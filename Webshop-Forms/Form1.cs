using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Webshop_db_modositas
{
    public partial class frmadatok : Form
    {
        string kereses_nev = "";
        string kereses_cikkszam = "";
        string kereses_gyarto = "";
        string kereses_kategoria = "";
        string cikkszam;
        void kerFeltoltes()
        {
            cbkereses_gyarto.Items.Clear();
            cbkereses_kategoria.Items.Clear();
            cbkereses_gyarto.Items.Add("Mind");
            cbkereses_kategoria.Items.Add("Mind");
            string gyarto_betoltes = "select gyarto_nev as gyarto from gyarto";
            Adatbazis ab = new Adatbazis(gyarto_betoltes);
            while (ab.Dr.Read())
            {
                cbkereses_gyarto.Items.Add(ab.Dr["gyarto"]);
            }
            ab.lezaras();
            string kategoria_betoltes = "select kat_nev as kategoria from kategoria";
            ab = new Adatbazis(kategoria_betoltes);
            while (ab.Dr.Read())
            {
                cbkereses_kategoria.Items.Add(ab.Dr["kategoria"]);
            }
            ab.lezaras();
        }
        public void Betoltes()
        {
            dgadatok.Rows.Clear();
            if (txcikkszam.TextLength != 0)
            {
                kereses_cikkszam = $" and termek.cikkszam like '%{txcikkszam.Text}%'";
            }
            else
            {
                kereses_cikkszam = "";
            }
            if (txkereses_nev.TextLength != 0)
            {
                kereses_nev = $" and termek.termek_nev like '%{txkereses_nev.Text}%' ";
            }
            else
            {
                kereses_nev = "";
            }
            if (cbkereses_gyarto.SelectedIndex != 0)
            {
                kereses_gyarto = $" and termek.gyarto_id = {cbkereses_gyarto.SelectedIndex} ";
            }
            else
            {
                kereses_gyarto = "";
            }
            if (cbkereses_kategoria.SelectedIndex != 0)
            {
                kereses_kategoria = $" and termek.kat_id = {cbkereses_kategoria.SelectedIndex} ";
            }
            else
            {
                kereses_kategoria = "";
            }

            string lekerdezes = "select termek.cikkszam, termek.termek_nev, termek.keszlet, termek.netto, termek.kedv, kategoria.kat_nev as kategoria, gyarto.gyarto_nev as gyarto, kategoria.kat_id as id from termek, kategoria, gyarto where termek.kat_id = kategoria.kat_id and termek.gyarto_id = gyarto.gyarto_id " + kereses_cikkszam +kereses_nev + kereses_gyarto + kereses_kategoria + " order by termek.termek_nev asc";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dgadatok.Rows.Add(ab.Dr["cikkszam"], ab.Dr["termek_nev"], ab.Dr["keszlet"], ab.Dr["netto"], ab.Dr["kedv"], ab.Dr["kategoria"], ab.Dr["gyarto"], ab.Dr["id"]);           
            }
            ab.lezaras();
        }
        public frmadatok()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;
        }

        private void frmadatok_Load(object sender, EventArgs e)
        {
            kerFeltoltes();
            cbkereses_gyarto.SelectedIndex = 0;
            cbkereses_kategoria.SelectedIndex = 0;
            Betoltes();

            txnev.Enabled = false;
            txar.Enabled = false;
            txkedvezmeny.Enabled = false;
            txkeszlet.Enabled = false;
            btnmod.Enabled = false;
            txurl.Enabled = false;
            dgtul.Enabled = false;
        }

        private void txkereses_nev_TextChanged(object sender, EventArgs e)
        {
            Betoltes();
            dgtul.Rows.Clear();
        }

        private void cbkereses_kategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Betoltes();
            dgtul.Rows.Clear();
        }

        private void cbkereses_gyarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Betoltes();
            dgtul.Rows.Clear();
        }

        private void txcikkszam_TextChanged(object sender, EventArgs e)
        {
            Betoltes();
            dgtul.Rows.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmadd add = new frmadd();
            add.ShowDialog();
            Close();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        List<string> katlista = new List<string>();
        List<int> tullistaszam = new List<int>();
        string ar = "";
        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgtul.Rows.Clear();
            ar = "";
            txnev.Enabled = true;
            txar.Enabled = true;
            txkedvezmeny.Enabled = true;
            txkeszlet.Enabled = true;
            btnmod.Enabled = true;
            txurl.Enabled = true;
            dgtul.Enabled = true;
            string szam = dgadatok.Rows[e.RowIndex].Cells["colCikkszam"].Value.ToString();
            int cikkszam = int.Parse(szam);
            this.cikkszam = $"{cikkszam}";
            string sszam = dgadatok.Rows[e.RowIndex].Cells["kat_id"].Value.ToString();
            int sorszam = int.Parse(sszam);
            txnev.Clear();
            txar.Clear();
            txkeszlet.Clear();
            txkedvezmeny.Clear();
            txurl.Clear();
            katlista.Clear();
            tullistaszam.Clear();
            string valasztott;
            if (sorszam == 1)
            {
                valasztott = "processzor";
                for (int i = 1; i < 13; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Típus", "Magok száma", "Szálak száma", "Processzor foglalat", "Processzor órajel", "Processzor Turbo órajel", "Gyártási technológia", "Integrált grafikai processzor", "L2 cache", "L3 cache", "TDP", "Rendszermemória" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 2)
            {
                valasztott = "videokartya";
                for (int i = 13; i < 35; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Csatolófelület", "Video chipset és termékcsalád", "Hűtés típusa", "Ventilátorok száma", "Grafikus chip sebessége", "Grafikus memória sebessége", "Memória mérete", "Memória típusa", "Memória sávszélesség", "Maximális felbontás", "DirectX", "OpenGL", "Tápcsatlakozó", "Ajánlott tápegység", "VGA", "DVI csatlakozók száma", "HDMI csatlakozók száma", "DisplayPort csatlakozók száma", "USB Type-C", "Szélesség", "Hosszúság", "Vastagság" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 3)
            {
                valasztott = "alaplap";
                for (int i = 35; i < 56; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "CPU foglalat", "Chipset", "Processzor gyártó", "Memória típusa", "Videokártya típusa", "HDMI", "DisplayPort", "Memória foglalatok száma", "SATA csatlakozók száma", "PCI - Express x16 csatlakozók száma", "PCI - Express x1 csatlakozók száma", "SATA 3 csatlakozók száma", "M.2 csatlakozók száma", "Hátlapi USB 2.0 portok száma", "Hátlapi USB 3.2 Gen 1 portok száma", "Hátlapi USB 3.2 Gen 2 portok száma", "Maximum memória mérete", "Integrált LAN sebessége", "RAID szintek", "Méret szabvány", "Alaplap mérete" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 4)
            {
                valasztott = "ram";
                for (int i = 56; i < 65; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = {"Kapacitás", "Kiszerelés", "Memória típusa", "Sebesség", "Többcsatornás kiszerelés", "Memóriakésleltetés", "Hűtőborda", "LED megvilágítás", "Feszültség" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 5)
            {
                valasztott = "ssd";
                for (int i = 65; i < 73; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Kialakítás", "M.2 méret", "Kapacitás", "NAND flash típusa", "Maximális SSD olvasási sebesség", "Maximális SSD írási sebesség", "Írástűrés", "Csatlakozók" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 6)
            {
                valasztott = "tap";
                for (int i = 73; i < 87; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Tápegység típusa", "Tápegység teljesítménye", "Hatásfok", "PFC", "Ventilátor mérete", "Maximum áramfelvéter + 3,3V", "Maximum áramfelvétel + 5V", "Maximum áramfelvétel + 12V", "Maximum áramfelvétel - 12V", "Tápkapcsoló", "FDD csatlakozó", "HDD csatlakozó", "SATA csatlakozó", "PCI - E csatlakozó" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 7)
            {
                valasztott = "gephaz";
                for (int i = 87; i < 99; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Típus", "2.5\" belső bővítőhely", "3.5\" belső bővítőhely", "Szélesség", "Magasság", "Mélység", "Tömeg", "Támogatott alaplaptípusok", "USB csatlakozók száma", "Audio az előlapon", "Átlátszó oldalfal", "Szín" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 8)
            {
                valasztott = "huto";
                for (int i = 99; i < 107; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Típus", "Ventilátor átmérője", "Ventilátor fordulatszáma", "Maximális zajszint", "Levegőáramlás", "LED megvilágítás", "Méretek", "Tömeg" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 9)
            {
                valasztott = "procihuto";
                for (int i = 107; i < 116; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Típus", "Ventilátor átmérője", "Ventilátor fordulatszáma", "Maximális zajszint", "Levegőáramlás", "LED megvilágítás", "Méretek", "Tömeg","Szín"};
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 10)
            {
                valasztott = "periferia";
                tullistaszam.Add(121);
                string[] kattomb = { "Leírás" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else if (sorszam == 11)
            {
                valasztott = "hdd";
                for (int i = 116; i < 121; i++)
                {
                    tullistaszam.Add(i);
                }
                string[] kattomb = { "Kapacitás", "Fordulatszám", "Cache mérete", "Maximális adatátviteli sebesség", "Csatlakozók" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }
            else
            {
                valasztott = "egyeb";
                tullistaszam.Add(122);
                string[] kattomb = { "Leírás" };
                for (int i = 0; i < kattomb.Length; i++)
                {
                    dgtul.Rows.Add(kattomb[i]);
                }
                katlista.AddRange(kattomb);
            }

            string lekerdezes = $"select termek_tul.tul_ertek as tul from termek_tul where termek_tul.cikkszam = {cikkszam}";
            Adatbazis ab = new Adatbazis(lekerdezes);
            int x = 0;
            while (ab.Dr.Read())
            {
                dgtul.Rows[x].Cells["adatok"].Value = ab.Dr["tul"];
                x++;
                if (x == katlista.Count)
                {
                    break;
                }
            }
            ab.lezaras();

            lekerdezes = $"select termek.termek_nev as nev, termek.keszlet as keszlet, termek.netto as netto, termek.kedv as kedv, image.url as url from termek,image where termek.cikkszam = {cikkszam} and image.cikkszam = {cikkszam}";
            ab = new Adatbazis(lekerdezes);
            ab.Dr.Read();
            txnev.Text = ab.Dr["nev"].ToString();
            txkeszlet.Text = ab.Dr["keszlet"].ToString();
            txar.Text = ab.Dr["netto"].ToString();
            ar = ab.Dr["netto"].ToString();
            txkedvezmeny.Text = ab.Dr["kedv"].ToString();
            txurl.Text = ab.Dr["url"].ToString();
            ab.lezaras();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("Nem adott meg nevet");
                txnev.Focus();
            }
            else if (txar.TextLength == 0)
            {
                MessageBox.Show("Nem adott meg árat");
                txar.Focus();
            }
            else
            {
                if (txkedvezmeny.TextLength == 0)
                {
                    txkedvezmeny.Text = "0";
                }
                if (txkeszlet.TextLength == 0)
                {
                    txkeszlet.Text = "10";
                }
                if (txurl.TextLength == 0)
                {
                    txurl.Text = "null";
                }
                DialogResult v = MessageBox.Show("Biztosan módosítani szeretné a terméket?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (v == DialogResult.Yes)
                {
                    string lekerdezes = $"UPDATE image SET image.url = '{txurl.Text}' WHERE image.cikkszam = {cikkszam};";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    ab.lezaras();

                    double netto = Convert.ToDouble(txar.Text) / 1.27;
                    int nettoar = (int)Math.Round(netto);
                    if (txar.Text == ar)
                    {
                        lekerdezes = $"UPDATE termek SET termek.termek_nev = '{txnev.Text}', termek.keszlet = {txkeszlet.Text}, termek.kedv = {txkedvezmeny.Text} WHERE termek.cikkszam = {cikkszam};";
                    }
                    else
                    {
                        lekerdezes = $"UPDATE termek SET termek.termek_nev = '{txnev.Text}', termek.keszlet = {txkeszlet.Text}, termek.netto = {nettoar}, termek.kedv = {txkedvezmeny.Text} WHERE termek.cikkszam = {cikkszam};";
                    }
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    ab.lezaras();

                    for (int i = 0; i < katlista.Count; i++)
                    {
                        if ( dgtul.Rows[i].Cells["adatok"].Value == null)
                        {
                            lekerdezes = $"UPDATE termek_tul SET tul_ertek = 'Nincs adat' WHERE cikkszam = {cikkszam} AND kat_tul_id = {tullistaszam[i]};";
                        }
                        else
                        {
                            lekerdezes = $"UPDATE termek_tul SET tul_ertek = '{dgtul.Rows[i].Cells["adatok"].Value}' WHERE cikkszam = {cikkszam} AND kat_tul_id = {tullistaszam[i]};";
                        }
                        ab = new Adatbazis(lekerdezes);
                        ab.Dr.Read();
                        ab.lezaras();
                    }

                    dgtul.Rows.Clear();
                    txnev.Clear();
                    txar.Clear();
                    txkeszlet.Clear();
                    txkedvezmeny.Clear();
                    txurl.Clear();
                    Betoltes();
                }
            }
        }

        private void txar_TextChanged(object sender, EventArgs e)
        {
            if (txar.TextLength != 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txar.Text);
                }
                catch
                {

                    MessageBox.Show("Csak számot adhat meg");
                    txar.Clear();
                    txar.Focus();
                }
            }
        }

        private void txkeszlet_TextChanged(object sender, EventArgs e)
        {
            if (txkeszlet.TextLength != 0)
            {
                try
                {
                    int szam = int.Parse(txkeszlet.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számot adhat meg");
                    txkeszlet.Clear();
                    txkeszlet.Focus();
                }
            }
        }

        private void txkedvezmeny_TextChanged(object sender, EventArgs e)
        {
            if (txkedvezmeny.TextLength != 0)
            {
                try
                {
                    int szam = int.Parse(txkedvezmeny.Text);
                }
                catch
                {

                    MessageBox.Show("Csak számot adhat meg");
                    txkedvezmeny.Clear();
                    txkedvezmeny.Focus();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txkereses_nev.Clear();
            Betoltes();
        }
    }
}
