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
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class Payment : Form
    {
       SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Payment()
        {
            InitializeComponent();
        }
        CultureInfo US = new CultureInfo("en-US");
      //  CultureInfo P = new CultureInfo("P");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
        private void show()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Student_tbl.StudentID, Student_tbl.Name, Student_tbl.Sex,Major_tbl.Degree,Major_tbl.Major,Major_tbl.Fee FROM (Student_tbl INNER JOIN Major_tbl ON Student_tbl.StudentID = Major_tbl.StuID ) ; ", con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                       dgvdetail.DataSource = dt;
                    }
                }
            }
        }

        private void showpayment()
        {

            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            // Input
            sql = "select * from Payment_tbl ";
            cmd = new SqlCommand(sql, con);
            con.Close();
            con.Open();
            dataReader = cmd.ExecuteReader();

            //Process
            if (dataReader.HasRows)
            {
                dgvpayment.Rows.Clear();
                while (dataReader.Read())
                {
                    dgvpayment.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3),
                    dataReader.GetValue(4), dataReader.GetValue(5));
                }
            }
            dataReader.Close();

            cmd.Dispose();
            con.Close();

            //using (SqlCommand cmd = new SqlCommand("SELECT *from Payment_tbl   ", con))
            //{
            //    cmd.CommandType = CommandType.Text;
            //    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //    {
            //        using (DataTable dt = new DataTable())
            //        {
            //            sda.Fill(dt);
            //            dgvpayment.DataSource = dt;
            //        }
            //    }
            //}
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            show();
            Refreshing();
            showpayment();
        }
        private void Refreshing()
        {
            SqlCommand cmd;
            string sql;
            try
            {
                sql = "select MAX(InvoiceID) from Payment_tbl";
                con.Close();
                con.Open();
                cmd = new SqlCommand(sql,con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txtinvoicenum.Text = "VPS-00001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(4, 5));
                    intval++;
                    txtinvoicenum.Text = String.Format("VPS-{0:00000}", intval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            if (dgvdetail.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgvdetail.Rows[i];
              //  txtinvoicenum.Text = row.Cells[0].Value.ToString();
                txtstudentID.Text = row.Cells[0].Value.ToString();
                txtfullname.Text = row.Cells[1].Value.ToString();
                //.Text = row.Cells[3].Value.ToString();
                txtsex.Text = row.Cells[2].Value.ToString();
                txtdegree.Text = row.Cells[3].Value.ToString();
                txtmajor.Text = row.Cells[4].Value.ToString();
               txtunitprice.Text = row.Cells[5].Value.ToString();
              
            }
        }

        private void labeldegree_Click(object sender, EventArgs e)
        {

        }

        private void txtunitprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            //if (e.KeyChar == (char)13)
            //{
            //    txtunitprice.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C}", double.Parse(txtunitprice.Text));
            //}
        }

        private void txtunitprice_KeyUp(object sender, KeyEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            //if (e.KeyChar == (char)13)
            //{
            //    txtunitprice.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C}", double.Parse(txtunitprice.Text));
            //}
            //if (!string.IsNullOrEmpty(txtunitprice.Text.Trim()))
            //{
            //    if (txtunitprice.Text.Length > 0)
            //    {
            //        txtunitprice.Text = string.Format("{0:N0}", Decimal.Parse(txtunitprice.Text));
            //        txtunitprice.SelectionStart = txtunitprice.Text.Length;
            //       // CalculateFee();

            //    }
            //}
            //else
            //{
            //    txtFee.Text = null;
            //    txtTotal.Text = null;
            //}
        }

        private void txtunitprice_Leave(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtunitprice.Text.Trim()))
            //{
            //    txtunitprice.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C0}", Decimal.Parse(txtunitprice.Text));
              
            //}
        }

        private void txtunitprice_Load(object sender, EventArgs e)
        {

        }

        private void txtscholaship_KeyDown(object sender, KeyEventArgs e)
        {

            //if (!string.IsNullOrEmpty(txtunitprice.Text.Trim()))
            //{
            //    txtunitprice.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C0}", double.Parse(txtunitprice.Text));

            //}
        }

        private void dgvdetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //dgvdetail.Columns[5].DefaultCellStyle.Format = "C0";
            //dgvdetail.Columns[5].DefaultCellStyle.FormatProvider = US;
        }

        private void txtscholaship_KeyDown_1(object sender, KeyEventArgs e)
        {
          
        }

        private void txtscholaship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtscholaship.Text.Trim()))
            {
                if (txtscholaship.Text.Length > 0)
                {
                    txtscholaship.Text = string.Format("{0:N0}", Decimal.Parse(txtscholaship.Text));
                    txtscholaship.SelectionStart = txtscholaship.Text.Length;
                    calculate();

                }
            }
            else
            {
                txtamountpaid.Text = null;

            }
          
        }
