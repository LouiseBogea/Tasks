using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UFPA.Common;
using UFPA.DAL;
namespace UFPA.BLL 
{

public class AuthorPaintingCategoriesBLL
 {
///<summary>
///This Method will return the maximum primary key number in your data base.
///For Example If your AuthorPaintingCategories contain only 1 record and the Primary Key Value is 5 then function will return 5
///You can Use this method to get next ID of your AuthorPaintingCategories
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public int GetMaxPrimaryKey()
{ 
 return new DAL.AuthorPaintingCategoriesDAL().GetMaxPrimaryKey();
}

///<summary>
///This Method will insert and record of AuthorPaintingCategories  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintingCategories>This is an Object of your Class AuthorPaintingCategories</param>
public bool Insert(AuthorPaintingCategories authorpaintingcategories)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().Insert(authorpaintingcategories);
}

///<summary>
///This Method will insert List of AuthorPaintingCategories  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintingCategories>This is an Object of your Class AuthorPaintingCategories</param>
public bool Insert(List<AuthorPaintingCategories> authorpaintingcategoriess)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().Insert(authorpaintingcategoriess);
}

///<summary>
///This Method will Update and record of AuthorPaintingCategories  in your database.
///Return true when data will update to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintingCategories>This is an Object of your Class AuthorPaintingCategories</param>
public bool Update(AuthorPaintingCategories authorpaintingcategories)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().Update(authorpaintingcategories);
}

///<summary>
///This Method will Delete and record of AuthorPaintingCategories  in your database.
///Return true when data will Delete to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintingCategories>This is an Object of your Class AuthorPaintingCategories</param>
public bool Delete(AuthorPaintingCategories authorpaintingcategories)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().Delete(authorpaintingcategories);
}

///<summary>
///This Method will Delete all record record of AuthorPaintingCategories  in your database.
///Return true when data will Delete From your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public bool DeleteAll()
{ 
 return new DAL.AuthorPaintingCategoriesDAL().DeleteAll();
}

///<summary>
///This Method will Get record of AuthorPaintingCategories  From your database in a Single Object of Class AuthorPaintingCategories.
///Return Object if record Found other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=AuthorPaintingCategories>This is an Object of your Class AuthorPaintingCategories</param>
public AuthorPaintingCategories GetAuthorPaintingCategoriesInObjectUsingID(AuthorPaintingCategories authorpaintingcategories)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().GetAuthorPaintingCategoriesInObjectUsingID(authorpaintingcategories);
}

public System.Data.DataTable  GetAuthorPaintingCategoriesInDataTable()
{ 
 return new DAL.AuthorPaintingCategoriesDAL().GetAuthorPaintingCategoriesInDataTable();
}

public System.Data.DataTable  GetAuthorPaintingCategoriesInDataTable(AuthorPaintingCategories authorpaintingcategories,string MatchWith)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().GetAuthorPaintingCategoriesInDataTable(authorpaintingcategories,MatchWith);
}

public List<AuthorPaintingCategories>  GetAuthorPaintingCategoriesInList()
{ 
 return new DAL.AuthorPaintingCategoriesDAL().GetAuthorPaintingCategoriesInList();
}

public List<AuthorPaintingCategories>  GetAuthorPaintingCategoriesInList(AuthorPaintingCategories authorpaintingcategories,string MatchWith)
{ 
 return new DAL.AuthorPaintingCategoriesDAL().GetAuthorPaintingCategoriesInList(authorpaintingcategories,MatchWith);
}


}

}
