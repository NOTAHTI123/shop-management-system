namespace shop_management_system
{
    partial class UC_Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product));
            this.product_price_text_box_main_product_form = new System.Windows.Forms.TextBox();
            this.product_price_label_main_product_form = new System.Windows.Forms.Label();
            this.data_table_main_product_form = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.drop_down_menu_main_Customer_form = new System.Windows.Forms.ComboBox();
            this.add_button_main_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.delete_button_main_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.edit_button_main_employee_form = new Bunifu.Framework.UI.BunifuThinButton2();
            this.product_idtext_box_main_product_form = new System.Windows.Forms.TextBox();
            this.product_quantity_text_box_main_product_form = new System.Windows.Forms.TextBox();
            this.product_name_text_box_main_product_form = new System.Windows.Forms.TextBox();
            this.product_id_label_main_product_form = new System.Windows.Forms.Label();
            this.product_quantity_label_main_product_form = new System.Windows.Forms.Label();
            this.product_category_label_main_product_form = new System.Windows.Forms.Label();
            this.product_page_heading = new System.Windows.Forms.Label();
            this.product_name_label_main_product_form = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_table_main_product_form)).BeginInit();
            this.SuspendLayout();
            // 
            // product_price_text_box_main_product_form
            // 
            this.product_price_text_box_main_product_form.Location = new System.Drawing.Point(248, 171);
            this.product_price_text_box_main_product_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_price_text_box_main_product_form.Name = "product_price_text_box_main_product_form";
            this.product_price_text_box_main_product_form.Size = new System.Drawing.Size(91, 20);
            this.product_price_text_box_main_product_form.TabIndex = 72;
            // 
            // product_price_label_main_product_form
            // 
            this.product_price_label_main_product_form.AutoSize = true;
            this.product_price_label_main_product_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price_label_main_product_form.Location = new System.Drawing.Point(244, 147);
            this.product_price_label_main_product_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_price_label_main_product_form.Name = "product_price_label_main_product_form";
            this.product_price_label_main_product_form.Size = new System.Drawing.Size(106, 17);
            this.product_price_label_main_product_form.TabIndex = 71;
            this.product_price_label_main_product_form.Text = "Product Price";
            // 
            // data_table_main_product_form
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.data_table_main_product_form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_table_main_product_form.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_table_main_product_form.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_table_main_product_form.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_table_main_product_form.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_table_main_product_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table_main_product_form.DoubleBuffered = true;
            this.data_table_main_product_form.EnableHeadersVisualStyles = false;
            this.data_table_main_product_form.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.data_table_main_product_form.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_table_main_product_form.Location = new System.Drawing.Point(92, 252);
            this.data_table_main_product_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_table_main_product_form.Name = "data_table_main_product_form";
            this.data_table_main_product_form.ReadOnly = true;
            this.data_table_main_product_form.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_table_main_product_form.RowHeadersWidth = 51;
            this.data_table_main_product_form.RowTemplate.Height = 24;
            this.data_table_main_product_form.Size = new System.Drawing.Size(538, 185);
            this.data_table_main_product_form.TabIndex = 70;
            this.data_table_main_product_form.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_table_main_product_form_CellContentClick);
            // 
            // drop_down_menu_main_Customer_form
            // 
            this.drop_down_menu_main_Customer_form.FormattingEnabled = true;
            this.drop_down_menu_main_Customer_form.Items.AddRange(new object[] {
            "Food and Beverages",
            "Beauty",
            "Clothing",
            "Bathroom",
            "Electronics"});
            this.drop_down_menu_main_Customer_form.Location = new System.Drawing.Point(248, 114);
            this.drop_down_menu_main_Customer_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drop_down_menu_main_Customer_form.Name = "drop_down_menu_main_Customer_form";
            this.drop_down_menu_main_Customer_form.Size = new System.Drawing.Size(92, 21);
            this.drop_down_menu_main_Customer_form.TabIndex = 69;
            // 
            // add_button_main_employee_form
            // 
            this.add_button_main_employee_form.ActiveBorderThickness = 1;
            this.add_button_main_employee_form.ActiveCornerRadius = 20;
            this.add_button_main_employee_form.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.add_button_main_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.add_button_main_employee_form.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.add_button_main_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.add_button_main_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button_main_employee_form.BackgroundImage")));
            this.add_button_main_employee_form.ButtonText = "Add";
            this.add_button_main_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button_main_employee_form.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button_main_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.add_button_main_employee_form.IdleBorderThickness = 1;
            this.add_button_main_employee_form.IdleCornerRadius = 20;
            this.add_button_main_employee_form.IdleFillColor = System.Drawing.Color.MidnightBlue;
            this.add_button_main_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button_main_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button_main_employee_form.Location = new System.Drawing.Point(98, 204);
            this.add_button_main_employee_form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_button_main_employee_form.Name = "add_button_main_employee_form";
            this.add_button_main_employee_form.Size = new System.Drawing.Size(100, 41);
            this.add_button_main_employee_form.TabIndex = 68;
            this.add_button_main_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_button_main_employee_form.Click += new System.EventHandler(this.add_button_main_employee_form_Click);
            // 
            // delete_button_main_employee_form
            // 
            this.delete_button_main_employee_form.ActiveBorderThickness = 1;
            this.delete_button_main_employee_form.ActiveCornerRadius = 20;
            this.delete_button_main_employee_form.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.delete_button_main_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.delete_button_main_employee_form.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.delete_button_main_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.delete_button_main_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_button_main_employee_form.BackgroundImage")));
            this.delete_button_main_employee_form.ButtonText = "Delete";
            this.delete_button_main_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button_main_employee_form.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button_main_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.delete_button_main_employee_form.IdleBorderThickness = 1;
            this.delete_button_main_employee_form.IdleCornerRadius = 20;
            this.delete_button_main_employee_form.IdleFillColor = System.Drawing.Color.MidnightBlue;
            this.delete_button_main_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_button_main_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_button_main_employee_form.Location = new System.Drawing.Point(368, 204);
            this.delete_button_main_employee_form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_button_main_employee_form.Name = "delete_button_main_employee_form";
            this.delete_button_main_employee_form.Size = new System.Drawing.Size(100, 41);
            this.delete_button_main_employee_form.TabIndex = 67;
            this.delete_button_main_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_button_main_employee_form.Click += new System.EventHandler(this.delete_button_main_employee_form_Click);
            // 
            // edit_button_main_employee_form
            // 
            this.edit_button_main_employee_form.ActiveBorderThickness = 1;
            this.edit_button_main_employee_form.ActiveCornerRadius = 20;
            this.edit_button_main_employee_form.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.edit_button_main_employee_form.ActiveForecolor = System.Drawing.Color.White;
            this.edit_button_main_employee_form.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.edit_button_main_employee_form.BackColor = System.Drawing.SystemColors.Control;
            this.edit_button_main_employee_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_button_main_employee_form.BackgroundImage")));
            this.edit_button_main_employee_form.ButtonText = "Edit";
            this.edit_button_main_employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button_main_employee_form.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button_main_employee_form.ForeColor = System.Drawing.Color.SeaGreen;
            this.edit_button_main_employee_form.IdleBorderThickness = 1;
            this.edit_button_main_employee_form.IdleCornerRadius = 20;
            this.edit_button_main_employee_form.IdleFillColor = System.Drawing.Color.MidnightBlue;
            this.edit_button_main_employee_form.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.edit_button_main_employee_form.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit_button_main_employee_form.Location = new System.Drawing.Point(233, 204);
            this.edit_button_main_employee_form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_button_main_employee_form.Name = "edit_button_main_employee_form";
            this.edit_button_main_employee_form.Size = new System.Drawing.Size(100, 41);
            this.edit_button_main_employee_form.TabIndex = 66;
            this.edit_button_main_employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit_button_main_employee_form.Click += new System.EventHandler(this.edit_button_main_employee_form_Click);
            // 
            // product_idtext_box_main_product_form
            // 
            this.product_idtext_box_main_product_form.Location = new System.Drawing.Point(92, 171);
            this.product_idtext_box_main_product_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_idtext_box_main_product_form.Name = "product_idtext_box_main_product_form";
            this.product_idtext_box_main_product_form.Size = new System.Drawing.Size(106, 20);
            this.product_idtext_box_main_product_form.TabIndex = 65;
            // 
            // product_quantity_text_box_main_product_form
            // 
            this.product_quantity_text_box_main_product_form.Location = new System.Drawing.Point(402, 114);
            this.product_quantity_text_box_main_product_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_quantity_text_box_main_product_form.Name = "product_quantity_text_box_main_product_form";
            this.product_quantity_text_box_main_product_form.Size = new System.Drawing.Size(106, 20);
            this.product_quantity_text_box_main_product_form.TabIndex = 64;
            // 
            // product_name_text_box_main_product_form
            // 
            this.product_name_text_box_main_product_form.Location = new System.Drawing.Point(92, 114);
            this.product_name_text_box_main_product_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_name_text_box_main_product_form.Name = "product_name_text_box_main_product_form";
            this.product_name_text_box_main_product_form.Size = new System.Drawing.Size(106, 20);
            this.product_name_text_box_main_product_form.TabIndex = 63;
            // 
            // product_id_label_main_product_form
            // 
            this.product_id_label_main_product_form.AutoSize = true;
            this.product_id_label_main_product_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id_label_main_product_form.Location = new System.Drawing.Point(89, 147);
            this.product_id_label_main_product_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_id_label_main_product_form.Name = "product_id_label_main_product_form";
            this.product_id_label_main_product_form.Size = new System.Drawing.Size(84, 17);
            this.product_id_label_main_product_form.TabIndex = 62;
            this.product_id_label_main_product_form.Text = "Product ID";
            // 
            // product_quantity_label_main_product_form
            // 
            this.product_quantity_label_main_product_form.AutoSize = true;
            this.product_quantity_label_main_product_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity_label_main_product_form.Location = new System.Drawing.Point(399, 85);
            this.product_quantity_label_main_product_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_quantity_label_main_product_form.Name = "product_quantity_label_main_product_form";
            this.product_quantity_label_main_product_form.Size = new System.Drawing.Size(69, 17);
            this.product_quantity_label_main_product_form.TabIndex = 61;
            this.product_quantity_label_main_product_form.Text = "Quantity";
            // 
            // product_category_label_main_product_form
            // 
            this.product_category_label_main_product_form.AutoSize = true;
            this.product_category_label_main_product_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_category_label_main_product_form.Location = new System.Drawing.Point(244, 85);
            this.product_category_label_main_product_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_category_label_main_product_form.Name = "product_category_label_main_product_form";
            this.product_category_label_main_product_form.Size = new System.Drawing.Size(73, 17);
            this.product_category_label_main_product_form.TabIndex = 60;
            this.product_category_label_main_product_form.Text = "Category";
            // 
            // product_page_heading
            // 
            this.product_page_heading.AutoSize = true;
            this.product_page_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_page_heading.Location = new System.Drawing.Point(272, 53);
            this.product_page_heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_page_heading.Name = "product_page_heading";
            this.product_page_heading.Size = new System.Drawing.Size(80, 20);
            this.product_page_heading.TabIndex = 58;
            this.product_page_heading.Text = "Products";
            // 
            // product_name_label_main_product_form
            // 
            this.product_name_label_main_product_form.AutoSize = true;
            this.product_name_label_main_product_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_label_main_product_form.Location = new System.Drawing.Point(89, 85);
            this.product_name_label_main_product_form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_name_label_main_product_form.Name = "product_name_label_main_product_form";
            this.product_name_label_main_product_form.Size = new System.Drawing.Size(110, 17);
            this.product_name_label_main_product_form.TabIndex = 59;
            this.product_name_label_main_product_form.Text = "Product Name";
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_price_text_box_main_product_form);
            this.Controls.Add(this.product_price_label_main_product_form);
            this.Controls.Add(this.data_table_main_product_form);
            this.Controls.Add(this.drop_down_menu_main_Customer_form);
            this.Controls.Add(this.add_button_main_employee_form);
            this.Controls.Add(this.delete_button_main_employee_form);
            this.Controls.Add(this.edit_button_main_employee_form);
            this.Controls.Add(this.product_idtext_box_main_product_form);
            this.Controls.Add(this.product_quantity_text_box_main_product_form);
            this.Controls.Add(this.product_name_text_box_main_product_form);
            this.Controls.Add(this.product_id_label_main_product_form);
            this.Controls.Add(this.product_quantity_label_main_product_form);
            this.Controls.Add(this.product_category_label_main_product_form);
            this.Controls.Add(this.product_page_heading);
            this.Controls.Add(this.product_name_label_main_product_form);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(719, 489);
            this.Load += new System.EventHandler(this.UC_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_table_main_product_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox product_price_text_box_main_product_form;
        private System.Windows.Forms.Label product_price_label_main_product_form;
        private Bunifu.Framework.UI.BunifuCustomDataGrid data_table_main_product_form;
        private System.Windows.Forms.ComboBox drop_down_menu_main_Customer_form;
        private Bunifu.Framework.UI.BunifuThinButton2 add_button_main_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 delete_button_main_employee_form;
        private Bunifu.Framework.UI.BunifuThinButton2 edit_button_main_employee_form;
        private System.Windows.Forms.TextBox product_idtext_box_main_product_form;
        private System.Windows.Forms.TextBox product_quantity_text_box_main_product_form;
        private System.Windows.Forms.TextBox product_name_text_box_main_product_form;
        private System.Windows.Forms.Label product_id_label_main_product_form;
        private System.Windows.Forms.Label product_quantity_label_main_product_form;
        private System.Windows.Forms.Label product_category_label_main_product_form;
        private System.Windows.Forms.Label product_page_heading;
        private System.Windows.Forms.Label product_name_label_main_product_form;
    }
}
