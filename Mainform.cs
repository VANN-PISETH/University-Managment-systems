using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace WindowsFormsApp1
{
    public partial class Mainform : Form
    {
       
       // private IconButton Currentbtn;
        private Panel leftBorderbtn;
        private Form currentChildForm;

        public Mainform()
        {
            InitializeComponent();
            customize();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            panelManu.Controls.Add(leftBorderbtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
           
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneldesktop.Controls.Add(childForm);
            paneldesktop.Tag = childForm;
            childForm.BringToFront(); childForm.Show();
            lblhome.Text = childForm.Text;
        }
    
        
           // panelDesktop.Controls.Add(childForm); }// panelDesktop.Tag = childForm; childForm.BringToFront (); childForm.Show (); lblTitleChildForm.Text = childForm.Text;}
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(249, 118, 176);
            public static Color color8 = Color.FromArgb(95, 77, 221);


        }
        private void Activatebtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Disble();
                //Currentbtn = (IconButton)senderBtn;
                //Currentbtn.BackColor = Color.FromArgb(37, 36, 81);

                //Currentbtn.ForeColor = color;
                //Currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                //Currentbtn.IconColor = color;
                //Currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderbtn.BackColor = color;
                //leftBorderbtn.Location = new Point(0, Currentbtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
                //iconcurrent1.IconChar = Currentbtn.IconChar;
                //iconcurrent1.IconColor = color;
                
                
            }
        }
        private void Disble()
        {
            //if (Currentbtn != null)
            //{
            //    Currentbtn.BackColor = Color.FromArgb(31, 30, 68);
            //    Currentbtn.ForeColor = Color.White;
            //    Currentbtn.TextAlign = ContentAlignment.MiddleLeft;
            //    Currentbtn.IconColor = Color.White;

            //    Currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            //    Currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            //}

        }
        private void customize()
        {
            panelhidestudent.Visible = false;
        }

        private void hide()
        {
            if (panelhidestudent.Visible == true)
                panelhidestudent.Visible = false;
        }

        private void showSub(Panel sunmanu)
        {
            if(sunmanu.Visible == false)
            {
                hide();
                sunmanu.Visible = true;
            }
            else
            {
                sunmanu.Visible = false;
            }
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            hide();
            OpenChildForm(new Registrationform());
        }

        private void btninformationstudent_Click(object sender, EventArgs e)
        {
            hide();
            OpenChildForm(new InformationStudentForm());

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            showSub(panelhidestudent);
           Activatebtn(sender, RGBColors.color2);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color3);
            OpenChildForm(new Class());

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color1);
           
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color5);
            OpenChildForm(new Attendance());
        }

        private void btnmajor_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color6);
            OpenChildForm(new Teacher());
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color4);
            OpenChildForm(new Payment());
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color7);
            OpenChildForm(new Income());

        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color8);
            OpenChildForm(new Setting());
        }

        private void Btnhome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            Disble();
            leftBorderbtn.Visible = false;
            customize();
            //iconcurrent1.IconChar =IconChar.Home;
            //iconcurrent1.IconColor = Color.DarkViolet;
            lblhome.Text = "Home";

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport ("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnhome_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btnmark_Click(object sender, EventArgs e)
        { 
           Activatebtn(sender, RGBColors.color3);
            OpenChildForm(new Mark());
        }

        private void paneltitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void Mainform_Load(object sender, EventArgs e)
        {
            //// Scale our form to look like it did when we designed it.
            //// This adjusts between the screen resolution of the design computer and the workstation.
            //int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            //int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            //float scaleFactorWidth = (float)ourScreenWidth / 1920f;
            //float scaleFactorHeigth = (float)ourScreenHeight / 1080f;
            //SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            //Scale(scaleFactor);
            //// If you want to center the resized screen.
            //CenterToScreen();


            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Dashboard dss = new Dashboard();
            //dss.Show();
            //paneldesktop.SetShadowForm(this);
            paneldesktop.Controls.Clear();
            Dashboard frm = new Dashboard();
            frm.TopLevel = false;
            paneldesktop.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void paneldesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsystemlog_Click(object sender, EventArgs e)
        {
            Activatebtn(sender, RGBColors.color4);
            OpenChildForm(new Systemlog());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
          
        }

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // Activatebtn(sender, RGBColors.color4);
            OpenChildForm(new Systemlog());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            showSub(panelhidestudent);
            //Activatebtn(sender, RGBColors.color2);
        }

        private void btnregistration_Click(object sender, EventArgs e)
        {
            hide();
            OpenChildForm(new Registrationform());
        }

        private void btnshowinformation_Click(object sender, EventArgs e)
        {
            hide();
            OpenChildForm(new InformationStudentForm());
        }

        private void panelManu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click_1(object sender, EventArgs e)
        {
           //hide();
            OpenChildForm(new Dashboard());
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            //hide();
            OpenChildForm(new Teacher());
        }

        private void btnclass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Class());
        }

        private void btnattendance_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Attendance());
        }

        private void btngrade_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Mark());
        }

        private void btnpayment_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Payment());
        }

        private void btnreport_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Income());
        }

        private void btnsystemlog_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Systemlog());
        }

        private void btnsetting_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Setting());
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            // Activatebtn(sender, RGBColors.color3);
            this.Hide();
            LogIn main = new LogIn();
            main.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
    }
}
