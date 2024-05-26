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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = korimeTextbox.Text;
            string password = lozinkaTextbox.Text;
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
