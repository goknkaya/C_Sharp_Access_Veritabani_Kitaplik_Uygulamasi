using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Proje_Kitaplik
{
    class AccessDB
    {
        public OleDbConnection connection()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\gokha\Documents\Access\Kitaplik.mdb");
            con.Open();
            return con;
        }
    }
}
