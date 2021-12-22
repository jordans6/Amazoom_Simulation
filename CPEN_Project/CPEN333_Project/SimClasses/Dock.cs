using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace CPEN_Project
{
    public class Dock
    {
        // FIELDS
        protected bool isEmpty;
        protected bool truckPresent;
        protected Tuple<int, int> location; // x, y location
        public Mutex m;
        private Truck truck;
        private Queue<Truck> scheduledTrucks;
        private EventWaitHandle newTruckReady;
        private bool restocking;

        // PROPERTIES
        public bool Restocking
        {
            get => restocking;
        }
        public bool TruckPresent
        {
            get => truckPresent;
            set => truckPresent = value;
        }
        public bool IsEmpty
        {
            get => isEmpty;
            set => isEmpty = value;
        }

        public Tuple<int, int> Location
        {
            get => location;
        }

        public Truck Truck
        {
            get => truck;
        }

        public Queue<Truck> ScheduledTrucks
        {
            get => scheduledTrucks;
        }

        public EventWaitHandle NewTruckReady
        {
            get => newTruckReady;
        }

        // METHODS
        public void setTruck(Truck truck)
        {
            this.truck = truck;
            this.truckPresent = true;
            if (truck.GetType() == typeof(RestockingTruck)) this.restocking = true;
            else this.restocking = false;
        }

        public void ScheduleTruck(Truck truck)
        {
            this.scheduledTrucks.Enqueue(truck);
            this.newTruckReady.Set();
        }

        // CONSTRUCTOR
        public Dock(Tuple<int, int> location)
        {
            this.isEmpty = true;
            this.location = location;
            this.scheduledTrucks = new Queue<Truck>();
            this.m = new Mutex();
            this.truckPresent = false;
            this.newTruckReady = new EventWaitHandle(false, EventResetMode.AutoReset);
            this.restocking = false;
        }

    }
}
