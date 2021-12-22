using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmazoomUI;
using CPEN333_Project;
using CPEN_Project;

namespace CPEN333_Project
{
    public partial class CustomerPage : Form
    {
        string customerID_passed;
        public CustomerPage(string customerID)
        {
            InitializeComponent();
            this.customerID_passed = customerID;
            customerid.Text = customerID_passed.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderPage CusToOrder = new OrderPage(customerID_passed);
            CusToOrder.Show();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPage CusToLogin = new LoginPage();
            CusToLogin.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<Label> productlist;
            productlist = new List<Label>();    

            productlist.Add(productlist_1);
            productlist.Add(productlist_2);
            productlist.Add(productlist_3);
            productlist.Add(productlist_4);
            productlist.Add(productlist_5);

            List<Label> pricelist;
            pricelist = new List<Label>();

            pricelist.Add(ordertotal_1);
            pricelist.Add(ordertotal_2);
            pricelist.Add(ordertotal_3);
            pricelist.Add(ordertotal_4);
            pricelist.Add(ordertotal_5);

            List<Label> idlist;
            idlist = new List<Label>();

            idlist.Add(orderid_1);
            idlist.Add(orderid_2);
            idlist.Add(orderid_3);
            idlist.Add(orderid_4);
            idlist.Add(orderid_5);

            List<Label> statuslist;
            statuslist = new List<Label>();

            statuslist.Add(orderstatus_1);
            statuslist.Add(orderstatus_2);
            statuslist.Add(orderstatus_3);
            statuslist.Add(orderstatus_4);
            statuslist.Add(orderstatus_5);

            foreach (List<string> order in Sim.orderList)
            {
                int i = Sim.orderList.IndexOf(order);
                productlist[i].Text = string.Join(", ", order);
                statuslist[i].Text = "Order Received!";
            }

            foreach (int price in Sim.priceList)
            {
                int i = Sim.priceList.IndexOf(price);
                pricelist[i].Text = "$" + price.ToString(); 
            }

            foreach (string orderID in Sim.idList)
            {
                int i = Sim.idList.IndexOf(orderID);
                idlist[i].Text = orderID;
            }

            int idx = 0;
            foreach (int status in Sim.statusList)  
            {
                statuslist[idx].Text = "Order Fulfilled!";
                idx++;
            }

            Sim.statusList.ForEach(Console.WriteLine);


        }

        private void orderstatus_1_Click(object sender, EventArgs e)
        {

        }
    }
}
