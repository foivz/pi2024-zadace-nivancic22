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
            var linije = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = linije;
            dgvLinije.Columns["ID_linije"].DisplayIndex = 0;
        }
    }
}
