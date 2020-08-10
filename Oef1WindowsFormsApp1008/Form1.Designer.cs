namespace Oef1WindowsFormsApp1008
{
    partial class Form1
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
            this.lbLeeg = new System.Windows.Forms.ListBox();
            this.txtVoegToe = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLeeg
            // 
            this.lbLeeg.FormattingEnabled = true;
            this.lbLeeg.Location = new System.Drawing.Point(29, 26);
            this.lbLeeg.Name = "lbLeeg";
            this.lbLeeg.Size = new System.Drawing.Size(122, 238);
            this.lbLeeg.TabIndex = 0;
            // 
            // txtVoegToe
            // 
            this.txtVoegToe.Location = new System.Drawing.Point(29, 291);
            this.txtVoegToe.Name = "txtVoegToe";
            this.txtVoegToe.Size = new System.Drawing.Size(122, 20);
            this.txtVoegToe.TabIndex = 1;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(29, 332);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(122, 32);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Toevoegen!";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.txtVoegToe);
            this.Controls.Add(this.lbLeeg);
            this.Name = "Form1";
            this.Text = "Windows Form Oefening";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLeeg;
        private System.Windows.Forms.TextBox txtVoegToe;
        private System.Windows.Forms.Button btnVoegToe;
    }
}

