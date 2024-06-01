using BŠoštar___GLines.Models;
using BŠoštar___GLines.Repozitoriji;
using DBLayer;
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
    public partial class FormaZaVozila : Form
    {
        public FormaZaVozila()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajVozilo_Click(object sender, EventArgs e)
        {

            FormaDodajVozilo formaDodajVozilo = new FormaDodajVozilo();
            formaDodajVozilo.ShowDialog();
            RefreshVozilo();
        }

        private void gumbAzurirajVozilo_Click(object sender, EventArgs e)
        {
            Vozilo oznacenoVozilo = dgvVozilo.CurrentRow.DataBoundItem as Vozilo;
            FormaAzurirajVozilo formaAzurirajVozilo = new FormaAzurirajVozilo(oznacenoVozilo);
            formaAzurirajVozilo.ShowDialog();
            RefreshVozilo();
        }

        private void FormaZaVozila_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_bsostar21_DB", "PI2324_bsostar21_User", "3DeGe:j]");
            ShowVozilo();
        }

        private void ShowVozilo()
        {
            var vozila = VoziloRepozitorij.GetVozila();
            dgvVozilo.DataSource = vozila;

            dgvVozilo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvVozilo.Columns["IdVozilo"].DisplayIndex = 0;
            dgvVozilo.Columns["oznakaVozila"].DisplayIndex = 1;
            dgvVozilo.Columns["modelVozila"].DisplayIndex = 2;
            dgvVozilo.Columns["markaVozila"].DisplayIndex = 3;
            dgvVozilo.Columns["nazivVozila"].DisplayIndex = 4;
            dgvVozilo.Columns["brojSjedala"].DisplayIndex = 5;
            dgvVozilo.Columns["brojSlobodnihMjesta"].DisplayIndex = 6;
            dgvVozilo.Columns["IdVozniRed"].DisplayIndex = 7;



            dgvVozilo.Columns["IdVozilo"].HeaderText = "ID Vozila";
            dgvVozilo.Columns["oznakaVozila"].HeaderText = "Oznaka";
            dgvVozilo.Columns["modelVozila"].HeaderText = "Model";
            dgvVozilo.Columns["markaVozila"].HeaderText = "Marka";
            dgvVozilo.Columns["nazivVozila"].HeaderText = "Naziv";
            dgvVozilo.Columns["brojSjedala"].HeaderText = "Broj sjedala";
            dgvVozilo.Columns["brojSlobodnihMjesta"].HeaderText = "Slobodna mjesta";
            dgvVozilo.Columns["IdVozniRed"].HeaderText = "Vozni Red";

        }



        private void gumbObrisiVozilo_Click(object sender, EventArgs e)
        {
            Vozilo oznacenoVozilo = dgvVozilo.CurrentRow.DataBoundItem as Vozilo;
            VoziloRepozitorij.Delete(oznacenoVozilo);
            RefreshVozilo();
        }

        private void RefreshVozilo()
        {
            List<Vozilo> listaVozila = VoziloRepozitorij.GetVozila();
            dgvVozilo.DataSource = listaVozila;
        }

        private void txtPretrazivanjeVozila_TextChanged(object sender, EventArgs e)
        {
            {
                string pretrazivanje = txtPretrazivanjeVozila.Text;
                List<Vozilo> vozila = VoziloRepozitorij.GetVoziloByOznaka(pretrazivanje);

                if (vozila.Any())
                {
                    dgvVozilo.DataSource = vozila;

                    dgvVozilo.Columns["IdVozilo"].DisplayIndex = 0;
                    dgvVozilo.Columns["oznakaVozila"].DisplayIndex = 1;
                    dgvVozilo.Columns["modelVozila"].DisplayIndex = 2;
                    dgvVozilo.Columns["markaVozila"].DisplayIndex = 3;
                    dgvVozilo.Columns["nazivVozila"].DisplayIndex = 4;
                    dgvVozilo.Columns["brojSjedala"].DisplayIndex = 5;
                    dgvVozilo.Columns["brojSlobodnihMjesta"].DisplayIndex = 6;
                    dgvVozilo.Columns["IdVozniRed"].DisplayIndex = 7;



                    dgvVozilo.Columns["IdVozilo"].HeaderText = "ID Vozila";
                    dgvVozilo.Columns["oznakaVozila"].HeaderText = "Oznaka";
                    dgvVozilo.Columns["modelVozila"].HeaderText = "Model";
                    dgvVozilo.Columns["markaVozila"].HeaderText = "Marka";
                    dgvVozilo.Columns["nazivVozila"].HeaderText = "Naziv";
                    dgvVozilo.Columns["brojSjedala"].HeaderText = "Broj sjedala";
                    dgvVozilo.Columns["brojSlobodnihMjesta"].HeaderText = "Slobodna mjesta";
                    dgvVozilo.Columns["IdVozniRed"].HeaderText = "Vozni Red";
                }
                else
                {
                    dgvVozilo.DataSource = null;

                }
            }
        }
    }
}