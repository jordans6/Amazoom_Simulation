using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;


namespace CPEN_Project
{
    public enum OrderStatus
    {
        WAITING = 0,
        FULFILLING = 1,
        FINISHED = 2,
    }
    public class CentralCPU
    {
        // FIELDS
        private Dictionary<String, int> itemInventory;
        private Dictionary<String, Queue<Tuple<int, int, int, int>>> itemLocations; // location value corresponds to width, length, shelf number, and height on shelf
        private Dictionary<int, Item> orderKeyToItem;
        private Dictionary<int, OrderStatus> orderStatus;
        public Queue<String> orderQueue;
        private Queue<int> ordersReceived; // give each order its own unique key
        private WareHouseLayout layout; // some object or struct to keep track of warehouse layout, could maybe use primitives
        private int NextOrderNumber;
        private Mutex m;
        private EventWaitHandle robotReady;
        private EventWaitHandle shelfSpace;
        public int trucksDone;
        public bool restockTruckPresent;

        // PROPERTIES
        public Dictionary<String, int> ItemInventory
        {
            get => itemInventory;
        }

        public WareHouseLayout Layout
        {
            get => layout;
        }

        // METHODS
        private bool checkItem(string item)
        {
            if (itemInventory[item] > 0) return true;

            return false;
        }

        //This method is for testing purposes
        public void addItem(Item item)
        {
            this.itemInventory.Add(item.Name, 1);
        }

        public OrderStatus GetOrderStatus(int orderNumber)
        {
            return orderStatus[orderNumber];
        }

        public int getNextOrderNumber()
        {
            int curNumber = NextOrderNumber;
            NextOrderNumber++;

            return curNumber;
        }

        public int getNumStock(string item)
        {
            bool hasKey;

            m.WaitOne();
            if (itemInventory.ContainsKey(item)) hasKey = true;
            else hasKey = false;
            m.ReleaseMutex();

            if (hasKey) return itemInventory[item];
            else return 0;
        }

        public void alert()
        {
            foreach (KeyValuePair<string, int> entry in itemInventory)
            {
                if (entry.Value <= 3)
                {
                    Console.WriteLine($"{entry.Key} is low in stock");
                }
            }
        }

        public void updateInventory(String item)
        {
            m.WaitOne();
            this.itemInventory[item]--;
            if (this.ItemInventory[item] == 0) this.ItemInventory.Remove(item);
            m.ReleaseMutex();
        }

