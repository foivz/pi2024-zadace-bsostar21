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
    public partial class FormaAzurirajStanicu : Form
    {
        private Stanica stanica = null;

        public FormaAzurirajStanicu(Stanica stanice)
        {
            InitializeComponent();

            stanica = stanice;

        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FormaAzurirajStanicu_Load(object sender, EventArgs e)
        {
            txtNazivStanice.Text = stanica.nazivStanice;
            txtAdresaStanice.Text = stanica.adresaStanice;


        }

        private void gumbAzurirajStanicu_Click(object sender, EventArgs e)
        {
            stanica.nazivStanice = txtNazivStanice.Text;
            stanica.adresaStanice = txtAdresaStanice.Text;

            StanicaRepozitorij.Update(stanica);
            this.Close() ;
        }
    }
}
