using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLines
{
    public partial class FormaZaPrijavu : Form
    {
        public FormaZaPrijavu()
        {
            InitializeComponent();
        }

        string korisnickoIme = "zaposlenik";
        string lozinka = "glines123";

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if(txtKorIMe.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije uneseno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(txtKorIMe.Text == korisnickoIme && txtLozinka.Text == lozinka)
                {
                    

                    MessageBox.Show("Uspješna prijava!", "Dobrodošli",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormaZaZaposlenike frmZaposlenici = new FormaZaZaposlenike();
                    Hide();
                    frmZaposlenici.ShowDialog();
                    Close();


                }
                else
                {
                    MessageBox.Show("Nevaljani podaci!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
