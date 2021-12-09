using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using szamlazo.kepernyok;

namespace szamlazo
{
    public partial class Fokepernyo : Form
    {
        public Fokepernyo()
        {
            InitializeComponent();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nevjegy ablak = new Nevjegy();
            ablak.ShowDialog();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
