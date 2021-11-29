
namespace WindowsFormsApp1
{
    partial class Teacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelteacher = new System.Windows.Forms.Panel();
            this.sforclass = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvteacher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtsex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelTeachernaem = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelSexx = new System.Windows.Forms.Label();
            this.labelPhonenumteacher = new System.Windows.Forms.Label();
            this.txtphonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblteacher = new System.Windows.Forms.Label();
            this.labelteacherID = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnmotify = new Guna.UI2.WinForms.Guna2Button();
            this.btnshowlist = new Guna.UI2.WinForms.Guna2Button();
            this.btngister = new Guna.UI2.WinForms.Guna2Button();
            this.panelteacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).BeginInit();
            this.SuspendLayout();
            // 
            // panelteacher
            // 
            this.panelteacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelteacher.Controls.Add(this.btngister);
            this.panelteacher.Controls.Add(this.btndelete);
            this.panelteacher.Controls.Add(this.btnclear1);
            this.panelteacher.Controls.Add(this.btnmotify);
            this.panelteacher.Controls.Add(this.btnshowlist);
            this.panelteacher.Controls.Add(this.sforclass);
            this.panelteacher.Controls.Add(this.dgvteacher);
            this.panelteacher.Controls.Add(this.txtsex);
            this.panelteacher.Controls.Add(this.labelTeachernaem);
            this.panelteacher.Controls.Add(this.txtname);
            this.panelteacher.Controls.Add(this.labelSexx);
            this.panelteacher.Controls.Add(this.labelPhonenumteacher);
            this.panelteacher.Controls.Add(this.txtphonenumber);
            this.panelteacher.Controls.Add(this.lblteacher);
            this.panelteacher.Controls.Add(this.labelteacherID);
            this.panelteacher.Controls.Add(this.txtid);
            this.panelteacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelteacher.Location = new System.Drawing.Point(0, 0);
            this.panelteacher.Name = "panelteacher";
            this.panelteacher.Size = new System.Drawing.Size(1253, 869);
            this.panelteacher.TabIndex = 2;
            // 
            // sforclass
            // 
            this.sforclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sforclass.Location = new System.Drawing.Point(12, 71);
            this.sforclass.Name = "sforclass";
            this.sforclass.Size = new System.Drawing.Size(1216, 10);
            this.sforclass.TabIndex = 62;
            // 
            // dgvteacher
            // 
            this.dgvteacher.AllowUserToAddRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvteacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvteacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvteacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvteacher.BackgroundColor = System.Drawing.Color.White;
            this.dgvteacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvteacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvteacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvteacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvteacher.ColumnHeadersHeight = 30;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvteacher.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvteacher.EnableHeadersVisualStyles = false;
            this.dgvteacher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvteacher.Location = new System.Drawing.Point(12, 553);
            this.dgvteacher.Name = "dgvteacher";
            this.dgvteacher.RowHeadersVisible = false;
            this.dgvteacher.RowHeadersWidth = 51;
            this.dgvteacher.RowTemplate.Height = 24;
            this.dgvteacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvteacher.Size = new System.Drawing.Size(1229, 304);
            this.dgvteacher.TabIndex = 61;
            this.dgvteacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvteacher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvteacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvteacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvteacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvteacher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvteacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvteacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvteacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvteacher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvteacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvteacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvteacher.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvteacher.ThemeStyle.ReadOnly = false;
            this.dgvteacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvteacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvteacher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvteacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvteacher.ThemeStyle.RowsStyle.Height = 24;
            this.dgvteacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvteacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvteacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvteacher_CellContentClick_1);
            // 
            // txtsex
            // 
            this.txtsex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsex.BackColor = System.Drawing.Color.Transparent;
            this.txtsex.BorderRadius = 9;
            this.txtsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.FocusedState.Parent = this.txtsex;
            this.txtsex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsex.ForeColor = System.Drawing.Color.Black;
            this.txtsex.HoverState.Parent = this.txtsex;
            this.txtsex.ItemHeight = 30;
            this.txtsex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtsex.ItemsAppearance.Parent = this.txtsex;
            this.txtsex.Location = new System.Drawing.Point(422, 301);
            this.txtsex.Name = "txtsex";
            this.txtsex.ShadowDecoration.Parent = this.txtsex;
            this.txtsex.Size = new System.Drawing.Size(408, 36);
            this.txtsex.TabIndex = 60;
            this.txtsex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTeachernaem
            // 
            this.labelTeachernaem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeachernaem.AutoSize = true;
            this.labelTeachernaem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeachernaem.ForeColor = System.Drawing.Color.White;
            this.labelTeachernaem.Location = new System.Drawing.Point(597, 175);
            this.labelTeachernaem.Name = "labelTeachernaem";
            this.labelTeachernaem.Size = new System.Drawing.Size(55, 19);
            this.labelTeachernaem.TabIndex = 59;
            this.labelTeachernaem.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtname.BorderRadius = 9;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(422, 210);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(408, 40);
            this.txtname.TabIndex = 58;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSexx
            // 
            this.labelSexx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSexx.AutoSize = true;
            this.labelSexx.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexx.ForeColor = System.Drawing.Color.White;
            this.labelSexx.Location = new System.Drawing.Point(606, 266);
            this.labelSexx.Name = "labelSexx";
            this.labelSexx.Size = new System.Drawing.Size(36, 19);
            this.labelSexx.TabIndex = 57;
            this.labelSexx.Text = "Sex";
            // 
            // labelPhonenumteacher
            // 
            this.labelPhonenumteacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhonenumteacher.AutoSize = true;
            this.labelPhonenumteacher.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhonenumteacher.ForeColor = System.Drawing.Color.White;
            this.labelPhonenumteacher.Location = new System.Drawing.Point(555, 353);
            this.labelPhonenumteacher.Name = "labelPhonenumteacher";
            this.labelPhonenumteacher.Size = new System.Drawing.Size(125, 19);
            this.labelPhonenumteacher.TabIndex = 55;
            this.labelPhonenumteacher.Text = "Phone Number";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtphonenumber.BorderRadius = 9;
            this.txtphonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphonenumber.DefaultText = "";
            this.txtphonenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphonenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphonenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphonenumber.DisabledState.Parent = this.txtphonenumber;
            this.txtphonenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphonenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphonenumber.FocusedState.Parent = this.txtphonenumber;
            this.txtphonenumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.ForeColor = System.Drawing.Color.Black;
            this.txtphonenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphonenumber.HoverState.Parent = this.txtphonenumber;
            this.txtphonenumber.Location = new System.Drawing.Point(422, 388);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.PasswordChar = '\0';
            this.txtphonenumber.PlaceholderText = "";
            this.txtphonenumber.SelectedText = "";
            this.txtphonenumber.ShadowDecoration.Parent = this.txtphonenumber;
            this.txtphonenumber.Size = new System.Drawing.Size(408, 40);
            this.txtphonenumber.TabIndex = 54;
            this.txtphonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.ForeColor = System.Drawing.Color.White;
            this.lblteacher.Location = new System.Drawing.Point(29, 27);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(147, 41);
            this.lblteacher.TabIndex = 39;
            this.lblteacher.Text = "Teacher";
            // 
            // labelteacherID
            // 
            this.labelteacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelteacherID.AutoSize = true;
            this.labelteacherID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteacherID.ForeColor = System.Drawing.Color.White;
            this.labelteacherID.Location = new System.Drawing.Point(606, 84);
            this.labelteacherID.Name = "labelteacherID";
            this.labelteacherID.Size = new System.Drawing.Size(26, 19);
            this.labelteacherID.TabIndex = 35;
            this.labelteacherID.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BorderRadius = 9;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.Parent = this.txtid;
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.FocusedState.Parent = this.txtid;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.HoverState.Parent = this.txtid;
            this.txtid.Location = new System.Drawing.Point(422, 119);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(408, 40);
            this.txtid.TabIndex = 13;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.CheckedState.Parent = this.btndelete;
            this.btndelete.CustomImages.Parent = this.btndelete;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.DisabledState.Parent = this.btndelete;
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btndelete.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.Parent = this.btndelete;
            this.btndelete.Image = global::WindowsFormsApp1.Properties.Resources.delete_48;
            this.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndelete.ImageSize = new System.Drawing.Size(40, 40);
            this.btndelete.Location = new System.Drawing.Point(786, 475);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(183, 50);
            this.btndelete.TabIndex = 82;
            this.btndelete.Text = "Delete";
            this.btndelete.TextOffset = new System.Drawing.Point(20, 0);
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnclear1
            // 
            this.btnclear1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear1.CheckedState.Parent = this.btnclear1;
            this.btnclear1.CustomImages.Parent = this.btnclear1;
            this.btnclear1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear1.DisabledState.Parent = this.btnclear1;
            this.btnclear1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnclear1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear1.ForeColor = System.Drawing.Color.White;
            this.btnclear1.HoverState.Parent = this.btnclear1;
            this.btnclear1.Image = global::WindowsFormsApp1.Properties.Resources.clear_481;
            this.btnclear1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnclear1.ImageSize = new System.Drawing.Size(40, 40);
            this.btnclear1.Location = new System.Drawing.Point(1034, 475);
            this.btnclear1.Name = "btnclear1";
            this.btnclear1.ShadowDecoration.Parent = this.btnclear1;
            this.btnclear1.Size = new System.Drawing.Size(183, 50);
            this.btnclear1.TabIndex = 81;
            this.btnclear1.Text = "Clear";
            this.btnclear1.TextOffset = new System.Drawing.Point(20, 0);
            this.btnclear1.Click += new System.EventHandler(this.btnclear1_Click);
            // 
            // btnmotify
            // 
            this.btnmotify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmotify.CheckedState.Parent = this.btnmotify;
            this.btnmotify.CustomImages.Parent = this.btnmotify;
            this.btnmotify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmotify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmotify.DisabledState.Parent = this.btnmotify;
            this.btnmotify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnmotify.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmotify.ForeColor = System.Drawing.Color.White;
            this.btnmotify.HoverState.Parent = this.btnmotify;
            this.btnmotify.Image = global::WindowsFormsApp1.Properties.Resources.motify_48;
            this.btnmotify.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmotify.ImageSize = new System.Drawing.Size(40, 40);
            this.btnmotify.Location = new System.Drawing.Point(538, 475);
            this.btnmotify.Name = "btnmotify";
            this.btnmotify.ShadowDecoration.Parent = this.btnmotify;
            this.btnmotify.Size = new System.Drawing.Size(183, 50);
            this.btnmotify.TabIndex = 80;
            this.btnmotify.Text = "Motify";
            this.btnmotify.TextOffset = new System.Drawing.Point(20, 0);
            this.btnmotify.Click += new System.EventHandler(this.btnmotify_Click);
            // 
            // btnshowlist
            // 
            this.btnshowlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnshowlist.CheckedState.Parent = this.btnshowlist;
            this.btnshowlist.CustomImages.Parent = this.btnshowlist;
            this.btnshowlist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnshowlist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnshowlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnshowlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnshowlist.DisabledState.Parent = this.btnshowlist;
            this.btnshowlist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnshowlist.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowlist.ForeColor = System.Drawing.Color.White;
            this.btnshowlist.HoverState.Parent = this.btnshowlist;
            this.btnshowlist.Image = global::WindowsFormsApp1.Properties.Resources.show_48;
            this.btnshowlist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnshowlist.ImageSize = new System.Drawing.Size(40, 40);
            this.btnshowlist.Location = new System.Drawing.Point(290, 475);
            this.btnshowlist.Name = "btnshowlist";
            this.btnshowlist.ShadowDecoration.Parent = this.btnshowlist;
            this.btnshowlist.Size = new System.Drawing.Size(183, 50);
            this.btnshowlist.TabIndex = 79;
            this.btnshowlist.Text = "Show List";
            this.btnshowlist.TextOffset = new System.Drawing.Point(20, 0);
            this.btnshowlist.Click += new System.EventHandler(this.btnshowlist_Click);
            // 
            // btngister
            // 
            this.btngister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngister.CheckedState.Parent = this.btngister;
            this.btngister.CustomImages.Parent = this.btngister;
            this.btngister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngister.DisabledState.Parent = this.btngister;
            this.btngister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btngister.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngister.ForeColor = System.Drawing.Color.White;
            this.btngister.HoverState.Parent = this.btngister;
            this.btngister.Image = global::WindowsFormsApp1.Properties.Resources.registerrrrrr_48;
            this.btngister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btngister.ImageSize = new System.Drawing.Size(40, 40);
            this.btngister.Location = new System.Drawing.Point(42, 475);
            this.btngister.Name = "btngister";
            this.btngister.ShadowDecoration.Parent = this.btngister;
            this.btngister.Size = new System.Drawing.Size(183, 50);
            this.btngister.TabIndex = 83;
            this.btngister.Text = "Add";
            this.btngister.TextOffset = new System.Drawing.Point(20, 0);
            this.btngister.Click += new System.EventHandler(this.btngister_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 869);
            this.Controls.Add(this.panelteacher);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panelteacher.ResumeLayout(false);
            this.panelteacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelteacher;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Label labelteacherID;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private System.Windows.Forms.Label labelTeachernaem;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Label labelSexx;
        private System.Windows.Forms.Label labelPhonenumteacher;
        private Guna.UI2.WinForms.Guna2TextBox txtphonenumber;
        private Guna.UI2.WinForms.Guna2ComboBox txtsex;
        private Guna.UI2.WinForms.Guna2DataGridView dgvteacher;
        private Guna.UI2.WinForms.Guna2Separator sforclass;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnclear1;
        private Guna.UI2.WinForms.Guna2Button btnmotify;
        private Guna.UI2.WinForms.Guna2Button btnshowlist;
        private Guna.UI2.WinForms.Guna2Button btngister;
    }
}