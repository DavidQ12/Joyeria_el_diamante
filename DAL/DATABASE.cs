using Joyeria_el_diamante.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_el_diamante.DAL
{
    public class DATABASE
    {
        
        public static string getStrConnection()
        {
            return Settings.Default.Joyeria_el_diamanteConnectionString;
        }
        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }
        public bool testConection()
        {
            SqlConnection Con = this.getConnection();
            Con.Open();
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

