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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gumbPutnici_Click(object sender, EventArgs e)
        {
            FormaZaPutnike formaZaPutnike = new FormaZaPutnike();
            formaZaPutnike.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbZaposlenici_Click(object sender, EventArgs e)
        {
            FormaZaPrijavu formaZaPrijavu = new FormaZaPrijavu();
            formaZaPrijavu.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_bsostar21_DB", "PI2324_bsostar21_User", "3DeGe:j]");
        }
    }
}
