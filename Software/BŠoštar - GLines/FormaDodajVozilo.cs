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
    public partial class FormaDodajVozilo : Form
    {
        public FormaDodajVozilo()
        {
            InitializeComponent();
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajVozilo_Click(object sender, EventArgs e)
        {
            string oznaka = txtOznakaVozilo.Text;
            string model = txtModelVozilo.Text;
            string marka = textMarkaVozilo.Text;
            string naziv = textNazivVozilo.Text;
            int sjedala = int.Parse(txtBrojSjedala.Text);
            int mjesta = int.Parse(txtSlobodnaMjesta.Text);
            int linija = (int)cmbLinija.SelectedValue;
            int voznired = (int)cmbVoziRed.SelectedValue;



            var vozilo = new Vozilo
            {
                oznakaVozila = oznaka,
                modelVozila = model,
                markaVozila = marka,
                nazivVozila = naziv,
                brojSjedala = sjedala,
                brojSlobodnihMjesta = mjesta,
                IdLinija = linija,
                IdVozniRed = voznired,

            };

            VoziloRepozitorij.Save(vozilo);
            this.Close();

        }

        private void FormaDodajVozilo_Load(object sender, EventArgs e)
        {
            var linija = LinijaRepozitorij.GetLinije();
            cmbLinija.DataSource = linija;
            cmbLinija.DisplayMember = "nazivLinije";
            cmbLinija.ValueMember = "IdLinija";

            var voznired = VozniRedRepozitorij.GetVozneRedove();
            cmbVoziRed.DataSource = voznired;
            cmbVoziRed.DisplayMember = "stanicaPolaska";
            cmbVoziRed.ValueMember = "IdVozniRed";
        }
    }
}
