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

namespace shop_management_system.employee_form_UC
{
    public partial class UC_Billing_emp : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");
        int temp_price;
        int total_bill = 0;
        int order_no;
        string cnic;
        string selected_cnic;
        int count = 0;

        public UC_Billing_emp()
        {
            InitializeComponent();
            update_products_table();
        }

        public UC_Billing_emp(string cnic_passed)
        {
            InitializeComponent();
            update_products_table();
            update_drop_down();
            init_bill_tb();
            //cnic = cnic_passed;
        }

        private void init_bill_tb()
        {

            products_bill_data_table.ColumnCount = 4;
            products_bill_data_table.Columns[0].Name = "product id";
            products_bill_data_table.Columns[1].Name = "product name";
            products_bill_data_table.Columns[2].Name = "product price";
            products_bill_data_table.Columns[3].Name = "product quantity";

        }

        private void update_bill_tb()
        {
            products_bill_data_table.Rows.Add();
            products_bill_data_table.Rows[count].Cells[0].Value = product_id_text_box.Text;
            products_bill_data_table.Rows[count].Cells[2].Value = temp_price;
            products_bill_data_table.Rows[count].Cells[3].Value = product_quantity_text_box_main_billing_employee_form.Text;
        }
        private void update_drop_down()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT customer_cnic FROM customer_tb", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                dropdown_customer_id_main_billing_employee_form.Items.Add(sdr.GetInt64(0));
            }
            con.Close();
        }

        private void update_products_table()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM  product_tb", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                products_data_table_main_billing_employee_form.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UB_Billing_emp_Load(object sender, EventArgs e)
        {

        }

        private void add_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            if(product_id_text_box.Text == "")
            {
                MessageBox.Show("Please Fill the PID field");
            }
            if(product_quantity_text_box_main_billing_employee_form.Text == "")
            {
                MessageBox.Show("Please Fill the quantity field");
            }
            if(dropdown_customer_id_main_billing_employee_form.SelectedIndex <= -1)
            {
                MessageBox.Show("Please Select customer ID");
            }

            if(product_id_text_box.Text == "" || product_quantity_text_box_main_billing_employee_form.Text == "" || dropdown_customer_id_main_billing_employee_form.SelectedIndex <= -1)
            {
                //just a check
            }
            else
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT COUNT(*) FROM product_tb where product_id = '" + product_id_text_box.Text + "'", con);
                    DataTable dt_1 = new DataTable();
                    sda_1.Fill(dt_1);

                    if (dt_1.Rows[0][0].ToString() != "1")
                    {
                        MessageBox.Show("No products with the provided PID exist");
                    }
                    else
                    {
                        SqlDataAdapter sda_check_quantity = new SqlDataAdapter("SELECT product_quantity from product_tb where product_id = '" + product_id_text_box.Text + "'", con);
                        DataTable dt_check_quantity = new DataTable();
                        sda_check_quantity.Fill(dt_check_quantity);

                        int available_quantity = int.Parse(dt_check_quantity.Rows[0][0].ToString());

                        if(int.Parse(product_quantity_text_box_main_billing_employee_form.Text.ToString()) > available_quantity)
                        {
                            MessageBox.Show("The requested quantity is not available");
                        }
                        else
                        {
                            //get order no
                            SqlDataAdapter sda_0 = new SqlDataAdapter("SELECT order_no from order_no_tb", con);
                            DataTable dt_0 = new DataTable();
                            sda_0.Fill(dt_0);
                            order_no = int.Parse(dt_0.Rows[0][0].ToString());


                            SqlCommand cmd = new SqlCommand("UPDATE product_tb set product_quantity = product_quantity - " + product_quantity_text_box_main_billing_employee_form.Text + " WHERE product_id = '" + product_id_text_box.Text + "'", con);
                            cmd.ExecuteNonQuery();

                            SqlDataAdapter sda_2 = new SqlDataAdapter("SELECT product_price FROM product_tb WHERE product_id = '" + product_id_text_box.Text + "'", con);
                            DataTable dt_2 = new DataTable();
                            sda_2.Fill(dt_2);

                            temp_price = int.Parse(dt_2.Rows[0][0].ToString()); //get price

                            SqlCommand cmd_orders_table = new SqlCommand("INSERT INTO orders VALUES(@order_no, @customer_cnic, @product_id, @product_price, @quantity, CURRENT_TIMESTAMP)", con);
                            cmd_orders_table.Parameters.AddWithValue("@order_no", order_no);

                            cmd_orders_table.Parameters.AddWithValue("@customer_cnic", dropdown_customer_id_main_billing_employee_form.Text);
                            cmd_orders_table.Parameters.AddWithValue("@product_id", product_id_text_box.Text);
                            cmd_orders_table.Parameters.AddWithValue("@product_price", temp_price);
                            cmd_orders_table.Parameters.AddWithValue("@quantity", product_quantity_text_box_main_billing_employee_form.Text);

                            cmd_orders_table.ExecuteNonQuery();
                            update_bill_tb();



                            cnic = dropdown_customer_id_main_billing_employee_form.Text;
                            total_bill = total_bill + temp_price*int.Parse(product_quantity_text_box_main_billing_employee_form.Text);

                            total_money_text_main_billing_employee_form.Text = total_bill.ToString();
                            count++;
                        }
                            
                    }

                    clear_text_box();
                    con.Close();
                    update_products_table();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void clear_text_box()
        {
            product_name_text_box_main_billing_employee_form.Text = "";
            product_id_text_box.Text = "";
            product_quantity_text_box_main_billing_employee_form.Text = "";
            price_text_box.Text = "";
        }

        private void search_product_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            if (product_name_text_box_main_billing_employee_form.Text == "")
            {
                MessageBox.Show("Please Fill the name field");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM product_tb WHERE product_name LIKE '{product_name_text_box_main_billing_employee_form.Text}%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    products_data_table_main_billing_employee_form.DataSource = dt;
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void show_all_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            update_products_table();
        }

        private void confirm_bill_button_main_billing_employee_form_Click(object sender, EventArgs e)
        {
            if(total_bill == 0)
            {
                MessageBox.Show("Please add some items first");
            }
            else
            {
                string message = "Bill paid?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    int old_order = order_no;
                    order_no++;
                    SqlCommand cmd = new SqlCommand("UPDATE order_no_tb SET order_no = @order_no WHERE order_no = @old_order", con);
                    cmd.Parameters.AddWithValue("@order_no", order_no);
                    cmd.Parameters.AddWithValue("@old_order", old_order);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd_update_total_tb = new SqlCommand("INSERT INTO total_bill_tb VALUES(@customer_cnic, @order_no, @total_bill, @bill_date, @employee_id)", con);
                    cmd_update_total_tb.Parameters.AddWithValue("@customer_cnic", cnic);
                    cmd_update_total_tb.Parameters.AddWithValue("@order_no", old_order);
                    cmd_update_total_tb.Parameters.AddWithValue("@total_bill", total_bill);
                    cmd_update_total_tb.Parameters.AddWithValue("@bill_date", DateTime.Now.ToShortDateString());
                    cmd_update_total_tb.Parameters.AddWithValue("@employee_id", cnic);
                    cmd_update_total_tb.ExecuteNonQuery();

                    total_bill = 0;
                    total_money_text_main_billing_employee_form.Text = "*";
                    con.Close();
                    update_products_table();
                    products_bill_data_table.Rows.Clear();
                    customers_panel_main_billing_employee_form.Visible = true;
                    panel1.Visible = false;
                    count = 0;
                }

            }
        }

        private void lock_customer_id_Click(object sender, EventArgs e)
        {
            if(dropdown_customer_id_main_billing_employee_form.Text == "")
            {
                MessageBox.Show("Select the customer id");
            }
            else
            {
                selected_cnic = dropdown_customer_id_main_billing_employee_form.Text;
                customers_panel_main_billing_employee_form.Visible = false;
                panel1.Visible = true;
            }
        }

        private void update_bill_after_delete(string id_passed)
        {
            for (int i = 0; i < products_bill_data_table.Rows.Count; i++)
            {
                if (products_bill_data_table.Rows[i].Cells[0].Value.ToString() == product_id_text_box.Text)
                {
                    products_bill_data_table.Rows.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }

        private void remove_item_bill_tb_Click(object sender, EventArgs e)
        {
            if(product_id_text_box.Text == "")
            {
                MessageBox.Show("Please fill the PID field");
            }
            else
            {
                string[] arr;
                int count_rows = products_bill_data_table.Rows.Count;
                int temp_cnt = 0;
                int ind_arr = 0;

                //get count
                for (int i = 0; i < count_rows; i++)
                {
                    if (products_bill_data_table.Rows[i].Cells[0].Value.ToString() == product_id_text_box.Text)
                    {
                        temp_cnt++;
                    }
                }


                if(temp_cnt == 0)
                {
                    MessageBox.Show("PID not found");
                }
                else
                {
                    try
                    {
                        con.Open();

                        SqlDataAdapter sda_price = new SqlDataAdapter("SELECT product_price FROM product_tb WHERE product_id = + '" + product_id_text_box.Text + "'", con);
                        DataTable dt_price = new DataTable();
                        sda_price.Fill(dt_price);


                        int price_fetched = int.Parse(dt_price.Rows[0][0].ToString());
                        int quantity = 0;
                        int index_of_product = 0;

                        for (int i = 0; i < products_bill_data_table.Rows.Count; i++)
                        {
                            if (products_bill_data_table.Rows[i].Cells[0].Value.ToString() == product_id_text_box.Text)
                            {
                                index_of_product = i;
                                quantity = quantity + int.Parse(products_bill_data_table.Rows[i].Cells[3].Value.ToString());
                            }
                        }

                        total_money_text_main_billing_employee_form.Text = Convert.ToString(int.Parse(total_money_text_main_billing_employee_form.Text.ToString()) - quantity * int.Parse(products_bill_data_table.Rows[index_of_product].Cells[2].Value.ToString()));
                        total_bill = int.Parse(total_money_text_main_billing_employee_form.Text);

                        SqlCommand cmd_products_tb = new SqlCommand("UPDATE product_tb SET product_quantity = product_quantity + '" + quantity + "' WHERE product_id = '" + product_id_text_box.Text + "'", con);
                        cmd_products_tb.ExecuteNonQuery();

                        SqlCommand cmd_orders_tb = new SqlCommand("DELETE FROM orders WHERE order_no = '" + order_no + "' AND product_id = '" + product_id_text_box.Text + "'", con);
                        cmd_orders_tb.ExecuteNonQuery();

                        MessageBox.Show("Product removed successfully");

                        update_bill_after_delete(product_id_text_box.Text);
                        con.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }

                }
            }
        }

        private void products_data_table_main_billing_employee_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                product_id_text_box.Text = products_data_table_main_billing_employee_form.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
