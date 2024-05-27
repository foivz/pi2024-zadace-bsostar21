using BŠoštar___GLines.Models;
using BŠoštar___GLines.Repozitoriji;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BŠoštar___GLines
{
    public partial class FormaZaStanicu : Form
    {
        public FormaZaStanicu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajStanicu_Click(object sender, EventArgs e)
        {
            FormaDodajStanicu formaDodajStanicu = new FormaDodajStanicu();
            formaDodajStanicu.ShowDialog();
            RefreshStanica();
        }

        private void gumbAzurirajStanicu_Click(object sender, EventArgs e)
        {
            Stanica oznacenaStanica = dgvStanice.CurrentRow.DataBoundItem as Stanica;
            FormaAzurirajStanicu formaAzurirajStanicu = new FormaAzurirajStanicu(oznacenaStanica);
            formaAzurirajStanicu.ShowDialog();
            RefreshStanica();
        }

        private void FormaZaStanicu_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_bsostar21_DB", "PI2324_bsostar21_User", "3DeGe:j]");
            ShowStanice();
        }

        private void ShowStanice()
        {
            var stanice = StanicaRepozitorij.GetStanice();
            dgvStanice.DataSource = stanice;

            dgvStanice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStanice.Columns["IdStanica"].DisplayIndex = 0;
            dgvStanice.Columns["nazivStanice"].DisplayIndex = 1;
            dgvStanice.Columns["adresaStanice"].DisplayIndex = 2;

            dgvStanice.Columns["IdStanica"].HeaderText = "ID Stanice";
            dgvStanice.Columns["nazivStanice"].HeaderText = "Naziv stanice";
            dgvStanice.Columns["adresaStanice"].HeaderText = "Adresa stanice";


        }

        private void RefreshStanica()
        {
            List<Stanica> listaStanica = StanicaRepozitorij.GetStanice();
            dgvStanice.DataSource = listaStanica;
        }

        private void gumbObrisiStanicu_Click(object sender, EventArgs e)
        {
            Stanica oznacenaStanica = dgvStanice.CurrentRow.DataBoundItem as Stanica;
            StanicaRepozitorij.Delete(oznacenaStanica);
            RefreshStanica();
        }

        private void txtPretrazivanjeStanice_TextChanged(object sender, EventArgs e)
        {
            string pretrazivanje = txtPretrazivanjeStanice.Text;
            List<Stanica> stanice = StanicaRepozitorij.GetStanicaByName(pretrazivanje);

            if (stanice.Any())
            {
                dgvStanice.DataSource = stanice;

                dgvStanice.Columns["IdStanica"].DisplayIndex = 0;
                dgvStanice.Columns["nazivStanice"].DisplayIndex = 1;
                dgvStanice.Columns["adresaStanice"].DisplayIndex = 2;

                dgvStanice.Columns["IdStanica"].HeaderText = "ID Stanice";
                dgvStanice.Columns["nazivStanice"].HeaderText = "Naziv stanice";
                dgvStanice.Columns["adresaStanice"].HeaderText = "Adresa stanice";
            }
            else
            {
                dgvStanice.DataSource = null;
               
            }
            
        }
    }
}
