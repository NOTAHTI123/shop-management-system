using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using shop_management_system.main_form_UC;

namespace shop_management_system
{
    public partial class main_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        string cnic, name;

        private IconButton currentbutton;
        public main_form()
        {
            InitializeComponent();

            //Custom start position
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            //
        }


        public main_form(string cnic_passed) //custom constructor
        {
            InitializeComponent();

            //Fetching name

            SqlDataAdapter sda = new SqlDataAdapter("SELECT admin_name from admin_tb where admin_cnic = '" + cnic_passed + "'", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);


            cnic = cnic_passed;

            profile_button.Text = dt.Rows[0][0].ToString();

            //Custom start position
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;


            //The following code is to automatically open dashboard user control on login
            UserControl ucprofile = new UC_admin_profile();
            addUserControl(ucprofile);
            ActivateButton(profile_button, RGBColors.color1);
            //
        }


        private void mainform_Load(object sender, EventArgs e)
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

        private void addUserControl(UserControl userControl) //Tabs
        {
            userControl.Dock = DockStyle.Fill; //usercontrol is the object
            uc_panel.Controls.Clear(); //clears previous usercontrol
            uc_panel.Controls.Add(userControl); //Like this.controls.add() but this is for the panel
            userControl.BringToFront();
        }


        //Buttons

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color2); //To change color

            UC_Dashboard ucd = new UC_Dashboard();
            addUserControl(ucd);
        }
        private void employee_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color4);

            UC_Employees uce = new UC_Employees();
            addUserControl(uce);
        }


        private void products_button_Click_1(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color6);

            UC_Product ucp = new UC_Product();
            addUserControl(ucp);

        }

        private void customers_button_Click_1(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color5);

            UC_Customers ucp = new UC_Customers();
            addUserControl(ucp);
        }

        private void analytics_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color3);

            UC_Analytics uca = new UC_Analytics();
            addUserControl(uca);
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color6);
        }



        private void cross_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //To reset colors
        private void reset()
        {
            DisableButton();
        }


        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void uc_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form_employee lf = new login_form_employee();
            lf.Show();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color5);

            UC_admin_profile uC_Admin_Profile = new UC_admin_profile(cnic, profile_button.Text);

            addUserControl(uC_Admin_Profile);


        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            reset();
            UC_admin uca = new UC_admin();
            ActivateButton(sender, RGBColors.color5);
            addUserControl(uca);
        }

        private void top_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
