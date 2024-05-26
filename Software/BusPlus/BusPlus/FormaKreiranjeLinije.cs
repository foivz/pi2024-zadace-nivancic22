using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusPlus.Klase;
using BusPlus.Repozitorij;
using DBLayer;

namespace BusPlus
{
    public partial class FormaKreiranjeLinije : Form
    {
        public FormaKreiranjeLinije()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_gumb_Click(object sender, EventArgs e)
        {
            if(idLin.Text == "" || pocStan.Text == "" || zavrStan.Text == "" || brBus.Text == "" || pocVr.Text == "" || zavrVr.Text == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                LinijaRepozitorij.ubaciLiniju(int.Parse(idLin.Text), pocStan.Text, zavrStan.Text, int.Parse(brBus.Text), pocVr.Text, zavrVr.Text);
            }
        }
    }
}
