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
using DGVPrinterHelper;

namespace WindowsFormsApp1
{
    public partial class Attendance : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Attendance()
        {
            InitializeComponent();
            fillcombox();
        }

        private void btnshowstudent_Click(object sender, EventArgs e)
        {
           
        }
        public void fillcombox()
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
                    txtclassattendance.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void txtmajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from SetClass_tbl where ClassName ='" + txtclassattendance.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                  



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void Print()
        {
            DGVPrinter Print = new DGVPrinter();
            Print.Title = "Attendance Sheet";
            if (txtclassattendance.Text.Trim() == string.Empty)
                Print.SubTitle = txtdateattendance.Text + "\n";
            else
                Print.SubTitle = txtclassattendance.Text.Trim() + "\n" + txtdateattendance.Text + "\n";
            Print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Print.PageNumbers = true;
            Print.PageNumberInHeader = false;
            Print.PorportionalColumns = true;
            Print.HeaderCellAlignment = StringAlignment.Near;
            Print.Footer = "HAHA";
            Print.FooterSpacing = 15;
            Print.PrintDataGridView(dgvattendance);
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void panelClassform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
           
        }

        private void btnshowlist_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;

            // Input
            sql = "select Name,Sex from Student_tbl ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dataReader = cmd.ExecuteReader();

            // Process
            if (dataReader.HasRows)
            {
                dgvattendance.Rows.Clear();
                while (dataReader.Read())
                {
                    dgvattendance.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1));
                }

            }
            dataReader.Close();
            cmd.Dispose();
            con.Close();
        }
    }
}
