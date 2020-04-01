namespace ReVeAK
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNewRech = new System.Windows.Forms.Button();
            this.BtnShowRech = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBasisVerw = new System.Windows.Forms.Button();
            this.BtnMwstVerw = new System.Windows.Forms.Button();
            this.BtnKdVerw = new System.Windows.Forms.Button();
            this.BtnArtVerw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNewRech);
            this.groupBox1.Controls.Add(this.BtnShowRech);
            this.groupBox1.Location = new System.Drawing.Point(55, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechnungen";
            // 
            // BtnNewRech
            // 
            this.BtnNewRech.Location = new System.Drawing.Point(23, 19);
            this.BtnNewRech.Name = "BtnNewRech";
            this.BtnNewRech.Size = new System.Drawing.Size(97, 23);
            this.BtnNewRech.TabIndex = 1;
            this.BtnNewRech.Text = "Neue Rechnung";
            this.BtnNewRech.UseVisualStyleBackColor = true;
            this.BtnNewRech.Click += new System.EventHandler(this.BtnNewRech_Click);
            // 
            // BtnShowRech
            // 
            this.BtnShowRech.Location = new System.Drawing.Point(135, 19);
            this.BtnShowRech.Name = "BtnShowRech";
            this.BtnShowRech.Size = new System.Drawing.Size(127, 23);
            this.BtnShowRech.TabIndex = 0;
            this.BtnShowRech.Text = "Rechnungen anzeigen";
            this.BtnShowRech.UseVisualStyleBackColor = true;
            this.BtnShowRech.Click += new System.EventHandler(this.BtnShowRech_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBasisVerw);
            this.groupBox2.Controls.Add(this.BtnMwstVerw);
            this.groupBox2.Controls.Add(this.BtnKdVerw);
            this.groupBox2.Controls.Add(this.BtnArtVerw);
            this.groupBox2.Location = new System.Drawing.Point(103, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verwaltung";
            // 
            // BtnBasisVerw
            // 
            this.BtnBasisVerw.Location = new System.Drawing.Point(87, 48);
            this.BtnBasisVerw.Name = "BtnBasisVerw";
            this.BtnBasisVerw.Size = new System.Drawing.Size(107, 23);
            this.BtnBasisVerw.TabIndex = 3;
            this.BtnBasisVerw.Text = "Verwaltungsbasis";
            this.BtnBasisVerw.UseVisualStyleBackColor = true;
            this.BtnBasisVerw.Click += new System.EventHandler(this.BtnBasisVerw_Click);
            // 
            // BtnMwstVerw
            // 
            this.BtnMwstVerw.Location = new System.Drawing.Point(6, 48);
            this.BtnMwstVerw.Name = "BtnMwstVerw";
            this.BtnMwstVerw.Size = new System.Drawing.Size(75, 23);
            this.BtnMwstVerw.TabIndex = 2;
            this.BtnMwstVerw.Text = "Mwst";
            this.BtnMwstVerw.UseVisualStyleBackColor = true;
            this.BtnMwstVerw.Click += new System.EventHandler(this.BtnMwstVerw_Click);
            // 
            // BtnKdVerw
            // 
            this.BtnKdVerw.Location = new System.Drawing.Point(87, 19);
            this.BtnKdVerw.Name = "BtnKdVerw";
            this.BtnKdVerw.Size = new System.Drawing.Size(107, 23);
            this.BtnKdVerw.TabIndex = 1;
            this.BtnKdVerw.Text = "Kunden";
            this.BtnKdVerw.UseVisualStyleBackColor = true;
            this.BtnKdVerw.Click += new System.EventHandler(this.BtnKdVerw_Click);
            // 
            // BtnArtVerw
            // 
            this.BtnArtVerw.Location = new System.Drawing.Point(6, 19);
            this.BtnArtVerw.Name = "BtnArtVerw";
            this.BtnArtVerw.Size = new System.Drawing.Size(75, 23);
            this.BtnArtVerw.TabIndex = 0;
            this.BtnArtVerw.Text = "Artikel";
            this.BtnArtVerw.UseVisualStyleBackColor = true;
            this.BtnArtVerw.Click += new System.EventHandler(this.BtnArtVerw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 228);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rechnungsverwaltung - Hauptmenü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNewRech;
        private System.Windows.Forms.Button BtnShowRech;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBasisVerw;
        private System.Windows.Forms.Button BtnMwstVerw;
        private System.Windows.Forms.Button BtnKdVerw;
        private System.Windows.Forms.Button BtnArtVerw;
    }
}

