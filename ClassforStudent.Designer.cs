
namespace WindowsFormsApp1
{
    partial class ClassforStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelClass = new System.Windows.Forms.Panel();
            this.sforclass = new Guna.UI2.WinForms.Guna2Separator();
            this.txtteacherID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTeacherID = new System.Windows.Forms.Label();
            this.txtteacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtclasss = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtStuID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvclass = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelstuff = new System.Windows.Forms.Label();
            this.txtstuff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblstuID = new System.Windows.Forms.Label();
            this.lblclasss = new System.Windows.Forms.Label();
            this.labelclasss = new System.Windows.Forms.Label();
            this.labelclass = new System.Windows.Forms.Label();
            this.labelteacher = new System.Windows.Forms.Label();
            this.txtclassID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btngister = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnmotify = new Guna.UI2.WinForms.Guna2Button();
            this.btnshow = new Guna.UI2.WinForms.Guna2Button();
            this.panelClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClass
            // 
            this.panelClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelClass.Controls.Add(this.btngister);
            this.panelClass.Controls.Add(this.btndelete);
            this.panelClass.Controls.Add(this.btnclear1);
            this.panelClass.Controls.Add(this.btnmotify);
            this.panelClass.Controls.Add(this.btnshow);
            this.panelClass.Controls.Add(this.sforclass);
            this.panelClass.Controls.Add(this.txtteacherID);
            this.panelClass.Controls.Add(this.labelTeacherID);
            this.panelClass.Controls.Add(this.txtteacher);
            this.panelClass.Controls.Add(this.txtclasss);
            this.panelClass.Controls.Add(this.txtStuID);
            this.panelClass.Controls.Add(this.dgvclass);
            this.panelClass.Controls.Add(this.labelstuff);
            this.panelClass.Controls.Add(this.txtstuff);
            this.panelClass.Controls.Add(this.lblstuID);
            this.panelClass.Controls.Add(this.lblclasss);
            this.panelClass.Controls.Add(this.labelclasss);
            this.panelClass.Controls.Add(this.labelclass);
            this.panelClass.Controls.Add(this.labelteacher);
            this.panelClass.Controls.Add(this.txtclassID);
            this.panelClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClass.Location = new System.Drawing.Point(0, 0);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(1274, 864);
            this.panelClass.TabIndex = 1;
            // 
            // sforclass
            // 
            this.sforclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sforclass.Location = new System.Drawing.Point(3, 65);
            this.sforclass.Name = "sforclass";
            this.sforclass.Size = new System.Drawing.Size(1269, 10);
            this.sforclass.TabIndex = 60;
            // 
            // txtteacherID
            // 
            this.txtteacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtteacherID.BorderRadius = 9;
            this.txtteacherID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtteacherID.DefaultText = "";
            this.txtteacherID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtteacherID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtteacherID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtteacherID.DisabledState.Parent = this.txtteacherID;
            this.txtteacherID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtteacherID.Enabled = false;
            this.txtteacherID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtteacherID.FocusedState.Parent = this.txtteacherID;
            this.txtteacherID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherID.ForeColor = System.Drawing.Color.Black;
            this.txtteacherID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtteacherID.HoverState.Parent = this.txtteacherID;
            this.txtteacherID.Location = new System.Drawing.Point(127, 290);
            this.txtteacherID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtteacherID.Name = "txtteacherID";
            this.txtteacherID.PasswordChar = '\0';
            this.txtteacherID.PlaceholderText = "";
            this.txtteacherID.SelectedText = "";
            this.txtteacherID.ShadowDecoration.Parent = this.txtteacherID;
            this.txtteacherID.Size = new System.Drawing.Size(185, 40);
            this.txtteacherID.TabIndex = 59;
            this.txtteacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTeacherID
            // 
            this.labelTeacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeacherID.AutoSize = true;
            this.labelTeacherID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherID.ForeColor = System.Drawing.Color.White;
            this.labelTeacherID.Location = new System.Drawing.Point(179, 261);
            this.labelTeacherID.Name = "labelTeacherID";
            this.labelTeacherID.Size = new System.Drawing.Size(90, 19);
            this.labelTeacherID.TabIndex = 57;
            this.labelTeacherID.Text = "Teacher ID";
            // 
            // txtteacher
            // 
            this.txtteacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtteacher.BackColor = System.Drawing.Color.Transparent;
            this.txtteacher.BorderRadius = 9;
            this.txtteacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtteacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtteacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtteacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtteacher.FocusedState.Parent = this.txtteacher;
            this.txtteacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacher.ForeColor = System.Drawing.Color.Black;
            this.txtteacher.HoverState.Parent = this.txtteacher;
            this.txtteacher.ItemHeight = 30;
            this.txtteacher.ItemsAppearance.Parent = this.txtteacher;
            this.txtteacher.Location = new System.Drawing.Point(475, 290);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.ShadowDecoration.Parent = this.txtteacher;
            this.txtteacher.Size = new System.Drawing.Size(408, 36);
            this.txtteacher.TabIndex = 56;
            this.txtteacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtteacher.SelectedIndexChanged += new System.EventHandler(this.txtteacher_SelectedIndexChanged_1);
            // 
            // txtclasss
            // 
            this.txtclasss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclasss.BackColor = System.Drawing.Color.Transparent;
            this.txtclasss.BorderRadius = 9;
            this.txtclasss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtclasss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtclasss.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclasss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclasss.FocusedState.Parent = this.txtclasss;
            this.txtclasss.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclasss.ForeColor = System.Drawing.Color.Black;
            this.txtclasss.HoverState.Parent = this.txtclasss;
            this.txtclasss.ItemHeight = 30;
            this.txtclasss.ItemsAppearance.Parent = this.txtclasss;
            this.txtclasss.Location = new System.Drawing.Point(475, 207);
            this.txtclasss.Name = "txtclasss";
            this.txtclasss.ShadowDecoration.Parent = this.txtclasss;
            this.txtclasss.Size = new System.Drawing.Size(408, 36);
            this.txtclasss.TabIndex = 55;
            this.txtclasss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclasss.SelectedIndexChanged += new System.EventHandler(this.txtclassID_SelectedIndexChanged);
            // 
            // txtStuID
            // 
            this.txtStuID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStuID.BackColor = System.Drawing.Color.Transparent;
            this.txtStuID.BorderRadius = 9;
            this.txtStuID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStuID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStuID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStuID.FocusedState.Parent = this.txtStuID;
            this.txtStuID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuID.ForeColor = System.Drawing.Color.Black;
            this.txtStuID.HoverState.Parent = this.txtStuID;
            this.txtStuID.ItemHeight = 30;
            this.txtStuID.ItemsAppearance.Parent = this.txtStuID;
            this.txtStuID.Location = new System.Drawing.Point(475, 124);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.ShadowDecoration.Parent = this.txtStuID;
            this.txtStuID.Size = new System.Drawing.Size(408, 36);
            this.txtStuID.TabIndex = 54;
            this.txtStuID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStuID.SelectedIndexChanged += new System.EventHandler(this.StuID_SelectedIndexChanged);
            // 
            // dgvclass
            // 
            this.dgvclass.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvclass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvclass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclass.BackgroundColor = System.Drawing.Color.White;
            this.dgvclass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvclass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvclass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvclass.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvclass.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvclass.EnableHeadersVisualStyles = false;
            this.dgvclass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvclass.Location = new System.Drawing.Point(12, 516);
            this.dgvclass.Name = "dgvclass";
            this.dgvclass.RowHeadersVisible = false;
            this.dgvclass.RowHeadersWidth = 51;
            this.dgvclass.RowTemplate.Height = 24;
            this.dgvclass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclass.Size = new System.Drawing.Size(1250, 336);
            this.dgvclass.TabIndex = 53;
            this.dgvclass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvclass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvclass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvclass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvclass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvclass.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvclass.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvclass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvclass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvclass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvclass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvclass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvclass.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvclass.ThemeStyle.ReadOnly = false;
            this.dgvclass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvclass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvclass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvclass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvclass.ThemeStyle.RowsStyle.Height = 24;
            this.dgvclass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvclass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvclass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclass_CellContentClick);
            // 
            // labelstuff
            // 
            this.labelstuff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelstuff.AutoSize = true;
            this.labelstuff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstuff.ForeColor = System.Drawing.Color.White;
            this.labelstuff.Location = new System.Drawing.Point(659, 340);
            this.labelstuff.Name = "labelstuff";
            this.labelstuff.Size = new System.Drawing.Size(46, 19);
            this.labelstuff.TabIndex = 43;
            this.labelstuff.Text = "Stuff";
            // 
            // txtstuff
            // 
            this.txtstuff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstuff.BackColor = System.Drawing.Color.Transparent;
            this.txtstuff.BorderRadius = 9;
            this.txtstuff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtstuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtstuff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstuff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstuff.FocusedState.Parent = this.txtstuff;
            this.txtstuff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtstuff.ForeColor = System.Drawing.Color.Black;
            this.txtstuff.HoverState.Parent = this.txtstuff;
            this.txtstuff.ItemHeight = 30;
            this.txtstuff.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Everning"});
            this.txtstuff.ItemsAppearance.Parent = this.txtstuff;
            this.txtstuff.Location = new System.Drawing.Point(475, 373);
            this.txtstuff.Name = "txtstuff";
            this.txtstuff.ShadowDecoration.Parent = this.txtstuff;
            this.txtstuff.Size = new System.Drawing.Size(408, 36);
            this.txtstuff.TabIndex = 42;
            this.txtstuff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblstuID
            // 
            this.lblstuID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstuID.AutoSize = true;
            this.lblstuID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstuID.ForeColor = System.Drawing.Color.White;
            this.lblstuID.Location = new System.Drawing.Point(634, 91);
            this.lblstuID.Name = "lblstuID";
            this.lblstuID.Size = new System.Drawing.Size(90, 19);
            this.lblstuID.TabIndex = 41;
            this.lblstuID.Text = "Student ID";
            this.lblstuID.Click += new System.EventHandler(this.lblstuID_Click);
            // 
            // lblclasss
            // 
            this.lblclasss.AutoSize = true;
            this.lblclasss.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasss.ForeColor = System.Drawing.Color.White;
            this.lblclasss.Location = new System.Drawing.Point(12, 21);
            this.lblclasss.Name = "lblclasss";
            this.lblclasss.Size = new System.Drawing.Size(363, 41);
            this.lblclasss.TabIndex = 39;
            this.lblclasss.Text = "Add Student To Class";
            // 
            // labelclasss
            // 
            this.labelclasss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelclasss.AutoSize = true;
            this.labelclasss.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclasss.ForeColor = System.Drawing.Color.White;
            this.labelclasss.Location = new System.Drawing.Point(659, 174);
            this.labelclasss.Name = "labelclasss";
            this.labelclasss.Size = new System.Drawing.Size(46, 19);
            this.labelclasss.TabIndex = 35;
            this.labelclasss.Text = "Class";
            // 
            // labelclass
            // 
            this.labelclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelclass.AutoSize = true;
            this.labelclass.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclass.ForeColor = System.Drawing.Color.White;
            this.labelclass.Location = new System.Drawing.Point(179, 91);
            this.labelclass.Name = "labelclass";
            this.labelclass.Size = new System.Drawing.Size(89, 19);
            this.labelclass.TabIndex = 31;
            this.labelclass.Text = "Class Code";
            // 
            // labelteacher
            // 
            this.labelteacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelteacher.AutoSize = true;
            this.labelteacher.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteacher.ForeColor = System.Drawing.Color.White;
            this.labelteacher.Location = new System.Drawing.Point(642, 257);
            this.labelteacher.Name = "labelteacher";
            this.labelteacher.Size = new System.Drawing.Size(69, 19);
            this.labelteacher.TabIndex = 29;
            this.labelteacher.Text = "Teacher";
            // 
            // txtclassID
            // 
            this.txtclassID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclassID.BorderRadius = 9;
            this.txtclassID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclassID.DefaultText = "";
            this.txtclassID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtclassID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtclassID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclassID.DisabledState.Parent = this.txtclassID;
            this.txtclassID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclassID.Enabled = false;
            this.txtclassID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclassID.FocusedState.Parent = this.txtclassID;
            this.txtclassID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclassID.ForeColor = System.Drawing.Color.Black;
            this.txtclassID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclassID.HoverState.Parent = this.txtclassID;
            this.txtclassID.Location = new System.Drawing.Point(127, 120);
            this.txtclassID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtclassID.Name = "txtclassID";
            this.txtclassID.PasswordChar = '\0';
            this.txtclassID.PlaceholderText = "";
            this.txtclassID.SelectedText = "";
            this.txtclassID.ShadowDecoration.Parent = this.txtclassID;
            this.txtclassID.Size = new System.Drawing.Size(185, 40);
            this.txtclassID.TabIndex = 13;
            this.txtclassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclassID.TextChanged += new System.EventHandler(this.txtclasss_TextChanged);
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
            this.btngister.Image = global::WindowsFormsApp1.Properties.Resources.add_48;
            this.btngister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btngister.ImageSize = new System.Drawing.Size(40, 40);
            this.btngister.Location = new System.Drawing.Point(64, 437);
            this.btngister.Name = "btngister";
            this.btngister.ShadowDecoration.Parent = this.btngister;
            this.btngister.Size = new System.Drawing.Size(183, 50);
            this.btngister.TabIndex = 93;
            this.btngister.Text = "Add";
            this.btngister.TextOffset = new System.Drawing.Point(20, 0);
            this.btngister.Click += new System.EventHandler(this.btngister_Click);
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
            this.btndelete.Location = new System.Drawing.Point(808, 437);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(183, 50);
            this.btndelete.TabIndex = 92;
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
            this.btnclear1.Location = new System.Drawing.Point(1056, 437);
            this.btnclear1.Name = "btnclear1";
            this.btnclear1.ShadowDecoration.Parent = this.btnclear1;
            this.btnclear1.Size = new System.Drawing.Size(183, 50);
            this.btnclear1.TabIndex = 91;
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
            this.btnmotify.Location = new System.Drawing.Point(560, 437);
            this.btnmotify.Name = "btnmotify";
            this.btnmotify.ShadowDecoration.Parent = this.btnmotify;
            this.btnmotify.Size = new System.Drawing.Size(183, 50);
            this.btnmotify.TabIndex = 90;
            this.btnmotify.Text = "Motify";
            this.btnmotify.TextOffset = new System.Drawing.Point(20, 0);
            this.btnmotify.Click += new System.EventHandler(this.btnmotify_Click);
            // 
            // btnshow
            // 
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnshow.CheckedState.Parent = this.btnshow;
            this.btnshow.CustomImages.Parent = this.btnshow;
            this.btnshow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnshow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnshow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnshow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnshow.DisabledState.Parent = this.btnshow;
            this.btnshow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnshow.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.HoverState.Parent = this.btnshow;
            this.btnshow.Image = global::WindowsFormsApp1.Properties.Resources.show_48;
            this.btnshow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnshow.ImageSize = new System.Drawing.Size(40, 40);
            this.btnshow.Location = new System.Drawing.Point(312, 437);
            this.btnshow.Name = "btnshow";
            this.btnshow.ShadowDecoration.Parent = this.btnshow;
            this.btnshow.Size = new System.Drawing.Size(183, 50);
            this.btnshow.TabIndex = 89;
            this.btnshow.Text = "Show Class";
            this.btnshow.TextOffset = new System.Drawing.Point(20, 0);
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click_1);
            // 
            // ClassforStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 864);
            this.Controls.Add(this.panelClass);
            this.Name = "ClassforStudent";
            this.Text = "Class For Student";
            this.Load += new System.EventHandler(this.ClassforStudent_Load);
            this.panelClass.ResumeLayout(false);
            this.panelClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClass;
        private System.Windows.Forms.Label lblstuID;
        private System.Windows.Forms.Label lblclasss;
        private System.Windows.Forms.Label labelclasss;
        private System.Windows.Forms.Label labelclass;
        private System.Windows.Forms.Label labelteacher;
        private Guna.UI2.WinForms.Guna2TextBox txtclassID;
        private System.Windows.Forms.Label labelstuff;
        private Guna.UI2.WinForms.Guna2ComboBox txtstuff;
        private Guna.UI2.WinForms.Guna2DataGridView dgvclass;
        private Guna.UI2.WinForms.Guna2ComboBox txtStuID;
        private Guna.UI2.WinForms.Guna2ComboBox txtclasss;
        private Guna.UI2.WinForms.Guna2ComboBox txtteacher;
        private System.Windows.Forms.Label labelTeacherID;
        private Guna.UI2.WinForms.Guna2TextBox txtteacherID;
        private Guna.UI2.WinForms.Guna2Separator sforclass;
        private Guna.UI2.WinForms.Guna2Button btngister;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnclear1;
        private Guna.UI2.WinForms.Guna2Button btnmotify;
        private Guna.UI2.WinForms.Guna2Button btnshow;
    }
}