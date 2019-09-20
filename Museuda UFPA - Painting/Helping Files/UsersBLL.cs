using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UFPA.Common;
using UFPA.DAL;
namespace UFPA.BLL 
{

public class UsersBLL
 {
///<summary>
///This Method will return the maximum primary key number in your data base.
///For Example If your Users contain only 1 record and the Primary Key Value is 5 then function will return 5
///You can Use this method to get next ID of your Users
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public int GetMaxPrimaryKey()
{ 
 return new DAL.UsersDAL().GetMaxPrimaryKey();
}

///<summary>
///This Method will insert and record of Users  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Users>This is an Object of your Class Users</param>
public bool Insert(Users users)
{ 
 return new DAL.UsersDAL().Insert(users);
}

///<summary>
///This Method will insert List of Users  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Users>This is an Object of your Class Users</param>
public bool Insert(List<Users> userss)
{ 
 return new DAL.UsersDAL().Insert(userss);
}

///<summary>
///This Method will Update and record of Users  in your database.
///Return true when data will update to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Users>This is an Object of your Class Users</param>
public bool Update(Users users)
{ 
 return new DAL.UsersDAL().Update(users);
}

///<summary>
///This Method will Delete and record of Users  in your database.
///Return true when data will Delete to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Users>This is an Object of your Class Users</param>
public bool Delete(Users users)
{ 
 return new DAL.UsersDAL().Delete(users);
}

///<summary>
///This Method will Delete all record record of Users  in your database.
///Return true when data will Delete From your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public bool DeleteAll()
{ 
 return new DAL.UsersDAL().DeleteAll();
}

///<summary>
///This Method will Get record of Users  From your database in a Single Object of Class Users.
///Return Object if record Found other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Users>This is an Object of your Class Users</param>
public Users GetUsersInObjectUsingID(Users users)
{ 
 return new DAL.UsersDAL().GetUsersInObjectUsingID(users);
}

public System.Data.DataTable  GetUsersInDataTable()
{ 
 return new DAL.UsersDAL().GetUsersInDataTable();
}

public System.Data.DataTable  GetUsersInDataTable(Users users,string MatchWith)
{ 
 return new DAL.UsersDAL().GetUsersInDataTable(users,MatchWith);
}

public List<Users>  GetUsersInList()
{ 
 return new DAL.UsersDAL().GetUsersInList();
}

public List<Users>  GetUsersInList(Users users,string MatchWith)
{ 
 return new DAL.UsersDAL().GetUsersInList(users,MatchWith);
}


}

}
