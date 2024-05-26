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

        private void gumbIzmijeni_Click(object sender, EventArgs e)
        {
            Close();
            FormaIzmijenaLinije formaIzmijena = new FormaIzmijenaLinije();
            formaIzmijena.ShowDialog();
            Close();
        }

       
        private void odjavaGumb_Click(object sender, EventArgs e)
        {
            FormaLogin formalogin = new FormaLogin();
            Hide();
            formalogin.ShowDialog();
            Close();
        }

        private void brisiGumb_Click(object sender, EventArgs e)
        {
            Close();
            FormaBrisanje formabrisanje = new FormaBrisanje();
            formabrisanje.ShowDialog();
            Close();
        }

        private void dgvLinije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
