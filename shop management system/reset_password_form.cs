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
    public partial class reset_password_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");
        string current_reset_acc_type;
        public reset_password_form()
        {
            InitializeComponent();
        }

        public reset_password_form(string cnic_passed, string acc_type)
        {
            InitializeComponent();
            cnic_value_label.Text = cnic_passed;
            current_reset_acc_type = acc_type;
        }

        private void reset_password_form_Load(object sender, EventArgs e)
        {

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            if (current_reset_acc_type == "employee")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT verification_code FROM forgot_password_tb where employee_cnic = '" + cnic_value_label.Text + "'", con);
                
                sda.Fill(dt);

            }
            else if(current_reset_acc_type == "admin")
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT verification_code FROM forgot_password_tb where admin_cnic = '" + cnic_value_label.Text + "'", con);
                
                sda.Fill(dt);
            }

            else if(current_reset_acc_type == "customer")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT verification_code FROM forgot_password_tb where customer_cnic = '" + cnic_value_label.Text + "'", con);

                sda.Fill(dt);
            }

            if(verification_code_text_box.Text != dt.Rows[0][0].ToString() )
            {
                MessageBox.Show("The verification code is not valid");
            }
            else
            {
                gb2.Visible = false;
                gb1.Visible = true;
            }
            con.Close();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if(new_password_text_box.Text != re_enter_password_text_box.Text)
            {
                MessageBox.Show("The entered passwords don't match");
            }
            else
            {
                con.Open();

                if(current_reset_acc_type == "employee")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE employee_tb SET employee_password = @pass WHERE employee_cnic = @cnic", con);
                    cmd.Parameters.AddWithValue("@pass", new_password_text_box.Text);
                    cmd.Parameters.AddWithValue("@cnic", cnic_value_label.Text);
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand("DELETE from forgot_password_tb where employee_cnic =  @cnic");
                    cmd2.Parameters.AddWithValue("@cnic", cnic_value_label.Text);
                    cmd2.Connection = con;

                    cmd2.ExecuteNonQuery();

                }

                else if(current_reset_acc_type == "admin")
                {

                    SqlCommand cmd = new SqlCommand("UPDATE admin_tb SET admin_password = @pass WHERE admin_cnic = @cnic", con);
                    cmd.Parameters.AddWithValue("@pass", new_password_text_box.Text);
                    cmd.Parameters.AddWithValue("@cnic", cnic_value_label.Text);
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand("DELETE from forgot_password_tb where admin_cnic =  @cnic");
                    cmd2.Parameters.AddWithValue("@cnic", cnic_value_label.Text);
                    cmd2.Connection = con;

                    cmd2.ExecuteNonQuery();
                }

                else if(current_reset_acc_type == "customer")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE customer_tb SET customer_password = @pass WHERE customer_cnic = @cnic", con);
                    cmd.Parameters.AddWithValue("@pass", new_password_text_box.Text);
                    cmd.Parameters.AddWithValue("@cnic", cnic_value_label.Text);
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand("DELETE from forgot_password_tb where customer_cnic =  @cnic");
                    cmd2.Parameters.AddWithValue("@cnic", cnic_value_label.Text);
                    cmd2.Connection = con;

                    cmd2.ExecuteNonQuery();
                }
                con.Close();

                MessageBox.Show("Password Updated");
                this.Hide();

            }
        }
    }
}
