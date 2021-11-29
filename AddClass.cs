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
    public partial class AddClass : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public AddClass()
        {
            InitializeComponent();
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
                cm.Parameters.AddWithValue("@Type", "Add Class");
                cm.Parameters.AddWithValue("@Description", "Class ID:" + txtclasssID.Text + " has been Added !");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Again. Class may already Add !");
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
        private void Refreshing()
        {
            string px;
            string query = "select MAX(ClassID) from SetClass_tbl";
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                px = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                px = ("111");
            }
            else
            {
                px = ("111");
            }
           
            txtclasssID.Text = px.ToString();
            con.Close();

        }
        private void Class_Load(object sender, EventArgs e)
        {
            Refreshing();
        }

     

        private void dgvAddClass_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            if (dgvAddClass.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgvAddClass.Rows[i];
                txtclasssID.Text = row.Cells[0].Value.ToString();
                txtClassName.Text = row.Cells[1].Value.ToString();


            }
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

        private void panelClass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btngister_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                con.Open();
                sql = "Insert into[SetClass_tbl] values('" + txtclasssID.Text + "', '" + txtClassName.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();
                InsertTrail();

                MessageBox.Show("Add Class Sucessfully");
                con.Close();
                Refreshing();
                btnshow_Click_1(sender, e);
            }
            catch// (Exception ex)
            {
                MessageBox.Show("ClassID already Takend");
                //  MessageBox.Show(ex.Message);
            }
        }

        private void btnshow_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT *from SetClass_tbl; ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvAddClass.DataSource = dt;
                    }
                }
            }
        }

        private void btnmotify_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("update SetClass_tbl set ClassName=@Class where ClassID=@ClassID", con);
            con.Close();
            con.Open();

            cmd.Parameters.AddWithValue("@ClassID", txtclasssID.Text);
            cmd.Parameters.AddWithValue("@Class", txtClassName.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            btnshow_Click_1(sender, e);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete SetClass_tbl where ClassID=@ClassID", con);
            cmd.Parameters.AddWithValue("@ClassId", txtclasssID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Removed from class Succesfully");
            btnshow_Click_1(sender, e);
            //  
            con.Close();
            Refreshing();
            txtClassName.Clear();
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            //  txtclasssID.ResetText();

            txtClassName.Clear();
            dgvAddClass.DataSource = null;
            Refreshing();
        }
    }
}
