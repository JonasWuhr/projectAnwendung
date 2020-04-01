using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReVeBK;
using System.Data.OleDb;

namespace ReVeAK
{
    public partial class Form5 : Form
    {
        DBBK dbbk = new DBBK();
        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            OleDbDataReader dataReader = dbbk.LeseVerwaltungsDaten();
            dataReader.Read();

            textBox1.Text = Convert.ToString(dataReader.GetInt32(1));
            textBox2.Text = Convert.ToString(dataReader.GetInt32(2));
            textBox3.Text = Convert.ToString(dataReader.GetInt32(3));
            dbbk.Schliessen();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbbk.EinfuegenVerwaltungsDaten(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("Änderung Erfolgreich");
            }
            catch
            {
                MessageBox.Show("Fehler bei der Werteingabe");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
