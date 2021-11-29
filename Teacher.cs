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
    public partial class Teacher : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Teacher()
        {
            InitializeComponent();
        }
        private void Refreshing()
        {
            string px;
            string query = "select MAX(TeacherID) from Teacher_tbl";
            con.Close();
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
            txtid.Text = px.ToString();

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
                cm.Parameters.AddWithValue("@Type", "Add Teacher");
                cm.Parameters.AddWithValue("@Description", "Teacher ID:" + txtid.Text + " has been Added !");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Again. Teacher may already Add !");
                MessageBox.Show(l.Message);
            }
        }
        private void btnregistrantion_Click(object sender, EventArgs e)
        {
           
          
          
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            Refreshing();
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

        private void dgvteacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvteacher_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            if (dgvteacher.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgvteacher.Rows[i];
                txtid.Text = row.Cells[0].Value.ToString();
                txtname.Text = row.Cells[1].Value.ToString();
                txtsex.Text = row.Cells[2].Value.ToString();
                txtphonenumber.Text = row.Cells[3].Value.ToString();


            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
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
            //string sql;
            //con.Close();
            //con.Open();
            //sql = "insert into [Teacher_tbl] values ('" + txtid.Text + "','" + txtname.Text + "','" + txtsex.Text + "','" + txtphonenumber.Text + "')";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Add Teacher Sucessfully");
            //con.Close();



            try
            {
                string sql;
                con.Close();
                con.Open();
                sql = " Insert into[Teacher_tbl] values('" + txtid.Text + "', '" + txtname.Text + "', '" + txtsex.Text + "', '" + txtphonenumber.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                InsertTrail();
                MessageBox.Show("Add Teacher Sucessfully");
                con.Close();


                btnshowlist_Click(sender, e);
                Refreshing();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This teacher is added");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnshowlist_Click(object sender, EventArgs e)
        {
            //string sql;
            //con.Close();
            //con.Open();
            //sql = "select * from [Teacher_tbl]";
            //SqlCommand cmd = new SqlCommand(sql,con);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);
            //dgvteacher.DataSource = dataTable;
            //con.Close();


            //con.Close();
            //con.Open();
            //string sql;
            //sql = "select * from [Teacher_tbl] ";
            //SqlCommand cmd = new SqlCommand(sql, con);
            ////SqlDataReader datareader;
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);
            //dgvteacher.DataSource = dataTable;

            //con.Close();
            //con.Open();
            //string sql;
            //sql = "select * from [Teacher_tbl] where TeacherID like ='"+txtid.Text+"%'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //SqlDataReader dataReader = cmd.ExecuteReader();
            //if (dataReader.HasRows)
            //{
            //    dgvteacher.Rows.Clear();
            //    while (dataReader.Read())
            //    {
            //        dgvteacher.Rows.Add(dataReader.GetValue(0));
            //    }
            //}
            //dataReader.Close();
            //cmd.Dispose();
            //con.Close();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);
            //dgvteacher.DataSource = dataTable;

            using (SqlCommand cmd = new SqlCommand("SELECT *from Teacher_tbl; ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvteacher.DataSource = dt;
                    }
                }
            }
        }

        private void btnmotify_Click(object sender, EventArgs e)
        {

            //con.Close();
            //con.Open();
            //string sql;
            //sql = "Update [Teacher_tbl] set Name='"+txtname.Text+"',Sex = '"+txtsex.Text+"',PhoneNumber ='"+txtphonenumber.Text+"' where TeacherID ='"+txtid.Text+"'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Ok sucess hz!!");
            //btnshowlist_Click(sender, e);
            SqlCommand cmd;
            cmd = new SqlCommand("update Teacher_tbl set Name=@Name,Sex=@Sex,PhoneNumber=@PhoneNumer where TeacherID=@TeacherID", con);
            con.Close();
            con.Open();
            cmd.Parameters.AddWithValue("@TeacherID", txtid.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Sex", txtsex.Text);
            cmd.Parameters.AddWithValue("@PhoneNumer", txtphonenumber.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            btnshowlist_Click(sender, e);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
           
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Teacher_tbl where TeacherID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txtid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Removed teacher Succesfully");
            btnshowlist_Click(sender, e);
            con.Close();
            Refreshing();
            txtname.Clear();
            txtphonenumber.Clear();
            txtsex.SelectedIndex = -1;
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            // txtid.Clear();
            Refreshing();
            txtname.Clear();
            txtphonenumber.Clear();
            txtsex.SelectedIndex = -1;
            dgvteacher.DataSource = null;
        }
    }
}
