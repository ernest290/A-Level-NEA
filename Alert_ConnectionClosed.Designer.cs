namespace A_Level_NEA
{
    partial class Alert_ConnectionClosed
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
            this.txtAccountCreatePrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.txtAccountCreatePrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountCreatePrompt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountCreatePrompt.Font = new System.Drawing.Font("Nunito", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountCreatePrompt.ForeColor = System.Drawing.Color.Transparent;
            this.txtAccountCreatePrompt.Location = new System.Drawing.Point(69, 38);
            this.txtAccountCreatePrompt.Name = "txtAccountCreatePrompt";
            this.txtAccountCreatePrompt.ReadOnly = true;
            this.txtAccountCreatePrompt.Size = new System.Drawing.Size(196, 17);
            this.txtAccountCreatePrompt.TabIndex = 21;
            this.txtAccountCreatePrompt.Text = "The connection is not open.";
            // 
            // Alert_ConnectionClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.txtAccountCreatePrompt);
            this.Name = "Alert_ConnectionClosed";
            this.Text = "Alert_ConnectionClosed";
            this.Load += new System.EventHandler(this.Alert_ConnectionClosed_Load);
            this.Controls.SetChildIndex(this.txtAccountCreatePrompt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountCreatePrompt;
    }
}