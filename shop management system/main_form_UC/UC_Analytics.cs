using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_management_system
{
    public partial class UC_Analytics : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public UC_Analytics()
        {
            InitializeComponent();

            prompt_label.Visible = false;
            //chart

            SqlDataAdapter sda = new SqlDataAdapter("Select product_id, quantity from orders", con);

            DataSet ds  = new DataSet();
            sda.Fill(ds);

            main_chart.DataSource = ds.Tables[0];
            //chart
            main_chart.Series[0].Name = "Sales";
            main_chart.Series["Sales"].XValueMember = "product_id";
            main_chart.Series["Sales"].YValueMembers = "quantity";
        }

        private void UC_Analytics_Load(object sender, EventArgs e)
        {

        }

        private void main_chart_Click(object sender, EventArgs e)
        {

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(duration_combo_box.Text == "")
            {
                prompt_label.Visible = true;
            }
            else
            {
                con.Open();
                try
                {
                    DateTime dt_now = DateTime.Now;
                    if (duration_combo_box.SelectedIndex == 0)
                    {
                        dt_now = dt_now.AddDays(-1);
                        string lower_date = dt_now.ToShortDateString();


                        SqlDataAdapter sda_final = new SqlDataAdapter("SELECT product_id, SUM(quantity) AS quantity FROM orders WHERE bill_date BETWEEN + '" + lower_date + "' AND CURRENT_TIMESTAMP GROUP BY product_id", con);
                        

                        DataSet ds = new DataSet();
                        sda_final.Fill(ds);

                        main_chart.DataSource = ds;
                        main_chart.DataBind();

                    }

                    else if (duration_combo_box.SelectedIndex == 1)
                    {
                        DateTime dt_lower = dt_now.AddMonths(-1);

                        SqlDataAdapter sda_final = new SqlDataAdapter("SELECT product_id, SUM(quantity) AS quantity FROM orders WHERE bill_date BETWEEN + '" + dt_lower.ToShortDateString() + "' AND '" + dt_now.ToShortDateString() + "' GROUP BY product_id", con);


                        DataSet ds = new DataSet();
                        sda_final.Fill(ds);

                        main_chart.DataSource = ds;
                        main_chart.DataBind();

                    }

                    else if(duration_combo_box.SelectedIndex == 2)
                    {
                        DateTime dt_lower = dt_now.AddMonths(-6);

                        SqlDataAdapter sda_final = new SqlDataAdapter("SELECT product_id, SUM(quantity) AS quantity FROM orders WHERE bill_date BETWEEN + '" + dt_lower.ToShortDateString() + "' AND CURRENT_TIMESTAMP GROUP BY product_id", con);


                        DataSet ds = new DataSet();
                        sda_final.Fill(ds);

                        main_chart.DataSource = ds;
                        main_chart.DataBind();
                    }

                    else if (duration_combo_box.SelectedIndex == 3)
                    {
                        DateTime dt_lower = dt_now.AddMonths(-24);

                        SqlDataAdapter sda_final = new SqlDataAdapter("SELECT product_id, SUM(quantity) AS quantity FROM orders WHERE bill_date BETWEEN + '" + dt_lower.ToShortDateString() + "' AND '" + dt_now.ToShortDateString() + "' GROUP BY product_id", con);


                        DataSet ds = new DataSet();
                        sda_final.Fill(ds);

                        main_chart.DataSource = ds;
                        main_chart.DataBind();
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
    }
}