        public void printInventory()
        {
            foreach (KeyValuePair<String, int> kvp in this.ItemInventory)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        public void scheduleTruck(Truck truck)
        {
            Dock myDock;
            this.m.WaitOne();

            if (truck.GetType() == typeof(DeliveryTruck)) myDock = this.Layout.Docks[0];
            else myDock = this.Layout.Docks[1];

            if (truck.GetType() == typeof(RestockingTruck)) this.restockTruckPresent = true;

            if (myDock.TruckPresent)
            {
                myDock.ScheduleTruck(truck);
            }
            else
            {
                myDock.setTruck(truck);
                myDock.TruckPresent = true;
            }
            this.m.ReleaseMutex();
        }

        public void setTruckDone(int dockNumber)
        {
            this.Layout.Docks[dockNumber].Truck.Done = true;
            if (dockNumber == 1) this.restockTruckPresent = false;
        }

        public bool restockPresent()
        {
            bool ans;
            m.WaitOne();
            ans = this.restockTruckPresent;
            m.ReleaseMutex();

            return ans;
        }

        
        public void handleOrder(String item)
        {
            Console.WriteLine("Delivery Started");
            Robot rb = new Robot(1);
            bool notReady = true;
            while (notReady)
            {
                foreach (Robot r in this.layout.Robots)
                {
                    m.WaitOne();
                    if (r.Status == RobotStatus.WAITING)
                    {
                        rb = r;
                        rb.Status = RobotStatus.DELIVERING;
                        notReady = false;
                    }
                    m.ReleaseMutex();
                    if (!notReady) break;
                    
                    if(robotReady.WaitOne()) 
                    {
                        Console.WriteLine("Robot Ready");
                    }
                }
            }

            m.WaitOne();
            Tuple<int, int, int, int> nextLoc = this.itemLocations[item].Dequeue();
            Tuple<int, int, int> itemLoc = new Tuple<int, int, int>(nextLoc.Item2, nextLoc.Item3, nextLoc.Item4);

            m.ReleaseMutex();

            Shelf sh = this.layout.Shelves[nextLoc.Item1];

            Tuple<int, int> d_loc = new Tuple<int, int>(-1, -1);
            Dock thisDock = this.Layout.Docks[0];
            notReady = true;
            while(notReady)
            {
                thisDock.m.WaitOne();
                if (thisDock.IsEmpty)
                {
                    thisDock.IsEmpty = false;
                    notReady = false;
                }
                thisDock.m.ReleaseMutex();
                if (!notReady) break;
                
            }

            EventWaitHandle waiting = thisDock.NewTruckReady;
            notReady = true; 
            if(thisDock.Truck.Done)
            {
                while (notReady)
                {
                    if (thisDock.ScheduledTrucks.Count > 0)
                    {
                        Truck next_truck = thisDock.ScheduledTrucks.Dequeue();
                        thisDock.setTruck(next_truck);
                        notReady = false;
                    }
                    else
                    {
                        if (waiting.WaitOne())
                        {
                            Console.WriteLine("Signal Triggered");
                        }
                    }
                }
            }

            //pathfindXthenY(itemLoc.Item1 + 1, itemLoc.Item2, rb);////////////////////////////////////////////////////
            if (pathfindXthenY(itemLoc.Item1 + 1, itemLoc.Item2, rb))
            {
                rb.getOrder(sh, itemLoc);
            }

            pathfindYthenX(thisDock.Location.Item1, thisDock.Location.Item1 - 1, rb);

            m.WaitOne();
            if (rb.dropItemAtTruck(thisDock))
            {
                this.robotReady.Set();
            }
            rb.Status = RobotStatus.WAITING;
            thisDock.IsEmpty = true;
            m.ReleaseMutex();

            pathfindXthenY(0, 1, rb);
            ReturntoChargingArea(rb);
            
            Console.WriteLine("Order Fulfilled!");
        }
        

        public void handleRestock()
        {
            Console.WriteLine("Handling Restock");
            Robot rb = new Robot(1);
            bool notReady = true;
            while(notReady)
            {
                foreach(Robot r in this.layout.Robots)
                {
                    m.WaitOne();
                    if(r.Status == RobotStatus.WAITING)
                    {
                        rb = r;
                        rb.Status = RobotStatus.RESTOCKING;
                        notReady = false;
                    }
                    m.ReleaseMutex();
                    if (!notReady) break;

                    if (robotReady.WaitOne())
                    {
                        Console.WriteLine("Robot Ready");
                    }
                }
            }

           
            Dock thisDock = this.Layout.Docks[1];
            notReady = true;
            while (notReady)
            {
                thisDock.m.WaitOne();
                if (thisDock.IsEmpty)
                {
                    thisDock.IsEmpty = false;
                    notReady = false;
                }
                thisDock.m.ReleaseMutex();
                if (!notReady) break;
                
            }

            Console.WriteLine("Got restock dock");
            EventWaitHandle waiting = thisDock.NewTruckReady;
            notReady = true;
            if (thisDock.Truck.Done)
            {
                while (notReady)
                {
                    if (thisDock.ScheduledTrucks.Count > 0)
                    {
                        Truck next_truck = thisDock.ScheduledTrucks.Dequeue();
                        thisDock.setTruck(next_truck);
                        this.restockTruckPresent = true;
                        notReady = false;
                    }
                    else
                    {
                    
                    if (waiting.WaitOne())
                        {
                            Console.WriteLine("Signal Triggered");
                         }
                    }   
                }
            }
            
                    Random rand = new Random();
            int random = rand.Next(6, Layout.Width);
            int columnSelect;
            if (random%2 == 0) { // selects random column to go down to reach target dock
                columnSelect = random;
            }else
            {
                columnSelect = random / 2 - 1;
            }

            pathfindXthenY(columnSelect, thisDock.Location.Item2 - 2, rb);  //from top take random path to bottom of shelf in row
            pathfindYthenX(thisDock.Location.Item1, thisDock.Location.Item2 - 1, rb); //moves to bottom row and then along to target dock
            Item item = rb.getItemFromTruck(thisDock);
            pathfindXthenY(0, 1, rb);
            ReturntoChargingArea(rb);

            notReady = true;
            Tuple<int, int> loc = new Tuple<int, int>(1, 1);
            Shelf sh = new Shelf(loc, 1, 1, 1);
            while (notReady)
            {
                foreach (Shelf s in this.layout.Shelves.Values)
                {
                    m.WaitOne();
                    if (s.HasSpace == true)
                    {
                        sh = s;
                        notReady = false;
                    }
                    m.ReleaseMutex();
                    if (!notReady) break;
                }
                if (!notReady) break;
                if (this.shelfSpace.WaitOne())
                {
                    
                }
                
            }

            m.WaitOne();
            Tuple<int, int, int> nextFreeLocation = sh.FreeLocations.Dequeue();
            m.ReleaseMutex();

            pathfindXthenY(nextFreeLocation.Item2 + 1, nextFreeLocation.Item3, rb);
            rb.PlaceItemOnShelf(sh, nextFreeLocation);
            pathfindYthenX(0, thisDock.Location.Item2 - 1, rb);
            pathfindXthenY(0, 1, rb);
            ReturntoChargingArea(rb);
            
            m.WaitOne();

            if (this.itemInventory.ContainsKey(item.Name))
            {
                this.itemInventory[item.Name]++; 
            }
            else
            {
                this.itemInventory.Add(item.Name, 1);   
            }
            m.ReleaseMutex();

            Tuple<int, int, int, int> itemLocation = new Tuple<int, int, int, int>(sh.Number, nextFreeLocation.Item1, nextFreeLocation.Item2, nextFreeLocation.Item3);
            
            m.WaitOne();
            if (this.itemLocations.ContainsKey(item.Name))
            {
                this.itemLocations[item.Name].Enqueue(itemLocation);
            }
            else
            {
                Queue<Tuple<int, int, int, int>> locs = new Queue<Tuple<int, int, int, int>>();
                locs.Enqueue(itemLocation);
                this.itemLocations.Add(item.Name, locs);
            }

            if (thisDock.Truck.Done) this.restockTruckPresent = false;

            this.trucksDone++;
            rb.Status = RobotStatus.WAITING;
            this.robotReady.Set();
            sh.Busy = false; 
            thisDock.IsEmpty = true;
            foreach (Shelf s in this.layout.Shelves.Values)
            {
                if(s.HasSpace)
                {
                    this.shelfSpace.Set();
                    break; 
                }
            }

            m.ReleaseMutex();
            Console.WriteLine("Done Restock");
        }

        public bool pathfindXthenY(int xPosTarget, int yPosTarget, Robot rb) //for charging area to shelf OR dock to charging area
        {
            //Robot rb = new Robot(1);

            if (rb.XPos < xPosTarget)
            {
                m.WaitOne();

                while (rb.XPos < xPosTarget)
                {
                    rb.XPos++;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }
            else if (rb.XPos > xPosTarget)
            {
                m.WaitOne();
                while (rb.XPos > xPosTarget)
                {
                    rb.XPos--;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }


            if (rb.YPos < yPosTarget) //should change to mutex every column individually instead of all columns
            {
                m.WaitOne();
                while (rb.YPos < yPosTarget)
                {
                    rb.YPos++;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }
            else if (rb.YPos > yPosTarget)
            {
                m.WaitOne();
                while (rb.YPos > yPosTarget)
                {
                    rb.YPos--;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }

            return true;
        }

        public void pathfindYthenX(int xPosTarget, int yPosTarget, Robot rb) //for leaving shelf to go to dock
        {

            if (rb.YPos < yPosTarget)
            {
                m.WaitOne();
                while (rb.YPos < yPosTarget)
                {
                    rb.YPos++;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }
            else if (rb.YPos > yPosTarget)
            {
                m.WaitOne();
                while (rb.YPos > yPosTarget)
                {
                    rb.YPos--;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }

            //if (rb.XPos < xPosTarget)
            ////{

            //    while (rb.XPos < xPosTarget) //
            //    {
            //        rb.XPos++;
            //        Thread.Sleep(50);

            //    }

            //}
            //else
            if (rb.XPos > xPosTarget)
            {
                m.WaitOne();
                while (rb.XPos > xPosTarget) //
                {
                    rb.XPos--;
                    Thread.Sleep(5);
                }
                m.ReleaseMutex();
            }
        }

        public void ReturntoChargingArea(Robot rb)  //move back to charging area after cycle completed
        {
            rb.XPos = -1;
            rb.YPos = 0;
        }
        
        // CONSTRUCTORS
        public CentralCPU(WareHouseLayout layout)
        {
            this.itemInventory = new Dictionary<String, int>();
            this.itemLocations = new Dictionary<String, Queue<Tuple<int, int, int, int>>>();
            this.orderKeyToItem = new Dictionary<int, Item>();
            this.orderStatus = new Dictionary<int, OrderStatus>();
            this.ordersReceived = new Queue<int>();
            this.layout = layout;
            this.NextOrderNumber = 0;
            this.m = new Mutex();
            this.robotReady = new EventWaitHandle(false, EventResetMode.AutoReset);
            this.shelfSpace = new EventWaitHandle(false, EventResetMode.AutoReset);
            this.trucksDone = 0;
            this.restockTruckPresent = false;
            this.orderQueue = new Queue<String>();
        }
    }
}

