namespace A_Level_NEA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnMinimise = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtAccountCreatePrompt = new System.Windows.Forms.TextBox();
            this.txtLogIn = new System.Windows.Forms.TextBox();
            this.inpPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreateAccount = new System.Windows.Forms.Label();
            this.inpUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShowPasswordSmall = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(880, 50);
            this.pnlTopBar.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlTopBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(14, 14);
            this.btnExit.Image = global::A_Level_NEA.Properties.Resources.close_icon;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(16, 16);
            this.btnExit.Location = new System.Drawing.Point(836, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnMinimise.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimise.HoverState.ImageSize = new System.Drawing.Size(14, 14);
            this.btnMinimise.Image = global::A_Level_NEA.Properties.Resources.minimise_icon;
            this.btnMinimise.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimise.ImageRotate = 0F;
            this.btnMinimise.ImageSize = new System.Drawing.Size(16, 16);
            this.btnMinimise.Location = new System.Drawing.Point(810, 9);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnMinimise.Size = new System.Drawing.Size(32, 32);
            this.btnMinimise.TabIndex = 2;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // txtAccountCreatePrompt
            // 
            this.txtAccountCreatePrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtAccountCreatePrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountCreatePrompt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountCreatePrompt.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountCreatePrompt.ForeColor = System.Drawing.Color.Transparent;
            this.txtAccountCreatePrompt.Location = new System.Drawing.Point(336, 203);
            this.txtAccountCreatePrompt.Name = "txtAccountCreatePrompt";
            this.txtAccountCreatePrompt.ReadOnly = true;
            this.txtAccountCreatePrompt.Size = new System.Drawing.Size(196, 17);
            this.txtAccountCreatePrompt.TabIndex = 12;
            this.txtAccountCreatePrompt.Text = "If you don\'t have an account press";
            // 
            // txtLogIn
            // 
            this.txtLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLogIn.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.txtLogIn.Location = new System.Drawing.Point(335, 155);
            this.txtLogIn.Name = "txtLogIn";
            this.txtLogIn.ReadOnly = true;
            this.txtLogIn.Size = new System.Drawing.Size(115, 44);
            this.txtLogIn.TabIndex = 13;
            this.txtLogIn.Text = "Log in.";
            // 
            // inpPassword
            // 
            this.inpPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpPassword.Animated = true;
            this.inpPassword.AutoRoundedCorners = true;
            this.inpPassword.BackColor = System.Drawing.Color.Transparent;
            this.inpPassword.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpPassword.BorderRadius = 19;
            this.inpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpPassword.DefaultText = "";
            this.inpPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpPassword.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpPassword.Location = new System.Drawing.Point(335, 287);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.PasswordChar = '*';
            this.inpPassword.PlaceholderText = "Password";
            this.inpPassword.SelectedText = "";
            this.inpPassword.Size = new System.Drawing.Size(250, 40);
            this.inpPassword.TabIndex = 2;
            this.inpPassword.TextChanged += new System.EventHandler(this.inpPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IndicateFocus = true;
            this.btnLogin.Location = new System.Drawing.Point(385, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AutoSize = true;
            this.btnCreateAccount.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateAccount.Location = new System.Drawing.Point(527, 203);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(37, 17);
            this.btnCreateAccount.TabIndex = 20;
            this.btnCreateAccount.Text = "here.";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // inpUsername
            // 
            this.inpUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpUsername.Animated = true;
            this.inpUsername.AutoRoundedCorners = true;
            this.inpUsername.BackColor = System.Drawing.Color.Transparent;
            this.inpUsername.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpUsername.BorderRadius = 19;
            this.inpUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpUsername.DefaultText = "";
            this.inpUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpUsername.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpUsername.Location = new System.Drawing.Point(335, 231);
            this.inpUsername.Name = "inpUsername";
            this.inpUsername.PasswordChar = '\0';
            this.inpUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inpUsername.PlaceholderText = "Username";
            this.inpUsername.SelectedText = "";
            this.inpUsername.Size = new System.Drawing.Size(250, 40);
            this.inpUsername.TabIndex = 1;
            this.inpUsername.TextChanged += new System.EventHandler(this.inpUsername_TextChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton1.Image = global::A_Level_NEA.Properties.Resources.icons8_eye_16;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton1.Location = new System.Drawing.Point(547, 297);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton1.Size = new System.Drawing.Size(27, 21);
            this.guna2ImageButton1.TabIndex = 21;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            this.guna2ImageButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2ImageButton1_MouseDown);
            this.guna2ImageButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2ImageButton1_MouseUp);
            // 
            // btnShowPasswordSmall
            // 
            this.btnShowPasswordSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnShowPasswordSmall.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShowPasswordSmall.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnShowPasswordSmall.Image = global::A_Level_NEA.Properties.Resources.icons8_eye_14;
            this.btnShowPasswordSmall.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowPasswordSmall.ImageRotate = 0F;
            this.btnShowPasswordSmall.ImageSize = new System.Drawing.Size(14, 14);
            this.btnShowPasswordSmall.Location = new System.Drawing.Point(548, 296);
            this.btnShowPasswordSmall.Name = "btnShowPasswordSmall";
            this.btnShowPasswordSmall.PressedState.ImageSize = new System.Drawing.Size(14, 14);
            this.btnShowPasswordSmall.Size = new System.Drawing.Size(27, 21);
            this.btnShowPasswordSmall.TabIndex = 22;
            this.btnShowPasswordSmall.Click += new System.EventHandler(this.btnShowPasswordSmall_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.inpUsername);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.txtLogIn);
            this.Controls.Add(this.txtAccountCreatePrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.btnShowPasswordSmall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimise;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.TextBox txtAccountCreatePrompt;
        private System.Windows.Forms.TextBox txtLogIn;
        private Guna.UI2.WinForms.Guna2TextBox inpPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.Label btnCreateAccount;
        private Guna.UI2.WinForms.Guna2TextBox inpUsername;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPasswordSmall;
    }
}

