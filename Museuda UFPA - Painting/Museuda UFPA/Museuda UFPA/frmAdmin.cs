using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace UFPA
{
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        DAL.PaintingsDAL pd = new DAL.PaintingsDAL();
        
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataAccess.CON_STR = @"Data Source = .\SQLExpress; Initial Catalog=MuseuDaUFPA;User id=sa;Password=sql;";
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Left = Top = 0;

            pnlMenuGroup1.Height = 29;

            pnlMenuGroup3.Height = 29;

            btnMenuGroupManagement.Image = Properties.Resources.down;

            btnMenuGroupSettings.Image = Properties.Resources.down;
        }

        private void btnMenuGroup1_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup1.Height == 29)
            {
                pnlMenuGroup1.Height = 187;// (25 * 4) + 8;
                btnMenuGroupManagement.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup1.Height = 29;
                btnMenuGroupManagement.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup3_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup3.Height == 29)
            {
                pnlMenuGroup3.Height = 134;// (25 * 4) + 8;
                btnMenuGroupSettings.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup3.Height = 29;
                btnMenuGroupSettings.Image = Properties.Resources.down;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmChild = new frmAbout();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void rbAssignedAuthorYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAssignedAuthorYes.Checked)
            {
                btnAddAuthor.Visible = true;
            }
            else
            {
                btnAddAuthor.Visible = false;
            }
        }

        private void rbPhotoYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPhotoYes.Checked)
            {
                gBoxPhoto.Visible = true;
                txtPhotoFrontPath.Visible = true;
                txtPhotoBackPath.Visible = true;
                btnBrowsePhotoFront.Visible = true;
                btnBrowsePhotoBack.Visible = true;
            }
            else
            {
                gBoxPhoto.Visible = false;
                txtPhotoFrontPath.Visible = false;
                txtPhotoBackPath.Visible = false;
                btnBrowsePhotoFront.Visible = false;
                btnBrowsePhotoBack.Visible = false;
            }
        }

        private void rbRestoredYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRestoredYes.Checked)
            {
                gBoxRestored.Visible = true;
                txtBeforeRestorationPath.Visible = true;
                txtAfterRestorationPath.Visible = true;
                btnBrowseBeforRestoration.Visible = true;
                btnBrowseAfterRestoration.Visible = true;
                dateTimeRestorationDate.Visible = true;
            }
            else
            {
                gBoxRestored.Visible = false;
                txtBeforeRestorationPath.Visible = false;
                txtAfterRestorationPath.Visible = false;
                btnBrowseBeforRestoration.Visible = false;
                btnBrowseAfterRestoration.Visible = false;
                dateTimeRestorationDate.Visible = false;
            }
        }

        private void rbInStoreYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInStoreYes.Checked)
            {
                gbInStore.Visible = true;
                txtDrawerNumber.Visible = true;
                txtCurrentLocation.Visible = true;
                txtLocalLocation.Visible = true;
            }
            else
            {
                gbInStore.Visible = false;
                txtDrawerNumber.Visible = false;
                txtCurrentLocation.Visible = false;
                txtLocalLocation.Visible = false;
            }
        }

        private void rbSignatureYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSignatureYes.Checked)
            {
                gBoxSignature.Visible = true;
                cboSignaturePosition.Visible = true;
                txtSignaturePath.Visible = true;
                btnSignaturePath.Visible = true;
                txtSignatureDescription.Visible = true;
            }
            else
            {
                gBoxSignature.Visible = false;
                cboSignaturePosition.Visible = false;
                txtSignaturePath.Visible = false;
                btnSignaturePath.Visible = false;
                txtSignatureDescription.Visible = false;
            }
        }

        private void rbMarkedYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMarkedYes.Checked)
            {
                gBoxMarked.Visible = true;
                cboMarkedPosition.Visible = true;
                txtMarkedPath.Visible = true;
                btnMarkedPath.Visible = true;
            }
            else
            {
                gBoxMarked.Visible = false;
                cboMarkedPosition.Visible = false;
                txtMarkedPath.Visible = false;
                btnMarkedPath.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DAL.PaintingsDAL pd = new DAL.PaintingsDAL();
            //Common.Paintings p = new Common.Paintings();
            Common.Paintings p = new Common.Paintings();

            p.PaintingID = pd.GetMaxPrimaryKey() + 1;
            p.RegistrationNumber = txtRegNumber.Text.Trim();
            p.InventoryNumber = txtInventoryNumber.Text.Trim();
            p.Collection = txtCollection.Text.Trim();
            p.IsAssignedToAuthor = rbAssignedAuthorYes.Checked;
            //if (objPainting.IsAssignedToAuthor)
            //{
            //    //Insert Painting ID to AuthorPainting table.
            //    foreach (object itemChecked in checkListAuthors.CheckedItems)
            //    {
            //        DataRowView castedItem = itemChecked as DataRowView;
            //        string AuthorName = castedItem["AuthorName"].ToString();
            //        int AuthorId = Convert.ToInt32(castedItem["AuthorID"].ToString());
            //    }
            //}
            p.Title = txtTitle.Text.Trim();
            p.WorkCondition = cboCondition.SelectedItem.ToString();
            p.WorkConditionDescription = txtConditionDescription.Text.Trim();
            p.IsPhotoAvailable = rbPhotoYes.Checked;
            if (p.IsPhotoAvailable)
            {
                p.FrontPhotoPath = txtPhotoFrontPath.Text.Trim();
                p.BackPhotoPath = txtPhotoBackPath.Text.Trim();
            }
            p.IsRestored = rbRestoredYes.Checked;
            if (p.IsRestored)
            {
                p.BeforeRestorationImagePath = txtBeforeRestorationPath.Text.Trim();
                p.AfterRestorationImagePath = txtAfterRestorationPath.Text.Trim();
                p.LastRestorationDate = dateTimeRestorationDate.Value.Date.ToString();
            }
            p.IsInTheStore = rbInStoreYes.Checked;
            if (p.IsInTheStore)
            {
                p.DrawerNumber = txtDrawerNumber.Text.Trim();
                p.CurrentLocation = txtCurrentLocation.Text.Trim();
                p.LocalLocation = txtLocalLocation.Text.Trim();
            }
            p.TagTitle = txtTagTitle.Text.Trim();
            p.TagDescription = txtTagDescription.Text.Trim();
            p.Object = txtObject.Text.Trim();
            p.Copy = txtCopy.Text.Trim();
            p.Technique = cboTechnique.SelectedItem.ToString();
            p.CreatedBy = 1;//TODO
            p.CreatedDate = DateTime.Now.ToString();
            p.ModifiedBy = 1;//TODO
            p.ModifiedDate = DateTime.Now.ToString(); //TODO
            p.CultureGroup = txtCultureGroup.Text.Trim();
            p.DatePosition = cboDatePosition.SelectedItem.ToString();
            p.Style = txtStyle.Text.Trim();
            p.Movement = txtMovement.Text.Trim();
            p.Period = txtPeriod.Text.Trim();
            p.IsSignatureAvailable = rbSignatureYes.Checked;
            if (p.IsSignatureAvailable)
            {
                p.SignaturePosition = cboSignaturePosition.SelectedItem.ToString();
                p.SignaturePath = txtSignaturePath.Text.Trim();
            }
            p.IsMarked = rbMarkedYes.Checked;
            if (p.IsMarked)
            {
                p.MarkedPosition = cboMarkedPosition.SelectedItem.ToString();
                p.MarkedPath = txtMarkedPath.Text.Trim();
            }
            p.ProcessNumber = txtProcessNumber.Text.Trim();
            p.WayOfAcquisition = rbSold.Checked ? rbSold.Text : rbGift.Text;
            p.DateOfAcquisition = dTimeDateOfAcquisition.Value.Date.ToString();
            p.PurchasePrice = txtPurchasePrice.Text.Trim();
            p.InsuranceValue = txtInsuranceValue.Text.Trim();
            p.Publisher = txtPublisher.Text.Trim();
            p.Edition = txtEdition.Text.Trim();
            p.EditionNumber = txtEditionNumber.Text.Trim();
            p.TypeOfAge = txtTypeOfAge.Text.Trim();
            //p.Category = cboCategory.SelectedItem.ToString();
            p.FrameHeight = txtFrameHeight.Text.Trim();
            p.FrameWidth = txtFrameWidth.Text.Trim();
            p.FrameDepth = txtFrameDepth.Text.Trim();
            p.FrameWeight = txtFrameWeight.Text.Trim();
            p.FrameShape = txtFrameShape.Text.Trim();
            p.PrintedAreaHeight = txtPrintedAreaHeight.Text.Trim();
            p.PrintedAreaWidth = txtPrintedAreaWidth.Text.Trim();
            p.PrintedAreaDepth = txtPrintedAreaDepth.Text.Trim();
            p.PrintedAreaWeight = txtPrintedAreaWeight.Text.Trim();
            p.PrintedAreaShape = txtPrintedAreaShape.Text.Trim();
            p.FormalDescription = txtFormalDescription.Text.Trim();
            p.ContentDescription = txtContentDescription.Text.Trim();
            p.KeywordsDescription = txtKeywordsDescription.Text.Trim();
            p.ExOwner = txtExOwners.Text.Trim();
            p.Exhibition = txtExhibition.Text.Trim();
            p.Reference = txtReferences.Text.Trim();
            p.Notes = txtNotes.Text.Trim();
            p.PaintingViewCount = 0;//TODO

            if (pd.Insert(p))
            {
                // success
                Debug.WriteLine("Record Inserted!");
            }
            else
            {
                Debug.WriteLine("Record Not Inserted");
            }
        }

       
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                Author objAuthor = new Author();
                objAuthor.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOther.Checked)
            {
                lblOtherAcquisitionDetail.Visible = true;
                txtOtherDetail.Visible = true;
            }
            else
            {
                lblOtherAcquisitionDetail.Visible = false;
                txtOtherDetail.Visible = false;
            }
        }
    }
}
