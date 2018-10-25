using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jardoeira
{
    class DBSQLServerUtils
    {

        public static SqlConnection
        GetDBConnection()
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="Y:\MEOCloud\Pedro Magalhães\ProjetoJarodeira\Jardoeira\Jardoeira\Database\Jardoeira.mdf";Integrated Security=True
            string connString = @"Data Source=10.1.1.50,1433;
                          Initial Catalog = Jardoeira;
                          Persist Security Info = True;
                          User ID = pedro;
                          Password = teste123";


            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }



    }
}
