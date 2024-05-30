﻿using BusPlus.Klase;
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

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            int id = int.Parse(txtIdLin.Text);
            Linija idLinije = linije.Find(linija => linija.ID_linije == id);
            if (txtIdLin.Text == "" )
            {
                MessageBox.Show("Ispunite polje!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(idLinije != null)
            {
                LinijaRepozitorij.IzbrisiLiniju(int.Parse(txtIdLin.Text));
                Hide();
                FormaPregledLinija formapregled = new FormaPregledLinija();
                formapregled.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Ne možete izbrisati nešto što ne postoji!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            FormaPregledLinija formaPregledLinija = new FormaPregledLinija();
            formaPregledLinija.ShowDialog();
            Close();
        }

        
    }
}
