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

public class UsersDAL
 {
public int GetMaxPrimaryKey()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select Max(id) from tblUsers";
SqlCommand cmd=new SqlCommand(query,con);
string max=cmd.ExecuteScalar().ToString();
if(max=="" || max==null) max="0";
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return Convert.ToInt32(max);
}

public bool Insert(Users users)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" insert into tblUsers(id,password,username,name,email,phone,signupdate,isadmin,isactive)values("+users.ID+",'"+users.Password+"','"+users.Username+"','"+users.Name+"','"+users.Email+"','"+users.Phone+"','"+users.SignupDate+"','"+users.IsAdmin+"','"+users.IsActive+"')";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool InsertUpdate(Users users)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select count(*) from tblUsers where id="+users.ID+"";
SqlCommand cmd=new SqlCommand(query,con);
int c=cmd.ExecuteScalar()==DBNull.Value?0:Convert.ToInt32(cmd.ExecuteScalar());
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return c==0?this.Insert(users):this.Update(users);
}
public bool Insert(List<Users> userss)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand("",con);
foreach(Users users in userss){
string query=" insert into tblUsers(id,password,username,name,email,phone,signupdate,isadmin,isactive)values("+users.ID+",'"+users.Password+"','"+users.Username+"','"+users.Name+"','"+users.Email+"','"+users.Phone+"','"+users.SignupDate+"','"+users.IsAdmin+"','"+users.IsActive+"')";
cmd.CommandText=query;
cmd.ExecuteNonQuery();
}
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool Update(Users users)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" update  tblUsers set password='"+users.Password+"',username='"+users.Username+"',name='"+users.Name+"',email='"+users.Email+"',phone='"+users.Phone+"',signupdate='"+users.SignupDate+"',isadmin='"+users.IsAdmin+"',isactive='"+users.IsActive+"' where id="+users.ID+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool Delete(Users users)
{
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from  tblusers   where id="+users.ID+"";
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
string query=" delete from tblusers";  
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public Users GetUsersInObjectUsingID(Users users)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,password,username,name,email,phone,signupdate,isadmin,isactive From tblusers where id="+users.ID+"";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
while(reader.Read())
{
users.ID=Convert.ToInt32(reader["id"]);
users.Password=Convert.ToString(reader["password"]);
users.Username=Convert.ToString(reader["username"]);
users.Name=Convert.ToString(reader["name"]);
users.Email=Convert.ToString(reader["email"]);
users.Phone=Convert.ToString(reader["phone"]);
users.SignupDate=Convert.ToString(reader["signupdate"]);
users.IsAdmin=Convert.ToBoolean(reader["isadmin"]);
users.IsActive=Convert.ToBoolean(reader["isactive"]);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return users;
}

public System.Data.DataTable  GetUsersInDataTable()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select id,password,username,name,email,phone,signupdate,isadmin,isactive From tblusers";
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable users=new System.Data.DataTable();
da.Fill(users);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return users;
}

public System.Data.DataTable  GetUsersInDataTable(Users users,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,password,username,name,email,phone,signupdate,isadmin,isactive From tblusers ";

switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+users.ID+"";
break;
case "password" : 
query+=" where password='"+users.Password+"'";
break;
case "username" : 
query+=" where username='"+users.Username+"'";
break;
case "name" : 
query+=" where name='"+users.Name+"'";
break;
case "email" : 
query+=" where email='"+users.Email+"'";
break;
case "phone" : 
query+=" where phone='"+users.Phone+"'";
break;
case "signupdate" : 
query+=" where signupdate='"+users.SignupDate+"'";
break;
case "isadmin" : 
query+=" where isadmin='"+users.IsAdmin+"'";
break;
case "isactive" : 
query+=" where isactive='"+users.IsActive+"'";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblusers=new System.Data.DataTable();
da.Fill(tblusers);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblusers;
}

public System.Data.DataTable  GetActiveUsersInDataTable(Users users,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  id,password,username,name,email,phone,signupdate,isadmin,isactive From tblusers ";

switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+users.ID+" and Is_Active='true' ";
break;
case "password" : 
query+=" where password='"+users.Password+"' and Is_Active='true'";
break;
case "username" : 
query+=" where username='"+users.Username+"' and Is_Active='true'";
break;
case "name" : 
query+=" where name='"+users.Name+"' and Is_Active='true'";
break;
case "email" : 
query+=" where email='"+users.Email+"' and Is_Active='true'";
break;
case "phone" : 
query+=" where phone='"+users.Phone+"' and Is_Active='true'";
break;
case "signupdate" : 
query+=" where signupdate='"+users.SignupDate+"' and Is_Active='true'";
break;
case "isadmin" : 
query+=" where isadmin='"+users.IsAdmin+"' and Is_Active='true'";
break;
case "isactive" : 
query+=" where isactive='"+users.IsActive+"' and Is_Active='true'";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblusers=new System.Data.DataTable();
da.Fill(tblusers);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblusers;
}

public List<Users>  GetUsersInList()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select id,password,username,name,email,phone,signupdate,isadmin,isactive From tblusers";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<Users> lstusers=new List<Users>();
while(reader.Read())
{
Users users=new Users();
users.ID=Convert.ToInt32(reader["id"]);
users.Password=Convert.ToString(reader["password"]);
users.Username=Convert.ToString(reader["username"]);
users.Name=Convert.ToString(reader["name"]);
users.Email=Convert.ToString(reader["email"]);
users.Phone=Convert.ToString(reader["phone"]);
users.SignupDate=Convert.ToString(reader["signupdate"]);
users.IsAdmin=Convert.ToBoolean(reader["isadmin"]);
users.IsActive=Convert.ToBoolean(reader["isactive"]);
lstusers.Add(users);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstusers;}

public List<Users>  GetUsersInList(Users users,string MatchWith)
{ 
string query=" Select id,password,username,name,email,phone,signupdate,isadmin,isactive From tblusers ";switch(MatchWith.ToLower()){
case "id" : 
query+=" where id="+users.ID+"";
break;
case "password" : 
query+=" where password='"+users.Password+"'";
break;
case "username" : 
query+=" where username='"+users.Username+"'";
break;
case "name" : 
query+=" where name='"+users.Name+"'";
break;
case "email" : 
query+=" where email='"+users.Email+"'";
break;
case "phone" : 
query+=" where phone='"+users.Phone+"'";
break;
case "signupdate" : 
query+=" where signupdate='"+users.SignupDate+"'";
break;
case "isadmin" : 
query+=" where isadmin='"+users.IsAdmin+"'";
break;
case "isactive" : 
query+=" where isactive='"+users.IsActive+"'";
break;
}
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<Users> lstusers=new List<Users>();
while(reader.Read())
{
users=new Users();
users.ID=Convert.ToInt32(reader["id"]);
users.Password=Convert.ToString(reader["password"]);
users.Username=Convert.ToString(reader["username"]);
users.Name=Convert.ToString(reader["name"]);
users.Email=Convert.ToString(reader["email"]);
users.Phone=Convert.ToString(reader["phone"]);
users.SignupDate=Convert.ToString(reader["signupdate"]);
users.IsAdmin=Convert.ToBoolean(reader["isadmin"]);
users.IsActive=Convert.ToBoolean(reader["isactive"]);
lstusers.Add(users);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstusers;}


}

}
