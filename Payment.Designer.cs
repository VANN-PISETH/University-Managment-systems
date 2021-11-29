
namespace WindowsFormsApp1
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelpayment = new System.Windows.Forms.Panel();
            this.labelsearch = new System.Windows.Forms.Label();
            this.dgvpayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.InvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scholaship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtscholaship = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdegree = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvdetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelpaymentmethod = new System.Windows.Forms.Label();
            this.txtpaymentmethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelscholaship = new System.Windows.Forms.Label();
            this.txtamountpaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtunitprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUnitprice = new System.Windows.Forms.Label();
            this.lblamountpaid = new System.Windows.Forms.Label();
            this.labelinvoicenum = new System.Windows.Forms.Label();
            this.txtinvoicenum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmajor = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.txtsex = new Guna.UI2.WinForms.Guna2TextBox();
            this.labeldegree = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.labelmajor = new System.Windows.Forms.Label();
            this.labelpaymetdate = new System.Windows.Forms.Label();
            this.labelsex = new System.Windows.Forms.Label();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.txtstudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpaymentdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtfullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnprint = new Guna.UI2.WinForms.Guna2Button();
            this.btnpayment = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxsearch = new System.Windows.Forms.PictureBox();
            this.panelpayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelpayment
            // 
            this.panelpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelpayment.Controls.Add(this.btndelete);
            this.panelpayment.Controls.Add(this.btnRefresh);
            this.panelpayment.Controls.Add(this.btnprint);
            this.panelpayment.Controls.Add(this.btnpayment);
            this.panelpayment.Controls.Add(this.pictureBoxsearch);
            this.panelpayment.Controls.Add(this.labelsearch);
            this.panelpayment.Controls.Add(this.dgvpayment);
            this.panelpayment.Controls.Add(this.txtsearch);
            this.panelpayment.Controls.Add(this.txtscholaship);
            this.panelpayment.Controls.Add(this.txtdegree);
            this.panelpayment.Controls.Add(this.dgvdetail);
            this.panelpayment.Controls.Add(this.labelpaymentmethod);
            this.panelpayment.Controls.Add(this.txtpaymentmethod);
            this.panelpayment.Controls.Add(this.labelscholaship);
            this.panelpayment.Controls.Add(this.txtamountpaid);
            this.panelpayment.Controls.Add(this.txtunitprice);
            this.panelpayment.Controls.Add(this.labelUnitprice);
            this.panelpayment.Controls.Add(this.lblamountpaid);
            this.panelpayment.Controls.Add(this.labelinvoicenum);
            this.panelpayment.Controls.Add(this.txtinvoicenum);
            this.panelpayment.Controls.Add(this.txtmajor);
            this.panelpayment.Controls.Add(this.labelname);
            this.panelpayment.Controls.Add(this.txtsex);
            this.panelpayment.Controls.Add(this.labeldegree);
            this.panelpayment.Controls.Add(this.lblpayment);
            this.panelpayment.Controls.Add(this.labelmajor);
            this.panelpayment.Controls.Add(this.labelpaymetdate);
            this.panelpayment.Controls.Add(this.labelsex);
            this.panelpayment.Controls.Add(this.lblstudentID);
            this.panelpayment.Controls.Add(this.txtstudentID);
            this.panelpayment.Controls.Add(this.txtpaymentdate);
            this.panelpayment.Controls.Add(this.txtfullname);
            this.panelpayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpayment.Location = new System.Drawing.Point(0, 0);
            this.panelpayment.Name = "panelpayment";
            this.panelpayment.Size = new System.Drawing.Size(1511, 918);
            this.panelpayment.TabIndex = 1;
            // 
            // labelsearch
            // 
            this.labelsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.ForeColor = System.Drawing.Color.White;
            this.labelsearch.Location = new System.Drawing.Point(100, 77);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(81, 19);
            this.labelsearch.TabIndex = 69;
            this.labelsearch.Text = "Search ID";
            // 
            // dgvpayment
            // 
            this.dgvpayment.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvpayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvpayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpayment.BackgroundColor = System.Drawing.Color.White;
            this.dgvpayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvpayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpayment.ColumnHeadersHeight = 30;
            this.dgvpayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvID,
            this.PayerID,
            this.UnitPrice,
            this.Scholaship,
            this.PaymentDate,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpayment.EnableHeadersVisualStyles = false;
            this.dgvpayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpayment.Location = new System.Drawing.Point(9, 536);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.RowHeadersVisible = false;
            this.dgvpayment.RowHeadersWidth = 51;
            this.dgvpayment.RowTemplate.Height = 24;
            this.dgvpayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpayment.Size = new System.Drawing.Size(1487, 237);
            this.dgvpayment.TabIndex = 66;
            this.dgvpayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpayment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvpayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvpayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvpayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvpayment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvpayment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvpayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvpayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvpayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvpayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvpayment.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvpayment.ThemeStyle.ReadOnly = false;
            this.dgvpayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvpayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvpayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvpayment.ThemeStyle.RowsStyle.Height = 24;
            this.dgvpayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvpayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpayment_CellContentClick);
            this.dgvpayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpayment_CellValueChanged);
            // 
            // InvID
            // 
            this.InvID.HeaderText = "Invoice ID";
            this.InvID.MinimumWidth = 6;
            this.InvID.Name = "InvID";
            // 
            // PayerID
            // 
            this.PayerID.HeaderText = "PayerID";
            this.PayerID.MinimumWidth = 6;
            this.PayerID.Name = "PayerID";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Scholaship
            // 
            this.Scholaship.HeaderText = "Scholaship (%)";
            this.Scholaship.MinimumWidth = 6;
            this.Scholaship.Name = "Scholaship";
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Date";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.txtsearch.Location = new System.Drawing.Point(12, 101);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtsearch.PlaceholderText = "Search...........";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(268, 40);
            this.txtsearch.TabIndex = 65;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnsearch_KeyUp);
            // 
            // txtscholaship
            // 
            this.txtscholaship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtscholaship.BackColor = System.Drawing.Color.Transparent;
            this.txtscholaship.BorderRadius = 9;
            this.txtscholaship.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtscholaship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtscholaship.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtscholaship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtscholaship.FocusedState.Parent = this.txtscholaship;
            this.txtscholaship.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtscholaship.ForeColor = System.Drawing.Color.Black;
            this.txtscholaship.HoverState.Parent = this.txtscholaship;
            this.txtscholaship.ItemHeight = 30;
            this.txtscholaship.Items.AddRange(new object[] {
            "0",
            "25",
            "30",
            "50",
            "80",
            "100"});
            this.txtscholaship.ItemsAppearance.Parent = this.txtscholaship;
            this.txtscholaship.Location = new System.Drawing.Point(772, 473);
            this.txtscholaship.Name = "txtscholaship";
            this.txtscholaship.ShadowDecoration.Parent = this.txtscholaship;
            this.txtscholaship.Size = new System.Drawing.Size(143, 36);
            this.txtscholaship.TabIndex = 64;
            this.txtscholaship.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtscholaship.SelectedIndexChanged += new System.EventHandler(this.txtscholaship_SelectedIndexChanged);
            this.txtscholaship.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtscholaship_KeyDown_1);
            this.txtscholaship.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtscholaship_KeyUp);
            // 
            // txtdegree
            // 
            this.txtdegree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdegree.BorderRadius = 9;
            this.txtdegree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdegree.DefaultText = "";
            this.txtdegree.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdegree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdegree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdegree.DisabledState.Parent = this.txtdegree;
            this.txtdegree.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdegree.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdegree.FocusedState.Parent = this.txtdegree;
            this.txtdegree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdegree.ForeColor = System.Drawing.Color.Black;
            this.txtdegree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdegree.HoverState.Parent = this.txtdegree;
            this.txtdegree.Location = new System.Drawing.Point(1148, 394);
            this.txtdegree.Margin = new System.Windows.Forms.Padding(4);
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.PasswordChar = '\0';
            this.txtdegree.PlaceholderText = "";
            this.txtdegree.SelectedText = "";
            this.txtdegree.ShadowDecoration.Parent = this.txtdegree;
            this.txtdegree.Size = new System.Drawing.Size(343, 40);
            this.txtdegree.TabIndex = 63;
            this.txtdegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvdetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvdetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdetail.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdetail.EnableHeadersVisualStyles = false;
            this.dgvdetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdetail.Location = new System.Drawing.Point(9, 165);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.RowHeadersVisible = false;
            this.dgvdetail.RowHeadersWidth = 51;
            this.dgvdetail.RowTemplate.Height = 24;
            this.dgvdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetail.Size = new System.Drawing.Size(1487, 189);
            this.dgvdetail.TabIndex = 62;
            this.dgvdetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvdetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvdetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvdetail.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvdetail.ThemeStyle.ReadOnly = false;
            this.dgvdetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvdetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvdetail.ThemeStyle.RowsStyle.Height = 24;
            this.dgvdetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetail_CellContentClick);
            this.dgvdetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetail_CellValueChanged);
            // 
            // labelpaymentmethod
            // 
            this.labelpaymentmethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpaymentmethod.AutoSize = true;
            this.labelpaymentmethod.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaymentmethod.ForeColor = System.Drawing.Color.White;
            this.labelpaymentmethod.Location = new System.Drawing.Point(1314, 449);
            this.labelpaymentmethod.Name = "labelpaymentmethod";
            this.labelpaymentmethod.Size = new System.Drawing.Size(141, 19);
            this.labelpaymentmethod.TabIndex = 56;
            this.labelpaymentmethod.Text = "Payment Method";
            // 
            // txtpaymentmethod
            // 
            this.txtpaymentmethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpaymentmethod.BackColor = System.Drawing.Color.Transparent;
            this.txtpaymentmethod.BorderRadius = 9;
            this.txtpaymentmethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtpaymentmethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpaymentmethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpaymentmethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpaymentmethod.FocusedState.Parent = this.txtpaymentmethod;
            this.txtpaymentmethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpaymentmethod.ForeColor = System.Drawing.Color.Black;
            this.txtpaymentmethod.HoverState.Parent = this.txtpaymentmethod;
            this.txtpaymentmethod.ItemHeight = 30;
            this.txtpaymentmethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "QR Code"});
            this.txtpaymentmethod.ItemsAppearance.Parent = this.txtpaymentmethod;
            this.txtpaymentmethod.Location = new System.Drawing.Point(1304, 473);
            this.txtpaymentmethod.Name = "txtpaymentmethod";
            this.txtpaymentmethod.ShadowDecoration.Parent = this.txtpaymentmethod;
            this.txtpaymentmethod.Size = new System.Drawing.Size(183, 36);
            this.txtpaymentmethod.TabIndex = 55;
            this.txtpaymentmethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelscholaship
            // 
            this.labelscholaship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelscholaship.AutoSize = true;
            this.labelscholaship.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelscholaship.ForeColor = System.Drawing.Color.White;
            this.labelscholaship.Location = new System.Drawing.Point(778, 449);
            this.labelscholaship.Name = "labelscholaship";
            this.labelscholaship.Size = new System.Drawing.Size(120, 19);
            this.labelscholaship.TabIndex = 53;
            this.labelscholaship.Text = "Scholaship (%)";
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtamountpaid.BorderRadius = 9;
            this.txtamountpaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtamountpaid.DefaultText = "";
            this.txtamountpaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtamountpaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtamountpaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtamountpaid.DisabledState.Parent = this.txtamountpaid;
            this.txtamountpaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtamountpaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtamountpaid.FocusedState.Parent = this.txtamountpaid;
            this.txtamountpaid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamountpaid.ForeColor = System.Drawing.Color.Black;
            this.txtamountpaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtamountpaid.HoverState.Parent = this.txtamountpaid;
            this.txtamountpaid.Location = new System.Drawing.Point(1013, 473);
            this.txtamountpaid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.PasswordChar = '\0';
            this.txtamountpaid.PlaceholderText = "";
            this.txtamountpaid.SelectedText = "";
            this.txtamountpaid.ShadowDecoration.Parent = this.txtamountpaid;
            this.txtamountpaid.Size = new System.Drawing.Size(193, 40);
            this.txtamountpaid.TabIndex = 51;
            this.txtamountpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtamountpaid.TextChanged += new System.EventHandler(this.txtamountpaid_TextChanged);
            this.txtamountpaid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtamountpaid_KeyUp);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtunitprice.BorderRadius = 9;
            this.txtunitprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitprice.DefaultText = "";
            this.txtunitprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtunitprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtunitprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitprice.DisabledState.Parent = this.txtunitprice;
            this.txtunitprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitprice.FocusedState.Parent = this.txtunitprice;
            this.txtunitprice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunitprice.ForeColor = System.Drawing.Color.Black;
            this.txtunitprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitprice.HoverState.Parent = this.txtunitprice;
            this.txtunitprice.Location = new System.Drawing.Point(514, 473);
            this.txtunitprice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.PasswordChar = '\0';
            this.txtunitprice.PlaceholderText = "";
            this.txtunitprice.SelectedText = "";
            this.txtunitprice.ShadowDecoration.Parent = this.txtunitprice;
            this.txtunitprice.Size = new System.Drawing.Size(160, 40);
            this.txtunitprice.TabIndex = 50;
            this.txtunitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtunitprice.TextChanged += new System.EventHandler(this.txtunitprice_TextChanged);
            this.txtunitprice.Load += new System.EventHandler(this.txtunitprice_Load);
            this.txtunitprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtunitprice_KeyPress);
            this.txtunitprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtunitprice_KeyUp);
            this.txtunitprice.Leave += new System.EventHandler(this.txtunitprice_Leave);
            // 
            // labelUnitprice
            // 
            this.labelUnitprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUnitprice.AutoSize = true;
            this.labelUnitprice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitprice.ForeColor = System.Drawing.Color.White;
            this.labelUnitprice.Location = new System.Drawing.Point(556, 449);
            this.labelUnitprice.Name = "labelUnitprice";
            this.labelUnitprice.Size = new System.Drawing.Size(82, 19);
            this.labelUnitprice.TabIndex = 49;
            this.labelUnitprice.Text = "Unit Price";
            // 
            // lblamountpaid
            // 
            this.lblamountpaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblamountpaid.AutoSize = true;
            this.lblamountpaid.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamountpaid.ForeColor = System.Drawing.Color.White;
            this.lblamountpaid.Location = new System.Drawing.Point(1042, 449);
            this.lblamountpaid.Name = "lblamountpaid";
            this.lblamountpaid.Size = new System.Drawing.Size(108, 19);
            this.lblamountpaid.TabIndex = 48;
            this.lblamountpaid.Text = "Amount Paid";
            // 
            // labelinvoicenum
            // 
            this.labelinvoicenum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelinvoicenum.AutoSize = true;
            this.labelinvoicenum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinvoicenum.ForeColor = System.Drawing.Color.White;
            this.labelinvoicenum.Location = new System.Drawing.Point(38, 367);
            this.labelinvoicenum.Name = "labelinvoicenum";
            this.labelinvoicenum.Size = new System.Drawing.Size(131, 19);
            this.labelinvoicenum.TabIndex = 47;
            this.labelinvoicenum.Text = "Invoice Number";
            // 
            // txtinvoicenum
            // 
            this.txtinvoicenum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtinvoicenum.BorderRadius = 9;
            this.txtinvoicenum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtinvoicenum.DefaultText = "";
            this.txtinvoicenum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtinvoicenum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtinvoicenum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtinvoicenum.DisabledState.Parent = this.txtinvoicenum;
            this.txtinvoicenum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtinvoicenum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtinvoicenum.FocusedState.Parent = this.txtinvoicenum;
            this.txtinvoicenum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoicenum.ForeColor = System.Drawing.Color.Black;
            this.txtinvoicenum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtinvoicenum.HoverState.Parent = this.txtinvoicenum;
            this.txtinvoicenum.Location = new System.Drawing.Point(23, 394);
            this.txtinvoicenum.Margin = new System.Windows.Forms.Padding(4);
            this.txtinvoicenum.Name = "txtinvoicenum";
            this.txtinvoicenum.PasswordChar = '\0';
            this.txtinvoicenum.PlaceholderText = "";
            this.txtinvoicenum.SelectedText = "";
            this.txtinvoicenum.ShadowDecoration.Parent = this.txtinvoicenum;
            this.txtinvoicenum.Size = new System.Drawing.Size(172, 40);
            this.txtinvoicenum.TabIndex = 46;
            this.txtinvoicenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtinvoicenum.TextChanged += new System.EventHandler(this.txtinvoicenum_TextChanged);
            // 
            // txtmajor
            // 
            this.txtmajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmajor.BorderRadius = 9;
            this.txtmajor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmajor.DefaultText = "";
            this.txtmajor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmajor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmajor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmajor.DisabledState.Parent = this.txtmajor;
            this.txtmajor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmajor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmajor.FocusedState.Parent = this.txtmajor;
            this.txtmajor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmajor.ForeColor = System.Drawing.Color.Black;
            this.txtmajor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmajor.HoverState.Parent = this.txtmajor;
            this.txtmajor.Location = new System.Drawing.Point(21, 473);
            this.txtmajor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtmajor.Name = "txtmajor";
            this.txtmajor.PasswordChar = '\0';
            this.txtmajor.PlaceholderText = "";
            this.txtmajor.SelectedText = "";
            this.txtmajor.ShadowDecoration.Parent = this.txtmajor;
            this.txtmajor.Size = new System.Drawing.Size(395, 40);
            this.txtmajor.TabIndex = 45;
            this.txtmajor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelname
            // 
            this.labelname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(606, 367);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(124, 19);
            this.labelname.TabIndex = 43;
            this.labelname.Text = "Name Of Payer";
            // 
            // txtsex
            // 
            this.txtsex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsex.BorderRadius = 9;
            this.txtsex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsex.DefaultText = "";
            this.txtsex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsex.DisabledState.Parent = this.txtsex;
            this.txtsex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.FocusedState.Parent = this.txtsex;
            this.txtsex.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsex.ForeColor = System.Drawing.Color.Black;
            this.txtsex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.HoverState.Parent = this.txtsex;
            this.txtsex.Location = new System.Drawing.Point(925, 394);
            this.txtsex.Margin = new System.Windows.Forms.Padding(4);
            this.txtsex.Name = "txtsex";
            this.txtsex.PasswordChar = '\0';
            this.txtsex.PlaceholderText = "";
            this.txtsex.SelectedText = "";
            this.txtsex.ShadowDecoration.Parent = this.txtsex;
            this.txtsex.Size = new System.Drawing.Size(126, 40);
            this.txtsex.TabIndex = 42;
            this.txtsex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeldegree
            // 
            this.labeldegree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldegree.AutoSize = true;
            this.labeldegree.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldegree.ForeColor = System.Drawing.Color.White;
            this.labeldegree.Location = new System.Drawing.Point(1286, 371);
            this.labeldegree.Name = "labeldegree";
            this.labeldegree.Size = new System.Drawing.Size(64, 19);
            this.labeldegree.TabIndex = 41;
            this.labeldegree.Text = "Degree";
            this.labeldegree.Click += new System.EventHandler(this.labeldegree_Click);
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.ForeColor = System.Drawing.Color.White;
            this.lblpayment.Location = new System.Drawing.Point(21, 19);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(160, 41);
            this.lblpayment.TabIndex = 39;
            this.lblpayment.Text = "Payment";
            // 
            // labelmajor
            // 
            this.labelmajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelmajor.AutoSize = true;
            this.labelmajor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmajor.ForeColor = System.Drawing.Color.White;
            this.labelmajor.Location = new System.Drawing.Point(190, 449);
            this.labelmajor.Name = "labelmajor";
            this.labelmajor.Size = new System.Drawing.Size(54, 19);
            this.labelmajor.TabIndex = 29;
            this.labelmajor.Text = "Major";
            // 
            // labelpaymetdate
            // 
            this.labelpaymetdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpaymetdate.AutoSize = true;
            this.labelpaymetdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaymetdate.ForeColor = System.Drawing.Color.White;
            this.labelpaymetdate.Location = new System.Drawing.Point(1333, 76);
            this.labelpaymetdate.Name = "labelpaymetdate";
            this.labelpaymetdate.Size = new System.Drawing.Size(117, 19);
            this.labelpaymetdate.TabIndex = 28;
            this.labelpaymetdate.Text = "Payment Date";
            // 
            // labelsex
            // 
            this.labelsex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsex.AutoSize = true;
            this.labelsex.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsex.ForeColor = System.Drawing.Color.White;
            this.labelsex.Location = new System.Drawing.Point(966, 367);
            this.labelsex.Name = "labelsex";
            this.labelsex.Size = new System.Drawing.Size(36, 19);
            this.labelsex.TabIndex = 24;
            this.labelsex.Text = "Sex";
            this.labelsex.Click += new System.EventHandler(this.labelsex_Click);
            // 
            // lblstudentID
            // 
            this.lblstudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentID.ForeColor = System.Drawing.Color.White;
            this.lblstudentID.Location = new System.Drawing.Point(336, 367);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(26, 19);
            this.lblstudentID.TabIndex = 23;
            this.lblstudentID.Text = "ID";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstudentID.BorderRadius = 9;
            this.txtstudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentID.DefaultText = "";
            this.txtstudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentID.DisabledState.Parent = this.txtstudentID;
            this.txtstudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentID.FocusedState.Parent = this.txtstudentID;
            this.txtstudentID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentID.ForeColor = System.Drawing.Color.Black;
            this.txtstudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentID.HoverState.Parent = this.txtstudentID;
            this.txtstudentID.Location = new System.Drawing.Point(292, 394);
            this.txtstudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.PasswordChar = '\0';
            this.txtstudentID.PlaceholderText = "";
            this.txtstudentID.SelectedText = "";
            this.txtstudentID.ShadowDecoration.Parent = this.txtstudentID;
            this.txtstudentID.Size = new System.Drawing.Size(130, 40);
            this.txtstudentID.TabIndex = 11;
            this.txtstudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpaymentdate
            // 
            this.txtpaymentdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpaymentdate.BorderRadius = 9;
            this.txtpaymentdate.CheckedState.Parent = this.txtpaymentdate;
            this.txtpaymentdate.FillColor = System.Drawing.Color.White;
            this.txtpaymentdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpaymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtpaymentdate.HoverState.Parent = this.txtpaymentdate;
            this.txtpaymentdate.Location = new System.Drawing.Point(1295, 101);
            this.txtpaymentdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtpaymentdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtpaymentdate.Name = "txtpaymentdate";
            this.txtpaymentdate.ShadowDecoration.Parent = this.txtpaymentdate;
            this.txtpaymentdate.Size = new System.Drawing.Size(198, 43);
            this.txtpaymentdate.TabIndex = 7;
            this.txtpaymentdate.Value = new System.DateTime(2021, 7, 11, 11, 52, 40, 717);
            // 
            // txtfullname
            // 
            this.txtfullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfullname.BorderRadius = 9;
            this.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfullname.DefaultText = "";
            this.txtfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfullname.DisabledState.Parent = this.txtfullname;
            this.txtfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfullname.FocusedState.Parent = this.txtfullname;
            this.txtfullname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.ForeColor = System.Drawing.Color.Black;
            this.txtfullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfullname.HoverState.Parent = this.txtfullname;
            this.txtfullname.Location = new System.Drawing.Point(519, 394);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.PasswordChar = '\0';
            this.txtfullname.PlaceholderText = "";
            this.txtfullname.SelectedText = "";
            this.txtfullname.ShadowDecoration.Parent = this.txtfullname;
            this.txtfullname.Size = new System.Drawing.Size(309, 40);
            this.txtfullname.TabIndex = 0;
            this.txtfullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btndelete.Location = new System.Drawing.Point(1229, 805);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(183, 50);
            this.btndelete.TabIndex = 74;
            this.btndelete.Text = "Delete";
            this.btndelete.TextOffset = new System.Drawing.Point(20, 0);
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.DisabledState.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnRefresh.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_48;
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRefresh.Location = new System.Drawing.Point(842, 805);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(183, 50);
            this.btnRefresh.TabIndex = 73;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextOffset = new System.Drawing.Point(20, 0);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprint.CheckedState.Parent = this.btnprint;
            this.btnprint.CustomImages.Parent = this.btnprint;
            this.btnprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprint.DisabledState.Parent = this.btnprint;
            this.btnprint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnprint.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.HoverState.Parent = this.btnprint;
            this.btnprint.Image = global::WindowsFormsApp1.Properties.Resources.print_48;
            this.btnprint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprint.ImageSize = new System.Drawing.Size(40, 40);
            this.btnprint.Location = new System.Drawing.Point(455, 805);
            this.btnprint.Name = "btnprint";
            this.btnprint.ShadowDecoration.Parent = this.btnprint;
            this.btnprint.Size = new System.Drawing.Size(183, 50);
            this.btnprint.TabIndex = 72;
            this.btnprint.Text = "Print";
            this.btnprint.TextOffset = new System.Drawing.Point(20, 0);
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click_1);
            // 
            // btnpayment
            // 
            this.btnpayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpayment.CheckedState.Parent = this.btnpayment;
            this.btnpayment.CustomImages.Parent = this.btnpayment;
            this.btnpayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpayment.DisabledState.Parent = this.btnpayment;
            this.btnpayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnpayment.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.Color.White;
            this.btnpayment.HoverState.Parent = this.btnpayment;
            this.btnpayment.Image = global::WindowsFormsApp1.Properties.Resources.pay_48;
            this.btnpayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnpayment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnpayment.Location = new System.Drawing.Point(68, 805);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.ShadowDecoration.Parent = this.btnpayment;
            this.btnpayment.Size = new System.Drawing.Size(183, 50);
            this.btnpayment.TabIndex = 71;
            this.btnpayment.Text = "Payment";
            this.btnpayment.TextOffset = new System.Drawing.Point(20, 0);
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click_1);
            // 
            // pictureBoxsearch
            // 
            this.pictureBoxsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxsearch.Image = global::WindowsFormsApp1.Properties.Resources.Search_48;
            this.pictureBoxsearch.Location = new System.Drawing.Point(288, 107);
            this.pictureBoxsearch.Name = "pictureBoxsearch";
            this.pictureBoxsearch.Size = new System.Drawing.Size(45, 34);
            this.pictureBoxsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsearch.TabIndex = 51;
            this.pictureBoxsearch.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 918);
            this.Controls.Add(this.panelpayment);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panelpayment.ResumeLayout(false);
            this.panelpayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelpayment;
        private System.Windows.Forms.Label labeldegree;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.Label labelmajor;
        private System.Windows.Forms.Label labelpaymetdate;
        private System.Windows.Forms.Label labelsex;
        private System.Windows.Forms.Label lblstudentID;
        private Guna.UI2.WinForms.Guna2TextBox txtstudentID;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtpaymentdate;
        private Guna.UI2.WinForms.Guna2TextBox txtfullname;
        private Guna.UI2.WinForms.Guna2TextBox txtsex;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelinvoicenum;
        private Guna.UI2.WinForms.Guna2TextBox txtinvoicenum;
        private Guna.UI2.WinForms.Guna2TextBox txtmajor;
        private System.Windows.Forms.Label labelscholaship;
        private Guna.UI2.WinForms.Guna2TextBox txtamountpaid;
        private Guna.UI2.WinForms.Guna2TextBox txtunitprice;
        private System.Windows.Forms.Label labelUnitprice;
        private System.Windows.Forms.Label lblamountpaid;
        private System.Windows.Forms.Label labelpaymentmethod;
        private Guna.UI2.WinForms.Guna2ComboBox txtpaymentmethod;
        private Guna.UI2.WinForms.Guna2DataGridView dgvdetail;
        private Guna.UI2.WinForms.Guna2TextBox txtdegree;
        private Guna.UI2.WinForms.Guna2ComboBox txtscholaship;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scholaship;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.PictureBox pictureBoxsearch;
        private Guna.UI2.WinForms.Guna2Button btnpayment;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnprint;
    }
}