using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFPA.Common 
{

public class painting
 {
public int id;
public int artistid;
public painting()
{
}
public painting(int id,int artistid)
{this.id= id;
this.artistid= artistid;

}
public override int GetHashCode() 
{
return Convert.ToInt32(this.id);
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
