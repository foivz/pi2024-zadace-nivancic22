﻿using System;
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
    public partial class FormaPrikazLinijaZaKorisnike : Form
    {
        public FormaPrikazLinijaZaKorisnike()
        {
            InitializeComponent();
        }

        private void FormaPrikazLinijaZaKorisnike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pI2324_nivancic22_DBDataSet.AutobusneLinije' table. You can move, or remove it, as needed.
            this.autobusneLinijeTableAdapter.Fill(this.pI2324_nivancic22_DBDataSet.AutobusneLinije);

        }

        private void prikazLinija_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
