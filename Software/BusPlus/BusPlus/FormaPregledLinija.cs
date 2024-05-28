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
            PokaziLinije();
        }
        private void PokaziLinije()
        {
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = linije;
            dgvLinije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormaKreiranjeLinije formaNovaLinija = new FormaKreiranjeLinije();
            Hide();
            formaNovaLinija.ShowDialog();
            Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            FormaIzmijenaLinije formaIzmijena = new FormaIzmijenaLinije();
            Hide();
            formaIzmijena.ShowDialog();
            Close();
        }

       
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            FormaLogin formalogin = new FormaLogin();
            formalogin.ShowDialog();
            Close();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            Hide();
            FormaBrisanje formabrisanje = new FormaBrisanje();
            formabrisanje.ShowDialog();
            Close();
        }

        
    }
}
