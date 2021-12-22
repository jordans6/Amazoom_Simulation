using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;


namespace CPEN_Project
{
    public class Truck
    {
        // FIELDS
        public bool busy;
        protected int maxWeight;
        public int curWeight;
        protected List<Item> items;
        protected int nextItem;
        protected Mutex m;
        protected bool done;

        public virtual bool fillUp(Item item)
        {
            Console.WriteLine("Parent Truck Class Fill Up");
            return true;
        }

        public virtual Item removeItem()
        {
            Console.WriteLine("Parent Truck Class Take Out");
            return new Item("Test", 1, -1);
        }

        public virtual void fillUpTruckItems(List<Item> items)
        {
            Console.WriteLine("Parent Class Fillup Up Items in Truck");
        }

        public bool Done
        {
            get => done;
            set => done = value;
        }

        public List<Item> itemsFilled
        {
            get => items;
        }

        public int Items
        {
            get => items.Count;
        }

    }
    
    public class RestockingTruck : Truck
    {
        public override Item removeItem()
        {
            m.WaitOne();
            Console.WriteLine("{0}", this.nextItem);
            Item item = this.items[this.nextItem];
            curWeight -= item.Weight;
            this.nextItem++;
            
            if(this.nextItem >= this.items.Count)
            {
                this.done = true;
            }
            m.ReleaseMutex();

            return item;
        }

        public override void fillUpTruckItems(List<Item> items)
        {
            this.items = items;
        }

        public RestockingTruck(int maxWeight)
        {
            this.busy = false;
            this.done = false;
            this.maxWeight = maxWeight;
            this.curWeight = 0;
            this.items = new List<Item>();
            this.m = new Mutex();
            this.nextItem = 0;
        }
    }
    

    public class DeliveryTruck : Truck
    {

        // METHODS
        public override bool fillUp(Item item)
        {
            bool filled = false;
            m.WaitOne();
            if (curWeight + item.Weight <= maxWeight)
            {
                curWeight += item.Weight;
                this.items.Add(item);
                filled = true;

                if (this.curWeight == this.maxWeight) this.done = true;
            }
            m.ReleaseMutex();

            return filled;
        }

        // CONSTRUCTORS
        public DeliveryTruck(int maxWeight)
        {
            this.busy = false;
            this.done = false;
            this.maxWeight = maxWeight;
            this.curWeight = 0;
            this.items = new List<Item>();
            this.m = new Mutex();
        }
    }

}

