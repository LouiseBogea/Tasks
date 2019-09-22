using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFPA
{
    public class clsPainting
    {
        public string RegistrationNumber { get; set; }
        public string InventoryNumber { get; set; }
        public string Collection { get; set; }
        public bool IsAssignedToAuthor { get; set; }
        public int AuthorPaintingID { get; set; }
        public string Title { get; set; }
        public string WorkCondition { get; set; }
        public string WorkConditionDescription { get; set; }
        public bool IsPhotoAvailable { get; set; }
        public string FrontPhotoPath { get; set; }
        public string BackPhotoPath { get; set; }
        public bool IsRestored { get; set; }
        public string BeforeRestorationImagePath { get; set; }
        public string AfterRestorationImagePath { get; set; }
        public DateTime LastRestorationDate { get; set; }
        public bool IsInTheStore { get; set; }
        public string DrawerNumber { get; set; }
        public string CurrentLocation { get; set; }
        public string LocalLocation { get; set; }
        public string TagTitle { get; set; }
        public string TagDescription { get; set; }
        public string Object { get; set; }
        public string Copy { get; set; }
        public string Technique { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CultureGroup { get; set; }
        public string DatePosition { get; set; }
        public string Style { get; set; }
        public string Movement { get; set; }
        public string Period { get; set; }
        public bool IsSignatureAvailable { get; set; }
        public string SignaturePosition { get; set; }
        public string SignaturePath { get; set; }
        public string SignatureDescription { get; set; }
        public bool IsMarked { get; set; }
        public string MarkedPosition { get; set; }
        public string MarkedPath { get; set; }
        public string ProcessNumber { get; set; }
        public string WayOfAcquisition { get; set; }
        public DateTime DateOfAcquisition { get; set; }
        public string PurchasePrice { get; set; }
        public string InsuranceValue { get; set; }
        public string Publisher { get; set; }
        public string Edition { get; set; }
        public string EditionNumber { get; set; }
        public string TypeOfAge { get; set; }
        public string Category { get; set; }
        public string FrameHeight { get; set; }
        public string FrameWidth { get; set; }
        public string FrameDepth { get; set; }
        public string FrameWeight { get; set; }
        public string FrameShape { get; set; }
        public string PrintedAreaHeight { get; set; }
        public string PrintedAreaWidth { get; set; }
        public string PrintedAreaDepth { get; set; }
        public string PrintedAreaWeight { get; set; }
        public string PrintedAreaShape { get; set; }
        public string FormalDescription { get; set; }
        public string ContentDescription { get; set; }
        public string KeywordsDescription { get; set; }
        public string ExOwner { get; set; }
        public string Exhibition { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }
        public int PaintingViewCount { get; set; }

    }
}
