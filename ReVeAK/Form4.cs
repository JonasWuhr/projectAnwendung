using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ReVeBK;

namespace ReVeAK
{
    public partial class Form4 : Form
    {

        
        DBBK dbbk = new DBBK();
        OleDbDataReader dataReader = null;
        private int cellIndex;
        public int CellIndex
        {
            get
            {
                return cellIndex;
            }
            set
            {
                this.cellIndex = value;   
            }
        }

        public Form4(int cellIndexAlt)
        {
            this.CellIndex = cellIndexAlt;
            InitializeComponent();
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            try
            {
                dbbk.AendereKunden(cellIndex, textBoxFirma.Text, textBoxName.Text, textBoxTel.Text, textBoxAdr.Text);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            dataReader = dbbk.LeseSpezKunden(cellIndex);
            dataReader.Read();
            textBoxKdNr.Text = dataReader.GetInt32(0) + "";
            labelZG.Text = ("Zuletzt geändert: " + dataReader.GetDateTime(1).ToString("dd.MM.yyyy"));
            textBoxFirma.Text = dataReader.GetString(2) + "";
            textBoxName.Text = dataReader.GetString(3);
            textBoxTel.Text = dataReader.GetString(4);
            textBoxAdr.Text = dataReader.GetString(5);
            dbbk.Schliessen();
            
            
        }
    }
}
