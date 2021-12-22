using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPEN_Project;

namespace CPEN333_Project
{
    public partial class RestockPage : Form
    {
        public static int nextNum = 100;
        public RestockPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int int_stock_laptop = 0, int_stock_smartphone = 0, int_stock_tablet = 0, int_stock_usbcable = 0, int_stock_headphones = 0,
            int_stock_monitor = 0, int_stock_phonecase = 0, int_stock_desktop = 0, int_stock_smartwatch = 0;

            foreach (CentralCPU cpu in Sim.myCPU)
            {
                int_stock_laptop += (cpu.getNumStock("laptop"));
                int_stock_smartphone += (cpu.getNumStock("smartphone"));
                int_stock_tablet += (cpu.getNumStock("tablet"));
                int_stock_headphones += (cpu.getNumStock("headphones"));
                int_stock_usbcable += (cpu.getNumStock("usb cable"));  
                int_stock_monitor += (cpu.getNumStock("monitor"));
                int_stock_phonecase += (cpu.getNumStock("phone case"));
                int_stock_desktop += (cpu.getNumStock("desktop"));
                int_stock_smartwatch += (cpu.getNumStock("smartwatch"));
            }

            stock_laptop.Text = int_stock_laptop.ToString();
            stock_smartphone.Text = int_stock_smartphone.ToString();
            stock_tablet.Text = int_stock_tablet.ToString();
            stock_headphones.Text = int_stock_headphones.ToString();
            stock_usbcable.Text = int_stock_usbcable.ToString();
            stock_monitor.Text = int_stock_monitor.ToString();
            stock_phonecase.Text = int_stock_phonecase.ToString();
            stock_desktop.Text = int_stock_desktop.ToString();
            stock_smartwatch.Text = int_stock_smartwatch.ToString();
        }

        private void restock_smartwatch_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_desktop_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_phonecase_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_monitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_usbcable_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_heaphones_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_tablet_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_smartphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void restock_laptop_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_smartwatch_Click(object sender, EventArgs e)
        {

        }

        private void stock_desktop_Click(object sender, EventArgs e)
        {

        }

        private void stock_phonecase_Click(object sender, EventArgs e)
        {

        }

        private void stock_monitor_Click(object sender, EventArgs e)
        {

        }

        private void stock_usbcable_Click(object sender, EventArgs e)
        {

        }

        private void stock_headphones_Click(object sender, EventArgs e)
        {

        }

        private void stock_tablet_Click(object sender, EventArgs e)
        {

        }

        private void stock_smartphone_Click(object sender, EventArgs e)
        {

        }

        private void stock_laptop_Click(object sender, EventArgs e)
        {

        }

        private void lbl_products_Click(object sender, EventArgs e)
        {

        }

        private void title_smartwatch_Click(object sender, EventArgs e)
        {

        }

        private void title_desktop_Click(object sender, EventArgs e)
        {

        }

        private void title_phonecase_Click(object sender, EventArgs e)
        {

        }

        private void title_monitor_Click(object sender, EventArgs e)
        {

        }

        private void title_usbcable_Click(object sender, EventArgs e)
        {

        }

        private void title_headphones_Click(object sender, EventArgs e)
        {

        }

        private void title_tablet_Click(object sender, EventArgs e)
        {

        }

        private void title_smartphone_Click(object sender, EventArgs e)
        {

        }

        private void title_laptop_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Item> restock = new List<Item>();

            int qty_laptop_parse, price_laptop_parse,
                qty_smartphone_parse, price_smartphone_parse,
                qty_tablet_parse, price_tablet_parse,
                qty_headphones_parse, price_headphones_parse,
                qty_usbcable_parse, price_usbcable_parse,
                qty_monitor_parse, price_monitor_parse,
                qty_phonecase_parse, price_phonecase_parse,
                qty_desktop_parse, price_desktop_parse,
                qty_smartwatch_parse, price_smartwatch_parse;

            int.TryParse(restock_laptop.Text, out qty_laptop_parse);

            int.TryParse(restock_smartphone.Text, out qty_smartphone_parse);

            int.TryParse(restock_tablet.Text, out qty_tablet_parse);

            int.TryParse(restock_headphones.Text, out qty_headphones_parse);

            int.TryParse(restock_usbcable.Text, out qty_usbcable_parse);

            int.TryParse(restock_monitor.Text, out qty_monitor_parse);

            int.TryParse(restock_phonecase.Text, out qty_phonecase_parse);

            int.TryParse(restock_desktop.Text, out qty_desktop_parse);

            int.TryParse(restock_smartwatch.Text, out qty_smartwatch_parse);

            for (int i = 0; i < qty_laptop_parse; i++)
            {
                string name = "laptop";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_smartphone_parse; i++)
            {
                
                string name = "smartphone";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_tablet_parse; i++)
            {
                string name = "tablet";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);


            }

            for (int i = 0; i < qty_headphones_parse; i++)
            {
                
                string name = "headphones";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_usbcable_parse; i++)
            {
                
                string name = "usb cable";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_monitor_parse; i++)
            {
             
                string name = "monitor";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_phonecase_parse; i++)
            {
                
                string name = "phone case";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_desktop_parse; i++)
            {
                
                string name = "desktop";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }

            for (int i = 0; i < qty_smartwatch_parse; i++)
            {
                
                string name = "smartwatch";
                int num = nextNum;
                nextNum++;
                int weight = 20;

                Item item = new Item(name, weight, num);

                restock.Add(item);

            }
            MessageBox.Show("Restock Request Received!");
            RestockingTruck rTruck = new RestockingTruck(Sim.TRUCK_MAX_WEIGHT);
            int truckNum = Int32.Parse(restock_warehouse.Text);
            rTruck.fillUpTruckItems(restock);

            Sim.ScheduleTruck(rTruck, truckNum);


        }

        private void btn_backrestock_Click(object sender, EventArgs e)
        {
            AdminPage AdminChild = new AdminPage();
            AdminChild.Show();
        }
    }
}
