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
    public partial class UC_Customers : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public UC_Customers()
        {
            InitializeComponent();
            update_data_table();

            data_table_main_customer_form.Columns[3].Width = 150;

        }

        private void update_data_table()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from customer_tb", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            data_table_main_customer_form.DataSource = dt;
            con.Close();
        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {

        }

        private void add_button_main_Customer_form_Click(object sender, EventArgs e)
        {
            if (phone_text_box_main_Customer_form.Text == "" || Customer_cnic_text_box_main_Customer_form.Text == "" || phone_text_box_main_Customer_form.Text == "" || Customer_cnic_text_box_main_Customer_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }

            else
            {
                try
                {
                    con.Open();



                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM customer_tb WHERE customer_cnic = '" + Customer_cnic_text_box_main_Customer_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if (cnt == 1)
                    {
                        if (Customer_name_text_box_main_Customer_form.Text != "" && Customer_address_text_box_main_Customer_form.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand("insert into customer_tb (customer_cnic, customer_name, customer_address)values(@cid, @cname , @caddress)", con);

                            cmd.Parameters.AddWithValue("@cname", Customer_name_text_box_main_Customer_form.Text);
                            cmd.Parameters.AddWithValue("@cid", Customer_cnic_text_box_main_Customer_form.Text);
                            cmd.Parameters.AddWithValue("@caddress", Customer_address_text_box_main_Customer_form.Text);
                            cmd.Parameters.AddWithValue("@cphone", phone_text_box_main_Customer_form.Text);

                            cmd.ExecuteNonQuery();


                            SqlCommand cmd_2 = new SqlCommand("INSERT INTO customer_phone(customer_id, phone)VALUES(@c_id, @cphone)", con);
                            cmd_2.Parameters.AddWithValue("@c_id", Customer_cnic_text_box_main_Customer_form.Text);
                            cmd_2.Parameters.AddWithValue("@cphone", phone_text_box_main_Customer_form.Text);

                            cmd_2.ExecuteNonQuery();


                            MessageBox.Show("Customer added successfully");

                        }
                    }
                    else
                    {
                        MessageBox.Show("The CNIC already exists");
                    }


                    //fetch customer id to insert customer phone
 //FK used



                    con.Close();
                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void edit_button_main_Customer_form_Click(object sender, EventArgs e)
        {
            if (Customer_name_text_box_main_Customer_form.Text == "" || Customer_address_text_box_main_Customer_form.Text == "" || phone_text_box_main_Customer_form.Text == "" || Customer_cnic_text_box_main_Customer_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields [The Customer cnic must be the same]");
            }
            else
            {
                try
                {
                    con.Open();



                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM customer_tb WHERE customer_cnic = '" + Customer_cnic_text_box_main_Customer_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if (cnt == 1)
                    {
                        SqlCommand cmd = new SqlCommand("update customer_tb set customer_name = @cname, customer_address = @caddress, customer_phone = @cphone  where customer_cnic=@cid", con);
                        cmd.Parameters.AddWithValue("@cid", Customer_cnic_text_box_main_Customer_form.Text);
                        cmd.Parameters.AddWithValue("@cname", Customer_name_text_box_main_Customer_form.Text);
                        cmd.Parameters.AddWithValue("@caddress", Customer_address_text_box_main_Customer_form.Text);
                        cmd.Parameters.AddWithValue("@cphone", phone_text_box_main_Customer_form.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer's data edited successfully");
                    }

                    else
                    {
                        MessageBox.Show("The CNIC was not found");
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

        private void delete_button_main_Customer_form_Click(object sender, EventArgs e)
        {
            if (Customer_cnic_text_box_main_Customer_form.Text == "")
            {
                MessageBox.Show("Please Enter the Customer CNIC");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM customer_tb WHERE customer_cnic = '" + Customer_cnic_text_box_main_Customer_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if (cnt == 1)
                    {
                        SqlCommand cmd_2 = new SqlCommand("DELETE FROM customer_phone where customer_id = @c_id", con);
                        cmd_2.Parameters.Add("@c_id", Customer_cnic_text_box_main_Customer_form.Text);

                        cmd_2.ExecuteNonQuery();


                        SqlCommand cmd = new SqlCommand("delete from customer_tb where customer_cnic=@ciid", con);
                        cmd.Parameters.AddWithValue("@ciid", Customer_cnic_text_box_main_Customer_form.Text);
                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Customer's data deleted successfully");

                    }

                    else
                    {
                        MessageBox.Show("The CNIC doesn't exist");
                    }

 
                    //MessageBox.Show(Customer_cnic_text_box_main_Customer_form.Text);
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void data_table_main_customer_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Customer_name_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[2].Value.ToString();
                Customer_address_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[3].Value.ToString();
                Customer_cnic_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[1].Value.ToString();
                //phone_text_box_main_Customer_form.Text = data_table_main_customer_form.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
