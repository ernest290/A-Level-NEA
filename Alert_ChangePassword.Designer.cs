namespace A_Level_NEA
{
    partial class Alert_ChangePassword
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.inpOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.inpConfirmNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.inpNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // inpOldPass
            // 
            this.inpOldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpOldPass.Animated = true;
            this.inpOldPass.AutoRoundedCorners = true;
            this.inpOldPass.BackColor = System.Drawing.Color.Transparent;
            this.inpOldPass.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpOldPass.BorderRadius = 15;
            this.inpOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpOldPass.DefaultText = "";
            this.inpOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpOldPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpOldPass.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpOldPass.Location = new System.Drawing.Point(36, 18);
            this.inpOldPass.Name = "inpOldPass";
            this.inpOldPass.PasswordChar = '\0';
            this.inpOldPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inpOldPass.PlaceholderText = "Old Password";
            this.inpOldPass.SelectedText = "";
            this.inpOldPass.Size = new System.Drawing.Size(221, 32);
            this.inpOldPass.TabIndex = 1;
            this.inpOldPass.TextChanged += new System.EventHandler(this.inpOldPass_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderRadius = 15;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IndicateFocus = true;
            this.btnConfirm.Location = new System.Drawing.Point(36, 146);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(98, 32);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // inpConfirmNewPass
            // 
            this.inpConfirmNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpConfirmNewPass.Animated = true;
            this.inpConfirmNewPass.AutoRoundedCorners = true;
            this.inpConfirmNewPass.BackColor = System.Drawing.Color.Transparent;
            this.inpConfirmNewPass.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpConfirmNewPass.BorderRadius = 15;
            this.inpConfirmNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpConfirmNewPass.DefaultText = "";
            this.inpConfirmNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpConfirmNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpConfirmNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpConfirmNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpConfirmNewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpConfirmNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpConfirmNewPass.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpConfirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpConfirmNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpConfirmNewPass.Location = new System.Drawing.Point(36, 94);
            this.inpConfirmNewPass.Name = "inpConfirmNewPass";
            this.inpConfirmNewPass.PasswordChar = '\0';
            this.inpConfirmNewPass.PlaceholderText = "Confirm New Password";
            this.inpConfirmNewPass.SelectedText = "";
            this.inpConfirmNewPass.Size = new System.Drawing.Size(221, 32);
            this.inpConfirmNewPass.TabIndex = 3;
            this.inpConfirmNewPass.TextChanged += new System.EventHandler(this.inpConfirmNewPass_TextChanged);
            // 
            // inpNewPass
            // 
            this.inpNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpNewPass.Animated = true;
            this.inpNewPass.AutoRoundedCorners = true;
            this.inpNewPass.BackColor = System.Drawing.Color.Transparent;
            this.inpNewPass.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpNewPass.BorderRadius = 15;
            this.inpNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpNewPass.DefaultText = "";
            this.inpNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpNewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpNewPass.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpNewPass.Location = new System.Drawing.Point(36, 56);
            this.inpNewPass.Name = "inpNewPass";
            this.inpNewPass.PasswordChar = '\0';
            this.inpNewPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inpNewPass.PlaceholderText = "New Password";
            this.inpNewPass.SelectedText = "";
            this.inpNewPass.Size = new System.Drawing.Size(221, 32);
            this.inpNewPass.TabIndex = 2;
            this.inpNewPass.TextChanged += new System.EventHandler(this.inpNewPass_TextChanged);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Crimson;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.IndicateFocus = true;
            this.guna2GradientButton1.Location = new System.Drawing.Point(152, 146);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(105, 32);
            this.guna2GradientButton1.TabIndex = 5;
            this.guna2GradientButton1.Text = "Cancel";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // Alert_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::A_Level_NEA.Properties.Resources.Main_Background;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.inpNewPass);
            this.Controls.Add(this.inpOldPass);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.inpConfirmNewPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert_ChangePassword";
            this.Load += new System.EventHandler(this.Alert_ChangePassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox inpNewPass;
        private Guna.UI2.WinForms.Guna2TextBox inpOldPass;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox inpConfirmNewPass;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}