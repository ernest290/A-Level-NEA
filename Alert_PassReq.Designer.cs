namespace A_Level_NEA
{
    partial class Alert_PassReq
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
            this.txtAccountCreatePrompt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAccountCreatePrompt
            // 
            this.txtAccountCreatePrompt.AcceptsReturn = true;
            this.txtAccountCreatePrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtAccountCreatePrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountCreatePrompt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountCreatePrompt.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountCreatePrompt.ForeColor = System.Drawing.Color.Transparent;
            this.txtAccountCreatePrompt.Location = new System.Drawing.Point(43, 12);
            this.txtAccountCreatePrompt.Multiline = true;
            this.txtAccountCreatePrompt.Name = "txtAccountCreatePrompt";
            this.txtAccountCreatePrompt.ReadOnly = true;
            this.txtAccountCreatePrompt.Size = new System.Drawing.Size(216, 54);
            this.txtAccountCreatePrompt.TabIndex = 21;
            this.txtAccountCreatePrompt.Text = "Notice: Password must be at least 7 characters long with at least one upper-case " +
    "letter and one number.";
            this.txtAccountCreatePrompt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Alert_PassReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.txtAccountCreatePrompt);
            this.Name = "Alert_PassReq";
            this.Text = "Alert_PassReq";
            this.Load += new System.EventHandler(this.Alert_PassReq_Load);
            this.Controls.SetChildIndex(this.txtAccountCreatePrompt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountCreatePrompt;
    }
}