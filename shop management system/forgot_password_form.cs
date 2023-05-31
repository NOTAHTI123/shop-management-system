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
using System.Net.Mail;
using System.Net;
using System.Linq.Expressions;
using System.Data.Common;

namespace shop_management_system
{
    public partial class forgot_password_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public forgot_password_form()
        {
            InitializeComponent();
        }

        private void forgot_password_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sending mail demo
            try
            {

                /*
                 First of all I have made an smtpclient object that will be used to set port, host, credentials and send message
                 I have also made a mailmessage object to set the sender and reciever email
                  */

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin_tb where admin_cnic = '"+ cnic_textbox.Text +"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("An account linked with the entered cnic not found");
                }

                else
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();


                    //To generate 6 digit random number
                    Random random = new Random();
                    int randomNumber = random.Next(100000, 999999);
                    //

                    try
                    {
                        SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT COUNT(*) FROM forgot_password_tb WHERE admin_cnic = '" + cnic_textbox.Text + "'", con);
                        DataTable dt_1 = new DataTable();
                        sda_1.Fill(dt_1);

                        if (int.Parse(dt_1.Rows[0][0].ToString()) > 0)
                        {
                            SqlCommand cmd_1 = new SqlCommand("DELETE FROM forgot_password_tb WHERE admin_cnic = @cnic", con);
                            cmd_1.Parameters.AddWithValue("@cnic", cnic_textbox.Text);

                            cmd_1.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //to store the code for future validation while updating the password in next form
                    SqlCommand cmd = new SqlCommand("INSERT INTO forgot_password_tb(admin_cnic, verification_code) VALUES(@cnic, @code)", con);
                    cmd.Parameters.AddWithValue("@cnic", cnic_textbox.Text);
                    cmd.Parameters.AddWithValue("@code", randomNumber.ToString());
                    cmd.ExecuteNonQuery();
                    //


                    //Get email
                    SqlDataAdapter sda_2 = new SqlDataAdapter("SELECT admin_email FROM admin_tb WHERE admin_cnic = '" + cnic_textbox.Text + "'", con);
                    DataTable dt_2 = new DataTable();
                    sda_2.Fill(dt_2);
                    string temp_mail = dt_2.Rows[0][0].ToString();
                    //
                    message.From = new MailAddress("shopmanagementsystem2.0@gmail.com"); // sender
                    message.To.Add(new MailAddress(temp_mail)); // reciever


                    message.Subject = "Your password reset code";
                    message.Body = $"YOUR 6 Digit code is : {randomNumber}";

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";

                    smtp.EnableSsl = true; // A type of security to ensure security while sending the email

                    smtp.Credentials = new NetworkCredential("shopmanagementsystem2.0@gmail.com", "bvbqqpvtdqnsfavn"); // setting credentials
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //To set the method how the email is going to be sent (i.e. via the network)
                    smtp.Send(message); // send the message

                    MessageBox.Show("An email has been sent to the registered email");
                    this.Hide();

                    reset_password_form rpf = new reset_password_form(cnic_textbox.Text, "admin");
                    rpf.Show();
                    
                }

                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            //sending mail demo
            try
            {

                /*
                 First of all I have made an smtpclient object that will be used to set port, host, credentials and send message
                 I have also made a mailmessage object to set the sender and reciever email
                  */

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM employee_tb where employee_cnic = '" + cnic_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("An account linked with the entered cnic not found");
                }

                else
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();


                    //To generate 6 digit random number
                    Random random = new Random();
                    int randomNumber = random.Next(100000, 999999);
                    //

                    try
                    {
                        SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT COUNT(*) FROM forgot_password_tb WHERE employee_cnic = '" + cnic_textbox.Text + "'", con);
                        DataTable dt_1 = new DataTable();
                        sda_1.Fill(dt_1);

                        if (int.Parse(dt_1.Rows[0][0].ToString()) > 0)
                        {
                            SqlCommand cmd_1 = new SqlCommand("DELETE FROM forgot_password_tb WHERE employee_cnic = @cnic", con);
                            cmd_1.Parameters.AddWithValue("@cnic", cnic_textbox.Text);

                            cmd_1.ExecuteNonQuery();

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //to store the code for future validation while updating the password in next form
                    SqlCommand cmd = new SqlCommand("INSERT INTO forgot_password_tb(employee_cnic, verification_code) VALUES(@cnic, @code)", con);
                    cmd.Parameters.AddWithValue("@cnic", cnic_textbox.Text);
                    cmd.Parameters.AddWithValue("@code", randomNumber.ToString());
                    cmd.ExecuteNonQuery();
                    //

                    //Get email
                    SqlDataAdapter sda_2 = new SqlDataAdapter("SELECT employee_email FROM employee_tb WHERE employee_cnic = '" + cnic_textbox.Text + "'", con);
                    DataTable dt_2 = new DataTable();
                    sda_2.Fill(dt_2);

                    string temp_mail = dt_2.Rows[0][0].ToString();
                    //


                    message.From = new MailAddress("shopmanagementsystem2.0@gmail.com"); // sender
                    message.To.Add(new MailAddress(temp_mail)); // reciever

                    message.Subject = "Your password reset code";
                    message.Body = $"YOUR 6 Digit code is : {randomNumber}";

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";

                    smtp.EnableSsl = true; // A type of security to ensure security while sending the email

                    smtp.Credentials = new NetworkCredential("shopmanagementsystem2.0@gmail.com", "bvbqqpvtdqnsfavn"); // setting credentials
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //To set the method how the email is going to be sent (i.e. via the network)
                    smtp.Send(message); // send the message

                    MessageBox.Show("An email has been sent to the registered email");
                    this.Hide();

                    reset_password_form rpf = new reset_password_form(cnic_textbox.Text, "employee");
                    rpf.Show();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            //sending mail demo
            try
            {

                /*
                 First of all I have made an smtpclient object that will be used to set port, host, credentials and send message
                 I have also made a mailmessage object to set the sender and reciever email
                  */

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM customer_tb where customer_cnic = '" + cnic_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("An account linked with the entered cnic not found");
                }

                else
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();


                    //To generate 6 digit random number
                    Random random = new Random();
                    int randomNumber = random.Next(100000, 999999);
                    //

                    try
                    {
                        SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT COUNT(*) FROM forgot_password_tb WHERE customer_cnic = '" + cnic_textbox.Text + "'", con);
                        DataTable dt_1 = new DataTable();
                        sda_1.Fill(dt_1);

                        if (int.Parse(dt_1.Rows[0][0].ToString()) > 0)
                        {
                            SqlCommand cmd_1 = new SqlCommand("DELETE FROM forgot_password_tb WHERE customer_cnic = @cnic", con);
                            cmd_1.Parameters.AddWithValue("@cnic", cnic_textbox.Text);

                            cmd_1.ExecuteNonQuery();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //to store the code for future validation while updating the password in next form
                    SqlCommand cmd = new SqlCommand("INSERT INTO forgot_password_tb(customer_cnic, verification_code) VALUES(@cnic, @code)", con);
                    cmd.Parameters.AddWithValue("@cnic", cnic_textbox.Text);
                    cmd.Parameters.AddWithValue("@code", randomNumber.ToString());
                    cmd.ExecuteNonQuery();
                    //

                    //Get email
                    SqlDataAdapter sda_2 = new SqlDataAdapter("SELECT customer_email FROM customer_tb WHERE customer_cnic = '" + cnic_textbox.Text + "'", con);
                    DataTable dt_2 = new DataTable();
                    sda_2.Fill(dt_2);

                    string temp_mail = dt_2.Rows[0][0].ToString();
                    //


                    message.From = new MailAddress("shopmanagementsystem2.0@gmail.com"); // sender
                    message.To.Add(new MailAddress(temp_mail)); // reciever

                    message.Subject = "Your password reset code";
                    message.Body = $"YOUR 6 Digit code is : {randomNumber}";

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";

                    smtp.EnableSsl = true; // A type of security to ensure security while sending the email

                    smtp.Credentials = new NetworkCredential("shopmanagementsystem2.0@gmail.com", "bvbqqpvtdqnsfavn"); // setting credentials
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //To set the method how the email is going to be sent (i.e. via the network)
                    smtp.Send(message); // send the message

                    MessageBox.Show("An email has been sent to the registered email");
                    this.Hide();

                    reset_password_form rpf = new reset_password_form(cnic_textbox.Text, "customer");
                    rpf.Show();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
