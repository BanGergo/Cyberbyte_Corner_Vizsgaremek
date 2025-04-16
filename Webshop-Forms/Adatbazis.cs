using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Webshop_db_modositas
{
    internal class Adatbazis
    {
        //const string szerver = "server=linsql.verebely.dc;uid=diak50;database=diak50;password=ZNVBTG";
        const string szerver = "datasource=127.0.0.1;username=root;database=webshop;password=";
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public Adatbazis(string sql)
        {
            kapcsolat = new MySqlConnection(szerver);
            kapcsolat.Open();
            parancs = new MySqlCommand(sql, kapcsolat);
            dr = parancs.ExecuteReader();
        }

        public void lezaras()
        {
            kapcsolat.Close();
        }

        ~Adatbazis()
        {
            kapcsolat.Close();
        }
    }
}
