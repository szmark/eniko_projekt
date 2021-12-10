using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamlazo.kepernyok
{
    public enum Tipus
    {
        KIMENO,
        BEJOVO,
        OSSZES
    }

    public partial class SzamlaLista : Form
    {
        private Tipus defaultTipusSelection;

        public SzamlaLista(Tipus tipus)
        {
            InitializeComponent();
            selectRightCb(tipus);
            defaultTipusSelection = tipus;

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellDoubleClick += cellDoubleClick;

            keres(tipus, null, null, null, null, null);

        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
            {
                if(cell.OwningColumn.Name == "id")
                {
                    new SzamlaHozzaad(cell.Value.ToString(), null, false).Show();
                }
            }      
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "tipus")
            {
                e.Value = e.Value.ToString().Equals("0") ? "Kimenő" : "Bejövő";
            } else if (dataGridView1.Columns[e.ColumnIndex].Name == "teljesitve")
            {
                if(!(dataGridView1.Rows[e.RowIndex].Cells[5].Value is System.DBNull))
                {
                    e.Value = "Igen";
                }
            }
        }
        /**
        private void TestGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridView1[YourColumnIndex, e.RowIndex].Value = YourEnumValue; // You can get your enum string value here.
        }
        */

        private void selectRightCb(Tipus tipus)
        {
            switch (tipus)
            {
                case Tipus.KIMENO:
                    rbTipKimeno.Checked = true;
                    break;
                case Tipus.BEJOVO:
                    rbTipBejovo.Checked = true;
                    break;
                case Tipus.OSSZES:
                    rbTipOsszes.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        async private void keres(Tipus tipus, DateTime? kezdet, DateTime? veg, bool? teljesitve, string cegnev, string cegId)
        {
            string query = "SELECT * FROM szamlak ";
            
            if (tipus == Tipus.KIMENO)
            {
                query += " WHERE tipus=0";
            }
            else if (tipus == Tipus.BEJOVO)
            {
                query += " WHERE tipus=1";
            }

            var cmd = Adatbazis.Instance.conn.CreateCommand();
            cmd.CommandText = query;
            DbDataReader data = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(data);
            dataGridView1.DataSource = dt;
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            Tipus tipus = Tipus.OSSZES;
            DateTime? kezdet = null;
            DateTime? veg = null;
            bool? teljesitve = null;
            string cegnev = null;
            string cegId = null;

            if (rbTipKimeno.Checked)
            {
                tipus = Tipus.KIMENO;
            } else if (rbTipBejovo.Checked)
            {
                tipus = Tipus.BEJOVO;
            }

            if(dtStart.Checked)
            {
                kezdet = dtStart.Value;
            }
            if(dtEnd.Checked)
            {
                veg = dtEnd.Value;
            }

            keres(tipus, kezdet, veg, teljesitve, cegnev, cegId);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectRightCb(defaultTipusSelection);
            dtStart.Checked = false;
            dtEnd.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(defaultTipusSelection == Tipus.KIMENO)
            {
                new SzamlaHozzaad(null, Tipus.KIMENO, true).Show();
            } else if (defaultTipusSelection == Tipus.BEJOVO)
            {
                new SzamlaHozzaad(null, Tipus.BEJOVO, true).Show();
            }
        }
    }
}
