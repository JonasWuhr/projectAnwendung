namespace ReVeAK
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxBez = new System.Windows.Forms.TextBox();
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSuche = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBes = new System.Windows.Forms.TextBox();
            this.textBoxStkp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxNA = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStkpNeu = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBoxSel = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSuche.SuspendLayout();
            this.groupBoxNA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxBez
            // 
            this.textBoxBez.Location = new System.Drawing.Point(18, 43);
            this.textBoxBez.Name = "textBoxBez";
            this.textBoxBez.Size = new System.Drawing.Size(134, 20);
            this.textBoxBez.TabIndex = 1;
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.Location = new System.Drawing.Point(72, 22);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(47, 20);
            this.textBoxSuche.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artikelnr.:";
            // 
            // groupBoxSuche
            // 
            this.groupBoxSuche.Controls.Add(this.button1);
            this.groupBoxSuche.Controls.Add(this.label1);
            this.groupBoxSuche.Controls.Add(this.textBoxSuche);
            this.groupBoxSuche.Location = new System.Drawing.Point(601, 41);
            this.groupBoxSuche.Name = "groupBoxSuche";
            this.groupBoxSuche.Size = new System.Drawing.Size(152, 81);
            this.groupBoxSuche.TabIndex = 4;
            this.groupBoxSuche.TabStop = false;
            this.groupBoxSuche.Text = "Suche";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBes
            // 
            this.textBoxBes.Location = new System.Drawing.Point(158, 43);
            this.textBoxBes.Name = "textBoxBes";
            this.textBoxBes.Size = new System.Drawing.Size(100, 20);
            this.textBoxBes.TabIndex = 5;
            // 
            // textBoxStkp
            // 
            this.textBoxStkp.Location = new System.Drawing.Point(264, 43);
            this.textBoxStkp.Name = "textBoxStkp";
            this.textBoxStkp.Size = new System.Drawing.Size(100, 20);
            this.textBoxStkp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bezeichnung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bestand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stückpreis:";
            // 
            // groupBoxNA
            // 
            this.groupBoxNA.Controls.Add(this.button4);
            this.groupBoxNA.Controls.Add(this.textBoxStkp);
            this.groupBoxNA.Controls.Add(this.label4);
            this.groupBoxNA.Controls.Add(this.textBoxBez);
            this.groupBoxNA.Controls.Add(this.label3);
            this.groupBoxNA.Controls.Add(this.textBoxBes);
            this.groupBoxNA.Controls.Add(this.label2);
            this.groupBoxNA.Location = new System.Drawing.Point(50, 419);
            this.groupBoxNA.Name = "groupBoxNA";
            this.groupBoxNA.Size = new System.Drawing.Size(463, 87);
            this.groupBoxNA.TabIndex = 10;
            this.groupBoxNA.TabStop = false;
            this.groupBoxNA.Text = "Neuer Artikel";
            this.groupBoxNA.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(370, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Bestätigen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Artikelpreis ändern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Hinzufügen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxStkpNeu);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(601, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikelpreis";
            // 
            // textBoxStkpNeu
            // 
            this.textBoxStkpNeu.Location = new System.Drawing.Point(6, 19);
            this.textBoxStkpNeu.Name = "textBoxStkpNeu";
            this.textBoxStkpNeu.Size = new System.Drawing.Size(100, 20);
            this.textBoxStkpNeu.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(601, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Alles anzeigen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(7, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 46);
            this.button6.TabIndex = 15;
            this.button6.Text = "Artikel der Rechnung hinzufügen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBoxSel
            // 
            this.groupBoxSel.Controls.Add(this.button6);
            this.groupBoxSel.Location = new System.Drawing.Point(601, 332);
            this.groupBoxSel.Name = "groupBoxSel";
            this.groupBoxSel.Size = new System.Drawing.Size(152, 71);
            this.groupBoxSel.TabIndex = 16;
            this.groupBoxSel.TabStop = false;
            this.groupBoxSel.Text = "Artikelauswahl";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(601, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 79);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bestand";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Bestand Aktualisieren";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBoxNA);
            this.Controls.Add(this.groupBoxSuche);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Artikelverwaltung";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSuche.ResumeLayout(false);
            this.groupBoxSuche.PerformLayout();
            this.groupBoxNA.ResumeLayout(false);
            this.groupBoxNA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxBez;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSuche;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBes;
        private System.Windows.Forms.TextBox textBoxStkp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxNA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxStkpNeu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBoxSel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}