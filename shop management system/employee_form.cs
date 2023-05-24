using FontAwesome.Sharp;
using shop_management_system.employee_form_UC;
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
    public partial class employee_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        private IconButton currentbutton;

        public employee_form()
        {
            InitializeComponent();
        }

        string cnic;
        public employee_form(string cnic_passed)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;

            cnic = cnic_passed;

            //Fetch name
            SqlDataAdapter sda = new SqlDataAdapter("SELECT employee_name from employee_tb where employee_cnic = '" + cnic_passed + "'", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            profile_button.Text = dt.Rows[0][0].ToString();
            UC_employee_profile ucp = new UC_employee_profile(cnic, profile_button.Text);
            addUserControl(ucp);
            ActivateButton(profile_button, RGBColors.color1);


        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill; //usercontrol is the object
            uc_panel.Controls.Clear(); //clears previous usercontrol
            uc_panel.Controls.Add(userControl); //Like this.controls.add() but this is for the panel
            userControl.BringToFront();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            reset();
            UC_employee_profile ucp = new UC_employee_profile(cnic, profile_button.Text);
            addUserControl(ucp);
            ActivateButton(sender, RGBColors.color1);
        }

        private void top_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void products_button_Click(object sender, EventArgs e) //billing button
        {
            reset();
            UC_Billing_emp ube = new UC_Billing_emp(cnic);
            addUserControl(ube);
            ActivateButton(sender, RGBColors.color2);
        }

        private void uc_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        //the following method is used for coloring of activated button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Button
                reset();
                currentbutton = (IconButton)senderBtn; //As I am using font awesome, i have to convert to btn
                //currentbutton.BackColor = Color.FromArgb(37, 36, 81);
                currentbutton.ForeColor = color;
                currentbutton.IconColor = color;
                currentbutton.TextAlign = ContentAlignment.MiddleRight;
                currentbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbutton.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        //colors
        private struct RGBColors //Colors stored by me
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void DisableButton() //using this to restore original layout of button
        {
            if (currentbutton != null) //currentbutton stores the previous button in this case
            {
                currentbutton.BackColor = Color.MidnightBlue;
                currentbutton.ForeColor = Color.Gainsboro;
                currentbutton.TextAlign = ContentAlignment.MiddleLeft;
                currentbutton.IconColor = Color.Gainsboro;
                currentbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbutton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            login_form_employee lf = new login_form_employee();
            lf.Show();
            this.Hide();
        }

        //To reset colors
        private void reset()
        {
            DisableButton();
        }


        ////

    }
}
