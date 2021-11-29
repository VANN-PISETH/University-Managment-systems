
namespace WindowsFormsApp1
{
    partial class Systemlog
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
            this.pnlsystemlog = new System.Windows.Forms.Panel();
            this.pictureBoxsystemlog = new System.Windows.Forms.PictureBox();
            this.btnremove = new Guna.UI2.WinForms.Guna2Button();
            this.txtsort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelsort = new System.Windows.Forms.Label();
            this.listViewSystemlog = new System.Windows.Forms.ListView();
            this.pnlsystemlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsystemlog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlsystemlog
            // 
            this.pnlsystemlog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsystemlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlsystemlog.Controls.Add(this.pictureBoxsystemlog);
            this.pnlsystemlog.Controls.Add(this.btnremove);
            this.pnlsystemlog.Controls.Add(this.txtsort);
            this.pnlsystemlog.Controls.Add(this.labelsort);
            this.pnlsystemlog.Controls.Add(this.listViewSystemlog);
            this.pnlsystemlog.Location = new System.Drawing.Point(-1, -1);
            this.pnlsystemlog.Name = "pnlsystemlog";
            this.pnlsystemlog.Size = new System.Drawing.Size(1117, 792);
            this.pnlsystemlog.TabIndex = 0;
            // 
            // pictureBoxsystemlog
            // 
            this.pictureBoxsystemlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxsystemlog.Image = global::WindowsFormsApp1.Properties.Resources.icons8_remove_64;
            this.pictureBoxsystemlog.Location = new System.Drawing.Point(877, 729);
            this.pictureBoxsystemlog.Name = "pictureBoxsystemlog";
            this.pictureBoxsystemlog.Size = new System.Drawing.Size(42, 49);
            this.pictureBoxsystemlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsystemlog.TabIndex = 98;
            this.pictureBoxsystemlog.TabStop = false;
            // 
            // btnremove
            // 
            this.btnremove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.btnremove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnremove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnremove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnremove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnremove.DisabledState.Parent = this.btnremove;
            this.btnremove.FillColor = System.Drawing.Color.Red;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Location = new System.Drawing.Point(925, 729);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Size = new System.Drawing.Size(180, 49);
            this.btnremove.TabIndex = 97;
            this.btnremove.Text = "Remove";
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // txtsort
            // 
            this.txtsort.BackColor = System.Drawing.Color.Transparent;
            this.txtsort.BorderRadius = 9;
            this.txtsort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsort.FocusedState.Parent = this.txtsort;
            this.txtsort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsort.ForeColor = System.Drawing.Color.Black;
            this.txtsort.HoverState.Parent = this.txtsort;
            this.txtsort.ItemHeight = 30;
            this.txtsort.Items.AddRange(new object[] {
            "Default",
            "Registration",
            "Add Class",
            "Set Class",
            "Add Teacher",
            "Payment"});
            this.txtsort.ItemsAppearance.Parent = this.txtsort;
            this.txtsort.Location = new System.Drawing.Point(171, 18);
            this.txtsort.Name = "txtsort";
            this.txtsort.ShadowDecoration.Parent = this.txtsort;
            this.txtsort.Size = new System.Drawing.Size(248, 36);
            this.txtsort.TabIndex = 95;
            this.txtsort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsort.SelectedIndexChanged += new System.EventHandler(this.txtsort_SelectedIndexChanged);
            // 
            // labelsort
            // 
            this.labelsort.AutoSize = true;
            this.labelsort.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsort.ForeColor = System.Drawing.Color.White;
            this.labelsort.Location = new System.Drawing.Point(13, 23);
            this.labelsort.Name = "labelsort";
            this.labelsort.Size = new System.Drawing.Size(115, 31);
            this.labelsort.TabIndex = 94;
            this.labelsort.Text = "Sort By :";
            // 
            // listViewSystemlog
            // 
            this.listViewSystemlog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSystemlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSystemlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSystemlog.GridLines = true;
            this.listViewSystemlog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSystemlog.HideSelection = false;
            this.listViewSystemlog.Location = new System.Drawing.Point(13, 91);
            this.listViewSystemlog.Name = "listViewSystemlog";
            this.listViewSystemlog.Size = new System.Drawing.Size(1092, 618);
            this.listViewSystemlog.TabIndex = 0;
            this.listViewSystemlog.UseCompatibleStateImageBehavior = false;
            this.listViewSystemlog.View = System.Windows.Forms.View.Details;
            // 
            // Systemlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 789);
            this.Controls.Add(this.pnlsystemlog);
            this.Name = "Systemlog";
            this.Text = "Systemlog";
            this.Load += new System.EventHandler(this.Systemlog_Load);
            this.pnlsystemlog.ResumeLayout(false);
            this.pnlsystemlog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsystemlog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlsystemlog;
        private System.Windows.Forms.ListView listViewSystemlog;
        private Guna.UI2.WinForms.Guna2ComboBox txtsort;
        private System.Windows.Forms.Label labelsort;
        private System.Windows.Forms.PictureBox pictureBoxsystemlog;
        private Guna.UI2.WinForms.Guna2Button btnremove;
    }
}