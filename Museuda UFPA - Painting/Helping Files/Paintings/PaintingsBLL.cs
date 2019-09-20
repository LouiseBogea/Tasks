using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UFPA.Common;
using UFPA.DAL;
namespace UFPA.BLL 
{

public class PaintingsBLL
 {
///<summary>
///This Method will return the maximum primary key number in your data base.
///For Example If your Paintings contain only 1 record and the Primary Key Value is 5 then function will return 5
///You can Use this method to get next ID of your Paintings
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public int GetMaxPrimaryKey()
{ 
 return new DAL.PaintingsDAL().GetMaxPrimaryKey();
}

///<summary>
///This Method will insert and record of Paintings  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Paintings>This is an Object of your Class Paintings</param>
public bool Insert(Paintings paintings)
{ 
 return new DAL.PaintingsDAL().Insert(paintings);
}

///<summary>
///This Method will insert List of Paintings  in your database.
///Return true when data will insert to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Paintings>This is an Object of your Class Paintings</param>
public bool Insert(List<Paintings> paintingss)
{ 
 return new DAL.PaintingsDAL().Insert(paintingss);
}

///<summary>
///This Method will Update and record of Paintings  in your database.
///Return true when data will update to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Paintings>This is an Object of your Class Paintings</param>
public bool Update(Paintings paintings)
{ 
 return new DAL.PaintingsDAL().Update(paintings);
}

///<summary>
///This Method will Delete and record of Paintings  in your database.
///Return true when data will Delete to your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Paintings>This is an Object of your Class Paintings</param>
public bool Delete(Paintings paintings)
{ 
 return new DAL.PaintingsDAL().Delete(paintings);
}

///<summary>
///This Method will Delete all record record of Paintings  in your database.
///Return true when data will Delete From your Data base other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
public bool DeleteAll()
{ 
 return new DAL.PaintingsDAL().DeleteAll();
}

///<summary>
///This Method will Get record of Paintings  From your database in a Single Object of Class Paintings.
///Return Object if record Found other wise will throw an Execption of Type SQLExecption or return false in any other Problem 
///Your are using Beta Version of Rapid Development (by Raees Ul Islam 0345-7294449 
///</summary>
///</param name=Paintings>This is an Object of your Class Paintings</param>
public Paintings GetPaintingsInObjectUsingID(Paintings paintings)
{ 
 return new DAL.PaintingsDAL().GetPaintingsInObjectUsingID(paintings);
}

public System.Data.DataTable  GetPaintingsInDataTable()
{ 
 return new DAL.PaintingsDAL().GetPaintingsInDataTable();
}

public System.Data.DataTable  GetPaintingsInDataTable(Paintings paintings,string MatchWith)
{ 
 return new DAL.PaintingsDAL().GetPaintingsInDataTable(paintings,MatchWith);
}

public List<Paintings>  GetPaintingsInList()
{ 
 return new DAL.PaintingsDAL().GetPaintingsInList();
}

public List<Paintings>  GetPaintingsInList(Paintings paintings,string MatchWith)
{ 
 return new DAL.PaintingsDAL().GetPaintingsInList(paintings,MatchWith);
}


}

}
