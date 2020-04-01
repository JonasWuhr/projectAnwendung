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
    public partial class Form3 : Form
    {
        private string suchAttr;
        private Dictionary<string, string> kritDict = new Dictionary<string, string>();
        private DBBK dbbk = new DBBK();
        private DataSet ds = new DataSet();

        private int selectKundenNr = 7;

        public int SelectKundenNr
        {
            get
            {
                return selectKundenNr;
            }
            set
            {
                selectKundenNr = value;
            }
        }

        private bool kdSelection;

        public bool KdSelection
        {
            get
            {
                return kdSelection;
            }
            set
            {
                kdSelection = value;
            }
        }


        public Form3(bool selection)
        {
            KdSelection = selection;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Auswahl Button verstecken?
            if (KdSelection)
            {
                button4.Visible = true;
            }
                
            else
            {
                button4.Visible = false;
            }

            //datagridview
            ds = dbbk.LeseKunden();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kunden";

            //dictionaries und combobox 
            kritDict.Add("Kundennummer","KundenNr");
            kritDict.Add("Firmenname","KundenFirmenName");
            kritDict.Add("Kundenname","KundenAnspName");
            comboBoxKrit.Items.Add("Kundennummer");
            comboBoxKrit.Items.Add("Firmenname");
            comboBoxKrit.Items.Add("Kundenname");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            suchAttr = kritDict[Convert.ToString(comboBoxKrit.Text)];
        }

        private void BtnAnz_Click(object sender, EventArgs e)
        {
            //Überprüfe ob der String in eine Integer umgewandelt werden kann
            try
            {
                if (int.TryParse(textBoxSuche.Text, out int IntWert))
                {
                    ds = dbbk.LeseKunden(IntWert, suchAttr);
                }
                else
                {
                    ds = dbbk.LeseKunden(textBoxSuche.Text, suchAttr);
                }
                
                //dataGridView1.AutoResizeColumn(6);
            }
            catch
            {
                MessageBox.Show("Eingegebener Wert ungültig");
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBoxNeuerKd.Visible == false)
            {
                groupBoxNeuerKd.Visible = true;
            }
            else
            {
                groupBoxNeuerKd.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbbk.EinfuegenKunde(textBoxFirN.Text, textBoxName.Text, textBoxTel.Text, textBoxAdresse.Text);
            }
            catch(Exception a)
            {
                MessageBox.Show(a+"");
            }

            ds = dbbk.LeseKunden();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sämtlichekunden";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Angeklickten Index auswerten
            int gridIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewCell cell = dataGridView1.Rows[gridIndex].Cells[0];
            //cellInt ist Index für Kundenänderung
            int cellInt = Convert.ToInt32(cell.Value);

            
            Form form4 = new Form4(cellInt);
            form4.ShowDialog();
            ds = dbbk.LeseKunden();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Angeklickten Index auswerten
            int gridIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewCell cell = dataGridView1.Rows[gridIndex].Cells[0];
            //cellInt ist Index für Kundenänderung
            int cellInt = Convert.ToInt32(cell.Value);
            SelectKundenNr = cellInt;
            

        }
    }
}
