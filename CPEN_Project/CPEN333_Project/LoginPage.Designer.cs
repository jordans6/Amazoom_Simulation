namespace CPEN333_Project
{
    partial class LoginPage
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.button_admincheck = new System.Windows.Forms.CheckBox();
            this.button_customercheck = new System.Windows.Forms.CheckBox();
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.TextBox();
            this.btn_logincontinue = new System.Windows.Forms.Button();
            this.btn_startsim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(46, 70);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(539, 55);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to Amazoom!";
            this.lbl_welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.Location = new System.Drawing.Point(56, 129);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(543, 37);
            this.lbl_select.TabIndex = 1;
            this.lbl_select.Text = "Select from one of the options below:";
            // 
            // button_admincheck
            // 
            this.button_admincheck.AutoSize = true;
            this.button_admincheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_admincheck.Location = new System.Drawing.Point(63, 203);
            this.button_admincheck.Name = "button_admincheck";
            this.button_admincheck.Size = new System.Drawing.Size(232, 37);
            this.button_admincheck.TabIndex = 2;
            this.button_admincheck.Text = "I am an admin";
            this.button_admincheck.UseVisualStyleBackColor = true;
            this.button_admincheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_customercheck
            // 
            this.button_customercheck.AutoSize = true;
            this.button_customercheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customercheck.Location = new System.Drawing.Point(63, 273);
            this.button_customercheck.Name = "button_customercheck";
            this.button_customercheck.Size = new System.Drawing.Size(257, 37);
            this.button_customercheck.TabIndex = 3;
            this.button_customercheck.Text = "I am a customer";
            this.button_customercheck.UseVisualStyleBackColor = true;
            this.button_customercheck.CheckedChanged += new System.EventHandler(this.button_customercheck_CheckedChanged);
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.Location = new System.Drawing.Point(57, 333);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(187, 33);
            this.lbl_customerid.TabIndex = 4;
            this.lbl_customerid.Text = "Customer ID:";
            // 
            // customerid
            // 
            this.customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.Location = new System.Drawing.Point(63, 370);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(257, 38);
            this.customerid.TabIndex = 5;
            this.customerid.TextChanged += new System.EventHandler(this.customerid_TextChanged);
            // 
            // btn_logincontinue
            // 
            this.btn_logincontinue.Location = new System.Drawing.Point(63, 434);
            this.btn_logincontinue.Name = "btn_logincontinue";
            this.btn_logincontinue.Size = new System.Drawing.Size(127, 44);
            this.btn_logincontinue.TabIndex = 6;
            this.btn_logincontinue.Text = "Continue";
            this.btn_logincontinue.UseVisualStyleBackColor = true;
            this.btn_logincontinue.Click += new System.EventHandler(this.btn_logincontinue_Click);
            // 
            // btn_startsim
            // 
            this.btn_startsim.Location = new System.Drawing.Point(22, 12);
            this.btn_startsim.Name = "btn_startsim";
            this.btn_startsim.Size = new System.Drawing.Size(121, 38);
            this.btn_startsim.TabIndex = 7;
            this.btn_startsim.Text = "Start";
            this.btn_startsim.UseVisualStyleBackColor = true;
            this.btn_startsim.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 528);
            this.Controls.Add(this.btn_startsim);
            this.Controls.Add(this.btn_logincontinue);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.lbl_customerid);
            this.Controls.Add(this.button_customercheck);
            this.Controls.Add(this.button_admincheck);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.CheckBox button_admincheck;
        private System.Windows.Forms.CheckBox button_customercheck;
        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.Button btn_logincontinue;
        private System.Windows.Forms.Button btn_startsim;
    }
}

