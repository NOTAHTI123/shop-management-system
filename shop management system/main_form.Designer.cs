namespace shop_management_system
{
    partial class main_form
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.main_button_panel = new System.Windows.Forms.Panel();
            this.logout_button = new FontAwesome.Sharp.IconButton();
            this.employee_button = new FontAwesome.Sharp.IconButton();
            this.products_button = new FontAwesome.Sharp.IconButton();
            this.analytics_button = new FontAwesome.Sharp.IconButton();
            this.dashboard_button = new FontAwesome.Sharp.IconButton();
            this.customers_button = new FontAwesome.Sharp.IconButton();
            this.profile_button = new FontAwesome.Sharp.IconButton();
            this.top_panel = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.uc_panel = new System.Windows.Forms.Panel();
            this.admin_button = new FontAwesome.Sharp.IconButton();
            this.main_panel.SuspendLayout();
            this.main_button_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.main_panel.Controls.Add(this.main_button_panel);
            this.main_panel.Controls.Add(this.profile_button);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(220, 642);
            this.main_panel.TabIndex = 0;
            // 
            // main_button_panel
            // 
            this.main_button_panel.Controls.Add(this.admin_button);
            this.main_button_panel.Controls.Add(this.logout_button);
            this.main_button_panel.Controls.Add(this.employee_button);
            this.main_button_panel.Controls.Add(this.products_button);
            this.main_button_panel.Controls.Add(this.analytics_button);
            this.main_button_panel.Controls.Add(this.dashboard_button);
            this.main_button_panel.Controls.Add(this.customers_button);
            this.main_button_panel.Location = new System.Drawing.Point(12, 95);
            this.main_button_panel.Name = "main_button_panel";
            this.main_button_panel.Size = new System.Drawing.Size(184, 520);
            this.main_button_panel.TabIndex = 6;
            // 
            // logout_button
            // 
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_button.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.logout_button.IconColor = System.Drawing.Color.White;
            this.logout_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout_button.IconSize = 36;
            this.logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.Location = new System.Drawing.Point(3, 474);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(184, 38);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "Logout";
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // employee_button
            // 
            this.employee_button.FlatAppearance.BorderSize = 0;
            this.employee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employee_button.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.employee_button.IconColor = System.Drawing.Color.White;
            this.employee_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employee_button.IconSize = 36;
            this.employee_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_button.Location = new System.Drawing.Point(3, 146);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(184, 38);
            this.employee_button.TabIndex = 2;
            this.employee_button.Text = "Employees";
            this.employee_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // products_button
            // 
            this.products_button.FlatAppearance.BorderSize = 0;
            this.products_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products_button.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.products_button.IconColor = System.Drawing.Color.White;
            this.products_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.products_button.IconSize = 36;
            this.products_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_button.Location = new System.Drawing.Point(3, 261);
            this.products_button.Name = "products_button";
            this.products_button.Size = new System.Drawing.Size(184, 38);
            this.products_button.TabIndex = 4;
            this.products_button.Text = "Products";
            this.products_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.products_button.UseVisualStyleBackColor = true;
            this.products_button.Click += new System.EventHandler(this.products_button_Click_1);
            // 
            // analytics_button
            // 
            this.analytics_button.FlatAppearance.BorderSize = 0;
            this.analytics_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analytics_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.analytics_button.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.analytics_button.IconColor = System.Drawing.Color.White;
            this.analytics_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.analytics_button.IconSize = 36;
            this.analytics_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analytics_button.Location = new System.Drawing.Point(3, 89);
            this.analytics_button.Name = "analytics_button";
            this.analytics_button.Size = new System.Drawing.Size(184, 38);
            this.analytics_button.TabIndex = 1;
            this.analytics_button.Text = "Analytics";
            this.analytics_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analytics_button.UseVisualStyleBackColor = true;
            this.analytics_button.Click += new System.EventHandler(this.analytics_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.FlatAppearance.BorderSize = 0;
            this.dashboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_button.IconChar = FontAwesome.Sharp.IconChar.House;
            this.dashboard_button.IconColor = System.Drawing.Color.White;
            this.dashboard_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboard_button.IconSize = 36;
            this.dashboard_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_button.Location = new System.Drawing.Point(3, 33);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(184, 38);
            this.dashboard_button.TabIndex = 0;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // customers_button
            // 
            this.customers_button.FlatAppearance.BorderSize = 0;
            this.customers_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customers_button.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.customers_button.IconColor = System.Drawing.Color.White;
            this.customers_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customers_button.IconSize = 36;
            this.customers_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_button.Location = new System.Drawing.Point(3, 205);
            this.customers_button.Name = "customers_button";
            this.customers_button.Size = new System.Drawing.Size(184, 38);
            this.customers_button.TabIndex = 3;
            this.customers_button.Text = "Customers";
            this.customers_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customers_button.UseVisualStyleBackColor = true;
            this.customers_button.Click += new System.EventHandler(this.customers_button_Click_1);
            // 
            // profile_button
            // 
            this.profile_button.FlatAppearance.BorderSize = 0;
            this.profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profile_button.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.profile_button.IconColor = System.Drawing.Color.White;
            this.profile_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profile_button.IconSize = 36;
            this.profile_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_button.Location = new System.Drawing.Point(12, 12);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(171, 77);
            this.profile_button.TabIndex = 3;
            this.profile_button.Text = "*NAME*";
            this.profile_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Location = new System.Drawing.Point(220, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(962, 42);
            this.top_panel.TabIndex = 1;
            this.top_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.top_panel_Paint);
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.close_button.IconColor = System.Drawing.Color.Red;
            this.close_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_button.IconSize = 36;
            this.close_button.Location = new System.Drawing.Point(923, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(36, 37);
            this.close_button.TabIndex = 4;
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.cross_button_Click);
            // 
            // uc_panel
            // 
            this.uc_panel.Location = new System.Drawing.Point(220, 40);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(959, 602);
            this.uc_panel.TabIndex = 2;
            this.uc_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.uc_panel_Paint);
            // 
            // admin_button
            // 
            this.admin_button.FlatAppearance.BorderSize = 0;
            this.admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_button.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.admin_button.IconColor = System.Drawing.Color.White;
            this.admin_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admin_button.IconSize = 36;
            this.admin_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_button.Location = new System.Drawing.Point(3, 308);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(184, 38);
            this.admin_button.TabIndex = 6;
            this.admin_button.Text = "Admins";
            this.admin_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 641);
            this.Controls.Add(this.uc_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.main_panel.ResumeLayout(false);
            this.main_button_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel top_panel;
        private FontAwesome.Sharp.IconButton dashboard_button;
        private FontAwesome.Sharp.IconButton analytics_button;
        private FontAwesome.Sharp.IconButton employee_button;
        private FontAwesome.Sharp.IconButton customers_button;
        private FontAwesome.Sharp.IconButton profile_button;
        private FontAwesome.Sharp.IconButton products_button;
        private FontAwesome.Sharp.IconButton logout_button;
        private FontAwesome.Sharp.IconButton close_button;
        private System.Windows.Forms.Panel main_button_panel;
        private System.Windows.Forms.Panel uc_panel;
        private FontAwesome.Sharp.IconButton admin_button;
    }
}

