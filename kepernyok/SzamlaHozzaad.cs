using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamlazo.kepernyok
{
    public partial class SzamlaHozzaad : Form
    {
        private bool isNew = true;
        private string id;
        private Tipus tipus;
        public SzamlaHozzaad(string id, Tipus? tipus, bool edit)
        {
            InitializeComponent();
            initView(id, tipus, edit);
        }

        private void initView(string id, Tipus? tipus, bool edit)
        {
            if(id != null)
            {
                isNew = false;
                this.id = id;
                // get
                loadById(id);
                setEditable(edit == null ? false : edit);
            } else
            {
                this.tipus = (Tipus)tipus;
                if (this.tipus == Tipus.KIMENO)
                {
                    lblTitle.Text = "Kimenő számla";
                }
                else
                {
                    lblTitle.Text = "Bejövő számla";
                }
                if (!edit)
                {
                    throw new Exception("What?!?");
                }
            }
        }

        private void setEditable(bool editable)
        {
            if (!editable)
            {
                txtCegNev.Enabled = false;
                txtCegCim.Enabled = false;
                txtCegBankszamla.Enabled = false;
                txtOsszeg.Enabled = false;
                dpLetrehozva.Enabled = false;
                dpTeljesitve.Enabled = false;
                txtMegjegyzes.Enabled = false;

                btnMentes.Visible = false;
                btnReset.Visible = false;
                btnCancel.Visible = true;
                btnTeljesit.Visible = true;
                btnDelete.Visible = true;
                if(!isNew)
                {
                    btnModosit.Visible = true;
                }

            } else
            {
                txtCegNev.Enabled = true;
                txtCegCim.Enabled = true;
                txtCegBankszamla.Enabled = true;
                txtOsszeg.Enabled = true;
                dpLetrehozva.Enabled = true;
                dpTeljesitve.Enabled = true;
                txtMegjegyzes.Enabled = true;

                btnMentes.Visible = true;
                btnReset.Visible = true;
                btnCancel.Visible = true;
                btnTeljesit.Visible = false;
                btnDelete.Visible = false;
                if (!isNew)
                {
                    btnModosit.Visible = false;
                }
            }

        }

        private void loadById(string id)
        {
            string query = @"
                SELECT *, cegek.nev as cegNev, cegek.cim as cegCim FROM szamlak
                INNER JOIN cegek on cegek.id = szamlak.ceg_id
                Where szamlak.id=@id;
            ";
            SQLiteCommand command = (SQLiteCommand)Adatbazis.Instance.conn.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", id);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(reader["tipus"].ToString().Equals("1"))
                {
                    lblTitle.Text = "Bejövő számla";
                } else
                {
                    lblTitle.Text = "Kimenő számla";
                }

                txtCegCim.Text = reader["cegCim"].ToString();
                txtCegNev.Text = reader["cegNev"].ToString();
                txtOsszeg.Text = reader["osszeg"].ToString();
                txtMegjegyzes.Text = reader["megjegyzes"].ToString();
                dpLetrehozva.Value = (DateTime)reader["letrehozas_datuma"];
                Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)}");
                Console.WriteLine($"{reader.GetInt32(0)} {reader.GetInt32(1)}");
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            string query;
            if (id != null)
            {
                query = @"
                UPDATE szamlak 
                SET 
                    teljesites_datuma=@teljesites_datuma,
                    osszeg=@osszeg,
                    letrehozas_datuma=@letrehozas_datuma,
                    megjegyzes=@megjegyzes
                WHERE id=@id;
            ";
            } else
            {
                query = @"
                INSERT INTO szamlak (tipus, teljesites_datuma, osszeg, letrehozas_datuma, megjegyzes, ceg_id)
                VALUES
                    (@tipus, @teljesites_datuma, @osszeg, @letrehozas_datuma, @megjegyzes, @ceg_id);
            ";
            }

            SQLiteCommand command = (SQLiteCommand)Adatbazis.Instance.conn.CreateCommand();
            command.CommandText = query;

            DateTime? teljesitve = dpTeljesitve.Value;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@tipus", tipus == Tipus.BEJOVO ? 1 : 0);
            command.Parameters.AddWithValue("@teljesites_datuma", (dpTeljesitve.Checked ? teljesitve : null));
            command.Parameters.AddWithValue("@osszeg", txtOsszeg.Text);
            command.Parameters.AddWithValue("@letrehozas_datuma", dpLetrehozva.Value);
            command.Parameters.AddWithValue("@megjegyzes", txtMegjegyzes.Text);
            command.Parameters.AddWithValue("@ceg_id", 1);
            var reader = command.ExecuteNonQuery();
            if(isNew)
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnTeljesit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            setEditable(true);
        }
    }
}
