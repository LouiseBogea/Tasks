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
public static string connectionstring;
public static string GetConnectionString(){ return connectionstring;}
public static void SetString(string connectionStringfiledata)
{ connectionstring=connectionStringfiledata; 
}
} 
 }
