using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UFPA
{
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
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
            DAL.paintingDAL pd = new DAL.paintingDAL();

            Common.painting p = new Common.painting();
            p.id = pd.GetMaxPrimaryKey() + 1;
            p.artistid = 2342;
            if (pd.Insert(p))
            {
                // success
            }
            clsPainting objPainting = new clsPainting();
            objPainting.RegistrationNumber = txtRegNumber.Text.Trim();
            objPainting.InventoryNumber = txtInventoryNumber.Text.Trim();
            objPainting.Collection = txtCollection.Text.Trim();
            objPainting.IsAssignedToAuthor = rbAssignedAuthorYes.Checked;
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
            objPainting.Title = txtTitle.Text.Trim();
            objPainting.WorkCondition = cboCondition.SelectedItem.ToString();
            objPainting.WorkConditionDescription = txtConditionDescription.Text.Trim();
            objPainting.IsPhotoAvailable = rbPhotoYes.Checked;
            if (objPainting.IsPhotoAvailable)
            {
                objPainting.FrontPhotoPath = txtPhotoFrontPath.Text.Trim();
                objPainting.BackPhotoPath = txtPhotoBackPath.Text.Trim();
            }
            objPainting.IsRestored = rbRestoredYes.Checked;
            if (objPainting.IsRestored)
            {
                objPainting.BeforeRestorationImagePath = txtBeforeRestorationPath.Text.Trim();
                objPainting.AfterRestorationImagePath = txtAfterRestorationPath.Text.Trim();
                objPainting.LastRestorationDate = dateTimeRestorationDate.Value.Date;
            }
            objPainting.IsInTheStore = rbInStoreYes.Checked;
            if (objPainting.IsInTheStore)
            {
                objPainting.DrawerNumber = txtDrawerNumber.Text.Trim();
                objPainting.CurrentLocation = txtCurrentLocation.Text.Trim();
                objPainting.LocalLocation = txtLocalLocation.Text.Trim();
            }
            objPainting.TagTitle = txtTagTitle.Text.Trim();
            objPainting.TagDescription = txtTagDescription.Text.Trim();
            objPainting.Object = txtObject.Text.Trim();
            objPainting.Copy = txtCopy.Text.Trim();
            objPainting.Technique = cboTechnique.SelectedItem.ToString();
            objPainting.CreatedBy = 1;//TODO
            objPainting.CreatedDate = DateTime.Now;
            objPainting.ModifiedBy = 1;//TODO
            objPainting.ModifiedDate = DateTime.Now; //TODO
            objPainting.CultureGroup = txtCultureGroup.Text.Trim();
            objPainting.DatePosition = cboDatePosition.SelectedItem.ToString();
            objPainting.Style = txtStyle.Text.Trim();
            objPainting.Movement = txtMovement.Text.Trim();
            objPainting.Period = txtPeriod.Text.Trim();
            objPainting.IsSignatureAvailable = rbSignatureYes.Checked;
            if (objPainting.IsSignatureAvailable)
            {
                objPainting.SignaturePosition = cboSignaturePosition.SelectedItem.ToString();
                objPainting.SignaturePath = txtSignaturePath.Text.Trim();
            }
            objPainting.IsMarked = rbMarkedYes.Checked;
            if (objPainting.IsMarked)
            {
                objPainting.MarkedPosition = cboMarkedPosition.SelectedItem.ToString();
                objPainting.MarkedPath = txtMarkedPath.Text.Trim();
            }
            objPainting.ProcessNumber = txtProcessNumber.Text.Trim();
            objPainting.WayOfAcquisition = rbSold.Checked ? rbSold.Text : rbGift.Text;
            objPainting.DateOfAcquisition = dTimeDateOfAcquisition.Value.Date;
            objPainting.PurchasePrice = txtPurchasePrice.Text.Trim();
            objPainting.InsuranceValue = txtInsuranceValue.Text.Trim();
            objPainting.Publisher = txtPublisher.Text.Trim();
            objPainting.Edition = txtEdition.Text.Trim();
            objPainting.EditionNumber = txtEditionNumber.Text.Trim();
            objPainting.TypeOfAge = txtTypeOfAge.Text.Trim();
            objPainting.Category = cboCategory.SelectedItem.ToString();
            objPainting.FrameHeight = txtFrameHeight.Text.Trim();
            objPainting.FrameWidth = txtFrameWidth.Text.Trim();
            objPainting.FrameDepth = txtFrameDepth.Text.Trim();
            objPainting.FrameWeight = txtFrameWeight.Text.Trim();
            objPainting.FrameShape = txtFrameShape.Text.Trim();
            objPainting.PrintedAreaHeight = txtPrintedAreaHeight.Text.Trim();
            objPainting.PrintedAreaWidth = txtPrintedAreaWidth.Text.Trim();
            objPainting.PrintedAreaDepth = txtPrintedAreaDepth.Text.Trim();
            objPainting.PrintedAreaWeight = txtPrintedAreaWeight.Text.Trim();
            objPainting.PrintedAreaShape = txtPrintedAreaShape.Text.Trim();
            objPainting.FormalDescription = txtFormalDescription.Text.Trim();
            objPainting.ContentDescription = txtContentDescription.Text.Trim();
            objPainting.KeywordsDescription = txtKeywordsDescription.Text.Trim();
            objPainting.ExOwner = txtExOwners.Text.Trim();
            objPainting.Exhibition = txtExhibition.Text.Trim();
            objPainting.Reference = txtReferences.Text.Trim();
            objPainting.Notes = txtNotes.Text.Trim();
            objPainting.PaintingViewCount = 0;//TODO
        }

        private void InsertPaintingData(clsPainting objPainting)
        {
            try
            {
                string Query = ",IsInTheStore,DrawerNumber,CurrentLocation,LocalLocation,TagTitle" +
                        ",TagDescription,Object,Copy,Technique,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate" +
                        ",CultureGroup,DatePosition,Style,Movement,Period,IsSignatureAvailable,SignaturePosition" +
                        ",SignaturePath,SinatureDescription,IsMarked,MarkedPosition,MarkedPath,ProcessNumber" +
                        ",WayOfAcquisition,DateOfAcquisition,PurchasePrice,InsuranceValue,Publisher,Edition" +
                        ",EditionNumber,TypeOfAge,Category,FrameHeight,FrameWidth,FrameDepth,FrameWeight,FrameShape" +
                        ",PrintedAreaHeight,PrintedAreaWidth,PrintedAreaDepth,PrintedAreaWeight,PrintedAreaShape" +
                        ",FormalDescription,ContentDescription,KeywordsDescription,ExOwner,Exhibition,Reference,Notes,PaintingViewCount)" +
                        "VALUES ('" + objPainting.RegistrationNumber + "', '" + objPainting.InventoryNumber + "', '" + objPainting.Collection + "', '" + objPainting.IsAssignedToAuthor + "" +
                        ", '" + objPainting.Title + "', '" + objPainting.WorkCondition + "', '" + objPainting.WorkConditionDescription + "', '" + objPainting.IsPhotoAvailable + "', '" + objPainting.FrontPhotoPath + "'" +
                        ", '" + objPainting.BackPhotoPath + "', '" + objPainting.IsRestored + "', '" + objPainting.BeforeRestorationImagePath + "', '" + objPainting.AfterRestorationImagePath + "','" + objPainting.LastRestorationDate + "'" +
                        ", '" + objPainting.IsInTheStore + "', '" + objPainting.DrawerNumber + "', '" + objPainting.CurrentLocation + "', '" + objPainting.LocalLocation + "', '" + objPainting.TagTitle + "'" +
                        ", '" + objPainting.TagDescription + "', '" + objPainting.Object + "', '" + objPainting.Copy + "', '" + objPainting.Technique + "', '" + objPainting.CreatedBy + "', '" + objPainting.CreatedDate + "', '" + objPainting.ModifiedBy + "', '" + objPainting.ModifiedDate + "'" +
                        ", '" + objPainting.CultureGroup + "', '" + objPainting.DatePosition + "', '" + objPainting.Style + "', '" + objPainting.Movement + "', '" + objPainting.Period + "', '" + objPainting.IsSignatureAvailable + "', '" + objPainting.SignaturePosition + "'" +
                        ", '" + objPainting.SignaturePath + "', '" + objPainting.SignatureDescription + "', '" + objPainting.IsMarked + "', '" + objPainting.MarkedPosition + "', '" + objPainting.MarkedPath + "', '" + objPainting.ProcessNumber + "'" +
                        ", '" + objPainting.WayOfAcquisition + "', '" + objPainting.DateOfAcquisition + "', '" + objPainting.PurchasePrice + "', '" + objPainting.InsuranceValue + "', '" + objPainting.Publisher + "', '" + objPainting.Edition + "'" +
                        ", '" + objPainting.EditionNumber + "', '" + objPainting.TypeOfAge + "', '" + objPainting.Category + "', '" + objPainting.FrameHeight + "', '" + objPainting.FrameWidth + "', '" + objPainting.FrameDepth + "', '" + objPainting.FrameWeight + "', '" + objPainting.FrameShape + "'" +
                        ", '" + objPainting.PrintedAreaHeight + "', '" + objPainting.PrintedAreaWidth + "', '" + objPainting.PrintedAreaDepth + "', '" + objPainting.PrintedAreaWeight + "', '" + objPainting.PrintedAreaShape + "'" +
                        ", '" + objPainting.FormalDescription + "', '" + objPainting.ContentDescription + "', '" + objPainting.KeywordsDescription + "', '" + objPainting.ExOwner + "', '" + objPainting.Exhibition + "', '" + objPainting.Reference + "', '" + objPainting.Notes + "', '" + objPainting.PaintingViewCount + "')";

            }
            catch (Exception ex)
            {

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
