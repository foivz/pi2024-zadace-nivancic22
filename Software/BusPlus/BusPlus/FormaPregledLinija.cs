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
    public partial class frmPregledLinija : Form
    {
        public frmPregledLinija()
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
            dgvLinije.Columns["ID_linije"].DefaultCellStyle.ForeColor = Color.White;
            dgvLinije.Columns["ID_linije"].DefaultCellStyle.BackColor = Color.DarkRed;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmKreiranje formaNovaLinija = new frmKreiranje();
            Hide();
            formaNovaLinija.ShowDialog();
            Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmIzmijenaLinije formaIzmijena = new frmIzmijenaLinije();
            formaIzmijena.ShowDialog();
            Close();
        }

       
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin formalogin = new frmLogin();
            formalogin.ShowDialog();
            Close();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            Hide();
            frmBrisanje formabrisanje = new frmBrisanje();
            formabrisanje.ShowDialog();
            Close();
        }

        
    }
}
