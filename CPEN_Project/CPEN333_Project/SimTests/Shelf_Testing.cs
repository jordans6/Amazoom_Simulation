using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CPEN_Project
{
    public class Shelf_Testing
    {
        static void Test()
        {

            //This tests the Shelf class 

            List<Tuple<Item, Shelf, Tuple<int, int, int>>> tests = new List<Tuple<Item, Shelf, Tuple<int, int, int>>>();
            Tuple<int, int> loc = new Tuple<int, int>(1, 1);
            Tuple<int, int, int> location = new Tuple<int, int, int>(1, 1, 1);
            Item item = new Item("Box", 100, 5);
            Shelf sh = new Shelf(loc, 1, 1, 1);

            tests.Add(new Tuple<Item, Shelf, Tuple<int, int, int>>(item, sh, location));

            ShelfTester1(tests[0].Item1, tests[0].Item2, tests[0].Item3);
         
            
        }

        static void ShelfTester1(Item item, Shelf shelf, Tuple<int, int, int> location)
        {

            //testing addItemTOShelf method
            shelf.addItemToShelf(item, location);
            Debug.Assert(shelf.itemLocation[item.ItemNumber] == location);

            //Testing removeItemFromShelf
            Item removedItem;
            removedItem = shelf.removeItemFromShelf(location);
            Debug.Assert(removedItem == item);
        }
    }

}
