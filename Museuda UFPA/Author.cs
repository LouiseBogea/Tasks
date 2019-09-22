using System;
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
    public partial class Author : MetroFramework.Forms.MetroForm
    {
        DataTable dt = null;
        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM Author";
                DataSet ds = (DataSet)DataAccess.ExecuteDataSet(CommandType.Text, Query, null);
                dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        checkListAuthors.Items.Add(dt.Rows[i]["Name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DAL.paintingDAL pd = new DAL.paintingDAL();

            //Common.painting p = new Common.painting();
            //p.id = pd.GetMaxPrimaryKey() + 1;
            DAL.AuthorsDAL ad = new DAL.AuthorsDAL();
            Common.Authors newAuthor = new Common.Authors();
            newAuthor.ID = ad.GetMaxPrimaryKey() + 1;
            newAuthor.Name = "waa";
            newAuthor.PlaceOfBirth = "wah";
            newAuthor.ProfileImage = "pic";
            newAuthor.DOB = new DateTime(2015, 12, 25);
            ad.Insert(newAuthor);
            this.Hide();
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkListAuthors == null || checkListAuthors.Items.Count == 0)
                    return;

                checkListAuthors.Items.Clear();
                if (string.IsNullOrEmpty(txtAuthorName.Text))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            checkListAuthors.Items.Add(dt.Rows[i]["Name"].ToString());
                        }
                    }
                }
                else
                {
                    checkListAuthors.Items.Clear();
                    List<DataRow> lstMatchedNames = dt.Select("Name LIKE '%" + txtAuthorName.Text.Trim() + "%'").ToList();
                    foreach (DataRow objDataRow in lstMatchedNames)
                    {
                        checkListAuthors.Items.Add(objDataRow["Name"]);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
