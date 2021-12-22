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
    public partial class AdminPage : Form
    {

        public AdminPage()
        {
            InitializeComponent();
        }

        private void lbl_customerwelcome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_yourorders_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestockPage RestockChild = new RestockPage();
            RestockChild.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parameters Updated");
            Sim.setLayout(int.Parse(warehouse_length.Text), int.Parse(warehouse_width.Text), int.Parse(warehouse_numrobots.Text), int.Parse(warehouse_numshelves.Text), int.Parse(warehouse_shelfheight.Text), int.Parse(warehouse_num.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginPage LoginChild = new LoginPage();
            LoginChild.Show();  
        }

        private void warehouse_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            warehouse_length.Text = Sim.LAYOUT_LENGTH.ToString();
            warehouse_width.Text = Sim.LAYOUT_WIDTH.ToString();
            warehouse_numrobots.Text = Sim.NUM_ROBOTS.ToString();
            warehouse_numshelves.Text = Sim.NUM_SHELVES.ToString();
            warehouse_shelfheight.Text = Sim.SHELF_HEIGHT.ToString();
            warehouse_num.Text = Sim.NUM_WAREHOUSES.ToString();
        }
    }
}