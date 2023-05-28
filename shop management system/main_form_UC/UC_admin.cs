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
            if(admin_name_text_box_main_admin_form.Text == "" || admin_address_text_box_main_admin_form.Text == "" || password_text_box_main_admin_form.Text == "" || admin_email_text_box.Text == "" || employee_idtext_box_main_employee_form.Text == "" || admin_phone_text_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                con.Open();

                try
                {
                    //admin TB
                    SqlCommand cmd_1 = new SqlCommand("INSERT INTO admin_tb VALUES(@cnic, @name, @pass, @address, @email)", con);
                    cmd_1.Parameters.AddWithValue("@cnic", employee_idtext_box_main_employee_form.Text);
                    cmd_1.Parameters.AddWithValue("@name", admin_name_text_box_main_admin_form.Text);
                    cmd_1.Parameters.AddWithValue("@pass", password_text_box_main_admin_form.Text);
                    cmd_1.Parameters.AddWithValue("@address", admin_address_text_box_main_admin_form.Text);
                    cmd_1.Parameters.AddWithValue("@email", admin_email_text_box.Text);

                    cmd_1.ExecuteNonQuery();

                    //phone TB
                    SqlCommand cmd_2 = new SqlCommand("INSERT INTO admin_phone VALUES(@cnic, @phone)", con);
                    cmd_2.Parameters.AddWithValue("@cnic", employee_idtext_box_main_employee_form.Text);
                    cmd_2.Parameters.AddWithValue("@phone", admin_phone_text_box_main_employee_form.Text);

                    cmd_2.ExecuteNonQuery();
                    MessageBox.Show("Admin account created successfully");
                    update_dgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void edit_button_main_admin_form_Click(object sender, EventArgs e)
        {
            if (admin_name_text_box_main_admin_form.Text == "" || admin_address_text_box_main_admin_form.Text == "" || password_text_box_main_admin_form.Text == "" || admin_email_text_box.Text == "" || employee_idtext_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin_tb WHERE admin_cnic = '" + employee_idtext_box_main_employee_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if(cnt == 1)
                    {
                        SqlCommand cmd = new SqlCommand("update admin_tb set admin_name = @ename, admin_password = @epass, admin_address = @eaddress WHERE admin_cnic = @cnic", con);

                        cmd.Parameters.AddWithValue("@ename", admin_name_text_box_main_admin_form.Text);
                        cmd.Parameters.AddWithValue("@eaddress", admin_address_text_box_main_admin_form.Text);
                        cmd.Parameters.AddWithValue("@ephone", admin_phone_text_box_main_employee_form.Text);
                        cmd.Parameters.AddWithValue("@epass", password_text_box_main_admin_form.Text);
                        cmd.Parameters.AddWithValue("@cnic", employee_idtext_box_main_employee_form.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin's data edited successfully");

                    }

                    else
                    {
                        MessageBox.Show("The CNIC entered not found");
                    }
                    con.Close();

                    update_dgv();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void data_table_main_admin_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employee_idtext_box_main_employee_form.Text =  data_table_main_admin_form.SelectedRows[0].Cells[0].Value.ToString();
            admin_name_text_box_main_admin_form.Text = data_table_main_admin_form.SelectedRows[0].Cells[1].Value.ToString();
            password_text_box_main_admin_form.Text = data_table_main_admin_form.SelectedRows[0].Cells[2].Value.ToString();
            admin_address_text_box_main_admin_form.Text = data_table_main_admin_form.SelectedRows[0].Cells[3].Value.ToString();
            admin_email_text_box.Text = data_table_main_admin_form.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void delete_button_main_admin_form_Click(object sender, EventArgs e)
        {
            if (employee_idtext_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Enter the Admin ID");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin_tb WHERE admin_cnic = '" + employee_idtext_box_main_employee_form.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int cnt = int.Parse(dt.Rows[0][0].ToString());

                    if(cnt == 1)
                    {
                        SqlCommand cmd_2 = new SqlCommand("delete from admin_phone  where admin_cnic=@eid", con);
                        cmd_2.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);

                        cmd_2.ExecuteNonQuery();


                        SqlCommand cmd = new SqlCommand("delete from admin_tb  where admin_cnic=@eid", con);
                        cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);

                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Admin's data deleted successfully");

                    }
                    else
                    {
                        MessageBox.Show("No account found against the entered CNIC");
                    }
                    con.Close();

                    update_dgv();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
