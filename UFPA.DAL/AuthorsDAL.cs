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

public class AuthorsDAL
 {
public int GetMaxPrimaryKey()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select Max(id) from tblAuthors";
SqlCommand cmd=new SqlCommand(query,con);
string max=cmd.ExecuteScalar().ToString();
if(max=="" || max==null) max="0";
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return Convert.ToInt32(max);
}

public bool Insert(Authors authors)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" insert into tblAuthors(id,name,dob,placeofbirth,address,biography,signimage,profileimage)values("+authors.ID+",'"+authors.Name+"','"+authors.DOB+"','"+authors.PlaceOfBirth+"','"+authors.Address+"','"+authors.Biography+"','"+authors.SignImage+"','"+authors.ProfileImage+"')";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool InsertUpdate(Authors authors)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select count(*) from tblAuthors where id="+authors.ID+"";
SqlCommand cmd=new SqlCommand(query,con);
int c=cmd.ExecuteScalar()==DBNull.Value?0:Convert.ToInt32(cmd.ExecuteScalar());
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return c==0?this.Insert(authors):this.Update(authors);
}
public bool Insert(List<Authors> authorss)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand("",con);
foreach(Authors authors in authorss){
string query=" insert into tblAuthors(id,name,dob,placeofbirth,address,biography,signimage,profileimage)values("+authors.ID+",'"+authors.Name+"','"+authors.DOB+"','"+authors.PlaceOfBirth+"','"+authors.Address+"','"+authors.Biography+"','"+authors.SignImage+"','"+authors.ProfileImage+"')";
cmd.CommandText=query;
cmd.ExecuteNonQuery();
}
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool Update(Authors authors)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" update  tblAuthors set name='"+authors.Name+"',dob='"+authors.DOB+"',placeofbirth='"+authors.PlaceOfBirth+"',address='"+authors.Address+"',biography='"+authors.Biography+"',signimage='"+authors.SignImage+"',profileimage='"+authors.ProfileImage+"' where id="+authors.ID+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool Delete(Authors authors)
{
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from  tblauthors   where id="+authors.ID+"";
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
string query=" delete from tblauthors";  
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public Authors GetAuthorsInObjectUsingID(Authors authors)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,name,dob,placeofbirth,address,biography,signimage,profileimage From tblauthors where id="+authors.ID+"";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
while(reader.Read())
{
authors.ID=Convert.ToInt32(reader["id"]);
authors.Name=Convert.ToString(reader["name"]);
authors.DOB=Convert.ToDateTime(reader["dob"]);
authors.PlaceOfBirth=Convert.ToString(reader["placeofbirth"]);
authors.Address=Convert.ToString(reader["address"]);
authors.Biography=Convert.ToString(reader["biography"]);
authors.SignImage=Convert.ToString(reader["signimage"]);
authors.ProfileImage=Convert.ToString(reader["profileimage"]);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return authors;
}

public System.Data.DataTable  GetAuthorsInDataTable()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select id,name,dob,placeofbirth,address,biography,signimage,profileimage From tblauthors";
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable authors=new System.Data.DataTable();
da.Fill(authors);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return authors;
}

public System.Data.DataTable  GetAuthorsInDataTable(Authors authors,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,name,dob,placeofbirth,address,biography,signimage,profileimage From tblauthors ";

switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+authors.ID+"";
break;
case "name" : 
query+=" where name='"+authors.Name+"'";
break;
case "dob" : 
query+=" where dob='"+authors.DOB+"'";
break;
case "placeofbirth" : 
query+=" where placeofbirth='"+authors.PlaceOfBirth+"'";
break;
case "address" : 
query+=" where address='"+authors.Address+"'";
break;
case "biography" : 
query+=" where biography='"+authors.Biography+"'";
break;
case "signimage" : 
query+=" where signimage='"+authors.SignImage+"'";
break;
case "profileimage" : 
query+=" where profileimage='"+authors.ProfileImage+"'";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblauthors=new System.Data.DataTable();
da.Fill(tblauthors);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblauthors;
}

public System.Data.DataTable  GetActiveAuthorsInDataTable(Authors authors,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,name,dob,placeofbirth,address,biography,signimage,profileimage From tblauthors ";

switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+authors.ID+" and Is_Active='true' ";
break;
case "name" : 
query+=" where name='"+authors.Name+"' and Is_Active='true'";
break;
case "dob" : 
query+=" where dob='"+authors.DOB+"' and Is_Active='true'";
break;
case "placeofbirth" : 
query+=" where placeofbirth='"+authors.PlaceOfBirth+"' and Is_Active='true'";
break;
case "address" : 
query+=" where address='"+authors.Address+"' and Is_Active='true'";
break;
case "biography" : 
query+=" where biography='"+authors.Biography+"' and Is_Active='true'";
break;
case "signimage" : 
query+=" where signimage='"+authors.SignImage+"' and Is_Active='true'";
break;
case "profileimage" : 
query+=" where profileimage='"+authors.ProfileImage+"' and Is_Active='true'";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblauthors=new System.Data.DataTable();
da.Fill(tblauthors);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblauthors;
}

public List<Authors>  GetAuthorsInList()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select id,name,dob,placeofbirth,address,biography,signimage,profileimage From tblauthors";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<Authors> lstauthors=new List<Authors>();
while(reader.Read())
{
Authors authors=new Authors();
authors.ID=Convert.ToInt32(reader["id"]);
authors.Name=Convert.ToString(reader["name"]);
authors.DOB=Convert.ToDateTime(reader["dob"]);
authors.PlaceOfBirth=Convert.ToString(reader["placeofbirth"]);
authors.Address=Convert.ToString(reader["address"]);
authors.Biography=Convert.ToString(reader["biography"]);
authors.SignImage=Convert.ToString(reader["signimage"]);
authors.ProfileImage=Convert.ToString(reader["profileimage"]);
lstauthors.Add(authors);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstauthors;}

public List<Authors>  GetAuthorsInList(Authors authors,string MatchWith)
{ 
string query=" Select id,name,dob,placeofbirth,address,biography,signimage,profileimage From tblauthors ";switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+authors.ID+"";
break;
case "name" : 
query+=" where name='"+authors.Name+"'";
break;
case "dob" : 
query+=" where dob='"+authors.DOB+"'";
break;
case "placeofbirth" : 
query+=" where placeofbirth='"+authors.PlaceOfBirth+"'";
break;
case "address" : 
query+=" where address='"+authors.Address+"'";
break;
case "biography" : 
query+=" where biography='"+authors.Biography+"'";
break;
case "signimage" : 
query+=" where signimage='"+authors.SignImage+"'";
break;
case "profileimage" : 
query+=" where profileimage='"+authors.ProfileImage+"'";
break;
}
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<Authors> lstauthors=new List<Authors>();
while(reader.Read())
{
authors=new Authors();
authors.ID=Convert.ToInt32(reader["id"]);
authors.Name=Convert.ToString(reader["name"]);
authors.DOB=Convert.ToDateTime(reader["dob"]);
authors.PlaceOfBirth=Convert.ToString(reader["placeofbirth"]);
authors.Address=Convert.ToString(reader["address"]);
authors.Biography=Convert.ToString(reader["biography"]);
authors.SignImage=Convert.ToString(reader["signimage"]);
authors.ProfileImage=Convert.ToString(reader["profileimage"]);
lstauthors.Add(authors);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstauthors;}


}

}
