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
    public partial class login_form_customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public login_form_customer()
        {
            InitializeComponent();
            //Custom start position
            StartPosition = FormStartPosition.Manual;
            Left = 650;
            Top = 250;
            //
        }

        private void admin_button_login_form_Click(object sender, EventArgs e)
        {
            if (cnic_textbox_login_form.Text == "" || password_textbox_login_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                con.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from customer_tb where customer_cnic='" + cnic_textbox_login_form.Text + "'", con);

                    sda.Fill(dt);


                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT customer_password from customer_tb where customer_cnic = '" + cnic_textbox_login_form.Text + "'", con);
                        DataTable dt_1 = new DataTable();
                        sda_1.Fill(dt_1);

                        string real_password = dt_1.Rows[0][0].ToString();

                        if (password_textbox_login_form.Text == real_password)
                        {
                            customer_form cf = new customer_form(cnic_textbox_login_form.Text);
                            cf.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Invalid Credentials");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
        }

        private void login_employee_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form_employee lfe = new login_form_employee();
            this.Hide();
            lfe.Show();
        }

        private void login_admin_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form_admin lfa = new login_form_admin();
            this.Hide();
            lfa.Show();
        }
    }
}
