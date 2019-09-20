using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFPA
{
    public partial class UserSignUp : MetroFramework.Forms.MetroForm
    {
        //DAL.AuthorsDAL ad = new DAL.AuthorsDAL();
        //Common.Authors newAuthor = new Common.Authors();
        //newAuthor.ID = ad.GetMaxPrimaryKey() + 1;
        DAL.UsersDAL ud = new DAL.UsersDAL();
        
        public UserSignUp()
        {
            
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Common.Users newUser = new Common.Users();
            newUser.ID = ud.GetMaxPrimaryKey() + 1;
            newUser.Name = txtName.Text;
            newUser.Username = txtUserName.Text;
            newUser.Email = txtEmail.Text;
            newUser.Phone = txtPhone.Text;
            newUser.Password = txtPassword.Text;
            if (ud.Insert(newUser))
            {
                Debug.WriteLine("yeh we are good to go!");
            }
            else
            {
                Debug.WriteLine(" ah! some problems there");
            }
        }
    }
}
