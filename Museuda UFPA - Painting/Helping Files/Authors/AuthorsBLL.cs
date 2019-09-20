using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UFPA.Common;
using UFPA.DAL;
namespace UFPA.BLL 
{

public class AuthorsBLL
 {
///<summary>
///This Method will return the maximum primary key number in your data base.
///For Example If your Authors contain only 1 record and the Primary Key Value is 5 then function will return 5
///You can Use this method to get next ID of your Authors
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public int GetMaxPrimaryKey()
{ 
 return new DAL.AuthorsDAL().GetMaxPrimaryKey();
}

///<summary>
///This Method will insert and record of Authors  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Authors>This is an Object of your Class Authors</param>
public bool Insert(Authors authors)
{ 
 return new DAL.AuthorsDAL().Insert(authors);
}

///<summary>
///This Method will insert List of Authors  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Authors>This is an Object of your Class Authors</param>
public bool Insert(List<Authors> authorss)
{ 
 return new DAL.AuthorsDAL().Insert(authorss);
}

///<summary>
///This Method will Update and record of Authors  in your database.
///Return true when data will update to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Authors>This is an Object of your Class Authors</param>
public bool Update(Authors authors)
{ 
 return new DAL.AuthorsDAL().Update(authors);
}

///<summary>
///This Method will Delete and record of Authors  in your database.
///Return true when data will Delete to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Authors>This is an Object of your Class Authors</param>
public bool Delete(Authors authors)
{ 
 return new DAL.AuthorsDAL().Delete(authors);
}

///<summary>
///This Method will Delete all record record of Authors  in your database.
///Return true when data will Delete From your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public bool DeleteAll()
{ 
 return new DAL.AuthorsDAL().DeleteAll();
}

///<summary>
///This Method will Get record of Authors  From your database in a Single Object of Class Authors.
///Return Object if record Found other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Authors>This is an Object of your Class Authors</param>
public Authors GetAuthorsInObjectUsingID(Authors authors)
{ 
 return new DAL.AuthorsDAL().GetAuthorsInObjectUsingID(authors);
}

public System.Data.DataTable  GetAuthorsInDataTable()
{ 
 return new DAL.AuthorsDAL().GetAuthorsInDataTable();
}

public System.Data.DataTable  GetAuthorsInDataTable(Authors authors,string MatchWith)
{ 
 return new DAL.AuthorsDAL().GetAuthorsInDataTable(authors,MatchWith);
}

public List<Authors>  GetAuthorsInList()
{ 
 return new DAL.AuthorsDAL().GetAuthorsInList();
}

public List<Authors>  GetAuthorsInList(Authors authors,string MatchWith)
{ 
 return new DAL.AuthorsDAL().GetAuthorsInList(authors,MatchWith);
}


}

}
