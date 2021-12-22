namespace CPEN333_Project
{
    partial class CustomerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_customerwelcome = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.Label();
            this.lbl_yourorders = new System.Windows.Forms.Label();
            this.lbl_orderid = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.lbl_ordertotal = new System.Windows.Forms.Label();
            this.lbl_orderstatus = new System.Windows.Forms.Label();
            this.orderid_1 = new System.Windows.Forms.Label();
            this.productlist_1 = new System.Windows.Forms.Label();
            this.ordertotal_1 = new System.Windows.Forms.Label();
            this.orderstatus_1 = new System.Windows.Forms.Label();
            this.orderstatus_2 = new System.Windows.Forms.Label();
            this.ordertotal_2 = new System.Windows.Forms.Label();
            this.productlist_2 = new System.Windows.Forms.Label();
            this.orderid_2 = new System.Windows.Forms.Label();
            this.orderstatus_3 = new System.Windows.Forms.Label();
            this.ordertotal_3 = new System.Windows.Forms.Label();
            this.productlist_3 = new System.Windows.Forms.Label();
            this.orderid_3 = new System.Windows.Forms.Label();
            this.orderstatus_4 = new System.Windows.Forms.Label();
            this.ordertotal_4 = new System.Windows.Forms.Label();
            this.productlist_4 = new System.Windows.Forms.Label();
            this.orderid_4 = new System.Windows.Forms.Label();
            this.orderstatus_5 = new System.Windows.Forms.Label();
            this.ordertotal_5 = new System.Windows.Forms.Label();
            this.productlist_5 = new System.Windows.Forms.Label();
            this.orderid_5 = new System.Windows.Forms.Label();
            this.btn_ordermore = new System.Windows.Forms.Button();
            this.btn_loginback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_customerwelcome
            // 
            this.lbl_customerwelcome.AutoSize = true;
            this.lbl_customerwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerwelcome.Location = new System.Drawing.Point(89, 84);
            this.lbl_customerwelcome.Name = "lbl_customerwelcome";
            this.lbl_customerwelcome.Size = new System.Drawing.Size(465, 55);
            this.lbl_customerwelcome.TabIndex = 1;
            this.lbl_customerwelcome.Text = "Welcome customer:";
            this.lbl_customerwelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerid
            // 
            this.customerid.AutoSize = true;
            this.customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.Location = new System.Drawing.Point(542, 86);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(74, 55);
            this.customerid.TabIndex = 2;
            this.customerid.Text = "ID";
            this.customerid.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_yourorders
            // 
            this.lbl_yourorders.AutoSize = true;
            this.lbl_yourorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yourorders.Location = new System.Drawing.Point(92, 155);
            this.lbl_yourorders.Name = "lbl_yourorders";
            this.lbl_yourorders.Size = new System.Drawing.Size(202, 37);
            this.lbl_yourorders.TabIndex = 3;
            this.lbl_yourorders.Text = "Your Orders:";
            this.lbl_yourorders.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_orderid
            // 
            this.lbl_orderid.AutoSize = true;
            this.lbl_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderid.Location = new System.Drawing.Point(96, 213);
            this.lbl_orderid.Name = "lbl_orderid";
            this.lbl_orderid.Size = new System.Drawing.Size(111, 31);
            this.lbl_orderid.TabIndex = 4;
            this.lbl_orderid.Text = "OrderID";
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products.Location = new System.Drawing.Point(308, 213);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(122, 31);
            this.lbl_products.TabIndex = 5;
            this.lbl_products.Text = "Products";
            // 
            // lbl_ordertotal
            // 
            this.lbl_ordertotal.AutoSize = true;
            this.lbl_ordertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordertotal.Location = new System.Drawing.Point(779, 213);
            this.lbl_ordertotal.Name = "lbl_ordertotal";
            this.lbl_ordertotal.Size = new System.Drawing.Size(151, 31);
            this.lbl_ordertotal.TabIndex = 6;
            this.lbl_ordertotal.Text = "Order Total";
            // 
            // lbl_orderstatus
            // 
            this.lbl_orderstatus.AutoSize = true;
            this.lbl_orderstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderstatus.Location = new System.Drawing.Point(1029, 213);
            this.lbl_orderstatus.Name = "lbl_orderstatus";
            this.lbl_orderstatus.Size = new System.Drawing.Size(168, 31);
            this.lbl_orderstatus.TabIndex = 7;
            this.lbl_orderstatus.Text = "Order Status";
            // 
            // orderid_1
            // 
            this.orderid_1.AutoSize = true;
            this.orderid_1.Location = new System.Drawing.Point(97, 273);
            this.orderid_1.Name = "orderid_1";
            this.orderid_1.Size = new System.Drawing.Size(0, 25);
            this.orderid_1.TabIndex = 8;
            // 
            // productlist_1
            // 
            this.productlist_1.AutoSize = true;
            this.productlist_1.Location = new System.Drawing.Point(309, 273);
            this.productlist_1.MaximumSize = new System.Drawing.Size(450, 300);
            this.productlist_1.Name = "productlist_1";
            this.productlist_1.Size = new System.Drawing.Size(0, 25);
            this.productlist_1.TabIndex = 9;
            // 
            // ordertotal_1
            // 
            this.ordertotal_1.AutoSize = true;
            this.ordertotal_1.Location = new System.Drawing.Point(789, 282);
            this.ordertotal_1.Name = "ordertotal_1";
            this.ordertotal_1.Size = new System.Drawing.Size(0, 25);
            this.ordertotal_1.TabIndex = 10;
            // 
            // orderstatus_1
            // 
            this.orderstatus_1.AutoSize = true;
            this.orderstatus_1.Location = new System.Drawing.Point(1030, 273);
            this.orderstatus_1.Name = "orderstatus_1";
            this.orderstatus_1.Size = new System.Drawing.Size(0, 25);
            this.orderstatus_1.TabIndex = 11;
            this.orderstatus_1.Click += new System.EventHandler(this.orderstatus_1_Click);
            // 
            // orderstatus_2
            // 
            this.orderstatus_2.AutoSize = true;
            this.orderstatus_2.Location = new System.Drawing.Point(1030, 348);
            this.orderstatus_2.Name = "orderstatus_2";
            this.orderstatus_2.Size = new System.Drawing.Size(0, 25);
            this.orderstatus_2.TabIndex = 15;
            // 
            // ordertotal_2
            // 
            this.ordertotal_2.AutoSize = true;
            this.ordertotal_2.Location = new System.Drawing.Point(789, 357);
            this.ordertotal_2.Name = "ordertotal_2";
            this.ordertotal_2.Size = new System.Drawing.Size(0, 25);
            this.ordertotal_2.TabIndex = 14;
            // 
            // productlist_2
            // 
            this.productlist_2.AutoSize = true;
            this.productlist_2.Location = new System.Drawing.Point(309, 348);
            this.productlist_2.MaximumSize = new System.Drawing.Size(450, 300);
            this.productlist_2.Name = "productlist_2";
            this.productlist_2.Size = new System.Drawing.Size(0, 25);
            this.productlist_2.TabIndex = 13;
            // 
            // orderid_2
            // 
            this.orderid_2.AutoSize = true;
            this.orderid_2.Location = new System.Drawing.Point(97, 348);
            this.orderid_2.Name = "orderid_2";
            this.orderid_2.Size = new System.Drawing.Size(0, 25);
            this.orderid_2.TabIndex = 12;
            // 
            // orderstatus_3
            // 
            this.orderstatus_3.AutoSize = true;
            this.orderstatus_3.Location = new System.Drawing.Point(1030, 427);
            this.orderstatus_3.Name = "orderstatus_3";
            this.orderstatus_3.Size = new System.Drawing.Size(0, 25);
            this.orderstatus_3.TabIndex = 19;
            // 
            // ordertotal_3
            // 
            this.ordertotal_3.AutoSize = true;
            this.ordertotal_3.Location = new System.Drawing.Point(789, 436);
            this.ordertotal_3.Name = "ordertotal_3";
            this.ordertotal_3.Size = new System.Drawing.Size(0, 25);
            this.ordertotal_3.TabIndex = 18;
            // 
            // productlist_3
            // 
            this.productlist_3.AutoSize = true;
            this.productlist_3.Location = new System.Drawing.Point(309, 427);
            this.productlist_3.MaximumSize = new System.Drawing.Size(450, 300);
            this.productlist_3.Name = "productlist_3";
            this.productlist_3.Size = new System.Drawing.Size(0, 25);
            this.productlist_3.TabIndex = 17;
            // 
            // orderid_3
            // 
            this.orderid_3.AutoSize = true;
            this.orderid_3.Location = new System.Drawing.Point(97, 427);
            this.orderid_3.Name = "orderid_3";
            this.orderid_3.Size = new System.Drawing.Size(0, 25);
            this.orderid_3.TabIndex = 16;
            // 
            // orderstatus_4
            // 
            this.orderstatus_4.AutoSize = true;
            this.orderstatus_4.Location = new System.Drawing.Point(1030, 509);
            this.orderstatus_4.Name = "orderstatus_4";
            this.orderstatus_4.Size = new System.Drawing.Size(0, 25);
            this.orderstatus_4.TabIndex = 23;
            // 
            // ordertotal_4
            // 
            this.ordertotal_4.AutoSize = true;
            this.ordertotal_4.Location = new System.Drawing.Point(789, 518);
            this.ordertotal_4.Name = "ordertotal_4";
            this.ordertotal_4.Size = new System.Drawing.Size(0, 25);
            this.ordertotal_4.TabIndex = 22;
            // 
            // productlist_4
            // 
            this.productlist_4.AutoSize = true;
            this.productlist_4.Location = new System.Drawing.Point(309, 509);
            this.productlist_4.MaximumSize = new System.Drawing.Size(450, 300);
            this.productlist_4.Name = "productlist_4";
            this.productlist_4.Size = new System.Drawing.Size(0, 25);
            this.productlist_4.TabIndex = 21;
            // 
            // orderid_4
            // 
            this.orderid_4.AutoSize = true;
            this.orderid_4.Location = new System.Drawing.Point(97, 509);
            this.orderid_4.Name = "orderid_4";
            this.orderid_4.Size = new System.Drawing.Size(0, 25);
            this.orderid_4.TabIndex = 20;
            // 
            // orderstatus_5
            // 
            this.orderstatus_5.AutoSize = true;
            this.orderstatus_5.Location = new System.Drawing.Point(1030, 597);
            this.orderstatus_5.Name = "orderstatus_5";
            this.orderstatus_5.Size = new System.Drawing.Size(0, 25);
            this.orderstatus_5.TabIndex = 27;
            // 
            // ordertotal_5
            // 
            this.ordertotal_5.AutoSize = true;
            this.ordertotal_5.Location = new System.Drawing.Point(789, 596);
            this.ordertotal_5.Name = "ordertotal_5";
            this.ordertotal_5.Size = new System.Drawing.Size(0, 25);
            this.ordertotal_5.TabIndex = 26;
            // 
            // productlist_5
            // 
            this.productlist_5.AutoSize = true;
            this.productlist_5.Location = new System.Drawing.Point(309, 597);
            this.productlist_5.MaximumSize = new System.Drawing.Size(450, 300);
            this.productlist_5.Name = "productlist_5";
            this.productlist_5.Size = new System.Drawing.Size(0, 25);
            this.productlist_5.TabIndex = 25;
            // 
            // orderid_5
            // 
            this.orderid_5.AutoSize = true;
            this.orderid_5.Location = new System.Drawing.Point(97, 597);
            this.orderid_5.Name = "orderid_5";
            this.orderid_5.Size = new System.Drawing.Size(0, 25);
            this.orderid_5.TabIndex = 24;
            // 
            // btn_ordermore
            // 
            this.btn_ordermore.Location = new System.Drawing.Point(99, 655);
            this.btn_ordermore.Name = "btn_ordermore";
            this.btn_ordermore.Size = new System.Drawing.Size(195, 42);
            this.btn_ordermore.TabIndex = 28;
            this.btn_ordermore.Text = "Order More";
            this.btn_ordermore.UseVisualStyleBackColor = true;
            this.btn_ordermore.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_loginback
            // 
            this.btn_loginback.Location = new System.Drawing.Point(13, 13);
            this.btn_loginback.Name = "btn_loginback";
            this.btn_loginback.Size = new System.Drawing.Size(123, 46);
            this.btn_loginback.TabIndex = 29;
            this.btn_loginback.Text = "Back";
            this.btn_loginback.UseVisualStyleBackColor = true;
            this.btn_loginback.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 785);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_loginback);
            this.Controls.Add(this.btn_ordermore);
            this.Controls.Add(this.orderstatus_5);
            this.Controls.Add(this.ordertotal_5);
            this.Controls.Add(this.productlist_5);
            this.Controls.Add(this.orderid_5);
            this.Controls.Add(this.orderstatus_4);
            this.Controls.Add(this.ordertotal_4);
            this.Controls.Add(this.productlist_4);
            this.Controls.Add(this.orderid_4);
            this.Controls.Add(this.orderstatus_3);
            this.Controls.Add(this.ordertotal_3);
            this.Controls.Add(this.productlist_3);
            this.Controls.Add(this.orderid_3);
            this.Controls.Add(this.orderstatus_2);
            this.Controls.Add(this.ordertotal_2);
            this.Controls.Add(this.productlist_2);
            this.Controls.Add(this.orderid_2);
            this.Controls.Add(this.orderstatus_1);
            this.Controls.Add(this.ordertotal_1);
            this.Controls.Add(this.productlist_1);
            this.Controls.Add(this.orderid_1);
            this.Controls.Add(this.lbl_orderstatus);
            this.Controls.Add(this.lbl_ordertotal);
            this.Controls.Add(this.lbl_products);
            this.Controls.Add(this.lbl_orderid);
            this.Controls.Add(this.lbl_yourorders);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.lbl_customerwelcome);
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerwelcome;
        private System.Windows.Forms.Label customerid;
        private System.Windows.Forms.Label lbl_yourorders;
        private System.Windows.Forms.Label lbl_orderid;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label lbl_ordertotal;
        private System.Windows.Forms.Label lbl_orderstatus;
        private System.Windows.Forms.Label orderid_1;
        private System.Windows.Forms.Label productlist_1;
        private System.Windows.Forms.Label ordertotal_1;
        private System.Windows.Forms.Label orderstatus_1;
        private System.Windows.Forms.Label orderstatus_2;
        private System.Windows.Forms.Label ordertotal_2;
        private System.Windows.Forms.Label productlist_2;
        private System.Windows.Forms.Label orderid_2;
        private System.Windows.Forms.Label orderstatus_3;
        private System.Windows.Forms.Label ordertotal_3;
        private System.Windows.Forms.Label productlist_3;
        private System.Windows.Forms.Label orderid_3;
        private System.Windows.Forms.Label orderstatus_4;
        private System.Windows.Forms.Label ordertotal_4;
        private System.Windows.Forms.Label productlist_4;
        private System.Windows.Forms.Label orderid_4;
        private System.Windows.Forms.Label orderstatus_5;
        private System.Windows.Forms.Label ordertotal_5;
        private System.Windows.Forms.Label productlist_5;
        private System.Windows.Forms.Label orderid_5;
        private System.Windows.Forms.Button btn_ordermore;
        private System.Windows.Forms.Button btn_loginback;
        private System.Windows.Forms.Button button1;
    }
}