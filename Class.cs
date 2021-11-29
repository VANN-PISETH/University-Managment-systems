using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }
      

        private void txtaddclass_Click(object sender, EventArgs e)
        {
            panelClassform.Controls.Clear();
            AddClass frm = new AddClass();
            frm.TopLevel = false;
            panelClassform.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void txtSetstudent_Click(object sender, EventArgs e)
        {
            panelClassform.Controls.Clear();
            ClassforStudent frm = new ClassforStudent();
            frm.TopLevel = false;
            panelClassform.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
