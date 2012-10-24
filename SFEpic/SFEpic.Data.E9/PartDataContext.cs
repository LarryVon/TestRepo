using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data.E9
{
    [Serializable()]
    public class PartDataContext : SFEpic.Data.DataContext
    {
        public PartDataContext() : base() { }

        public ECORev GetECORev(string companyNum, string partNum, string revisionNum)
        {
            return ECORev.FillByPartRev(this, companyNum, partNum, revisionNum, new string[] { Schema.ECORev.CompanyNum, Schema.ECORev.PartNum, Schema.ECORev.RevisionNum, Schema.ECORev.CheckedOut });
        }

        public OpMasDtl GetOpMasDtl(string companyNum)
        {
            return OpMasDtl.FillByCompanyNum(this, companyNum);
        }

        public OpMasDtl GetOpMasDtl(string companyNum, string opCode)
        {
            return OpMasDtl.FillByOpCode(this, companyNum, opCode);
        }

        public OpMaster GetOpMaster(string companyNum)
        {
            return OpMaster.FillByCompanyNum(this, companyNum, Schema.OpMaster.CompanyNum, Schema.OpMaster.OpCode, Schema.OpMaster.OpDesc, Schema.OpMaster.PrimaryProdOpDtl, Schema.OpMaster.PrimarySetupOpDtl);
        }

        public OpMaster GetOpMaster(string companyNum, string opCode)
        {
            return OpMaster.FillByOpCode(this, companyNum, opCode, Schema.OpMaster.CompanyNum, Schema.OpMaster.OpCode, Schema.OpMaster.OpDesc, Schema.OpMaster.PrimaryProdOpDtl, Schema.OpMaster.PrimarySetupOpDtl);
        }

        public Part GetPart(string companyNum)
        {
            return Part.FillByCompanyNum(this, companyNum, new string[] { Schema.Part.CompanyNum, Schema.Part.PartNum, Schema.Part.IUM, Schema.Part.UOMClassID });
        }

        public Part GetPart(string companyNum, string partNum)
        {
            return Part.FillByPartNum(this, companyNum, partNum, new string[] { Schema.Part.CompanyNum, Schema.Part.PartNum, Schema.Part.IUM, Schema.Part.UOMClassID });
        }

        public PartCost GetPartCost(string companyNum, string partNum)
        {
            return PartCost.FillByPartNum(this, companyNum, partNum, new string[] { Schema.PartCost.CompanyNum, Schema.PartCost.PartNum, Schema.PartCost.CostID });
        }

        public PartMtl GetPartMtl(string companyNum, string partNum, string revisionNum)
        {
            return PartMtl.FillByPartNum(this, companyNum, partNum, Schema.PartMtl.CompanyNum, Schema.PartMtl.PartNum, Schema.PartMtl.RevisionNum, Schema.PartMtl.AltMethod, Schema.PartMtl.MtlSeq);
        }

        public PartPlant GetPartPlant(string companyNum, string partNum)
        {
            return PartPlant.FillByPartNum(this, companyNum, partNum, Schema.PartPlant.CompanyNum, Schema.PartPlant.PartNum, Schema.PartPlant.PlantNum);
        }

        public PartPlant GetPartPlant(string companyNum, string partNum, string plantNum)
        {
            return PartPlant.FillByPlantNum(this, companyNum, partNum, plantNum, Schema.PartPlant.CompanyNum, Schema.PartPlant.PartNum, Schema.PartPlant.PlantNum);
        }

        public PartRev GetPartRev(string companyNum)
        {
            return PartRev.FillByCompanyNum(this, companyNum, new string[] { Schema.PartRev.CompanyNum, Schema.PartRev.PartNum, Schema.PartRev.RevisionNum, Schema.PartRev.Approved, Schema.PartRev.ApprovedDate, Schema.PartRev.EffectiveDate });
        }

        public PartRev GetPartRev(string companyNum, string partNum)
        {
            return PartRev.FillByPartNum(this, companyNum, partNum, new string[] { Schema.PartRev.CompanyNum, Schema.PartRev.PartNum, Schema.PartRev.RevisionNum, Schema.PartRev.Approved, Schema.PartRev.ApprovedDate, Schema.PartRev.EffectiveDate });
        }

        public PartRev GetPartRev(string companyNum, string partNum, string revisionNum)
        {
            return PartRev.FillByRevisionNum(this, companyNum, partNum, revisionNum, new string[] { Schema.PartRev.CompanyNum, Schema.PartRev.PartNum, Schema.PartRev.RevisionNum, Schema.PartRev.Approved, Schema.PartRev.ApprovedDate, Schema.PartRev.EffectiveDate });
        }

        public PartUOM GetPartUOM(string companyNum, string partNum)
        {
            return PartUOM.FillByPartNum(this, companyNum, partNum, Schema.PartUOM.CompanyNum, Schema.PartUOM.PartNum);
        }

        public PartWhse GetPartWhse(string companyNum, string partNum, string warehouseCode)
        {
            return PartWhse.FillByWarehouseCode(this, companyNum, partNum, warehouseCode, Schema.PartWhse.CompanyNum, Schema.PartWhse.PartNum, Schema.PartWhse.WarehouseCode);
        }

        public PlantWhse GetPlantWhse(string companyNum, string plantNum, string partNum, string warehouseCode)
        {
            return PlantWhse.FillByWarehouseCode(this, companyNum, plantNum, partNum, warehouseCode, Schema.PlantWhse.CompanyNum, Schema.PlantWhse.PlantNum, Schema.PlantWhse.PartNum, Schema.PlantWhse.WarehouseCode);
        }

        public ResourceGroup GetResourceGroup(string companyNum)
        {
            return ResourceGroup.FillByCompanyNum(this, companyNum, Schema.ResourceGroup.CompanyNum, Schema.ResourceGroup.ResourceGrpID, Schema.ResourceGroup.Description);
        }

        public ResourceGroup GetResourceGroup(string companyNum, string resourceGrpID)
        {
            return ResourceGroup.FillByResourceGrpID(this, companyNum, resourceGrpID, Schema.ResourceGroup.CompanyNum, Schema.ResourceGroup.ResourceGrpID, Schema.ResourceGroup.Description);
        }

        public UOM GetUOM(string companyNum)
        {
            return UOM.FillByCompanyNum(this, companyNum, new string[] { Schema.UOM.CompanyNum, Schema.UOM.UOMCode });
        }

        public UOM GetUOM(string companyNum, string uomCode)
        {
            return UOM.FillByUOMCode(this, companyNum, uomCode, new string[] { Schema.UOM.CompanyNum, Schema.UOM.UOMCode });
        }

        public UOMClass GetUOMClass(string companyNum, string uomClassID)
        {
            return UOMClass.FillByUOMClassID(this, companyNum, uomClassID, Schema.UOMClass.CompanyNum, Schema.UOMClass.UOMClassID, Schema.UOMClass.Active, Schema.UOMClass.BaseUOMCode, Schema.UOMClass.DefUomCode);
        }

        public UOMConv GetUOMConv(string companyNum, string uomClassID)
        {
            return UOMConv.FillByUOMClassID(this, companyNum, uomClassID, Schema.UOMConv.CompanyNum, Schema.UOMConv.UOMClassID, Schema.UOMConv.UOMCode, Schema.UOMConv.ConvFactor, Schema.UOMConv.ConvOperator, Schema.UOMConv.Active);
        }

        public UOMConv GetUOMConvByUOMCode(string companyNum, string uomCode)
        {
            return UOMConv.FillByUOMCodeOnly(this, companyNum, uomCode, Schema.UOMConv.CompanyNum, Schema.UOMConv.UOMClassID, Schema.UOMConv.UOMCode, Schema.UOMConv.ConvFactor, Schema.UOMConv.ConvOperator, Schema.UOMConv.Active);
        }

        public UOMConv GetUOMConv(string companyNum, string uomClassID, string uomCode)
        {
            return UOMConv.FillByUOMCode(this, companyNum, uomClassID, uomCode, Schema.UOMConv.CompanyNum, Schema.UOMConv.UOMClassID, Schema.UOMConv.UOMCode, Schema.UOMConv.ConvFactor, Schema.UOMConv.ConvOperator, Schema.UOMConv.Active);
        }

        public Part NewPart()
        {
            return Part.GetEmpty(this);
        }

        public PartBin NewPartBin()
        {
            return PartBin.GetEmpty(this);
        }

        public PartCost NewPartCost()
        {
            return PartCost.GetEmpty(this);
        }

        public PartMtl NewPartMtl()
        {
            return PartMtl.GetEmpty(this);
        }

        public PartOpDtl NewPartOpDtl()
        {
            return PartOpDtl.GetEmpty(this);
        }

        public PartOpr NewPartOpr()
        {
            return PartOpr.GetEmpty(this);
        }

        public PartPlant NewPartPlant()
        {
            return PartPlant.GetEmpty(this);
        }

        public PartRev NewPartRev()
        {
            return PartRev.GetEmpty(this);
        }

        public PartUOM NewPartUOM()
        {
            return PartUOM.GetEmpty(this);
        }

        public PartWhse NewPartWhse()
        {
            return PartWhse.GetEmpty(this);
        }

        public PlantWhse NewPlantWhse()
        {
            return PlantWhse.GetEmpty(this);
        }
    }
}
