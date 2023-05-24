namespace shop_management_system
{
    partial class login_form_admin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_page_label = new System.Windows.Forms.Label();
            this.admin_button_login_form = new FontAwesome.Sharp.IconButton();
            this.password_textbox_login_form = new System.Windows.Forms.TextBox();
            this.password_label_login_form = new System.Windows.Forms.Label();
            this.cnic_textbox_login_form = new System.Windows.Forms.TextBox();
            this.username_label_login_form = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.signup_label = new System.Windows.Forms.LinkLabel();
            this.login_customer_link_label = new System.Windows.Forms.LinkLabel();
            this.login_employee_link_label = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.login_page_label);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 435);
            this.panel1.TabIndex = 14;
            // 
            // login_page_label
            // 
            this.login_page_label.AutoSize = true;
            this.login_page_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_page_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_page_label.Location = new System.Drawing.Point(39, 183);
            this.login_page_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_page_label.Name = "login_page_label";
            this.login_page_label.Size = new System.Drawing.Size(58, 20);
            this.login_page_label.TabIndex = 5;
            this.login_page_label.Text = "Login";
            // 
            // admin_button_login_form
            // 
            this.admin_button_login_form.BackColor = System.Drawing.Color.Gainsboro;
            this.admin_button_login_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_button_login_form.IconChar = FontAwesome.Sharp.IconChar.None;
            this.admin_button_login_form.IconColor = System.Drawing.Color.Black;
            this.admin_button_login_form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admin_button_login_form.Location = new System.Drawing.Point(277, 231);
            this.admin_button_login_form.Margin = new System.Windows.Forms.Padding(2);
            this.admin_button_login_form.Name = "admin_button_login_form";
            this.admin_button_login_form.Size = new System.Drawing.Size(79, 33);
            this.admin_button_login_form.TabIndex = 20;
            this.admin_button_login_form.Text = "Login";
            this.admin_button_login_form.UseVisualStyleBackColor = false;
            this.admin_button_login_form.Click += new System.EventHandler(this.admin_button_login_form_Click);
            // 
            // password_textbox_login_form
            // 
            this.password_textbox_login_form.Location = new System.Drawing.Point(263, 184);
            this.password_textbox_login_form.Margin = new System.Windows.Forms.Padding(2);
            this.password_textbox_login_form.Name = "password_textbox_login_form";
            this.password_textbox_login_form.PasswordChar = '*';
            this.password_textbox_login_form.Size = new System.Drawing.Size(114, 20);
            this.password_textbox_login_form.TabIndex = 18;
            // 
            // password_label_login_form
            // 
            this.password_label_login_form.AutoSize = true;
            this.password_label_login_form.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label_login_form.Location = new System.Drawing.Point(175, 186);
            this.password_label_login_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label_login_form.Name = "password_label_login_form";
            this.password_label_login_form.Size = new System.Drawing.Size(68, 15);
            this.password_label_login_form.TabIndex = 17;
            this.password_label_login_form.Text = "Password";
            // 
            // cnic_textbox_login_form
            // 
            this.cnic_textbox_login_form.Location = new System.Drawing.Point(263, 125);
            this.cnic_textbox_login_form.Margin = new System.Windows.Forms.Padding(2);
            this.cnic_textbox_login_form.Name = "cnic_textbox_login_form";
            this.cnic_textbox_login_form.Size = new System.Drawing.Size(114, 20);
            this.cnic_textbox_login_form.TabIndex = 16;
            // 
            // username_label_login_form
            // 
            this.username_label_login_form.AutoSize = true;
            this.username_label_login_form.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label_login_form.Location = new System.Drawing.Point(175, 128);
            this.username_label_login_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label_login_form.Name = "username_label_login_form";
            this.username_label_login_form.Size = new System.Drawing.Size(44, 15);
            this.username_label_login_form.TabIndex = 15;
            this.username_label_login_form.Text = "CNIC";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 24;
            this.bunifuElipse1.TargetControl = this;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(268, 326);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 13);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signup_label.Location = new System.Drawing.Point(240, 295);
            this.signup_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(158, 13);
            this.signup_label.TabIndex = 21;
            this.signup_label.TabStop = true;
            this.signup_label.Text = "Don\'t have an account? Signup";
            this.signup_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login_customer_link_label
            // 
            this.login_customer_link_label.AutoSize = true;
            this.login_customer_link_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_customer_link_label.Location = new System.Drawing.Point(265, 408);
            this.login_customer_link_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_customer_link_label.Name = "login_customer_link_label";
            this.login_customer_link_label.Size = new System.Drawing.Size(94, 13);
            this.login_customer_link_label.TabIndex = 24;
            this.login_customer_link_label.TabStop = true;
            this.login_customer_link_label.Text = "Login as Customer";
            // 
            // login_employee_link_label
            // 
            this.login_employee_link_label.AutoSize = true;
            this.login_employee_link_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_employee_link_label.Location = new System.Drawing.Point(264, 384);
            this.login_employee_link_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_employee_link_label.Name = "login_employee_link_label";
            this.login_employee_link_label.Size = new System.Drawing.Size(96, 13);
            this.login_employee_link_label.TabIndex = 23;
            this.login_employee_link_label.TabStop = true;
            this.login_employee_link_label.Text = "Login as Employee";
            this.login_employee_link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_employee_link_label_LinkClicked);
            // 
            // login_form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 436);
            this.Controls.Add(this.login_customer_link_label);
            this.Controls.Add(this.login_employee_link_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admin_button_login_form);
            this.Controls.Add(this.password_textbox_login_form);
            this.Controls.Add(this.password_label_login_form);
            this.Controls.Add(this.cnic_textbox_login_form);
            this.Controls.Add(this.username_label_login_form);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.signup_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form_admin";
            this.Text = "login_form_admin";
            this.Load += new System.EventHandler(this.login_form_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_page_label;
        private FontAwesome.Sharp.IconButton admin_button_login_form;
        private System.Windows.Forms.TextBox password_textbox_login_form;
        private System.Windows.Forms.Label password_label_login_form;
        private System.Windows.Forms.TextBox cnic_textbox_login_form;
        private System.Windows.Forms.Label username_label_login_form;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel signup_label;
        private System.Windows.Forms.LinkLabel login_customer_link_label;
        private System.Windows.Forms.LinkLabel login_employee_link_label;
    }
}