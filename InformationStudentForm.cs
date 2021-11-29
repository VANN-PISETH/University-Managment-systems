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
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class InformationStudentForm : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public InformationStudentForm()
        {
            InitializeComponent();
        }

        private void panelinformationstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnshowstudent_Click(object sender, EventArgs e)
        {
           
            
        }
      //  
        private void dgvinformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
          
            if (dgvinformation.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgvinformation.Rows[i];
                txtshowstudentID.Text = row.Cells[0].Value.ToString();
                txtshowstudentname.Text = row.Cells[1].Value.ToString();
                txtshowsex.Text = row.Cells[2].Value.ToString();
                txtshowstatus.Text = row.Cells[3].Value.ToString();
                txtshowdateofbirth.Text = row.Cells[4].Value.ToString();
                txtshowparentname.Text = row.Cells[5].Value.ToString();
                txtshowplaceofbirth.Text = row.Cells[6].Value.ToString();
                txtshowcityprovince.Text = row.Cells[7].Value.ToString();
                txtshowcountry.Text = row.Cells[8].Value.ToString();
                txtshowaddress.Text = row.Cells[9].Value.ToString();
                txtshowemail.Text = row.Cells[10].Value.ToString();
                txtshowphonenumber.Text = row.Cells[11].Value.ToString();
                txtshowparentnumber.Text = row.Cells[12].Value.ToString();
                txtshowdateofjoin.Text = row.Cells[13].Value.ToString();
                txtshowmajorcode.Text = row.Cells[14].Value.ToString();
                txtshowdegree.Text = row.Cells[15].Value.ToString();
                txtshowmajor.Text = row.Cells[16].Value.ToString();
                txtshowfee.Text = row.Cells[17].Value.ToString();
               var data = (Byte[])(row.Cells[18].Value);
                var stream = new MemoryStream(data);
                txtshowpicstudent.Image = Image.FromStream(stream);
            }
            
        }
       

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
          
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }
        private void Refreshing()
        {
            txtshowaddress.Clear();
            txtshowcityprovince.Clear();
            txtshowcountry.Clear();
            txtshowdateofbirth.Clear();
            txtshowdateofjoin.Clear();
            txtshowemail.Clear();
            txtshowparentname.Clear();
            txtshowparentnumber.Clear();
            txtshowphonenumber.Clear();
            txtshowpicstudent.Image = null;
            txtshowplaceofbirth.Clear();
            txtshowsex.Clear();
            txtshowstatus.Clear();
            txtshowstudentID.Clear();
            txtshowstudentname.Clear();
            txtshowmajor.Clear();
            txtshowfee.Clear();
            txtshowmajorcode.Clear();
            txtshowdegree.Clear();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvinformation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvinformation.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvinformation.Columns[14].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void txtshowsex_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformationStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void txtshowdateofbirth_TextChanged(object sender, EventArgs e)
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

        private void btnshowlist_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Student_tbl.StudentID, Student_tbl.Name, Student_tbl.Sex,Student_tbl.Status,Student_tbl.Dateofbirth,Student_tbl.parentname" +
               ",About_tbl.placeofbirth,About_tbl.cityprovince,About_tbl.country,About_tbl.Address,About_tbl.Email,About_tbl.PhoneNum,About_tbl.ParentNum,Student_tbl.Dateofjoin,Major_tbl.Majorcode,Major_tbl.Degree,Major_tbl.Major,Major_tbl.Fee,Student_tbl.Photo FROM ((Student_tbl INNER JOIN About_tbl ON Student_tbl.StudentID = About_tbl.StudentID) INNER JOIN Major_tbl ON Student_tbl.StudentID = Major_tbl.StuID) ; ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvinformation.DataSource = dt;
                    }
                }
            }
        }

        private void btnmotify_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("update Student_tbl set Name=@name,Sex=@sex,Dateofjoin=@Dateofjoin,Status=@status,Dateofbirth=@Dateofbirth,parentname=@parentname where StudentID=@StID", con);

            //cmd = new SqlCommand("update Student_tbl,About_tbl set Student_tbl.Name=@name,Student_tbl.Sex=@sex,Student_tbl.Dateofjoin=@Dateofjoin,Student_tbl.Status=@status,Student_tbl.Dateofbirth=@Dateofbirth,Student_tbl.parentname=@parentname,About_tbl.Email=@email,About_tbl.PhoneNum=@phonenum," +
            //    "About_tbl.ParentNum=@parentnum,About_tbl.placeofbirth=@placeofbirth,About_tbl.cityprovince=@cityprovince,About_tbl.country=@country,About_tbl.Address=@address From Student_tbl ,About_tbl  where Student_tbl.StudentID=About_tbl.StudentID And Student_tbl.StudentID = @StID", con);
            con.Close();
            con.Open();
            cmd.Parameters.AddWithValue("@StID", txtshowstudentID.Text);
            cmd.Parameters.AddWithValue("@name", txtshowstudentname.Text);
            cmd.Parameters.AddWithValue("@sex", txtshowsex.Text);
            cmd.Parameters.AddWithValue("@Dateofjoin", txtshowdateofjoin.Text);
            cmd.Parameters.AddWithValue("@status", txtshowstatus.Text);
            cmd.Parameters.AddWithValue("@Dateofbirth", txtshowdateofbirth.Text);
            cmd.Parameters.AddWithValue("@parentname", txtshowparentname.Text);

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("update About_tbl set Email=@email,PhoneNum=@phonenum," +
              "ParentNum=@parentnum,placeofbirth=@placeofbirth,cityprovince=@cityprovince,country=@country,Address=@address where StudentID = @StID", con);
            cmd.Parameters.AddWithValue("@StID", txtshowstudentID.Text);
            cmd.Parameters.AddWithValue("@email", txtshowemail.Text);
            cmd.Parameters.AddWithValue("@phonenum", txtshowphonenumber.Text);
            cmd.Parameters.AddWithValue("@parentnum", txtshowparentnumber.Text);
            cmd.Parameters.AddWithValue("@placeofbirth", txtshowplaceofbirth.Text);
            cmd.Parameters.AddWithValue("@cityprovince", txtshowcityprovince.Text);
            cmd.Parameters.AddWithValue("@country", txtshowcountry.Text);
            cmd.Parameters.AddWithValue("@address", txtshowaddress.Text);
            cmd.ExecuteNonQuery();


            cmd = new SqlCommand("update Major_tbl set Majorcode=@Majorcode,Degree=@Degree,Major=@Major,Fee=@Fee where StuID=@StID", con);
            //  cmd.Parameters.AddWithValue("@StID", txtshowstudentID.Text);
            cmd.Parameters.AddWithValue("@StID", txtshowstudentID.Text);
            cmd.Parameters.AddWithValue("@Majorcode", txtshowmajorcode.Text);
            cmd.Parameters.AddWithValue("@Degree", txtshowdegree.Text);
            cmd.Parameters.AddWithValue("@Major", txtshowmajor.Text);
            cmd.Parameters.AddWithValue("@Fee", txtshowfee.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            btnshowlist_Click(sender, e);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Student_tbl where StudentID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txtshowstudentID.Text);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Delete Major_tbl where StuID = @SID", con);
            cmd.Parameters.AddWithValue("@SID", txtshowstudentID.Text);
            cmd.ExecuteNonQuery(); cmd = new SqlCommand("Delete Class_tbl where StuID = @SID", con);
            cmd.Parameters.AddWithValue("@SID", txtshowstudentID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Succesfully");
            btnshowlist_Click(sender, e);
            Refreshing();
            con.Close();
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            txtshowaddress.Clear();
            txtshowcityprovince.Clear();
            txtshowcountry.Clear();
            txtshowdateofbirth.Clear();
            txtshowdateofjoin.Clear();
            txtshowemail.Clear();
            txtshowparentname.Clear();
            txtshowparentnumber.Clear();
            txtshowphonenumber.Clear();
            txtshowpicstudent.Image = null;
            txtshowplaceofbirth.Clear();
            txtshowsex.Clear();
            txtshowstatus.Clear();
            txtshowstudentID.Clear();
            txtshowstudentname.Clear();
            txtshowmajor.Clear();
            txtshowfee.Clear();
            txtshowmajorcode.Clear();
            txtshowdegree.Clear();
            dgvinformation.DataSource = null;
        }
    }
       
}
