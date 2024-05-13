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
    public partial class FormaZaZaposlenike : Form
    {
        public FormaZaZaposlenike()
        {
            InitializeComponent();
        }

        private void gumbOdjava_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste odjavljeni", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void gumbVozilo_Click(object sender, EventArgs e)
        {
            FormaVozila formVozilo = new FormaVozila();
            formVozilo.ShowDialog();
        }

        private void gumbStanica_Click(object sender, EventArgs e)
        {

        }
    }
}
