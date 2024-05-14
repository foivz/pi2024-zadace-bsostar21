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
    public partial class FormaZaLiniju : Form
    {
        public FormaZaLiniju()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajLiniju_Click(object sender, EventArgs e)
        {
            FormaDodajLiniju formaDodajLiniju = new FormaDodajLiniju();
            formaDodajLiniju.ShowDialog();
        }

        private void gumbAzurirajLiniju_Click(object sender, EventArgs e)
        {
            FormaAzurirajLiniju formaAzurirajLiniju = new FormaAzurirajLiniju();
            formaAzurirajLiniju.ShowDialog();
        }
    }
}
