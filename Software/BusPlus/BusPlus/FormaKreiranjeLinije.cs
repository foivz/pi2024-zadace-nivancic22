using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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

       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string vrijemeFormat = @"^\d{2}:\d{2}:\d{2}$";
            Regex regex = new Regex(vrijemeFormat);
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            int id = int.Parse(IdLin.Text);
            Linija idLinije = linije.Find(linija => linija.ID_linije == id);
            if (IdLin.Text == "" || PocStan.Text == "" || ZavrStan.Text == "" || BrBus.Text == "" || PocVr.Text == "" || ZavrVr.Text == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            else if(idLinije == null)
            {
                if(regex.IsMatch(PocVr.Text) && regex.IsMatch(ZavrVr.Text)){
                    LinijaRepozitorij.UbaciLiniju(int.Parse(IdLin.Text), PocStan.Text, ZavrStan.Text, int.Parse(BrBus.Text), PocVr.Text, ZavrVr.Text);
                    Hide();
                    FormaPregledLinija formaPregled = new FormaPregledLinija();
                    formaPregled.ShowDialog();
                    Close(); 
                }
                else
                {
                    MessageBox.Show("Netočno upisano vrijeme", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Krivo je upisani ID!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            FormaPregledLinija formaPregledLinija = new FormaPregledLinija();
            formaPregledLinija.ShowDialog();
            Close();
        }

        private void ZavrVr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
