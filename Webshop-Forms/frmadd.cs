using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Webshop_db_modositas
{
    public partial class frmadd : Form
    {
        string kereses_kategoria = "";
        void kerFeltoltes()
        {
            cbkategoria.Items.Clear();
            cbgyarto.Items.Clear();
            cbgyarto.Items.Add("Kérem válasszon!");
            cbkategoria.Items.Add("Kérem válasszon!");
            string kategoria_betoltes = "select kat_nev as kategoria from kategoria";
            Adatbazis ab = new Adatbazis(kategoria_betoltes);
            while (ab.Dr.Read())
            {
                cbkategoria.Items.Add(ab.Dr["kategoria"]);
            }
            ab.lezaras();
            string gyarto_betoltes = "select gyarto_nev as gyarto from gyarto";
            ab = new Adatbazis(gyarto_betoltes);
            while (ab.Dr.Read())
            {
                cbgyarto.Items.Add(ab.Dr["gyarto"]);
            }
            ab.lezaras();
        }
        public frmadd()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void frmadd_Load(object sender, EventArgs e)
        {
            kerFeltoltes();
            cbkategoria.SelectedIndex = 0;
            cbgyarto.SelectedIndex = 0;
        }
        List<string> katlista = new List<string>();
        List<int> tullistaszam = new List<int>();
        
        private void cbkategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dghozzaadas.Rows.Clear();
            katlista.Clear();
            tullistaszam.Clear();
            if (cbkategoria.SelectedIndex != 0)
            {
                string valasztott;
                if (cbkategoria.SelectedIndex == 1)
                {
                    valasztott = "processzor";
                    for (int i = 1; i < 13 ; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Típus", "Magok száma", "Szálak száma", "Processzor foglalat", "Processzor órajel", "Processzor Turbo órajel", "Gyártási technológia", "Integrált grafikai processzor", "L2 cache", "L3 cache", "TDP", "Rendszermemória" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if(cbkategoria.SelectedIndex == 2)
                {
                    valasztott = "videokartya";
                    for (int i = 13; i < 35 ; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Csatolófelület", "Video chipset és termékcsalád", "Hűtés típusa", "Ventilátorok száma", "Grafikus chip sebessége", "Grafikus memória sebessége", "Memória mérete", "Memória típusa", "Memória sávszélesség", "Maximális felbontás", "DirectX", "OpenGL", "Tápcsatlakozó", "Ajánlott tápegység", "VGA", "DVI csatlakozók száma", "HDMI csatlakozók száma", "DisplayPort csatlakozók száma", "USB Type-C", "Szélesség", "Hosszúság", "Vastagság" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 3)
                {
                    valasztott = "alaplap";
                    for (int i = 35; i < 56; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "CPU foglalat","Chipset", "Processzor gyártó", "Memória típusa", "Videokártya típusa", "HDMI", "DisplayPort", "Memória foglalatok száma", "SATA csatlakozók száma","PCI - Express x16 csatlakozók száma","PCI - Express x1 csatlakozók száma", "SATA 3 csatlakozók száma", "M.2 csatlakozók száma", "Hátlapi USB 2.0 portok száma", "Hátlapi USB 3.2 Gen 1 portok száma", "Hátlapi USB 3.2 Gen 2 portok száma", "Maximum memória mérete", "Integrált LAN sebessége", "RAID szintek", "Méret szabvány","Alaplap mérete" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 4)
                {
                    valasztott = "ram";
                    for (int i = 56; i < 65; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = {"Kapacitás", "Kiszerelés", "Memória típusa", "Sebesség", "Többcsatornás kiszerelés", "Memóriakésleltetés", "Hűtőborda", "LED megvilágítás", "Feszültség" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 5)
                {
                    valasztott = "ssd";
                    for (int i = 65; i < 73; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Kialakítás", "M.2 méret", "Kapacitás", "NAND flash típusa", "Maximális SSD olvasási sebesség", "Maximális SSD írási sebesség", "Írástűrés", "Csatlakozók" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 6)
                {
                    valasztott = "tap";
                    for (int i = 73; i < 87; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Tápegység típusa", "Tápegység teljesítménye", "Hatásfok", "PFC", "Ventilátor mérete",  "Maximum áramfelvéter + 3", "3V",  "Maximum áramfelvétel + 5V", "Maximum áramfelvétel + 12V", "Maximum áramfelvétel - 12V", "Tápkapcsoló", "FDD csatlakozó", "HDD csatlakozó", "SATA csatlakozó", "PCI - E csatlakozó" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 7)
                {
                    valasztott = "gephaz";
                    for (int i = 87; i < 99; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Típus", "2.5\" belső bővítőhely", "3.5\" belső bővítőhely", "Szélesség", "Magasság", "Mélység", "Tömeg", "Támogatott alaplaptípusok", "USB csatlakozók száma", "Audio az előlapon", "Átlátszó oldalfal", "Szín"  };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 8)
                {
                    valasztott = "huto";
                    for (int i = 99; i < 107; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Típus", "Ventilátor átmérője", "Ventilátor fordulatszáma", "Maximális zajszint", "Levegőáramlás", "LED megvilágítás", "Méretek", "Tömeg" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 9)
                {
                    valasztott = "procihuto";
                    for (int i = 107; i < 116; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Típus", "Ventilátor átmérője", "Ventilátor fordulatszáma", "Maximális zajszint", "Levegőáramlás", "LED megvilágítás", "Méretek", "Tömeg", "Szín" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 10)
                {
                    valasztott = "periferia";
                    tullistaszam.Add(121);
                    string[] kattomb = {"Leírás"};
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else if (cbkategoria.SelectedIndex == 11)
                {
                    valasztott = "hdd";
                    for (int i = 116; i < 121; i++)
                    {
                        tullistaszam.Add(i);
                    }

                    string[] kattomb = { "Kapacitás", "Fordulatszám", "Cache mérete", "Maximális adatátviteli sebesség", "Csatlakozók" };
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
                else
                {
                    valasztott = "egyeb";
                    tullistaszam.Add(122);
                    string[] kattomb = {"Leírás"};
                    for (int i = 0; i < kattomb.Length; i++)
                    {
                        dghozzaadas.Rows.Add(kattomb[i]);
                    }
                    katlista.AddRange(kattomb);
                }
            }
        }

        private void txcikkszam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txnev_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txar.TextLength != 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txar.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számot adhat meg árnak!","HIBA!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txar.Clear();
                }
            }
        }

        private void btnmentes_Click(object sender, EventArgs e)
        {
            int keszlet =  10;
            int kedv = 0;
            if (txkesz.TextLength != 0)
            {
                keszlet = int.Parse(txkesz.Text);
            }
            else
            {
                keszlet = 10;
            }
            if (txkedv.TextLength != 0)
            {
                kedv = int.Parse(txkedv.Text);
            }
            else
            {
                kedv = 0;
            }
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("Nem adott meg nevet!");
                txnev.Focus();
            }
            else if (txar.TextLength == 0)
            {
                MessageBox.Show("Nem adott meg árat!");
                txar.Focus();
            }
            else if (cbgyarto.SelectedIndex == 0)
            {
                MessageBox.Show("Kérem válasszon gyártót!");
            }
            else if (cbkategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Kérem válasszon kategóriát!");
            }
            else
            {
                string lekerdezes = "select max(termek.cikkszam) as lszam from termek";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                string cszam = ab.Dr["lszam"].ToString();
                ab.lezaras();
                int cikkszam = int.Parse(cszam) + 1;
                double netto = Convert.ToDouble(txar.Text) / 1.27;
                int nettoar = (int)Math.Round(netto);
                lekerdezes = $"insert into termek(`termek_nev`, `keszlet`, `netto`, `kedv`, `kat_id`, `gyarto_id`) value " +
                $"('{txnev.Text}',{keszlet},{nettoar},{kedv},{cbkategoria.SelectedIndex},{cbgyarto.SelectedIndex});";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                ab.lezaras();
                if (txurl.TextLength == 0)
                {
                    lekerdezes = $"insert into image (cikkszam, url) value ({cikkszam}, 'null')";
                }
                else
                {
                    lekerdezes = $"insert into image (cikkszam, url) value ({cikkszam}, '{txurl.Text}')";
                }
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                ab.lezaras();
                string[] tulajdonsagtomb = new string[katlista.Count];
                for (int i = 0; i < tulajdonsagtomb.Length; i++)
                {
                    if (dghozzaadas.Rows[i].Cells["adatok"].Value is null)
                    {
                        tulajdonsagtomb[i] = "Nincs adat";
                    }
                    else
                    {
                        tulajdonsagtomb[i] = dghozzaadas.Rows[i].Cells["adatok"].Value.ToString();
                    }
                }

                for (int i = 0; i < tulajdonsagtomb.Length; i++)
                {
                    lekerdezes = $"insert into termek_tul (kat_tul_id, cikkszam, tul_ertek) values ({tullistaszam[i]}, {cikkszam}, '{tulajdonsagtomb[i]}');";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    ab.lezaras();
                }

                MessageBox.Show("Sikeres mentés");
                txnev.Clear();
                txkedv.Clear();
                txar.Clear();
                txkesz.Clear();
                txurl.Clear();
                dghozzaadas.Rows.Clear();
                cbgyarto.SelectedIndex = 0;
                cbkategoria.SelectedIndex = 0;
            }
        }

        private void txkesz_TextChanged(object sender, EventArgs e)
        {
            if (txkesz.TextLength != 0)
            {
                try
                {
                    int szam = int.Parse(txkesz.Text);
                }
                catch
                {

                    MessageBox.Show("Csak számot adjon meg!");
                }
            }
        }

        private void txkedv_TextChanged(object sender, EventArgs e)
        {
            if (txkedv.TextLength != 0)
            {
                try
                {
                    int szam = int.Parse(txkedv.Text);
                }
                catch
                {

                    MessageBox.Show("Csak számot adjon meg!");
                }
            }
        }

        private void btngyhozzadas_Click(object sender, EventArgs e)
        {
            Close();
            Frmgyh ujgyarto = new Frmgyh();
            ujgyarto.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            frmadatok ujadatok = new frmadatok();
            ujadatok.ShowDialog();
        }
    }
}
