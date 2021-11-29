
namespace WindowsFormsApp1
{
    partial class LogIn
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.labellogin = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelforgetpassword = new System.Windows.Forms.Label();
            this.btnsignin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnsignup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBoxlogin = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1login = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.paneltoplogin = new System.Windows.Forms.Panel();
            this.guna2DragControl1login = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.max = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelforlogin = new System.Windows.Forms.Panel();
            this.panelsignup = new System.Windows.Forms.Panel();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelnewpassword = new System.Windows.Forms.Label();
            this.txtnewpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbacktologin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelsignup = new System.Windows.Forms.Label();
            this.labelusernamesignup = new System.Windows.Forms.Label();
            this.labelconfirm = new System.Windows.Forms.Label();
            this.txtsignupusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtconfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.btncreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Transition1login = new Guna.UI2.WinForms.Guna2Transition();
            this.btnexit = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).BeginInit();
            this.panelforlogin.SuspendLayout();
            this.panelsignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // labellogin
            // 
            this.labellogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellogin.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labellogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labellogin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.DarkViolet;
            this.labellogin.Location = new System.Drawing.Point(167, 103);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(131, 40);
            this.labellogin.TabIndex = 1;
            this.labellogin.Text = "LOG IN";
            // 
            // labelusername
            // 
            this.labelusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelusername.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelusername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelusername.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(20, 168);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(100, 21);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "User Name";
            // 
            // labelpassword
            // 
            this.labelpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpassword.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelpassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(20, 245);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(85, 21);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.BorderColor = System.Drawing.Color.Transparent;
            this.txtusername.BorderRadius = 10;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1login.SetDecoration(this.txtusername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(24, 194);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(396, 36);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtpassword.BorderRadius = 10;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1login.SetDecoration(this.txtpassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(24, 271);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(396, 36);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelforgetpassword
            // 
            this.labelforgetpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelforgetpassword.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelforgetpassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelforgetpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforgetpassword.Location = new System.Drawing.Point(155, 326);
            this.labelforgetpassword.Name = "labelforgetpassword";
            this.labelforgetpassword.Size = new System.Drawing.Size(142, 19);
            this.labelforgetpassword.TabIndex = 6;
            this.labelforgetpassword.Text = "Forget Password";
            this.labelforgetpassword.Click += new System.EventHandler(this.labelforgetpassword_Click);
            // 
            // btnsignin
            // 
            this.btnsignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsignin.BorderRadius = 19;
            this.btnsignin.CheckedState.Parent = this.btnsignin;
            this.btnsignin.CustomImages.Parent = this.btnsignin;
            this.guna2Transition1login.SetDecoration(this.btnsignin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnsignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsignin.DisabledState.Parent = this.btnsignin;
            this.btnsignin.FillColor = System.Drawing.Color.Magenta;
            this.btnsignin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnsignin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.HoverState.Parent = this.btnsignin;
            this.btnsignin.Location = new System.Drawing.Point(75, 370);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.ShadowDecoration.Parent = this.btnsignin;
            this.btnsignin.Size = new System.Drawing.Size(295, 45);
            this.btnsignin.TabIndex = 7;
            this.btnsignin.Text = "SIGN IN";
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsignup.BorderRadius = 19;
            this.btnsignup.CheckedState.Parent = this.btnsignup;
            this.btnsignup.CustomImages.Parent = this.btnsignup;
            this.guna2Transition1login.SetDecoration(this.btnsignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnsignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsignup.DisabledState.Parent = this.btnsignup;
            this.btnsignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnsignup.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.HoverState.Parent = this.btnsignup;
            this.btnsignup.Location = new System.Drawing.Point(308, 24);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.ShadowDecoration.Parent = this.btnsignup;
            this.btnsignup.Size = new System.Drawing.Size(125, 45);
            this.btnsignup.TabIndex = 8;
            this.btnsignup.Text = "SIGN UP";
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click_1);
            // 
            // pictureBoxlogin
            // 
            this.pictureBoxlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Transition1login.SetDecoration(this.pictureBoxlogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBoxlogin.Image = global::WindowsFormsApp1.Properties.Resources.login_img1;
            this.pictureBoxlogin.Location = new System.Drawing.Point(-1, 73);
            this.pictureBoxlogin.Name = "pictureBoxlogin";
            this.pictureBoxlogin.Size = new System.Drawing.Size(705, 626);
            this.pictureBoxlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogin.TabIndex = 0;
            this.pictureBoxlogin.TabStop = false;
            // 
            // guna2Elipse1login
            // 
            this.guna2Elipse1login.BorderRadius = 88;
            this.guna2Elipse1login.TargetControl = this;
            // 
            // paneltoplogin
            // 
            this.paneltoplogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Transition1login.SetDecoration(this.paneltoplogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.paneltoplogin.Location = new System.Drawing.Point(42, 0);
            this.paneltoplogin.Name = "paneltoplogin";
            this.paneltoplogin.Size = new System.Drawing.Size(919, 75);
            this.paneltoplogin.TabIndex = 9;
            this.paneltoplogin.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltoplogin_Paint);
            // 
            // guna2DragControl1login
            // 
            this.guna2DragControl1login.TargetControl = this.paneltoplogin;
            // 
            // mini
            // 
            this.mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1login.SetDecoration(this.mini, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mini.FillColor = System.Drawing.Color.Transparent;
            this.mini.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mini.HoverState.Parent = this.mini;
            this.mini.IconColor = System.Drawing.Color.Black;
            this.mini.Location = new System.Drawing.Point(967, 12);
            this.mini.Name = "mini";
            this.mini.ShadowDecoration.Parent = this.mini;
            this.mini.Size = new System.Drawing.Size(51, 41);
            this.mini.TabIndex = 12;
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2Transition1login.SetDecoration(this.max, Guna.UI2.AnimatorNS.DecorationType.None);
            this.max.FillColor = System.Drawing.Color.Transparent;
            this.max.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.max.HoverState.Parent = this.max;
            this.max.IconColor = System.Drawing.Color.Black;
            this.max.Location = new System.Drawing.Point(1018, 12);
            this.max.Name = "max";
            this.max.ShadowDecoration.Parent = this.max;
            this.max.Size = new System.Drawing.Size(51, 41);
            this.max.TabIndex = 11;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1login.SetDecoration(this.close, Guna.UI2.AnimatorNS.DecorationType.None);
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.close.HoverState.Parent = this.close;
            this.close.IconColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1069, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(51, 41);
            this.close.TabIndex = 10;
            // 
            // panelforlogin
            // 
            this.panelforlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelforlogin.Controls.Add(this.btnexit);
            this.panelforlogin.Controls.Add(this.btnsignup);
            this.panelforlogin.Controls.Add(this.labellogin);
            this.panelforlogin.Controls.Add(this.labelusername);
            this.panelforlogin.Controls.Add(this.labelpassword);
            this.panelforlogin.Controls.Add(this.txtpassword);
            this.panelforlogin.Controls.Add(this.btnsignin);
            this.panelforlogin.Controls.Add(this.txtusername);
            this.panelforlogin.Controls.Add(this.labelforgetpassword);
            this.guna2Transition1login.SetDecoration(this.panelforlogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelforlogin.Location = new System.Drawing.Point(710, 73);
            this.panelforlogin.Name = "panelforlogin";
            this.panelforlogin.Size = new System.Drawing.Size(442, 626);
            this.panelforlogin.TabIndex = 13;
            // 
            // panelsignup
            // 
            this.panelsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelsignup.Controls.Add(this.labelemail);
            this.panelsignup.Controls.Add(this.txtemail);
            this.panelsignup.Controls.Add(this.labelnewpassword);
            this.panelsignup.Controls.Add(this.txtnewpassword);
            this.panelsignup.Controls.Add(this.txtbacktologin);
            this.panelsignup.Controls.Add(this.labelsignup);
            this.panelsignup.Controls.Add(this.labelusernamesignup);
            this.panelsignup.Controls.Add(this.labelconfirm);
            this.panelsignup.Controls.Add(this.txtsignupusername);
            this.panelsignup.Controls.Add(this.txtconfirm);
            this.panelsignup.Controls.Add(this.btncreate);
            this.guna2Transition1login.SetDecoration(this.panelsignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelsignup.Location = new System.Drawing.Point(710, 73);
            this.panelsignup.Name = "panelsignup";
            this.panelsignup.Size = new System.Drawing.Size(445, 626);
            this.panelsignup.TabIndex = 14;
            // 
            // labelemail
            // 
            this.labelemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelemail.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelemail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelemail.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(21, 243);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(54, 21);
            this.labelemail.TabIndex = 11;
            this.labelemail.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.BorderColor = System.Drawing.Color.Transparent;
            this.txtemail.BorderRadius = 10;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1login.SetDecoration(this.txtemail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.Parent = this.txtemail;
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedState.Parent = this.txtemail;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.HoverState.Parent = this.txtemail;
            this.txtemail.Location = new System.Drawing.Point(25, 271);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.ShadowDecoration.Parent = this.txtemail;
            this.txtemail.Size = new System.Drawing.Size(396, 36);
            this.txtemail.TabIndex = 12;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelnewpassword
            // 
            this.labelnewpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnewpassword.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelnewpassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelnewpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnewpassword.Location = new System.Drawing.Point(21, 322);
            this.labelnewpassword.Name = "labelnewpassword";
            this.labelnewpassword.Size = new System.Drawing.Size(128, 21);
            this.labelnewpassword.TabIndex = 9;
            this.labelnewpassword.Text = "New Password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnewpassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtnewpassword.BorderRadius = 10;
            this.txtnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1login.SetDecoration(this.txtnewpassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtnewpassword.DefaultText = "";
            this.txtnewpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnewpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnewpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnewpassword.DisabledState.Parent = this.txtnewpassword;
            this.txtnewpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnewpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnewpassword.FocusedState.Parent = this.txtnewpassword;
            this.txtnewpassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.ForeColor = System.Drawing.Color.Black;
            this.txtnewpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnewpassword.HoverState.Parent = this.txtnewpassword;
            this.txtnewpassword.Location = new System.Drawing.Point(25, 350);
            this.txtnewpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '\0';
            this.txtnewpassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtnewpassword.PlaceholderText = "";
            this.txtnewpassword.SelectedText = "";
            this.txtnewpassword.ShadowDecoration.Parent = this.txtnewpassword;
            this.txtnewpassword.Size = new System.Drawing.Size(396, 36);
            this.txtnewpassword.TabIndex = 10;
            this.txtnewpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbacktologin
            // 
            this.txtbacktologin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbacktologin.BorderRadius = 19;
            this.txtbacktologin.CheckedState.Parent = this.txtbacktologin;
            this.txtbacktologin.CustomImages.Parent = this.txtbacktologin;
            this.guna2Transition1login.SetDecoration(this.txtbacktologin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtbacktologin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtbacktologin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtbacktologin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtbacktologin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtbacktologin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtbacktologin.DisabledState.Parent = this.txtbacktologin;
            this.txtbacktologin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtbacktologin.FillColor2 = System.Drawing.Color.Fuchsia;
            this.txtbacktologin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbacktologin.ForeColor = System.Drawing.Color.White;
            this.txtbacktologin.HoverState.Parent = this.txtbacktologin;
            this.txtbacktologin.Location = new System.Drawing.Point(325, 24);
            this.txtbacktologin.Name = "txtbacktologin";
            this.txtbacktologin.ShadowDecoration.Parent = this.txtbacktologin;
            this.txtbacktologin.Size = new System.Drawing.Size(109, 45);
            this.txtbacktologin.TabIndex = 8;
            this.txtbacktologin.Text = "LOG IN";
            this.txtbacktologin.Click += new System.EventHandler(this.txtbacktologin_Click_1);
            // 
            // labelsignup
            // 
            this.labelsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsignup.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelsignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelsignup.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignup.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelsignup.Location = new System.Drawing.Point(161, 103);
            this.labelsignup.Name = "labelsignup";
            this.labelsignup.Size = new System.Drawing.Size(144, 40);
            this.labelsignup.TabIndex = 1;
            this.labelsignup.Text = "SIGN UP";
            // 
            // labelusernamesignup
            // 
            this.labelusernamesignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelusernamesignup.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelusernamesignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelusernamesignup.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernamesignup.Location = new System.Drawing.Point(21, 166);
            this.labelusernamesignup.Name = "labelusernamesignup";
            this.labelusernamesignup.Size = new System.Drawing.Size(100, 21);
            this.labelusernamesignup.TabIndex = 2;
            this.labelusernamesignup.Text = "User Name";
            // 
            // labelconfirm
            // 
            this.labelconfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelconfirm.AutoSize = true;
            this.guna2Transition1login.SetDecoration(this.labelconfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelconfirm.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconfirm.Location = new System.Drawing.Point(21, 403);
            this.labelconfirm.Name = "labelconfirm";
            this.labelconfirm.Size = new System.Drawing.Size(154, 21);
            this.labelconfirm.TabIndex = 3;
            this.labelconfirm.Text = "Confirm Password";
            // 
            // txtsignupusername
            // 
            this.txtsignupusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsignupusername.BorderColor = System.Drawing.Color.Transparent;
            this.txtsignupusername.BorderRadius = 10;
            this.txtsignupusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1login.SetDecoration(this.txtsignupusername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtsignupusername.DefaultText = "";
            this.txtsignupusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsignupusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsignupusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsignupusername.DisabledState.Parent = this.txtsignupusername;
            this.txtsignupusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsignupusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsignupusername.FocusedState.Parent = this.txtsignupusername;
            this.txtsignupusername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsignupusername.ForeColor = System.Drawing.Color.Black;
            this.txtsignupusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsignupusername.HoverState.Parent = this.txtsignupusername;
            this.txtsignupusername.Location = new System.Drawing.Point(25, 192);
            this.txtsignupusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsignupusername.Name = "txtsignupusername";
            this.txtsignupusername.PasswordChar = '\0';
            this.txtsignupusername.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtsignupusername.PlaceholderText = "";
            this.txtsignupusername.SelectedText = "";
            this.txtsignupusername.ShadowDecoration.Parent = this.txtsignupusername;
            this.txtsignupusername.Size = new System.Drawing.Size(396, 36);
            this.txtsignupusername.TabIndex = 4;
            this.txtsignupusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtconfirm.BorderColor = System.Drawing.Color.Transparent;
            this.txtconfirm.BorderRadius = 10;
            this.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1login.SetDecoration(this.txtconfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtconfirm.DefaultText = "";
            this.txtconfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirm.DisabledState.Parent = this.txtconfirm;
            this.txtconfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirm.FocusedState.Parent = this.txtconfirm;
            this.txtconfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.ForeColor = System.Drawing.Color.Black;
            this.txtconfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirm.HoverState.Parent = this.txtconfirm;
            this.txtconfirm.Location = new System.Drawing.Point(25, 429);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '\0';
            this.txtconfirm.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtconfirm.PlaceholderText = "";
            this.txtconfirm.SelectedText = "";
            this.txtconfirm.ShadowDecoration.Parent = this.txtconfirm;
            this.txtconfirm.Size = new System.Drawing.Size(396, 36);
            this.txtconfirm.TabIndex = 5;
            this.txtconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncreate
            // 
            this.btncreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncreate.BorderRadius = 19;
            this.btncreate.CheckedState.Parent = this.btncreate;
            this.btncreate.CustomImages.Parent = this.btncreate;
            this.guna2Transition1login.SetDecoration(this.btncreate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncreate.DisabledState.Parent = this.btncreate;
            this.btncreate.FillColor = System.Drawing.Color.Magenta;
            this.btncreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btncreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncreate.ForeColor = System.Drawing.Color.White;
            this.btncreate.HoverState.Parent = this.btncreate;
            this.btncreate.Location = new System.Drawing.Point(78, 514);
            this.btncreate.Name = "btncreate";
            this.btncreate.ShadowDecoration.Parent = this.btncreate;
            this.btncreate.Size = new System.Drawing.Size(295, 45);
            this.btncreate.TabIndex = 7;
            this.btncreate.Text = "CREATE USER";
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click_1);
            // 
            // guna2Transition1login
            // 
            this.guna2Transition1login.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1login.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1login.DefaultAnimation = animation1;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexit.BorderRadius = 19;
            this.btnexit.CheckedState.Parent = this.btnexit;
            this.btnexit.CustomImages.Parent = this.btnexit;
            this.guna2Transition1login.SetDecoration(this.btnexit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.DisabledState.Parent = this.btnexit;
            this.btnexit.FillColor = System.Drawing.Color.Red;
            this.btnexit.FillColor2 = System.Drawing.Color.Indigo;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.HoverState.Parent = this.btnexit;
            this.btnexit.Location = new System.Drawing.Point(308, 550);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Parent = this.btnexit;
            this.btnexit.Size = new System.Drawing.Size(125, 45);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 699);
            this.Controls.Add(this.panelforlogin);
            this.Controls.Add(this.panelsignup);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.max);
            this.Controls.Add(this.close);
            this.Controls.Add(this.paneltoplogin);
            this.Controls.Add(this.pictureBoxlogin);
            this.guna2Transition1login.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).EndInit();
            this.panelforlogin.ResumeLayout(false);
            this.panelforlogin.PerformLayout();
            this.panelsignup.ResumeLayout(false);
            this.panelsignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxlogin;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private System.Windows.Forms.Label labelforgetpassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnsignin;
        private Guna.UI2.WinForms.Guna2GradientButton btnsignup;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1login;
        private System.Windows.Forms.Panel paneltoplogin;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1login;
        private Guna.UI2.WinForms.Guna2ControlBox mini;
        private Guna.UI2.WinForms.Guna2ControlBox max;
        private Guna.UI2.WinForms.Guna2ControlBox close;
        private System.Windows.Forms.Panel panelforlogin;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1login;
        private System.Windows.Forms.Panel panelsignup;
        private System.Windows.Forms.Label labelemail;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.Label labelnewpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtnewpassword;
        private Guna.UI2.WinForms.Guna2GradientButton txtbacktologin;
        private System.Windows.Forms.Label labelsignup;
        private System.Windows.Forms.Label labelusernamesignup;
        private System.Windows.Forms.Label labelconfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtsignupusername;
        private Guna.UI2.WinForms.Guna2TextBox txtconfirm;
        private Guna.UI2.WinForms.Guna2GradientButton btncreate;
        private Guna.UI2.WinForms.Guna2GradientButton btnexit;
    }
}