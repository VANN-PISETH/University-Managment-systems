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
    public partial class Systemlog : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Systemlog()
        {
            InitializeComponent();
            getData();
        }
        SqlCommand cm;
        //SqlConnection cn;
        SqlDataReader dr;
        // string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";
        ListViewItem lst;
      

        public void getData()
        {
            //displaying data from Database to lstview
            try
            {
                listViewSystemlog.Items.Clear();
                listViewSystemlog.Columns.Clear();
                listViewSystemlog.Columns.Add("Date", 200);
                listViewSystemlog.Columns.Add("Transaction Type", 170);
                listViewSystemlog.Columns.Add("Description", 400);
                listViewSystemlog.Columns.Add("Authority", 100);


                string sql2 = @"Select * from Systemlog_tbl order by Date DESC";
                cm = new SqlCommand(sql2, con);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listViewSystemlog.Items.Add(dr[0].ToString());
                    lst.SubItems.Add(dr[1].ToString());
                    lst.SubItems.Add(dr[2].ToString());
                    lst.SubItems.Add(dr[3].ToString());

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getAuditTrail()
        {
            //displaying data from Database to lstview
            try
            {
                listViewSystemlog.Items.Clear();
                listViewSystemlog.Columns.Clear();
                listViewSystemlog.Columns.Add("Date", 200);
                listViewSystemlog.Columns.Add("Transaction Type", 170);
                listViewSystemlog.Columns.Add("Description", 400);
                listViewSystemlog.Columns.Add("Authority", 100);


                string sql2 = @"Select * from Systemlog_tbl where TransactionType like '" + txtsort.Text + "' order by Date DESC";
                cm = new SqlCommand(sql2, con);
                con.Close();
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listViewSystemlog.Items.Add(dr[0].ToString());
                    lst.SubItems.Add(dr[1].ToString());
                    lst.SubItems.Add(dr[2].ToString());
                    lst.SubItems.Add(dr[3].ToString());
                    //lst.SubItems.Add(dr[4].ToString());
                    //lst.SubItems.Add(dr[5].ToString());

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Systemlog_Load(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        }

        private void txtsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsort.Text == "Default")
            {

                getData();
            }
            else
            {
                getAuditTrail();

            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
           
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            if (listViewSystemlog.Items.Count == 0)
            {

                return;
            }

            if (MessageBox.Show("Do you really want to Delete ALL items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //   AllDelTrail();


                try
                {
                    //  listView1.FocusedItem.Remove();
                    string del = "DELETE from Systemlog_tbl";
                    cm = new SqlCommand(del, con);
                    con.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted!");
                    con.Close();
                    getData();
                }
                catch (Exception)
                {
                    MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
    }
}
