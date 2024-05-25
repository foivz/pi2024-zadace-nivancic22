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
    public partial class FormaLinije : Form
    {
        public FormaLinije()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void FormaLinije_Load(object sender, EventArgs e)
        {
            ShowLinije();
        }
        private void ShowLinije()
        {
            List<Linija> linije = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = linije;
            dgvLinije.Columns["ID_linije"].DisplayIndex = 0;
            dgvLinije.Columns["PocetnaStanica"].DisplayIndex = 1;
            dgvLinije.Columns["ZavrsnaStanica"].DisplayIndex = 2;
            dgvLinije.Columns["BrojAutobusa"].DisplayIndex = 3;
            dgvLinije.Columns["PocetnoVrijeme"].DisplayIndex = 4;
            dgvLinije.Columns["ZavrsnoVrijeme"].DisplayIndex = 5;

        }

        private void FormaLinije_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pI2324_nivancic22_DBDataSet.AutobusneLinije' table. You can move, or remove it, as needed.
            this.autobusneLinijeTableAdapter.Fill(this.pI2324_nivancic22_DBDataSet.AutobusneLinije);

        }
    }
}
