
namespace WindowsFormsApp1
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelClassform = new System.Windows.Forms.Panel();
            this.guna2Separatorunder = new Guna.UI2.WinForms.Guna2Separator();
            this.lblattendance = new System.Windows.Forms.Label();
            this.labelclass = new System.Windows.Forms.Label();
            this.txtclassattendance = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labeldateattendance = new System.Windows.Forms.Label();
            this.guna2Separator1attendance = new Guna.UI2.WinForms.Guna2Separator();
            this.txtdateattendance = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvattendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nameatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Late = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Absent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2Elipse1attendance = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragcontrolattendance = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picattendance = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnprintattendance = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnshowlist = new Guna.UI2.WinForms.Guna2Button();
            this.panelClassform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattendance)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClassform
            // 
            this.panelClassform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClassform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelClassform.Controls.Add(this.btnshowlist);
            this.panelClassform.Controls.Add(this.guna2Separatorunder);
            this.panelClassform.Controls.Add(this.picattendance);
            this.panelClassform.Controls.Add(this.btnprintattendance);
            this.panelClassform.Controls.Add(this.lblattendance);
            this.panelClassform.Controls.Add(this.labelclass);
            this.panelClassform.Controls.Add(this.txtclassattendance);
            this.panelClassform.Controls.Add(this.labeldateattendance);
            this.panelClassform.Controls.Add(this.guna2Separator1attendance);
            this.panelClassform.Controls.Add(this.txtdateattendance);
            this.panelClassform.Controls.Add(this.dgvattendance);
            this.panelClassform.Location = new System.Drawing.Point(0, 0);
            this.panelClassform.Name = "panelClassform";
            this.panelClassform.Size = new System.Drawing.Size(1128, 904);
            this.panelClassform.TabIndex = 4;
            this.panelClassform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClassform_Paint);
            // 
            // guna2Separatorunder
            // 
            this.guna2Separatorunder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Separatorunder.Location = new System.Drawing.Point(0, 891);
            this.guna2Separatorunder.Name = "guna2Separatorunder";
            this.guna2Separatorunder.Size = new System.Drawing.Size(1128, 10);
            this.guna2Separatorunder.TabIndex = 52;
            // 
            // lblattendance
            // 
            this.lblattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblattendance.AutoSize = true;
            this.lblattendance.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblattendance.ForeColor = System.Drawing.Color.White;
            this.lblattendance.Location = new System.Drawing.Point(394, 98);
            this.lblattendance.Name = "lblattendance";
            this.lblattendance.Size = new System.Drawing.Size(296, 41);
            this.lblattendance.TabIndex = 39;
            this.lblattendance.Text = "Attendance Sheet";
            // 
            // labelclass
            // 
            this.labelclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelclass.AutoSize = true;
            this.labelclass.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclass.ForeColor = System.Drawing.Color.White;
            this.labelclass.Location = new System.Drawing.Point(557, 188);
            this.labelclass.Name = "labelclass";
            this.labelclass.Size = new System.Drawing.Size(95, 19);
            this.labelclass.TabIndex = 50;
            this.labelclass.Text = "Select Class";
            // 
            // txtclassattendance
            // 
            this.txtclassattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclassattendance.BackColor = System.Drawing.Color.Transparent;
            this.txtclassattendance.BorderRadius = 9;
            this.txtclassattendance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtclassattendance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtclassattendance.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclassattendance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclassattendance.FocusedState.Parent = this.txtclassattendance;
            this.txtclassattendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclassattendance.ForeColor = System.Drawing.Color.Black;
            this.txtclassattendance.HoverState.Parent = this.txtclassattendance;
            this.txtclassattendance.ItemHeight = 30;
            this.txtclassattendance.ItemsAppearance.Parent = this.txtclassattendance;
            this.txtclassattendance.Location = new System.Drawing.Point(442, 218);
            this.txtclassattendance.Name = "txtclassattendance";
            this.txtclassattendance.ShadowDecoration.Parent = this.txtclassattendance;
            this.txtclassattendance.Size = new System.Drawing.Size(321, 36);
            this.txtclassattendance.TabIndex = 49;
            this.txtclassattendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclassattendance.SelectedIndexChanged += new System.EventHandler(this.txtmajor_SelectedIndexChanged);
            // 
            // labeldateattendance
            // 
            this.labeldateattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldateattendance.AutoSize = true;
            this.labeldateattendance.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldateattendance.ForeColor = System.Drawing.Color.White;
            this.labeldateattendance.Location = new System.Drawing.Point(196, 188);
            this.labeldateattendance.Name = "labeldateattendance";
            this.labeldateattendance.Size = new System.Drawing.Size(106, 19);
            this.labeldateattendance.TabIndex = 48;
            this.labeldateattendance.Text = "Current Date";
            // 
            // guna2Separator1attendance
            // 
            this.guna2Separator1attendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Separator1attendance.Location = new System.Drawing.Point(0, 175);
            this.guna2Separator1attendance.Name = "guna2Separator1attendance";
            this.guna2Separator1attendance.Size = new System.Drawing.Size(1128, 10);
            this.guna2Separator1attendance.TabIndex = 47;
            // 
            // txtdateattendance
            // 
            this.txtdateattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdateattendance.BorderRadius = 9;
            this.txtdateattendance.CheckedState.Parent = this.txtdateattendance;
            this.txtdateattendance.FillColor = System.Drawing.Color.White;
            this.txtdateattendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdateattendance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdateattendance.HoverState.Parent = this.txtdateattendance;
            this.txtdateattendance.Location = new System.Drawing.Point(97, 218);
            this.txtdateattendance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdateattendance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdateattendance.Name = "txtdateattendance";
            this.txtdateattendance.ShadowDecoration.Parent = this.txtdateattendance;
            this.txtdateattendance.Size = new System.Drawing.Size(325, 46);
            this.txtdateattendance.TabIndex = 46;
            this.txtdateattendance.Value = new System.DateTime(2021, 7, 14, 20, 28, 43, 68);
            // 
            // dgvattendance
            // 
            this.dgvattendance.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvattendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvattendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvattendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dgvattendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvattendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvattendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvattendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvattendance.ColumnHeadersHeight = 30;
            this.dgvattendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nameatt,
            this.Sexatt,
            this.Present,
            this.Late,
            this.Absent});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvattendance.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvattendance.EnableHeadersVisualStyles = false;
            this.dgvattendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvattendance.Location = new System.Drawing.Point(184, 275);
            this.dgvattendance.Name = "dgvattendance";
            this.dgvattendance.RowHeadersVisible = false;
            this.dgvattendance.RowHeadersWidth = 51;
            this.dgvattendance.RowTemplate.Height = 24;
            this.dgvattendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvattendance.Size = new System.Drawing.Size(776, 610);
            this.dgvattendance.TabIndex = 41;
            this.dgvattendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvattendance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvattendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvattendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvattendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvattendance.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dgvattendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvattendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvattendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvattendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvattendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvattendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvattendance.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvattendance.ThemeStyle.ReadOnly = false;
            this.dgvattendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvattendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvattendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvattendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvattendance.ThemeStyle.RowsStyle.Height = 24;
            this.dgvattendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvattendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Nameatt
            // 
            this.Nameatt.HeaderText = "Name";
            this.Nameatt.MinimumWidth = 6;
            this.Nameatt.Name = "Nameatt";
            // 
            // Sexatt
            // 
            this.Sexatt.HeaderText = "Sex";
            this.Sexatt.MinimumWidth = 6;
            this.Sexatt.Name = "Sexatt";
            // 
            // Present
            // 
            this.Present.HeaderText = "Present";
            this.Present.MinimumWidth = 6;
            this.Present.Name = "Present";
            // 
            // Late
            // 
            this.Late.HeaderText = "Late";
            this.Late.MinimumWidth = 6;
            this.Late.Name = "Late";
            // 
            // Absent
            // 
            this.Absent.HeaderText = "Absent";
            this.Absent.MinimumWidth = 6;
            this.Absent.Name = "Absent";
            // 
            // guna2Elipse1attendance
            // 
            this.guna2Elipse1attendance.TargetControl = this;
            // 
            // dragcontrolattendance
            // 
            this.dragcontrolattendance.TargetControl = this.panelClassform;
            // 
            // picattendance
            // 
            this.picattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picattendance.Image = global::WindowsFormsApp1.Properties.Resources.icons8_attendance_32;
            this.picattendance.ImageRotate = 0F;
            this.picattendance.Location = new System.Drawing.Point(25, 98);
            this.picattendance.Name = "picattendance";
            this.picattendance.ShadowDecoration.Parent = this.picattendance;
            this.picattendance.Size = new System.Drawing.Size(43, 41);
            this.picattendance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picattendance.TabIndex = 41;
            this.picattendance.TabStop = false;
            // 
            // btnprintattendance
            // 
            this.btnprintattendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprintattendance.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnprintattendance.CheckedState.Parent = this.btnprintattendance;
            this.btnprintattendance.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnprintattendance.HoverState.Parent = this.btnprintattendance;
            this.btnprintattendance.Image = global::WindowsFormsApp1.Properties.Resources.icons8_print_64;
            this.btnprintattendance.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnprintattendance.ImageRotate = 0F;
            this.btnprintattendance.Location = new System.Drawing.Point(1052, 204);
            this.btnprintattendance.Name = "btnprintattendance";
            this.btnprintattendance.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnprintattendance.PressedState.Parent = this.btnprintattendance;
            this.btnprintattendance.ShadowDecoration.Parent = this.btnprintattendance;
            this.btnprintattendance.Size = new System.Drawing.Size(64, 54);
            this.btnprintattendance.TabIndex = 51;
            this.btnprintattendance.Click += new System.EventHandler(this.guna2ImageButton1_Click);
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
            this.btnshowlist.Location = new System.Drawing.Point(826, 208);
            this.btnshowlist.Name = "btnshowlist";
            this.btnshowlist.ShadowDecoration.Parent = this.btnshowlist;
            this.btnshowlist.Size = new System.Drawing.Size(183, 50);
            this.btnshowlist.TabIndex = 76;
            this.btnshowlist.Text = "Show List";
            this.btnshowlist.TextOffset = new System.Drawing.Point(20, 0);
            this.btnshowlist.Click += new System.EventHandler(this.btnshowlist_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 904);
            this.Controls.Add(this.panelClassform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.panelClassform.ResumeLayout(false);
            this.panelClassform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picattendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClassform;
        private Guna.UI2.WinForms.Guna2PictureBox picattendance;
        private System.Windows.Forms.Label lblattendance;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1attendance;
        private Guna.UI2.WinForms.Guna2DataGridView dgvattendance;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1attendance;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdateattendance;
        private System.Windows.Forms.Label labeldateattendance;
        private System.Windows.Forms.Label labelclass;
        private Guna.UI2.WinForms.Guna2ComboBox txtclassattendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nameatt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexatt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Present;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Late;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Absent;
        private Guna.UI2.WinForms.Guna2ImageButton btnprintattendance;
        private Guna.UI2.WinForms.Guna2Separator guna2Separatorunder;
        private Guna.UI2.WinForms.Guna2DragControl dragcontrolattendance;
        private Guna.UI2.WinForms.Guna2Button btnshowlist;
    }
}