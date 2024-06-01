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
    public partial class FormaAzurirajVozilo : Form
    {
        private Vozilo vozilo;

        public FormaAzurirajVozilo(Vozilo vozila)
        {
            InitializeComponent();

            vozilo = vozila;
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaAzurirajVozilo_Load(object sender, EventArgs e)
        {

            var voznired = VozniRedRepozitorij.GetVozneRedove();
            cmbVoziRed.DataSource = voznired;
            //cmbVoziRed.DisplayMember = "stanicaPolaska";
            cmbVoziRed.ValueMember = "IdVozniRed";


            txtOznakaVozilo.Text = vozilo.oznakaVozila;
            txtModelVozilo.Text = vozilo.modelVozila;
            textMarkaVozilo.Text = vozilo.markaVozila;
            textNazivVozilo.Text = vozilo.nazivVozila;
            txtBrojSjedala.Text = vozilo.brojSjedala.ToString();
            txtSlobodnaMjesta.Text = vozilo.brojSlobodnihMjesta.ToString();
            cmbVoziRed.Text = vozilo.IdVozniRed.ToString(); 
        }

        private void gumbAzurirajVozilo_Click(object sender, EventArgs e)
        {
            vozilo.oznakaVozila = txtOznakaVozilo.Text;
            vozilo.modelVozila = txtModelVozilo.Text;
            vozilo.markaVozila = textMarkaVozilo.Text;
            vozilo.nazivVozila = textNazivVozilo.Text;

            int sjedala;
            if(int.TryParse(txtBrojSjedala.Text, out sjedala))
            {
                vozilo.brojSjedala = sjedala;
            }
            int mjesta;
            if (int.TryParse(txtSlobodnaMjesta.Text, out mjesta))
            {
                vozilo.brojSlobodnihMjesta = mjesta;
            }

            int voznired;
            if(int.TryParse(cmbVoziRed.Text, out voznired))
            {
                vozilo.IdVozniRed = voznired;
            }

            VoziloRepozitorij.Update(vozilo);
            this.Close();
        }
    }
}
