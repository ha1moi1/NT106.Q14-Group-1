using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Monopoly
{
    internal class Connection
    {

        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3_HK1-N2\NT106\Tuan3\moiiiii\NT106.Q14-Group-1-LightKer23\Exercise2.2\Exercise2.2.2\Database1.mdf;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
