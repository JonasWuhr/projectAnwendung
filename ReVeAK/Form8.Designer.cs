namespace ReVeAK
{
    partial class Form8
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
            this.KundenButton = new System.Windows.Forms.Button();
            this.ReButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VIPcheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(467, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // KundenButton
            // 
            this.KundenButton.Location = new System.Drawing.Point(12, 12);
            this.KundenButton.Name = "KundenButton";
            this.KundenButton.Size = new System.Drawing.Size(117, 29);
            this.KundenButton.TabIndex = 1;
            this.KundenButton.Text = "Kunde auswählen";
            this.KundenButton.UseVisualStyleBackColor = true;
            this.KundenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReButton
            // 
            this.ReButton.Location = new System.Drawing.Point(12, 222);
            this.ReButton.Name = "ReButton";
            this.ReButton.Size = new System.Drawing.Size(244, 34);
            this.ReButton.TabIndex = 2;
            this.ReButton.Text = "Rechnung anzeigen";
            this.ReButton.UseVisualStyleBackColor = true;
            this.ReButton.Click += new System.EventHandler(this.ReButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "VIP-Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VIPcheck
            // 
            this.VIPcheck.AutoSize = true;
            this.VIPcheck.Enabled = false;
            this.VIPcheck.Location = new System.Drawing.Point(551, 47);
            this.VIPcheck.Name = "VIPcheck";
            this.VIPcheck.Size = new System.Drawing.Size(18, 17);
            this.VIPcheck.TabIndex = 4;
            this.VIPcheck.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 268);
            this.Controls.Add(this.VIPcheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReButton);
            this.Controls.Add(this.KundenButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Rechnung auswählen";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button KundenButton;
        private System.Windows.Forms.Button ReButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox VIPcheck;
    }
}