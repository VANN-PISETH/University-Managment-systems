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
    public partial class ClassforStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public ClassforStudent()
        {
            InitializeComponent();
            fillcomboxclass();
            fillcomboxclassssss();
            fillcombox();
        }
        public void fillcomboxclass()
        {
            string sql = "select * from Student_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string sname = da.GetString(0);
                    txtStuID.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void fillcombox()
        {
            string sql = "select * from Teacher_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string sname = da.GetString(1);
                    txtteacher.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void txtteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void StuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Student_tbl where StudentID ='" + txtStuID.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    //string code = da.GetInt32(0).ToString();
                    //string fee = da.GetString(2);
                    //txtmajorID.Text = code;
                    //txtfee.Text = fee;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void fillcomboxclassssss()
        {
            string sql = "select * from SetClass_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string sname = da.GetString(1);
                    txtclasss.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void txtclassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from SetClass_tbl where ClassName ='" + txtclasss.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string ClassID = da.GetInt32(0).ToString();
                    txtclassID.Text = ClassID;
                    //string code = da.GetInt32(0).ToString();
                    //string fee = da.GetString(2);
                    //txtmajorID.Text = code;
                    //txtfee.Text = fee;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dgvclass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            if (dgvclass.RowCount > 0)
            {
                con.Close();
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgvclass.Rows[i];
                txtclassID.Text = row.Cells[0].Value.ToString();
                txtStuID.Text = row.Cells[1].Value.ToString();
                txtclasss.Text = row.Cells[2].Value.ToString();
                txtteacher.Text = row.Cells[3].Value.ToString();
                txtstuff.Text = row.Cells[4].Value.ToString();
               
            }
        }
        public void InsertTrail()
        {
            try
            {
                SqlCommand cm;
                DateTime dt = DateTime.Now;
                string sql = @"INSERT INTO Systemlog_tbl VALUES(@Date,@Type,@Description,@Authority)";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Date", dt);
                cm.Parameters.AddWithValue("@Type", "Set Class");
                cm.Parameters.AddWithValue("@Description", "Student ID:" + txtStuID.Text + " has been Sat !");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. StudentID may already has a class !");
                MessageBox.Show(l.Message);
            }
        }
        private void btnregistrantion_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnshowstudent_Click(object sender, EventArgs e)
        {
          
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void txtclasss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtteacher_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sql = "select * from Teacher_tbl where Name ='" + txtteacher.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                   
                    string id = da.GetString(0);
                    //string fee = da.GetString(2);
                    txtteacherID.Text = id;
                    //txtfee.Text = fee;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void lblstuID_Click(object sender, EventArgs e)
        {

        }

        private void ClassforStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
          
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
          
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {

          

        }

        private void btngister_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                con.Open();
                sql = " Insert into[Class_tbl] values('" + txtclassID.Text + "', '" + txtStuID.Text + "', '" + txtclasss.Text + "', '" + txtteacher.Text + "', '" + txtstuff.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                InsertTrail();
                MessageBox.Show("Add Class Sucessfully");
                con.Close();
                btnshow_Click_1(sender, e);
            }
            catch//(Exception ex)
            {
                MessageBox.Show("This Student has a class");
                // MessageBox.Show(ex.Message);
            }
        }

        private void btnshow_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT *from Class_tbl; ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvclass.DataSource = dt;
                    }
                }
            }
        }

        private void btnmotify_Click(object sender, EventArgs e)
        {
            string cl;
            cl = txtclasss.Text;
            SqlCommand cmd;
            cmd = new SqlCommand("update Class_tbl set ClassID=@ClassID,Class=@Class,Teacher=@Teacher,Stuff=@Stuff where StuID=@StID", con);
            con.Close();
            con.Open();
            cmd.Parameters.AddWithValue("@StID", txtStuID.Text);
            cmd.Parameters.AddWithValue("@ClassID", txtclassID.Text);
            cmd.Parameters.AddWithValue("@Class", cl);
            cmd.Parameters.AddWithValue("@Teacher", txtteacher.Text);
            cmd.Parameters.AddWithValue("@Stuff", txtstuff.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            btnshow_Click_1(sender, e);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Class_tbl where StuID = @ID", con);
            cmd.Parameters.AddWithValue("@Id", txtStuID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Removed from class Succesfully");
            btnshow_Click_1(sender, e);
            con.Close();
            txtStuID.SelectedIndex = -1;
            txtclasss.SelectedIndex = -1;
            txtclassID.Clear();
            txtteacherID.Clear();
            txtteacher.SelectedIndex = -1;
            txtstuff.SelectedIndex = -1;
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            txtStuID.SelectedIndex = -1;
            txtclasss.SelectedIndex = -1;
            txtclassID.Clear();
            txtteacherID.Clear();
            txtteacher.SelectedIndex = -1;
            txtstuff.SelectedIndex = -1;
            dgvclass.DataSource = null;
        }
    }
}
