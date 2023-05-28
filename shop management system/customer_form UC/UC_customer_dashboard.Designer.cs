namespace shop_management_system.customer_form_UC
{
    partial class UC_customer_dashboard
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
            this.transaction_history_label = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // transaction_history_label
            // 
            this.transaction_history_label.AutoSize = true;
            this.transaction_history_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_history_label.Location = new System.Drawing.Point(258, 24);
            this.transaction_history_label.Name = "transaction_history_label";
            this.transaction_history_label.Size = new System.Drawing.Size(170, 24);
            this.transaction_history_label.TabIndex = 0;
            this.transaction_history_label.Text = "Transaction History";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(136, 80);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(446, 359);
            this.dgv.TabIndex = 1;
            // 
            // UC_customer_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.transaction_history_label);
            this.Name = "UC_customer_dashboard";
            this.Size = new System.Drawing.Size(719, 489);
            this.Load += new System.EventHandler(this.UC_customer_dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transaction_history_label;
        private System.Windows.Forms.DataGridView dgv;
    }
}
