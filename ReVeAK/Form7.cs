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
    public partial class Form7 : Form
    {
        DataSet ds = new DataSet();
        private OleDbDataReader dataReader = null;
        private DBBK dbbk = new DBBK();

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

        private int artNr;
        public int ArtNr
        {
            get
            {
                return artNr;
            }
            set
            {
                ArtNr = value;
            }
        }

        private int rnr;
        public int Rnr
        {
            get
            {
                return rnr;
            }
            set
            {
                rnr = value;
            }
        }
        private double gesamtBetr;
        public double GesamtBetr
        {
            get
            {
                return gesamtBetr;
            }
            set
            {
                gesamtBetr = value;
            }
        }

        private bool istRechNeu;
        public bool IstRechNeu
        {
            get
            {
                return istRechNeu;
            }
            set
            {
                istRechNeu = !value;
            }
        }

        private int mwstNrAlt;
        public int MwstNrAlt
        {
            get
            {
                return mwstNrAlt;
            }
            set
            {
                mwstNrAlt = value;
            }
        }

        public Form7(int rnr)
        {
            this.Rnr = rnr;
            this.IstRechNeu = Convert.ToBoolean(rnr);
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (!istRechNeu)
            {
                //deaktivieren von Bearbeitungselementen
                button2.Visible = false;
                button1.Visible = false;
                groupBox4.Visible = false;

                //Füllen der Textboxen mit Informationen
                textBox2.Text = rnr+"";
                dataReader = dbbk.LesenSpezRechnung(rnr);
                dataReader.Read();
                textBox1.Text = dataReader.GetInt32(5)+"";
                textBox3.Text = dataReader.GetDateTime(1).ToString("dd.MM.yyyy") + "";
                textBox11.Text = dataReader.GetInt32(4)+"";
                Kdnr = dataReader.GetInt32(5);
                DateTime kdDat = dataReader.GetDateTime(6);
                MwstNrAlt = dataReader.GetInt32(7);
                dbbk.Schliessen();
                
                dataReader = dbbk.LesenSpezRechnung(rnr);
                dataReader.Read();
                checkBoxBezahlt.Checked = dataReader.GetBoolean(3);
                dbbk.Schliessen();

                //Artikelpositionen in DataSet/DataGridview laden
                ds = dbbk.LesenRechnungsPosition(rnr);
                for (int c = 0; c < ds.Tables[0].Rows.Count; c++)
                {
                    //Datatypes festelgen
                    int i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[c].Cells[0].ValueType = typeof(int);
                    dataGridView1.Rows[c].Cells[1].ValueType = typeof(string);
                    dataGridView1.Rows[c].Cells[2].ValueType = typeof(double);
                    dataGridView1.Rows[c].Cells[3].ValueType = typeof(int);
                    dataGridView1.Rows[c].Cells[4].ValueType = typeof(double);

                    //value inserten
                    dataGridView1.Rows[c].Cells[0].Value = ds.Tables[0].Rows[c][0];

                    //Artikel aus Datenbank für weitere Informationen abfragen;
                    dataReader = dbbk.LeseSpezArtikel(Convert.ToInt32(ds.Tables[0].Rows[c][0]), Convert.ToDateTime(ds.Tables[0].Rows[c][2]));
                    dataReader.Read();
                    
                    dataGridView1.Rows[c].Cells[1].Value = dataReader.GetString(2);
                    dataGridView1.Rows[c].Cells[2].Value = dataReader.GetDouble(4);
                    dataGridView1.Rows[c].Cells[3].Value = ds.Tables[0].Rows[c][3];
                    dataGridView1.Rows[c].Cells[4].Value = dataReader.GetDouble(4) * Convert.ToInt32(ds.Tables[0].Rows[c][3]);

                    dbbk.Schliessen();
                }

                //Frage Kundendaten ab und füge diese in Textboxen ein
                dataReader = dbbk.LeseSpezKunden(kdnr,kdDat);
                dataReader.Read();
                try
                {
                    label6.Text = dataReader.GetString(2);
                    label8.Text = dataReader.GetString(5);
                    label10.Text = dataReader.GetString(3);
                    label12.Text = dataReader.GetString(4);
                }
                finally
                {
                    dbbk.Schliessen();
                }

                BetragsBerechnung();
            }
            //Wenn es sich um eine neue Rechnung handelt
            else
            {
                textBox3.Text = DateTime.Today.Date.ToString("dd.MM.yyyy");
                dataReader = dbbk.LeseMaxRechNr();
                groupBoxMahnung.Visible = false;
                bezahlAktualButton.Visible = false;

                //Wenn keine Rechnung vorhanden ist, die Abfrage fehlschlägt setzte Rechnungsnummer auf 1
                dataReader.Read();
                try
                {
                    Rnr = (dataReader.GetInt32(0) + 1);
                }
                catch
                {
                    Rnr = 1;
                }
                textBox2.Text = rnr+"";
                dbbk.Schliessen();
                
            }
            checkBox1.Checked = dbbk.CheckOffeneRechnungen(kdnr);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3(true))
            {
                if(form3.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = form3.SelectKundenNr+"";
                    kdnr = form3.SelectKundenNr;
                    dataReader = dbbk.LeseSpezKunden(kdnr);
                    dataReader.Read();
                    try
                    {
                        label6.Text = dataReader.GetString(2);
                        label8.Text = dataReader.GetString(5);
                        label10.Text = dataReader.GetString(3);
                        label12.Text = dataReader.GetString(4);
                    }
                    finally
                    {
                        dbbk.Schliessen();
                        checkBox1.Checked = dbbk.CheckOffeneRechnungen(kdnr);
                    }
                }
                else
                {
                    kdnr = 0;
                }
            }


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(true))
            {
                if(form2.ShowDialog() == DialogResult.OK)
                {
                    textBox9.Text = form2.SelectedArt+"";
                    artNr = form2.SelectedArt;
                }
            }
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataReader = dbbk.LeseSpezArtikel(artNr);
            dataReader.Read();
            
            int menge;
            bool mengeBool=Int32.TryParse(textBox10.Text, out menge);
            


            if (mengeBool)
            {
                if (menge <= dataReader.GetInt32(3))
                {
                    //Datatypes festelgen
                    int i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[1].ValueType = typeof(string);
                    dataGridView1.Rows[i].Cells[2].ValueType = typeof(double);
                    dataGridView1.Rows[i].Cells[3].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[4].ValueType = typeof(double);

                    //value inserten
                    dataGridView1.Rows[i].Cells[0].Value = artNr;
                    dataGridView1.Rows[i].Cells[1].Value = dataReader.GetString(2);
                    dataGridView1.Rows[i].Cells[2].Value = dataReader.GetDouble(4);
                    dataGridView1.Rows[i].Cells[3].Value = menge;
                    dataGridView1.Rows[i].Cells[4].Value = dataReader.GetDouble(4) * menge;
                }
                else
                {
                    MessageBox.Show("Nicht genügend Artikel auf Lager!");
                }
            }
            else
            {
                MessageBox.Show("Bitte geben sie eine gültige Mengeanzahl an");
            }
            dbbk.Schliessen();
            BetragsBerechnung();

        }

        //Methode zur Berechnung des Rechnungsbetrages
        private void BetragsBerechnung()
        {
            if (istRechNeu)
            {
                dataReader = dbbk.LeseMwst();
            }
            else
            {
                dataReader = dbbk.LeseSpezMwst(mwstNrAlt);
            }
            
            dataReader.Read();
            textBox4.Text = dataReader.GetInt32(1) + "%";
            double mwst = dataReader.GetInt32(1) * 0.01;

            // Summe der Artikelpreise
            double artSumme = 0;
            
            for (int c = 0; c < dataGridView1.Rows.Count; c++)
            {

                artSumme += Convert.ToDouble(dataGridView1.Rows[c].Cells[4].Value.ToString());

            }
            dbbk.Schliessen();
            double lieferkosten;
            dataReader = dbbk.LeseVerwaltungsDaten();
            dataReader.Read();
            int rechnungsSchwelle = dataReader.GetInt32(2);
            dbbk.Schliessen();
            if (dbbk.CheckVipStatus(kdnr) || artSumme > rechnungsSchwelle)
            {
                lieferkosten = 0;
            }
            else
            {
                lieferkosten = 30;
            }
            textBox5.Text = artSumme + "€";
            double mwstBetrag = (mwst * artSumme);
            textBox6.Text = mwstBetrag + "€";
            if (istRechNeu)
            {
                textBox8.Text = lieferkosten + "";
                double nettoKosten = artSumme + lieferkosten + mwstBetrag;
                textBox7.Text = nettoKosten + "€";
                gesamtBetr = nettoKosten;
            }
            else
            {
                textBox8.Visible = false;
                label17.Visible = false;
                dataReader = dbbk.LesenSpezRechnung(rnr);
                dataReader.Read();
                textBox7.Text = dataReader.GetDouble(9)+"";
                dbbk.Schliessen();
            }
            
        }

        //Methode zur Rechnungserstellung
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataReader = dbbk.LeseSpezKunden(kdnr);
                dataReader.Read();
                DateTime kddat = dataReader.GetDateTime(1);
                dbbk.Schliessen();
                dataReader = dbbk.LeseMwst();
                dataReader.Read();
                int mwstnr = dataReader.GetInt32(0);
                dbbk.Schliessen();
                dataReader = dbbk.LeseVerwaltungsDaten();
                dataReader.Read();
                int vwnr = dataReader.GetInt32(0);
                dbbk.Schliessen();
                bool bezahlt = checkBoxBezahlt.Checked;
                try
                {
                    dbbk.ErstellenRechnung(rnr, bezahlt, kdnr, kddat, mwstnr, vwnr, gesamtBetr);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a + "");
                }
                for (int c = 0; c < dataGridView1.Rows.Count; c++)
                {

                    dbbk.ErstellenRechnungsPosition(Convert.ToInt32(dataGridView1.Rows[c].Cells[0].Value), rnr, Convert.ToInt32(dataGridView1.Rows[c].Cells[3].Value));
                    dbbk.AkualisiereBestand(Convert.ToInt32(dataGridView1.Rows[c].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[c].Cells[3].Value));
                }

                MessageBox.Show("Rechnung erfolgreich erstellt!");
            }
            catch
            {
                MessageBox.Show("Bitte wählen sie einen Kunden aus");
            }
    
            


        }

        private void bezahlAktualButton_Click(object sender, EventArgs e)
        {
            dbbk.AktualisierenBezahlung(rnr, checkBoxBezahlt.Checked);
        }
    }
}
