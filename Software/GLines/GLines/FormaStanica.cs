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
    public partial class FormaStanica : Form
    {
        public FormaStanica()
        {
            InitializeComponent();
        }

        private void gumbNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajStanicu_Click(object sender, EventArgs e)
        {
            FormaDodajStanicu formDodajStanicu = new FormaDodajStanicu();
            formDodajStanicu.ShowDialog();
        }

        private void gumbAzurirajStanicu_Click(object sender, EventArgs e)
        {
            FormaAzurirajStanicu formAzurirajStanicu = new FormaAzurirajStanicu();
            formAzurirajStanicu.ShowDialog();
        }
    }
}
