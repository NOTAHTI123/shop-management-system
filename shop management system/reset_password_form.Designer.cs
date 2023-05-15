namespace shop_management_system
{
    partial class reset_password_form
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cnic_label = new System.Windows.Forms.Label();
            this.cnic_value_label = new System.Windows.Forms.Label();
            this.verification_code_text_box = new System.Windows.Forms.TextBox();
            this.verification_code_label = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.update_button = new System.Windows.Forms.Button();
            this.re_enter_password_text_box = new System.Windows.Forms.TextBox();
            this.re_enter_password_label = new System.Windows.Forms.Label();
            this.new_password_text_box = new System.Windows.Forms.TextBox();
            this.new_password_label = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.login_page_label);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 539);
            this.panel1.TabIndex = 4;
            // 
            // login_page_label
            // 
            this.login_page_label.AutoSize = true;
            this.login_page_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_page_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_page_label.Location = new System.Drawing.Point(52, 226);
            this.login_page_label.Name = "login_page_label";
            this.login_page_label.Size = new System.Drawing.Size(73, 26);
            this.login_page_label.TabIndex = 5;
            this.login_page_label.Text = "Reset";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 24;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cnic_label
            // 
            this.cnic_label.AutoSize = true;
            this.cnic_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic_label.Location = new System.Drawing.Point(263, 91);
            this.cnic_label.Name = "cnic_label";
            this.cnic_label.Size = new System.Drawing.Size(68, 18);
            this.cnic_label.TabIndex = 9;
            this.cnic_label.Text = "CNIC : ";
            // 
            // cnic_value_label
            // 
            this.cnic_value_label.AutoSize = true;
            this.cnic_value_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic_value_label.Location = new System.Drawing.Point(362, 91);
            this.cnic_value_label.Name = "cnic_value_label";
            this.cnic_value_label.Size = new System.Drawing.Size(18, 18);
            this.cnic_value_label.TabIndex = 10;
            this.cnic_value_label.Text = "*";
            // 
            // verification_code_text_box
            // 
            this.verification_code_text_box.Location = new System.Drawing.Point(212, 58);
            this.verification_code_text_box.Name = "verification_code_text_box";
            this.verification_code_text_box.Size = new System.Drawing.Size(150, 22);
            this.verification_code_text_box.TabIndex = 12;
            // 
            // verification_code_label
            // 
            this.verification_code_label.AutoSize = true;
            this.verification_code_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verification_code_label.Location = new System.Drawing.Point(-3, 62);
            this.verification_code_label.Name = "verification_code_label";
            this.verification_code_label.Size = new System.Drawing.Size(168, 18);
            this.verification_code_label.TabIndex = 11;
            this.verification_code_label.Text = "Verification Code : ";
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(238, 97);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(83, 28);
            this.confirm_button.TabIndex = 17;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.update_button);
            this.gb1.Controls.Add(this.re_enter_password_text_box);
            this.gb1.Controls.Add(this.re_enter_password_label);
            this.gb1.Controls.Add(this.new_password_text_box);
            this.gb1.Controls.Add(this.new_password_label);
            this.gb1.Location = new System.Drawing.Point(266, 295);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(362, 162);
            this.gb1.TabIndex = 18;
            this.gb1.TabStop = false;
            this.gb1.Visible = false;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(203, 128);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(83, 28);
            this.update_button.TabIndex = 21;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // re_enter_password_text_box
            // 
            this.re_enter_password_text_box.Location = new System.Drawing.Point(171, 85);
            this.re_enter_password_text_box.Name = "re_enter_password_text_box";
            this.re_enter_password_text_box.Size = new System.Drawing.Size(150, 22);
            this.re_enter_password_text_box.TabIndex = 20;
            // 
            // re_enter_password_label
            // 
            this.re_enter_password_label.AutoSize = true;
            this.re_enter_password_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_enter_password_label.Location = new System.Drawing.Point(-3, 89);
            this.re_enter_password_label.Name = "re_enter_password_label";
            this.re_enter_password_label.Size = new System.Drawing.Size(168, 18);
            this.re_enter_password_label.TabIndex = 19;
            this.re_enter_password_label.Text = "re-enter password : ";
            // 
            // new_password_text_box
            // 
            this.new_password_text_box.Location = new System.Drawing.Point(171, 32);
            this.new_password_text_box.Name = "new_password_text_box";
            this.new_password_text_box.Size = new System.Drawing.Size(150, 22);
            this.new_password_text_box.TabIndex = 18;
            // 
            // new_password_label
            // 
            this.new_password_label.AutoSize = true;
            this.new_password_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_label.Location = new System.Drawing.Point(-3, 36);
            this.new_password_label.Name = "new_password_label";
            this.new_password_label.Size = new System.Drawing.Size(139, 18);
            this.new_password_label.TabIndex = 17;
            this.new_password_label.Text = "New password : ";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.verification_code_label);
            this.gb2.Controls.Add(this.verification_code_text_box);
            this.gb2.Controls.Add(this.confirm_button);
            this.gb2.Location = new System.Drawing.Point(266, 141);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(362, 148);
            this.gb2.TabIndex = 19;
            this.gb2.TabStop = false;
            // 
            // reset_password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 537);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.cnic_value_label);
            this.Controls.Add(this.cnic_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reset_password_form";
            this.Text = "reset_password_form";
            this.Load += new System.EventHandler(this.reset_password_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_page_label;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label cnic_value_label;
        private System.Windows.Forms.Label cnic_label;
        private System.Windows.Forms.TextBox verification_code_text_box;
        private System.Windows.Forms.Label verification_code_label;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox re_enter_password_text_box;
        private System.Windows.Forms.Label re_enter_password_label;
        private System.Windows.Forms.TextBox new_password_text_box;
        private System.Windows.Forms.Label new_password_label;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.GroupBox gb2;
    }
}