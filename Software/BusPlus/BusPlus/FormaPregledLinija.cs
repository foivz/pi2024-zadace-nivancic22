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
            Hide();
            formaNovaLinija.ShowDialog();
            Close();
        }

        private void gumbIzmijeni_Click(object sender, EventArgs e)
        {
            FormaIzmijenaLinije formaIzmijena = new FormaIzmijenaLinije();
            Hide();
            formaIzmijena.ShowDialog();
            Close();
        }

       
        private void odjavaGumb_Click(object sender, EventArgs e)
        {
            Hide();
            FormaLogin formalogin = new FormaLogin();
            formalogin.ShowDialog();
            Close();
        }

        private void brisiGumb_Click(object sender, EventArgs e)
        {
            Hide();
            FormaBrisanje formabrisanje = new FormaBrisanje();
            formabrisanje.ShowDialog();
            Close();
        }

        private void dgvLinije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
