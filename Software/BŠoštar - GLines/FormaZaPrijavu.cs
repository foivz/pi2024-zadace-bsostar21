using BŠoštar___GLines.Models;
using BŠoštar___GLines.Repozitoriji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BŠoštar___GLines
{
    public partial class FormaZaPrijavu : Form
    {
        public static Zaposlenik prijavljeniZaposlenik {  get; set; }

        public FormaZaPrijavu()
        {
            InitializeComponent();
        }

        private void gumbPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Greška",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Greška", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                prijavljeniZaposlenik = ZaposlenikRepozitorij.GetZaposlenik(txtKorIme.Text);

                if (prijavljeniZaposlenik != null && prijavljeniZaposlenik.lozinka == txtLozinka.Text) 
                {
                    MessageBox.Show("Uspješna prijava!", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormaZaZaposlenike formaZaZaposlenike = new FormaZaZaposlenike();
                    Hide();
                    formaZaZaposlenike.ShowDialog();
                    Close();

                    
                }
                else
                {
                    MessageBox.Show("Neispravni podaci!", "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}