//       
        private void btncalculate_Click(object sender, EventArgs e)
        {
            
        }
          

        private void btnsearch_KeyUp(object sender, KeyEventArgs e)
        {
            //using (SqlCommand cmd = new SqlCommand("SELECT Student_tbl.StudentID, Student_tbl.Name, Student_tbl.Sex,Major_tbl.Degree,Major_tbl.Major,Major_tbl.Fee FROM (Student_tbl INNER JOIN Major_tbl ON Student_tbl.StudentID = Major_tbl.StuID ) where Student_tbl.StudentID like '" + txtsearch.Text + "%' ", con))
            //{
            //    cmd.CommandType = CommandType.Text;
            //    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //    {
            //        using (DataTable dt = new DataTable())
            //        {
            //            sda.Fill(dt);
            //            dgvdetail.DataSource = dt;
            //        }
            //    }
            //}
            ////SqlCommand cmd;
            ////SqlDataReader dataReader;
            ////string sql;
            ////// Input
            ////sql = "select * from Student_tbl where StudentID like '" + txtsearch.Text + "%'";
            ////cmd = new SqlCommand(sql, con);
            ////con.Close();
            ////con.Open();
            ////dataReader = cmd.ExecuteReader();

            //////Process
            ////if (dataReader.HasRows)
            ////{
            ////    //  dgvdetail.Rows.Clear();
            ////    while (dataReader.Read())
            ////    {
            ////        dgvdetail.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3),
            ////        dataReader.GetValue(4), dataReader.GetValue(5));
            ////    }
            ////}
            ////dataReader.Close();
            ////cmd.Dispose();
            //string sql;
            //sql = "select * from Student_tbl where StudentID like '" + txtsearch.Text + "%'";
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);
            //dgvdetail.DataSource = dataAdapter;
            //show();
        }
        private void calculate()
        {
            decimal cal = (Convert.ToDecimal(txtunitprice.Text) / 100) * Convert.ToDecimal(txtscholaship.Text);
            txtamountpaid.Text = (decimal.Parse(txtunitprice.Text) - cal).ToString();
        }
        
   //     ,CONVERT(datetime,'" + date.ToString() + "',103)
        private void btnPayment_Click(object sender, EventArgs e)
        {
          
    // 


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
                cm.Parameters.AddWithValue("@Type", "Payment");
                cm.Parameters.AddWithValue("@Description", "Payment ID:" + txtinvoicenum.Text + " has been Paid !");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Again. This Ivoice may already Paid !");
                MessageBox.Show(l.Message);
            }
        }
        private void txtamountpaid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtamountpaid_KeyUp(object sender, KeyEventArgs e)
        {
          
           
           // btncalculate_Click(sender, e);
        }

        private void txtscholaship_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
          //  frm.Show();
        }

        private void dgvpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            if (dgvpayment.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgvpayment.Rows[i];
                //  txtinvoicenum.Text = row.Cells[0].Value.ToString();
                txtinvoicenum.Text = row.Cells[0].Value.ToString();
                //txtfullname.Text = row.Cells[1].Value.ToString();
                ////.Text = row.Cells[3].Value.ToString();
                //txtsex.Text = row.Cells[2].Value.ToString();
                //txtdegree.Text = row.Cells[3].Value.ToString();
                //txtmajor.Text = row.Cells[4].Value.ToString();
                //txtunitprice.Text = row.Cells[5].Value.ToString();

            }
        }

        private void dgvpayment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           dgvpayment.Columns[2].DefaultCellStyle.Format = "C0";
            dgvpayment.Columns[2].DefaultCellStyle.FormatProvider = US;
            dgvpayment.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvpayment.Columns[5].DefaultCellStyle.Format = "C0";
            dgvpayment.Columns[5].DefaultCellStyle.FormatProvider = US;

        }

        private void labelsex_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            
          
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvpayment1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //guna2DataGridView1.Columns[2].DefaultCellStyle.Format = "C0";
            //guna2DataGridView1.Columns[2].DefaultCellStyle.FormatProvider = US;
            //guna2DataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            //guna2DataGridView1.Columns[5].DefaultCellStyle.Format = "C0";
            //guna2DataGridView1.Columns[5].DefaultCellStyle.FormatProvider = US;
        }

        private void txtinvoicenum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                //string date = DateTime.Now.ToString();
                string date = txtpaymentdate.Text;
                string sql;
                // con.Close();
                con.Open();
                sql = " Insert into[Payment_tbl] values('" + txtinvoicenum.Text + "', '" + txtstudentID.Text + "', '" + txtunitprice.Text + "', '" + txtscholaship.Text + "','" + date + "','" + txtamountpaid.Text + "' )";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                InsertTrail();
                MessageBox.Show("Payment Sucessfully");

                con.Close();
                showpayment();
            }
            catch//(Exception ex)
            {
                MessageBox.Show("This Invoice already Paid !!!");
                // MessageBox.Show(ex.Message);
            }
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {

            //   panelpayment.Controls.Clear();
            Invoiceform inv = new Invoiceform();
            //  ReceiptFrm inv = new ReceiptFrm();
            inv.reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport Lrpt = inv.reportViewer1.LocalReport;
            Lrpt.DisplayName = "Invioce2.rdlc";
            ReportParameter p1 = new ReportParameter("InvoiceID", txtinvoicenum.Text);
            inv.reportViewer1.LocalReport.SetParameters(p1);
            ReportParameter p2 = new ReportParameter("PayerID", txtstudentID.Text);
            inv.reportViewer1.LocalReport.SetParameters(p2);
            ReportParameter p3 = new ReportParameter("UnitPrice", txtunitprice.Text);
            inv.reportViewer1.LocalReport.SetParameters(p3);
            ReportParameter p4 = new ReportParameter("Scholaship", txtscholaship.Text);
            inv.reportViewer1.LocalReport.SetParameters(p4);
            ReportParameter p5 = new ReportParameter("PaymentDate", txtpaymentdate.Text);
            inv.reportViewer1.LocalReport.SetParameters(p5);
            ReportParameter p6 = new ReportParameter("Total", txtamountpaid.Text);
            inv.reportViewer1.LocalReport.SetParameters(p6);
            ReportParameter p7 = new ReportParameter("Degree", txtdegree.Text);
            inv.reportViewer1.LocalReport.SetParameters(p7);
            ReportParameter p8 = new ReportParameter("Major", txtmajor.Text);
            inv.reportViewer1.LocalReport.SetParameters(p8);
            ReportParameter p9 = new ReportParameter("fullname", txtfullname.Text);
            inv.reportViewer1.LocalReport.SetParameters(p9);
            ReportParameter p10 = new ReportParameter("Paymentmethod", txtpaymentmethod.Text);
            inv.reportViewer1.LocalReport.SetParameters(p10);
            ReportParameter p11 = new ReportParameter("Sex", txtsex.Text);
            inv.reportViewer1.LocalReport.SetParameters(p11);
            inv.Show();
            inv.reportViewer1.RefreshReport();

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Refreshing();
            txtstudentID.Clear();
            txtfullname.Clear();
            txtsex.Clear();
            txtunitprice.Clear();
            txtscholaship.SelectedIndex = -1;
            txtmajor.Clear();
            txtdegree.Clear();
            txtpaymentmethod.SelectedIndex = -1;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Payment_tbl where InvoiceID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txtinvoicenum.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Removed Payment Succesfully");
            showpayment();
            con.Close();
            Refreshing();
        }
    }
}
