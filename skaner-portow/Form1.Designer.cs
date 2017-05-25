namespace skaner_portow
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
            this.adres = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.ListBox();
            this.skanuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 15);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(183, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "Adres";
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(12, 41);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(818, 355);
            this.info.TabIndex = 1;
            // 
            // skanuj
            // 
            this.skanuj.Location = new System.Drawing.Point(377, 401);
            this.skanuj.Name = "skanuj";
            this.skanuj.Size = new System.Drawing.Size(58, 27);
            this.skanuj.TabIndex = 2;
            this.skanuj.Text = "Skanuj";
            this.skanuj.UseVisualStyleBackColor = true;
            this.skanuj.Click += new System.EventHandler(this.skanuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 440);
            this.Controls.Add(this.skanuj);
            this.Controls.Add(this.info);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.Button skanuj;
    }
}

