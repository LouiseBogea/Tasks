using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFPA.Common 
{

public class Authors
 {
public int ID;
public string Name;
public DateTime DOB;
public string PlaceOfBirth;
public string Address;
public string Biography;
public string SignImage;
public string ProfileImage;
public Authors()
{
}
public Authors(int ID,string Name,DateTime DOB,string PlaceOfBirth,string Address,string Biography,string SignImage,string ProfileImage)
{this.ID= ID;
this.Name= Name;
this.DOB= DOB;
this.PlaceOfBirth= PlaceOfBirth;
this.Address= Address;
this.Biography= Biography;
this.SignImage= SignImage;
this.ProfileImage= ProfileImage;

}
public override int GetHashCode() 
{
return Convert.ToInt32(this.ID);
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
