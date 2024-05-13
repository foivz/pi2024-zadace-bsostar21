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
    public partial class FormaLinija : Form
    {
        public FormaLinija()
        {
            InitializeComponent();
        }

        private void gumbNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajLiniju_Click(object sender, EventArgs e)
        {
            FormaDodajLiniju formDodajLiniju = new FormaDodajLiniju();
            formDodajLiniju.ShowDialog();
        }

        private void gumbAzurirajLiniju_Click(object sender, EventArgs e)
        {
            FormaAzurirajLiniju formAzurirajLiniju = new FormaAzurirajLiniju();
            formAzurirajLiniju.ShowDialog();
        }
    }
}
