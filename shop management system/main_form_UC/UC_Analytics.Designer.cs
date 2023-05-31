namespace shop_management_system
{
    partial class UC_Analytics
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Analytics));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.show_analytics_label = new System.Windows.Forms.Label();
            this.duration_combo_box = new System.Windows.Forms.ComboBox();
            this.ok_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.prompt_label = new System.Windows.Forms.Label();
            this.shop_management_DBDataSet = new shop_management_system.shop_management_DBDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new shop_management_system.shop_management_DBDataSetTableAdapters.ordersTableAdapter();
            this.main_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shop_management_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // show_analytics_label
            // 
            this.show_analytics_label.AutoSize = true;
            this.show_analytics_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_analytics_label.Location = new System.Drawing.Point(219, 66);
            this.show_analytics_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.show_analytics_label.Name = "show_analytics_label";
            this.show_analytics_label.Size = new System.Drawing.Size(122, 17);
            this.show_analytics_label.TabIndex = 1;
            this.show_analytics_label.Text = "Show analytics for";
            // 
            // duration_combo_box
            // 
            this.duration_combo_box.FormattingEnabled = true;
            this.duration_combo_box.Items.AddRange(new object[] {
            "Last 7 days",
            "Last Month",
            "Last 6 Months",
            "Last Year"});
            this.duration_combo_box.Location = new System.Drawing.Point(340, 66);
            this.duration_combo_box.Margin = new System.Windows.Forms.Padding(2);
            this.duration_combo_box.Name = "duration_combo_box";
            this.duration_combo_box.Size = new System.Drawing.Size(92, 21);
            this.duration_combo_box.TabIndex = 2;
            // 
            // ok_button
            // 
            this.ok_button.ActiveBorderThickness = 1;
            this.ok_button.ActiveCornerRadius = 20;
            this.ok_button.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.ok_button.ActiveForecolor = System.Drawing.Color.White;
            this.ok_button.ActiveLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.ok_button.BackColor = System.Drawing.SystemColors.Control;
            this.ok_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ok_button.BackgroundImage")));
            this.ok_button.ButtonText = "Ok";
            this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.ForeColor = System.Drawing.Color.SeaGreen;
            this.ok_button.IdleBorderThickness = 1;
            this.ok_button.IdleCornerRadius = 20;
            this.ok_button.IdleFillColor = System.Drawing.Color.MidnightBlue;
            this.ok_button.IdleForecolor = System.Drawing.SystemColors.ControlLightLight;
            this.ok_button.IdleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.ok_button.Location = new System.Drawing.Point(454, 59);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 33);
            this.ok_button.TabIndex = 37;
            this.ok_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.ForeColor = System.Drawing.Color.Red;
            this.prompt_label.Location = new System.Drawing.Point(338, 102);
            this.prompt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(116, 13);
            this.prompt_label.TabIndex = 38;
            this.prompt_label.Text = "please select an option";
            // 
            // shop_management_DBDataSet
            // 
            this.shop_management_DBDataSet.DataSetName = "shop_management_DBDataSet";
            this.shop_management_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.shop_management_DBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // main_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.main_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.main_chart.Legends.Add(legend5);
            this.main_chart.Location = new System.Drawing.Point(134, 175);
            this.main_chart.Margin = new System.Windows.Forms.Padding(2);
            this.main_chart.Name = "main_chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.main_chart.Series.Add(series5);
            this.main_chart.Size = new System.Drawing.Size(490, 244);
            this.main_chart.TabIndex = 39;
            this.main_chart.Text = "main_chart";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_chart);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.duration_combo_box);
            this.Controls.Add(this.show_analytics_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Analytics";
            this.Size = new System.Drawing.Size(719, 489);
            this.Load += new System.EventHandler(this.UC_Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shop_management_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label show_analytics_label;
        private System.Windows.Forms.ComboBox duration_combo_box;
        private Bunifu.Framework.UI.BunifuThinButton2 ok_button;
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private shop_management_DBDataSet shop_management_DBDataSet;
        private shop_management_DBDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart main_chart;
        private System.Windows.Forms.Timer timer1;
    }
}
