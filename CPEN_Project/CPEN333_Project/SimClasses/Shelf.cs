using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CPEN_Project
{
    public class Shelf
    {
        // FIELDS
        private Tuple<int, int> location; // specifies start location, assumed to be at the top
        private int length; // specifies length of shelf, assumed to extend down vertically from the location field
        private int height;
        private Dictionary<int, Tuple<int, int, int>> itemLocations; // matches item id to location on shelf x, y, height
        private Dictionary<Tuple<int, int, int>, Item> items; // matches location to item stored there
        private Queue<Tuple<int, int, int>> freeLocations;
        private bool hasSpace;
        private int number;
        private Mutex m;
        private bool busy;

        // PROPERTIES
        public Dictionary<int, Tuple<int, int, int>> itemLocation
        {
            get => itemLocations;
        }

        public bool Busy
        {
            get => busy;
            set => busy = value;
        }
        public bool HasSpace
        {
            get => hasSpace;
        }
        public int Number
        {
            get => number;
        }
        public Tuple<int, int> Location
        {
            get => location;
        }

        public Queue<Tuple<int, int, int>> FreeLocations
        {
            get => freeLocations;
        }

        public int Length
        {
            get => length;
        }

        public int Height
        {
            get => height;
        }

        // METHODS
        public void addItemToShelf(Item item, Tuple<int, int, int> location)
        {
            m.WaitOne();
            this.itemLocations.Add(item.ItemNumber, location);
            this.items.Add(location, item);
            m.ReleaseMutex();
            this.hasSpace = IsFull();
        }

        public Item removeItemFromShelf(Tuple<int, int, int> location)
        {
            m.WaitOne();
            Item orderItem = this.items[location];
            this.items.Remove(location);
            this.itemLocations.Remove(orderItem.ItemNumber);
            this.hasSpace = IsFull();
            m.ReleaseMutex();
            return orderItem;
        }

        private bool IsFull()
        {
            if (this.FreeLocations.Count == 0) return false;
            else return true;
        }

        // CONSTRUCTORS
        public Shelf(Tuple<int, int> location, int length, int height, int number)
        {
            this.location = location;
            this.length = length;
            this.height = height;
            this.hasSpace = true;
            this.freeLocations = new Queue<Tuple<int, int, int>>();
            this.itemLocations = new Dictionary<int, Tuple<int, int, int>>();
            this.items = new Dictionary<Tuple<int, int, int>, Item>();
            this.number = number;
            this.m = new Mutex();
            this.busy = false;


            for (int y = 0; y < this.length; y++)
            {
                for (int i = 0; i < this.height; i++)
                {
                    Tuple<int, int, int> nextLocation = new Tuple<int, int, int>(location.Item1, location.Item2+y, i);
                    freeLocations.Enqueue(nextLocation);
                }
            }
        }

    }

}
