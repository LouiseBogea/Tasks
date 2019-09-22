using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Data.SqlClient; 
using System.Data;
using UFPA.Common;
using UFPA.DAL;
namespace UFPA.DAL 
{

public class PaintingsDAL
 {
public int GetMaxPrimaryKey()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select Max(paintingid) from tblPaintings";
SqlCommand cmd=new SqlCommand(query,con);
string max=cmd.ExecuteScalar().ToString();
if(max=="" || max==null) max="0";
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return Convert.ToInt32(max);
}

public bool Insert(Paintings paintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" insert into tblPaintings(paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked)values("+paintings.PaintingID+",'"+paintings.RegistrationNumber+"','"+paintings.Collection+"','"+paintings.IsAssignedToAuthor+"',"+paintings.AuthorPaintingID+",'"+paintings.Title+"','"+paintings.WorkCondition+"','"+paintings.WorkConditionDescription+"','"+paintings.InventoryNumber+"','"+paintings.FrontPhotoPath+"','"+paintings.BackPhotoPath+"','"+paintings.BeforeRestorationImagePath+"','"+paintings.AfterRestorationImagePath+"','"+paintings.LastRestorationDate+"','"+paintings.DrawerNumber+"','"+paintings.CurrentLocation+"','"+paintings.LocalLocation+"','"+paintings.TagTitle+"','"+paintings.Tag+"','"+paintings.TagDescription+"','"+paintings.Object+"','"+paintings.Copy+"','"+paintings.CreatedDate+"','"+paintings.ModifiedDate+"','"+paintings.CultureGroup+"','"+paintings.DatePosition+"','"+paintings.Style+"','"+paintings.Movement+"','"+paintings.Period+"','"+paintings.SignaturePosition+"','"+paintings.SignaturePath+"','"+paintings.SinatureDescription+"','"+paintings.MarkedPosition+"','"+paintings.MarkedPath+"','"+paintings.ProcessNumber+"','"+paintings.WayOfAcquisition+"','"+paintings.DateOfAcquisition+"','"+paintings.PurchasePrice+"','"+paintings.InsuranceValue+"','"+paintings.Publisher+"','"+paintings.Edition+"','"+paintings.EditionNumber+"','"+paintings.TypeOfAge+"','"+paintings.Category+"','"+paintings.ProviderName+"','"+paintings.FrameHeight+"','"+paintings.FrameWidth+"','"+paintings.FrameDepth+"','"+paintings.FrameWeight+"','"+paintings.FrameShape+"','"+paintings.PrintedAreaHeight+"','"+paintings.PrintedAreaWidth+"','"+paintings.PrintedAreaDepth+"','"+paintings.PrintedAreaWeight+"','"+paintings.PrintedAreaShape+"','"+paintings.FormalDescription+"','"+paintings.ContentDescription+"','"+paintings.KeywordsDescription+"','"+paintings.ExOwner+"','"+paintings.Exhibition+"','"+paintings.Reference+"','"+paintings.Notes+"',"+paintings.PaintingViewCount+","+paintings.ModifiedBy+","+paintings.CreatedBy+",'"+paintings.IsPhotoAvailable+"','"+paintings.IsRestored+"','"+paintings.IsInTheStore+"','"+paintings.IsSignatureAvailable+"','"+paintings.IsMarked+"')";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool InsertUpdate(Paintings paintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" select count(*) from tblPaintings where paintingid="+paintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
int c=cmd.ExecuteScalar()==DBNull.Value?0:Convert.ToInt32(cmd.ExecuteScalar());
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return c==0?this.Insert(paintings):this.Update(paintings);
}
public bool Insert(List<Paintings> paintingss)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand("",con);
foreach(Paintings paintings in paintingss){
string query=" insert into tblPaintings(paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked)values("+paintings.PaintingID+",'"+paintings.RegistrationNumber+"','"+paintings.Collection+"','"+paintings.IsAssignedToAuthor+"',paintings.AuthorPaintingID,'"+paintings.Title+"','"+paintings.WorkCondition+"','"+paintings.WorkConditionDescription+"','"+paintings.InventoryNumber+"','"+paintings.FrontPhotoPath+"','"+paintings.BackPhotoPath+"','"+paintings.BeforeRestorationImagePath+"','"+paintings.AfterRestorationImagePath+"','"+paintings.LastRestorationDate+"','"+paintings.DrawerNumber+"','"+paintings.CurrentLocation+"','"+paintings.LocalLocation+"','"+paintings.TagTitle+"','"+paintings.Tag+"','"+paintings.TagDescription+"','"+paintings.Object+"','"+paintings.Copy+"','"+paintings.CreatedDate+"','"+paintings.ModifiedDate+"','"+paintings.CultureGroup+"','"+paintings.DatePosition+"','"+paintings.Style+"','"+paintings.Movement+"','"+paintings.Period+"','"+paintings.SignaturePosition+"','"+paintings.SignaturePath+"','"+paintings.SinatureDescription+"','"+paintings.MarkedPosition+"','"+paintings.MarkedPath+"','"+paintings.ProcessNumber+"','"+paintings.WayOfAcquisition+"','"+paintings.DateOfAcquisition+"','"+paintings.PurchasePrice+"','"+paintings.InsuranceValue+"','"+paintings.Publisher+"','"+paintings.Edition+"','"+paintings.EditionNumber+"','"+paintings.TypeOfAge+"','"+paintings.Category+"','"+paintings.ProviderName+"','"+paintings.FrameHeight+"','"+paintings.FrameWidth+"','"+paintings.FrameDepth+"','"+paintings.FrameWeight+"','"+paintings.FrameShape+"','"+paintings.PrintedAreaHeight+"','"+paintings.PrintedAreaWidth+"','"+paintings.PrintedAreaDepth+"','"+paintings.PrintedAreaWeight+"','"+paintings.PrintedAreaShape+"','"+paintings.FormalDescription+"','"+paintings.ContentDescription+"','"+paintings.KeywordsDescription+"','"+paintings.ExOwner+"','"+paintings.Exhibition+"','"+paintings.Reference+"','"+paintings.Notes+"',paintings.PaintingViewCount,paintings.ModifiedBy,paintings.CreatedBy,'"+paintings.IsPhotoAvailable+"','"+paintings.IsRestored+"','"+paintings.IsInTheStore+"','"+paintings.IsSignatureAvailable+"','"+paintings.IsMarked+"')";
cmd.CommandText=query;
cmd.ExecuteNonQuery();
}
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return true;
}
public bool Update(Paintings paintings)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" update  tblPaintings set registrationnumber='"+paintings.RegistrationNumber+"',collection='"+paintings.Collection+"',isassignedtoauthor='"+paintings.IsAssignedToAuthor+"',authorpaintingid="+paintings.AuthorPaintingID+",title='"+paintings.Title+"',workcondition='"+paintings.WorkCondition+"',workconditiondescription='"+paintings.WorkConditionDescription+"',inventorynumber='"+paintings.InventoryNumber+"',frontphotopath='"+paintings.FrontPhotoPath+"',backphotopath='"+paintings.BackPhotoPath+"',beforerestorationimagepath='"+paintings.BeforeRestorationImagePath+"',afterrestorationimagepath='"+paintings.AfterRestorationImagePath+"',lastrestorationdate='"+paintings.LastRestorationDate+"',drawernumber='"+paintings.DrawerNumber+"',currentlocation='"+paintings.CurrentLocation+"',locallocation='"+paintings.LocalLocation+"',tagtitle='"+paintings.TagTitle+"',tag='"+paintings.Tag+"',tagdescription='"+paintings.TagDescription+"',object='"+paintings.Object+"',copy='"+paintings.Copy+"',createddate='"+paintings.CreatedDate+"',modifieddate='"+paintings.ModifiedDate+"',culturegroup='"+paintings.CultureGroup+"',dateposition='"+paintings.DatePosition+"',style='"+paintings.Style+"',movement='"+paintings.Movement+"',period='"+paintings.Period+"',signatureposition='"+paintings.SignaturePosition+"',signaturepath='"+paintings.SignaturePath+"',sinaturedescription='"+paintings.SinatureDescription+"',markedposition='"+paintings.MarkedPosition+"',markedpath='"+paintings.MarkedPath+"',processnumber='"+paintings.ProcessNumber+"',wayofacquisition='"+paintings.WayOfAcquisition+"',dateofacquisition='"+paintings.DateOfAcquisition+"',purchaseprice='"+paintings.PurchasePrice+"',insurancevalue='"+paintings.InsuranceValue+"',publisher='"+paintings.Publisher+"',edition='"+paintings.Edition+"',editionnumber='"+paintings.EditionNumber+"',typeofage='"+paintings.TypeOfAge+"',category='"+paintings.Category+"',providername='"+paintings.ProviderName+"',frameheight='"+paintings.FrameHeight+"',framewidth='"+paintings.FrameWidth+"',framedepth='"+paintings.FrameDepth+"',frameweight='"+paintings.FrameWeight+"',frameshape='"+paintings.FrameShape+"',printedareaheight='"+paintings.PrintedAreaHeight+"',printedareawidth='"+paintings.PrintedAreaWidth+"',printedareadepth='"+paintings.PrintedAreaDepth+"',printedareaweight='"+paintings.PrintedAreaWeight+"',printedareashape='"+paintings.PrintedAreaShape+"',formaldescription='"+paintings.FormalDescription+"',contentdescription='"+paintings.ContentDescription+"',keywordsdescription='"+paintings.KeywordsDescription+"',exowner='"+paintings.ExOwner+"',exhibition='"+paintings.Exhibition+"',reference='"+paintings.Reference+"',notes='"+paintings.Notes+"',paintingviewcount="+paintings.PaintingViewCount+",modifiedby="+paintings.ModifiedBy+",createdby="+paintings.CreatedBy+",isphotoavailable='"+paintings.IsPhotoAvailable+"',isrestored='"+paintings.IsRestored+"',isinthestore='"+paintings.IsInTheStore+"',issignatureavailable='"+paintings.IsSignatureAvailable+"',ismarked='"+paintings.IsMarked+"' where paintingid="+paintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool Delete(Paintings paintings)
{
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from  tblpaintings   where paintingid="+paintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public bool DeleteAll()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" delete from tblpaintings";  
SqlCommand cmd=new SqlCommand(query,con);
cmd.ExecuteNonQuery();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();

 return true; 
}

public Paintings GetPaintingsInObjectUsingID(Paintings paintings)
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked From tblpaintings where paintingid="+paintings.PaintingID+"";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
while(reader.Read())
{
paintings.PaintingID=Convert.ToInt32(reader["paintingid"]);
paintings.RegistrationNumber=Convert.ToString(reader["registrationnumber"]);
paintings.Collection=Convert.ToString(reader["collection"]);
paintings.IsAssignedToAuthor=Convert.ToBoolean(reader["isassignedtoauthor"]);
paintings.AuthorPaintingID=Convert.ToInt32(reader["authorpaintingid"]);
paintings.Title=Convert.ToString(reader["title"]);
paintings.WorkCondition=Convert.ToString(reader["workcondition"]);
paintings.WorkConditionDescription=Convert.ToString(reader["workconditiondescription"]);
paintings.InventoryNumber=Convert.ToString(reader["inventorynumber"]);
paintings.FrontPhotoPath=Convert.ToString(reader["frontphotopath"]);
paintings.BackPhotoPath=Convert.ToString(reader["backphotopath"]);
paintings.BeforeRestorationImagePath=Convert.ToString(reader["beforerestorationimagepath"]);
paintings.AfterRestorationImagePath=Convert.ToString(reader["afterrestorationimagepath"]);
paintings.LastRestorationDate=Convert.ToString(reader["lastrestorationdate"]);
paintings.DrawerNumber=Convert.ToString(reader["drawernumber"]);
paintings.CurrentLocation=Convert.ToString(reader["currentlocation"]);
paintings.LocalLocation=Convert.ToString(reader["locallocation"]);
paintings.TagTitle=Convert.ToString(reader["tagtitle"]);
paintings.Tag=Convert.ToString(reader["tag"]);
paintings.TagDescription=Convert.ToString(reader["tagdescription"]);
paintings.Object=Convert.ToString(reader["object"]);
paintings.Copy=Convert.ToString(reader["copy"]);
paintings.CreatedDate=Convert.ToString(reader["createddate"]);
paintings.ModifiedDate=Convert.ToString(reader["modifieddate"]);
paintings.CultureGroup=Convert.ToString(reader["culturegroup"]);
paintings.DatePosition=Convert.ToString(reader["dateposition"]);
paintings.Style=Convert.ToString(reader["style"]);
paintings.Movement=Convert.ToString(reader["movement"]);
paintings.Period=Convert.ToString(reader["period"]);
paintings.SignaturePosition=Convert.ToString(reader["signatureposition"]);
paintings.SignaturePath=Convert.ToString(reader["signaturepath"]);
paintings.SinatureDescription=Convert.ToString(reader["sinaturedescription"]);
paintings.MarkedPosition=Convert.ToString(reader["markedposition"]);
paintings.MarkedPath=Convert.ToString(reader["markedpath"]);
paintings.ProcessNumber=Convert.ToString(reader["processnumber"]);
paintings.WayOfAcquisition=Convert.ToString(reader["wayofacquisition"]);
paintings.DateOfAcquisition=Convert.ToString(reader["dateofacquisition"]);
paintings.PurchasePrice=Convert.ToString(reader["purchaseprice"]);
paintings.InsuranceValue=Convert.ToString(reader["insurancevalue"]);
paintings.Publisher=Convert.ToString(reader["publisher"]);
paintings.Edition=Convert.ToString(reader["edition"]);
paintings.EditionNumber=Convert.ToString(reader["editionnumber"]);
paintings.TypeOfAge=Convert.ToString(reader["typeofage"]);
paintings.Category=Convert.ToString(reader["category"]);
paintings.ProviderName=Convert.ToString(reader["providername"]);
paintings.FrameHeight=Convert.ToString(reader["frameheight"]);
paintings.FrameWidth=Convert.ToString(reader["framewidth"]);
paintings.FrameDepth=Convert.ToString(reader["framedepth"]);
paintings.FrameWeight=Convert.ToString(reader["frameweight"]);
paintings.FrameShape=Convert.ToString(reader["frameshape"]);
paintings.PrintedAreaHeight=Convert.ToString(reader["printedareaheight"]);
paintings.PrintedAreaWidth=Convert.ToString(reader["printedareawidth"]);
paintings.PrintedAreaDepth=Convert.ToString(reader["printedareadepth"]);
paintings.PrintedAreaWeight=Convert.ToString(reader["printedareaweight"]);
paintings.PrintedAreaShape=Convert.ToString(reader["printedareashape"]);
paintings.FormalDescription=Convert.ToString(reader["formaldescription"]);
paintings.ContentDescription=Convert.ToString(reader["contentdescription"]);
paintings.KeywordsDescription=Convert.ToString(reader["keywordsdescription"]);
paintings.ExOwner=Convert.ToString(reader["exowner"]);
paintings.Exhibition=Convert.ToString(reader["exhibition"]);
paintings.Reference=Convert.ToString(reader["reference"]);
paintings.Notes=Convert.ToString(reader["notes"]);
paintings.PaintingViewCount=Convert.ToInt32(reader["paintingviewcount"]);
paintings.ModifiedBy=Convert.ToInt32(reader["modifiedby"]);
paintings.CreatedBy=Convert.ToInt32(reader["createdby"]);
paintings.IsPhotoAvailable=Convert.ToBoolean(reader["isphotoavailable"]);
paintings.IsRestored=Convert.ToBoolean(reader["isrestored"]);
paintings.IsInTheStore=Convert.ToBoolean(reader["isinthestore"]);
paintings.IsSignatureAvailable=Convert.ToBoolean(reader["issignatureavailable"]);
paintings.IsMarked=Convert.ToBoolean(reader["ismarked"]);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
return paintings;
}

public System.Data.DataTable  GetPaintingsInDataTable()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked From tblpaintings";
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable paintings=new System.Data.DataTable();
da.Fill(paintings);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return paintings;
}

