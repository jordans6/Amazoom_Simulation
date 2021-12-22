using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CPEN_Project
{
    class RobotTesting
    {
        static void Test()
        {

            //This tests the Robot class

            List<Tuple<Truck, Dock, Robot, bool, Shelf, Tuple<int, int, int>>> tests = new List<Tuple<Truck, Dock, Robot, bool, Shelf, Tuple<int, int, int>>>();
            int width = 10;
            int length = 10;
            
            RestockingTruck restockingTruck = new RestockingTruck(10000);
            Tuple<int, int> d1 = new Tuple<int, int>(width / 2 - 1, length - 1);
            Dock dock = new Dock(d1);
            Robot robot = new Robot(1000);

            Tuple<int, int> loc = new Tuple<int, int>(1, 1);
            Tuple<int, int, int> location = new Tuple<int, int, int>(1, 1, 1);
            Shelf sh = new Shelf(loc, 1, 1, 1);

            tests.Add(new Tuple<Truck, Dock, Robot, bool, Shelf, Tuple<int, int, int>>(restockingTruck, dock, robot, true, sh, location));
   

            RobotTester1(tests[0].Item1, tests[0].Item2, tests[0].Item3, tests[0].Item4, tests[0].Item5, tests[0].Item6);
      
            
        }
        static void RobotTester1(Truck truck, Dock dock, Robot robot, bool result, Shelf shelf, Tuple<int, int, int> location)
        {

            //testing getItemFromTruck method
            dock.setTruck(truck);
            List<Item> items = new List<Item>();
            items.Add(new Item("test", 100, 5));
            truck.fillUpTruckItems(items);
            Item testItem;
            testItem = robot.getItemFromTruck(dock);
            Debug.Assert(testItem == items[0]);

            //Check items the robot is holding
            Debug.Assert(robot.heldItemsRobot[0].Name == items[0].Name);

            //testing PlaceItemOnShelf
            robot.PlaceItemOnShelf(shelf, location);
            Debug.Assert(shelf.itemLocation[items[0].ItemNumber] == location);

            //testing getOrder
            robot.getOrder(shelf, location);
            Debug.Assert(robot.heldItemsRobot[0].Name == items[0].Name);

            //testing dropItemAtTruck
            bool testResult = robot.dropItemAtTruck(dock);
            Debug.Assert(testResult =  result);

        }

    }
}
