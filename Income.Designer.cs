
namespace WindowsFormsApp1
{
    partial class Income
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Payment_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new WindowsFormsApp1.DataSet();
            this.Payment_tblTableAdapter = new WindowsFormsApp1.DataSetTableAdapters.Payment_tblTableAdapter();
            this.panelincome = new System.Windows.Forms.Panel();
            this.btnyear = new Guna.UI2.WinForms.Guna2Button();
            this.btnmonth = new Guna.UI2.WinForms.Guna2Button();
            this.btntoday = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectID = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDforincome = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelfrom = new System.Windows.Forms.Label();
            this.labeto = new System.Windows.Forms.Label();
            this.dte = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dts = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panelincome.SuspendLayout();
            this.SuspendLayout();
            // 
            // Payment_tblBindingSource
            // 
            this.Payment_tblBindingSource.DataMember = "Payment_tbl";
            this.Payment_tblBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Payment_tblTableAdapter
            // 
            this.Payment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // panelincome
            // 
            this.panelincome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelincome.Controls.Add(this.btnyear);
            this.panelincome.Controls.Add(this.btnmonth);
            this.panelincome.Controls.Add(this.btntoday);
            this.panelincome.Controls.Add(this.btnSelectID);
            this.panelincome.Controls.Add(this.txtIDforincome);
            this.panelincome.Controls.Add(this.labelfrom);
            this.panelincome.Controls.Add(this.labeto);
            this.panelincome.Controls.Add(this.dte);
            this.panelincome.Controls.Add(this.dts);
            this.panelincome.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelincome.Location = new System.Drawing.Point(934, 0);
            this.panelincome.Name = "panelincome";
            this.panelincome.Size = new System.Drawing.Size(403, 862);
            this.panelincome.TabIndex = 1;
            // 
            // btnyear
            // 
            this.btnyear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnyear.CheckedState.Parent = this.btnyear;
            this.btnyear.CustomImages.Parent = this.btnyear;
            this.btnyear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnyear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnyear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnyear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnyear.DisabledState.Parent = this.btnyear;
            this.btnyear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnyear.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyear.ForeColor = System.Drawing.Color.White;
            this.btnyear.HoverState.Parent = this.btnyear;
            this.btnyear.Image = global::WindowsFormsApp1.Properties.Resources.year_48;
            this.btnyear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnyear.ImageSize = new System.Drawing.Size(40, 40);
            this.btnyear.Location = new System.Drawing.Point(130, 244);
            this.btnyear.Name = "btnyear";
            this.btnyear.ShadowDecoration.Parent = this.btnyear;
            this.btnyear.Size = new System.Drawing.Size(183, 50);
            this.btnyear.TabIndex = 76;
            this.btnyear.Text = "Year";
            this.btnyear.TextOffset = new System.Drawing.Point(20, 0);
            this.btnyear.Click += new System.EventHandler(this.btnyear_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmonth.CheckedState.Parent = this.btnmonth;
            this.btnmonth.CustomImages.Parent = this.btnmonth;
            this.btnmonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmonth.DisabledState.Parent = this.btnmonth;
            this.btnmonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnmonth.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonth.ForeColor = System.Drawing.Color.White;
            this.btnmonth.HoverState.Parent = this.btnmonth;
            this.btnmonth.Image = global::WindowsFormsApp1.Properties.Resources.month_48;
            this.btnmonth.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmonth.ImageSize = new System.Drawing.Size(40, 40);
            this.btnmonth.Location = new System.Drawing.Point(130, 168);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.ShadowDecoration.Parent = this.btnmonth;
            this.btnmonth.Size = new System.Drawing.Size(183, 50);
            this.btnmonth.TabIndex = 75;
            this.btnmonth.Text = "Month";
            this.btnmonth.TextOffset = new System.Drawing.Point(20, 0);
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click_1);
            // 
            // btntoday
            // 
            this.btntoday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntoday.CheckedState.Parent = this.btntoday;
            this.btntoday.CustomImages.Parent = this.btntoday;
            this.btntoday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntoday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntoday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntoday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntoday.DisabledState.Parent = this.btntoday;
            this.btntoday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btntoday.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoday.ForeColor = System.Drawing.Color.White;
            this.btntoday.HoverState.Parent = this.btntoday;
            this.btntoday.Image = global::WindowsFormsApp1.Properties.Resources.today_48;
            this.btntoday.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btntoday.ImageSize = new System.Drawing.Size(40, 40);
            this.btntoday.Location = new System.Drawing.Point(130, 100);
            this.btntoday.Name = "btntoday";
            this.btntoday.ShadowDecoration.Parent = this.btntoday;
            this.btntoday.Size = new System.Drawing.Size(183, 50);
            this.btntoday.TabIndex = 74;
            this.btntoday.Text = "Today";
            this.btntoday.TextOffset = new System.Drawing.Point(20, 0);
            this.btntoday.Click += new System.EventHandler(this.btntoday_Click_1);
            // 
            // btnSelectID
            // 
            this.btnSelectID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectID.CheckedState.Parent = this.btnSelectID;
            this.btnSelectID.CustomImages.Parent = this.btnSelectID;
            this.btnSelectID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectID.DisabledState.Parent = this.btnSelectID;
            this.btnSelectID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnSelectID.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectID.ForeColor = System.Drawing.Color.White;
            this.btnSelectID.HoverState.Parent = this.btnSelectID;
            this.btnSelectID.Image = global::WindowsFormsApp1.Properties.Resources.SelectID_48;
            this.btnSelectID.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSelectID.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSelectID.Location = new System.Drawing.Point(6, 22);
            this.btnSelectID.Name = "btnSelectID";
            this.btnSelectID.ShadowDecoration.Parent = this.btnSelectID;
            this.btnSelectID.Size = new System.Drawing.Size(183, 50);
            this.btnSelectID.TabIndex = 73;
            this.btnSelectID.Text = "Select ID";
            this.btnSelectID.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSelectID.Click += new System.EventHandler(this.btnSelectID_Click);
            // 
            // txtIDforincome
            // 
            this.txtIDforincome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDforincome.BorderRadius = 9;
            this.txtIDforincome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDforincome.DefaultText = "";
            this.txtIDforincome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDforincome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDforincome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDforincome.DisabledState.Parent = this.txtIDforincome;
            this.txtIDforincome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDforincome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDforincome.FocusedState.Parent = this.txtIDforincome;
            this.txtIDforincome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDforincome.ForeColor = System.Drawing.Color.Black;
            this.txtIDforincome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDforincome.HoverState.Parent = this.txtIDforincome;
            this.txtIDforincome.Location = new System.Drawing.Point(229, 22);
            this.txtIDforincome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIDforincome.Name = "txtIDforincome";
            this.txtIDforincome.PasswordChar = '\0';
            this.txtIDforincome.PlaceholderText = "";
            this.txtIDforincome.SelectedText = "";
            this.txtIDforincome.ShadowDecoration.Parent = this.txtIDforincome;
            this.txtIDforincome.Size = new System.Drawing.Size(153, 40);
            this.txtIDforincome.TabIndex = 51;
            this.txtIDforincome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelfrom
            // 
            this.labelfrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelfrom.AutoSize = true;
            this.labelfrom.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfrom.ForeColor = System.Drawing.Color.White;
            this.labelfrom.Location = new System.Drawing.Point(174, 330);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(48, 19);
            this.labelfrom.TabIndex = 28;
            this.labelfrom.Text = "From";
            // 
            // labeto
            // 
            this.labeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeto.AutoSize = true;
            this.labeto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeto.ForeColor = System.Drawing.Color.White;
            this.labeto.Location = new System.Drawing.Point(184, 407);
            this.labeto.Name = "labeto";
            this.labeto.Size = new System.Drawing.Size(28, 19);
            this.labeto.TabIndex = 27;
            this.labeto.Text = "To";
            // 
            // dte
            // 
            this.dte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dte.BorderColor = System.Drawing.Color.White;
            this.dte.CheckedState.Parent = this.dte;
            this.dte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dte.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dte.HoverState.Parent = this.dte;
            this.dte.Location = new System.Drawing.Point(63, 429);
            this.dte.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dte.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dte.Name = "dte";
            this.dte.ShadowDecoration.Parent = this.dte;
            this.dte.Size = new System.Drawing.Size(310, 48);
            this.dte.TabIndex = 26;
            this.dte.Value = new System.DateTime(2021, 7, 19, 15, 7, 34, 906);
            this.dte.ValueChanged += new System.EventHandler(this.dte_ValueChanged);
            // 
            // dts
            // 
            this.dts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dts.BorderColor = System.Drawing.Color.White;
            this.dts.CheckedState.Parent = this.dts;
            this.dts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dts.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dts.HoverState.Parent = this.dts;
            this.dts.Location = new System.Drawing.Point(63, 352);
            this.dts.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dts.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dts.Name = "dts";
            this.dts.ShadowDecoration.Parent = this.dts;
            this.dts.Size = new System.Drawing.Size(310, 52);
            this.dts.TabIndex = 25;
            this.dts.Value = new System.DateTime(2021, 7, 19, 15, 7, 34, 906);
            this.dts.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Payment_tblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Income.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 862);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 862);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelincome);
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Payment_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panelincome.ResumeLayout(false);
            this.panelincome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Payment_tblBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.Payment_tblTableAdapter Payment_tblTableAdapter;
        private System.Windows.Forms.Panel panelincome;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dte;
        private Guna.UI2.WinForms.Guna2DateTimePicker dts;
        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label labeto;
        private Guna.UI2.WinForms.Guna2TextBox txtIDforincome;
        private Guna.UI2.WinForms.Guna2Button btnmonth;
        private Guna.UI2.WinForms.Guna2Button btntoday;
        private Guna.UI2.WinForms.Guna2Button btnSelectID;
        private Guna.UI2.WinForms.Guna2Button btnyear;
    }
}