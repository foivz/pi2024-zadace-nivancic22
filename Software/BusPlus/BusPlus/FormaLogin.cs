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
    public partial class FormaLogin : Form
    {
        public FormaLogin()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = KorimeTextbox.Text;
            string password = LozinkaTextbox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(username == "zaposlenik" && password == "lozinka")
            {
                FormaPregledLinija formalinije = new FormaPregledLinija();
                Hide();
                formalinije.ShowDialog();
                Close();
            }
            else if (username == "korisnik" && password == "lozinka")
            {
                
                FormaPrikazLinijaZaKorisnike formaPrikaz = new FormaPrikazLinijaZaKorisnike();
                Hide();
                formaPrikaz.ShowDialog();
                Close();
                
            }
            else
            {
                MessageBox.Show("Uneseni su krivi podaci!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void FormaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
