using BusPlus.Klase;
using BusPlus.Repozitorij;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPlus
{
    public partial class FormaPregledLinija : Form
    {
        public FormaPregledLinija()
        {
            InitializeComponent();
        }

        private void FormaPregledLinija_Load(object sender, EventArgs e)
        {
            pokaziLinije();
        }
        private void pokaziLinije()
        {
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = linije;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormaKreiranjeLinije formaNovaLinija = new FormaKreiranjeLinije();
            formaNovaLinija.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void zavrVr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void zavrStan_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void brBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void pocVr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pocStan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void odjavaGumb_Click(object sender, EventArgs e)
        {
            FormaLogin formalogin = new FormaLogin();
            Hide();
            formalogin.ShowDialog();
            Close();
        }
    }
}
