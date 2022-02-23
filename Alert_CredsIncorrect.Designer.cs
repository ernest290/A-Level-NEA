namespace A_Level_NEA
{
    partial class Alert_CredsIncorrect
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
            this.txtCredsIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCredsIncorrect
            // 
            this.txtCredsIncorrect.AutoSize = true;
            this.txtCredsIncorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtCredsIncorrect.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredsIncorrect.ForeColor = System.Drawing.Color.White;
            this.txtCredsIncorrect.Location = new System.Drawing.Point(50, 46);
            this.txtCredsIncorrect.Name = "txtCredsIncorrect";
            this.txtCredsIncorrect.Size = new System.Drawing.Size(198, 17);
            this.txtCredsIncorrect.TabIndex = 21;
            this.txtCredsIncorrect.Text = "Username or Password Incorrect!";
            // 
            // Alert_CredsIncorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.txtCredsIncorrect);
            this.Name = "Alert_CredsIncorrect";
            this.Text = "Alert_CredsIncorrect";
            this.Load += new System.EventHandler(this.Alert_CredsIncorrect_Load);
            this.Controls.SetChildIndex(this.txtCredsIncorrect, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCredsIncorrect;
    }
}