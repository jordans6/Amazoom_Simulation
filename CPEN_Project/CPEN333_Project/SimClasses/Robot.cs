using System;
using System.Collections.Generic;
using System.Text;


namespace CPEN_Project
{
    public enum RobotStatus
    {
        WAITING = 0,
        DELIVERING = 1,
        RESTOCKING = 2,
    }

    public class Robot
    {
        // FIELDS
        private RobotStatus status; // lets CPU know if robot is available
        private int xPos; // current position of robot on warehouse grid
        private int yPos; // should we add exception for collision avoidance in each path or just update CPU everytime robot moves and let it handle collisions?)
        private int maxWeight;
        private int curWeight;
        private List<Item> heldItems; // lists held items 

        //PROPERTIES
        public List<Item> heldItemsRobot
        {
            get => heldItems;
        }

        public int XPos
        {
            get => xPos;
            set => xPos = value; //need a setter for pathfinding
        }

        public int YPos
        {
            get => yPos;
            set => yPos = value;
        }

        public int MaxWeight
        {
            get => maxWeight;
        }

        public int CurWeight
        {
            get => curWeight;
        }

        public RobotStatus Status
        {
            get => status;
            set => status = value;
        }
        
        //METHODS
        public Item getItemFromTruck(Dock dock)
        {
            while (!dock.TruckPresent) { }; // wait for truck

            Item item = dock.Truck.removeItem();
            this.heldItems.Add(item);
            return item;
        }
        

        public void PlaceItemOnShelf(Shelf shelf, Tuple<int, int, int> nextFreeLocation)
        {

            shelf.addItemToShelf(this.heldItems[0], nextFreeLocation);

            this.heldItems.RemoveAt(0);
        }

        public void getOrder(Shelf shelf, Tuple<int, int, int> location) 
        {

            Item item = shelf.removeItemFromShelf(location);

            this.heldItems.Add(item);
        }

        public bool dropItemAtTruck(Dock dock)
        {

            while(!dock.TruckPresent) { }; // wait for truck

            bool dropped = dock.Truck.fillUp(this.heldItems[0]);

            if(dropped)
            {
                this.heldItems.RemoveAt(0);
                this.xPos = -1;
                this.yPos = -1;
                return true;
            }
            return false;

            
        }

        // CONSTRUCTORS
        public Robot(int maxWeight)
        {
            this.status = RobotStatus.WAITING;
            this.xPos = -1;
            this.yPos = -1;
            this.maxWeight = maxWeight;
            this.curWeight = 0;
            this.heldItems = new List<Item>();
    }

    }

}
