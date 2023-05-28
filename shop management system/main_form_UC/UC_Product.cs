using FontAwesome.Sharp;
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
    public partial class UC_Product : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public UC_Product()
        {
            InitializeComponent();
            update_data_table();
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {

        }
        private void update_data_table()
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from product_tb", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            data_table_main_product_form.DataSource = dt;
            con.Close();
        }


        private void add_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (product_name_text_box_main_product_form.Text == "" || drop_down_menu_main_Customer_form.Text == "" || product_quantity_text_box_main_product_form.Text == "" || product_price_text_box_main_product_form.Text == "" || product_idtext_box_main_product_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                try
                {
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_id = '" + product_idtext_box_main_product_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if (cnt == 1)
                    {

                        SqlCommand cmd = new SqlCommand("insert into product_tb ( product_name, product_category, product_quantity, product_price)values(@pname, @pcategory, @pquantity, @pprice)", con);
                        cmd.Parameters.AddWithValue("@pid", product_idtext_box_main_product_form.Text);
                        cmd.Parameters.AddWithValue("@pname", product_name_text_box_main_product_form.Text);
                        cmd.Parameters.AddWithValue("@pcategory", drop_down_menu_main_Customer_form.Text);
                        cmd.Parameters.AddWithValue("@pquantity", product_quantity_text_box_main_product_form.Text);
                        cmd.Parameters.AddWithValue("@pprice", product_price_text_box_main_product_form.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully");
                    }
                    else
                    {
                        MessageBox.Show("The ID already exists");
                    }
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show("The Product with the matching id already exists");
                    con.Close();
                }
            }
        }

        private void edit_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (product_name_text_box_main_product_form.Text == "" || drop_down_menu_main_Customer_form.Text == "" || product_quantity_text_box_main_product_form.Text == "" || product_price_text_box_main_product_form.Text == "" || product_idtext_box_main_product_form.Text == "")
            {
                MessageBox.Show("Please Enter all the details [Keeping the product id the same]");
            }
            else
            {
                try
                {
                    con.Open();




                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_id = '" + product_idtext_box_main_product_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if (cnt == 1)
                    {
                        SqlCommand cmd = new SqlCommand("update product_tb set product_name = @pname, product_category = @pcategory, product_quantity = @pquantity where product_id=@pid", con);
                        cmd.Parameters.AddWithValue("@pid", product_idtext_box_main_product_form.Text);
                        cmd.Parameters.AddWithValue("@pname", product_name_text_box_main_product_form.Text);
                        cmd.Parameters.AddWithValue("@pcategory", drop_down_menu_main_Customer_form.Text);
                        cmd.Parameters.AddWithValue("@pquantity", product_quantity_text_box_main_product_form.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Products's data edited successfully");
                    }
                    else
                    {
                        MessageBox.Show("The ID is not found");
                    }
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void delete_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (product_idtext_box_main_product_form.Text == "")
            {
                MessageBox.Show("Please Enter the product id");
            }
            else
            {
                try
                {
                    con.Open();




                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb WHERE product_id = '" + product_idtext_box_main_product_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if (cnt == 1)
                    {
                        SqlCommand cmd = new SqlCommand("delete from product_tb  where product_id=@pid", con);
                        cmd.Parameters.AddWithValue("@pid", product_idtext_box_main_product_form.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product's data deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("The ID is not found");
                    }
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void data_table_main_product_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                product_name_text_box_main_product_form.Text = data_table_main_product_form.SelectedRows[0].Cells[1].Value.ToString();
                drop_down_menu_main_Customer_form.Text = data_table_main_product_form.SelectedRows[0].Cells[2].Value.ToString();
                product_quantity_text_box_main_product_form.Text = data_table_main_product_form.SelectedRows[0].Cells[3].Value.ToString();
                product_idtext_box_main_product_form.Text = data_table_main_product_form.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
