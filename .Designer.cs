
namespace WindowsFormsApp1
{
    partial class AddClass
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
            this.dgvAddClass = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtClassName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.lblclasss = new System.Windows.Forms.Label();
            this.labelclasssID = new System.Windows.Forms.Label();
            this.txtclasssID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btngister = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnmotify = new Guna.UI2.WinForms.Guna2Button();
            this.btnshow = new Guna.UI2.WinForms.Guna2Button();
            this.panelClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddClass)).BeginInit();
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
            this.panelClass.Controls.Add(this.dgvAddClass);
            this.panelClass.Controls.Add(this.txtClassName);
            this.panelClass.Controls.Add(this.labelClassName);
            this.panelClass.Controls.Add(this.lblclasss);
            this.panelClass.Controls.Add(this.labelclasssID);
            this.panelClass.Controls.Add(this.txtclasssID);
            this.panelClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClass.Location = new System.Drawing.Point(0, 0);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(1317, 874);
            this.panelClass.TabIndex = 2;
            this.panelClass.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClass_Paint);
            // 
            // sforclass
            // 
            this.sforclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sforclass.Location = new System.Drawing.Point(13, 149);
            this.sforclass.Name = "sforclass";
            this.sforclass.Size = new System.Drawing.Size(1284, 10);
            this.sforclass.TabIndex = 58;
            // 
            // dgvAddClass
            // 
            this.dgvAddClass.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvAddClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAddClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAddClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAddClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAddClass.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddClass.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAddClass.EnableHeadersVisualStyles = false;
            this.dgvAddClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddClass.Location = new System.Drawing.Point(12, 520);
            this.dgvAddClass.Name = "dgvAddClass";
            this.dgvAddClass.RowHeadersVisible = false;
            this.dgvAddClass.RowHeadersWidth = 51;
            this.dgvAddClass.RowTemplate.Height = 24;
            this.dgvAddClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddClass.Size = new System.Drawing.Size(1293, 342);
            this.dgvAddClass.TabIndex = 57;
            this.dgvAddClass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAddClass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAddClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAddClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAddClass.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddClass.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddClass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAddClass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAddClass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAddClass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAddClass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAddClass.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAddClass.ThemeStyle.ReadOnly = false;
            this.dgvAddClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAddClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAddClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAddClass.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAddClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAddClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddClass_CellContentClick_1);
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClassName.BorderRadius = 9;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.DefaultText = "";
            this.txtClassName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClassName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClassName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClassName.DisabledState.Parent = this.txtClassName;
            this.txtClassName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClassName.FocusedState.Parent = this.txtClassName;
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.ForeColor = System.Drawing.Color.Black;
            this.txtClassName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClassName.HoverState.Parent = this.txtClassName;
            this.txtClassName.Location = new System.Drawing.Point(711, 267);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.PlaceholderText = "";
            this.txtClassName.SelectedText = "";
            this.txtClassName.ShadowDecoration.Parent = this.txtClassName;
            this.txtClassName.Size = new System.Drawing.Size(408, 40);
            this.txtClassName.TabIndex = 18;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelClassName
            // 
            this.labelClassName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.ForeColor = System.Drawing.Color.White;
            this.labelClassName.Location = new System.Drawing.Point(875, 243);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(96, 19);
            this.labelClassName.TabIndex = 55;
            this.labelClassName.Text = "Class Name";
            // 
            // lblclasss
            // 
            this.lblclasss.AutoSize = true;
            this.lblclasss.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasss.ForeColor = System.Drawing.Color.White;
            this.lblclasss.Location = new System.Drawing.Point(39, 38);
            this.lblclasss.Name = "lblclasss";
            this.lblclasss.Size = new System.Drawing.Size(178, 41);
            this.lblclasss.TabIndex = 39;
            this.lblclasss.Text = "Add Class";
            // 
            // labelclasssID
            // 
            this.labelclasssID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelclasssID.AutoSize = true;
            this.labelclasssID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclasssID.ForeColor = System.Drawing.Color.White;
            this.labelclasssID.Location = new System.Drawing.Point(310, 243);
            this.labelclasssID.Name = "labelclasssID";
            this.labelclasssID.Size = new System.Drawing.Size(89, 19);
            this.labelclasssID.TabIndex = 35;
            this.labelclasssID.Text = "Class Code";
            // 
            // txtclasssID
            // 
            this.txtclasssID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclasssID.BorderRadius = 9;
            this.txtclasssID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclasssID.DefaultText = "";
            this.txtclasssID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtclasssID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtclasssID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclasssID.DisabledState.Parent = this.txtclasssID;
            this.txtclasssID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclasssID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclasssID.FocusedState.Parent = this.txtclasssID;
            this.txtclasssID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclasssID.ForeColor = System.Drawing.Color.Black;
            this.txtclasssID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclasssID.HoverState.Parent = this.txtclasssID;
            this.txtclasssID.Location = new System.Drawing.Point(164, 267);
            this.txtclasssID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtclasssID.Name = "txtclasssID";
            this.txtclasssID.PasswordChar = '\0';
            this.txtclasssID.PlaceholderText = "";
            this.txtclasssID.SelectedText = "";
            this.txtclasssID.ShadowDecoration.Parent = this.txtclasssID;
            this.txtclasssID.Size = new System.Drawing.Size(408, 40);
            this.txtclasssID.TabIndex = 13;
            this.txtclasssID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btngister.Location = new System.Drawing.Point(68, 422);
            this.btngister.Name = "btngister";
            this.btngister.ShadowDecoration.Parent = this.btngister;
            this.btngister.Size = new System.Drawing.Size(183, 50);
            this.btngister.TabIndex = 88;
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
            this.btndelete.Location = new System.Drawing.Point(812, 422);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(183, 50);
            this.btndelete.TabIndex = 87;
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
            this.btnclear1.Location = new System.Drawing.Point(1060, 422);
            this.btnclear1.Name = "btnclear1";
            this.btnclear1.ShadowDecoration.Parent = this.btnclear1;
            this.btnclear1.Size = new System.Drawing.Size(183, 50);
            this.btnclear1.TabIndex = 86;
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
            this.btnmotify.Location = new System.Drawing.Point(564, 422);
            this.btnmotify.Name = "btnmotify";
            this.btnmotify.ShadowDecoration.Parent = this.btnmotify;
            this.btnmotify.Size = new System.Drawing.Size(183, 50);
            this.btnmotify.TabIndex = 85;
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
            this.btnshow.Location = new System.Drawing.Point(316, 422);
            this.btnshow.Name = "btnshow";
            this.btnshow.ShadowDecoration.Parent = this.btnshow;
            this.btnshow.Size = new System.Drawing.Size(183, 50);
            this.btnshow.TabIndex = 84;
            this.btnshow.Text = "Show Class";
            this.btnshow.TextOffset = new System.Drawing.Point(20, 0);
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click_1);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 874);
            this.Controls.Add(this.panelClass);
            this.Name = "AddClass";
            this.Text = "Add Class";
            this.Load += new System.EventHandler(this.Class_Load);
            this.panelClass.ResumeLayout(false);
            this.panelClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClass;
        private System.Windows.Forms.Label lblclasss;
        private System.Windows.Forms.Label labelclasssID;
        private Guna.UI2.WinForms.Guna2TextBox txtclasssID;
        private System.Windows.Forms.Label labelClassName;
        private Guna.UI2.WinForms.Guna2TextBox txtClassName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAddClass;
        private Guna.UI2.WinForms.Guna2Separator sforclass;
        private Guna.UI2.WinForms.Guna2Button btngister;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnclear1;
        private Guna.UI2.WinForms.Guna2Button btnmotify;
        private Guna.UI2.WinForms.Guna2Button btnshow;
    }
}