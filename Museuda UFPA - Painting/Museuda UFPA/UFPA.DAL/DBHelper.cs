using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace UFPA.DAL
{

    public class DBHelper
    {
        public static string connectionstring = "workstation id=MUJAHID-PC;packet size=4096;user id=sa;password=sa123;data source=MUJAHID-PC;persist security info=false;initial catalog=MuseudaUFPA;";
public static string GetConnectionString() { return connectionstring; }
        public static void SetString(string connectionStringfiledata)
        {
            connectionstring = connectionStringfiledata;
        }
    }
}
