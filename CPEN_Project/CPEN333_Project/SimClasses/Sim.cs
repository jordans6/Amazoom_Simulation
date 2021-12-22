using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace CPEN_Project
{
    class Sim
    {
        public static int LAYOUT_LENGTH = 10;
        public static int LAYOUT_WIDTH = 10;
        public static int NUM_SHELVES = 4;
        public static int SHELF_HEIGHT = 3;
        public static int NUM_ROBOTS = 4;
        public static int MAX_ROBOT_WEIGHT = 100;
        public static int TRUCK_MAX_WEIGHT = 100;
        public static int NUM_WAREHOUSES = 1;
        static string[] ITEM_NAMES = { "laptop", "smartphone", "tablet", "headphones", "usb cable", "monitor", "phone case", "desktop", "smartwatch" };

        public static List<CentralCPU> myCPU; 

        private static Mutex m;
        static Queue<String> orderQueue;
        public static List<List<String>> orderList;
        public static List<int> priceList;
        public static List<string> idList;
        public static List<int> statusList;
        public static int total;

        static Sim()
        {
            myCPU = new List<CentralCPU>();
            orderQueue = new Queue<String>();
            m = new Mutex();
            orderList = new List<List<string>>();
            priceList = new List<int>();
            idList = new List<string>();
            statusList = new List<int>();
            total = 0;
        }
        public static void setLayout(int length, int width, int numRobots, int numShelves, int shelfHeight, int numWarehouses)
        {
            Sim.LAYOUT_LENGTH = length;
            Sim.LAYOUT_WIDTH = width;
            Sim.NUM_ROBOTS = numRobots;
            Sim.NUM_SHELVES = numShelves;
            Sim.SHELF_HEIGHT = shelfHeight;
            Sim.NUM_WAREHOUSES = numWarehouses;
        }

        public static void setCPU()
        {
            for(int i = 0; i < Sim.NUM_WAREHOUSES; i++)
            {
                WareHouseLayout layout = new WareHouseLayout(Sim.LAYOUT_LENGTH, Sim.LAYOUT_WIDTH, Sim.NUM_ROBOTS, Sim.NUM_SHELVES, Sim.SHELF_HEIGHT);
                CentralCPU cpu = new CentralCPU(layout);
                Robot tempRobot;
                for (int r = 0; r < NUM_ROBOTS; r++)
                {
                    tempRobot = new Robot(MAX_ROBOT_WEIGHT);
                    layout.addRobot(tempRobot);
                }

                Sim.myCPU.Add(cpu);
            }
            
        }

        public static void TestMethod()
        {
            Console.WriteLine("This is working");
        }

        public static void addToQueue(List<String> items, int price, string orderID)
        {
            Console.WriteLine("Added to Queue");
            orderList.Add(items);
            priceList.Add(price);
            idList.Add(orderID);
            total += items.Count;

            m.WaitOne();
            Console.WriteLine("In Mutex");
            foreach(String s in items)
            {
                orderQueue.Enqueue(s);
            }
            m.ReleaseMutex();
        }

        public static void ScheduleTruck(Truck truck, int cpuNum)
        {
            Thread.Sleep(1000);
            Sim.myCPU[cpuNum].scheduleTruck(truck);
        }
        public static void waitForPool()
        {
            int max, max2;
            ThreadPool.GetMaxThreads(out max, out max2);
            int available, available2;
            ThreadPool.GetAvailableThreads(out available, out available2);
            int running = max - available;

            while (running > 0)
            {
                ThreadPool.GetMaxThreads(out max, out max2);
                ThreadPool.GetAvailableThreads(out available, out available2);
                running = max - available;
            }
        }

        public static void restock(CentralCPU cpu)
        {
            var tasks = new List<Task>();
            for (int j = 0; j < cpu.Layout.Docks[1].Truck.Items; j++)
            {
                Thread.Sleep(100);
                Task thr = Task.Run(() => cpu.handleRestock());
                tasks.Add(thr);
            }
            Task.WaitAll(tasks.ToArray());
        }

        public static void startSim()
        {
            int loop = 0;
            int order_flag = 0;
            int num_orders = 0;
            Console.WriteLine("{0}", Sim.NUM_WAREHOUSES); 
            while (true)
            {
                Thread.Sleep(700);
                if (loop % 10 == 0)
                {
                    foreach (CentralCPU cpu in Sim.myCPU)
                    {
                        DeliveryTruck temp = new DeliveryTruck(TRUCK_MAX_WEIGHT);
                        cpu.scheduleTruck(temp);
                    }
                }
                loop++;

                foreach (CentralCPU cpu in Sim.myCPU)
                {
                    if (cpu.restockPresent())
                    {
                        Console.WriteLine("Halt orders, we're restocking");
                        Sim.restock(cpu);
                    }
                }
                  
                if (Sim.orderQueue.Count > 0)
                {
                    num_orders += 1;
                    order_flag = 1;
                    String nextOrder = Sim.orderQueue.Dequeue();
                    foreach(CentralCPU cpu in Sim.myCPU)
                    {
                        if (cpu.getNumStock(nextOrder) > 0)
                        {
                            cpu.updateInventory(nextOrder);
                            Task t = Task.Run(() => cpu.handleOrder(nextOrder));

                            cpu.printInventory();
                            break;
                        }
                        else Console.WriteLine("Out of Stock Sorry!");
                    }
                    
                }

                if ((num_orders == Sim.total) && (order_flag == 1))
                {
                    Sim.statusList.Add(1);
                    order_flag = 0;
                }
            }
        }
    }
}

