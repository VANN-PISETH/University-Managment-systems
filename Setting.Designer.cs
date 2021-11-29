
namespace WindowsFormsApp1
{
    partial class Setting
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
            this.panelsetting = new System.Windows.Forms.Panel();
            this.panelinsetting = new System.Windows.Forms.Panel();
            this.txtchangeuser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.txtStuID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblsetting = new System.Windows.Forms.Label();
            this.labellanguage = new System.Windows.Forms.Label();
            this.panelsetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsetting
            // 
            this.panelsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelsetting.Controls.Add(this.panelinsetting);
            this.panelsetting.Controls.Add(this.txtchangeuser);
            this.panelsetting.Controls.Add(this.labeluser);
            this.panelsetting.Controls.Add(this.txtStuID);
            this.panelsetting.Controls.Add(this.lblsetting);
            this.panelsetting.Controls.Add(this.labellanguage);
            this.panelsetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsetting.Location = new System.Drawing.Point(0, 0);
            this.panelsetting.Name = "panelsetting";
            this.panelsetting.Size = new System.Drawing.Size(1097, 749);
            this.panelsetting.TabIndex = 2;
            // 
            // panelinsetting
            // 
            this.panelinsetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelinsetting.BackColor = System.Drawing.Color.White;
            this.panelinsetting.ForeColor = System.Drawing.Color.White;
            this.panelinsetting.Location = new System.Drawing.Point(126, 419);
            this.panelinsetting.Name = "panelinsetting";
            this.panelinsetting.Size = new System.Drawing.Size(800, 1);
            this.panelinsetting.TabIndex = 94;
            // 
            // txtchangeuser
            // 
            this.txtchangeuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtchangeuser.BackColor = System.Drawing.Color.Transparent;
            this.txtchangeuser.BorderRadius = 9;
            this.txtchangeuser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtchangeuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtchangeuser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchangeuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchangeuser.FocusedState.Parent = this.txtchangeuser;
            this.txtchangeuser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtchangeuser.ForeColor = System.Drawing.Color.Black;
            this.txtchangeuser.HoverState.Parent = this.txtchangeuser;
            this.txtchangeuser.ItemHeight = 30;
            this.txtchangeuser.ItemsAppearance.Parent = this.txtchangeuser;
            this.txtchangeuser.Location = new System.Drawing.Point(399, 279);
            this.txtchangeuser.Name = "txtchangeuser";
            this.txtchangeuser.ShadowDecoration.Parent = this.txtchangeuser;
            this.txtchangeuser.Size = new System.Drawing.Size(408, 36);
            this.txtchangeuser.TabIndex = 93;
            this.txtchangeuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeluser
            // 
            this.labeluser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.ForeColor = System.Drawing.Color.White;
            this.labeluser.Location = new System.Drawing.Point(48, 275);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(224, 40);
            this.labeluser.TabIndex = 92;
            this.labeluser.Text = "Change User :";
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
            this.txtStuID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStuID.ForeColor = System.Drawing.Color.Black;
            this.txtStuID.HoverState.Parent = this.txtStuID;
            this.txtStuID.ItemHeight = 30;
            this.txtStuID.Items.AddRange(new object[] {
            "English",
            "Khmer",
            "Thai",
            "Japan"});
            this.txtStuID.ItemsAppearance.Parent = this.txtStuID;
            this.txtStuID.Location = new System.Drawing.Point(399, 180);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.ShadowDecoration.Parent = this.txtStuID;
            this.txtStuID.Size = new System.Drawing.Size(408, 36);
            this.txtStuID.TabIndex = 91;
            this.txtStuID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsetting
            // 
            this.lblsetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsetting.AutoSize = true;
            this.lblsetting.Font = new System.Drawing.Font("Modern No. 20", 24F);
            this.lblsetting.ForeColor = System.Drawing.Color.White;
            this.lblsetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblsetting.Location = new System.Drawing.Point(454, 42);
            this.lblsetting.Name = "lblsetting";
            this.lblsetting.Size = new System.Drawing.Size(130, 41);
            this.lblsetting.TabIndex = 90;
            this.lblsetting.Text = "Setting";
            // 
            // labellanguage
            // 
            this.labellanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellanguage.AutoSize = true;
            this.labellanguage.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellanguage.ForeColor = System.Drawing.Color.White;
            this.labellanguage.Location = new System.Drawing.Point(92, 176);
            this.labellanguage.Name = "labellanguage";
            this.labellanguage.Size = new System.Drawing.Size(180, 40);
            this.labellanguage.TabIndex = 44;
            this.labellanguage.Text = "Language :";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 749);
            this.Controls.Add(this.panelsetting);
            this.Name = "Setting";
            this.Text = "Setting";
            this.panelsetting.ResumeLayout(false);
            this.panelsetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsetting;
        private System.Windows.Forms.Label labellanguage;
        private System.Windows.Forms.Label lblsetting;
        private Guna.UI2.WinForms.Guna2ComboBox txtStuID;
        private System.Windows.Forms.Panel panelinsetting;
        private Guna.UI2.WinForms.Guna2ComboBox txtchangeuser;
        private System.Windows.Forms.Label labeluser;
    }
}