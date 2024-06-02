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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtKorime.Text;
            string password = txtLozinka.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(username == "zaposlenik" && password == "lozinka")
            {
                frmPregledLinija formalinije = new frmPregledLinija();
                Hide();
                formalinije.ShowDialog();
                Close();
            }
            else if (username == "korisnik" && password == "lozinka")
            {
                frmPrikazLinija formaPrikaz = new frmPrikazLinija();
                Hide();
                formaPrikaz.ShowDialog();
                Close();
                
            }
            else
            {
                MessageBox.Show("Uneseni su krivi podaci!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
