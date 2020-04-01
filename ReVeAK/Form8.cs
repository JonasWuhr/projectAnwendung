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
    public partial class Form8 : Form
    {
        DBBK dbbk = new DBBK();
        private DataSet ds = new DataSet();

        private int kdnr;
        public int Kdnr
        {
            get
            {
                return kdnr;
            }
            set
            {
                kdnr = value;
            }
        }

        public Form8()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3(true))
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    Kdnr = form3.SelectKundenNr;
                }
                else
                {
                    Kdnr = 0;
                }
            }
            ds = dbbk.LesenRechnung(kdnr);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "rechnung";

            VIPcheck.Checked = dbbk.CheckVipStatus(kdnr);

        }

        private void ReButton_Click(object sender, EventArgs e)
        {
            //Angeklickten Index auswerten
            int gridIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewCell cell = dataGridView1.Rows[gridIndex].Cells[0];
            //cellInt ist Index für Kundenänderung
            int cellInt = Convert.ToInt32(cell.Value);
            Form form7 = new Form7(cellInt);
            form7.Show();

        }
    }
}
