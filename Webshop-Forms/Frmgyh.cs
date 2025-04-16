using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop_db_modositas
{
    public partial class Frmgyh : Form
    {
        public Frmgyh()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        List<string> gylista = new List<string>();
        void betoltes()
        {
            dggyarto.Rows.Clear();
            string lekerdezes = "select gyarto_nev as nev from gyarto";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dggyarto.Rows.Add(ab.Dr["nev"]);
                gylista.Add(ab.Dr["nev"].ToString());
            }
        }
        private void Frmgyh_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void btnujgyarto_Click(object sender, EventArgs e)
        {
            if (txgyarto.TextLength == 0)
            {
                DialogResult valasz = MessageBox.Show("Nem adta meg a gyártó nevét!","HIBA!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if (valasz == DialogResult.Cancel)
                {
                    Close();
                    frmadd ujadd = new frmadd();
                    ujadd.ShowDialog();
                }
                else
                {
                    txgyarto.Focus();
                }
            }
            else
            {
                bool vane = false;
                for (int i = 0; i < gylista.Count; i++)
                {
                    if (txgyarto.Text.ToUpper() == gylista[i].ToUpper())
                    {
                        vane = true;
                        i = gylista.Count;
                    }
                    else
                    {
                        vane = false;
                    }
                }

                if (vane == false)
                {
                    string lekerdezes = $"insert into gyarto (gyarto_nev) value ('{txgyarto.Text}');";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    ab.lezaras();
                    DialogResult valasz = MessageBox.Show($"Sikeresen hozzáadta a(z) {txgyarto.Text} nevű gyártót az adatbázishoz!", "Üzenet", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (valasz == DialogResult.Cancel)
                    {
                        Close();
                        frmadd ujadd = new frmadd();
                        ujadd.ShowDialog();
                    }
                    txgyarto.Clear();
                    betoltes();
                }
                else
                {
                    DialogResult valasz = MessageBox.Show("Ez a gyártó már létezik az adatbázisban!","HIBA!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    if (valasz == DialogResult.Cancel)
                    {
                        Close();
                        frmadd ujadd = new frmadd();
                        ujadd.ShowDialog();
                    }
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            frmadd ujadd = new frmadd();
            ujadd.ShowDialog();
        }
    }
}
