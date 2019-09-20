using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFPA.Common 
{

public class Users
 {
public int ID;
public string Password;
public string Username;
public string Name;
public string Email;
public string Phone;
public string SignupDate;
public bool IsAdmin;
public bool IsActive;
public Users()
{
}
public Users(int ID,string Password,string Username,string Name,string Email,string Phone,string SignupDate,bool IsAdmin,bool IsActive)
{this.ID= ID;
this.Password= Password;
this.Username= Username;
this.Name= Name;
this.Email= Email;
this.Phone= Phone;
this.SignupDate= SignupDate;
this.IsAdmin= IsAdmin;
this.IsActive= IsActive;

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
