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
    public partial class frmPrikazLinija : Form
    {
        public frmPrikazLinija()
        {
            InitializeComponent();
        }

        private void FormaPrikazLinijaZaKorisnike_Load(object sender, EventArgs e)
        {
           PokaziLinije();
        }

        

        private void PokaziLinije()
        {
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = linije;
            dgvLinije.Columns["PocetnaStanica"].DefaultCellStyle.ForeColor = Color.Black;
            dgvLinije.Columns["PocetnaStanica"].DefaultCellStyle.BackColor = Color.White;
            dgvLinije.Columns["ZavrsnaStanica"].DefaultCellStyle.ForeColor = Color.Black;
            dgvLinije.Columns["ZavrsnaStanica"].DefaultCellStyle.BackColor = Color.White;
            dgvLinije.Columns["PocetnoVrijeme"].DefaultCellStyle.ForeColor = Color.Black;
            dgvLinije.Columns["PocetnoVrijeme"].DefaultCellStyle.BackColor = Color.White;
            dgvLinije.Columns["ZavrsnoVrijeme"].DefaultCellStyle.ForeColor = Color.Black;
            dgvLinije.Columns["ZavrsnoVrijeme"].DefaultCellStyle.BackColor = Color.White;
        }


        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmLogin formalogin = new frmLogin();
            Hide();
            formalogin.ShowDialog();
            Close();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            PrikaziTrazene();
        }
        private void PrikaziTrazene()
        {
            string stanica = txtTraziStan.Text;
            string vr = txtTraziVr.Text;
            List<Linija> linije = LinijaRepozitorij.TraziLiniju(stanica, vr);
            dgvLinije.DataSource = linije;
            if (stanica != "")
            {
                dgvLinije.Columns["PocetnaStanica"].DefaultCellStyle.ForeColor = Color.White;
                dgvLinije.Columns["PocetnaStanica"].DefaultCellStyle.BackColor = Color.DarkRed;
                dgvLinije.Columns["ZavrsnaStanica"].DefaultCellStyle.ForeColor = Color.White;
                dgvLinije.Columns["ZavrsnaStanica"].DefaultCellStyle.BackColor = Color.DarkRed;

            }
            if(vr != "")
            {
                dgvLinije.Columns["PocetnoVrijeme"].DefaultCellStyle.ForeColor = Color.White;
                dgvLinije.Columns["PocetnoVrijeme"].DefaultCellStyle.BackColor = Color.DarkRed;
                dgvLinije.Columns["ZavrsnoVrijeme"].DefaultCellStyle.ForeColor = Color.White;
                dgvLinije.Columns["ZavrsnoVrijeme"].DefaultCellStyle.BackColor = Color.DarkRed;

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PokaziLinije();
        }
    }
}
