using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CPEN_Project
{
    public class DockTesting
    {
        static void Test()
        {
            

           //This tests the dock class 

           List<Tuple<Truck, Dock, bool>> tests = new List<Tuple<Truck, Dock, bool>>();
           int width = 10;
           int length = 10;
           DeliveryTruck deliveryTruck = new DeliveryTruck(10000);
           RestockingTruck restockingTruck = new RestockingTruck(10000);
           Tuple<int, int> d1 = new Tuple<int, int>(width / 2 - 1, length - 1);
           Dock dock = new Dock(d1);

           tests.Add(new Tuple<Truck, Dock, bool>(deliveryTruck, dock, false));
           tests.Add(new Tuple<Truck, Dock, bool>(restockingTruck, dock, true));

           int count = tests.Count;
           int i = 0;



           //testing setTruck method

           while (i < count)
           {
               DockTester1(tests[i].Item1, tests[i].Item2, tests[i].Item3);
               i++;
           }
            i = 0;

            List<Tuple<Truck, Truck, Truck, Dock>> tests2 = new List<Tuple<Truck, Truck, Truck, Dock>>();

            DeliveryTruck Truck1 = new DeliveryTruck(10000);
            RestockingTruck Truck2 = new RestockingTruck(10000);
            RestockingTruck Truck3 = new RestockingTruck(10000);
            tests2.Add(new Tuple<Truck, Truck, Truck, Dock>(Truck1, Truck2, Truck3, dock));
            tests2.Add(new Tuple<Truck, Truck, Truck, Dock>(Truck1, Truck2, Truck3, dock));

            //testing ScheduleTruck method
            while (i < count)
                {
                    DockTester2(tests2[i].Item1, tests2[i].Item2, tests2[i].Item3, tests2[i].Item4);
                    i++;
                }

        }


        static void DockTester1(Truck truck, Dock dock, bool result) { 

            //testing setTruck method
            dock.setTruck(truck);
            Debug.Assert(dock.Restocking == result);

    }

        static void DockTester2(Truck truck1, Truck truck2, Truck truck3, Dock dock)
        {

            //testing ScheduleTruck method
            dock.ScheduleTruck(truck1);
            dock.ScheduleTruck(truck2);
            dock.ScheduleTruck(truck3);

            Debug.Assert(dock.ScheduledTrucks.Dequeue() == truck1);

            Debug.Assert(dock.ScheduledTrucks.Dequeue() == truck2);

            Debug.Assert(dock.ScheduledTrucks.Dequeue() == truck3);

        }
    }

}
