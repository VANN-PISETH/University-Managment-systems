using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public LogIn()
        {
            InitializeComponent();
           
        }
        //private ChildForm childForm;
        //private MoreForm moreForm;
        //private void OpenChildForm(Form childForm)
        //{
        //    if (currentChildForm != null)
        //    {
        //        currentChildForm.Close();
        //    }
        //    currentChildForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //   // paneldesktop.Controls.Add(childForm);
        //   // paneldesktop.Tag = childForm;
        //    childForm.BringToFront(); childForm.Show();
        //   // lblhome.Text = childForm.Text;
        //}
        private void paneltoplogin_Paint(object sender, PaintEventArgs e)
        {

        }
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Mainform());
        //}
        private void btnsignin_Click(object sender, EventArgs e)
        {
            //  OpenChildForm(new Mainform());

            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                MessageBox.Show("Please Input username", "Missing");

            }
            if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                MessageBox.Show("Please Input password", "Missing");

            }
            //// Declare 
            //SqlCommand cmd;     // Write sql command
            //SqlDataAdapter da;  // Transit data from database
            //DataTable dt;         // Store table in memory
            ////input
            //con.Close();
            //con.Open();
            //cmd = new SqlCommand("Select * from Login_tbl where Username ='" +
            //    txtusername.Text + "' and Password = '" + txtpassword.Text + "'", con);
            //da = new SqlDataAdapter(cmd);   // select username and password in db
            //dt = new DataTable();             // Table in memory
            //da.Fill(dt);                    // Fill data in table into memory 
            //if (dt.Rows.Count > 0)
            //{
            //    //DataRow dr = dt.Rows[0];
            //    //Operation.Username = dr[0].ToString();
            //    //Operation.Password = dr[2].ToString();
            //    // label2.Text = "Login successfully";
            //    //con.Close();
            //    this.Hide();
            //    Mainform mf = new Mainform();
            //    mf.ShowDialog();
            //    this.Close();
            //}


            //else
            //{
            //    MessageBox.Show("Invalid Username or Password !");
            //}

            //con.Close();
            //// Main();
            ////Application.EnableVisualStyles();
            ////Application.SetCompatibleTextRenderingDefault(false);
            ////Application.Run(new Mainform());
            string sql;
            con.Close();
            con.Open();
            sql = "select * from Login_tbl where UserName ='"+txtusername.Text+"' and password ='"+txtpassword.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                Mainform mf = new Mainform();
                mf.ShowDialog();
                this.Close();
            }
                

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
          



          
        }

        private void btnsignup_Click_1(object sender, EventArgs e)
        {
            panelforlogin.Visible = false;
            panelsignup.Visible = true;
            guna2Transition1login.HideSync(panelforlogin);
            guna2Transition1login.ShowSync(panelsignup);
        }

        private void txtbacktologin_Click(object sender, EventArgs e)
        {
          
           
            
        }

        private void btncreate_Click(object sender, EventArgs e)
        {

        }

        private void txtbacktologin_Click_1(object sender, EventArgs e)
        {
            panelsignup.Visible = false;
            panelforlogin.Visible = true;
            guna2Transition1login.HideSync(panelsignup);
            guna2Transition1login.ShowSync(panelforlogin);
        }

        private void btncreate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsignupusername.Text.Trim()))
            {
                MessageBox.Show("Please Input New username", "Missing");

            }
            if (string.IsNullOrEmpty(txtnewpassword.Text.Trim()))
            {
                MessageBox.Show("Please Input New password", "Missing");

            }
            try
            {
                // Declare 
                String sql;
            SqlDataAdapter da = new SqlDataAdapter();
            String Username, email, password, confirmPassoword;

            Username = txtsignupusername.Text;
            email = txtemail.Text;
            password = txtnewpassword.Text;
            confirmPassoword = txtconfirm.Text;
                con.Close();
                con.Open();
                sql = "Insert into Login_tbl ([Username] , [Email] , [Password] , [CPassword])" + "values ('" + Username + "', '" + email + "', '" + password + "' , '" + confirmPassoword + "')";
                da.InsertCommand = new SqlCommand(sql, con);    //transit to database 
                da.InsertCommand.ExecuteNonQuery();             // Insert into table

                // Output
                MessageBox.Show("Account has been created sucessfully !");
                con.Close();
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Can't Create This User name !");
            }
        }

        private void labelforgetpassword_Click(object sender, EventArgs e)
        {
            panelforlogin.Visible = false;
            panelsignup.Visible = true;
            guna2Transition1login.HideSync(panelforlogin);
            guna2Transition1login.ShowSync(panelsignup);
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {


        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }





        //More_Click()
        //{
        //    childForm.Close();
        //    moreForm = new Mainform();
        //    moreForm.Show();

        //}
    }
}
