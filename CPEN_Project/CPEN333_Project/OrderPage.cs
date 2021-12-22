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
using CPEN333_Project;

namespace AmazoomUI
{
    public partial class OrderPage : Form
    {
        string customerID_passed; 

        public OrderPage(string customerID)
        {
            InitializeComponent();
            this.customerID_passed = customerID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void desc_tablet_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void desc_headphones_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void Start_butoon_Click(object sender, EventArgs e)
        {
           CustomerPage ChildCustomer = new CustomerPage(customerID_passed);
           ChildCustomer.Show();
        }

        private void qty_laptop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void label2_Click_4(object sender, EventArgs e)
        {

        }

        private void label2_Click_5(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty_laptop_parse, price_laptop_parse,
                qty_smartphone_parse, price_smartphone_parse,
                qty_tablet_parse, price_tablet_parse,
                qty_headphones_parse, price_headphones_parse,
                qty_usbcable_parse, price_usbcable_parse,
                qty_monitor_parse, price_monitor_parse,
                qty_phonecase_parse, price_phonecase_parse,
                qty_desktop_parse, price_desktop_parse,
                qty_smartwatch_parse, price_smartwatch_parse;

            int.TryParse(qty_laptop.Text, out qty_laptop_parse);
            int.TryParse(price_laptop.Text, out price_laptop_parse);

            int.TryParse(qty_smartphone.Text, out qty_smartphone_parse);
            int.TryParse(price_smartphone.Text, out price_smartphone_parse);

            int.TryParse(qty_tablet.Text, out qty_tablet_parse);
            int.TryParse(price_tablet.Text, out price_tablet_parse);

            int.TryParse(qty_headphones.Text, out qty_headphones_parse);
            int.TryParse(price_headphones.Text, out price_headphones_parse);

            int.TryParse(qty_usbcable.Text, out qty_usbcable_parse);
            int.TryParse(price_usbcable.Text, out price_usbcable_parse);

            int.TryParse(qty_monitor.Text, out qty_monitor_parse);
            int.TryParse(price_monitor.Text, out price_monitor_parse);

            int.TryParse(qty_phonecase.Text, out qty_phonecase_parse);
            int.TryParse(price_phonecase.Text, out price_phonecase_parse);

            int.TryParse(qty_desktop.Text, out qty_desktop_parse);
            int.TryParse(price_desktop.Text, out price_desktop_parse);

            int.TryParse(qty_smartwatch.Text, out qty_smartwatch_parse);
            int.TryParse(price_smartwatch.Text, out price_smartwatch_parse);

            lbl_carttotal.Text = (qty_laptop_parse * price_laptop_parse +
                                  qty_smartphone_parse * price_smartphone_parse +
                                  qty_tablet_parse * price_tablet_parse +
                                  qty_headphones_parse * price_headphones_parse +
                                  qty_usbcable_parse * price_usbcable_parse +
                                  qty_monitor_parse * price_monitor_parse +
                                  qty_phonecase_parse * price_phonecase_parse +
                                  qty_desktop_parse * price_desktop_parse +
                                  qty_smartwatch_parse * price_smartwatch_parse
                                 ).ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            List<string> order = new List<string>();

            int qty_laptop_parse, price_laptop_parse,
                qty_smartphone_parse, price_smartphone_parse,
                qty_tablet_parse, price_tablet_parse,
                qty_headphones_parse, price_headphones_parse,
                qty_usbcable_parse, price_usbcable_parse,
                qty_monitor_parse, price_monitor_parse,
                qty_phonecase_parse, price_phonecase_parse,
                qty_desktop_parse, price_desktop_parse,
                qty_smartwatch_parse, price_smartwatch_parse;

            int price;

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

            int.TryParse(qty_laptop.Text, out qty_laptop_parse);
            int.TryParse(price_laptop.Text, out price_laptop_parse);

            int.TryParse(qty_smartphone.Text, out qty_smartphone_parse);
            int.TryParse(price_smartphone.Text, out price_smartphone_parse);

            int.TryParse(qty_tablet.Text, out qty_tablet_parse);
            int.TryParse(price_tablet.Text, out price_tablet_parse);

            int.TryParse(qty_headphones.Text, out qty_headphones_parse);
            int.TryParse(price_headphones.Text, out price_headphones_parse);

            int.TryParse(qty_usbcable.Text, out qty_usbcable_parse);
            int.TryParse(price_usbcable.Text, out price_usbcable_parse);

            int.TryParse(qty_monitor.Text, out qty_monitor_parse);
            int.TryParse(price_monitor.Text, out price_monitor_parse);

            int.TryParse(qty_phonecase.Text, out qty_phonecase_parse);
            int.TryParse(price_phonecase.Text, out price_phonecase_parse);

            int.TryParse(qty_desktop.Text, out qty_desktop_parse);
            int.TryParse(price_desktop.Text, out price_desktop_parse);

            int.TryParse(qty_smartwatch.Text, out qty_smartwatch_parse);
            int.TryParse(price_smartwatch.Text, out price_smartwatch_parse);

            if ((int_stock_laptop < qty_laptop_parse) ||
                (int_stock_smartphone < qty_smartphone_parse) ||
                (int_stock_tablet < qty_tablet_parse) ||
                (int_stock_headphones < qty_headphones_parse) ||
                (int_stock_usbcable < qty_usbcable_parse) ||
                (int_stock_monitor < qty_monitor_parse) ||
                (int_stock_phonecase < qty_phonecase_parse) ||
                (int_stock_desktop < qty_desktop_parse) ||
                (int_stock_smartwatch < qty_smartwatch_parse)) {

                MessageBox.Show("Out of stock sorry!");
            }

            else
            {
                for (int i = 0; i < qty_laptop_parse; i++)
                {
                order.Add("laptop");
                }

                for (int i = 0; i < qty_smartphone_parse; i++)
                {
                    order.Add("smartphone");
                }

                for (int i = 0; i < qty_tablet_parse; i++)
                {
                    order.Add("tablet");
                }

                for (int i = 0; i < qty_headphones_parse; i++)
                {
                    order.Add("headphones");
                }

                for (int i = 0; i < qty_usbcable_parse; i++)
                {
                    order.Add("usb cable");
                }

                for (int i = 0; i < qty_monitor_parse; i++)
                {
                    order.Add("monitor");
                }

                for (int i = 0; i < qty_phonecase_parse; i++)
                {
                    order.Add("phone case");
                }

                for (int i = 0; i < qty_desktop_parse; i++)
                {
                    order.Add("desktop");
                }

                for (int i = 0; i < qty_smartwatch_parse; i++)
                {
                    order.Add("smartwatch");
                }
                price = (qty_laptop_parse * price_laptop_parse +
                                      qty_smartphone_parse * price_smartphone_parse +
                                      qty_tablet_parse * price_tablet_parse +
                                      qty_headphones_parse * price_headphones_parse +
                                      qty_usbcable_parse * price_usbcable_parse +
                                      qty_monitor_parse * price_monitor_parse +
                                      qty_phonecase_parse * price_phonecase_parse +
                                      qty_desktop_parse * price_desktop_parse +
                                      qty_smartwatch_parse * price_smartwatch_parse
                                     );

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var stringChars = new char[5];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                string orderID = new String(stringChars);

                MessageBox.Show("Order Received!");
                Task t = Task.Run(() => Sim.addToQueue(order, price, orderID));
            }
        }

        private void qty_phonecase_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
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
    }
}
