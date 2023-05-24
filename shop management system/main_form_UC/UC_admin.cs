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

namespace shop_management_system.main_form_UC
{
    public partial class UC_admin : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public UC_admin()
        {
            InitializeComponent();
            update_dgv();
        }

        private void update_dgv()
        {
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM admin_tb", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                data_table_main_admin_form.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void add_button_main_admin_form_Click(object sender, EventArgs e)
        {

        }
    }
}
