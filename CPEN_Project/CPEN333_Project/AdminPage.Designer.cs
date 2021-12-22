namespace CPEN333_Project
{
    partial class AdminPage
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
            this.lbl_yourorders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warehouse_num = new System.Windows.Forms.TextBox();
            this.warehouse_length = new System.Windows.Forms.TextBox();
            this.warehouse_width = new System.Windows.Forms.TextBox();
            this.warehouse_numshelves = new System.Windows.Forms.TextBox();
            this.warehouse_shelfheight = new System.Windows.Forms.TextBox();
            this.warehouse_numrobots = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_customerwelcome
            // 
            this.lbl_customerwelcome.AutoSize = true;
            this.lbl_customerwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerwelcome.Location = new System.Drawing.Point(74, 60);
            this.lbl_customerwelcome.Name = "lbl_customerwelcome";
            this.lbl_customerwelcome.Size = new System.Drawing.Size(400, 55);
            this.lbl_customerwelcome.TabIndex = 2;
            this.lbl_customerwelcome.Text = "Welcome Admin!";
            this.lbl_customerwelcome.Click += new System.EventHandler(this.lbl_customerwelcome_Click);
            // 
            // lbl_yourorders
            // 
            this.lbl_yourorders.AutoSize = true;
            this.lbl_yourorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yourorders.Location = new System.Drawing.Point(77, 125);
            this.lbl_yourorders.Name = "lbl_yourorders";
            this.lbl_yourorders.Size = new System.Drawing.Size(577, 37);
            this.lbl_yourorders.TabIndex = 4;
            this.lbl_yourorders.Text = "Adjust the warehouse parameters here:";
            this.lbl_yourorders.Click += new System.EventHandler(this.lbl_yourorders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Warehouses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Warehouse Length";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Warehouse Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Shelves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height of Shelves";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Robots";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // warehouse_num
            // 
            this.warehouse_num.Location = new System.Drawing.Point(84, 182);
            this.warehouse_num.Name = "warehouse_num";
            this.warehouse_num.Size = new System.Drawing.Size(100, 31);
            this.warehouse_num.TabIndex = 11;
            this.warehouse_num.TextChanged += new System.EventHandler(this.warehouse_num_TextChanged);
            // 
            // warehouse_length
            // 
            this.warehouse_length.Location = new System.Drawing.Point(84, 253);
            this.warehouse_length.Name = "warehouse_length";
            this.warehouse_length.Size = new System.Drawing.Size(100, 31);
            this.warehouse_length.TabIndex = 12;
            // 
            // warehouse_width
            // 
            this.warehouse_width.Location = new System.Drawing.Point(84, 328);
            this.warehouse_width.Name = "warehouse_width";
            this.warehouse_width.Size = new System.Drawing.Size(100, 31);
            this.warehouse_width.TabIndex = 13;
            // 
            // warehouse_numshelves
            // 
            this.warehouse_numshelves.Location = new System.Drawing.Point(84, 400);
            this.warehouse_numshelves.Name = "warehouse_numshelves";
            this.warehouse_numshelves.Size = new System.Drawing.Size(100, 31);
            this.warehouse_numshelves.TabIndex = 14;
            // 
            // warehouse_shelfheight
            // 
            this.warehouse_shelfheight.Location = new System.Drawing.Point(84, 471);
            this.warehouse_shelfheight.Name = "warehouse_shelfheight";
            this.warehouse_shelfheight.Size = new System.Drawing.Size(100, 31);
            this.warehouse_shelfheight.TabIndex = 15;
            // 
            // warehouse_numrobots
            // 
            this.warehouse_numrobots.Location = new System.Drawing.Point(84, 539);
            this.warehouse_numrobots.Name = "warehouse_numrobots";
            this.warehouse_numrobots.Size = new System.Drawing.Size(100, 31);
            this.warehouse_numrobots.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 603);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Restock Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(660, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 59);
            this.button4.TabIndex = 20;
            this.button4.Text = "Refresh Parameters";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 674);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.warehouse_numrobots);
            this.Controls.Add(this.warehouse_shelfheight);
            this.Controls.Add(this.warehouse_numshelves);
            this.Controls.Add(this.warehouse_width);
            this.Controls.Add(this.warehouse_length);
            this.Controls.Add(this.warehouse_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_yourorders);
            this.Controls.Add(this.lbl_customerwelcome);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerwelcome;
        private System.Windows.Forms.Label lbl_yourorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox warehouse_num;
        private System.Windows.Forms.TextBox warehouse_length;
        private System.Windows.Forms.TextBox warehouse_width;
        private System.Windows.Forms.TextBox warehouse_numshelves;
        private System.Windows.Forms.TextBox warehouse_shelfheight;
        private System.Windows.Forms.TextBox warehouse_numrobots;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}