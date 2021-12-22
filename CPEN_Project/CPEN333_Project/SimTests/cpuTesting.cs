using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace CPEN_Project
{
    class cpuTesting
    {
        static void Test()
        {
            WareHouseLayout layout = new WareHouseLayout(100, 100, 1, 1, 10);
            CentralCPU cpu = new CentralCPU(layout);
           

            List<Tuple< CentralCPU,  Item>> tests = new List<Tuple<CentralCPU, Item>>();
   
            Item item = new Item("test", 100, 5);


            tests.Add(new Tuple<CentralCPU, Item>(cpu, item));


            cpuTester1(tests[0].Item1, tests[0].Item2);
        }
        static void cpuTester1(CentralCPU cpu, Item item)
        {

            //Check number of items in stock
            cpu.addItem(item);
            Debug.Assert(cpu.getNumStock(item.Name) == 1);

            //Should be a low amount of items in stock. Check this.
            cpu.alert();

            //print out the inventory to check
            cpu.printInventory();

            //update item inventory by removing item
            cpu.updateInventory(item.Name);
            Debug.Assert(cpu.getNumStock(item.Name) == 0);

        }
    }
}
