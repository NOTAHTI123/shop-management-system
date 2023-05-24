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
    public partial class signup_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public signup_form()
        {
            InitializeComponent();
            //Custom start position
            StartPosition = FormStartPosition.Manual;
            Left = 650;
            Top = 250;
            //
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (phone_text_box.Text == "" || cnic_textbox_signup_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }

            else
            {
                try
                {
                    con.Open();

                    if (name_text_box.Text != "" && address_text_box.Text != "")
                    {
                        signup_options_form sof = new signup_options_form(cnic_textbox_signup_form.Text, name_text_box.Text, address_text_box.Text, email_text_box.Text, phone_text_box.Text, password_textbox_signup_form.Text, dateTimePicker1.Value.Date.ToString());
                        sof.Show();
                    }

                    con.Close();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show("The CNIC already exists");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form_employee lf = new login_form_employee();
            this.Hide();
            lf.Show();
        }
    }
}
