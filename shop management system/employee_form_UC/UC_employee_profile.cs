﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shop_management_system
{
    public partial class UC_employee_profile : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public UC_employee_profile()
        {
            InitializeComponent();
        }

        public UC_employee_profile(string cnic_passed, string name_passed)
        {
            InitializeComponent();

            cnic_value_label.Text = cnic_passed;
            name_value_label.Text = name_passed;

            //Fetching name and address

            SqlDataAdapter sda = new SqlDataAdapter("SELECT employee_address FROM employee_tb where employee_cnic = '" + cnic_passed + "'", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            address_value_label.Text = dt.Rows[0][0].ToString();

        }

        private void edit_button_main_home_employee_form_Click(object sender, EventArgs e)
        {
            if (old_password_text_box_main_home_employee_form.Text == "" || new_password_text_box_main_home_employee_form.Text == "")
            {
                MessageBox.Show("Please Fill out both the fields");
            }
            else
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from employee_tb where employee_cnic='" + cnic_value_label.Text + "' and employee_password ='" + old_password_text_box_main_home_employee_form.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                try
                {

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string query = "update employee_tb set employee_password=@enewpass where employee_cnic ='" + cnic_value_label.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@enewpass", new_password_text_box_main_home_employee_form.Text);
                        MessageBox.Show("Success");
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Issue");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
        }

        private void UC_employee_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
