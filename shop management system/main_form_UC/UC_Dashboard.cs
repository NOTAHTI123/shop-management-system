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
    public partial class UC_Dashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");
        public UC_Dashboard()
        {
            InitializeComponent();
            update_counts();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void update_counts()
        {
            try
            {
                con.Open();

                //Food and beverages
                SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_category = 'Food and Beverages'", con);
                DataTable dt_1 = new DataTable();
                sda_1.Fill(dt_1);

                count_food_and_beverages_main_home_page.Text = dt_1.Rows[0][0].ToString();

                //Beauty
                SqlDataAdapter sda_2 = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_category = 'Beauty'", con);
                DataTable dt_2 = new DataTable();
                sda_2.Fill(dt_2);

                count_beauty_main_home_page.Text = dt_2.Rows[0][0].ToString();

                //Clothing
                SqlDataAdapter sda_3 = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_category = 'Clothing'", con);
                DataTable dt_3 = new DataTable();
                sda_3.Fill(dt_3);

                count_clothing_main_home_page.Text = dt_3.Rows[0][0].ToString();

                //Bathroom
                SqlDataAdapter sda_4 = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_category = 'Bathroom'", con);
                DataTable dt_4 = new DataTable();
                sda_4.Fill(dt_4);

                count_bathroom_accessories.Text = dt_4.Rows[0][0].ToString();

                //Electronics
                SqlDataAdapter sda_5 = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_category = 'Electronics'", con);
                DataTable dt_5 = new DataTable();
                sda_5.Fill(dt_5);

                count_electronics.Text = dt_5.Rows[0][0].ToString();


                //Employee
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_tb", con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                string number_of_employees;


                number_of_employees = dt.Rows[0][0].ToString();

                employee_count.Text = number_of_employees;


                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //V1.0 methods
        /*private void update_progress_employee()
        {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_tb", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            string number_of_employees;


            number_of_employees = dt.Rows[0][0].ToString();

            employee_count.Text = number_of_employees;

            con.Close();
        }

        private void update_food_and_beverages()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'food and beverages'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_food_and_beverages_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void update_beauty()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'beauty'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_beauty_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void update_clothing()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'clothing'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_clothing_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }*/

    }
}
