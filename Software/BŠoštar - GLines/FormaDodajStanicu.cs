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
    public partial class FormaDodajStanicu : Form
    {
        public FormaDodajStanicu()
        {
            InitializeComponent();
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajStanicu_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivStanice.Text;
            string adresa = txtAdresaStanice.Text;

            var stanica = new Stanica
            {
                nazivStanice = naziv,
                adresaStanice = adresa,
            };

            StanicaRepozitorij.Save(stanica);
            this.Close();
        }
    }
}
