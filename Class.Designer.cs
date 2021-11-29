
namespace WindowsFormsApp1
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.panelClassform = new System.Windows.Forms.Panel();
            this.sforclassunder = new Guna.UI2.WinForms.Guna2Separator();
            this.sforclass = new Guna.UI2.WinForms.Guna2Separator();
            this.paneladdstudenttoclass = new System.Windows.Forms.Panel();
            this.labeladdstudenttoclass = new System.Windows.Forms.Label();
            this.txtSetstudent = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelAddclass = new System.Windows.Forms.Panel();
            this.labeladdclass = new System.Windows.Forms.Label();
            this.txtaddclass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblClassform = new System.Windows.Forms.Label();
            this.panelClassform.SuspendLayout();
            this.paneladdstudenttoclass.SuspendLayout();
            this.panelAddclass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClassform
            // 
            this.panelClassform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelClassform.Controls.Add(this.sforclassunder);
            this.panelClassform.Controls.Add(this.sforclass);
            this.panelClassform.Controls.Add(this.paneladdstudenttoclass);
            this.panelClassform.Controls.Add(this.panelAddclass);
            this.panelClassform.Controls.Add(this.lblClassform);
            resources.ApplyResources(this.panelClassform, "panelClassform");
            this.panelClassform.Name = "panelClassform";
            // 
            // sforclassunder
            // 
            resources.ApplyResources(this.sforclassunder, "sforclassunder");
            this.sforclassunder.Name = "sforclassunder";
            // 
            // sforclass
            // 
            resources.ApplyResources(this.sforclass, "sforclass");
            this.sforclass.Name = "sforclass";
            // 
            // paneladdstudenttoclass
            // 
            resources.ApplyResources(this.paneladdstudenttoclass, "paneladdstudenttoclass");
            this.paneladdstudenttoclass.Controls.Add(this.labeladdstudenttoclass);
            this.paneladdstudenttoclass.Controls.Add(this.txtSetstudent);
            this.paneladdstudenttoclass.Name = "paneladdstudenttoclass";
            // 
            // labeladdstudenttoclass
            // 
            resources.ApplyResources(this.labeladdstudenttoclass, "labeladdstudenttoclass");
            this.labeladdstudenttoclass.ForeColor = System.Drawing.Color.White;
            this.labeladdstudenttoclass.Name = "labeladdstudenttoclass";
            // 
            // txtSetstudent
            // 
            this.txtSetstudent.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.txtSetstudent.CheckedState.Parent = this.txtSetstudent;
            this.txtSetstudent.HoverState.ImageSize = new System.Drawing.Size(90, 90);
            this.txtSetstudent.HoverState.Parent = this.txtSetstudent;
            this.txtSetstudent.Image = global::WindowsFormsApp1.Properties.Resources.new_64;
            this.txtSetstudent.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtSetstudent.ImageRotate = 0F;
            this.txtSetstudent.ImageSize = new System.Drawing.Size(90, 90);
            resources.ApplyResources(this.txtSetstudent, "txtSetstudent");
            this.txtSetstudent.Name = "txtSetstudent";
            this.txtSetstudent.PressedState.ImageSize = new System.Drawing.Size(90, 90);
            this.txtSetstudent.PressedState.Parent = this.txtSetstudent;
            this.txtSetstudent.ShadowDecoration.Parent = this.txtSetstudent;
            this.txtSetstudent.Click += new System.EventHandler(this.txtSetstudent_Click);
            // 
            // panelAddclass
            // 
            resources.ApplyResources(this.panelAddclass, "panelAddclass");
            this.panelAddclass.Controls.Add(this.labeladdclass);
            this.panelAddclass.Controls.Add(this.txtaddclass);
            this.panelAddclass.Name = "panelAddclass";
            // 
            // labeladdclass
            // 
            resources.ApplyResources(this.labeladdclass, "labeladdclass");
            this.labeladdclass.ForeColor = System.Drawing.Color.White;
            this.labeladdclass.Name = "labeladdclass";
            // 
            // txtaddclass
            // 
            this.txtaddclass.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.txtaddclass.CheckedState.Parent = this.txtaddclass;
            this.txtaddclass.HoverState.ImageSize = new System.Drawing.Size(80, 80);
            this.txtaddclass.HoverState.Parent = this.txtaddclass;
            this.txtaddclass.Image = global::WindowsFormsApp1.Properties.Resources.classroom_641;
            this.txtaddclass.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtaddclass.ImageRotate = 0F;
            this.txtaddclass.ImageSize = new System.Drawing.Size(80, 80);
            resources.ApplyResources(this.txtaddclass, "txtaddclass");
            this.txtaddclass.Name = "txtaddclass";
            this.txtaddclass.PressedState.ImageSize = new System.Drawing.Size(80, 80);
            this.txtaddclass.PressedState.Parent = this.txtaddclass;
            this.txtaddclass.ShadowDecoration.Parent = this.txtaddclass;
            this.txtaddclass.Click += new System.EventHandler(this.txtaddclass_Click);
            // 
            // lblClassform
            // 
            resources.ApplyResources(this.lblClassform, "lblClassform");
            this.lblClassform.ForeColor = System.Drawing.Color.White;
            this.lblClassform.Name = "lblClassform";
            // 
            // Class
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelClassform);
            this.Name = "Class";
            this.panelClassform.ResumeLayout(false);
            this.panelClassform.PerformLayout();
            this.paneladdstudenttoclass.ResumeLayout(false);
            this.paneladdstudenttoclass.PerformLayout();
            this.panelAddclass.ResumeLayout(false);
            this.panelAddclass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClassform;
        private System.Windows.Forms.Label lblClassform;
        private Guna.UI2.WinForms.Guna2ImageButton txtaddclass;
        private System.Windows.Forms.Panel panelAddclass;
        private System.Windows.Forms.Label labeladdclass;
        private System.Windows.Forms.Panel paneladdstudenttoclass;
        private System.Windows.Forms.Label labeladdstudenttoclass;
        private Guna.UI2.WinForms.Guna2ImageButton txtSetstudent;
        private Guna.UI2.WinForms.Guna2Separator sforclassunder;
        private Guna.UI2.WinForms.Guna2Separator sforclass;
    }
}