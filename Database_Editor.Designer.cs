namespace A_Level_NEA
{
    partial class Database_Editor
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
            this.pnlUser = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDBEditor = new System.Windows.Forms.TextBox();
            this.pnlComponents = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtComponents = new System.Windows.Forms.TextBox();
            this.inpUserQuery = new Guna.UI2.WinForms.Guna2TextBox();
            this.inpComponentsQuery = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReturn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExecute1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExecute2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnOpenCon1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCloseCon1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCloseCon2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnOpenCon2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlUser.SuspendLayout();
            this.pnlComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlUser.Controls.Add(this.txtUser);
            this.pnlUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnlUser.Location = new System.Drawing.Point(175, 162);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnlUser.Size = new System.Drawing.Size(185, 53);
            this.pnlUser.TabIndex = 20;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUser.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Red;
            this.txtUser.Location = new System.Drawing.Point(16, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(115, 21);
            this.txtUser.TabIndex = 15;
            this.txtUser.Text = "User.db";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtDBEditor
            // 
            this.txtDBEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtDBEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDBEditor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDBEditor.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBEditor.ForeColor = System.Drawing.Color.Transparent;
            this.txtDBEditor.Location = new System.Drawing.Point(310, 77);
            this.txtDBEditor.Name = "txtDBEditor";
            this.txtDBEditor.ReadOnly = true;
            this.txtDBEditor.Size = new System.Drawing.Size(253, 44);
            this.txtDBEditor.TabIndex = 22;
            this.txtDBEditor.Text = "Database Editor";
            // 
            // pnlComponents
            // 
            this.pnlComponents.BackColor = System.Drawing.Color.Transparent;
            this.pnlComponents.Controls.Add(this.txtComponents);
            this.pnlComponents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnlComponents.Location = new System.Drawing.Point(175, 292);
            this.pnlComponents.Name = "pnlComponents";
            this.pnlComponents.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnlComponents.Size = new System.Drawing.Size(185, 53);
            this.pnlComponents.TabIndex = 22;
            // 
            // txtComponents
            // 
            this.txtComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtComponents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComponents.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtComponents.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponents.ForeColor = System.Drawing.Color.Red;
            this.txtComponents.Location = new System.Drawing.Point(16, 16);
            this.txtComponents.Name = "txtComponents";
            this.txtComponents.ReadOnly = true;
            this.txtComponents.Size = new System.Drawing.Size(115, 21);
            this.txtComponents.TabIndex = 15;
            this.txtComponents.Text = "Components.db";
            this.txtComponents.TextChanged += new System.EventHandler(this.txtComponents_TextChanged);
            // 
            // inpUserQuery
            // 
            this.inpUserQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpUserQuery.Animated = true;
            this.inpUserQuery.AutoRoundedCorners = true;
            this.inpUserQuery.BackColor = System.Drawing.Color.Transparent;
            this.inpUserQuery.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpUserQuery.BorderRadius = 25;
            this.inpUserQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpUserQuery.DefaultText = "";
            this.inpUserQuery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpUserQuery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpUserQuery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpUserQuery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpUserQuery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpUserQuery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpUserQuery.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpUserQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpUserQuery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpUserQuery.Location = new System.Drawing.Point(366, 162);
            this.inpUserQuery.Name = "inpUserQuery";
            this.inpUserQuery.PasswordChar = '\0';
            this.inpUserQuery.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inpUserQuery.PlaceholderText = "Enter SQL Query";
            this.inpUserQuery.SelectedText = "";
            this.inpUserQuery.Size = new System.Drawing.Size(337, 53);
            this.inpUserQuery.TabIndex = 23;
            this.inpUserQuery.TextChanged += new System.EventHandler(this.inpUserQuery_TextChanged);
            // 
            // inpComponentsQuery
            // 
            this.inpComponentsQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpComponentsQuery.Animated = true;
            this.inpComponentsQuery.AutoRoundedCorners = true;
            this.inpComponentsQuery.BackColor = System.Drawing.Color.Transparent;
            this.inpComponentsQuery.BorderColor = System.Drawing.Color.RoyalBlue;
            this.inpComponentsQuery.BorderRadius = 25;
            this.inpComponentsQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpComponentsQuery.DefaultText = "";
            this.inpComponentsQuery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inpComponentsQuery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inpComponentsQuery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpComponentsQuery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inpComponentsQuery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.inpComponentsQuery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inpComponentsQuery.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold);
            this.inpComponentsQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.inpComponentsQuery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.inpComponentsQuery.Location = new System.Drawing.Point(366, 292);
            this.inpComponentsQuery.Name = "inpComponentsQuery";
            this.inpComponentsQuery.PasswordChar = '\0';
            this.inpComponentsQuery.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inpComponentsQuery.PlaceholderText = "Enter SQL Query (Output queries not supported!)";
            this.inpComponentsQuery.SelectedText = "";
            this.inpComponentsQuery.Size = new System.Drawing.Size(337, 53);
            this.inpComponentsQuery.TabIndex = 24;
            // 
            // btnReturn
            // 
            this.btnReturn.Animated = true;
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BorderRadius = 19;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReturn.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnReturn.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IndicateFocus = true;
            this.btnReturn.Location = new System.Drawing.Point(355, 442);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 40);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExecute1
            // 
            this.btnExecute1.Animated = true;
            this.btnExecute1.AutoRoundedCorners = true;
            this.btnExecute1.BackColor = System.Drawing.Color.Transparent;
            this.btnExecute1.BorderRadius = 15;
            this.btnExecute1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExecute1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExecute1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExecute1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExecute1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExecute1.FillColor = System.Drawing.Color.SpringGreen;
            this.btnExecute1.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnExecute1.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExecute1.ForeColor = System.Drawing.Color.White;
            this.btnExecute1.IndicateFocus = true;
            this.btnExecute1.Location = new System.Drawing.Point(203, 226);
            this.btnExecute1.Name = "btnExecute1";
            this.btnExecute1.Size = new System.Drawing.Size(130, 33);
            this.btnExecute1.TabIndex = 26;
            this.btnExecute1.Text = "Execute";
            this.btnExecute1.Click += new System.EventHandler(this.btnExecute1_Click);
            // 
            // btnExecute2
            // 
            this.btnExecute2.Animated = true;
            this.btnExecute2.AutoRoundedCorners = true;
            this.btnExecute2.BackColor = System.Drawing.Color.Transparent;
            this.btnExecute2.BorderRadius = 15;
            this.btnExecute2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExecute2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExecute2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExecute2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExecute2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExecute2.FillColor = System.Drawing.Color.SpringGreen;
            this.btnExecute2.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnExecute2.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExecute2.ForeColor = System.Drawing.Color.White;
            this.btnExecute2.IndicateFocus = true;
            this.btnExecute2.Location = new System.Drawing.Point(203, 354);
            this.btnExecute2.Name = "btnExecute2";
            this.btnExecute2.Size = new System.Drawing.Size(130, 33);
            this.btnExecute2.TabIndex = 27;
            this.btnExecute2.Text = "Execute";
            this.btnExecute2.Click += new System.EventHandler(this.btnExecute2_Click);
            // 
            // btnOpenCon1
            // 
            this.btnOpenCon1.Animated = true;
            this.btnOpenCon1.AutoRoundedCorners = true;
            this.btnOpenCon1.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenCon1.BorderRadius = 15;
            this.btnOpenCon1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenCon1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenCon1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenCon1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenCon1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenCon1.FillColor = System.Drawing.Color.SpringGreen;
            this.btnOpenCon1.FillColor2 = System.Drawing.Color.Green;
            this.btnOpenCon1.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenCon1.ForeColor = System.Drawing.Color.White;
            this.btnOpenCon1.IndicateFocus = true;
            this.btnOpenCon1.Location = new System.Drawing.Point(366, 226);
            this.btnOpenCon1.Name = "btnOpenCon1";
            this.btnOpenCon1.Size = new System.Drawing.Size(162, 33);
            this.btnOpenCon1.TabIndex = 30;
            this.btnOpenCon1.Text = "Open Connection";
            this.btnOpenCon1.Click += new System.EventHandler(this.btnOpenCon1_Click);
            // 
            // btnCloseCon1
            // 
            this.btnCloseCon1.Animated = true;
            this.btnCloseCon1.AutoRoundedCorners = true;
            this.btnCloseCon1.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseCon1.BorderRadius = 15;
            this.btnCloseCon1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseCon1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseCon1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseCon1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseCon1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseCon1.FillColor = System.Drawing.Color.PaleVioletRed;
            this.btnCloseCon1.FillColor2 = System.Drawing.Color.Crimson;
            this.btnCloseCon1.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCloseCon1.ForeColor = System.Drawing.Color.White;
            this.btnCloseCon1.IndicateFocus = true;
            this.btnCloseCon1.Location = new System.Drawing.Point(542, 226);
            this.btnCloseCon1.Name = "btnCloseCon1";
            this.btnCloseCon1.Size = new System.Drawing.Size(161, 33);
            this.btnCloseCon1.TabIndex = 31;
            this.btnCloseCon1.Text = "Close Connection";
            this.btnCloseCon1.Click += new System.EventHandler(this.btnCloseCon1_Click);
            // 
            // btnCloseCon2
            // 
            this.btnCloseCon2.Animated = true;
            this.btnCloseCon2.AutoRoundedCorners = true;
            this.btnCloseCon2.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseCon2.BorderRadius = 15;
            this.btnCloseCon2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseCon2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseCon2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseCon2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseCon2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseCon2.FillColor = System.Drawing.Color.PaleVioletRed;
            this.btnCloseCon2.FillColor2 = System.Drawing.Color.Crimson;
            this.btnCloseCon2.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCloseCon2.ForeColor = System.Drawing.Color.White;
            this.btnCloseCon2.IndicateFocus = true;
            this.btnCloseCon2.Location = new System.Drawing.Point(542, 354);
            this.btnCloseCon2.Name = "btnCloseCon2";
            this.btnCloseCon2.Size = new System.Drawing.Size(161, 33);
            this.btnCloseCon2.TabIndex = 33;
            this.btnCloseCon2.Text = "Close Connection";
            this.btnCloseCon2.Click += new System.EventHandler(this.btnCloseCon2_Click);
            // 
            // btnOpenCon2
            // 
            this.btnOpenCon2.Animated = true;
            this.btnOpenCon2.AutoRoundedCorners = true;
            this.btnOpenCon2.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenCon2.BorderRadius = 15;
            this.btnOpenCon2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenCon2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenCon2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenCon2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenCon2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenCon2.FillColor = System.Drawing.Color.SpringGreen;
            this.btnOpenCon2.FillColor2 = System.Drawing.Color.Green;
            this.btnOpenCon2.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenCon2.ForeColor = System.Drawing.Color.White;
            this.btnOpenCon2.IndicateFocus = true;
            this.btnOpenCon2.Location = new System.Drawing.Point(366, 354);
            this.btnOpenCon2.Name = "btnOpenCon2";
            this.btnOpenCon2.Size = new System.Drawing.Size(162, 33);
            this.btnOpenCon2.TabIndex = 32;
            this.btnOpenCon2.Text = "Open Connection";
            this.btnOpenCon2.Click += new System.EventHandler(this.btnOpenCon2_Click);
            // 
            // Database_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.btnCloseCon2);
            this.Controls.Add(this.btnOpenCon2);
            this.Controls.Add(this.btnCloseCon1);
            this.Controls.Add(this.btnOpenCon1);
            this.Controls.Add(this.btnExecute2);
            this.Controls.Add(this.btnExecute1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.inpComponentsQuery);
            this.Controls.Add(this.inpUserQuery);
            this.Controls.Add(this.pnlComponents);
            this.Controls.Add(this.txtDBEditor);
            this.Controls.Add(this.pnlUser);
            this.Name = "Database_Editor";
            this.Text = "Database_Editor";
            this.Load += new System.EventHandler(this.Database_Editor_Load);
            this.Controls.SetChildIndex(this.pnlUser, 0);
            this.Controls.SetChildIndex(this.txtDBEditor, 0);
            this.Controls.SetChildIndex(this.pnlComponents, 0);
            this.Controls.SetChildIndex(this.inpUserQuery, 0);
            this.Controls.SetChildIndex(this.inpComponentsQuery, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.btnExecute1, 0);
            this.Controls.SetChildIndex(this.btnExecute2, 0);
            this.Controls.SetChildIndex(this.btnOpenCon1, 0);
            this.Controls.SetChildIndex(this.btnCloseCon1, 0);
            this.Controls.SetChildIndex(this.btnOpenCon2, 0);
            this.Controls.SetChildIndex(this.btnCloseCon2, 0);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlComponents.ResumeLayout(false);
            this.pnlComponents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDBEditor;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlComponents;
        private System.Windows.Forms.TextBox txtComponents;
        private Guna.UI2.WinForms.Guna2TextBox inpUserQuery;
        private Guna.UI2.WinForms.Guna2TextBox inpComponentsQuery;
        private Guna.UI2.WinForms.Guna2GradientButton btnReturn;
        private Guna.UI2.WinForms.Guna2GradientButton btnExecute1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExecute2;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenCon1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCloseCon1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCloseCon2;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenCon2;
    }
}