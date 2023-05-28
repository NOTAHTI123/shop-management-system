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

namespace shop_management_system.customer_form_UC
{
    public partial class UC_customer_dashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");
        string cnic;
        public UC_customer_dashboard()
        {
            InitializeComponent();

            get_history();
        }

        public UC_customer_dashboard(string cnic_passed)
        {
            InitializeComponent();
            cnic = cnic_passed;
            get_history();
        }

        private void get_history()
        {
            //retreive transaction history
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT order_no, total_bill, bill_date, employee_id  FROM total_bill_tb INNER JOIN customer_tb ON customer_tb.customer_cnic = total_bill_tb.customer_cnic WHERE customer_tb.customer_cnic = '" + cnic + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void UC_customer_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