public System.Data.DataTable  GetPaintingsInDataTable(Paintings paintings,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked From tblpaintings ";

switch(MatchWith.ToLower()){
case "paintingid" : 
query+=" where paintingid="+paintings.PaintingID+"";
break;
case "registrationnumber" : 
query+=" where registrationnumber='"+paintings.RegistrationNumber+"'";
break;
case "collection" : 
query+=" where collection='"+paintings.Collection+"'";
break;
case "isassignedtoauthor" : 
query+=" where isassignedtoauthor='"+paintings.IsAssignedToAuthor+"'";
break;
case "authorpaintingid" : 
query+=" where authorpaintingid="+paintings.AuthorPaintingID+"";
break;
case "title" : 
query+=" where title='"+paintings.Title+"'";
break;
case "workcondition" : 
query+=" where workcondition='"+paintings.WorkCondition+"'";
break;
case "workconditiondescription" : 
query+=" where workconditiondescription='"+paintings.WorkConditionDescription+"'";
break;
case "inventorynumber" : 
query+=" where inventorynumber='"+paintings.InventoryNumber+"'";
break;
case "frontphotopath" : 
query+=" where frontphotopath='"+paintings.FrontPhotoPath+"'";
break;
case "backphotopath" : 
query+=" where backphotopath='"+paintings.BackPhotoPath+"'";
break;
case "beforerestorationimagepath" : 
query+=" where beforerestorationimagepath='"+paintings.BeforeRestorationImagePath+"'";
break;
case "afterrestorationimagepath" : 
query+=" where afterrestorationimagepath='"+paintings.AfterRestorationImagePath+"'";
break;
case "lastrestorationdate" : 
query+=" where lastrestorationdate='"+paintings.LastRestorationDate+"'";
break;
case "drawernumber" : 
query+=" where drawernumber='"+paintings.DrawerNumber+"'";
break;
case "currentlocation" : 
query+=" where currentlocation='"+paintings.CurrentLocation+"'";
break;
case "locallocation" : 
query+=" where locallocation='"+paintings.LocalLocation+"'";
break;
case "tagtitle" : 
query+=" where tagtitle='"+paintings.TagTitle+"'";
break;
case "tag" : 
query+=" where tag='"+paintings.Tag+"'";
break;
case "tagdescription" : 
query+=" where tagdescription='"+paintings.TagDescription+"'";
break;
case "object" : 
query+=" where object='"+paintings.Object+"'";
break;
case "copy" : 
query+=" where copy='"+paintings.Copy+"'";
break;
case "createddate" : 
query+=" where createddate='"+paintings.CreatedDate+"'";
break;
case "modifieddate" : 
query+=" where modifieddate='"+paintings.ModifiedDate+"'";
break;
case "culturegroup" : 
query+=" where culturegroup='"+paintings.CultureGroup+"'";
break;
case "dateposition" : 
query+=" where dateposition='"+paintings.DatePosition+"'";
break;
case "style" : 
query+=" where style='"+paintings.Style+"'";
break;
case "movement" : 
query+=" where movement='"+paintings.Movement+"'";
break;
case "period" : 
query+=" where period='"+paintings.Period+"'";
break;
case "signatureposition" : 
query+=" where signatureposition='"+paintings.SignaturePosition+"'";
break;
case "signaturepath" : 
query+=" where signaturepath='"+paintings.SignaturePath+"'";
break;
case "sinaturedescription" : 
query+=" where sinaturedescription='"+paintings.SinatureDescription+"'";
break;
case "markedposition" : 
query+=" where markedposition='"+paintings.MarkedPosition+"'";
break;
case "markedpath" : 
query+=" where markedpath='"+paintings.MarkedPath+"'";
break;
case "processnumber" : 
query+=" where processnumber='"+paintings.ProcessNumber+"'";
break;
case "wayofacquisition" : 
query+=" where wayofacquisition='"+paintings.WayOfAcquisition+"'";
break;
case "dateofacquisition" : 
query+=" where dateofacquisition='"+paintings.DateOfAcquisition+"'";
break;
case "purchaseprice" : 
query+=" where purchaseprice='"+paintings.PurchasePrice+"'";
break;
case "insurancevalue" : 
query+=" where insurancevalue='"+paintings.InsuranceValue+"'";
break;
case "publisher" : 
query+=" where publisher='"+paintings.Publisher+"'";
break;
case "edition" : 
query+=" where edition='"+paintings.Edition+"'";
break;
case "editionnumber" : 
query+=" where editionnumber='"+paintings.EditionNumber+"'";
break;
case "typeofage" : 
query+=" where typeofage='"+paintings.TypeOfAge+"'";
break;
case "category" : 
query+=" where category='"+paintings.Category+"'";
break;
case "providername" : 
query+=" where providername='"+paintings.ProviderName+"'";
break;
case "frameheight" : 
query+=" where frameheight='"+paintings.FrameHeight+"'";
break;
case "framewidth" : 
query+=" where framewidth='"+paintings.FrameWidth+"'";
break;
case "framedepth" : 
query+=" where framedepth='"+paintings.FrameDepth+"'";
break;
case "frameweight" : 
query+=" where frameweight='"+paintings.FrameWeight+"'";
break;
case "frameshape" : 
query+=" where frameshape='"+paintings.FrameShape+"'";
break;
case "printedareaheight" : 
query+=" where printedareaheight='"+paintings.PrintedAreaHeight+"'";
break;
case "printedareawidth" : 
query+=" where printedareawidth='"+paintings.PrintedAreaWidth+"'";
break;
case "printedareadepth" : 
query+=" where printedareadepth='"+paintings.PrintedAreaDepth+"'";
break;
case "printedareaweight" : 
query+=" where printedareaweight='"+paintings.PrintedAreaWeight+"'";
break;
case "printedareashape" : 
query+=" where printedareashape='"+paintings.PrintedAreaShape+"'";
break;
case "formaldescription" : 
query+=" where formaldescription='"+paintings.FormalDescription+"'";
break;
case "contentdescription" : 
query+=" where contentdescription='"+paintings.ContentDescription+"'";
break;
case "keywordsdescription" : 
query+=" where keywordsdescription='"+paintings.KeywordsDescription+"'";
break;
case "exowner" : 
query+=" where exowner='"+paintings.ExOwner+"'";
break;
case "exhibition" : 
query+=" where exhibition='"+paintings.Exhibition+"'";
break;
case "reference" : 
query+=" where reference='"+paintings.Reference+"'";
break;
case "notes" : 
query+=" where notes='"+paintings.Notes+"'";
break;
case "paintingviewcount" : 
query+=" where paintingviewcount="+paintings.PaintingViewCount+"";
break;
case "modifiedby" : 
query+=" where modifiedby="+paintings.ModifiedBy+"";
break;
case "createdby" : 
query+=" where createdby="+paintings.CreatedBy+"";
break;
case "isphotoavailable" : 
query+=" where isphotoavailable='"+paintings.IsPhotoAvailable+"'";
break;
case "isrestored" : 
query+=" where isrestored='"+paintings.IsRestored+"'";
break;
case "isinthestore" : 
query+=" where isinthestore='"+paintings.IsInTheStore+"'";
break;
case "issignatureavailable" : 
query+=" where issignatureavailable='"+paintings.IsSignatureAvailable+"'";
break;
case "ismarked" : 
query+=" where ismarked='"+paintings.IsMarked+"'";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblpaintings=new System.Data.DataTable();
da.Fill(tblpaintings);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblpaintings;
}

public System.Data.DataTable  GetActivePaintingsInDataTable(Paintings paintings,string MatchWith)
{ 
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select  paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked From tblpaintings ";

switch(MatchWith.ToLower()){
case "paintingid" : 
query+=" where paintingid="+paintings.PaintingID+" and Is_Active='true' ";
break;
case "registrationnumber" : 
query+=" where registrationnumber='"+paintings.RegistrationNumber+"' and Is_Active='true'";
break;
case "collection" : 
query+=" where collection='"+paintings.Collection+"' and Is_Active='true'";
break;
case "isassignedtoauthor" : 
query+=" where isassignedtoauthor='"+paintings.IsAssignedToAuthor+"' and Is_Active='true'";
break;
case "authorpaintingid" : 
query+=" where authorpaintingid="+paintings.AuthorPaintingID+" and Is_Active='true' ";
break;
case "title" : 
query+=" where title='"+paintings.Title+"' and Is_Active='true'";
break;
case "workcondition" : 
query+=" where workcondition='"+paintings.WorkCondition+"' and Is_Active='true'";
break;
case "workconditiondescription" : 
query+=" where workconditiondescription='"+paintings.WorkConditionDescription+"' and Is_Active='true'";
break;
case "inventorynumber" : 
query+=" where inventorynumber='"+paintings.InventoryNumber+"' and Is_Active='true'";
break;
case "frontphotopath" : 
query+=" where frontphotopath='"+paintings.FrontPhotoPath+"' and Is_Active='true'";
break;
case "backphotopath" : 
query+=" where backphotopath='"+paintings.BackPhotoPath+"' and Is_Active='true'";
break;
case "beforerestorationimagepath" : 
query+=" where beforerestorationimagepath='"+paintings.BeforeRestorationImagePath+"' and Is_Active='true'";
break;
case "afterrestorationimagepath" : 
query+=" where afterrestorationimagepath='"+paintings.AfterRestorationImagePath+"' and Is_Active='true'";
break;
case "lastrestorationdate" : 
query+=" where lastrestorationdate='"+paintings.LastRestorationDate+"' and Is_Active='true'";
break;
case "drawernumber" : 
query+=" where drawernumber='"+paintings.DrawerNumber+"' and Is_Active='true'";
break;
case "currentlocation" : 
query+=" where currentlocation='"+paintings.CurrentLocation+"' and Is_Active='true'";
break;
case "locallocation" : 
query+=" where locallocation='"+paintings.LocalLocation+"' and Is_Active='true'";
break;
case "tagtitle" : 
query+=" where tagtitle='"+paintings.TagTitle+"' and Is_Active='true'";
break;
case "tag" : 
query+=" where tag='"+paintings.Tag+"' and Is_Active='true'";
break;
case "tagdescription" : 
query+=" where tagdescription='"+paintings.TagDescription+"' and Is_Active='true'";
break;
case "object" : 
query+=" where object='"+paintings.Object+"' and Is_Active='true'";
break;
case "copy" : 
query+=" where copy='"+paintings.Copy+"' and Is_Active='true'";
break;
case "createddate" : 
query+=" where createddate='"+paintings.CreatedDate+"' and Is_Active='true'";
break;
case "modifieddate" : 
query+=" where modifieddate='"+paintings.ModifiedDate+"' and Is_Active='true'";
break;
case "culturegroup" : 
query+=" where culturegroup='"+paintings.CultureGroup+"' and Is_Active='true'";
break;
case "dateposition" : 
query+=" where dateposition='"+paintings.DatePosition+"' and Is_Active='true'";
break;
case "style" : 
query+=" where style='"+paintings.Style+"' and Is_Active='true'";
break;
case "movement" : 
query+=" where movement='"+paintings.Movement+"' and Is_Active='true'";
break;
case "period" : 
query+=" where period='"+paintings.Period+"' and Is_Active='true'";
break;
case "signatureposition" : 
query+=" where signatureposition='"+paintings.SignaturePosition+"' and Is_Active='true'";
break;
case "signaturepath" : 
query+=" where signaturepath='"+paintings.SignaturePath+"' and Is_Active='true'";
break;
case "sinaturedescription" : 
query+=" where sinaturedescription='"+paintings.SinatureDescription+"' and Is_Active='true'";
break;
case "markedposition" : 
query+=" where markedposition='"+paintings.MarkedPosition+"' and Is_Active='true'";
break;
case "markedpath" : 
query+=" where markedpath='"+paintings.MarkedPath+"' and Is_Active='true'";
break;
case "processnumber" : 
query+=" where processnumber='"+paintings.ProcessNumber+"' and Is_Active='true'";
break;
case "wayofacquisition" : 
query+=" where wayofacquisition='"+paintings.WayOfAcquisition+"' and Is_Active='true'";
break;
case "dateofacquisition" : 
query+=" where dateofacquisition='"+paintings.DateOfAcquisition+"' and Is_Active='true'";
break;
case "purchaseprice" : 
query+=" where purchaseprice='"+paintings.PurchasePrice+"' and Is_Active='true'";
break;
case "insurancevalue" : 
query+=" where insurancevalue='"+paintings.InsuranceValue+"' and Is_Active='true'";
break;
case "publisher" : 
query+=" where publisher='"+paintings.Publisher+"' and Is_Active='true'";
break;
case "edition" : 
query+=" where edition='"+paintings.Edition+"' and Is_Active='true'";
break;
case "editionnumber" : 
query+=" where editionnumber='"+paintings.EditionNumber+"' and Is_Active='true'";
break;
case "typeofage" : 
query+=" where typeofage='"+paintings.TypeOfAge+"' and Is_Active='true'";
break;
case "category" : 
query+=" where category='"+paintings.Category+"' and Is_Active='true'";
break;
case "providername" : 
query+=" where providername='"+paintings.ProviderName+"' and Is_Active='true'";
break;
case "frameheight" : 
query+=" where frameheight='"+paintings.FrameHeight+"' and Is_Active='true'";
break;
case "framewidth" : 
query+=" where framewidth='"+paintings.FrameWidth+"' and Is_Active='true'";
break;
case "framedepth" : 
query+=" where framedepth='"+paintings.FrameDepth+"' and Is_Active='true'";
break;
case "frameweight" : 
query+=" where frameweight='"+paintings.FrameWeight+"' and Is_Active='true'";
break;
case "frameshape" : 
query+=" where frameshape='"+paintings.FrameShape+"' and Is_Active='true'";
break;
case "printedareaheight" : 
query+=" where printedareaheight='"+paintings.PrintedAreaHeight+"' and Is_Active='true'";
break;
case "printedareawidth" : 
query+=" where printedareawidth='"+paintings.PrintedAreaWidth+"' and Is_Active='true'";
break;
case "printedareadepth" : 
query+=" where printedareadepth='"+paintings.PrintedAreaDepth+"' and Is_Active='true'";
break;
case "printedareaweight" : 
query+=" where printedareaweight='"+paintings.PrintedAreaWeight+"' and Is_Active='true'";
break;
case "printedareashape" : 
query+=" where printedareashape='"+paintings.PrintedAreaShape+"' and Is_Active='true'";
break;
case "formaldescription" : 
query+=" where formaldescription='"+paintings.FormalDescription+"' and Is_Active='true'";
break;
case "contentdescription" : 
query+=" where contentdescription='"+paintings.ContentDescription+"' and Is_Active='true'";
break;
case "keywordsdescription" : 
query+=" where keywordsdescription='"+paintings.KeywordsDescription+"' and Is_Active='true'";
break;
case "exowner" : 
query+=" where exowner='"+paintings.ExOwner+"' and Is_Active='true'";
break;
case "exhibition" : 
query+=" where exhibition='"+paintings.Exhibition+"' and Is_Active='true'";
break;
case "reference" : 
query+=" where reference='"+paintings.Reference+"' and Is_Active='true'";
break;
case "notes" : 
query+=" where notes='"+paintings.Notes+"' and Is_Active='true'";
break;
case "paintingviewcount" : 
query+=" where paintingviewcount="+paintings.PaintingViewCount+" and Is_Active='true' ";
break;
case "modifiedby" : 
query+=" where modifiedby="+paintings.ModifiedBy+" and Is_Active='true' ";
break;
case "createdby" : 
query+=" where createdby="+paintings.CreatedBy+" and Is_Active='true' ";
break;
case "isphotoavailable" : 
query+=" where isphotoavailable='"+paintings.IsPhotoAvailable+"' and Is_Active='true'";
break;
case "isrestored" : 
query+=" where isrestored='"+paintings.IsRestored+"' and Is_Active='true'";
break;
case "isinthestore" : 
query+=" where isinthestore='"+paintings.IsInTheStore+"' and Is_Active='true'";
break;
case "issignatureavailable" : 
query+=" where issignatureavailable='"+paintings.IsSignatureAvailable+"' and Is_Active='true'";
break;
case "ismarked" : 
query+=" where ismarked='"+paintings.IsMarked+"' and Is_Active='true'";
break;
}
SqlDataAdapter  da=new SqlDataAdapter(query,con);
System.Data.DataTable tblpaintings=new System.Data.DataTable();
da.Fill(tblpaintings);
if (con.State == System.Data.ConnectionState.Open)
con.Close();
return tblpaintings;
}

public List<Paintings>  GetPaintingsInList()
{ 

SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
string query=" Select paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked From tblpaintings";
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<Paintings> lstpaintings=new List<Paintings>();
while(reader.Read())
{
Paintings paintings=new Paintings();
paintings.PaintingID=Convert.ToInt32(reader["paintingid"]);
paintings.RegistrationNumber=Convert.ToString(reader["registrationnumber"]);
paintings.Collection=Convert.ToString(reader["collection"]);
paintings.IsAssignedToAuthor=Convert.ToBoolean(reader["isassignedtoauthor"]);
paintings.AuthorPaintingID=Convert.ToInt32(reader["authorpaintingid"]);
paintings.Title=Convert.ToString(reader["title"]);
paintings.WorkCondition=Convert.ToString(reader["workcondition"]);
paintings.WorkConditionDescription=Convert.ToString(reader["workconditiondescription"]);
paintings.InventoryNumber=Convert.ToString(reader["inventorynumber"]);
paintings.FrontPhotoPath=Convert.ToString(reader["frontphotopath"]);
paintings.BackPhotoPath=Convert.ToString(reader["backphotopath"]);
paintings.BeforeRestorationImagePath=Convert.ToString(reader["beforerestorationimagepath"]);
paintings.AfterRestorationImagePath=Convert.ToString(reader["afterrestorationimagepath"]);
paintings.LastRestorationDate=Convert.ToString(reader["lastrestorationdate"]);
paintings.DrawerNumber=Convert.ToString(reader["drawernumber"]);
paintings.CurrentLocation=Convert.ToString(reader["currentlocation"]);
paintings.LocalLocation=Convert.ToString(reader["locallocation"]);
paintings.TagTitle=Convert.ToString(reader["tagtitle"]);
paintings.Tag=Convert.ToString(reader["tag"]);
paintings.TagDescription=Convert.ToString(reader["tagdescription"]);
paintings.Object=Convert.ToString(reader["object"]);
paintings.Copy=Convert.ToString(reader["copy"]);
paintings.CreatedDate=Convert.ToString(reader["createddate"]);
paintings.ModifiedDate=Convert.ToString(reader["modifieddate"]);
paintings.CultureGroup=Convert.ToString(reader["culturegroup"]);
paintings.DatePosition=Convert.ToString(reader["dateposition"]);
paintings.Style=Convert.ToString(reader["style"]);
paintings.Movement=Convert.ToString(reader["movement"]);
paintings.Period=Convert.ToString(reader["period"]);
paintings.SignaturePosition=Convert.ToString(reader["signatureposition"]);
paintings.SignaturePath=Convert.ToString(reader["signaturepath"]);
paintings.SinatureDescription=Convert.ToString(reader["sinaturedescription"]);
paintings.MarkedPosition=Convert.ToString(reader["markedposition"]);
paintings.MarkedPath=Convert.ToString(reader["markedpath"]);
paintings.ProcessNumber=Convert.ToString(reader["processnumber"]);
paintings.WayOfAcquisition=Convert.ToString(reader["wayofacquisition"]);
paintings.DateOfAcquisition=Convert.ToString(reader["dateofacquisition"]);
paintings.PurchasePrice=Convert.ToString(reader["purchaseprice"]);
paintings.InsuranceValue=Convert.ToString(reader["insurancevalue"]);
paintings.Publisher=Convert.ToString(reader["publisher"]);
paintings.Edition=Convert.ToString(reader["edition"]);
paintings.EditionNumber=Convert.ToString(reader["editionnumber"]);
paintings.TypeOfAge=Convert.ToString(reader["typeofage"]);
paintings.Category=Convert.ToString(reader["category"]);
paintings.ProviderName=Convert.ToString(reader["providername"]);
paintings.FrameHeight=Convert.ToString(reader["frameheight"]);
paintings.FrameWidth=Convert.ToString(reader["framewidth"]);
paintings.FrameDepth=Convert.ToString(reader["framedepth"]);
paintings.FrameWeight=Convert.ToString(reader["frameweight"]);
paintings.FrameShape=Convert.ToString(reader["frameshape"]);
paintings.PrintedAreaHeight=Convert.ToString(reader["printedareaheight"]);
paintings.PrintedAreaWidth=Convert.ToString(reader["printedareawidth"]);
paintings.PrintedAreaDepth=Convert.ToString(reader["printedareadepth"]);
paintings.PrintedAreaWeight=Convert.ToString(reader["printedareaweight"]);
paintings.PrintedAreaShape=Convert.ToString(reader["printedareashape"]);
paintings.FormalDescription=Convert.ToString(reader["formaldescription"]);
paintings.ContentDescription=Convert.ToString(reader["contentdescription"]);
paintings.KeywordsDescription=Convert.ToString(reader["keywordsdescription"]);
paintings.ExOwner=Convert.ToString(reader["exowner"]);
paintings.Exhibition=Convert.ToString(reader["exhibition"]);
paintings.Reference=Convert.ToString(reader["reference"]);
paintings.Notes=Convert.ToString(reader["notes"]);
paintings.PaintingViewCount=Convert.ToInt32(reader["paintingviewcount"]);
paintings.ModifiedBy=Convert.ToInt32(reader["modifiedby"]);
paintings.CreatedBy=Convert.ToInt32(reader["createdby"]);
paintings.IsPhotoAvailable=Convert.ToBoolean(reader["isphotoavailable"]);
paintings.IsRestored=Convert.ToBoolean(reader["isrestored"]);
paintings.IsInTheStore=Convert.ToBoolean(reader["isinthestore"]);
paintings.IsSignatureAvailable=Convert.ToBoolean(reader["issignatureavailable"]);
paintings.IsMarked=Convert.ToBoolean(reader["ismarked"]);
lstpaintings.Add(paintings);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstpaintings;}

public List<Paintings>  GetPaintingsInList(Paintings paintings,string MatchWith)
{ 
string query=" Select paintingid,registrationnumber,collection,isassignedtoauthor,authorpaintingid,title,workcondition,workconditiondescription,inventorynumber,frontphotopath,backphotopath,beforerestorationimagepath,afterrestorationimagepath,lastrestorationdate,drawernumber,currentlocation,locallocation,tagtitle,tag,tagdescription,object,copy,createddate,modifieddate,culturegroup,dateposition,style,movement,period,signatureposition,signaturepath,sinaturedescription,markedposition,markedpath,processnumber,wayofacquisition,dateofacquisition,purchaseprice,insurancevalue,publisher,edition,editionnumber,typeofage,category,providername,frameheight,framewidth,framedepth,frameweight,frameshape,printedareaheight,printedareawidth,printedareadepth,printedareaweight,printedareashape,formaldescription,contentdescription,keywordsdescription,exowner,exhibition,reference,notes,paintingviewcount,modifiedby,createdby,isphotoavailable,isrestored,isinthestore,issignatureavailable,ismarked From tblpaintings ";switch(MatchWith.ToLower()){
case "paintingid" : 
query+=" where paintingid="+paintings.PaintingID+"";
break;
case "registrationnumber" : 
query+=" where registrationnumber='"+paintings.RegistrationNumber+"'";
break;
case "collection" : 
query+=" where collection='"+paintings.Collection+"'";
break;
case "isassignedtoauthor" : 
query+=" where isassignedtoauthor='"+paintings.IsAssignedToAuthor+"'";
break;
case "authorpaintingid" : 
query+=" where authorpaintingid="+paintings.AuthorPaintingID+"";
break;
case "title" : 
query+=" where title='"+paintings.Title+"'";
break;
case "workcondition" : 
query+=" where workcondition='"+paintings.WorkCondition+"'";
break;
case "workconditiondescription" : 
query+=" where workconditiondescription='"+paintings.WorkConditionDescription+"'";
break;
case "inventorynumber" : 
query+=" where inventorynumber='"+paintings.InventoryNumber+"'";
break;
case "frontphotopath" : 
query+=" where frontphotopath='"+paintings.FrontPhotoPath+"'";
break;
case "backphotopath" : 
query+=" where backphotopath='"+paintings.BackPhotoPath+"'";
break;
case "beforerestorationimagepath" : 
query+=" where beforerestorationimagepath='"+paintings.BeforeRestorationImagePath+"'";
break;
case "afterrestorationimagepath" : 
query+=" where afterrestorationimagepath='"+paintings.AfterRestorationImagePath+"'";
break;
case "lastrestorationdate" : 
query+=" where lastrestorationdate='"+paintings.LastRestorationDate+"'";
break;
case "drawernumber" : 
query+=" where drawernumber='"+paintings.DrawerNumber+"'";
break;
case "currentlocation" : 
query+=" where currentlocation='"+paintings.CurrentLocation+"'";
break;
case "locallocation" : 
query+=" where locallocation='"+paintings.LocalLocation+"'";
break;
case "tagtitle" : 
query+=" where tagtitle='"+paintings.TagTitle+"'";
break;
case "tag" : 
query+=" where tag='"+paintings.Tag+"'";
break;
case "tagdescription" : 
query+=" where tagdescription='"+paintings.TagDescription+"'";
break;
case "object" : 
query+=" where object='"+paintings.Object+"'";
break;
case "copy" : 
query+=" where copy='"+paintings.Copy+"'";
break;
case "createddate" : 
query+=" where createddate='"+paintings.CreatedDate+"'";
break;
case "modifieddate" : 
query+=" where modifieddate='"+paintings.ModifiedDate+"'";
break;
case "culturegroup" : 
query+=" where culturegroup='"+paintings.CultureGroup+"'";
break;
case "dateposition" : 
query+=" where dateposition='"+paintings.DatePosition+"'";
break;
case "style" : 
query+=" where style='"+paintings.Style+"'";
break;
case "movement" : 
query+=" where movement='"+paintings.Movement+"'";
break;
case "period" : 
query+=" where period='"+paintings.Period+"'";
break;
case "signatureposition" : 
query+=" where signatureposition='"+paintings.SignaturePosition+"'";
break;
case "signaturepath" : 
query+=" where signaturepath='"+paintings.SignaturePath+"'";
break;
case "sinaturedescription" : 
query+=" where sinaturedescription='"+paintings.SinatureDescription+"'";
break;
case "markedposition" : 
query+=" where markedposition='"+paintings.MarkedPosition+"'";
break;
case "markedpath" : 
query+=" where markedpath='"+paintings.MarkedPath+"'";
break;
case "processnumber" : 
query+=" where processnumber='"+paintings.ProcessNumber+"'";
break;
case "wayofacquisition" : 
query+=" where wayofacquisition='"+paintings.WayOfAcquisition+"'";
break;
case "dateofacquisition" : 
query+=" where dateofacquisition='"+paintings.DateOfAcquisition+"'";
break;
case "purchaseprice" : 
query+=" where purchaseprice='"+paintings.PurchasePrice+"'";
break;
case "insurancevalue" : 
query+=" where insurancevalue='"+paintings.InsuranceValue+"'";
break;
case "publisher" : 
query+=" where publisher='"+paintings.Publisher+"'";
break;
case "edition" : 
query+=" where edition='"+paintings.Edition+"'";
break;
case "editionnumber" : 
query+=" where editionnumber='"+paintings.EditionNumber+"'";
break;
case "typeofage" : 
query+=" where typeofage='"+paintings.TypeOfAge+"'";
break;
case "category" : 
query+=" where category='"+paintings.Category+"'";
break;
case "providername" : 
query+=" where providername='"+paintings.ProviderName+"'";
break;
case "frameheight" : 
query+=" where frameheight='"+paintings.FrameHeight+"'";
break;
case "framewidth" : 
query+=" where framewidth='"+paintings.FrameWidth+"'";
break;
case "framedepth" : 
query+=" where framedepth='"+paintings.FrameDepth+"'";
break;
case "frameweight" : 
query+=" where frameweight='"+paintings.FrameWeight+"'";
break;
case "frameshape" : 
query+=" where frameshape='"+paintings.FrameShape+"'";
break;
case "printedareaheight" : 
query+=" where printedareaheight='"+paintings.PrintedAreaHeight+"'";
break;
case "printedareawidth" : 
query+=" where printedareawidth='"+paintings.PrintedAreaWidth+"'";
break;
case "printedareadepth" : 
query+=" where printedareadepth='"+paintings.PrintedAreaDepth+"'";
break;
case "printedareaweight" : 
query+=" where printedareaweight='"+paintings.PrintedAreaWeight+"'";
break;
case "printedareashape" : 
query+=" where printedareashape='"+paintings.PrintedAreaShape+"'";
break;
case "formaldescription" : 
query+=" where formaldescription='"+paintings.FormalDescription+"'";
break;
case "contentdescription" : 
query+=" where contentdescription='"+paintings.ContentDescription+"'";
break;
case "keywordsdescription" : 
query+=" where keywordsdescription='"+paintings.KeywordsDescription+"'";
break;
case "exowner" : 
query+=" where exowner='"+paintings.ExOwner+"'";
break;
case "exhibition" : 
query+=" where exhibition='"+paintings.Exhibition+"'";
break;
case "reference" : 
query+=" where reference='"+paintings.Reference+"'";
break;
case "notes" : 
query+=" where notes='"+paintings.Notes+"'";
break;
case "paintingviewcount" : 
query+=" where paintingviewcount="+paintings.PaintingViewCount+"";
break;
case "modifiedby" : 
query+=" where modifiedby="+paintings.ModifiedBy+"";
break;
case "createdby" : 
query+=" where createdby="+paintings.CreatedBy+"";
break;
case "isphotoavailable" : 
query+=" where isphotoavailable='"+paintings.IsPhotoAvailable+"'";
break;
case "isrestored" : 
query+=" where isrestored='"+paintings.IsRestored+"'";
break;
case "isinthestore" : 
query+=" where isinthestore='"+paintings.IsInTheStore+"'";
break;
case "issignatureavailable" : 
query+=" where issignatureavailable='"+paintings.IsSignatureAvailable+"'";
break;
case "ismarked" : 
query+=" where ismarked='"+paintings.IsMarked+"'";
break;
}
SqlConnection con=new SqlConnection(DBHelper.GetConnectionString());
 if (con.State == System.Data.ConnectionState.Closed)
con.Open();
SqlCommand cmd=new SqlCommand(query,con);
SqlDataReader reader=cmd.ExecuteReader();
List<Paintings> lstpaintings=new List<Paintings>();
while(reader.Read())
{
paintings=new Paintings();
paintings.PaintingID=Convert.ToInt32(reader["paintingid"]);
paintings.RegistrationNumber=Convert.ToString(reader["registrationnumber"]);
paintings.Collection=Convert.ToString(reader["collection"]);
paintings.IsAssignedToAuthor=Convert.ToBoolean(reader["isassignedtoauthor"]);
paintings.AuthorPaintingID=Convert.ToInt32(reader["authorpaintingid"]);
paintings.Title=Convert.ToString(reader["title"]);
paintings.WorkCondition=Convert.ToString(reader["workcondition"]);
paintings.WorkConditionDescription=Convert.ToString(reader["workconditiondescription"]);
paintings.InventoryNumber=Convert.ToString(reader["inventorynumber"]);
paintings.FrontPhotoPath=Convert.ToString(reader["frontphotopath"]);
paintings.BackPhotoPath=Convert.ToString(reader["backphotopath"]);
paintings.BeforeRestorationImagePath=Convert.ToString(reader["beforerestorationimagepath"]);
paintings.AfterRestorationImagePath=Convert.ToString(reader["afterrestorationimagepath"]);
paintings.LastRestorationDate=Convert.ToString(reader["lastrestorationdate"]);
paintings.DrawerNumber=Convert.ToString(reader["drawernumber"]);
paintings.CurrentLocation=Convert.ToString(reader["currentlocation"]);
paintings.LocalLocation=Convert.ToString(reader["locallocation"]);
paintings.TagTitle=Convert.ToString(reader["tagtitle"]);
paintings.Tag=Convert.ToString(reader["tag"]);
paintings.TagDescription=Convert.ToString(reader["tagdescription"]);
paintings.Object=Convert.ToString(reader["object"]);
paintings.Copy=Convert.ToString(reader["copy"]);
paintings.CreatedDate=Convert.ToString(reader["createddate"]);
paintings.ModifiedDate=Convert.ToString(reader["modifieddate"]);
paintings.CultureGroup=Convert.ToString(reader["culturegroup"]);
paintings.DatePosition=Convert.ToString(reader["dateposition"]);
paintings.Style=Convert.ToString(reader["style"]);
paintings.Movement=Convert.ToString(reader["movement"]);
paintings.Period=Convert.ToString(reader["period"]);
paintings.SignaturePosition=Convert.ToString(reader["signatureposition"]);
paintings.SignaturePath=Convert.ToString(reader["signaturepath"]);
paintings.SinatureDescription=Convert.ToString(reader["sinaturedescription"]);
paintings.MarkedPosition=Convert.ToString(reader["markedposition"]);
paintings.MarkedPath=Convert.ToString(reader["markedpath"]);
paintings.ProcessNumber=Convert.ToString(reader["processnumber"]);
paintings.WayOfAcquisition=Convert.ToString(reader["wayofacquisition"]);
paintings.DateOfAcquisition=Convert.ToString(reader["dateofacquisition"]);
paintings.PurchasePrice=Convert.ToString(reader["purchaseprice"]);
paintings.InsuranceValue=Convert.ToString(reader["insurancevalue"]);
paintings.Publisher=Convert.ToString(reader["publisher"]);
paintings.Edition=Convert.ToString(reader["edition"]);
paintings.EditionNumber=Convert.ToString(reader["editionnumber"]);
paintings.TypeOfAge=Convert.ToString(reader["typeofage"]);
paintings.Category=Convert.ToString(reader["category"]);
paintings.ProviderName=Convert.ToString(reader["providername"]);
paintings.FrameHeight=Convert.ToString(reader["frameheight"]);
paintings.FrameWidth=Convert.ToString(reader["framewidth"]);
paintings.FrameDepth=Convert.ToString(reader["framedepth"]);
paintings.FrameWeight=Convert.ToString(reader["frameweight"]);
paintings.FrameShape=Convert.ToString(reader["frameshape"]);
paintings.PrintedAreaHeight=Convert.ToString(reader["printedareaheight"]);
paintings.PrintedAreaWidth=Convert.ToString(reader["printedareawidth"]);
paintings.PrintedAreaDepth=Convert.ToString(reader["printedareadepth"]);
paintings.PrintedAreaWeight=Convert.ToString(reader["printedareaweight"]);
paintings.PrintedAreaShape=Convert.ToString(reader["printedareashape"]);
paintings.FormalDescription=Convert.ToString(reader["formaldescription"]);
paintings.ContentDescription=Convert.ToString(reader["contentdescription"]);
paintings.KeywordsDescription=Convert.ToString(reader["keywordsdescription"]);
paintings.ExOwner=Convert.ToString(reader["exowner"]);
paintings.Exhibition=Convert.ToString(reader["exhibition"]);
paintings.Reference=Convert.ToString(reader["reference"]);
paintings.Notes=Convert.ToString(reader["notes"]);
paintings.PaintingViewCount=Convert.ToInt32(reader["paintingviewcount"]);
paintings.ModifiedBy=Convert.ToInt32(reader["modifiedby"]);
paintings.CreatedBy=Convert.ToInt32(reader["createdby"]);
paintings.IsPhotoAvailable=Convert.ToBoolean(reader["isphotoavailable"]);
paintings.IsRestored=Convert.ToBoolean(reader["isrestored"]);
paintings.IsInTheStore=Convert.ToBoolean(reader["isinthestore"]);
paintings.IsSignatureAvailable=Convert.ToBoolean(reader["issignatureavailable"]);
paintings.IsMarked=Convert.ToBoolean(reader["ismarked"]);
lstpaintings.Add(paintings);
}
reader.Close();
if (con.State == System.Data.ConnectionState.Open)
con.Close();
cmd.Dispose();
 return lstpaintings;}


}

}
