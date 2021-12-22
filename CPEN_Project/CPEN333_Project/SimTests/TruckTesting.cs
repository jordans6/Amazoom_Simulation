using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics; 

namespace CPEN_Project
{
    class TruckTesting
    {
        static void Test()
        {

            //This tests the Truck class

            List<Tuple<Truck, Truck, List<Item>>> tests = new List<Tuple<Truck, Truck, List<Item>>>();
            DeliveryTruck deliveryTruck = new DeliveryTruck(10000);
            RestockingTruck restockingTruck = new RestockingTruck(10000);
            List<Item> items = new List<Item>();
            items.Add(new Item("test", 100, 5));

            tests.Add(new Tuple<Truck, Truck, List<Item>>(restockingTruck, deliveryTruck, items));


            TruckTester1(tests[0].Item1, tests[0].Item2, tests[0].Item3);


        }
        static void TruckTester1(Truck restockingTruck, Truck deliveryTruck, List<Item> items)
        {

            //testing fillUp method
            deliveryTruck.fillUp(items[0]);
            Debug.Assert(deliveryTruck.itemsFilled[0] == items[0]);

            //Check current weight
            Debug.Assert(deliveryTruck.curWeight == items[0].Weight);

            //testing fillupTruckItems method
            restockingTruck.fillUpTruckItems(items);
            Debug.Assert(restockingTruck.itemsFilled[0] == items[0]);

            //testing removeItem method
            Item testItem;
            testItem = restockingTruck.removeItem();
            Debug.Assert(testItem == items[0]);
  
        }
    }
}
