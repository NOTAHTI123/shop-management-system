namespace shop_management_system
{
    partial class employee_form
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
            this.main_button_panel = new System.Windows.Forms.Panel();
            this.logout_button = new FontAwesome.Sharp.IconButton();
            this.billing_button = new FontAwesome.Sharp.IconButton();
            this.profile_button = new FontAwesome.Sharp.IconButton();
            this.uc_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.main_button_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_button_panel
            // 
            this.main_button_panel.Controls.Add(this.logout_button);
            this.main_button_panel.Controls.Add(this.billing_button);
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
            // billing_button
            // 
            this.billing_button.FlatAppearance.BorderSize = 0;
            this.billing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billing_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billing_button.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.billing_button.IconColor = System.Drawing.Color.White;
            this.billing_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.billing_button.IconSize = 36;
            this.billing_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billing_button.Location = new System.Drawing.Point(0, 0);
            this.billing_button.Name = "billing_button";
            this.billing_button.Size = new System.Drawing.Size(184, 38);
            this.billing_button.TabIndex = 4;
            this.billing_button.Text = "Billing";
            this.billing_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.billing_button.UseVisualStyleBackColor = true;
            this.billing_button.Click += new System.EventHandler(this.products_button_Click);
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
            // uc_panel
            // 
            this.uc_panel.Location = new System.Drawing.Point(218, 39);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(959, 602);
            this.uc_panel.TabIndex = 5;
            this.uc_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.uc_panel_Paint);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Location = new System.Drawing.Point(208, -1);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(972, 42);
            this.top_panel.TabIndex = 4;
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
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.main_panel.Controls.Add(this.main_button_panel);
            this.main_panel.Controls.Add(this.profile_button);
            this.main_panel.Location = new System.Drawing.Point(-2, -1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(220, 642);
            this.main_panel.TabIndex = 3;
            // 
            // employee_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 641);
            this.Controls.Add(this.uc_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee_form";
            this.Text = "employee_form";
            this.main_button_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_button_panel;
        private FontAwesome.Sharp.IconButton logout_button;
        private FontAwesome.Sharp.IconButton billing_button;
        private FontAwesome.Sharp.IconButton profile_button;
        private System.Windows.Forms.Panel uc_panel;
        private System.Windows.Forms.Panel top_panel;
        private FontAwesome.Sharp.IconButton close_button;
        private System.Windows.Forms.Panel main_panel;
    }
}