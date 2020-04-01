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
    public partial class Form6 : Form
    {
        DataSet ds = new DataSet();
        private DBBK dbbk = new DBBK();
        private OleDbDataReader dataReader = null;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataReader = dbbk.LeseMwst();
            dataReader.Read();
            textBox2.Text = dataReader.GetInt32(1) + "";
            dbbk.Schliessen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbbk.EinfuegenMwst(Convert.ToInt32(textBox2.Text));
        }
    }
}
