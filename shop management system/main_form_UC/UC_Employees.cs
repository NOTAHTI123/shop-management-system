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
    public partial class UC_Employees : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");
        public UC_Employees()
        {
            InitializeComponent();
            update_data_table();
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {

        }
        private void update_data_table()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select employee_cnic, employee_name, employee_address, employee_dob from employee_tb", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            data_table_main_employee_form.DataSource = dt;


            data_table_main_employee_form.Columns[0].Width = 120;
            data_table_main_employee_form.Columns[1].Width = 130;
            data_table_main_employee_form.Columns[2].Width = 140;
            data_table_main_employee_form.Columns[3].Width = 160;


            con.Close();
        }

        private void add_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (employee_idtext_box_main_employee_form.Text == "" || employee_phone_text_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }

            else
            {
                try
                {
                    con.Open();

                    //Insert in main table

                    if(employee_name_text_box_main_employee_form.Text != "" || employee_address_text_box_main_employee_form.Text != "")
                    {

                        SqlCommand cmd = new SqlCommand("insert into employee_tb (employee_cnic, employee_name, employee_address, employee_dob, employee_password, employee_email)values(@eid, @ename, @eaddress, @edob, @epass, @email)", con);
                        cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);
                        cmd.Parameters.AddWithValue("@ename", employee_name_text_box_main_employee_form.Text);
                        cmd.Parameters.AddWithValue("@eaddress", employee_address_text_box_main_employee_form.Text);
                        cmd.Parameters.AddWithValue("@edob", date_select_main_employee_form.Value);
                        cmd.Parameters.AddWithValue("@epass", password_text_box_main_employee_form.Text);
                        cmd.Parameters.AddWithValue("@email", employee_email_text_box.Text);
                        cmd.ExecuteNonQuery();
                    }

                    SqlCommand cmd_2 = new SqlCommand("INSERT INTO employee_phone VALUES(@eid, @ephone)", con);
                    cmd_2.Parameters.AddWithValue("@ephone", employee_phone_text_box_main_employee_form.Text);
                    cmd_2.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);

                    cmd_2.ExecuteNonQuery();

                    MessageBox.Show("Employee added successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void edit_button_main_employee_form_Click(object sender, EventArgs e)
        {
            if (employee_idtext_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Enter the Employee ID");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update employee_tb set employee_name = @ename, employee_address = @eaddress, employee_phone = @ephone, employee_password=@epass where employee_cnic=@eid", con);
                    cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@ename", employee_name_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@eaddress", employee_address_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@ephone", employee_phone_text_box_main_employee_form.Text);
                    cmd.Parameters.AddWithValue("@edob", date_select_main_employee_form.Value);
                    cmd.Parameters.AddWithValue("@epass", password_text_box_main_employee_form.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee's data edited successfully");
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
            if (employee_idtext_box_main_employee_form.Text == "")
            {
                MessageBox.Show("Please Enter the Employee ID");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd_2 = new SqlCommand("delete from employee_phone  where employee_cnic=@eid", con);
                    cmd_2.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);

                    cmd_2.ExecuteNonQuery();


                    SqlCommand cmd = new SqlCommand("delete from employee_tb  where employee_cnic=@eid", con);
                    cmd.Parameters.AddWithValue("@eid", employee_idtext_box_main_employee_form.Text);

                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Employee's data deleted successfully");
                    con.Close();

                    update_data_table();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void data_table_main_employee_form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                employee_name_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[1].Value.ToString();
                employee_address_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[2].Value.ToString();
                password_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[5].Value.ToString();
                employee_idtext_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[0].Value.ToString();
                employee_phone_text_box_main_employee_form.Text = data_table_main_employee_form.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
