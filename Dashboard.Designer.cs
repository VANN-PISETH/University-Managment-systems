
namespace WindowsFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.paneldashboard = new System.Windows.Forms.Panel();
            this.panelteacher = new System.Windows.Forms.Panel();
            this.labelteacherlbl = new System.Windows.Forms.Label();
            this.labelteachercount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelteachertotal = new System.Windows.Forms.Label();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxsearch = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradiedashntPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBoxaverage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.guna2CircleProgresdashsBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelincomeyear = new System.Windows.Forms.Label();
            this.pictureBoxdollar = new System.Windows.Forms.PictureBox();
            this.labelincome = new System.Windows.Forms.Label();
            this.pictureBoxincreas = new System.Windows.Forms.PictureBox();
            this.labelincomeforayear = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelprogresssomething = new System.Windows.Forms.Label();
            this.guna2CircleProgressdash2Bar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.labelprogress = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel = new System.Windows.Forms.Panel();
            this.labelStudentwhostudy = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.pictureBoxStudenttotal = new System.Windows.Forms.PictureBox();
            this.labeltotalstudent = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.paneldashboard.SuspendLayout();
            this.panelteacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).BeginInit();
            this.guna2CustomGradiedashntPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxaverage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxincreas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudenttotal)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldashboard
            // 
            this.paneldashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.paneldashboard.Controls.Add(this.panelteacher);
            this.paneldashboard.Controls.Add(this.txtsearch);
            this.paneldashboard.Controls.Add(this.pictureBoxsearch);
            this.paneldashboard.Controls.Add(this.guna2CustomGradiedashntPanel1);
            this.paneldashboard.Controls.Add(this.panel2);
            this.paneldashboard.Controls.Add(this.panel1);
            this.paneldashboard.Controls.Add(this.chart2);
            this.paneldashboard.Controls.Add(this.chart1);
            this.paneldashboard.Controls.Add(this.panel);
            this.paneldashboard.Controls.Add(this.lblDashboard);
            this.paneldashboard.Location = new System.Drawing.Point(0, 0);
            this.paneldashboard.Name = "paneldashboard";
            this.paneldashboard.Size = new System.Drawing.Size(1377, 914);
            this.paneldashboard.TabIndex = 2;
            this.paneldashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldashboard_Paint);
            // 
            // panelteacher
            // 
            this.panelteacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelteacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelteacher.Controls.Add(this.labelteacherlbl);
            this.panelteacher.Controls.Add(this.labelteachercount);
            this.panelteacher.Controls.Add(this.pictureBox1);
            this.panelteacher.Controls.Add(this.labelteachertotal);
            this.panelteacher.Location = new System.Drawing.Point(685, 90);
            this.panelteacher.Name = "panelteacher";
            this.panelteacher.Size = new System.Drawing.Size(310, 200);
            this.panelteacher.TabIndex = 67;
            // 
            // labelteacherlbl
            // 
            this.labelteacherlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelteacherlbl.AutoSize = true;
            this.labelteacherlbl.BackColor = System.Drawing.Color.Transparent;
            this.labelteacherlbl.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteacherlbl.ForeColor = System.Drawing.Color.White;
            this.labelteacherlbl.Location = new System.Drawing.Point(3, 143);
            this.labelteacherlbl.Name = "labelteacherlbl";
            this.labelteacherlbl.Size = new System.Drawing.Size(125, 17);
            this.labelteacherlbl.TabIndex = 75;
            this.labelteacherlbl.Text = "Total Teacher";
            // 
            // labelteachercount
            // 
            this.labelteachercount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelteachercount.AutoSize = true;
            this.labelteachercount.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteachercount.ForeColor = System.Drawing.Color.White;
            this.labelteachercount.Location = new System.Drawing.Point(3, 43);
            this.labelteachercount.Name = "labelteachercount";
            this.labelteachercount.Size = new System.Drawing.Size(118, 30);
            this.labelteachercount.TabIndex = 72;
            this.labelteachercount.Text = "Teacher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_school_director_64;
            this.pictureBox1.Location = new System.Drawing.Point(186, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // labelteachertotal
            // 
            this.labelteachertotal.AutoSize = true;
            this.labelteachertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteachertotal.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelteachertotal.Location = new System.Drawing.Point(32, 87);
            this.labelteachertotal.Name = "labelteachertotal";
            this.labelteachertotal.Size = new System.Drawing.Size(42, 46);
            this.labelteachertotal.TabIndex = 71;
            this.labelteachertotal.Text = "0";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.BorderRadius = 9;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.Parent = this.txtsearch;
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedState.Parent = this.txtsearch;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(1047, 16);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtsearch.PlaceholderText = "Search...........";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(252, 34);
            this.txtsearch.TabIndex = 66;
            // 
            // pictureBoxsearch
            // 
            this.pictureBoxsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxsearch.Image = global::WindowsFormsApp1.Properties.Resources.Search_48;
            this.pictureBoxsearch.Location = new System.Drawing.Point(1322, 16);
            this.pictureBoxsearch.Name = "pictureBoxsearch";
            this.pictureBoxsearch.Size = new System.Drawing.Size(45, 34);
            this.pictureBoxsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsearch.TabIndex = 50;
            this.pictureBoxsearch.TabStop = false;
            // 
            // guna2CustomGradiedashntPanel1
            // 
            this.guna2CustomGradiedashntPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CustomGradiedashntPanel1.BorderRadius = 60;
            this.guna2CustomGradiedashntPanel1.Controls.Add(this.pictureBoxaverage);
            this.guna2CustomGradiedashntPanel1.Controls.Add(this.label1);
            this.guna2CustomGradiedashntPanel1.Controls.Add(this.labelAverage);
            this.guna2CustomGradiedashntPanel1.Controls.Add(this.guna2CircleProgresdashsBar1);
            this.guna2CustomGradiedashntPanel1.FillColor = System.Drawing.Color.Navy;
            this.guna2CustomGradiedashntPanel1.FillColor2 = System.Drawing.Color.BlueViolet;
            this.guna2CustomGradiedashntPanel1.FillColor4 = System.Drawing.Color.DarkViolet;
            this.guna2CustomGradiedashntPanel1.Location = new System.Drawing.Point(316, 319);
            this.guna2CustomGradiedashntPanel1.Name = "guna2CustomGradiedashntPanel1";
            this.guna2CustomGradiedashntPanel1.ShadowDecoration.Parent = this.guna2CustomGradiedashntPanel1;
            this.guna2CustomGradiedashntPanel1.Size = new System.Drawing.Size(602, 166);
            this.guna2CustomGradiedashntPanel1.TabIndex = 49;
            // 
            // pictureBoxaverage
            // 
            this.pictureBoxaverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxaverage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxaverage.Image = global::WindowsFormsApp1.Properties.Resources.average_64;
            this.pictureBoxaverage.Location = new System.Drawing.Point(75, 23);
            this.pictureBoxaverage.Name = "pictureBoxaverage";
            this.pictureBoxaverage.Size = new System.Drawing.Size(88, 99);
            this.pictureBoxaverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxaverage.TabIndex = 76;
            this.pictureBoxaverage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = " Show Detail By Stastic";
            // 
            // labelAverage
            // 
            this.labelAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAverage.AutoSize = true;
            this.labelAverage.BackColor = System.Drawing.Color.Transparent;
            this.labelAverage.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.ForeColor = System.Drawing.Color.White;
            this.labelAverage.Location = new System.Drawing.Point(232, 46);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(118, 30);
            this.labelAverage.TabIndex = 73;
            this.labelAverage.Text = "Average";
            // 
            // guna2CircleProgresdashsBar1
            // 
            this.guna2CircleProgresdashsBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CircleProgresdashsBar1.Animated = true;
            this.guna2CircleProgresdashsBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgresdashsBar1.FillThickness = 10;
            this.guna2CircleProgresdashsBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgresdashsBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgresdashsBar1.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgresdashsBar1.Location = new System.Drawing.Point(400, 23);
            this.guna2CircleProgresdashsBar1.Minimum = 0;
            this.guna2CircleProgresdashsBar1.Name = "guna2CircleProgresdashsBar1";
            this.guna2CircleProgresdashsBar1.ProgressColor = System.Drawing.Color.Navy;
            this.guna2CircleProgresdashsBar1.ProgressColor2 = System.Drawing.Color.Red;
            this.guna2CircleProgresdashsBar1.ProgressOffset = 5;
            this.guna2CircleProgresdashsBar1.ProgressThickness = 10;
            this.guna2CircleProgresdashsBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgresdashsBar1.ShadowDecoration.Parent = this.guna2CircleProgresdashsBar1;
            this.guna2CircleProgresdashsBar1.ShowPercentage = true;
            this.guna2CircleProgresdashsBar1.Size = new System.Drawing.Size(130, 130);
            this.guna2CircleProgresdashsBar1.TabIndex = 0;
            this.guna2CircleProgresdashsBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgresdashsBar1.Value = 88;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.labelincomeyear);
            this.panel2.Controls.Add(this.pictureBoxdollar);
            this.panel2.Controls.Add(this.labelincome);
            this.panel2.Controls.Add(this.pictureBoxincreas);
            this.panel2.Controls.Add(this.labelincomeforayear);
            this.panel2.Location = new System.Drawing.Point(1042, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 200);
            this.panel2.TabIndex = 48;
            // 
            // labelincomeyear
            // 
            this.labelincomeyear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelincomeyear.AutoSize = true;
            this.labelincomeyear.BackColor = System.Drawing.Color.Transparent;
            this.labelincomeyear.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelincomeyear.ForeColor = System.Drawing.Color.White;
            this.labelincomeyear.Location = new System.Drawing.Point(5, 143);
            this.labelincomeyear.Name = "labelincomeyear";
            this.labelincomeyear.Size = new System.Drawing.Size(125, 17);
            this.labelincomeyear.TabIndex = 76;
            this.labelincomeyear.Text = "Income (year)";
            // 
            // pictureBoxdollar
            // 
            this.pictureBoxdollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxdollar.Image = global::WindowsFormsApp1.Properties.Resources.income_64;
            this.pictureBoxdollar.Location = new System.Drawing.Point(235, 112);
            this.pictureBoxdollar.Name = "pictureBoxdollar";
            this.pictureBoxdollar.Size = new System.Drawing.Size(75, 76);
            this.pictureBoxdollar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxdollar.TabIndex = 75;
            this.pictureBoxdollar.TabStop = false;
            // 
            // labelincome
            // 
            this.labelincome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelincome.AutoSize = true;
            this.labelincome.BackColor = System.Drawing.Color.Transparent;
            this.labelincome.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelincome.ForeColor = System.Drawing.Color.White;
            this.labelincome.Location = new System.Drawing.Point(3, 43);
            this.labelincome.Name = "labelincome";
            this.labelincome.Size = new System.Drawing.Size(103, 30);
            this.labelincome.TabIndex = 74;
            this.labelincome.Text = "Income";
            // 
            // pictureBoxincreas
            // 
            this.pictureBoxincreas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxincreas.Image = global::WindowsFormsApp1.Properties.Resources.increas_64;
            this.pictureBoxincreas.Location = new System.Drawing.Point(235, 23);
            this.pictureBoxincreas.Name = "pictureBoxincreas";
            this.pictureBoxincreas.Size = new System.Drawing.Size(75, 77);
            this.pictureBoxincreas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxincreas.TabIndex = 47;
            this.pictureBoxincreas.TabStop = false;
            // 
            // labelincomeforayear
            // 
            this.labelincomeforayear.AutoSize = true;
            this.labelincomeforayear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelincomeforayear.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelincomeforayear.Location = new System.Drawing.Point(16, 87);
            this.labelincomeforayear.Name = "labelincomeforayear";
            this.labelincomeforayear.Size = new System.Drawing.Size(64, 46);
            this.labelincomeforayear.TabIndex = 71;
            this.labelincomeforayear.Text = "0$";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.labelprogresssomething);
            this.panel1.Controls.Add(this.guna2CircleProgressdash2Bar1);
            this.panel1.Controls.Add(this.labelprogress);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 395);
            this.panel1.TabIndex = 47;
            // 
            // labelprogresssomething
            // 
            this.labelprogresssomething.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelprogresssomething.AutoSize = true;
            this.labelprogresssomething.BackColor = System.Drawing.Color.Transparent;
            this.labelprogresssomething.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprogresssomething.ForeColor = System.Drawing.Color.White;
            this.labelprogresssomething.Location = new System.Drawing.Point(72, 323);
            this.labelprogresssomething.Name = "labelprogresssomething";
            this.labelprogresssomething.Size = new System.Drawing.Size(125, 17);
            this.labelprogresssomething.TabIndex = 76;
            this.labelprogresssomething.Text = "Some Progress";
            // 
            // guna2CircleProgressdash2Bar1
            // 
            this.guna2CircleProgressdash2Bar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CircleProgressdash2Bar1.Animated = true;
            this.guna2CircleProgressdash2Bar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressdash2Bar1.FillThickness = 10;
            this.guna2CircleProgressdash2Bar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressdash2Bar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressdash2Bar1.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressdash2Bar1.Location = new System.Drawing.Point(48, 128);
            this.guna2CircleProgressdash2Bar1.Minimum = 0;
            this.guna2CircleProgressdash2Bar1.Name = "guna2CircleProgressdash2Bar1";
            this.guna2CircleProgressdash2Bar1.ProgressColor = System.Drawing.Color.DarkViolet;
            this.guna2CircleProgressdash2Bar1.ProgressColor2 = System.Drawing.Color.Yellow;
            this.guna2CircleProgressdash2Bar1.ProgressOffset = 5;
            this.guna2CircleProgressdash2Bar1.ProgressThickness = 10;
            this.guna2CircleProgressdash2Bar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressdash2Bar1.ShadowDecoration.Parent = this.guna2CircleProgressdash2Bar1;
            this.guna2CircleProgressdash2Bar1.ShowPercentage = true;
            this.guna2CircleProgressdash2Bar1.Size = new System.Drawing.Size(166, 166);
            this.guna2CircleProgressdash2Bar1.TabIndex = 72;
            this.guna2CircleProgressdash2Bar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressdash2Bar1.Value = 74;
            // 
            // labelprogress
            // 
            this.labelprogress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelprogress.AutoSize = true;
            this.labelprogress.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprogress.ForeColor = System.Drawing.Color.White;
            this.labelprogress.Location = new System.Drawing.Point(70, 62);
            this.labelprogress.Name = "labelprogress";
            this.labelprogress.Size = new System.Drawing.Size(133, 30);
            this.labelprogress.TabIndex = 70;
            this.labelprogress.Text = "Progress";
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(971, 319);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(392, 531);
            this.chart2.TabIndex = 45;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(10, 510);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(930, 340);
            this.chart1.TabIndex = 44;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel.Controls.Add(this.labelStudentwhostudy);
            this.panel.Controls.Add(this.labeltotal);
            this.panel.Controls.Add(this.pictureBoxStudenttotal);
            this.panel.Controls.Add(this.labeltotalstudent);
            this.panel.Location = new System.Drawing.Point(336, 90);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(302, 200);
            this.panel.TabIndex = 40;
            // 
            // labelStudentwhostudy
            // 
            this.labelStudentwhostudy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStudentwhostudy.AutoSize = true;
            this.labelStudentwhostudy.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentwhostudy.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentwhostudy.ForeColor = System.Drawing.Color.White;
            this.labelStudentwhostudy.Location = new System.Drawing.Point(3, 143);
            this.labelStudentwhostudy.Name = "labelStudentwhostudy";
            this.labelStudentwhostudy.Size = new System.Drawing.Size(134, 17);
            this.labelStudentwhostudy.TabIndex = 75;
            this.labelStudentwhostudy.Text = "Total Student ";
            // 
            // labeltotal
            // 
            this.labeltotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.ForeColor = System.Drawing.Color.White;
            this.labeltotal.Location = new System.Drawing.Point(3, 43);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(118, 30);
            this.labeltotal.TabIndex = 72;
            this.labeltotal.Text = "Student";
            // 
            // pictureBoxStudenttotal
            // 
            this.pictureBoxStudenttotal.Image = global::WindowsFormsApp1.Properties.Resources.icons8_student_male_64;
            this.pictureBoxStudenttotal.Location = new System.Drawing.Point(182, 43);
            this.pictureBoxStudenttotal.Name = "pictureBoxStudenttotal";
            this.pictureBoxStudenttotal.Size = new System.Drawing.Size(103, 99);
            this.pictureBoxStudenttotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudenttotal.TabIndex = 47;
            this.pictureBoxStudenttotal.TabStop = false;
            // 
            // labeltotalstudent
            // 
            this.labeltotalstudent.AutoSize = true;
            this.labeltotalstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalstudent.ForeColor = System.Drawing.Color.BlueViolet;
            this.labeltotalstudent.Location = new System.Drawing.Point(28, 87);
            this.labeltotalstudent.Name = "labeltotalstudent";
            this.labeltotalstudent.Size = new System.Drawing.Size(42, 46);
            this.labeltotalstudent.TabIndex = 71;
            this.labeltotalstudent.Text = "0";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(3, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(194, 41);
            this.lblDashboard.TabIndex = 39;
            this.lblDashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 914);
            this.Controls.Add(this.paneldashboard);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.paneldashboard.ResumeLayout(false);
            this.paneldashboard.PerformLayout();
            this.panelteacher.ResumeLayout(false);
            this.panelteacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).EndInit();
            this.guna2CustomGradiedashntPanel1.ResumeLayout(false);
            this.guna2CustomGradiedashntPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxaverage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxincreas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudenttotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldashboard;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox pictureBoxStudenttotal;
        private System.Windows.Forms.Label labeltotalstudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxincreas;
        private System.Windows.Forms.Label labelincomeforayear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelprogress;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradiedashntPanel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgresdashsBar1;
        private System.Windows.Forms.PictureBox pictureBoxsearch;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressdash2Bar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelincome;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.PictureBox pictureBoxdollar;
        private System.Windows.Forms.Label labelincomeyear;
        private System.Windows.Forms.Label labelprogresssomething;
        private System.Windows.Forms.Label labelStudentwhostudy;
        private System.Windows.Forms.PictureBox pictureBoxaverage;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.Panel panelteacher;
        private System.Windows.Forms.Label labelteacherlbl;
        private System.Windows.Forms.Label labelteachercount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelteachertotal;
    }
}