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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class Income : Form
    {
       SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 110;
            // TODO: This line of code loads data into the 'DataSet.Payment_tbl' table. You can move, or remove it, as needed.
            this.Payment_tblTableAdapter.Fill(this.DataSet.Payment_tbl);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btntoday_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dte_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dts.Value;
            DateTime dt2 = dte.Value;

            SqlCommand cmd = new SqlCommand("select * from Payment_tbl where convert(Date,PaymentDate,101) between convert(date,'" + dt1 + "' , 101) and Convert(Date,'" + dt2 + "' , 101)", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
          //  this.reportViewer1.LocalReport.ReportPath = @"D:\Project C#\Project for year ll (University Managment Systems)\Income.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
          


        }

        private void btnyear_Click(object sender, EventArgs e)
        {
            con.Open();
            // DateTime dateTime = DateTime.Now;
            SqlCommand cmd = new SqlCommand("select * from Payment_tbl where year(convert(Date,PaymentDate)) = year(Convert(Date,Getdate()))", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Income.rdlc";

            this.reportViewer1.LocalReport.ReportPath = @"D:\University Managment Systems\Project for year ll (University Managment Systems)\Income.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
            con.Close();
         
        }

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            SqlCommand cmd;
            //  SqlDataReader dataReader;
            // string sql;
            // Input
            //  ("SELECT *from Teacher_tbl; ", con))
            // where TeacherID = ", con);
            //SqlCommand cmd;
            cmd = new SqlCommand("Select * from Payment_tbl where InvoiceID=@InvID", con);
            //   con.Open();
            cmd.Parameters.AddWithValue("@InvID", txtIDforincome.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(DT);
            cmd.Dispose();
            da.Dispose();
            reportViewer1.Reset();
            ReportDataSource ds1 = new ReportDataSource("DataSet1", DT.DefaultView);
            reportViewer1.LocalReport.DataSources.Add(ds1);
            this.reportViewer1.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Income.rdlc";

            this.reportViewer1.LocalReport.ReportPath = @"D:\University Managment Systems\Project for year ll (University Managment Systems)\Income.rdlc";
            //  this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }

        private void btntoday_Click_1(object sender, EventArgs e)
        {
            con.Open();
            // DateTime dateTime = DateTime.Now;
            SqlCommand cmd = new SqlCommand("select * from Payment_tbl where convert(Date,PaymentDate) = Convert(Date,Getdate())", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Income.rdlc";
       // D: \University Managment Systems\Project for year ll (University Managment Systems)\Income.rdlc

this.reportViewer1.LocalReport.ReportPath = @"D:\University Managment Systems\Project for year ll (University Managment Systems)\Income.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
            con.Close();
            // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");

        }

        private void btnmonth_Click_1(object sender, EventArgs e)
        {
            con.Open();
            // DateTime dateTime = DateTime.Now;
            SqlCommand cmd = new SqlCommand("select * from Payment_tbl where month(convert(Date,PaymentDate)) = month(Convert(Date,Getdate()))", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Income.rdlc";

            this.reportViewer1.LocalReport.ReportPath = @"D:\University Managment Systems\Project for year ll (University Managment Systems)\Income.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
            con.Close();
        }
    }
}
