using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Data.SqlClient; 
using System.Data;
using UFPA.Common;
using UFPA.DAL;
namespace UFPA.DAL 
{

public class paintingDAL
 {
public int GetMaxPrimaryKey()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select Max(id) from tblpainting";
SqlCommand cmd=new SqlCommand(query,con);
string max=cmd.ExecuteScalar().ToString();
if(max=="" || max==null) max="0";
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return Convert.ToInt32(max);
}

public bool Insert(painting painting)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" insert into tblpainting(id,artistid)values("+painting.id+","+painting.artistid+")";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool InsertUpdate(painting painting)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select count(*) from tblpainting where id="+painting.id+"";
SqlCommand cmd=new SqlCommand(query,con);
int c=cmd.ExecuteScalar()==DBNull.Value?0:Convert.ToInt32(cmd.ExecuteScalar());
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return c==0?this.Insert(painting):this.Update(painting);
}
public bool Insert(List<painting> paintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand("",con);
foreach(painting painting in paintings){
string query=" insert into tblpainting(id,artistid)values("+painting.id+",painting.artistid)";
cmd.CommandText=query;
cmd.ExecuteNonQuery();
}
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool Update(painting painting)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" update  tblpainting set artistid="+painting.artistid+" where id="+painting.id+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool Delete(painting painting)
{
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from  tblpainting   where id="+painting.id+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool DeleteAll()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from tblpainting";  
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public painting GetpaintingInObjectUsingID(painting painting)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,artistid From tblpainting where id="+painting.id+"";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
while(reader.Read())
{
painting.id=Convert.ToInt32(reader["id"]);
painting.artistid=Convert.ToInt32(reader["artistid"]);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return painting;
}

public System.Data.DataTable  GetpaintingInDataTable()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select id,artistid From tblpainting";
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable painting=new System.Data.DataTable();
da.Fill(painting);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return painting;
}

public System.Data.DataTable  GetpaintingInDataTable(painting painting,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,artistid From tblpainting ";

switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+painting.id+"";
break;
case "artistid" : 
query+=" where artistid="+painting.artistid+"";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblpainting=new System.Data.DataTable();
da.Fill(tblpainting);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblpainting;
}

public System.Data.DataTable  GetActivepaintingInDataTable(painting painting,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,artistid From tblpainting ";

switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+painting.id+" and Is_Active='true' ";
break;
case "artistid" : 
query+=" where artistid="+painting.artistid+" and Is_Active='true' ";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblpainting=new System.Data.DataTable();
da.Fill(tblpainting);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblpainting;
}

public List<painting>  GetpaintingInList()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select id,artistid From tblpainting";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<painting> lstpainting=new List<painting>();
while(reader.Read())
{
painting painting=new painting();
painting.id=Convert.ToInt32(reader["id"]);
painting.artistid=Convert.ToInt32(reader["artistid"]);
lstpainting.Add(painting);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstpainting;}

public List<painting>  GetpaintingInList(painting painting,string MatchWith)
{ 
string query=" Select id,artistid From tblpainting ";switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+painting.id+"";
break;
case "artistid" : 
query+=" where artistid="+painting.artistid+"";
break;
}
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<painting> lstpainting=new List<painting>();
while(reader.Read())
{
painting=new painting();
painting.id=Convert.ToInt32(reader["id"]);
painting.artistid=Convert.ToInt32(reader["artistid"]);
lstpainting.Add(painting);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstpainting;}


}

}
