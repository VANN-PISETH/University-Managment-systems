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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        CultureInfo US = new CultureInfo("en-US");
        public Dashboard()
        {
            InitializeComponent();
           // chart1.Series[0].LabelFormat = "##0$";
        }
        private void Livechart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Payment_tbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Payment_tbl");
           
            chart1.DataSource = ds.Tables["Payment_tbl"];
            chart1.Series[0].XValueMember = "PayerID";
            chart1.Series[0].YValueMembers = "Total";
            this.chart1.Titles.Add("Income Chart");
            chart1.Series[0].ChartType =SeriesChartType.Line;
            chart1.Series[0].IsValueShownAsLabel = true;
            con.Close();
        }
        private void Totalteacher()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Count(TeacherID) From Teacher_tbl", con);

                Int32 rows_count = 0;

                var queryResult = cmd.ExecuteScalar();
                if (queryResult != DBNull.Value)
                {
                    rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                con.Close();
                labelteachertotal.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Totalstudent()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Count(StudentID) From Student_tbl", con);

                Int32 rows_count = 0;

                var queryResult = cmd.ExecuteScalar();
                if (queryResult != DBNull.Value)
                {
                    rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                con.Close();
                labeltotalstudent.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Incomebyyear()
        {
            try
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select Sum(Total) From Payment_tbl where year(convert(Date,PaymentDate)) = year(Convert(Date,Getdate()))", con);
                Int32 rows_count1 = 0;
                var queryResult = cmd1.ExecuteScalar();
                if (!Convert.IsDBNull(queryResult))
                {
                    rows_count1 = Convert.ToInt32(cmd1.ExecuteScalar());
                }
                con.Close();
                labelincomeforayear.Text = rows_count1.ToString("C0", US);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            // Livechart();
            Incomeinmonth();
            NewStudentbymonth();
            Totalstudent();
            Incomebyyear();
            Totalteacher();
        }
        private void Incomeinmonth()
        {
            this.chart1.Titles.Add("Income (Month)");
            chart1.Series[0].Name = "Income";                             
            chart1.Series[0].Color = Color.FromArgb(95, 77, 221);
           

            SqlCommand cmd = new SqlCommand("select datename(month,PaymentDate) as Month, Sum (Total) as Total From Payment_tbl Where datediff(month, PaymentDate, GETDATE()) <12 Group by Year(PaymentDate), month(PaymentDate),datename (month,PaymentDate) ", con);
            //SqlCommand cmd = new SqlCommand("select Sum(PaymentDate) , Sum(Total) from Payment_tbl where month(convert(Date,PaymentDate)) = month(Convert(Date,Getdate())) ", con);
            // SqlCommand cmd = new SqlCommand("select * from Payment_tbl where month(convert(Date,PaymentDate)) = month(Convert(Date,Getdate()))", con);         
       //  SqlCommand cmd = new SqlCommand("Select cast(PaymentDate as date) as StartMonth , sum(Total) as Total From Payment_tbl where datediff(month, PaymentDate, GETDATE()) <12 Group BY cast(PaymentDate as date) order by StartMonth", con);          
            //SqlCommand cmd = new SqlCommand("SELECT  SUM(Total), MONTH(PaymentDate) FROM Payment_tbl WHERE PaymentDate >= '2014-04-14' AND PaymentDate <= '2016-04-14' GROUP BY MONTH(PaymentDate) ORDER BY MONTH(PaymentDate)", con);
            // SqlCommand cmd = new SqlCommand("Select cast(PaymentDate as date) as Stat_Year , sum(Total) as Total From Payment_tbl where datePart(Year, PaymentDate, GETDATE()) <360 Group BY cast(PaymentDate as date) order by Stat_Year", con);
            // SqlCommand cmd = new SqlCommand("Select PaymentDate = DATEADD(MONTH,DATEDIFF(MONTH, 0 , PaymentDate),0) , Sum(Total) as Total From Payment_tbl where PaymentDate >='2020-01-01' AND PaymentDate <='2022-01-01'  Group BY DATEADD(MONTH,DATEDIFF(MONTH, 0 , PaymentDate),0),Total", con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    if (myReader.HasRows)
                    {
                        chart1.Series[0].Points.AddXY(myReader.GetValue(0), myReader.GetValue(1));
                        chart1.Series[0].ChartType = SeriesChartType.Spline;
                        
                    }


                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private void NewStudentbymonth()
        {
            this.chart2.Titles.Add("New Student (Month)");
            chart2.Series[0].Name = "Student";
          //  chart2.Series[0].Color = Color.FromArgb(24, 161, 251);
            //  chart1.LabelStyle.Format = "##0$";
            SqlCommand cmd = new SqlCommand("select datename(month,Dateofjoin) as Month, Count (Name) as Student From Student_tbl Where datediff(month, Dateofjoin, GETDATE()) <120 Group by Year(Dateofjoin), month(Dateofjoin),datename (month,Dateofjoin) ", con);
            //SqlCommand cmd = new SqlCommand("select Sum(PaymentDate) , Sum(Total) from Payment_tbl where month(convert(Date,PaymentDate)) = month(Convert(Date,Getdate())) ", con);
            // SqlCommand cmd = new SqlCommand("select * from Payment_tbl where month(convert(Date,PaymentDate)) = month(Convert(Date,Getdate()))", con);         
            //  SqlCommand cmd = new SqlCommand("Select cast(PaymentDate as date) as StartMonth , sum(Total) as Total From Payment_tbl where datediff(month, PaymentDate, GETDATE()) <12 Group BY cast(PaymentDate as date) order by StartMonth", con);          
            //SqlCommand cmd = new SqlCommand("SELECT  SUM(Total), MONTH(PaymentDate) FROM Payment_tbl WHERE PaymentDate >= '2014-04-14' AND PaymentDate <= '2016-04-14' GROUP BY MONTH(PaymentDate) ORDER BY MONTH(PaymentDate)", con);
            // SqlCommand cmd = new SqlCommand("Select cast(PaymentDate as date) as Stat_Year , sum(Total) as Total From Payment_tbl where datePart(Year, PaymentDate, GETDATE()) <360 Group BY cast(PaymentDate as date) order by Stat_Year", con);
            // SqlCommand cmd = new SqlCommand("Select PaymentDate = DATEADD(MONTH,DATEDIFF(MONTH, 0 , PaymentDate),0) , Sum(Total) as Total From Payment_tbl where PaymentDate >='2020-01-01' AND PaymentDate <='2022-01-01'  Group BY DATEADD(MONTH,DATEDIFF(MONTH, 0 , PaymentDate),0),Total", con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    if (myReader.HasRows)
                    {
                        chart2.Series[0].Points.AddXY(myReader.GetValue(0), myReader.GetValue(1));
                        chart2.Series[0].ChartType = SeriesChartType.Funnel;
                        // chart1.LabelStyle.Format = "##0$";
                    }


                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void paneldashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
