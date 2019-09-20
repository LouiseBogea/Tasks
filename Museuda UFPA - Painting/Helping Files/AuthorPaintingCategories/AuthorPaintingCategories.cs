using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFPA.Common 
{

public class AuthorPaintingCategories
 {
public int PaintingCategoryID;
public int AuthorID;
public AuthorPaintingCategories()
{
}
public AuthorPaintingCategories(int PaintingCategoryID,int AuthorID)
{this.PaintingCategoryID= PaintingCategoryID;
this.AuthorID= AuthorID;

}
public override int GetHashCode() 
{
return Convert.ToInt32(this.PaintingCategoryID);
}
public override bool Equals(object obj)
 {    
      if (obj == null)  
            return false;   
       else if (obj.GetHashCode() == this.GetHashCode())  
          {      
    return true;   
       }    
    else return false;   
   }

}

}
