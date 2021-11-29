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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Registrationform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Registrationform()
        {
            InitializeComponent();
            fillcombox();
        }
        string img = "";
        private void btnaddpic_Click(object sender, EventArgs e)
        {
          
        }


        private void panelregistration_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fillcombox()
        {
            string sql = "select * from SetMajor_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string sname = da.GetString(1);
                    txtmajor.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void Refreshing()
        {
            string px;
            string query = "select MAX(StudentID) from Student_tbl";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                px = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                px = ("00001");
            }
            else
            {
                px = ("00001");
            }
            con.Close();
            txtstudentID.Text = px.ToString();

        }
        //       
        //[PlaceID] NCHAR(10)    NULL,

        public void InsertTrail()
        {
            try
            {
                SqlCommand cm;
                DateTime dt = DateTime.Now;
                string sql = @"INSERT INTO Systemlog_tbl VALUES(@Date,@Type,@Description,@Authority)";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Date", dt);
                cm.Parameters.AddWithValue("@Type", "Registration");
                cm.Parameters.AddWithValue("@Description", "Student ID:" + txtstudentID.Text + " has been register !");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. StudentID may already be taken!");
                MessageBox.Show(l.Message);
            }
        }
        private void btnregistrantion_Click(object sender, EventArgs e)
        {
        }

        private void Registrationform_Load(object sender, EventArgs e)
        {
            Refreshing();
        }

        private void txtmajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from SetMajor_tbl where Majorset ='" + txtmajor.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string code = da.GetInt32(0).ToString();
                    string fee = da.GetString(2);
                    txtmajorID.Text = code;
                    txtfee.Text = fee;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnclearregistration_Click(object sender, EventArgs e)
        {
           



        }

        private void txtstudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelmajor_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            

              

            }

        private void btnclear_Click(object sender, EventArgs e)
        {
           

        }

        private void btnaddphoto_Click(object sender, EventArgs e)
        {
          
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtcityprovince.SelectedIndex = -1;
            txtcountry.SelectedIndex = -1;
            txtdegree.SelectedIndex = -1;
            txtemail.Clear();
            txtfee.Clear();
            txtfisrtname.Clear();
            txtfullname.Clear();
            txtlastname.Clear();
            txtmajor.SelectedIndex = -1;
            txtmajorID.Clear();
            txtparentname.Clear();
            txtparentnum.Clear();
            txtphonenum.Clear();
            txtpicstudent.Image = null;
            txtplaceofbirth.SelectedIndex = -1;
            txtsex.SelectedIndex = -1;
            txtstatus.SelectedIndex = -1;
            txtdataofjoin.ResetText();
            txtdateofbirth.ResetText();
        }

        private void btngister_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image = null;
                FileStream fs = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                string date = txtdateofbirth.Text;
                string date2 = txtdataofjoin.Text;
                string sql;
                con.Open();
                sql = " Insert into[Major_tbl] values('" + txtmajorID.Text + "', '" + txtstudentID.Text + "', '" + txtdegree.Text + "', '" + txtmajor.Text + "', '" + txtfee.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into [Student_tbl] values ('" + txtstudentID.Text + "','" + txtfullname.Text + "','" + txtsex.Text + "','" + date2 + "','" + txtstatus.Text + "','" + date2 + "','" + txtparentname.Text + "',@Imgg)";
                cmd.Parameters.Add(new SqlParameter("@Imgg", image));
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into [About_tbl] values('" + txtstudentID.Text + "', '" + txtemail.Text + "', '" + txtphonenum.Text + "', '" + txtparentnum.Text + "', '" + txtplaceofbirth.Text + "', '" + txtcityprovince.Text + "', '" + txtcountry.Text + "', '" + txtaddress.Text + "' )";
                cmd.ExecuteNonQuery();
                InsertTrail();
                MessageBox.Show("Registration Sucessfully");

                con.Close();
                Refreshing();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void btnaddphoto_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                img = open.FileName.ToString();
                txtpicstudent.ImageLocation = img;

            }
        }
    }
    }
