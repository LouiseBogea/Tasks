using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UFPA.Common;
using UFPA.DAL;
namespace UFPA.BLL 
{

public class AuthorPaintingsBLL
 {
///<summary>
///This Method will return the maximum primary key number in your data base.
///For Example If your AuthorPaintings contain only 1 record and the Primary Key Value is 5 then function will return 5
///You can Use this method to get next ID of your AuthorPaintings
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public int GetMaxPrimaryKey()
{ 
 return new DAL.AuthorPaintingsDAL().GetMaxPrimaryKey();
}

///<summary>
///This Method will insert and record of AuthorPaintings  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintings>This is an Object of your Class AuthorPaintings</param>
public bool Insert(AuthorPaintings authorpaintings)
{ 
 return new DAL.AuthorPaintingsDAL().Insert(authorpaintings);
}

///<summary>
///This Method will insert List of AuthorPaintings  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintings>This is an Object of your Class AuthorPaintings</param>
public bool Insert(List<AuthorPaintings> authorpaintingss)
{ 
 return new DAL.AuthorPaintingsDAL().Insert(authorpaintingss);
}

///<summary>
///This Method will Update and record of AuthorPaintings  in your database.
///Return true when data will update to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintings>This is an Object of your Class AuthorPaintings</param>
public bool Update(AuthorPaintings authorpaintings)
{ 
 return new DAL.AuthorPaintingsDAL().Update(authorpaintings);
}

///<summary>
///This Method will Delete and record of AuthorPaintings  in your database.
///Return true when data will Delete to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintings>This is an Object of your Class AuthorPaintings</param>
public bool Delete(AuthorPaintings authorpaintings)
{ 
 return new DAL.AuthorPaintingsDAL().Delete(authorpaintings);
}

///<summary>
///This Method will Delete all record record of AuthorPaintings  in your database.
///Return true when data will Delete From your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public bool DeleteAll()
{ 
 return new DAL.AuthorPaintingsDAL().DeleteAll();
}

///<summary>
///This Method will Get record of AuthorPaintings  From your database in a Single Object of Class AuthorPaintings.
///Return Object if record Found other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintings>This is an Object of your Class AuthorPaintings</param>
public AuthorPaintings GetAuthorPaintingsInObjectUsingID(AuthorPaintings authorpaintings)
{ 
 return new DAL.AuthorPaintingsDAL().GetAuthorPaintingsInObjectUsingID(authorpaintings);
}

public System.Data.DataTable  GetAuthorPaintingsInDataTable()
{ 
 return new DAL.AuthorPaintingsDAL().GetAuthorPaintingsInDataTable();
}

public System.Data.DataTable  GetAuthorPaintingsInDataTable(AuthorPaintings authorpaintings,string MatchWith)
{ 
 return new DAL.AuthorPaintingsDAL().GetAuthorPaintingsInDataTable(authorpaintings,MatchWith);
}

public List<AuthorPaintings>  GetAuthorPaintingsInList()
{ 
 return new DAL.AuthorPaintingsDAL().GetAuthorPaintingsInList();
}

public List<AuthorPaintings>  GetAuthorPaintingsInList(AuthorPaintings authorpaintings,string MatchWith)
{ 
 return new DAL.AuthorPaintingsDAL().GetAuthorPaintingsInList(authorpaintings,MatchWith);
}


}

}
