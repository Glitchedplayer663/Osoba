using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Osoba
{
    internal class Konekcija
    {
        static public SqlConnection Konektuj()
        {
            string s = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            SqlConnection konekcija = new SqlConnection(s);
            return konekcija;
        }
    }
}
