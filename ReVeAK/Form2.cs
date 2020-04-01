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
    public partial class Form2 : Form
    {
        private DataSet ds = new DataSet();
        private DBBK dbbk = new DBBK();

        private bool artSelection = false;
        public bool ArtSelection
        {
            get
            {
                return artSelection;
            }
            set
            {
                artSelection = value;
            }
        }

        private int selectedArt;
        public int SelectedArt
        {
            get
            {
                return selectedArt;
            }
            set
            {
                selectedArt = value;
            }
        }

        public Form2(bool selection)
        {
            ArtSelection = selection;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (ArtSelection == true)
            {
                groupBoxSel.Visible = true;
            }
            else
            {
                groupBoxSel.Visible = false;
            }

            //Beim laden Artikelliste auffüllen, Datenquelle festlegen.
            ds.Clear();
            ds = dbbk.LeseArtikel(0);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sämtlicheartikel";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupBoxNA.Visible == false)
            {
                groupBoxNA.Visible = true;
            }
            else
            {
                groupBoxNA.Visible = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //deklaration
            int artBestand;
            double artStkp;
            DateTime artDate;
            string artBez;

            //Textboxen auswerten
            artBez = textBoxBez.Text;
            artBestand = Convert.ToInt32(textBoxBes.Text);
            artStkp = Convert.ToDouble(textBoxStkp.Text);

            //Übernehme Datum  -> heutiges Datum
            artDate = DateTime.Today.Date;
            
            //Artikel hinzufügen
            try
            {
                dbbk.EinfuegenArtikel(artDate, artBez, artBestand, artStkp);
            }
            catch (Exception a)
            {
                MessageBox.Show(Convert.ToString(a));
            }
            //Textboxen leeren
            textBoxBes.Clear();
            textBoxStkp.Clear();
            textBoxBez.Clear();
            dbbk.LeseArtikel(0);
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Angeklickten Index auswerten
            int gridIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewCell cell = dataGridView1.Rows[gridIndex].Cells[0];
            //cellInt ist Index für Artikelpreisänderung
            int cellInt = Convert.ToInt32(cell.Value);

            //Füge neuen Datensatz mit neuem Preis hinzu
            try
            {
                string test = dbbk.AendernArtikelPreis(cellInt, Convert.ToDouble(textBoxStkpNeu.Text));
                MessageBox.Show(test);
 
                dbbk.Schliessen();
                dbbk.LeseArtikel(0);
                dataGridView1.Update();
            }
            catch(Exception a)
            {
                MessageBox.Show(a+"");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {           
                int artIndex = Convert.ToInt32(textBoxSuche.Text);
                dbbk.LeseArtikel(artIndex);
                dataGridView1.Update();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Werteingabe");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbbk.LeseArtikel(0);
            dataGridView1.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Angeklickten Index auswerten
            int gridIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewCell cell = dataGridView1.Rows[gridIndex].Cells[0];
            //cellInt ist Index für Artikelpreisänderung
            int cellInt = Convert.ToInt32(cell.Value);
            SelectedArt = cellInt;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //Angeklickten Index auswerten
            int gridIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewCell cell = dataGridView1.Rows[gridIndex].Cells[0];
            //cellInt ist Index für Artikelpreisänderung
            int cellInt = Convert.ToInt32(cell.Value);
            SelectedArt = cellInt;
            try
            {
                dbbk.AktualisiereBestand(cellInt, Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Bestand erfolgreich aktualisiert");
            }
            catch
            {
                MessageBox.Show("Bitte geben sie einen gültigen Lagerbetrag ein");
            }
            
        }
    }
}
