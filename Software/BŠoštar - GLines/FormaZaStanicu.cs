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
        }

        private void gumbAzurirajStanicu_Click(object sender, EventArgs e)
        {
            FormaAzurirajStanicu formaAzurirajStanicu = new FormaAzurirajStanicu();
            formaAzurirajStanicu.ShowDialog();
        }

        private void FormaZaStanicu_Load(object sender, EventArgs e)
        {
            ShowStanice();
        }

        private void ShowStanice()
        {
            var stanice = StanicaRepozitorij.GetStanice();
            dgvStanice.DataSource = stanice;

            dgvStanice.Columns["IdStanica"].DisplayIndex = 0;
            dgvStanice.Columns["nazivStanica"].DisplayIndex = 1;
            dgvStanice.Columns["adresaStanica"].DisplayIndex = 2;
    

        }
    }
}
