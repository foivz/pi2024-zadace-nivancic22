using BusPlus.Klase;
using BusPlus.Repozitorij;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPlus
{
    public partial class FormaIzmijenaLinije : Form
    {
        public FormaIzmijenaLinije()
        {
            InitializeComponent();
        }

        private void izmijeniGumb_Click(object sender, EventArgs e)
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

                else if (idLinije != null)
                {
                    if (regex.IsMatch(pocVr.Text) && regex.IsMatch(zavrVr.Text))
                    {
                        LinijaRepozitorij.AzurirajLiniju(int.Parse(idLin.Text), pocStan.Text, zavrStan.Text, int.Parse(brBus.Text), pocVr.Text, zavrVr.Text);
                        Close();
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
    }
}
