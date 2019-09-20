using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFPA.Common 
{

public class AuthorPaintings
 {
public int PaintingID;
public int AuthorID;
public AuthorPaintings()
{
}
public AuthorPaintings(int PaintingID,int AuthorID)
{this.PaintingID= PaintingID;
this.AuthorID= AuthorID;

}
public override int GetHashCode() 
{
return Convert.ToInt32(this.PaintingID);
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
