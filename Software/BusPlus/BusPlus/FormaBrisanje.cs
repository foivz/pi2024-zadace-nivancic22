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
    public partial class FormaBrisanje : Form
    {
        public FormaBrisanje()
        {
            InitializeComponent();
        }

        private void BrisiGumb_Click(object sender, EventArgs e)
        {
            if (idLin.Text == "" )
            {
                MessageBox.Show("Ispunite polje!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                LinijaRepozitorij.IzbrisiLiniju(int.Parse(idLin.Text));
                Close();
                FormaPregledLinija formapregled = new FormaPregledLinija();
                formapregled.ShowDialog();
                Close();
            }
        }
    }
}
