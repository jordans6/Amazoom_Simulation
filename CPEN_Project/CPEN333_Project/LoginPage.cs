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
    public partial class LoginPage : Form
    {
        int admin_flag = 0;
        int customer_flag = 0;
        string customerID;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            admin_flag = 1;
        }

        private void btn_logincontinue_Click(object sender, EventArgs e)
        {
            if (admin_flag == 1) {
                AdminPage ChildAdmin = new AdminPage();
                ChildAdmin.Show();
            }
            if (customer_flag == 1) {
                CustomerPage ChildCustomer = new CustomerPage(customerID);
                ChildCustomer.Show();
            }
        }

        private void button_customercheck_CheckedChanged(object sender, EventArgs e)
        {
            customer_flag = 1;
        }

        private void customerid_TextChanged(object sender, EventArgs e)
        {
            customerID = customerid.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simulation Started");
            Sim.setCPU();
            Task t = Task.Run(() => Sim.startSim());
        }
    }
}
