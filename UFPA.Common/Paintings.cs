using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFPA.Common 
{

public class Paintings
 {
public int PaintingID;
public string RegistrationNumber;
public string Collection;
public bool IsAssignedToAuthor;
public int AuthorPaintingID;
public string Title;
public string WorkCondition;
public string WorkConditionDescription;
public string InventoryNumber;
public string FrontPhotoPath;
public string BackPhotoPath;
public string BeforeRestorationImagePath;
public string AfterRestorationImagePath;
public string LastRestorationDate;
public string DrawerNumber;
public string CurrentLocation;
public string LocalLocation;
public string TagTitle;
public string Tag;
public string TagDescription;
public string Object;
public string Copy;
public string CreatedDate;
public string ModifiedDate;
public string CultureGroup;
public string DatePosition;
public string Style;
public string Movement;
public string Period;
public string SignaturePosition;
public string SignaturePath;
public string SinatureDescription;
public string MarkedPosition;
public string MarkedPath;
public string ProcessNumber;
public string WayOfAcquisition;
public string DateOfAcquisition;
public string PurchasePrice;
public string InsuranceValue;
public string Publisher;
public string Edition;
public string EditionNumber;
public string TypeOfAge;
public string Category;
public string ProviderName;
public string FrameHeight;
public string FrameWidth;
public string FrameDepth;
public string FrameWeight;
public string FrameShape;
public string PrintedAreaHeight;
public string PrintedAreaWidth;
public string PrintedAreaDepth;
public string PrintedAreaWeight;
public string PrintedAreaShape;
public string FormalDescription;
public string ContentDescription;
public string KeywordsDescription;
public string ExOwner;
public string Exhibition;
public string Reference;
public string Notes;
public int PaintingViewCount;
public int ModifiedBy;
public int CreatedBy;
public bool IsPhotoAvailable;
public bool IsRestored;
public bool IsInTheStore;
public bool IsSignatureAvailable;
public bool IsMarked;
        public string Technique;

        public Paintings()
{
}
public Paintings(int PaintingID,string RegistrationNumber,string Collection,bool IsAssignedToAuthor,int AuthorPaintingID,string Title,string WorkCondition,string WorkConditionDescription,string InventoryNumber,string FrontPhotoPath,string BackPhotoPath,string BeforeRestorationImagePath,string AfterRestorationImagePath,string LastRestorationDate,string DrawerNumber,string CurrentLocation,string LocalLocation,string TagTitle,string Tag,string TagDescription,string Object,string Copy,string CreatedDate,string ModifiedDate,string CultureGroup,string DatePosition,string Style,string Movement,string Period,string SignaturePosition,string SignaturePath,string SinatureDescription,string MarkedPosition,string MarkedPath,string ProcessNumber,string WayOfAcquisition,string DateOfAcquisition,string PurchasePrice,string InsuranceValue,string Publisher,string Edition,string EditionNumber,string TypeOfAge,string Category,string ProviderName,string FrameHeight,string FrameWidth,string FrameDepth,string FrameWeight,string FrameShape,string PrintedAreaHeight,string PrintedAreaWidth,string PrintedAreaDepth,string PrintedAreaWeight,string PrintedAreaShape,string FormalDescription,string ContentDescription,string KeywordsDescription,string ExOwner,string Exhibition,string Reference,string Notes,int PaintingViewCount,int ModifiedBy,int CreatedBy,bool IsPhotoAvailable,bool IsRestored,bool IsInTheStore,bool IsSignatureAvailable,bool IsMarked)
{this.PaintingID= PaintingID;
this.RegistrationNumber= RegistrationNumber;
this.Collection= Collection;
this.IsAssignedToAuthor= IsAssignedToAuthor;
this.AuthorPaintingID= AuthorPaintingID;
this.Title= Title;
this.WorkCondition= WorkCondition;
this.WorkConditionDescription= WorkConditionDescription;
this.InventoryNumber= InventoryNumber;
this.FrontPhotoPath= FrontPhotoPath;
this.BackPhotoPath= BackPhotoPath;
this.BeforeRestorationImagePath= BeforeRestorationImagePath;
this.AfterRestorationImagePath= AfterRestorationImagePath;
this.LastRestorationDate= LastRestorationDate;
this.DrawerNumber= DrawerNumber;
this.CurrentLocation= CurrentLocation;
this.LocalLocation= LocalLocation;
this.TagTitle= TagTitle;
this.Tag= Tag;
this.TagDescription= TagDescription;
this.Object= Object;
this.Copy= Copy;
this.CreatedDate= CreatedDate;
this.ModifiedDate= ModifiedDate;
this.CultureGroup= CultureGroup;
this.DatePosition= DatePosition;
this.Style= Style;
this.Movement= Movement;
this.Period= Period;
this.SignaturePosition= SignaturePosition;
this.SignaturePath= SignaturePath;
this.SinatureDescription= SinatureDescription;
this.MarkedPosition= MarkedPosition;
this.MarkedPath= MarkedPath;
this.ProcessNumber= ProcessNumber;
this.WayOfAcquisition= WayOfAcquisition;
this.DateOfAcquisition= DateOfAcquisition;
this.PurchasePrice= PurchasePrice;
this.InsuranceValue= InsuranceValue;
this.Publisher= Publisher;
this.Edition= Edition;
this.EditionNumber= EditionNumber;
this.TypeOfAge= TypeOfAge;
this.Category= Category;
this.ProviderName= ProviderName;
this.FrameHeight= FrameHeight;
this.FrameWidth= FrameWidth;
this.FrameDepth= FrameDepth;
this.FrameWeight= FrameWeight;
this.FrameShape= FrameShape;
this.PrintedAreaHeight= PrintedAreaHeight;
this.PrintedAreaWidth= PrintedAreaWidth;
this.PrintedAreaDepth= PrintedAreaDepth;
this.PrintedAreaWeight= PrintedAreaWeight;
this.PrintedAreaShape= PrintedAreaShape;
this.FormalDescription= FormalDescription;
this.ContentDescription= ContentDescription;
this.KeywordsDescription= KeywordsDescription;
this.ExOwner= ExOwner;
this.Exhibition= Exhibition;
this.Reference= Reference;
this.Notes= Notes;
this.PaintingViewCount= PaintingViewCount;
this.ModifiedBy= ModifiedBy;
this.CreatedBy= CreatedBy;
this.IsPhotoAvailable= IsPhotoAvailable;
this.IsRestored= IsRestored;
this.IsInTheStore= IsInTheStore;
this.IsSignatureAvailable= IsSignatureAvailable;
this.IsMarked= IsMarked;

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
