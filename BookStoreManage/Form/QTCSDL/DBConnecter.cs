using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QTCSDL
{
    class DBConnecter
    {
        public static SqlConnection sqlConnector() {
            SqlConnection myConnect = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            return myConnect;
        }
    }
}
