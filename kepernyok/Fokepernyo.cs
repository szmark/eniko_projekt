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
        private Form currentPanel = null;

        public Fokepernyo()
        {
            InitializeComponent();
            Adatbazis.init();
        }

        private void showPanel(Form panel)
        {
            if (currentPanel != null)
            {
                currentPanel.Close();
            }
            mainPanel.Controls.Clear();
            currentPanel = panel;
            currentPanel.TopLevel = false;
            mainPanel.Controls.Add(currentPanel);
            currentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            currentPanel.Show();
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

        private void összesListázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(new SzamlaLista(Tipus.OSSZES));
        }

        private void listázásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(new SzamlaLista(Tipus.KIMENO));
        }

        private void listázásToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel(new SzamlaLista(Tipus.BEJOVO));
        }
    }
}
