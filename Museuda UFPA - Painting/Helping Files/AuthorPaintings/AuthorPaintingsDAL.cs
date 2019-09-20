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

public class AuthorPaintingsDAL
 {
public int GetMaxPrimaryKey()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select Max(paintingid) from tblAuthorPaintings";
SqlCommand cmd=new SqlCommand(query,con);
string max=cmd.ExecuteScalar().ToString();
if(max=="" || max==null) max="0";
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return Convert.ToInt32(max);
}

public bool Insert(AuthorPaintings authorpaintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" insert into tblAuthorPaintings(paintingid,authorid)values("+authorpaintings.PaintingID+","+authorpaintings.AuthorID+")";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool InsertUpdate(AuthorPaintings authorpaintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select count(*) from tblAuthorPaintings where paintingid="+authorpaintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
int c=cmd.ExecuteScalar()==DBNull.Value?0:Convert.ToInt32(cmd.ExecuteScalar());
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return c==0?this.Insert(authorpaintings):this.Update(authorpaintings);
}
public bool Insert(List<AuthorPaintings> authorpaintingss)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand("",con);
foreach(AuthorPaintings authorpaintings in authorpaintingss){
string query=" insert into tblAuthorPaintings(paintingid,authorid)values("+authorpaintings.PaintingID+",authorpaintings.AuthorID)";
cmd.CommandText=query;
cmd.ExecuteNonQuery();
}
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool Update(AuthorPaintings authorpaintings)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" update  tblAuthorPaintings set authorid="+authorpaintings.AuthorID+" where paintingid="+authorpaintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool Delete(AuthorPaintings authorpaintings)
{
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from  tblauthorpaintings   where paintingid="+authorpaintings.PaintingID+"";
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
string query=" delete from tblauthorpaintings";  
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public AuthorPaintings GetAuthorPaintingsInObjectUsingID(AuthorPaintings authorpaintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingid,authorid From tblauthorpaintings where paintingid="+authorpaintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
while(reader.Read())
{
authorpaintings.PaintingID=Convert.ToInt32(reader["paintingid"]);
authorpaintings.AuthorID=Convert.ToInt32(reader["authorid"]);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return authorpaintings;
}

public System.Data.DataTable  GetAuthorPaintingsInDataTable()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select paintingid,authorid From tblauthorpaintings";
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable authorpaintings=new System.Data.DataTable();
da.Fill(authorpaintings);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return authorpaintings;
}

public System.Data.DataTable  GetAuthorPaintingsInDataTable(AuthorPaintings authorpaintings,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingid,authorid From tblauthorpaintings ";

switch(MatchWith.ToLower()){
case "paintingid" : 
query+=" where paintingid="+authorpaintings.PaintingID+"";
break;
case "authorid" : 
query+=" where authorid="+authorpaintings.AuthorID+"";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblauthorpaintings=new System.Data.DataTable();
da.Fill(tblauthorpaintings);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblauthorpaintings;
}

public System.Data.DataTable  GetActiveAuthorPaintingsInDataTable(AuthorPaintings authorpaintings,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingid,authorid From tblauthorpaintings ";

switch(MatchWith.ToLower()){
case "paintingid" : 
query+=" where paintingid="+authorpaintings.PaintingID+" and Is_Active='true' ";
break;
case "authorid" : 
query+=" where authorid="+authorpaintings.AuthorID+" and Is_Active='true' ";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblauthorpaintings=new System.Data.DataTable();
da.Fill(tblauthorpaintings);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblauthorpaintings;
}

public List<AuthorPaintings>  GetAuthorPaintingsInList()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select paintingid,authorid From tblauthorpaintings";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<AuthorPaintings> lstauthorpaintings=new List<AuthorPaintings>();
while(reader.Read())
{
AuthorPaintings authorpaintings=new AuthorPaintings();
authorpaintings.PaintingID=Convert.ToInt32(reader["paintingid"]);
authorpaintings.AuthorID=Convert.ToInt32(reader["authorid"]);
lstauthorpaintings.Add(authorpaintings);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstauthorpaintings;}

public List<AuthorPaintings>  GetAuthorPaintingsInList(AuthorPaintings authorpaintings,string MatchWith)
{ 
string query=" Select paintingid,authorid From tblauthorpaintings ";switch(MatchWith.ToLower()){
case "paintingid" : 
query+=" where paintingid="+authorpaintings.PaintingID+"";
break;
case "authorid" : 
query+=" where authorid="+authorpaintings.AuthorID+"";
break;
}
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<AuthorPaintings> lstauthorpaintings=new List<AuthorPaintings>();
while(reader.Read())
{
authorpaintings=new AuthorPaintings();
authorpaintings.PaintingID=Convert.ToInt32(reader["paintingid"]);
authorpaintings.AuthorID=Convert.ToInt32(reader["authorid"]);
lstauthorpaintings.Add(authorpaintings);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstauthorpaintings;}


}

}
