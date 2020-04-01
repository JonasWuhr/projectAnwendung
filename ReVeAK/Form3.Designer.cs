namespace ReVeAK
{
    partial class Form3
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
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxKrit = new System.Windows.Forms.ComboBox();
            this.BtnAnz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxNeuerKd = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFirN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxNeuerKd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.Location = new System.Drawing.Point(24, 19);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(120, 20);
            this.textBoxSuche.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxKrit);
            this.groupBox1.Controls.Add(this.BtnAnz);
            this.groupBox1.Controls.Add(this.textBoxSuche);
            this.groupBox1.Location = new System.Drawing.Point(570, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden-Suche:";
            // 
            // comboBoxKrit
            // 
            this.comboBoxKrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKrit.FormattingEnabled = true;
            this.comboBoxKrit.Location = new System.Drawing.Point(24, 45);
            this.comboBoxKrit.Name = "comboBoxKrit";
            this.comboBoxKrit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKrit.TabIndex = 5;
            this.comboBoxKrit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnAnz
            // 
            this.BtnAnz.Location = new System.Drawing.Point(24, 72);
            this.BtnAnz.Name = "BtnAnz";
            this.BtnAnz.Size = new System.Drawing.Size(120, 23);
            this.BtnAnz.TabIndex = 2;
            this.BtnAnz.Text = "anzeigen";
            this.BtnAnz.UseVisualStyleBackColor = true;
            this.BtnAnz.Click += new System.EventHandler(this.BtnAnz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxNeuerKd
            // 
            this.groupBoxNeuerKd.Controls.Add(this.label4);
            this.groupBoxNeuerKd.Controls.Add(this.label3);
            this.groupBoxNeuerKd.Controls.Add(this.label2);
            this.groupBoxNeuerKd.Controls.Add(this.label1);
            this.groupBoxNeuerKd.Controls.Add(this.textBoxAdresse);
            this.groupBoxNeuerKd.Controls.Add(this.textBoxTel);
            this.groupBoxNeuerKd.Controls.Add(this.textBoxName);
            this.groupBoxNeuerKd.Controls.Add(this.textBoxFirN);
            this.groupBoxNeuerKd.Controls.Add(this.button2);
            this.groupBoxNeuerKd.Location = new System.Drawing.Point(21, 384);
            this.groupBoxNeuerKd.Name = "groupBoxNeuerKd";
            this.groupBoxNeuerKd.Size = new System.Drawing.Size(585, 100);
            this.groupBoxNeuerKd.TabIndex = 4;
            this.groupBoxNeuerKd.TabStop = false;
            this.groupBoxNeuerKd.Text = "Neuer Kunde:";
            this.groupBoxNeuerKd.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firma:";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(336, 50);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresse.TabIndex = 4;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(230, 49);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxFirN
            // 
            this.textBoxFirN.Location = new System.Drawing.Point(18, 50);
            this.textBoxFirN.Name = "textBoxFirN";
            this.textBoxFirN.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirN.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Bestätigen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kundendaten ändern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(570, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kunden auswählen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 494);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBoxNeuerKd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Kundenverwaltung";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxNeuerKd.ResumeLayout(false);
            this.groupBoxNeuerKd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAnz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxNeuerKd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFirN;
        private System.Windows.Forms.ComboBox comboBoxKrit;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}