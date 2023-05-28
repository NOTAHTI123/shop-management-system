namespace shop_management_system
{
    partial class customer_form
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
            this.profile_button = new FontAwesome.Sharp.IconButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.main_button_panel = new System.Windows.Forms.Panel();
            this.logout_button = new FontAwesome.Sharp.IconButton();
            this.dashboard_button = new FontAwesome.Sharp.IconButton();
            this.uc_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.main_panel.SuspendLayout();
            this.main_button_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
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
            this.profile_button.Location = new System.Drawing.Point(9, 10);
            this.profile_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(128, 63);
            this.profile_button.TabIndex = 3;
            this.profile_button.Text = "*NAME*";
            this.profile_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.main_panel.Controls.Add(this.main_button_panel);
            this.main_panel.Controls.Add(this.profile_button);
            this.main_panel.Location = new System.Drawing.Point(-2, -1);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(165, 522);
            this.main_panel.TabIndex = 3;
            // 
            // main_button_panel
            // 
            this.main_button_panel.Controls.Add(this.logout_button);
            this.main_button_panel.Controls.Add(this.dashboard_button);
            this.main_button_panel.Location = new System.Drawing.Point(9, 77);
            this.main_button_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_button_panel.Name = "main_button_panel";
            this.main_button_panel.Size = new System.Drawing.Size(138, 422);
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
            this.logout_button.Location = new System.Drawing.Point(2, 385);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(138, 31);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "Logout";
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
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
            this.dashboard_button.Location = new System.Drawing.Point(2, 27);
            this.dashboard_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(138, 31);
            this.dashboard_button.TabIndex = 0;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // uc_panel
            // 
            this.uc_panel.Location = new System.Drawing.Point(164, 32);
            this.uc_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(719, 489);
            this.uc_panel.TabIndex = 5;
            this.uc_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.uc_panel_Paint);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Location = new System.Drawing.Point(163, -1);
            this.top_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(722, 34);
            this.top_panel.TabIndex = 4;
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
            this.close_button.Location = new System.Drawing.Point(692, 2);
            this.close_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(27, 30);
            this.close_button.TabIndex = 4;
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_button.UseVisualStyleBackColor = true;
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.uc_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "customer_form";
            this.Text = "customer_form";
            this.Load += new System.EventHandler(this.customer_form_Load);
            this.main_panel.ResumeLayout(false);
            this.main_button_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton profile_button;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel main_button_panel;
        private FontAwesome.Sharp.IconButton logout_button;
        private FontAwesome.Sharp.IconButton dashboard_button;
        private System.Windows.Forms.Panel uc_panel;
        private System.Windows.Forms.Panel top_panel;
        private FontAwesome.Sharp.IconButton close_button;
    }
}