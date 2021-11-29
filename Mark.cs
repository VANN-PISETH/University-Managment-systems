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
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class Mark : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\DataManagmentStudents.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project C#\Project for year ll (University Managment Systems)\DataManagmentStudents.mdf;Integrated Security=True");
        public Mark()
        {
            InitializeComponent();
            fillcomboxstu();
            fillcomboxterm();
        }

        private void panelmark_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowGPA_Click(object sender, EventArgs e)
        {
          
        }
        public void fillcomboxstu()
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
        private void txtStuID_SelectedIndexChanged(object sender, EventArgs e)
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
        public void fillcomboxterm()
        {
            string sql = "select * from Term_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da;
            try
            {
                con.Open();
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string sname = da.GetString(0);
                    txtsemester.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void txtsemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Term_tbl where Term ='" + txtsemester.Text + "';";
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
                    string code1 = da.GetString(1);
                    string code2 = da.GetString(2);
                    string code3 = da.GetString(3);
                    string code4 = da.GetString(4);
                    string code5 = da.GetString(5);
                    string cur1 = da.GetString(6);
                    string cur2 = da.GetString(7);
                    string cur3 = da.GetString(8);
                    string cur4 = da.GetString(9);
                    string cur5 = da.GetString(10);
                    txtcode1.Text = code1;
                    txtcode2.Text = code2;
                    txtcode3.Text = code3;
                    txtcode4.Text = code4;
                    txtcode5.Text = code5;
                    txttitle1.Text = cur1;
                    txttitle2.Text = cur2;
                    txttitle3.Text = cur3;
                    txttitle4.Text = cur4;
                    txttitle5.Text = cur5;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
      
        private void btnprint_Click(object sender, EventArgs e)
        {
           
        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelmark = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();


        }
       public void pntdoc_printpage()
        {

        }
        //        Bitmap bitmap;  
        //private void CaptureScreen() {  
        //    Graphics myGraphics = this.CreateGraphics();  
        //    Size s = this.Size;  
        //    bitmap = new Bitmap(s.Width, s.Height, myGraphics);  
        //    Graphics memoryGraphics = Graphics.FromImage(bitmap);  
        //    memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);  
        //}
        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawImage(bitmap, 0, 0);
        //}
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           // e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bitmap, 0, 0);
        }
        //    printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);

        //    //Rest of the code
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        // //}
        private void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 18) - (this.panelmark.Width / 11), this.panelmark.Location.Y);
        }

        private void Mark_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
           
        }

        private void btnprintgrade_Click(object sender, EventArgs e)
        {
            Print(this.panelmark);
            //Panel panel = new Panel();
            //this.Controls.Add(panel);
            //Graphics grp = panel.CreateGraphics();
            //Size formSize = this.ClientSize;
            //bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            //grp = Graphics.FromImage(bitmap);
            //Point panelLocation = PointToScreen(panel.Location);
            //grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();
        }

        private void btnshowGPA_Click_1(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtmark1.Text.Trim()))
            //{
            //    MessageBox.Show("Please Input Mark");

            //}
            try
            {


                float num1, num2, num3, num4, num5, Total;
                num1 = float.Parse(txtmark1.Text);
                num2 = float.Parse(txtmark2.Text);
                num3 = float.Parse(txtmark3.Text);
                num4 = float.Parse(txtmark4.Text);
                num5 = float.Parse(txtmark5.Text);

                Total = num1 + num2 + num3 + num4 + num5;
                txtmark6.Text = Total.ToString();

                float A;
                A = float.Parse(txtmark1.Text);

                if (A >= 80 && A <= 100)
                {
                    txtgrade1.Text = "A+";
                    txtre1.Text = "Excellent";
                }
                else if (A >= 70 && A < 79)
                {
                    txtgrade1.Text = "A";
                    txtre1.Text = "Very Good";
                }
                else if (A >= 60 && A < 69)
                {
                    txtgrade1.Text = "B";
                    txtre1.Text = "Good";

                }
                else if (A >= 50 && A < 59)
                {
                    txtgrade1.Text = "C";
                    txtre1.Text = "Fairly Good";
                }
                else if (A >= 0 && A < 49)
                {
                    txtgrade1.Text = "Fail";
                    txtre1.Text = "Not Good!!!";
                }
                else
                {
                    txtgrade1.Text = "???";
                    txtre1.Text = "???";
                }

                float B;
                B = float.Parse(txtmark2.Text);

                if (B >= 80 && B <= 100)
                {
                    txtgrade2.Text = "A+";
                    txtre2.Text = "Excellent";
                }
                else if (B >= 70 && B < 79)
                {
                    txtgrade2.Text = "A";
                    txtre2.Text = "Very Good";
                }
                else if (B >= 60 && B < 69)
                {
                    txtgrade2.Text = "B";
                    txtre2.Text = "Good";
                }
                else if (B >= 50 && B < 59)
                {
                    txtgrade2.Text = "C";
                    txtre2.Text = "Fairly Good";
                }
                else if (B >= 0 && B < 49)
                {
                    txtgrade2.Text = "Fail";
                    txtre2.Text = "Not Good!!!";
                }
                else
                {
                    txtgrade2.Text = "???";
                    txtre2.Text = "???";
                }

                float C;
                C = float.Parse(txtmark3.Text);

                if (C >= 80 && C <= 100)
                {
                    txtgrade3.Text = "A+";
                    txtre3.Text = "Excellent";
                }
                else if (C >= 70 && C < 79)
                {
                    txtgrade3.Text = "A";
                    txtre3.Text = "Very Good";
                }
                else if (C >= 60 && C < 69)
                {
                    txtgrade3.Text = "B";
                    txtre3.Text = "Good";
                }
                else if (C >= 50 && C < 59)
                {
                    txtgrade3.Text = "C";
                    txtre3.Text = "Fairly Good";
                }
                else if (C >= 0 && C < 49)
                {
                    txtgrade3.Text = "Fail";
                    txtre3.Text = "Not Good!!!";
                }
                else
                {
                    txtgrade3.Text = "???";
                    txtre3.Text = "???";
                }

                float D;
                D = float.Parse(txtmark4.Text);

                if (D >= 80 && D <= 100)
                {
                    txtgrade4.Text = "A+";
                    txtre4.Text = "Excellent";
                }
                else if (D >= 70 && D < 79)
                {
                    txtgrade4.Text = "A";
                    txtre4.Text = "Very Good";
                }
                else if (D >= 60 && D < 69)
                {
                    txtgrade4.Text = "B";
                    txtre4.Text = "Good";
                }
                else if (D >= 50 && D < 59)
                {
                    txtgrade4.Text = "C";
                    txtre4.Text = "Fairly Good";
                }
                else if (D >= 0 && D < 49)
                {
                    txtgrade4.Text = "Fail";
                    txtre4.Text = "Not Good!!!";
                }
                else
                {
                    txtgrade4.Text = "???";
                    txtre4.Text = "???";
                }

                float E;
                E = float.Parse(txtmark5.Text);

                if (E >= 80 && E <= 100)
                {
                    txtgrade5.Text = "A+";
                    txtre5.Text = "Excellent";
                }
                else if (E >= 70 && E < 79)
                {
                    txtgrade5.Text = "A";
                    txtre5.Text = "Very Good";
                }
                else if (E >= 60 && E < 69)
                {
                    txtgrade5.Text = "B";
                    txtre5.Text = "Good";
                }
                else if (E >= 50 && E < 59)
                {
                    txtgrade5.Text = "C";
                    txtre5.Text = "Fairly Good";
                }
                else if (E >= 0 && E < 49)
                {
                    txtgrade5.Text = "Fail";
                    txtre5.Text = "Not Good!!!";
                }
                else
                {
                    txtgrade5.Text = "???";
                    txtre5.Text = "???";
                }

                float F;
                F = float.Parse(txtmark6.Text);

                if (F >= 450 && F <= 500)
                {
                    txtgrade6.Text = "A+";
                    txtfinalremark.Text = "Excellent";
                }
                else if (F >= 400 && F < 450)
                {
                    txtgrade6.Text = "A";
                    txtfinalremark.Text = "Very Good";
                }
                else if (F >= 350 && F < 400)
                {
                    txtgrade6.Text = "B";
                    txtfinalremark.Text = "Good";
                }
                else if (F >= 250 && F < 350)
                {
                    txtgrade6.Text = "C";
                    txtfinalremark.Text = "Fairly Good";
                }
                else if (F >= 0 && F < 250)
                {
                    txtgrade6.Text = "Fail";
                    txtfinalremark.Text = "Not Good!!!";
                }
                else
                {
                    txtgrade6.Text = "???";
                    txtfinalremark.Text = "???";

                }
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Please input mark !!!");
            }

        }
        // public void Print(Panel pnl)
        // {
        //     pannel = pnl; y
        //     GetPrintArea(pnl);
        //     previewdlg.Document = printdoc1;
        //     previewdlg.ShowDialog();
        // }
    }
} 

