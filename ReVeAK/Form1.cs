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

namespace ReVeAK
{
    public partial class Form1 : Form
    {
        DBBK dbbk = new DBBK();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnArtVerw_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(false);
            form2.Show();
        }

        private void BtnShowRech_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.Show();
        }

        private void BtnNewRech_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7(0);
            form7.Show();
        }

        private void BtnKdVerw_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3(false);
            form3.Show();
        }

        private void BtnMwstVerw_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show();
        }

        private void BtnBasisVerw_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dbbk.MahnPrüfung();
            }
            catch(Exception a)
            {
                MessageBox.Show(a+"");
            }
            
        }
    }
}
