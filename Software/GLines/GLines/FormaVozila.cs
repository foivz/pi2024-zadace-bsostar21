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
    public partial class FormaVozila : Form
    {
        public FormaVozila()
        {
            InitializeComponent();
        }

        private void gumbNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajVozilo_Click(object sender, EventArgs e)
        {
            FormaDodajVozilo formDodajVozilo = new FormaDodajVozilo();
            formDodajVozilo.ShowDialog();
        }

        private void gumbAzurirajVozilo_Click(object sender, EventArgs e)
        {
            FormaAzurirajVozilo formAzurirajVOzilo = new FormaAzurirajVozilo();
            formAzurirajVOzilo.ShowDialog();
        }
    }
}
