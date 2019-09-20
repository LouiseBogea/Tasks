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

public class AuthorPaintingCategoriesDAL
 {
public int GetMaxPrimaryKey()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select Max(paintingcategoryid) from tblAuthorPaintingCategories";
SqlCommand cmd=new SqlCommand(query,con);
string max=cmd.ExecuteScalar().ToString();
if(max=="" || max==null) max="0";
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return Convert.ToInt32(max);
}

public bool Insert(AuthorPaintingCategories authorpaintingcategories)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" insert into tblAuthorPaintingCategories(paintingcategoryid,authorid)values("+authorpaintingcategories.PaintingCategoryID+","+authorpaintingcategories.AuthorID+")";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool InsertUpdate(AuthorPaintingCategories authorpaintingcategories)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select count(*) from tblAuthorPaintingCategories where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+"";
SqlCommand cmd=new SqlCommand(query,con);
int c=cmd.ExecuteScalar()==DBNull.Value?0:Convert.ToInt32(cmd.ExecuteScalar());
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return c==0?this.Insert(authorpaintingcategories):this.Update(authorpaintingcategories);
}
public bool Insert(List<AuthorPaintingCategories> authorpaintingcategoriess)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand("",con);
foreach(AuthorPaintingCategories authorpaintingcategories in authorpaintingcategoriess){
string query=" insert into tblAuthorPaintingCategories(paintingcategoryid,authorid)values("+authorpaintingcategories.PaintingCategoryID+",authorpaintingcategories.AuthorID)";
cmd.CommandText=query;
cmd.ExecuteNonQuery();
}
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool Update(AuthorPaintingCategories authorpaintingcategories)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" update  tblAuthorPaintingCategories set authorid="+authorpaintingcategories.AuthorID+" where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool Delete(AuthorPaintingCategories authorpaintingcategories)
{
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from  tblauthorpaintingcategories   where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+"";
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
string query=" delete from tblauthorpaintingcategories";  
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public AuthorPaintingCategories GetAuthorPaintingCategoriesInObjectUsingID(AuthorPaintingCategories authorpaintingcategories)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingcategoryid,authorid From tblauthorpaintingcategories where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+"";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
while(reader.Read())
{
authorpaintingcategories.PaintingCategoryID=Convert.ToInt32(reader["paintingcategoryid"]);
authorpaintingcategories.AuthorID=Convert.ToInt32(reader["authorid"]);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return authorpaintingcategories;
}

public System.Data.DataTable  GetAuthorPaintingCategoriesInDataTable()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select paintingcategoryid,authorid From tblauthorpaintingcategories";
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable authorpaintingcategories=new System.Data.DataTable();
da.Fill(authorpaintingcategories);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return authorpaintingcategories;
}

public System.Data.DataTable  GetAuthorPaintingCategoriesInDataTable(AuthorPaintingCategories authorpaintingcategories,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingcategoryid,authorid From tblauthorpaintingcategories ";

switch(MatchWith.ToLower()){
case "paintingcategoryid" : 
query+=" where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+"";
break;
case "authorid" : 
query+=" where authorid="+authorpaintingcategories.AuthorID+"";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblauthorpaintingcategories=new System.Data.DataTable();
da.Fill(tblauthorpaintingcategories);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblauthorpaintingcategories;
}

public System.Data.DataTable  GetActiveAuthorPaintingCategoriesInDataTable(AuthorPaintingCategories authorpaintingcategories,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingcategoryid,authorid From tblauthorpaintingcategories ";

switch(MatchWith.ToLower()){
case "paintingcategoryid" : 
query+=" where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+" and Is_Active='true' ";
break;
case "authorid" : 
query+=" where authorid="+authorpaintingcategories.AuthorID+" and Is_Active='true' ";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblauthorpaintingcategories=new System.Data.DataTable();
da.Fill(tblauthorpaintingcategories);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblauthorpaintingcategories;
}

public List<AuthorPaintingCategories>  GetAuthorPaintingCategoriesInList()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select paintingcategoryid,authorid From tblauthorpaintingcategories";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<AuthorPaintingCategories> lstauthorpaintingcategories=new List<AuthorPaintingCategories>();
while(reader.Read())
{
AuthorPaintingCategories authorpaintingcategories=new AuthorPaintingCategories();
authorpaintingcategories.PaintingCategoryID=Convert.ToInt32(reader["paintingcategoryid"]);
authorpaintingcategories.AuthorID=Convert.ToInt32(reader["authorid"]);
lstauthorpaintingcategories.Add(authorpaintingcategories);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstauthorpaintingcategories;}

public List<AuthorPaintingCategories>  GetAuthorPaintingCategoriesInList(AuthorPaintingCategories authorpaintingcategories,string MatchWith)
{ 
string query=" Select paintingcategoryid,authorid From tblauthorpaintingcategories ";switch(MatchWith.ToLower()){
case "paintingcategoryid" : 
query+=" where paintingcategoryid="+authorpaintingcategories.PaintingCategoryID+"";
break;
case "authorid" : 
query+=" where authorid="+authorpaintingcategories.AuthorID+"";
break;
}
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<AuthorPaintingCategories> lstauthorpaintingcategories=new List<AuthorPaintingCategories>();
while(reader.Read())
{
authorpaintingcategories=new AuthorPaintingCategories();
authorpaintingcategories.PaintingCategoryID=Convert.ToInt32(reader["paintingcategoryid"]);
authorpaintingcategories.AuthorID=Convert.ToInt32(reader["authorid"]);
lstauthorpaintingcategories.Add(authorpaintingcategories);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstauthorpaintingcategories;}


}

}
