using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufe_20250213
{
    internal class Adatbazis
    {
        const string szerver = "server=localhost;uid=root;database=bufe;password=";
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }
    
    
        public Adatbazis(string sql)
        {
            kapcsolat = new MySqlConnection(szerver);
            kapcsolat.Open();
            parancs = new MySqlCommand(sql, kapcsolat);
            dr  = parancs.ExecuteReader();
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
