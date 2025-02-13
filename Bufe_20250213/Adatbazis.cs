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
        const string szerver = "server=linsql.verebely.dc;uid=diak57;password=HXPEFG,database=diak57";
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }
    
    

    }
}
