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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_gumb_Click(object sender, EventArgs e)
        {
            string vrijemeFormat = @"^\d{2}:\d{2}:\d{2}$";
            Regex regex = new Regex(vrijemeFormat);
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            int id = int.Parse(idLin.Text);
            Linija idLinije = linije.Find(linija => linija.ID_linije == id);
            if (idLin.Text == "" || pocStan.Text == "" || zavrStan.Text == "" || brBus.Text == "" || pocVr.Text == "" || zavrVr.Text == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            else if(idLinije == null)
            {
                if(regex.IsMatch(pocVr.Text) && regex.IsMatch(zavrVr.Text)){
                    LinijaRepozitorij.UbaciLiniju(int.Parse(idLin.Text), pocStan.Text, zavrStan.Text, int.Parse(brBus.Text), pocVr.Text, zavrVr.Text);
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
        }

        private void prikazLinija_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pocStan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void zavrStan_TextChanged(object sender, EventArgs e)
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

        private void zavrVr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void idLin_TextChanged(object sender, EventArgs e)
        {

        }

        private void povratakGumb_Click(object sender, EventArgs e)
        {
            Hide();
            FormaPregledLinija formaPregledLinija = new FormaPregledLinija();
            formaPregledLinija.ShowDialog();
            Close();
        }
    }
}
