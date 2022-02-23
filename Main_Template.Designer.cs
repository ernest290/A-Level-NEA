namespace A_Level_NEA
{
    partial class Main_Template
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
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnMinimise = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btnExit.TabIndex = 6;
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
            this.btnMinimise.TabIndex = 5;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(880, 50);
            this.pnlTopBar.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Main_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::A_Level_NEA.Properties.Resources.Main_Background;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Template";
            this.Text = "Main_Template";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimise;
        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}