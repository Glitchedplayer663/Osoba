using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoba
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void jednaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }
        private void Glavna_form_closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
