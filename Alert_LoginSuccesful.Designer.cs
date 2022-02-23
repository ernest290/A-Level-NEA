namespace A_Level_NEA
{
    partial class Alert_LoginSuccesful
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
            this.txtCredsCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCredsCorrect
            // 
            this.txtCredsCorrect.AutoSize = true;
            this.txtCredsCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtCredsCorrect.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredsCorrect.ForeColor = System.Drawing.Color.White;
            this.txtCredsCorrect.Location = new System.Drawing.Point(101, 45);
            this.txtCredsCorrect.Name = "txtCredsCorrect";
            this.txtCredsCorrect.Size = new System.Drawing.Size(100, 17);
            this.txtCredsCorrect.TabIndex = 22;
            this.txtCredsCorrect.Text = "Login Succesful!";
            // 
            // Alert_LoginSuccesful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.txtCredsCorrect);
            this.Name = "Alert_LoginSuccesful";
            this.Text = "Alert_LoginSuccesful";
            this.Load += new System.EventHandler(this.Alert_LoginSuccesful_Load);
            this.Controls.SetChildIndex(this.txtCredsCorrect, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCredsCorrect;
    }
}