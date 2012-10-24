using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Data;

namespace SFEpic.Data.V8
{
    [Serializable()]
    public partial class V8Schema : SFEpic.Data.DbSchema
    {
        protected V8Schema()
            : base("V8Schema")
        {
        }

        protected static V8Schema instance;
        public static V8Schema Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new V8Schema();
                }
                return instance;
            }
        }

        #region Schema Table Names

        public const string Company = "Company";
        public const string Part = "Part";
        public const string PODetail = "PODetail";
        public const string POHeader = "POHeader";
        public const string PORel = "PORel";
        public const string PurAgent = "PurAgent";
        public const string Vendor = "Vendor";
        public const string VendorPP = "VendorPP";

        #endregion

        protected virtual Schema.Company GetCompanySchemaTable()
        {
            return new Schema.Company();
        }

        protected virtual Schema.Part GetPartSchemaTable()
        {
            return new Schema.Part();
        }

        protected virtual Schema.PODetail GetPODetailSchemaTable()
        {
            return new Schema.PODetail();
        }

        protected virtual Schema.POHeader GetPOHeaderSchemaTable()
        {
            return new Schema.POHeader();
        }

        protected virtual Schema.PORel GetPORelSchemaTable()
        {
            return new Schema.PORel();
        }

        protected virtual Schema.PurAgent GetPurAgentSchemaTable()
        {
            return new Schema.PurAgent();
        }

        protected virtual Schema.Vendor GetVendorSchemaTable()
        {
            return new Schema.Vendor();
        }

        protected virtual Schema.VendorPP GetVendorPPSchemaTable()
        {
            return new Schema.VendorPP();
        }

        protected override void InitTablesCore()
        {
            tablesList.Add(GetCompanySchemaTable());
            tablesList.Add(GetPartSchemaTable());
            tablesList.Add(GetPODetailSchemaTable());
            tablesList.Add(GetPOHeaderSchemaTable());
            tablesList.Add(GetPORelSchemaTable());
            tablesList.Add(GetPurAgentSchemaTable());
            tablesList.Add(GetVendorSchemaTable());
            tablesList.Add(GetVendorPPSchemaTable());
        }
    }

    namespace Schema
    {
        [Serializable()]
        public partial class Company : SFEpic.Data.SchemaTable
        {
            public Company()
                : base("Company")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "Company.CompanyNum";
            public const string Name = "Company.Name";
            public const string Address1 = "Company.Address1";
            public const string Address2 = "Company.Address2";
            public const string City = "Company.City";
            public const string Country = "Company.Country";
            public const string FaxNum = "Company.FaxNum";
            public const string PhoneNum = "Company.PhoneNum";
            public const string State = "Company.State";
            public const string Zip = "Company.Zip";
            public const string FEIN = "Company.FEIN";
            public const string StateTaxID = "Company.StateTaxID";
            public const string CurrentFiscalYear = "Company.CurrentFiscalYear";
            public const string Address3 = "Company.Address3";
            public const string EDICode = "Company.EDICode";
            public const string TaxRegionCode = "Company.TaxRegionCode";
            public const string CountryNum = "Company.CountryNum";
            public const string Number = "Company.Number";
            public const string FRxDSN = "Company.FRxDSN";
            public const string EschedFileSet = "Company.EschedFileSet";
            public const string EMailLinkPort = "Company.EMailLinkPort";
            public const string MfgSys = "Company.MfgSys";
            public const string ExternalID = "Company.ExternalID";
            public const string SerialNum = "Company.SerialNum";
            public const string EmailFromAddr = "Company.EmailFromAddr";
            public const string EmailFromLabel = "Company.EmailFromLabel";
            public const string SMTPServer = "Company.SMTPServer";
            public const string SMTPPort = "Company.SMTPPort";
            public const string LogoFile = "Company.LogoFile";
            public const string EmpPhotoPath = "Company.EmpPhotoPath";
            public const string CalendarID = "Company.CalendarID";
            public const string AuxMailAddr = "Company.AuxMailAddr";
            public const string FrxUserid = "Company.FrxUserid";
            public const string FRxPassWord = "Company.FRxPassWord";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 100, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address1", 100, schemaColumnName: "Address1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address2", 100, schemaColumnName: "Address2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "City", 100, schemaColumnName: "City", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Country", 100, schemaColumnName: "Country", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FaxNum", 40, schemaColumnName: "FaxNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PhoneNum", 40, schemaColumnName: "PhoneNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "State", 100, schemaColumnName: "State", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Zip", 20, schemaColumnName: "Zip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FEIN", 24, schemaColumnName: "FEIN", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "StateTaxID", 40, schemaColumnName: "StateTaxID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CurrentFiscalYear", schemaColumnName: "CurrentFiscalYear", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address3", 100, schemaColumnName: "Address3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxRegionCode", 8, schemaColumnName: "TaxRegionCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountryNum", schemaColumnName: "CountryNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "Number", schemaColumnName: "Number", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FRxDSN", 40, schemaColumnName: "FRxDSN", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EschedFileSet", 16, schemaColumnName: "EschedFileSet", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailLinkPort", 80, schemaColumnName: "EMailLinkPort", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MfgSys", 16, schemaColumnName: "MfgSys", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExternalID", 40, schemaColumnName: "ExternalID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SerialNum", 25, 0, schemaColumnName: "SerialNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EmailFromAddr", 100, schemaColumnName: "EmailFromAddr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EmailFromLabel", 100, schemaColumnName: "EmailFromLabel", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SMTPServer", 100, schemaColumnName: "SMTPServer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SMTPPort", schemaColumnName: "SMTPPort", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LogoFile", 100, schemaColumnName: "LogoFile", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EmpPhotoPath", 160, schemaColumnName: "EmpPhotoPath", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CalendarID", 16, schemaColumnName: "CalendarID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AuxMailAddr", 512, schemaColumnName: "AuxMailAddr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FrxUserid", 40, schemaColumnName: "FrxUserid", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FRxPassWord", 40, schemaColumnName: "FRxPassWord", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["Company.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class Part : SFEpic.Data.SchemaTable
        {
            public Part()
                : base("Part")
            {
            }

            #region Field Name Constants

            public const string PartNum = "Part.PartNum";
            public const string PartDescription = "Part.PartDescription";
            public const string ProdCode = "Part.ProdCode";
            public const string ClassID = "Part.ClassID";
            public const string IUM = "Part.IUM";
            public const string PUM = "Part.PUM";
            public const string TypeCode = "Part.TypeCode";
            public const string PurchasingFactor = "Part.PurchasingFactor";
            public const string PricePerCode = "Part.PricePerCode";
            public const string ExpenseChart = "Part.ExpenseChart";
            public const string ExpenseDiv = "Part.ExpenseDiv";
            public const string UnitPrice = "Part.UnitPrice";
            public const string TrackLots = "Part.TrackLots";
            public const string ExpenseDept = "Part.ExpenseDept";
            public const string LowLevelCode = "Part.LowLevelCode";
            public const string SearchWord = "Part.SearchWord";
            public const string MfgComment = "Part.MfgComment";
            public const string Method = "Part.Method";
            public const string PurComment = "Part.PurComment";
            public const string CompanyNum = "Part.CompanyNum";
            public const string CostMethod = "Part.CostMethod";
            public const string UserChar1 = "Part.UserChar1";
            public const string UserChar2 = "Part.UserChar2";
            public const string UserChar3 = "Part.UserChar3";
            public const string UserChar4 = "Part.UserChar4";
            public const string UserDate1 = "Part.UserDate1";
            public const string UserDate2 = "Part.UserDate2";
            public const string UserDate3 = "Part.UserDate3";
            public const string UserDate4 = "Part.UserDate4";
            public const string UserDecimal1 = "Part.UserDecimal1";
            public const string UserDecimal2 = "Part.UserDecimal2";
            public const string UserInteger1 = "Part.UserInteger1";
            public const string UserInteger2 = "Part.UserInteger2";
            public const string NonStock = "Part.NonStock";
            public const string TaxCatID = "Part.TaxCatID";
            public const string UserDecimal3 = "Part.UserDecimal3";
            public const string UserDecimal4 = "Part.UserDecimal4";
            public const string InActive = "Part.InActive";
            public const string TrackDimension = "Part.TrackDimension";
            public const string DefaultDim = "Part.DefaultDim";
            public const string TrackSerialNum = "Part.TrackSerialNum";
            public const string CommodityCode = "Part.CommodityCode";
            public const string WarrantyCode = "Part.WarrantyCode";
            public const string InternalUnitPrice = "Part.InternalUnitPrice";
            public const string InternalPricePerCode = "Part.InternalPricePerCode";
            public const string PhantomBOM = "Part.PhantomBOM";
            public const string SalesUM = "Part.SalesUM";
            public const string SellingFactor = "Part.SellingFactor";
            public const string MtlBurRate = "Part.MtlBurRate";
            public const string WholeUnit = "Part.WholeUnit";
            public const string NetWeight = "Part.NetWeight";
            public const string UsePartRev = "Part.UsePartRev";
            public const string PartsPerContainer = "Part.PartsPerContainer";
            public const string PartLength = "Part.PartLength";
            public const string PartWidth = "Part.PartWidth";
            public const string PartHeight = "Part.PartHeight";
            public const string LotShelfLife = "Part.LotShelfLife";
            public const string WebPart = "Part.WebPart";
            public const string RunOut = "Part.RunOut";
            public const string SubPart = "Part.SubPart";
            public const string Diameter = "Part.Diameter";
            public const string Gravity = "Part.Gravity";
            public const string OnHold = "Part.OnHold";
            public const string OnHoldDate = "Part.OnHoldDate";
            public const string OnHoldReasonCode = "Part.OnHoldReasonCode";
            public const string AnalysisCode = "Part.AnalysisCode";
            public const string GlobalPart = "Part.GlobalPart";
            public const string Mtl_AnalysisCode = "Part.Mtl_AnalysisCode";
            public const string ISSuppUnitsFactor = "Part.ISSuppUnitsFactor";
            public const string GlobalLock = "Part.GlobalLock";
            public const string PDMObjID = "Part.PDMObjID";
            public const string ImageFileName = "Part.ImageFileName";
            public const string SNRequiredWhenIn = "Part.SNRequiredWhenIn";
            public const string ISOrigCountry = "Part.ISOrigCountry";
            public const string SNFormat = "Part.SNFormat";
            public const string SNPrefix = "Part.SNPrefix";
            public const string SNBaseDataType = "Part.SNBaseDataType";
            public const string Constrained = "Part.Constrained";
            public const string UPCCode1 = "Part.UPCCode1";
            public const string UPCCode2 = "Part.UPCCode2";
            public const string UPCCode3 = "Part.UPCCode3";
            public const string EDICode = "Part.EDICode";
            public const string ConsolidatedPurchasing = "Part.ConsolidatedPurchasing";
            public const string WebInStock = "Part.WebInStock";
            public const string PurchasingFactorDirection = "Part.PurchasingFactorDirection";
            public const string SellingFactorDirection = "Part.SellingFactorDirection";
            public const string MDPV = "Part.MDPV";
            public const string ReturnableContainer = "Part.ReturnableContainer";
            public const string RecDocReq = "Part.RecDocReq";
            public const string ShipDocReq = "Part.ShipDocReq";
            public const string NetVolume = "Part.NetVolume";
            public const string QtyBearing = "Part.QtyBearing";
            public const string HazSub = "Part.HazSub";
            public const string HazGvrnmtID = "Part.HazGvrnmtID";
            public const string HazPackInstr = "Part.HazPackInstr";
            public const string NAFTAOrigCountry = "Part.NAFTAOrigCountry";
            public const string NAFTAProd = "Part.NAFTAProd";
            public const string NAFTAPref = "Part.NAFTAPref";
            public const string ExpLicType = "Part.ExpLicType";
            public const string ExpLicNumber = "Part.ExpLicNumber";
            public const string ECCNNumber = "Part.ECCNNumber";
            public const string AESExp = "Part.AESExp";
            public const string HTS = "Part.HTS";
            public const string UseHTSDesc = "Part.UseHTSDesc";
            public const string SchedBcode = "Part.SchedBcode";
            public const string HazItem = "Part.HazItem";
            public const string HazTechName = "Part.HazTechName";
            public const string HazClass = "Part.HazClass";
            public const string RevChargeMethod = "Part.RevChargeMethod";
            public const string RCUnderThreshold = "Part.RCUnderThreshold";
            public const string RCOverThreshold = "Part.RCOverThreshold";
            public const string OwnershipStatus = "Part.OwnershipStatus";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartDescription", 2000, schemaColumnName: "PartDescription", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ProdCode", 16, schemaColumnName: "ProdCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ClassID", 8, schemaColumnName: "ClassID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "IUM", 4, schemaColumnName: "IUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PUM", 4, schemaColumnName: "PUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TypeCode", 2, schemaColumnName: "TypeCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PurchasingFactor", 25, 4, schemaColumnName: "PurchasingFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PricePerCode", 2, schemaColumnName: "PricePerCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseChart", 100, schemaColumnName: "ExpenseChart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDiv", 100, schemaColumnName: "ExpenseDiv", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UnitPrice", 25, 5, schemaColumnName: "UnitPrice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackLots", schemaColumnName: "TrackLots", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDept", 100, schemaColumnName: "ExpenseDept", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LowLevelCode", schemaColumnName: "LowLevelCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SearchWord", 16, schemaColumnName: "SearchWord", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MfgComment", 2000, schemaColumnName: "MfgComment", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Method", schemaColumnName: "Method", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurComment", 2000, schemaColumnName: "PurComment", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CostMethod", 2, schemaColumnName: "CostMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar1", 60, schemaColumnName: "UserChar1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar2", 60, schemaColumnName: "UserChar2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar3", 60, schemaColumnName: "UserChar3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar4", 60, schemaColumnName: "UserChar4", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate1", schemaColumnName: "UserDate1", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate2", schemaColumnName: "UserDate2", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate3", schemaColumnName: "UserDate3", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate4", schemaColumnName: "UserDate4", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal1", 25, 2, schemaColumnName: "UserDecimal1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal2", 25, 2, schemaColumnName: "UserDecimal2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger1", schemaColumnName: "UserInteger1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger2", schemaColumnName: "UserInteger2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStock", schemaColumnName: "NonStock", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxCatID", 20, schemaColumnName: "TaxCatID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal3", 25, 5, schemaColumnName: "UserDecimal3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal4", 25, 5, schemaColumnName: "UserDecimal4", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "InActive", schemaColumnName: "InActive", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackDimension", schemaColumnName: "TrackDimension", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DefaultDim", 12, schemaColumnName: "DefaultDim", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackSerialNum", schemaColumnName: "TrackSerialNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommodityCode", 16, schemaColumnName: "CommodityCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarrantyCode", 16, schemaColumnName: "WarrantyCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "InternalUnitPrice", 25, 5, schemaColumnName: "InternalUnitPrice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InternalPricePerCode", 2, schemaColumnName: "InternalPricePerCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PhantomBOM", schemaColumnName: "PhantomBOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SalesUM", 4, schemaColumnName: "SalesUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SellingFactor", 25, 8, schemaColumnName: "SellingFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MtlBurRate", 25, 2, schemaColumnName: "MtlBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WholeUnit", schemaColumnName: "WholeUnit", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "NetWeight", 25, 5, schemaColumnName: "NetWeight", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UsePartRev", schemaColumnName: "UsePartRev", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PartsPerContainer", schemaColumnName: "PartsPerContainer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PartLength", 25, 5, schemaColumnName: "PartLength", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PartWidth", 25, 5, schemaColumnName: "PartWidth", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PartHeight", 25, 5, schemaColumnName: "PartHeight", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LotShelfLife", schemaColumnName: "LotShelfLife", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebPart", schemaColumnName: "WebPart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RunOut", schemaColumnName: "RunOut", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SubPart", 100, schemaColumnName: "SubPart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Diameter", 25, 5, schemaColumnName: "Diameter", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Gravity", 25, 5, schemaColumnName: "Gravity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OnHold", schemaColumnName: "OnHold", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "OnHoldDate", schemaColumnName: "OnHoldDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OnHoldReasonCode", 10, schemaColumnName: "OnHoldReasonCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AnalysisCode", 16, schemaColumnName: "AnalysisCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalPart", schemaColumnName: "GlobalPart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Mtl_AnalysisCode", 16, schemaColumnName: "Mtl-AnalysisCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ISSuppUnitsFactor", 25, 8, schemaColumnName: "ISSuppUnitsFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalLock", schemaColumnName: "GlobalLock", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PDMObjID", 16, schemaColumnName: "PDMObjID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ImageFileName", 512, schemaColumnName: "ImageFileName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNRequiredWhenIn", 48, schemaColumnName: "SNRequiredWhenIn", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ISOrigCountry", 12, schemaColumnName: "ISOrigCountry", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNFormat", 20, schemaColumnName: "SNFormat", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNPrefix", 60, schemaColumnName: "SNPrefix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNBaseDataType", 20, schemaColumnName: "SNBaseDataType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Constrained", schemaColumnName: "Constrained", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPCCode1", 40, schemaColumnName: "UPCCode1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPCCode2", 40, schemaColumnName: "UPCCode2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPCCode3", 40, schemaColumnName: "UPCCode3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPurchasing", schemaColumnName: "ConsolidatedPurchasing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebInStock", schemaColumnName: "WebInStock", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurchasingFactorDirection", 2, schemaColumnName: "PurchasingFactorDirection", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SellingFactorDirection", 2, schemaColumnName: "SellingFactorDirection", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "MDPV", schemaColumnName: "MDPV", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ReturnableContainer", 60, schemaColumnName: "ReturnableContainer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RecDocReq", schemaColumnName: "RecDocReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShipDocReq", schemaColumnName: "ShipDocReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "NetVolume", 20, 5, schemaColumnName: "NetVolume", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "QtyBearing", schemaColumnName: "QtyBearing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazSub", 16, schemaColumnName: "HazSub", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazGvrnmtID", 16, schemaColumnName: "HazGvrnmtID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazPackInstr", 2000, schemaColumnName: "HazPackInstr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NAFTAOrigCountry", 12, schemaColumnName: "NAFTAOrigCountry", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NAFTAProd", 16, schemaColumnName: "NAFTAProd", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NAFTAPref", 16, schemaColumnName: "NAFTAPref", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpLicType", 16, schemaColumnName: "ExpLicType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpLicNumber", 50, schemaColumnName: "ExpLicNumber", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ECCNNumber", 50, schemaColumnName: "ECCNNumber", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AESExp", 16, schemaColumnName: "AESExp", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HTS", 20, schemaColumnName: "HTS", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseHTSDesc", schemaColumnName: "UseHTSDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SchedBcode", 16, schemaColumnName: "SchedBcode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "HazItem", schemaColumnName: "HazItem", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazTechName", 80, schemaColumnName: "HazTechName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazClass", 16, schemaColumnName: "HazClass", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevChargeMethod", 16, schemaColumnName: "RevChargeMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RCUnderThreshold", 17, 2, schemaColumnName: "RCUnderThreshold", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RCOverThreshold", 17, 2, schemaColumnName: "RCOverThreshold", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OwnershipStatus", 16, schemaColumnName: "OwnershipStatus", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["Part.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["Part.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PODetail : SFEpic.Data.SchemaTable
        {
            public PODetail()
                : base("PODetail")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PODetail.CompanyNum";
            public const string VoidLine = "PODetail.VoidLine";
            public const string PONUM = "PODetail.PONUM";
            public const string Taxable = "PODetail.Taxable";
            public const string OrderQty = "PODetail.OrderQty";
            public const string IUM = "PODetail.IUM";
            public const string OpenLine = "PODetail.OpenLine";
            public const string POLine = "PODetail.POLine";
            public const string XOrderQty = "PODetail.XOrderQty";
            public const string UnitCost = "PODetail.UnitCost";
            public const string CommentText = "PODetail.CommentText";
            public const string PUM = "PODetail.PUM";
            public const string LineDesc = "PODetail.LineDesc";
            public const string PartNum = "PODetail.PartNum";
            public const string CostPerCode = "PODetail.CostPerCode";
            public const string VenPartNum = "PODetail.VenPartNum";
            public const string ClassID = "PODetail.ClassID";
            public const string RevisionNum = "PODetail.RevisionNum";
            public const string RcvInspectionReq = "PODetail.RcvInspectionReq";
            public const string DocUnitCost = "PODetail.DocUnitCost";
            public const string VendorNum = "PODetail.VendorNum";
            public const string AdvancePayBal = "PODetail.AdvancePayBal";
            public const string DocAdvancePayBal = "PODetail.DocAdvancePayBal";
            public const string Confirmed = "PODetail.Confirmed";
            public const string DateChgReq = "PODetail.DateChgReq";
            public const string QtyChgReq = "PODetail.QtyChgReq";
            public const string PartNumChgReq = "PODetail.PartNumChgReq";
            public const string RevisionNumChgReq = "PODetail.RevisionNumChgReq";
            public const string ConfirmDate = "PODetail.ConfirmDate";
            public const string ConfirmVia = "PODetail.ConfirmVia";
            public const string PrcChgReq = "PODetail.PrcChgReq";
            public const string PurchCode = "PODetail.PurchCode";
            public const string OrderNum = "PODetail.OrderNum";
            public const string OrderLine = "PODetail.OrderLine";
            public const string ExtCompany = "PODetail.ExtCompany";
            public const string Linked = "PODetail.Linked";
            public const string GlbCompany = "PODetail.GlbCompany";
            public const string ContractQty = "PODetail.ContractQty";
            public const string ContractUnitCost = "PODetail.ContractUnitCost";
            public const string ContractActive = "PODetail.ContractActive";
            public const string ContractDocUnitCost = "PODetail.ContractDocUnitCost";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "VoidLine", schemaColumnName: "VoidLine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PONUM", schemaColumnName: "PONUM", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Taxable", schemaColumnName: "Taxable", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "OrderQty", 25, 2, schemaColumnName: "OrderQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "IUM", 4, schemaColumnName: "IUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OpenLine", schemaColumnName: "OpenLine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "POLine", schemaColumnName: "POLine", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "XOrderQty", 25, 2, schemaColumnName: "XOrderQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UnitCost", 25, 5, schemaColumnName: "UnitCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommentText", 2000, schemaColumnName: "CommentText", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PUM", 4, schemaColumnName: "PUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LineDesc", 2000, schemaColumnName: "LineDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CostPerCode", 2, schemaColumnName: "CostPerCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VenPartNum", 100, schemaColumnName: "VenPartNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ClassID", 8, schemaColumnName: "ClassID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RcvInspectionReq", schemaColumnName: "RcvInspectionReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DocUnitCost", 25, 5, schemaColumnName: "DocUnitCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AdvancePayBal", 25, 2, schemaColumnName: "AdvancePayBal", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DocAdvancePayBal", 25, 2, schemaColumnName: "DocAdvancePayBal", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Confirmed", schemaColumnName: "Confirmed", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DateChgReq", schemaColumnName: "DateChgReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "QtyChgReq", schemaColumnName: "QtyChgReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNumChgReq", 100, schemaColumnName: "PartNumChgReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNumChgReq", 24, schemaColumnName: "RevisionNumChgReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ConfirmDate", schemaColumnName: "ConfirmDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConfirmVia", 16, schemaColumnName: "ConfirmVia", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PrcChgReq", 25, 5, schemaColumnName: "PrcChgReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurchCode", 16, schemaColumnName: "PurchCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderNum", schemaColumnName: "OrderNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderLine", schemaColumnName: "OrderLine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExtCompany", 16, schemaColumnName: "ExtCompany", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Linked", schemaColumnName: "Linked", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbCompany", 16, schemaColumnName: "GlbCompany", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ContractQty", 17, 2, schemaColumnName: "ContractQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ContractUnitCost", 17, 5, schemaColumnName: "ContractUnitCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ContractActive", schemaColumnName: "ContractActive", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ContractDocUnitCost", 17, 5, schemaColumnName: "ContractDocUnitCost", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PODetail.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PODetail.PONUM"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PODetail.POLine"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class POHeader : SFEpic.Data.SchemaTable
        {
            public POHeader()
                : base("POHeader")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "POHeader.CompanyNum";
            public const string EntryPerson = "POHeader.EntryPerson";
            public const string FOB = "POHeader.FOB";
            public const string ShipAddress3 = "POHeader.ShipAddress3";
            public const string OrderDate = "POHeader.OrderDate";
            public const string PONum = "POHeader.PONum";
            public const string ShipCountry = "POHeader.ShipCountry";
            public const string CommentText = "POHeader.CommentText";
            public const string PrcConNum = "POHeader.PrcConNum";
            public const string VendorNum = "POHeader.VendorNum";
            public const string ShipName = "POHeader.ShipName";
            public const string PurPoint = "POHeader.PurPoint";
            public const string ShipState = "POHeader.ShipState";
            public const string ShipViaCode = "POHeader.ShipViaCode";
            public const string ShipZIP = "POHeader.ShipZIP";
            public const string TermsCode = "POHeader.TermsCode";
            public const string OrderHeld = "POHeader.OrderHeld";
            public const string OpenOrder = "POHeader.OpenOrder";
            public const string BuyerID = "POHeader.BuyerID";
            public const string UserChar1 = "POHeader.UserChar1";
            public const string FreightPP = "POHeader.FreightPP";
            public const string UserChar2 = "POHeader.UserChar2";
            public const string UserChar3 = "POHeader.UserChar3";
            public const string VoidOrder = "POHeader.VoidOrder";
            public const string UserChar4 = "POHeader.UserChar4";
            public const string ShipAddress1 = "POHeader.ShipAddress1";
            public const string ShipAddress2 = "POHeader.ShipAddress2";
            public const string ShipCity = "POHeader.ShipCity";
            public const string UserDate1 = "POHeader.UserDate1";
            public const string UserDate2 = "POHeader.UserDate2";
            public const string UserDate3 = "POHeader.UserDate3";
            public const string UserDate4 = "POHeader.UserDate4";
            public const string UserDecimal1 = "POHeader.UserDecimal1";
            public const string UserDecimal2 = "POHeader.UserDecimal2";
            public const string UserInteger1 = "POHeader.UserInteger1";
            public const string UserInteger2 = "POHeader.UserInteger2";
            public const string ShipToConName = "POHeader.ShipToConName";
            public const string ReadyToPrint = "POHeader.ReadyToPrint";
            public const string PrintAs = "POHeader.PrintAs";
            public const string CurrencyCode = "POHeader.CurrencyCode";
            public const string ExchangeRate = "POHeader.ExchangeRate";
            public const string LockRate = "POHeader.LockRate";
            public const string RefCode = "POHeader.RefCode";
            public const string DocToRef = "POHeader.DocToRef";
            public const string RefToBase = "POHeader.RefToBase";
            public const string RefToBaseRate = "POHeader.RefToBaseRate";
            public const string ShipCountryNum = "POHeader.ShipCountryNum";
            public const string LogChanges = "POHeader.LogChanges";
            public const string ApprovedDate = "POHeader.ApprovedDate";
            public const string ApprovedBy = "POHeader.ApprovedBy";
            public const string Approve = "POHeader.Approve";
            public const string ApprovalStatus = "POHeader.ApprovalStatus";
            public const string ApprovedAmount = "POHeader.ApprovedAmount";
            public const string PostDate = "POHeader.PostDate";
            public const string ConfirmReq = "POHeader.ConfirmReq";
            public const string Confirmed = "POHeader.Confirmed";
            public const string ConfirmVia = "POHeader.ConfirmVia";
            public const string PostToWeb = "POHeader.PostToWeb";
            public const string OrderNum = "POHeader.OrderNum";
            public const string LegalNumber = "POHeader.LegalNumber";
            public const string VendorRefNum = "POHeader.VendorRefNum";
            public const string ExtCompany = "POHeader.ExtCompany";
            public const string Linked = "POHeader.Linked";
            public const string XRefPONum = "POHeader.XRefPONum";
            public const string ConsolidatedPO = "POHeader.ConsolidatedPO";
            public const string GlbCompany = "POHeader.GlbCompany";
            public const string ContractStartDate = "POHeader.ContractStartDate";
            public const string ContractEndDate = "POHeader.ContractEndDate";
            public const string ContractOrder = "POHeader.ContractOrder";
            public const string PrintHeaderAddress = "POHeader.PrintHeaderAddress";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EntryPerson", 40, schemaColumnName: "EntryPerson", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FOB", 30, schemaColumnName: "FOB", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipAddress3", 100, schemaColumnName: "ShipAddress3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "OrderDate", schemaColumnName: "OrderDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PONum", schemaColumnName: "PONum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipCountry", 100, schemaColumnName: "ShipCountry", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommentText", 2000, schemaColumnName: "CommentText", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrcConNum", schemaColumnName: "PrcConNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipName", 100, schemaColumnName: "ShipName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipState", 100, schemaColumnName: "ShipState", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipViaCode", 8, schemaColumnName: "ShipViaCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipZIP", 20, schemaColumnName: "ShipZIP", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TermsCode", 8, schemaColumnName: "TermsCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OrderHeld", schemaColumnName: "OrderHeld", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OpenOrder", schemaColumnName: "OpenOrder", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BuyerID", 16, schemaColumnName: "BuyerID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar1", 60, schemaColumnName: "UserChar1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "FreightPP", schemaColumnName: "FreightPP", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar2", 60, schemaColumnName: "UserChar2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar3", 60, schemaColumnName: "UserChar3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "VoidOrder", schemaColumnName: "VoidOrder", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar4", 60, schemaColumnName: "UserChar4", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipAddress1", 100, schemaColumnName: "ShipAddress1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipAddress2", 100, schemaColumnName: "ShipAddress2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipCity", 100, schemaColumnName: "ShipCity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate1", schemaColumnName: "UserDate1", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate2", schemaColumnName: "UserDate2", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate3", schemaColumnName: "UserDate3", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate4", schemaColumnName: "UserDate4", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal1", 25, 2, schemaColumnName: "UserDecimal1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal2", 25, 2, schemaColumnName: "UserDecimal2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger1", schemaColumnName: "UserInteger1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger2", schemaColumnName: "UserInteger2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipToConName", 100, schemaColumnName: "ShipToConName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ReadyToPrint", schemaColumnName: "ReadyToPrint", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PrintAs", 2, schemaColumnName: "PrintAs", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CurrencyCode", 8, schemaColumnName: "CurrencyCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ExchangeRate", 25, 10, schemaColumnName: "ExchangeRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LockRate", schemaColumnName: "LockRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCode", 8, schemaColumnName: "RefCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DocToRef", schemaColumnName: "DocToRef", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RefToBase", schemaColumnName: "RefToBase", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RefToBaseRate", 25, 6, schemaColumnName: "RefToBaseRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ShipCountryNum", schemaColumnName: "ShipCountryNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LogChanges", schemaColumnName: "LogChanges", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ApprovedDate", schemaColumnName: "ApprovedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovedBy", 40, schemaColumnName: "ApprovedBy", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Approve", schemaColumnName: "Approve", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovalStatus", 2, schemaColumnName: "ApprovalStatus", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ApprovedAmount", 25, 2, schemaColumnName: "ApprovedAmount", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "PostDate", schemaColumnName: "PostDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConfirmReq", schemaColumnName: "ConfirmReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Confirmed", schemaColumnName: "Confirmed", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConfirmVia", 16, schemaColumnName: "ConfirmVia", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PostToWeb", schemaColumnName: "PostToWeb", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderNum", schemaColumnName: "OrderNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LegalNumber", 40, schemaColumnName: "LegalNumber", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VendorRefNum", 60, schemaColumnName: "VendorRefNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExtCompany", 16, schemaColumnName: "ExtCompany", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Linked", schemaColumnName: "Linked", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "XRefPONum", 100, schemaColumnName: "XRefPONum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPO", schemaColumnName: "ConsolidatedPO", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbCompany", 16, schemaColumnName: "GlbCompany", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ContractStartDate", schemaColumnName: "ContractStartDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ContractEndDate", schemaColumnName: "ContractEndDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ContractOrder", schemaColumnName: "ContractOrder", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrintHeaderAddress", schemaColumnName: "PrintHeaderAddress", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["POHeader.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["POHeader.PONum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PORel : SFEpic.Data.SchemaTable
        {
            public PORel()
                : base("PORel")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PORel.CompanyNum";
            public const string POLine = "PORel.POLine";
            public const string PONum = "PORel.PONum";
            public const string RelQty = "PORel.RelQty";
            public const string DueDate = "PORel.DueDate";
            public const string PORelNum = "PORel.PORelNum";
            public const string OpenRelease = "PORel.OpenRelease";
            public const string VoidRelease = "PORel.VoidRelease";
            public const string JobNum = "PORel.JobNum";
            public const string AssemblySeq = "PORel.AssemblySeq";
            public const string JobSeqType = "PORel.JobSeqType";
            public const string JobSeq = "PORel.JobSeq";
            public const string WarehouseCode = "PORel.WarehouseCode";
            public const string ReceivedQty = "PORel.ReceivedQty";
            public const string XRelQty = "PORel.XRelQty";
            public const string PurchasingFactor = "PORel.PurchasingFactor";
            public const string ExpDivision = "PORel.ExpDivision";
            public const string ExpGLDept = "PORel.ExpGLDept";
            public const string ExpChart = "PORel.ExpChart";
            public const string ExpOverride = "PORel.ExpOverride";
            public const string ReqNum = "PORel.ReqNum";
            public const string ReqLine = "PORel.ReqLine";
            public const string PlantNum = "PORel.PlantNum";
            public const string PromiseDt = "PORel.PromiseDt";
            public const string ProjectID = "PORel.ProjectID";
            public const string ReqChgDate = "PORel.ReqChgDate";
            public const string Confirmed = "PORel.Confirmed";
            public const string ReqChgQty = "PORel.ReqChgQty";
            public const string LockRel = "PORel.LockRel";
            public const string RefCode = "PORel.RefCode";
            public const string RefCodeDesc = "PORel.RefCodeDesc";
            public const string RefType = "PORel.RefType";
            public const string OrderNum = "PORel.OrderNum";
            public const string OrderLine = "PORel.OrderLine";
            public const string OrderRelNum = "PORel.OrderRelNum";
            public const string ConfirmVia = "PORel.ConfirmVia";
            public const string ExtCompany = "PORel.ExtCompany";
            public const string Linked = "PORel.Linked";
            public const string RefDisplayAccount = "PORel.RefDisplayAccount";
            public const string ShippedQty = "PORel.ShippedQty";
            public const string TranType = "PORel.TranType";
            public const string RefAcctChart = "PORel.RefAcctChart";
            public const string RefAcctDiv = "PORel.RefAcctDiv";
            public const string RefAcctDept = "PORel.RefAcctDept";
            public const string GlbCompany = "PORel.GlbCompany";
            public const string GlbPlant = "PORel.GlbPlant";
            public const string GlbWarehouse = "PORel.GlbWarehouse";
            public const string GlbCreateJobMtl = "PORel.GlbCreateJobMtl";
            public const string ShippedDate = "PORel.ShippedDate";
            public const string ContainerID = "PORel.ContainerID";
            public const string PurchasingFactorDirection = "PORel.PurchasingFactorDirection";
            public const string PreviousDueDate = "PORel.PreviousDueDate";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "POLine", schemaColumnName: "POLine", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PONum", schemaColumnName: "PONum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RelQty", 25, 2, schemaColumnName: "RelQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "DueDate", schemaColumnName: "DueDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PORelNum", schemaColumnName: "PORelNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OpenRelease", schemaColumnName: "OpenRelease", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "VoidRelease", schemaColumnName: "VoidRelease", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "JobNum", 28, schemaColumnName: "JobNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "AssemblySeq", schemaColumnName: "AssemblySeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "JobSeqType", 2, schemaColumnName: "JobSeqType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "JobSeq", schemaColumnName: "JobSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarehouseCode", 16, schemaColumnName: "WarehouseCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ReceivedQty", 25, 2, schemaColumnName: "ReceivedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "XRelQty", 25, 2, schemaColumnName: "XRelQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PurchasingFactor", 25, 4, schemaColumnName: "PurchasingFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpDivision", 100, schemaColumnName: "ExpDivision", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpGLDept", 100, schemaColumnName: "ExpGLDept", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpChart", 100, schemaColumnName: "ExpChart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ExpOverride", schemaColumnName: "ExpOverride", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReqNum", schemaColumnName: "ReqNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReqLine", schemaColumnName: "ReqLine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "PromiseDt", schemaColumnName: "PromiseDt", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ProjectID", 50, schemaColumnName: "ProjectID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ReqChgDate", schemaColumnName: "ReqChgDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Confirmed", schemaColumnName: "Confirmed", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ReqChgQty", 25, 2, schemaColumnName: "ReqChgQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LockRel", 16, schemaColumnName: "LockRel", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCode", 16, schemaColumnName: "RefCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCodeDesc", 60, schemaColumnName: "RefCodeDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefType", 16, schemaColumnName: "RefType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderNum", schemaColumnName: "OrderNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderLine", schemaColumnName: "OrderLine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderRelNum", schemaColumnName: "OrderRelNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConfirmVia", 16, schemaColumnName: "ConfirmVia", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExtCompany", 16, schemaColumnName: "ExtCompany", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Linked", schemaColumnName: "Linked", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefDisplayAccount", 130, schemaColumnName: "RefDisplayAccount", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ShippedQty", 25, 2, schemaColumnName: "ShippedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TranType", 14, schemaColumnName: "TranType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefAcctChart", 100, schemaColumnName: "RefAcctChart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefAcctDiv", 100, schemaColumnName: "RefAcctDiv", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefAcctDept", 100, schemaColumnName: "RefAcctDept", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbCompany", 16, schemaColumnName: "GlbCompany", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbPlant", 16, schemaColumnName: "GlbPlant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbWarehouse", 16, schemaColumnName: "GlbWarehouse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlbCreateJobMtl", schemaColumnName: "GlbCreateJobMtl", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ShippedDate", schemaColumnName: "ShippedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ContainerID", schemaColumnName: "ContainerID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurchasingFactorDirection", 2, schemaColumnName: "PurchasingFactorDirection", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "PreviousDueDate", schemaColumnName: "PreviousDueDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PORel.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PORel.PONum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PORel.POLine"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PORel.PORelNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PurAgent : SFEpic.Data.SchemaTable
        {
            public PurAgent()
                : base("PurAgent")
            {
            }

            #region Field Name Constants

            public const string InActive = "PurAgent.InActive";
            public const string CompanyNum = "PurAgent.CompanyNum";
            public const string BuyerID = "PurAgent.BuyerID";
            public const string Name = "PurAgent.Name";
            public const string ApprovalPerson = "PurAgent.ApprovalPerson";
            public const string POLimit = "PurAgent.POLimit";
            public const string EMailAddress = "PurAgent.EMailAddress";
            public const string ConsolidatedPurchasing = "PurAgent.ConsolidatedPurchasing";
            public const string CnvEmpID = "PurAgent.CnvEmpID";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "InActive", schemaColumnName: "InActive", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BuyerID", 16, schemaColumnName: "BuyerID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 60, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovalPerson", 16, schemaColumnName: "ApprovalPerson", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "POLimit", 25, 2, schemaColumnName: "POLimit", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailAddress", 100, schemaColumnName: "EMailAddress", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPurchasing", schemaColumnName: "ConsolidatedPurchasing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CnvEmpID", 16, schemaColumnName: "CnvEmpID", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PurAgent.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PurAgent.BuyerID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class Vendor : SFEpic.Data.SchemaTable
        {
            public Vendor()
                : base("Vendor")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "Vendor.CompanyNum";
            public const string VendorID = "Vendor.VendorID";
            public const string Address1 = "Vendor.Address1";
            public const string Address2 = "Vendor.Address2";
            public const string City = "Vendor.City";
            public const string Country = "Vendor.Country";
            public const string GroupCode = "Vendor.GroupCode";
            public const string Name = "Vendor.Name";
            public const string ExpenseDiv = "Vendor.ExpenseDiv";
            public const string TaxPayerID = "Vendor.TaxPayerID";
            public const string FaxNum = "Vendor.FaxNum";
            public const string PurPoint = "Vendor.PurPoint";
            public const string State = "Vendor.State";
            public const string TermsCode = "Vendor.TermsCode";
            public const string ZIP = "Vendor.ZIP";
            public const string Print1099 = "Vendor.Print1099";
            public const string ExpenseChart = "Vendor.ExpenseChart";
            public const string ExpenseDept = "Vendor.ExpenseDept";
            public const string OneCheck = "Vendor.OneCheck";
            public const string PrintLabels = "Vendor.PrintLabels";
            public const string Inactive = "Vendor.Inactive";
            public const string VendorNum = "Vendor.VendorNum";
            public const string PhoneNum = "Vendor.PhoneNum";
            public const string Comment = "Vendor.Comment";
            public const string Address3 = "Vendor.Address3";
            public const string PayHold = "Vendor.PayHold";
            public const string PrimPCon = "Vendor.PrimPCon";
            public const string AccountRef = "Vendor.AccountRef";
            public const string APAcctID = "Vendor.APAcctID";
            public const string DefaultFOB = "Vendor.DefaultFOB";
            public const string RcvInspectionReq = "Vendor.RcvInspectionReq";
            public const string CurrencyCode = "Vendor.CurrencyCode";
            public const string TaxRegionCode = "Vendor.TaxRegionCode";
            public const string LangNameID = "Vendor.LangNameID";
            public const string CountryNum = "Vendor.CountryNum";
            public const string FormatStr = "Vendor.FormatStr";
            public const string BorderCrossing = "Vendor.BorderCrossing";
            public const string ElecPayment = "Vendor.ElecPayment";
            public const string PrimaryBankID = "Vendor.PrimaryBankID";
            public const string Approved = "Vendor.Approved";
            public const string ICVend = "Vendor.ICVend";
            public const string EMailAddress = "Vendor.EMailAddress";
            public const string WebVendor = "Vendor.WebVendor";
            public const string VendURL = "Vendor.VendURL";
            public const string EarlyBuffer = "Vendor.EarlyBuffer";
            public const string LateBuffer = "Vendor.LateBuffer";
            public const string OnTimeRating = "Vendor.OnTimeRating";
            public const string QualityRating = "Vendor.QualityRating";
            public const string PriceRating = "Vendor.PriceRating";
            public const string ServiceRating = "Vendor.ServiceRating";
            public const string ExternalId = "Vendor.ExternalId";
            public const string VendPILimit = "Vendor.VendPILimit";
            public const string GlobalVendor = "Vendor.GlobalVendor";
            public const string ICTrader = "Vendor.ICTrader";
            public const string TaxAuthorityCode = "Vendor.TaxAuthorityCode";
            public const string GlobalLock = "Vendor.GlobalLock";
            public const string Min_Order_Value = "Vendor.Min_Order_Value";
            public const string CalendarID = "Vendor.CalendarID";
            public const string EDICode = "Vendor.EDICode";
            public const string LocalPurchasing = "Vendor.LocalPurchasing";
            public const string ConsolidatedPurchasing = "Vendor.ConsolidatedPurchasing";
            public const string SatDelivery = "Vendor.SatDelivery";
            public const string SatPickup = "Vendor.SatPickup";
            public const string Hazmat = "Vendor.Hazmat";
            public const string DocOnly = "Vendor.DocOnly";
            public const string RefNotes = "Vendor.RefNotes";
            public const string ApplyChrg = "Vendor.ApplyChrg";
            public const string ChrgAmount = "Vendor.ChrgAmount";
            public const string COD = "Vendor.COD";
            public const string CODFreight = "Vendor.CODFreight";
            public const string CODCheck = "Vendor.CODCheck";
            public const string CODAmount = "Vendor.CODAmount";
            public const string GroundType = "Vendor.GroundType";
            public const string NotifyFlag = "Vendor.NotifyFlag";
            public const string NotifyEMail = "Vendor.NotifyEMail";
            public const string DeclaredIns = "Vendor.DeclaredIns";
            public const string DeclaredAmt = "Vendor.DeclaredAmt";
            public const string ResDelivery = "Vendor.ResDelivery";
            public const string ServSignature = "Vendor.ServSignature";
            public const string ServAlert = "Vendor.ServAlert";
            public const string ServHomeDel = "Vendor.ServHomeDel";
            public const string DeliveryType = "Vendor.DeliveryType";
            public const string ServDeliveryDate = "Vendor.ServDeliveryDate";
            public const string ServPhone = "Vendor.ServPhone";
            public const string ServInstruct = "Vendor.ServInstruct";
            public const string ServRelease = "Vendor.ServRelease";
            public const string ServAuthNum = "Vendor.ServAuthNum";
            public const string ServRef1 = "Vendor.ServRef1";
            public const string ServRef2 = "Vendor.ServRef2";
            public const string ServRef3 = "Vendor.ServRef3";
            public const string ServRef4 = "Vendor.ServRef4";
            public const string ServRef5 = "Vendor.ServRef5";
            public const string CPay = "Vendor.CPay";
            public const string IntrntlShip = "Vendor.IntrntlShip";
            public const string CertOfOrigin = "Vendor.CertOfOrigin";
            public const string CommercialInvoice = "Vendor.CommercialInvoice";
            public const string ShipExprtDeclartn = "Vendor.ShipExprtDeclartn";
            public const string LetterOfInstr = "Vendor.LetterOfInstr";
            public const string FFID = "Vendor.FFID";
            public const string FFCompName = "Vendor.FFCompName";
            public const string FFContact = "Vendor.FFContact";
            public const string FFAddress1 = "Vendor.FFAddress1";
            public const string FFAddress2 = "Vendor.FFAddress2";
            public const string FFAddress3 = "Vendor.FFAddress3";
            public const string FFCity = "Vendor.FFCity";
            public const string FFState = "Vendor.FFState";
            public const string FFZip = "Vendor.FFZip";
            public const string FFCountry = "Vendor.FFCountry";
            public const string NonStdPkg = "Vendor.NonStdPkg";
            public const string DeliveryConf = "Vendor.DeliveryConf";
            public const string AddlHdlgFlag = "Vendor.AddlHdlgFlag";
            public const string IndividualPackIDs = "Vendor.IndividualPackIDs";
            public const string UPSQVShipFromName = "Vendor.UPSQVShipFromName";
            public const string UPSQVMemo = "Vendor.UPSQVMemo";
            public const string UPSQuantumView = "Vendor.UPSQuantumView";
            public const string FFCountryNum = "Vendor.FFCountryNum";
            public const string FFPhoneNum = "Vendor.FFPhoneNum";
            public const string RevChargeMethod = "Vendor.RevChargeMethod";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VendorID", 16, schemaColumnName: "VendorID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address1", 100, schemaColumnName: "Address1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address2", 100, schemaColumnName: "Address2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "City", 100, schemaColumnName: "City", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Country", 100, schemaColumnName: "Country", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroupCode", 8, schemaColumnName: "GroupCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 100, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDiv", 100, schemaColumnName: "ExpenseDiv", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxPayerID", 40, schemaColumnName: "TaxPayerID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FaxNum", 40, schemaColumnName: "FaxNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "State", 100, schemaColumnName: "State", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TermsCode", 8, schemaColumnName: "TermsCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ZIP", 20, schemaColumnName: "ZIP", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Print1099", schemaColumnName: "Print1099", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseChart", 100, schemaColumnName: "ExpenseChart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDept", 100, schemaColumnName: "ExpenseDept", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OneCheck", schemaColumnName: "OneCheck", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrintLabels", schemaColumnName: "PrintLabels", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Inactive", schemaColumnName: "Inactive", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PhoneNum", 40, schemaColumnName: "PhoneNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Comment", 2000, schemaColumnName: "Comment", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address3", 100, schemaColumnName: "Address3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PayHold", schemaColumnName: "PayHold", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimPCon", schemaColumnName: "PrimPCon", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AccountRef", 40, schemaColumnName: "AccountRef", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APAcctID", 10, schemaColumnName: "APAcctID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DefaultFOB", 30, schemaColumnName: "DefaultFOB", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RcvInspectionReq", schemaColumnName: "RcvInspectionReq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CurrencyCode", 8, schemaColumnName: "CurrencyCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxRegionCode", 8, schemaColumnName: "TaxRegionCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LangNameID", 16, schemaColumnName: "LangNameID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountryNum", schemaColumnName: "CountryNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FormatStr", 100, schemaColumnName: "FormatStr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BorderCrossing", 8, schemaColumnName: "BorderCrossing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ElecPayment", schemaColumnName: "ElecPayment", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PrimaryBankID", 18, schemaColumnName: "PrimaryBankID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Approved", schemaColumnName: "Approved", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ICVend", schemaColumnName: "ICVend", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailAddress", 100, schemaColumnName: "EMailAddress", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebVendor", schemaColumnName: "WebVendor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VendURL", 2000, schemaColumnName: "VendURL", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "EarlyBuffer", schemaColumnName: "EarlyBuffer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LateBuffer", schemaColumnName: "LateBuffer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OnTimeRating", 8, schemaColumnName: "OnTimeRating", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "QualityRating", 8, schemaColumnName: "QualityRating", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PriceRating", 8, schemaColumnName: "PriceRating", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServiceRating", 8, schemaColumnName: "ServiceRating", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExternalId", 80, schemaColumnName: "ExternalId", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendPILimit", schemaColumnName: "VendPILimit", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalVendor", schemaColumnName: "GlobalVendor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ICTrader", schemaColumnName: "ICTrader", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxAuthorityCode", 16, schemaColumnName: "TaxAuthorityCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalLock", schemaColumnName: "GlobalLock", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Min_Order_Value", 25, 2, schemaColumnName: "Min-Order-Value", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CalendarID", 16, schemaColumnName: "CalendarID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LocalPurchasing", schemaColumnName: "LocalPurchasing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPurchasing", schemaColumnName: "ConsolidatedPurchasing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatDelivery", schemaColumnName: "SatDelivery", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatPickup", schemaColumnName: "SatPickup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Hazmat", schemaColumnName: "Hazmat", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DocOnly", schemaColumnName: "DocOnly", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefNotes", 1000, schemaColumnName: "RefNotes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ApplyChrg", schemaColumnName: "ApplyChrg", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ChrgAmount", 17, 2, schemaColumnName: "ChrgAmount", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "COD", schemaColumnName: "COD", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODFreight", schemaColumnName: "CODFreight", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODCheck", schemaColumnName: "CODCheck", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "CODAmount", 17, 2, schemaColumnName: "CODAmount", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroundType", 16, schemaColumnName: "GroundType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NotifyFlag", schemaColumnName: "NotifyFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NotifyEMail", 1000, schemaColumnName: "NotifyEMail", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DeclaredIns", schemaColumnName: "DeclaredIns", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DeclaredAmt", 17, 2, schemaColumnName: "DeclaredAmt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ResDelivery", schemaColumnName: "ResDelivery", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServSignature", schemaColumnName: "ServSignature", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServAlert", schemaColumnName: "ServAlert", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServHomeDel", schemaColumnName: "ServHomeDel", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DeliveryType", 16, schemaColumnName: "DeliveryType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ServDeliveryDate", schemaColumnName: "ServDeliveryDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServPhone", 40, schemaColumnName: "ServPhone", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServInstruct", 200, schemaColumnName: "ServInstruct", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServRelease", schemaColumnName: "ServRelease", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServAuthNum", 100, schemaColumnName: "ServAuthNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef1", 100, schemaColumnName: "ServRef1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef2", 100, schemaColumnName: "ServRef2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef3", 100, schemaColumnName: "ServRef3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef4", 100, schemaColumnName: "ServRef4", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef5", 100, schemaColumnName: "ServRef5", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CPay", schemaColumnName: "CPay", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IntrntlShip", schemaColumnName: "IntrntlShip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CertOfOrigin", schemaColumnName: "CertOfOrigin", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CommercialInvoice", schemaColumnName: "CommercialInvoice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShipExprtDeclartn", schemaColumnName: "ShipExprtDeclartn", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LetterOfInstr", schemaColumnName: "LetterOfInstr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFID", 16, schemaColumnName: "FFID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCompName", 100, schemaColumnName: "FFCompName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFContact", 100, schemaColumnName: "FFContact", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress1", 100, schemaColumnName: "FFAddress1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress2", 100, schemaColumnName: "FFAddress2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress3", 100, schemaColumnName: "FFAddress3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCity", 100, schemaColumnName: "FFCity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFState", 100, schemaColumnName: "FFState", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFZip", 20, schemaColumnName: "FFZip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCountry", 100, schemaColumnName: "FFCountry", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStdPkg", schemaColumnName: "NonStdPkg", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "DeliveryConf", schemaColumnName: "DeliveryConf", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AddlHdlgFlag", schemaColumnName: "AddlHdlgFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IndividualPackIDs", schemaColumnName: "IndividualPackIDs", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVShipFromName", 100, schemaColumnName: "UPSQVShipFromName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVMemo", 2000, schemaColumnName: "UPSQVMemo", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UPSQuantumView", schemaColumnName: "UPSQuantumView", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FFCountryNum", schemaColumnName: "FFCountryNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFPhoneNum", 40, schemaColumnName: "FFPhoneNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevChargeMethod", 16, schemaColumnName: "RevChargeMethod", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["Vendor.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["Vendor.VendorNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class VendorPP : SFEpic.Data.SchemaTable
        {
            public VendorPP()
                : base("VendorPP")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "VendorPP.CompanyNum";
            public const string PurPoint = "VendorPP.PurPoint";
            public const string VendorNum = "VendorPP.VendorNum";
            public const string Address1 = "VendorPP.Address1";
            public const string Address2 = "VendorPP.Address2";
            public const string City = "VendorPP.City";
            public const string Country = "VendorPP.Country";
            public const string Name = "VendorPP.Name";
            public const string State = "VendorPP.State";
            public const string Zip = "VendorPP.Zip";
            public const string Address3 = "VendorPP.Address3";
            public const string PrimPCon = "VendorPP.PrimPCon";
            public const string LangNameID = "VendorPP.LangNameID";
            public const string CountryNum = "VendorPP.CountryNum";
            public const string FormatStr = "VendorPP.FormatStr";
            public const string BorderCrossing = "VendorPP.BorderCrossing";
            public const string EMailAddress = "VendorPP.EMailAddress";
            public const string ExternalId = "VendorPP.ExternalId";
            public const string TaxAuthorityCode = "VendorPP.TaxAuthorityCode";
            public const string GlobalLock = "VendorPP.GlobalLock";
            public const string EDICode = "VendorPP.EDICode";
            public const string ResDelivery = "VendorPP.ResDelivery";
            public const string SatDelivery = "VendorPP.SatDelivery";
            public const string SatPickup = "VendorPP.SatPickup";
            public const string Hazmat = "VendorPP.Hazmat";
            public const string DocOnly = "VendorPP.DocOnly";
            public const string RefNotes = "VendorPP.RefNotes";
            public const string ApplyChrg = "VendorPP.ApplyChrg";
            public const string ChrgAmount = "VendorPP.ChrgAmount";
            public const string COD = "VendorPP.COD";
            public const string CODFreight = "VendorPP.CODFreight";
            public const string CODCheck = "VendorPP.CODCheck";
            public const string CODAmount = "VendorPP.CODAmount";
            public const string GroundType = "VendorPP.GroundType";
            public const string NotifyFlag = "VendorPP.NotifyFlag";
            public const string NotifyEMail = "VendorPP.NotifyEMail";
            public const string DeclaredIns = "VendorPP.DeclaredIns";
            public const string DeclaredAmt = "VendorPP.DeclaredAmt";
            public const string ServSignature = "VendorPP.ServSignature";
            public const string ServAlert = "VendorPP.ServAlert";
            public const string ServHomeDel = "VendorPP.ServHomeDel";
            public const string DeliveryType = "VendorPP.DeliveryType";
            public const string ServDeliveryDate = "VendorPP.ServDeliveryDate";
            public const string ServPhone = "VendorPP.ServPhone";
            public const string ServInstruct = "VendorPP.ServInstruct";
            public const string ServRelease = "VendorPP.ServRelease";
            public const string ServAuthNum = "VendorPP.ServAuthNum";
            public const string ServRef1 = "VendorPP.ServRef1";
            public const string ServRef2 = "VendorPP.ServRef2";
            public const string ServRef3 = "VendorPP.ServRef3";
            public const string ServRef4 = "VendorPP.ServRef4";
            public const string ServRef5 = "VendorPP.ServRef5";
            public const string OverrideCarrier = "VendorPP.OverrideCarrier";
            public const string OverrideService = "VendorPP.OverrideService";
            public const string IndividualPackIDs = "VendorPP.IndividualPackIDs";
            public const string IntrntlShip = "VendorPP.IntrntlShip";
            public const string CertOfOrigin = "VendorPP.CertOfOrigin";
            public const string CommercialInvoice = "VendorPP.CommercialInvoice";
            public const string ShipExprtDeclartn = "VendorPP.ShipExprtDeclartn";
            public const string LetterOfInstr = "VendorPP.LetterOfInstr";
            public const string FFID = "VendorPP.FFID";
            public const string FFCompName = "VendorPP.FFCompName";
            public const string FFContact = "VendorPP.FFContact";
            public const string FFAddress1 = "VendorPP.FFAddress1";
            public const string FFAddress2 = "VendorPP.FFAddress2";
            public const string FFAddress3 = "VendorPP.FFAddress3";
            public const string FFCity = "VendorPP.FFCity";
            public const string FFState = "VendorPP.FFState";
            public const string FFZip = "VendorPP.FFZip";
            public const string FFCountry = "VendorPP.FFCountry";
            public const string NonStdPkg = "VendorPP.NonStdPkg";
            public const string DeliveryConf = "VendorPP.DeliveryConf";
            public const string AddlHdlgFlag = "VendorPP.AddlHdlgFlag";
            public const string UPSQuantumView = "VendorPP.UPSQuantumView";
            public const string UPSQVShipFromName = "VendorPP.UPSQVShipFromName";
            public const string UPSQVMemo = "VendorPP.UPSQVMemo";
            public const string FFPhoneNum = "VendorPP.FFPhoneNum";
            public const string FFCountryNum = "VendorPP.FFCountryNum";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address1", 100, schemaColumnName: "Address1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address2", 100, schemaColumnName: "Address2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "City", 100, schemaColumnName: "City", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Country", 100, schemaColumnName: "Country", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 100, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "State", 100, schemaColumnName: "State", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Zip", 20, schemaColumnName: "Zip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address3", 100, schemaColumnName: "Address3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimPCon", schemaColumnName: "PrimPCon", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LangNameID", 16, schemaColumnName: "LangNameID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountryNum", schemaColumnName: "CountryNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FormatStr", 100, schemaColumnName: "FormatStr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BorderCrossing", 8, schemaColumnName: "BorderCrossing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailAddress", 100, schemaColumnName: "EMailAddress", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExternalId", 40, schemaColumnName: "ExternalId", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxAuthorityCode", 16, schemaColumnName: "TaxAuthorityCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalLock", schemaColumnName: "GlobalLock", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ResDelivery", schemaColumnName: "ResDelivery", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatDelivery", schemaColumnName: "SatDelivery", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatPickup", schemaColumnName: "SatPickup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Hazmat", schemaColumnName: "Hazmat", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DocOnly", schemaColumnName: "DocOnly", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefNotes", 1000, schemaColumnName: "RefNotes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ApplyChrg", schemaColumnName: "ApplyChrg", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ChrgAmount", 17, 2, schemaColumnName: "ChrgAmount", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "COD", schemaColumnName: "COD", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODFreight", schemaColumnName: "CODFreight", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODCheck", schemaColumnName: "CODCheck", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "CODAmount", 17, 2, schemaColumnName: "CODAmount", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroundType", 16, schemaColumnName: "GroundType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NotifyFlag", schemaColumnName: "NotifyFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NotifyEMail", 1000, schemaColumnName: "NotifyEMail", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DeclaredIns", schemaColumnName: "DeclaredIns", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DeclaredAmt", 17, 2, schemaColumnName: "DeclaredAmt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServSignature", schemaColumnName: "ServSignature", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServAlert", schemaColumnName: "ServAlert", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServHomeDel", schemaColumnName: "ServHomeDel", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DeliveryType", 16, schemaColumnName: "DeliveryType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ServDeliveryDate", schemaColumnName: "ServDeliveryDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServPhone", 40, schemaColumnName: "ServPhone", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServInstruct", 200, schemaColumnName: "ServInstruct", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServRelease", schemaColumnName: "ServRelease", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServAuthNum", 100, schemaColumnName: "ServAuthNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef1", 100, schemaColumnName: "ServRef1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef2", 100, schemaColumnName: "ServRef2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef3", 100, schemaColumnName: "ServRef3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef4", 100, schemaColumnName: "ServRef4", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef5", 100, schemaColumnName: "ServRef5", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OverrideCarrier", schemaColumnName: "OverrideCarrier", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OverrideService", schemaColumnName: "OverrideService", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IndividualPackIDs", schemaColumnName: "IndividualPackIDs", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IntrntlShip", schemaColumnName: "IntrntlShip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CertOfOrigin", schemaColumnName: "CertOfOrigin", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CommercialInvoice", schemaColumnName: "CommercialInvoice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShipExprtDeclartn", schemaColumnName: "ShipExprtDeclartn", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LetterOfInstr", schemaColumnName: "LetterOfInstr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFID", 16, schemaColumnName: "FFID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCompName", 100, schemaColumnName: "FFCompName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFContact", 100, schemaColumnName: "FFContact", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress1", 100, schemaColumnName: "FFAddress1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress2", 100, schemaColumnName: "FFAddress2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress3", 100, schemaColumnName: "FFAddress3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCity", 100, schemaColumnName: "FFCity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFState", 100, schemaColumnName: "FFState", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFZip", 20, schemaColumnName: "FFZip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCountry", 100, schemaColumnName: "FFCountry", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStdPkg", schemaColumnName: "NonStdPkg", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "DeliveryConf", schemaColumnName: "DeliveryConf", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AddlHdlgFlag", schemaColumnName: "AddlHdlgFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UPSQuantumView", schemaColumnName: "UPSQuantumView", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVShipFromName", 100, schemaColumnName: "UPSQVShipFromName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVMemo", 2000, schemaColumnName: "UPSQVMemo", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFPhoneNum", 40, schemaColumnName: "FFPhoneNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FFCountryNum", schemaColumnName: "FFCountryNum", ordinalSequence: seq++, isRequired: false));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["VendorPP.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["VendorPP.VendorNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["VendorPP.PurPoint"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
    }

    #region Tables

    #region Company Table

    [Serializable()]
    public abstract partial class CompanyBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : CompanyBase<T, R>, new()
        where R : CompanyRow, new()
    {
        protected CompanyBase() : base() { }

        protected static Schema.Company schemaTable;
        public static Schema.Company SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.Company)V8Schema.Instance.TablesDictionary["Company"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Company.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class Company : CompanyBase<Company, CompanyRow>
    {
        public Company() : base() { }
    }

    #region CompanyRow

    [Serializable()]
    public class CompanyRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Company.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Company.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> nameProperty;
        public string Name
        {
            get
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("Company.Name");
                return nameProperty.Value;
            }
            set
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("Company.Name");
                nameProperty.Value = value;
            }
        }

        protected RowProperty<string> address1Property;
        public string Address1
        {
            get
            {
                if (address1Property == null)
                    address1Property = GetStringProperty("Company.Address1");
                return address1Property.Value;
            }
            set
            {
                if (address1Property == null)
                    address1Property = GetStringProperty("Company.Address1");
                address1Property.Value = value;
            }
        }

        protected RowProperty<string> address2Property;
        public string Address2
        {
            get
            {
                if (address2Property == null)
                    address2Property = GetStringProperty("Company.Address2");
                return address2Property.Value;
            }
            set
            {
                if (address2Property == null)
                    address2Property = GetStringProperty("Company.Address2");
                address2Property.Value = value;
            }
        }

        protected RowProperty<string> cityProperty;
        public string City
        {
            get
            {
                if (cityProperty == null)
                    cityProperty = GetStringProperty("Company.City");
                return cityProperty.Value;
            }
            set
            {
                if (cityProperty == null)
                    cityProperty = GetStringProperty("Company.City");
                cityProperty.Value = value;
            }
        }

        protected RowProperty<string> countryProperty;
        public string Country
        {
            get
            {
                if (countryProperty == null)
                    countryProperty = GetStringProperty("Company.Country");
                return countryProperty.Value;
            }
            set
            {
                if (countryProperty == null)
                    countryProperty = GetStringProperty("Company.Country");
                countryProperty.Value = value;
            }
        }

        protected RowProperty<string> faxNumProperty;
        public string FaxNum
        {
            get
            {
                if (faxNumProperty == null)
                    faxNumProperty = GetStringProperty("Company.FaxNum");
                return faxNumProperty.Value;
            }
            set
            {
                if (faxNumProperty == null)
                    faxNumProperty = GetStringProperty("Company.FaxNum");
                faxNumProperty.Value = value;
            }
        }

        protected RowProperty<string> phoneNumProperty;
        public string PhoneNum
        {
            get
            {
                if (phoneNumProperty == null)
                    phoneNumProperty = GetStringProperty("Company.PhoneNum");
                return phoneNumProperty.Value;
            }
            set
            {
                if (phoneNumProperty == null)
                    phoneNumProperty = GetStringProperty("Company.PhoneNum");
                phoneNumProperty.Value = value;
            }
        }

        protected RowProperty<string> stateProperty;
        public string State
        {
            get
            {
                if (stateProperty == null)
                    stateProperty = GetStringProperty("Company.State");
                return stateProperty.Value;
            }
            set
            {
                if (stateProperty == null)
                    stateProperty = GetStringProperty("Company.State");
                stateProperty.Value = value;
            }
        }

        protected RowProperty<string> zipProperty;
        public string Zip
        {
            get
            {
                if (zipProperty == null)
                    zipProperty = GetStringProperty("Company.Zip");
                return zipProperty.Value;
            }
            set
            {
                if (zipProperty == null)
                    zipProperty = GetStringProperty("Company.Zip");
                zipProperty.Value = value;
            }
        }

        protected RowProperty<string> feinProperty;
        public string FEIN
        {
            get
            {
                if (feinProperty == null)
                    feinProperty = GetStringProperty("Company.FEIN");
                return feinProperty.Value;
            }
            set
            {
                if (feinProperty == null)
                    feinProperty = GetStringProperty("Company.FEIN");
                feinProperty.Value = value;
            }
        }

        protected RowProperty<string> stateTaxIDProperty;
        public string StateTaxID
        {
            get
            {
                if (stateTaxIDProperty == null)
                    stateTaxIDProperty = GetStringProperty("Company.StateTaxID");
                return stateTaxIDProperty.Value;
            }
            set
            {
                if (stateTaxIDProperty == null)
                    stateTaxIDProperty = GetStringProperty("Company.StateTaxID");
                stateTaxIDProperty.Value = value;
            }
        }

        protected RowProperty<int> currentFiscalYearProperty;
        public int CurrentFiscalYear
        {
            get
            {
                if (currentFiscalYearProperty == null)
                    currentFiscalYearProperty = GetIntegerProperty("Company.CurrentFiscalYear");
                return currentFiscalYearProperty.Value;
            }
            set
            {
                if (currentFiscalYearProperty == null)
                    currentFiscalYearProperty = GetIntegerProperty("Company.CurrentFiscalYear");
                currentFiscalYearProperty.Value = value;
            }
        }

        protected RowProperty<string> address3Property;
        public string Address3
        {
            get
            {
                if (address3Property == null)
                    address3Property = GetStringProperty("Company.Address3");
                return address3Property.Value;
            }
            set
            {
                if (address3Property == null)
                    address3Property = GetStringProperty("Company.Address3");
                address3Property.Value = value;
            }
        }

        protected RowProperty<string> eDICodeProperty;
        public string EDICode
        {
            get
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("Company.EDICode");
                return eDICodeProperty.Value;
            }
            set
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("Company.EDICode");
                eDICodeProperty.Value = value;
            }
        }

        protected RowProperty<string> taxRegionCodeProperty;
        public string TaxRegionCode
        {
            get
            {
                if (taxRegionCodeProperty == null)
                    taxRegionCodeProperty = GetStringProperty("Company.TaxRegionCode");
                return taxRegionCodeProperty.Value;
            }
            set
            {
                if (taxRegionCodeProperty == null)
                    taxRegionCodeProperty = GetStringProperty("Company.TaxRegionCode");
                taxRegionCodeProperty.Value = value;
            }
        }

        protected RowProperty<int> countryNumProperty;
        public int CountryNum
        {
            get
            {
                if (countryNumProperty == null)
                    countryNumProperty = GetIntegerProperty("Company.CountryNum");
                return countryNumProperty.Value;
            }
            set
            {
                if (countryNumProperty == null)
                    countryNumProperty = GetIntegerProperty("Company.CountryNum");
                countryNumProperty.Value = value;
            }
        }

        protected RowProperty<int> numberProperty;
        public int Number
        {
            get
            {
                if (numberProperty == null)
                    numberProperty = GetIntegerProperty("Company.Number");
                return numberProperty.Value;
            }
            set
            {
                if (numberProperty == null)
                    numberProperty = GetIntegerProperty("Company.Number");
                numberProperty.Value = value;
            }
        }

        protected RowProperty<string> fRxDSNProperty;
        public string FRxDSN
        {
            get
            {
                if (fRxDSNProperty == null)
                    fRxDSNProperty = GetStringProperty("Company.FRxDSN");
                return fRxDSNProperty.Value;
            }
            set
            {
                if (fRxDSNProperty == null)
                    fRxDSNProperty = GetStringProperty("Company.FRxDSN");
                fRxDSNProperty.Value = value;
            }
        }

        protected RowProperty<string> eschedFileSetProperty;
        public string EschedFileSet
        {
            get
            {
                if (eschedFileSetProperty == null)
                    eschedFileSetProperty = GetStringProperty("Company.EschedFileSet");
                return eschedFileSetProperty.Value;
            }
            set
            {
                if (eschedFileSetProperty == null)
                    eschedFileSetProperty = GetStringProperty("Company.EschedFileSet");
                eschedFileSetProperty.Value = value;
            }
        }

        protected RowProperty<string> eMailLinkPortProperty;
        public string EMailLinkPort
        {
            get
            {
                if (eMailLinkPortProperty == null)
                    eMailLinkPortProperty = GetStringProperty("Company.EMailLinkPort");
                return eMailLinkPortProperty.Value;
            }
            set
            {
                if (eMailLinkPortProperty == null)
                    eMailLinkPortProperty = GetStringProperty("Company.EMailLinkPort");
                eMailLinkPortProperty.Value = value;
            }
        }

        protected RowProperty<string> mfgSysProperty;
        public string MfgSys
        {
            get
            {
                if (mfgSysProperty == null)
                    mfgSysProperty = GetStringProperty("Company.MfgSys");
                return mfgSysProperty.Value;
            }
            set
            {
                if (mfgSysProperty == null)
                    mfgSysProperty = GetStringProperty("Company.MfgSys");
                mfgSysProperty.Value = value;
            }
        }

        protected RowProperty<string> externalIDProperty;
        public string ExternalID
        {
            get
            {
                if (externalIDProperty == null)
                    externalIDProperty = GetStringProperty("Company.ExternalID");
                return externalIDProperty.Value;
            }
            set
            {
                if (externalIDProperty == null)
                    externalIDProperty = GetStringProperty("Company.ExternalID");
                externalIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> serialNumProperty;
        public decimal SerialNum
        {
            get
            {
                if (serialNumProperty == null)
                    serialNumProperty = GetDecimalProperty("Company.SerialNum");
                return serialNumProperty.Value;
            }
            set
            {
                if (serialNumProperty == null)
                    serialNumProperty = GetDecimalProperty("Company.SerialNum");
                serialNumProperty.Value = value;
            }
        }

        protected RowProperty<string> emailFromAddrProperty;
        public string EmailFromAddr
        {
            get
            {
                if (emailFromAddrProperty == null)
                    emailFromAddrProperty = GetStringProperty("Company.EmailFromAddr");
                return emailFromAddrProperty.Value;
            }
            set
            {
                if (emailFromAddrProperty == null)
                    emailFromAddrProperty = GetStringProperty("Company.EmailFromAddr");
                emailFromAddrProperty.Value = value;
            }
        }

        protected RowProperty<string> emailFromLabelProperty;
        public string EmailFromLabel
        {
            get
            {
                if (emailFromLabelProperty == null)
                    emailFromLabelProperty = GetStringProperty("Company.EmailFromLabel");
                return emailFromLabelProperty.Value;
            }
            set
            {
                if (emailFromLabelProperty == null)
                    emailFromLabelProperty = GetStringProperty("Company.EmailFromLabel");
                emailFromLabelProperty.Value = value;
            }
        }

        protected RowProperty<string> sMTPServerProperty;
        public string SMTPServer
        {
            get
            {
                if (sMTPServerProperty == null)
                    sMTPServerProperty = GetStringProperty("Company.SMTPServer");
                return sMTPServerProperty.Value;
            }
            set
            {
                if (sMTPServerProperty == null)
                    sMTPServerProperty = GetStringProperty("Company.SMTPServer");
                sMTPServerProperty.Value = value;
            }
        }

        protected RowProperty<int> sMTPPortProperty;
        public int SMTPPort
        {
            get
            {
                if (sMTPPortProperty == null)
                    sMTPPortProperty = GetIntegerProperty("Company.SMTPPort");
                return sMTPPortProperty.Value;
            }
            set
            {
                if (sMTPPortProperty == null)
                    sMTPPortProperty = GetIntegerProperty("Company.SMTPPort");
                sMTPPortProperty.Value = value;
            }
        }

        protected RowProperty<string> logoFileProperty;
        public string LogoFile
        {
            get
            {
                if (logoFileProperty == null)
                    logoFileProperty = GetStringProperty("Company.LogoFile");
                return logoFileProperty.Value;
            }
            set
            {
                if (logoFileProperty == null)
                    logoFileProperty = GetStringProperty("Company.LogoFile");
                logoFileProperty.Value = value;
            }
        }

        protected RowProperty<string> empPhotoPathProperty;
        public string EmpPhotoPath
        {
            get
            {
                if (empPhotoPathProperty == null)
                    empPhotoPathProperty = GetStringProperty("Company.EmpPhotoPath");
                return empPhotoPathProperty.Value;
            }
            set
            {
                if (empPhotoPathProperty == null)
                    empPhotoPathProperty = GetStringProperty("Company.EmpPhotoPath");
                empPhotoPathProperty.Value = value;
            }
        }

        protected RowProperty<string> calendarIDProperty;
        public string CalendarID
        {
            get
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("Company.CalendarID");
                return calendarIDProperty.Value;
            }
            set
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("Company.CalendarID");
                calendarIDProperty.Value = value;
            }
        }

        protected RowProperty<string> auxMailAddrProperty;
        public string AuxMailAddr
        {
            get
            {
                if (auxMailAddrProperty == null)
                    auxMailAddrProperty = GetStringProperty("Company.AuxMailAddr");
                return auxMailAddrProperty.Value;
            }
            set
            {
                if (auxMailAddrProperty == null)
                    auxMailAddrProperty = GetStringProperty("Company.AuxMailAddr");
                auxMailAddrProperty.Value = value;
            }
        }

        protected RowProperty<string> frxUseridProperty;
        public string FrxUserid
        {
            get
            {
                if (frxUseridProperty == null)
                    frxUseridProperty = GetStringProperty("Company.FrxUserid");
                return frxUseridProperty.Value;
            }
            set
            {
                if (frxUseridProperty == null)
                    frxUseridProperty = GetStringProperty("Company.FrxUserid");
                frxUseridProperty.Value = value;
            }
        }

        protected RowProperty<string> fRxPassWordProperty;
        public string FRxPassWord
        {
            get
            {
                if (fRxPassWordProperty == null)
                    fRxPassWordProperty = GetStringProperty("Company.FRxPassWord");
                return fRxPassWordProperty.Value;
            }
            set
            {
                if (fRxPassWordProperty == null)
                    fRxPassWordProperty = GetStringProperty("Company.FRxPassWord");
                fRxPassWordProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region Part Table

    [Serializable()]
    public abstract partial class PartBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartBase<T, R>, new()
        where R : PartRow, new()
    {
        protected PartBase() : base() { }

        protected static Schema.Part schemaTable;
        public static Schema.Part SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.Part)V8Schema.Instance.TablesDictionary["Part"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPartNumCriteria;
        public static T FillByPartNum(DataContext context, string companyNum, string partNum, params string[] columnNames)
        {
            if (fillByPartNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class Part : PartBase<Part, PartRow>
    {
        public Part() : base() { }
    }

    #region PartRow

    [Serializable()]
    public class PartRow : DataRow
    {
        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("Part.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("Part.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partDescriptionProperty;
        public string PartDescription
        {
            get
            {
                if (partDescriptionProperty == null)
                    partDescriptionProperty = GetStringProperty("Part.PartDescription");
                return partDescriptionProperty.Value;
            }
            set
            {
                if (partDescriptionProperty == null)
                    partDescriptionProperty = GetStringProperty("Part.PartDescription");
                partDescriptionProperty.Value = value;
            }
        }

        protected RowProperty<string> prodCodeProperty;
        public string ProdCode
        {
            get
            {
                if (prodCodeProperty == null)
                    prodCodeProperty = GetStringProperty("Part.ProdCode");
                return prodCodeProperty.Value;
            }
            set
            {
                if (prodCodeProperty == null)
                    prodCodeProperty = GetStringProperty("Part.ProdCode");
                prodCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> classIDProperty;
        public string ClassID
        {
            get
            {
                if (classIDProperty == null)
                    classIDProperty = GetStringProperty("Part.ClassID");
                return classIDProperty.Value;
            }
            set
            {
                if (classIDProperty == null)
                    classIDProperty = GetStringProperty("Part.ClassID");
                classIDProperty.Value = value;
            }
        }

        protected RowProperty<string> iumProperty;
        public string IUM
        {
            get
            {
                if (iumProperty == null)
                    iumProperty = GetStringProperty("Part.IUM");
                return iumProperty.Value;
            }
            set
            {
                if (iumProperty == null)
                    iumProperty = GetStringProperty("Part.IUM");
                iumProperty.Value = value;
            }
        }

        protected RowProperty<string> pumProperty;
        public string PUM
        {
            get
            {
                if (pumProperty == null)
                    pumProperty = GetStringProperty("Part.PUM");
                return pumProperty.Value;
            }
            set
            {
                if (pumProperty == null)
                    pumProperty = GetStringProperty("Part.PUM");
                pumProperty.Value = value;
            }
        }

        protected RowProperty<string> typeCodeProperty;
        public string TypeCode
        {
            get
            {
                if (typeCodeProperty == null)
                    typeCodeProperty = GetStringProperty("Part.TypeCode");
                return typeCodeProperty.Value;
            }
            set
            {
                if (typeCodeProperty == null)
                    typeCodeProperty = GetStringProperty("Part.TypeCode");
                typeCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> purchasingFactorProperty;
        public decimal PurchasingFactor
        {
            get
            {
                if (purchasingFactorProperty == null)
                    purchasingFactorProperty = GetDecimalProperty("Part.PurchasingFactor");
                return purchasingFactorProperty.Value;
            }
            set
            {
                if (purchasingFactorProperty == null)
                    purchasingFactorProperty = GetDecimalProperty("Part.PurchasingFactor");
                purchasingFactorProperty.Value = value;
            }
        }

        protected RowProperty<string> pricePerCodeProperty;
        public string PricePerCode
        {
            get
            {
                if (pricePerCodeProperty == null)
                    pricePerCodeProperty = GetStringProperty("Part.PricePerCode");
                return pricePerCodeProperty.Value;
            }
            set
            {
                if (pricePerCodeProperty == null)
                    pricePerCodeProperty = GetStringProperty("Part.PricePerCode");
                pricePerCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> expenseChartProperty;
        public string ExpenseChart
        {
            get
            {
                if (expenseChartProperty == null)
                    expenseChartProperty = GetStringProperty("Part.ExpenseChart");
                return expenseChartProperty.Value;
            }
            set
            {
                if (expenseChartProperty == null)
                    expenseChartProperty = GetStringProperty("Part.ExpenseChart");
                expenseChartProperty.Value = value;
            }
        }

        protected RowProperty<string> expenseDivProperty;
        public string ExpenseDiv
        {
            get
            {
                if (expenseDivProperty == null)
                    expenseDivProperty = GetStringProperty("Part.ExpenseDiv");
                return expenseDivProperty.Value;
            }
            set
            {
                if (expenseDivProperty == null)
                    expenseDivProperty = GetStringProperty("Part.ExpenseDiv");
                expenseDivProperty.Value = value;
            }
        }

        protected RowProperty<decimal> unitPriceProperty;
        public decimal UnitPrice
        {
            get
            {
                if (unitPriceProperty == null)
                    unitPriceProperty = GetDecimalProperty("Part.UnitPrice");
                return unitPriceProperty.Value;
            }
            set
            {
                if (unitPriceProperty == null)
                    unitPriceProperty = GetDecimalProperty("Part.UnitPrice");
                unitPriceProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackLotsProperty;
        public bool TrackLots
        {
            get
            {
                if (trackLotsProperty == null)
                    trackLotsProperty = GetBooleanProperty("Part.TrackLots");
                return trackLotsProperty.Value;
            }
            set
            {
                if (trackLotsProperty == null)
                    trackLotsProperty = GetBooleanProperty("Part.TrackLots");
                trackLotsProperty.Value = value;
            }
        }

        protected RowProperty<string> expenseDeptProperty;
        public string ExpenseDept
        {
            get
            {
                if (expenseDeptProperty == null)
                    expenseDeptProperty = GetStringProperty("Part.ExpenseDept");
                return expenseDeptProperty.Value;
            }
            set
            {
                if (expenseDeptProperty == null)
                    expenseDeptProperty = GetStringProperty("Part.ExpenseDept");
                expenseDeptProperty.Value = value;
            }
        }

        protected RowProperty<int> lowLevelCodeProperty;
        public int LowLevelCode
        {
            get
            {
                if (lowLevelCodeProperty == null)
                    lowLevelCodeProperty = GetIntegerProperty("Part.LowLevelCode");
                return lowLevelCodeProperty.Value;
            }
            set
            {
                if (lowLevelCodeProperty == null)
                    lowLevelCodeProperty = GetIntegerProperty("Part.LowLevelCode");
                lowLevelCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> searchWordProperty;
        public string SearchWord
        {
            get
            {
                if (searchWordProperty == null)
                    searchWordProperty = GetStringProperty("Part.SearchWord");
                return searchWordProperty.Value;
            }
            set
            {
                if (searchWordProperty == null)
                    searchWordProperty = GetStringProperty("Part.SearchWord");
                searchWordProperty.Value = value;
            }
        }

        protected RowProperty<string> mfgCommentProperty;
        public string MfgComment
        {
            get
            {
                if (mfgCommentProperty == null)
                    mfgCommentProperty = GetStringProperty("Part.MfgComment");
                return mfgCommentProperty.Value;
            }
            set
            {
                if (mfgCommentProperty == null)
                    mfgCommentProperty = GetStringProperty("Part.MfgComment");
                mfgCommentProperty.Value = value;
            }
        }

        protected RowProperty<bool> methodProperty;
        public bool Method
        {
            get
            {
                if (methodProperty == null)
                    methodProperty = GetBooleanProperty("Part.Method");
                return methodProperty.Value;
            }
            set
            {
                if (methodProperty == null)
                    methodProperty = GetBooleanProperty("Part.Method");
                methodProperty.Value = value;
            }
        }

        protected RowProperty<string> purCommentProperty;
        public string PurComment
        {
            get
            {
                if (purCommentProperty == null)
                    purCommentProperty = GetStringProperty("Part.PurComment");
                return purCommentProperty.Value;
            }
            set
            {
                if (purCommentProperty == null)
                    purCommentProperty = GetStringProperty("Part.PurComment");
                purCommentProperty.Value = value;
            }
        }

        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Part.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Part.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> costMethodProperty;
        public string CostMethod
        {
            get
            {
                if (costMethodProperty == null)
                    costMethodProperty = GetStringProperty("Part.CostMethod");
                return costMethodProperty.Value;
            }
            set
            {
                if (costMethodProperty == null)
                    costMethodProperty = GetStringProperty("Part.CostMethod");
                costMethodProperty.Value = value;
            }
        }

        protected RowProperty<string> userChar1Property;
        public string UserChar1
        {
            get
            {
                if (userChar1Property == null)
                    userChar1Property = GetStringProperty("Part.UserChar1");
                return userChar1Property.Value;
            }
            set
            {
                if (userChar1Property == null)
                    userChar1Property = GetStringProperty("Part.UserChar1");
                userChar1Property.Value = value;
            }
        }

        protected RowProperty<string> userChar2Property;
        public string UserChar2
        {
            get
            {
                if (userChar2Property == null)
                    userChar2Property = GetStringProperty("Part.UserChar2");
                return userChar2Property.Value;
            }
            set
            {
                if (userChar2Property == null)
                    userChar2Property = GetStringProperty("Part.UserChar2");
                userChar2Property.Value = value;
            }
        }

        protected RowProperty<string> userChar3Property;
        public string UserChar3
        {
            get
            {
                if (userChar3Property == null)
                    userChar3Property = GetStringProperty("Part.UserChar3");
                return userChar3Property.Value;
            }
            set
            {
                if (userChar3Property == null)
                    userChar3Property = GetStringProperty("Part.UserChar3");
                userChar3Property.Value = value;
            }
        }

        protected RowProperty<string> userChar4Property;
        public string UserChar4
        {
            get
            {
                if (userChar4Property == null)
                    userChar4Property = GetStringProperty("Part.UserChar4");
                return userChar4Property.Value;
            }
            set
            {
                if (userChar4Property == null)
                    userChar4Property = GetStringProperty("Part.UserChar4");
                userChar4Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate1Property;
        public DateTime UserDate1
        {
            get
            {
                if (userDate1Property == null)
                    userDate1Property = GetDateTimeProperty("Part.UserDate1");
                return userDate1Property.Value;
            }
            set
            {
                if (userDate1Property == null)
                    userDate1Property = GetDateTimeProperty("Part.UserDate1");
                userDate1Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate2Property;
        public DateTime UserDate2
        {
            get
            {
                if (userDate2Property == null)
                    userDate2Property = GetDateTimeProperty("Part.UserDate2");
                return userDate2Property.Value;
            }
            set
            {
                if (userDate2Property == null)
                    userDate2Property = GetDateTimeProperty("Part.UserDate2");
                userDate2Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate3Property;
        public DateTime UserDate3
        {
            get
            {
                if (userDate3Property == null)
                    userDate3Property = GetDateTimeProperty("Part.UserDate3");
                return userDate3Property.Value;
            }
            set
            {
                if (userDate3Property == null)
                    userDate3Property = GetDateTimeProperty("Part.UserDate3");
                userDate3Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate4Property;
        public DateTime UserDate4
        {
            get
            {
                if (userDate4Property == null)
                    userDate4Property = GetDateTimeProperty("Part.UserDate4");
                return userDate4Property.Value;
            }
            set
            {
                if (userDate4Property == null)
                    userDate4Property = GetDateTimeProperty("Part.UserDate4");
                userDate4Property.Value = value;
            }
        }

        protected RowProperty<decimal> userDecimal1Property;
        public decimal UserDecimal1
        {
            get
            {
                if (userDecimal1Property == null)
                    userDecimal1Property = GetDecimalProperty("Part.UserDecimal1");
                return userDecimal1Property.Value;
            }
            set
            {
                if (userDecimal1Property == null)
                    userDecimal1Property = GetDecimalProperty("Part.UserDecimal1");
                userDecimal1Property.Value = value;
            }
        }

        protected RowProperty<decimal> userDecimal2Property;
        public decimal UserDecimal2
        {
            get
            {
                if (userDecimal2Property == null)
                    userDecimal2Property = GetDecimalProperty("Part.UserDecimal2");
                return userDecimal2Property.Value;
            }
            set
            {
                if (userDecimal2Property == null)
                    userDecimal2Property = GetDecimalProperty("Part.UserDecimal2");
                userDecimal2Property.Value = value;
            }
        }

        protected RowProperty<int> userInteger1Property;
        public int UserInteger1
        {
            get
            {
                if (userInteger1Property == null)
                    userInteger1Property = GetIntegerProperty("Part.UserInteger1");
                return userInteger1Property.Value;
            }
            set
            {
                if (userInteger1Property == null)
                    userInteger1Property = GetIntegerProperty("Part.UserInteger1");
                userInteger1Property.Value = value;
            }
        }

        protected RowProperty<int> userInteger2Property;
        public int UserInteger2
        {
            get
            {
                if (userInteger2Property == null)
                    userInteger2Property = GetIntegerProperty("Part.UserInteger2");
                return userInteger2Property.Value;
            }
            set
            {
                if (userInteger2Property == null)
                    userInteger2Property = GetIntegerProperty("Part.UserInteger2");
                userInteger2Property.Value = value;
            }
        }

        protected RowProperty<bool> nonStockProperty;
        public bool NonStock
        {
            get
            {
                if (nonStockProperty == null)
                    nonStockProperty = GetBooleanProperty("Part.NonStock");
                return nonStockProperty.Value;
            }
            set
            {
                if (nonStockProperty == null)
                    nonStockProperty = GetBooleanProperty("Part.NonStock");
                nonStockProperty.Value = value;
            }
        }

        protected RowProperty<string> taxCatIDProperty;
        public string TaxCatID
        {
            get
            {
                if (taxCatIDProperty == null)
                    taxCatIDProperty = GetStringProperty("Part.TaxCatID");
                return taxCatIDProperty.Value;
            }
            set
            {
                if (taxCatIDProperty == null)
                    taxCatIDProperty = GetStringProperty("Part.TaxCatID");
                taxCatIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> userDecimal3Property;
        public decimal UserDecimal3
        {
            get
            {
                if (userDecimal3Property == null)
                    userDecimal3Property = GetDecimalProperty("Part.UserDecimal3");
                return userDecimal3Property.Value;
            }
            set
            {
                if (userDecimal3Property == null)
                    userDecimal3Property = GetDecimalProperty("Part.UserDecimal3");
                userDecimal3Property.Value = value;
            }
        }

        protected RowProperty<decimal> userDecimal4Property;
        public decimal UserDecimal4
        {
            get
            {
                if (userDecimal4Property == null)
                    userDecimal4Property = GetDecimalProperty("Part.UserDecimal4");
                return userDecimal4Property.Value;
            }
            set
            {
                if (userDecimal4Property == null)
                    userDecimal4Property = GetDecimalProperty("Part.UserDecimal4");
                userDecimal4Property.Value = value;
            }
        }

        protected RowProperty<bool> inActiveProperty;
        public bool InActive
        {
            get
            {
                if (inActiveProperty == null)
                    inActiveProperty = GetBooleanProperty("Part.InActive");
                return inActiveProperty.Value;
            }
            set
            {
                if (inActiveProperty == null)
                    inActiveProperty = GetBooleanProperty("Part.InActive");
                inActiveProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackDimensionProperty;
        public bool TrackDimension
        {
            get
            {
                if (trackDimensionProperty == null)
                    trackDimensionProperty = GetBooleanProperty("Part.TrackDimension");
                return trackDimensionProperty.Value;
            }
            set
            {
                if (trackDimensionProperty == null)
                    trackDimensionProperty = GetBooleanProperty("Part.TrackDimension");
                trackDimensionProperty.Value = value;
            }
        }

        protected RowProperty<string> defaultDimProperty;
        public string DefaultDim
        {
            get
            {
                if (defaultDimProperty == null)
                    defaultDimProperty = GetStringProperty("Part.DefaultDim");
                return defaultDimProperty.Value;
            }
            set
            {
                if (defaultDimProperty == null)
                    defaultDimProperty = GetStringProperty("Part.DefaultDim");
                defaultDimProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackSerialNumProperty;
        public bool TrackSerialNum
        {
            get
            {
                if (trackSerialNumProperty == null)
                    trackSerialNumProperty = GetBooleanProperty("Part.TrackSerialNum");
                return trackSerialNumProperty.Value;
            }
            set
            {
                if (trackSerialNumProperty == null)
                    trackSerialNumProperty = GetBooleanProperty("Part.TrackSerialNum");
                trackSerialNumProperty.Value = value;
            }
        }

        protected RowProperty<string> commodityCodeProperty;
        public string CommodityCode
        {
            get
            {
                if (commodityCodeProperty == null)
                    commodityCodeProperty = GetStringProperty("Part.CommodityCode");
                return commodityCodeProperty.Value;
            }
            set
            {
                if (commodityCodeProperty == null)
                    commodityCodeProperty = GetStringProperty("Part.CommodityCode");
                commodityCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> warrantyCodeProperty;
        public string WarrantyCode
        {
            get
            {
                if (warrantyCodeProperty == null)
                    warrantyCodeProperty = GetStringProperty("Part.WarrantyCode");
                return warrantyCodeProperty.Value;
            }
            set
            {
                if (warrantyCodeProperty == null)
                    warrantyCodeProperty = GetStringProperty("Part.WarrantyCode");
                warrantyCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> internalUnitPriceProperty;
        public decimal InternalUnitPrice
        {
            get
            {
                if (internalUnitPriceProperty == null)
                    internalUnitPriceProperty = GetDecimalProperty("Part.InternalUnitPrice");
                return internalUnitPriceProperty.Value;
            }
            set
            {
                if (internalUnitPriceProperty == null)
                    internalUnitPriceProperty = GetDecimalProperty("Part.InternalUnitPrice");
                internalUnitPriceProperty.Value = value;
            }
        }

        protected RowProperty<string> internalPricePerCodeProperty;
        public string InternalPricePerCode
        {
            get
            {
                if (internalPricePerCodeProperty == null)
                    internalPricePerCodeProperty = GetStringProperty("Part.InternalPricePerCode");
                return internalPricePerCodeProperty.Value;
            }
            set
            {
                if (internalPricePerCodeProperty == null)
                    internalPricePerCodeProperty = GetStringProperty("Part.InternalPricePerCode");
                internalPricePerCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> phantomBOMProperty;
        public bool PhantomBOM
        {
            get
            {
                if (phantomBOMProperty == null)
                    phantomBOMProperty = GetBooleanProperty("Part.PhantomBOM");
                return phantomBOMProperty.Value;
            }
            set
            {
                if (phantomBOMProperty == null)
                    phantomBOMProperty = GetBooleanProperty("Part.PhantomBOM");
                phantomBOMProperty.Value = value;
            }
        }

        protected RowProperty<string> salesUMProperty;
        public string SalesUM
        {
            get
            {
                if (salesUMProperty == null)
                    salesUMProperty = GetStringProperty("Part.SalesUM");
                return salesUMProperty.Value;
            }
            set
            {
                if (salesUMProperty == null)
                    salesUMProperty = GetStringProperty("Part.SalesUM");
                salesUMProperty.Value = value;
            }
        }

        protected RowProperty<decimal> sellingFactorProperty;
        public decimal SellingFactor
        {
            get
            {
                if (sellingFactorProperty == null)
                    sellingFactorProperty = GetDecimalProperty("Part.SellingFactor");
                return sellingFactorProperty.Value;
            }
            set
            {
                if (sellingFactorProperty == null)
                    sellingFactorProperty = GetDecimalProperty("Part.SellingFactor");
                sellingFactorProperty.Value = value;
            }
        }

        protected RowProperty<decimal> mtlBurRateProperty;
        public decimal MtlBurRate
        {
            get
            {
                if (mtlBurRateProperty == null)
                    mtlBurRateProperty = GetDecimalProperty("Part.MtlBurRate");
                return mtlBurRateProperty.Value;
            }
            set
            {
                if (mtlBurRateProperty == null)
                    mtlBurRateProperty = GetDecimalProperty("Part.MtlBurRate");
                mtlBurRateProperty.Value = value;
            }
        }

        protected RowProperty<bool> wholeUnitProperty;
        public bool WholeUnit
        {
            get
            {
                if (wholeUnitProperty == null)
                    wholeUnitProperty = GetBooleanProperty("Part.WholeUnit");
                return wholeUnitProperty.Value;
            }
            set
            {
                if (wholeUnitProperty == null)
                    wholeUnitProperty = GetBooleanProperty("Part.WholeUnit");
                wholeUnitProperty.Value = value;
            }
        }

        protected RowProperty<decimal> netWeightProperty;
        public decimal NetWeight
        {
            get
            {
                if (netWeightProperty == null)
                    netWeightProperty = GetDecimalProperty("Part.NetWeight");
                return netWeightProperty.Value;
            }
            set
            {
                if (netWeightProperty == null)
                    netWeightProperty = GetDecimalProperty("Part.NetWeight");
                netWeightProperty.Value = value;
            }
        }

        protected RowProperty<bool> usePartRevProperty;
        public bool UsePartRev
        {
            get
            {
                if (usePartRevProperty == null)
                    usePartRevProperty = GetBooleanProperty("Part.UsePartRev");
                return usePartRevProperty.Value;
            }
            set
            {
                if (usePartRevProperty == null)
                    usePartRevProperty = GetBooleanProperty("Part.UsePartRev");
                usePartRevProperty.Value = value;
            }
        }

        protected RowProperty<int> partsPerContainerProperty;
        public int PartsPerContainer
        {
            get
            {
                if (partsPerContainerProperty == null)
                    partsPerContainerProperty = GetIntegerProperty("Part.PartsPerContainer");
                return partsPerContainerProperty.Value;
            }
            set
            {
                if (partsPerContainerProperty == null)
                    partsPerContainerProperty = GetIntegerProperty("Part.PartsPerContainer");
                partsPerContainerProperty.Value = value;
            }
        }

        protected RowProperty<decimal> partLengthProperty;
        public decimal PartLength
        {
            get
            {
                if (partLengthProperty == null)
                    partLengthProperty = GetDecimalProperty("Part.PartLength");
                return partLengthProperty.Value;
            }
            set
            {
                if (partLengthProperty == null)
                    partLengthProperty = GetDecimalProperty("Part.PartLength");
                partLengthProperty.Value = value;
            }
        }

        protected RowProperty<decimal> partWidthProperty;
        public decimal PartWidth
        {
            get
            {
                if (partWidthProperty == null)
                    partWidthProperty = GetDecimalProperty("Part.PartWidth");
                return partWidthProperty.Value;
            }
            set
            {
                if (partWidthProperty == null)
                    partWidthProperty = GetDecimalProperty("Part.PartWidth");
                partWidthProperty.Value = value;
            }
        }

        protected RowProperty<decimal> partHeightProperty;
        public decimal PartHeight
        {
            get
            {
                if (partHeightProperty == null)
                    partHeightProperty = GetDecimalProperty("Part.PartHeight");
                return partHeightProperty.Value;
            }
            set
            {
                if (partHeightProperty == null)
                    partHeightProperty = GetDecimalProperty("Part.PartHeight");
                partHeightProperty.Value = value;
            }
        }

        protected RowProperty<int> lotShelfLifeProperty;
        public int LotShelfLife
        {
            get
            {
                if (lotShelfLifeProperty == null)
                    lotShelfLifeProperty = GetIntegerProperty("Part.LotShelfLife");
                return lotShelfLifeProperty.Value;
            }
            set
            {
                if (lotShelfLifeProperty == null)
                    lotShelfLifeProperty = GetIntegerProperty("Part.LotShelfLife");
                lotShelfLifeProperty.Value = value;
            }
        }

        protected RowProperty<bool> webPartProperty;
        public bool WebPart
        {
            get
            {
                if (webPartProperty == null)
                    webPartProperty = GetBooleanProperty("Part.WebPart");
                return webPartProperty.Value;
            }
            set
            {
                if (webPartProperty == null)
                    webPartProperty = GetBooleanProperty("Part.WebPart");
                webPartProperty.Value = value;
            }
        }

        protected RowProperty<bool> runOutProperty;
        public bool RunOut
        {
            get
            {
                if (runOutProperty == null)
                    runOutProperty = GetBooleanProperty("Part.RunOut");
                return runOutProperty.Value;
            }
            set
            {
                if (runOutProperty == null)
                    runOutProperty = GetBooleanProperty("Part.RunOut");
                runOutProperty.Value = value;
            }
        }

        protected RowProperty<string> subPartProperty;
        public string SubPart
        {
            get
            {
                if (subPartProperty == null)
                    subPartProperty = GetStringProperty("Part.SubPart");
                return subPartProperty.Value;
            }
            set
            {
                if (subPartProperty == null)
                    subPartProperty = GetStringProperty("Part.SubPart");
                subPartProperty.Value = value;
            }
        }

        protected RowProperty<decimal> diameterProperty;
        public decimal Diameter
        {
            get
            {
                if (diameterProperty == null)
                    diameterProperty = GetDecimalProperty("Part.Diameter");
                return diameterProperty.Value;
            }
            set
            {
                if (diameterProperty == null)
                    diameterProperty = GetDecimalProperty("Part.Diameter");
                diameterProperty.Value = value;
            }
        }

        protected RowProperty<decimal> gravityProperty;
        public decimal Gravity
        {
            get
            {
                if (gravityProperty == null)
                    gravityProperty = GetDecimalProperty("Part.Gravity");
                return gravityProperty.Value;
            }
            set
            {
                if (gravityProperty == null)
                    gravityProperty = GetDecimalProperty("Part.Gravity");
                gravityProperty.Value = value;
            }
        }

        protected RowProperty<bool> onHoldProperty;
        public bool OnHold
        {
            get
            {
                if (onHoldProperty == null)
                    onHoldProperty = GetBooleanProperty("Part.OnHold");
                return onHoldProperty.Value;
            }
            set
            {
                if (onHoldProperty == null)
                    onHoldProperty = GetBooleanProperty("Part.OnHold");
                onHoldProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> onHoldDateProperty;
        public DateTime OnHoldDate
        {
            get
            {
                if (onHoldDateProperty == null)
                    onHoldDateProperty = GetDateTimeProperty("Part.OnHoldDate");
                return onHoldDateProperty.Value;
            }
            set
            {
                if (onHoldDateProperty == null)
                    onHoldDateProperty = GetDateTimeProperty("Part.OnHoldDate");
                onHoldDateProperty.Value = value;
            }
        }

        protected RowProperty<string> onHoldReasonCodeProperty;
        public string OnHoldReasonCode
        {
            get
            {
                if (onHoldReasonCodeProperty == null)
                    onHoldReasonCodeProperty = GetStringProperty("Part.OnHoldReasonCode");
                return onHoldReasonCodeProperty.Value;
            }
            set
            {
                if (onHoldReasonCodeProperty == null)
                    onHoldReasonCodeProperty = GetStringProperty("Part.OnHoldReasonCode");
                onHoldReasonCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> analysisCodeProperty;
        public string AnalysisCode
        {
            get
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("Part.AnalysisCode");
                return analysisCodeProperty.Value;
            }
            set
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("Part.AnalysisCode");
                analysisCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> globalPartProperty;
        public bool GlobalPart
        {
            get
            {
                if (globalPartProperty == null)
                    globalPartProperty = GetBooleanProperty("Part.GlobalPart");
                return globalPartProperty.Value;
            }
            set
            {
                if (globalPartProperty == null)
                    globalPartProperty = GetBooleanProperty("Part.GlobalPart");
                globalPartProperty.Value = value;
            }
        }

        protected RowProperty<string> mtlAnalysisCodeProperty;
        public string Mtl_AnalysisCode
        {
            get
            {
                if (mtlAnalysisCodeProperty == null)
                    mtlAnalysisCodeProperty = GetStringProperty("Part.Mtl_AnalysisCode");
                return mtlAnalysisCodeProperty.Value;
            }
            set
            {
                if (mtlAnalysisCodeProperty == null)
                    mtlAnalysisCodeProperty = GetStringProperty("Part.Mtl_AnalysisCode");
                mtlAnalysisCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> iSSuppUnitsFactorProperty;
        public decimal ISSuppUnitsFactor
        {
            get
            {
                if (iSSuppUnitsFactorProperty == null)
                    iSSuppUnitsFactorProperty = GetDecimalProperty("Part.ISSuppUnitsFactor");
                return iSSuppUnitsFactorProperty.Value;
            }
            set
            {
                if (iSSuppUnitsFactorProperty == null)
                    iSSuppUnitsFactorProperty = GetDecimalProperty("Part.ISSuppUnitsFactor");
                iSSuppUnitsFactorProperty.Value = value;
            }
        }

        protected RowProperty<bool> globalLockProperty;
        public bool GlobalLock
        {
            get
            {
                if (globalLockProperty == null)
                    globalLockProperty = GetBooleanProperty("Part.GlobalLock");
                return globalLockProperty.Value;
            }
            set
            {
                if (globalLockProperty == null)
                    globalLockProperty = GetBooleanProperty("Part.GlobalLock");
                globalLockProperty.Value = value;
            }
        }

        protected RowProperty<string> pDMObjIDProperty;
        public string PDMObjID
        {
            get
            {
                if (pDMObjIDProperty == null)
                    pDMObjIDProperty = GetStringProperty("Part.PDMObjID");
                return pDMObjIDProperty.Value;
            }
            set
            {
                if (pDMObjIDProperty == null)
                    pDMObjIDProperty = GetStringProperty("Part.PDMObjID");
                pDMObjIDProperty.Value = value;
            }
        }

        protected RowProperty<string> imageFileNameProperty;
        public string ImageFileName
        {
            get
            {
                if (imageFileNameProperty == null)
                    imageFileNameProperty = GetStringProperty("Part.ImageFileName");
                return imageFileNameProperty.Value;
            }
            set
            {
                if (imageFileNameProperty == null)
                    imageFileNameProperty = GetStringProperty("Part.ImageFileName");
                imageFileNameProperty.Value = value;
            }
        }

        protected RowProperty<string> sNRequiredWhenInProperty;
        public string SNRequiredWhenIn
        {
            get
            {
                if (sNRequiredWhenInProperty == null)
                    sNRequiredWhenInProperty = GetStringProperty("Part.SNRequiredWhenIn");
                return sNRequiredWhenInProperty.Value;
            }
            set
            {
                if (sNRequiredWhenInProperty == null)
                    sNRequiredWhenInProperty = GetStringProperty("Part.SNRequiredWhenIn");
                sNRequiredWhenInProperty.Value = value;
            }
        }

        protected RowProperty<string> iSOrigCountryProperty;
        public string ISOrigCountry
        {
            get
            {
                if (iSOrigCountryProperty == null)
                    iSOrigCountryProperty = GetStringProperty("Part.ISOrigCountry");
                return iSOrigCountryProperty.Value;
            }
            set
            {
                if (iSOrigCountryProperty == null)
                    iSOrigCountryProperty = GetStringProperty("Part.ISOrigCountry");
                iSOrigCountryProperty.Value = value;
            }
        }

        protected RowProperty<string> sNFormatProperty;
        public string SNFormat
        {
            get
            {
                if (sNFormatProperty == null)
                    sNFormatProperty = GetStringProperty("Part.SNFormat");
                return sNFormatProperty.Value;
            }
            set
            {
                if (sNFormatProperty == null)
                    sNFormatProperty = GetStringProperty("Part.SNFormat");
                sNFormatProperty.Value = value;
            }
        }

        protected RowProperty<string> sNPrefixProperty;
        public string SNPrefix
        {
            get
            {
                if (sNPrefixProperty == null)
                    sNPrefixProperty = GetStringProperty("Part.SNPrefix");
                return sNPrefixProperty.Value;
            }
            set
            {
                if (sNPrefixProperty == null)
                    sNPrefixProperty = GetStringProperty("Part.SNPrefix");
                sNPrefixProperty.Value = value;
            }
        }

        protected RowProperty<string> sNBaseDataTypeProperty;
        public string SNBaseDataType
        {
            get
            {
                if (sNBaseDataTypeProperty == null)
                    sNBaseDataTypeProperty = GetStringProperty("Part.SNBaseDataType");
                return sNBaseDataTypeProperty.Value;
            }
            set
            {
                if (sNBaseDataTypeProperty == null)
                    sNBaseDataTypeProperty = GetStringProperty("Part.SNBaseDataType");
                sNBaseDataTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> constrainedProperty;
        public bool Constrained
        {
            get
            {
                if (constrainedProperty == null)
                    constrainedProperty = GetBooleanProperty("Part.Constrained");
                return constrainedProperty.Value;
            }
            set
            {
                if (constrainedProperty == null)
                    constrainedProperty = GetBooleanProperty("Part.Constrained");
                constrainedProperty.Value = value;
            }
        }

        protected RowProperty<string> uPCCode1Property;
        public string UPCCode1
        {
            get
            {
                if (uPCCode1Property == null)
                    uPCCode1Property = GetStringProperty("Part.UPCCode1");
                return uPCCode1Property.Value;
            }
            set
            {
                if (uPCCode1Property == null)
                    uPCCode1Property = GetStringProperty("Part.UPCCode1");
                uPCCode1Property.Value = value;
            }
        }

        protected RowProperty<string> uPCCode2Property;
        public string UPCCode2
        {
            get
            {
                if (uPCCode2Property == null)
                    uPCCode2Property = GetStringProperty("Part.UPCCode2");
                return uPCCode2Property.Value;
            }
            set
            {
                if (uPCCode2Property == null)
                    uPCCode2Property = GetStringProperty("Part.UPCCode2");
                uPCCode2Property.Value = value;
            }
        }

        protected RowProperty<string> uPCCode3Property;
        public string UPCCode3
        {
            get
            {
                if (uPCCode3Property == null)
                    uPCCode3Property = GetStringProperty("Part.UPCCode3");
                return uPCCode3Property.Value;
            }
            set
            {
                if (uPCCode3Property == null)
                    uPCCode3Property = GetStringProperty("Part.UPCCode3");
                uPCCode3Property.Value = value;
            }
        }

        protected RowProperty<string> eDICodeProperty;
        public string EDICode
        {
            get
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("Part.EDICode");
                return eDICodeProperty.Value;
            }
            set
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("Part.EDICode");
                eDICodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> consolidatedPurchasingProperty;
        public bool ConsolidatedPurchasing
        {
            get
            {
                if (consolidatedPurchasingProperty == null)
                    consolidatedPurchasingProperty = GetBooleanProperty("Part.ConsolidatedPurchasing");
                return consolidatedPurchasingProperty.Value;
            }
            set
            {
                if (consolidatedPurchasingProperty == null)
                    consolidatedPurchasingProperty = GetBooleanProperty("Part.ConsolidatedPurchasing");
                consolidatedPurchasingProperty.Value = value;
            }
        }

        protected RowProperty<bool> webInStockProperty;
        public bool WebInStock
        {
            get
            {
                if (webInStockProperty == null)
                    webInStockProperty = GetBooleanProperty("Part.WebInStock");
                return webInStockProperty.Value;
            }
            set
            {
                if (webInStockProperty == null)
                    webInStockProperty = GetBooleanProperty("Part.WebInStock");
                webInStockProperty.Value = value;
            }
        }

        protected RowProperty<string> purchasingFactorDirectionProperty;
        public string PurchasingFactorDirection
        {
            get
            {
                if (purchasingFactorDirectionProperty == null)
                    purchasingFactorDirectionProperty = GetStringProperty("Part.PurchasingFactorDirection");
                return purchasingFactorDirectionProperty.Value;
            }
            set
            {
                if (purchasingFactorDirectionProperty == null)
                    purchasingFactorDirectionProperty = GetStringProperty("Part.PurchasingFactorDirection");
                purchasingFactorDirectionProperty.Value = value;
            }
        }

        protected RowProperty<string> sellingFactorDirectionProperty;
        public string SellingFactorDirection
        {
            get
            {
                if (sellingFactorDirectionProperty == null)
                    sellingFactorDirectionProperty = GetStringProperty("Part.SellingFactorDirection");
                return sellingFactorDirectionProperty.Value;
            }
            set
            {
                if (sellingFactorDirectionProperty == null)
                    sellingFactorDirectionProperty = GetStringProperty("Part.SellingFactorDirection");
                sellingFactorDirectionProperty.Value = value;
            }
        }

        protected RowProperty<int> mdpvProperty;
        public int MDPV
        {
            get
            {
                if (mdpvProperty == null)
                    mdpvProperty = GetIntegerProperty("Part.MDPV");
                return mdpvProperty.Value;
            }
            set
            {
                if (mdpvProperty == null)
                    mdpvProperty = GetIntegerProperty("Part.MDPV");
                mdpvProperty.Value = value;
            }
        }

        protected RowProperty<string> returnableContainerProperty;
        public string ReturnableContainer
        {
            get
            {
                if (returnableContainerProperty == null)
                    returnableContainerProperty = GetStringProperty("Part.ReturnableContainer");
                return returnableContainerProperty.Value;
            }
            set
            {
                if (returnableContainerProperty == null)
                    returnableContainerProperty = GetStringProperty("Part.ReturnableContainer");
                returnableContainerProperty.Value = value;
            }
        }

        protected RowProperty<bool> recDocReqProperty;
        public bool RecDocReq
        {
            get
            {
                if (recDocReqProperty == null)
                    recDocReqProperty = GetBooleanProperty("Part.RecDocReq");
                return recDocReqProperty.Value;
            }
            set
            {
                if (recDocReqProperty == null)
                    recDocReqProperty = GetBooleanProperty("Part.RecDocReq");
                recDocReqProperty.Value = value;
            }
        }

        protected RowProperty<bool> shipDocReqProperty;
        public bool ShipDocReq
        {
            get
            {
                if (shipDocReqProperty == null)
                    shipDocReqProperty = GetBooleanProperty("Part.ShipDocReq");
                return shipDocReqProperty.Value;
            }
            set
            {
                if (shipDocReqProperty == null)
                    shipDocReqProperty = GetBooleanProperty("Part.ShipDocReq");
                shipDocReqProperty.Value = value;
            }
        }

        protected RowProperty<decimal> netVolumeProperty;
        public decimal NetVolume
        {
            get
            {
                if (netVolumeProperty == null)
                    netVolumeProperty = GetDecimalProperty("Part.NetVolume");
                return netVolumeProperty.Value;
            }
            set
            {
                if (netVolumeProperty == null)
                    netVolumeProperty = GetDecimalProperty("Part.NetVolume");
                netVolumeProperty.Value = value;
            }
        }

        protected RowProperty<bool> qtyBearingProperty;
        public bool QtyBearing
        {
            get
            {
                if (qtyBearingProperty == null)
                    qtyBearingProperty = GetBooleanProperty("Part.QtyBearing");
                return qtyBearingProperty.Value;
            }
            set
            {
                if (qtyBearingProperty == null)
                    qtyBearingProperty = GetBooleanProperty("Part.QtyBearing");
                qtyBearingProperty.Value = value;
            }
        }

        protected RowProperty<string> hazSubProperty;
        public string HazSub
        {
            get
            {
                if (hazSubProperty == null)
                    hazSubProperty = GetStringProperty("Part.HazSub");
                return hazSubProperty.Value;
            }
            set
            {
                if (hazSubProperty == null)
                    hazSubProperty = GetStringProperty("Part.HazSub");
                hazSubProperty.Value = value;
            }
        }

        protected RowProperty<string> hazGvrnmtIDProperty;
        public string HazGvrnmtID
        {
            get
            {
                if (hazGvrnmtIDProperty == null)
                    hazGvrnmtIDProperty = GetStringProperty("Part.HazGvrnmtID");
                return hazGvrnmtIDProperty.Value;
            }
            set
            {
                if (hazGvrnmtIDProperty == null)
                    hazGvrnmtIDProperty = GetStringProperty("Part.HazGvrnmtID");
                hazGvrnmtIDProperty.Value = value;
            }
        }

        protected RowProperty<string> hazPackInstrProperty;
        public string HazPackInstr
        {
            get
            {
                if (hazPackInstrProperty == null)
                    hazPackInstrProperty = GetStringProperty("Part.HazPackInstr");
                return hazPackInstrProperty.Value;
            }
            set
            {
                if (hazPackInstrProperty == null)
                    hazPackInstrProperty = GetStringProperty("Part.HazPackInstr");
                hazPackInstrProperty.Value = value;
            }
        }

        protected RowProperty<string> nAFTAOrigCountryProperty;
        public string NAFTAOrigCountry
        {
            get
            {
                if (nAFTAOrigCountryProperty == null)
                    nAFTAOrigCountryProperty = GetStringProperty("Part.NAFTAOrigCountry");
                return nAFTAOrigCountryProperty.Value;
            }
            set
            {
                if (nAFTAOrigCountryProperty == null)
                    nAFTAOrigCountryProperty = GetStringProperty("Part.NAFTAOrigCountry");
                nAFTAOrigCountryProperty.Value = value;
            }
        }

        protected RowProperty<string> nAFTAProdProperty;
        public string NAFTAProd
        {
            get
            {
                if (nAFTAProdProperty == null)
                    nAFTAProdProperty = GetStringProperty("Part.NAFTAProd");
                return nAFTAProdProperty.Value;
            }
            set
            {
                if (nAFTAProdProperty == null)
                    nAFTAProdProperty = GetStringProperty("Part.NAFTAProd");
                nAFTAProdProperty.Value = value;
            }
        }

        protected RowProperty<string> nAFTAPrefProperty;
        public string NAFTAPref
        {
            get
            {
                if (nAFTAPrefProperty == null)
                    nAFTAPrefProperty = GetStringProperty("Part.NAFTAPref");
                return nAFTAPrefProperty.Value;
            }
            set
            {
                if (nAFTAPrefProperty == null)
                    nAFTAPrefProperty = GetStringProperty("Part.NAFTAPref");
                nAFTAPrefProperty.Value = value;
            }
        }

        protected RowProperty<string> expLicTypeProperty;
        public string ExpLicType
        {
            get
            {
                if (expLicTypeProperty == null)
                    expLicTypeProperty = GetStringProperty("Part.ExpLicType");
                return expLicTypeProperty.Value;
            }
            set
            {
                if (expLicTypeProperty == null)
                    expLicTypeProperty = GetStringProperty("Part.ExpLicType");
                expLicTypeProperty.Value = value;
            }
        }

        protected RowProperty<string> expLicNumberProperty;
        public string ExpLicNumber
        {
            get
            {
                if (expLicNumberProperty == null)
                    expLicNumberProperty = GetStringProperty("Part.ExpLicNumber");
                return expLicNumberProperty.Value;
            }
            set
            {
                if (expLicNumberProperty == null)
                    expLicNumberProperty = GetStringProperty("Part.ExpLicNumber");
                expLicNumberProperty.Value = value;
            }
        }

        protected RowProperty<string> eCCNNumberProperty;
        public string ECCNNumber
        {
            get
            {
                if (eCCNNumberProperty == null)
                    eCCNNumberProperty = GetStringProperty("Part.ECCNNumber");
                return eCCNNumberProperty.Value;
            }
            set
            {
                if (eCCNNumberProperty == null)
                    eCCNNumberProperty = GetStringProperty("Part.ECCNNumber");
                eCCNNumberProperty.Value = value;
            }
        }

        protected RowProperty<string> aESExpProperty;
        public string AESExp
        {
            get
            {
                if (aESExpProperty == null)
                    aESExpProperty = GetStringProperty("Part.AESExp");
                return aESExpProperty.Value;
            }
            set
            {
                if (aESExpProperty == null)
                    aESExpProperty = GetStringProperty("Part.AESExp");
                aESExpProperty.Value = value;
            }
        }

        protected RowProperty<string> htsProperty;
        public string HTS
        {
            get
            {
                if (htsProperty == null)
                    htsProperty = GetStringProperty("Part.HTS");
                return htsProperty.Value;
            }
            set
            {
                if (htsProperty == null)
                    htsProperty = GetStringProperty("Part.HTS");
                htsProperty.Value = value;
            }
        }

        protected RowProperty<bool> useHTSDescProperty;
        public bool UseHTSDesc
        {
            get
            {
                if (useHTSDescProperty == null)
                    useHTSDescProperty = GetBooleanProperty("Part.UseHTSDesc");
                return useHTSDescProperty.Value;
            }
            set
            {
                if (useHTSDescProperty == null)
                    useHTSDescProperty = GetBooleanProperty("Part.UseHTSDesc");
                useHTSDescProperty.Value = value;
            }
        }

        protected RowProperty<string> schedBcodeProperty;
        public string SchedBcode
        {
            get
            {
                if (schedBcodeProperty == null)
                    schedBcodeProperty = GetStringProperty("Part.SchedBcode");
                return schedBcodeProperty.Value;
            }
            set
            {
                if (schedBcodeProperty == null)
                    schedBcodeProperty = GetStringProperty("Part.SchedBcode");
                schedBcodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> hazItemProperty;
        public bool HazItem
        {
            get
            {
                if (hazItemProperty == null)
                    hazItemProperty = GetBooleanProperty("Part.HazItem");
                return hazItemProperty.Value;
            }
            set
            {
                if (hazItemProperty == null)
                    hazItemProperty = GetBooleanProperty("Part.HazItem");
                hazItemProperty.Value = value;
            }
        }

        protected RowProperty<string> hazTechNameProperty;
        public string HazTechName
        {
            get
            {
                if (hazTechNameProperty == null)
                    hazTechNameProperty = GetStringProperty("Part.HazTechName");
                return hazTechNameProperty.Value;
            }
            set
            {
                if (hazTechNameProperty == null)
                    hazTechNameProperty = GetStringProperty("Part.HazTechName");
                hazTechNameProperty.Value = value;
            }
        }

        protected RowProperty<string> hazClassProperty;
        public string HazClass
        {
            get
            {
                if (hazClassProperty == null)
                    hazClassProperty = GetStringProperty("Part.HazClass");
                return hazClassProperty.Value;
            }
            set
            {
                if (hazClassProperty == null)
                    hazClassProperty = GetStringProperty("Part.HazClass");
                hazClassProperty.Value = value;
            }
        }

        protected RowProperty<string> revChargeMethodProperty;
        public string RevChargeMethod
        {
            get
            {
                if (revChargeMethodProperty == null)
                    revChargeMethodProperty = GetStringProperty("Part.RevChargeMethod");
                return revChargeMethodProperty.Value;
            }
            set
            {
                if (revChargeMethodProperty == null)
                    revChargeMethodProperty = GetStringProperty("Part.RevChargeMethod");
                revChargeMethodProperty.Value = value;
            }
        }

        protected RowProperty<decimal> rCUnderThresholdProperty;
        public decimal RCUnderThreshold
        {
            get
            {
                if (rCUnderThresholdProperty == null)
                    rCUnderThresholdProperty = GetDecimalProperty("Part.RCUnderThreshold");
                return rCUnderThresholdProperty.Value;
            }
            set
            {
                if (rCUnderThresholdProperty == null)
                    rCUnderThresholdProperty = GetDecimalProperty("Part.RCUnderThreshold");
                rCUnderThresholdProperty.Value = value;
            }
        }

        protected RowProperty<decimal> rCOverThresholdProperty;
        public decimal RCOverThreshold
        {
            get
            {
                if (rCOverThresholdProperty == null)
                    rCOverThresholdProperty = GetDecimalProperty("Part.RCOverThreshold");
                return rCOverThresholdProperty.Value;
            }
            set
            {
                if (rCOverThresholdProperty == null)
                    rCOverThresholdProperty = GetDecimalProperty("Part.RCOverThreshold");
                rCOverThresholdProperty.Value = value;
            }
        }

        protected RowProperty<string> ownershipStatusProperty;
        public string OwnershipStatus
        {
            get
            {
                if (ownershipStatusProperty == null)
                    ownershipStatusProperty = GetStringProperty("Part.OwnershipStatus");
                return ownershipStatusProperty.Value;
            }
            set
            {
                if (ownershipStatusProperty == null)
                    ownershipStatusProperty = GetStringProperty("Part.OwnershipStatus");
                ownershipStatusProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region PODetail Table

    [Serializable()]
    public abstract partial class PODetailBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PODetailBase<T, R>, new()
        where R : PODetailRow, new()
    {
        protected PODetailBase() : base() { }

        protected static Schema.PODetail schemaTable;
        public static Schema.PODetail SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PODetail)V8Schema.Instance.TablesDictionary["PODetail"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PODetail.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPONUMCriteria;
        public static T FillByPONUM(DataContext context, string companyNum, int ponum, params string[] columnNames)
        {
            if (fillByPONUMCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PODetail.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PODetail.PONUM]));
                fillByPONUMCriteria = list.ToArray();
            }
            fillByPONUMCriteria[0].Value = companyNum;
            fillByPONUMCriteria[1].Value = ponum;
            return EditTable<T, R>.Fetch(context, fillByPONUMCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPOLineCriteria;
        public static T FillByPOLine(DataContext context, string companyNum, int ponum, int pOLine, params string[] columnNames)
        {
            if (fillByPOLineCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PODetail.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PODetail.PONUM]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PODetail.POLine]));
                fillByPOLineCriteria = list.ToArray();
            }
            fillByPOLineCriteria[0].Value = companyNum;
            fillByPOLineCriteria[1].Value = ponum;
            fillByPOLineCriteria[2].Value = pOLine;
            return EditTable<T, R>.Fetch(context, fillByPOLineCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PODetail : PODetailBase<PODetail, PODetailRow>
    {
        public PODetail() : base() { }
    }

    #region PODetailRow

    [Serializable()]
    public class PODetailRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PODetail.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PODetail.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> voidLineProperty;
        public bool VoidLine
        {
            get
            {
                if (voidLineProperty == null)
                    voidLineProperty = GetBooleanProperty("PODetail.VoidLine");
                return voidLineProperty.Value;
            }
            set
            {
                if (voidLineProperty == null)
                    voidLineProperty = GetBooleanProperty("PODetail.VoidLine");
                voidLineProperty.Value = value;
            }
        }

        protected RowProperty<int> ponumProperty;
        public int PONUM
        {
            get
            {
                if (ponumProperty == null)
                    ponumProperty = GetIntegerProperty("PODetail.PONUM");
                return ponumProperty.Value;
            }
            set
            {
                if (ponumProperty == null)
                    ponumProperty = GetIntegerProperty("PODetail.PONUM");
                ponumProperty.Value = value;
            }
        }

        protected RowProperty<bool> taxableProperty;
        public bool Taxable
        {
            get
            {
                if (taxableProperty == null)
                    taxableProperty = GetBooleanProperty("PODetail.Taxable");
                return taxableProperty.Value;
            }
            set
            {
                if (taxableProperty == null)
                    taxableProperty = GetBooleanProperty("PODetail.Taxable");
                taxableProperty.Value = value;
            }
        }

        protected RowProperty<decimal> orderQtyProperty;
        public decimal OrderQty
        {
            get
            {
                if (orderQtyProperty == null)
                    orderQtyProperty = GetDecimalProperty("PODetail.OrderQty");
                return orderQtyProperty.Value;
            }
            set
            {
                if (orderQtyProperty == null)
                    orderQtyProperty = GetDecimalProperty("PODetail.OrderQty");
                orderQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> iumProperty;
        public string IUM
        {
            get
            {
                if (iumProperty == null)
                    iumProperty = GetStringProperty("PODetail.IUM");
                return iumProperty.Value;
            }
            set
            {
                if (iumProperty == null)
                    iumProperty = GetStringProperty("PODetail.IUM");
                iumProperty.Value = value;
            }
        }

        protected RowProperty<bool> openLineProperty;
        public bool OpenLine
        {
            get
            {
                if (openLineProperty == null)
                    openLineProperty = GetBooleanProperty("PODetail.OpenLine");
                return openLineProperty.Value;
            }
            set
            {
                if (openLineProperty == null)
                    openLineProperty = GetBooleanProperty("PODetail.OpenLine");
                openLineProperty.Value = value;
            }
        }

        protected RowProperty<int> pOLineProperty;
        public int POLine
        {
            get
            {
                if (pOLineProperty == null)
                    pOLineProperty = GetIntegerProperty("PODetail.POLine");
                return pOLineProperty.Value;
            }
            set
            {
                if (pOLineProperty == null)
                    pOLineProperty = GetIntegerProperty("PODetail.POLine");
                pOLineProperty.Value = value;
            }
        }

        protected RowProperty<decimal> xOrderQtyProperty;
        public decimal XOrderQty
        {
            get
            {
                if (xOrderQtyProperty == null)
                    xOrderQtyProperty = GetDecimalProperty("PODetail.XOrderQty");
                return xOrderQtyProperty.Value;
            }
            set
            {
                if (xOrderQtyProperty == null)
                    xOrderQtyProperty = GetDecimalProperty("PODetail.XOrderQty");
                xOrderQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> unitCostProperty;
        public decimal UnitCost
        {
            get
            {
                if (unitCostProperty == null)
                    unitCostProperty = GetDecimalProperty("PODetail.UnitCost");
                return unitCostProperty.Value;
            }
            set
            {
                if (unitCostProperty == null)
                    unitCostProperty = GetDecimalProperty("PODetail.UnitCost");
                unitCostProperty.Value = value;
            }
        }

        protected RowProperty<string> commentTextProperty;
        public string CommentText
        {
            get
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("PODetail.CommentText");
                return commentTextProperty.Value;
            }
            set
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("PODetail.CommentText");
                commentTextProperty.Value = value;
            }
        }

        protected RowProperty<string> pumProperty;
        public string PUM
        {
            get
            {
                if (pumProperty == null)
                    pumProperty = GetStringProperty("PODetail.PUM");
                return pumProperty.Value;
            }
            set
            {
                if (pumProperty == null)
                    pumProperty = GetStringProperty("PODetail.PUM");
                pumProperty.Value = value;
            }
        }

        protected RowProperty<string> lineDescProperty;
        public string LineDesc
        {
            get
            {
                if (lineDescProperty == null)
                    lineDescProperty = GetStringProperty("PODetail.LineDesc");
                return lineDescProperty.Value;
            }
            set
            {
                if (lineDescProperty == null)
                    lineDescProperty = GetStringProperty("PODetail.LineDesc");
                lineDescProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PODetail.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PODetail.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> costPerCodeProperty;
        public string CostPerCode
        {
            get
            {
                if (costPerCodeProperty == null)
                    costPerCodeProperty = GetStringProperty("PODetail.CostPerCode");
                return costPerCodeProperty.Value;
            }
            set
            {
                if (costPerCodeProperty == null)
                    costPerCodeProperty = GetStringProperty("PODetail.CostPerCode");
                costPerCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> venPartNumProperty;
        public string VenPartNum
        {
            get
            {
                if (venPartNumProperty == null)
                    venPartNumProperty = GetStringProperty("PODetail.VenPartNum");
                return venPartNumProperty.Value;
            }
            set
            {
                if (venPartNumProperty == null)
                    venPartNumProperty = GetStringProperty("PODetail.VenPartNum");
                venPartNumProperty.Value = value;
            }
        }

        protected RowProperty<string> classIDProperty;
        public string ClassID
        {
            get
            {
                if (classIDProperty == null)
                    classIDProperty = GetStringProperty("PODetail.ClassID");
                return classIDProperty.Value;
            }
            set
            {
                if (classIDProperty == null)
                    classIDProperty = GetStringProperty("PODetail.ClassID");
                classIDProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumProperty;
        public string RevisionNum
        {
            get
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PODetail.RevisionNum");
                return revisionNumProperty.Value;
            }
            set
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PODetail.RevisionNum");
                revisionNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> rcvInspectionReqProperty;
        public bool RcvInspectionReq
        {
            get
            {
                if (rcvInspectionReqProperty == null)
                    rcvInspectionReqProperty = GetBooleanProperty("PODetail.RcvInspectionReq");
                return rcvInspectionReqProperty.Value;
            }
            set
            {
                if (rcvInspectionReqProperty == null)
                    rcvInspectionReqProperty = GetBooleanProperty("PODetail.RcvInspectionReq");
                rcvInspectionReqProperty.Value = value;
            }
        }

        protected RowProperty<decimal> docUnitCostProperty;
        public decimal DocUnitCost
        {
            get
            {
                if (docUnitCostProperty == null)
                    docUnitCostProperty = GetDecimalProperty("PODetail.DocUnitCost");
                return docUnitCostProperty.Value;
            }
            set
            {
                if (docUnitCostProperty == null)
                    docUnitCostProperty = GetDecimalProperty("PODetail.DocUnitCost");
                docUnitCostProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("PODetail.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("PODetail.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> advancePayBalProperty;
        public decimal AdvancePayBal
        {
            get
            {
                if (advancePayBalProperty == null)
                    advancePayBalProperty = GetDecimalProperty("PODetail.AdvancePayBal");
                return advancePayBalProperty.Value;
            }
            set
            {
                if (advancePayBalProperty == null)
                    advancePayBalProperty = GetDecimalProperty("PODetail.AdvancePayBal");
                advancePayBalProperty.Value = value;
            }
        }

        protected RowProperty<decimal> docAdvancePayBalProperty;
        public decimal DocAdvancePayBal
        {
            get
            {
                if (docAdvancePayBalProperty == null)
                    docAdvancePayBalProperty = GetDecimalProperty("PODetail.DocAdvancePayBal");
                return docAdvancePayBalProperty.Value;
            }
            set
            {
                if (docAdvancePayBalProperty == null)
                    docAdvancePayBalProperty = GetDecimalProperty("PODetail.DocAdvancePayBal");
                docAdvancePayBalProperty.Value = value;
            }
        }

        protected RowProperty<bool> confirmedProperty;
        public bool Confirmed
        {
            get
            {
                if (confirmedProperty == null)
                    confirmedProperty = GetBooleanProperty("PODetail.Confirmed");
                return confirmedProperty.Value;
            }
            set
            {
                if (confirmedProperty == null)
                    confirmedProperty = GetBooleanProperty("PODetail.Confirmed");
                confirmedProperty.Value = value;
            }
        }

        protected RowProperty<bool> dateChgReqProperty;
        public bool DateChgReq
        {
            get
            {
                if (dateChgReqProperty == null)
                    dateChgReqProperty = GetBooleanProperty("PODetail.DateChgReq");
                return dateChgReqProperty.Value;
            }
            set
            {
                if (dateChgReqProperty == null)
                    dateChgReqProperty = GetBooleanProperty("PODetail.DateChgReq");
                dateChgReqProperty.Value = value;
            }
        }

        protected RowProperty<bool> qtyChgReqProperty;
        public bool QtyChgReq
        {
            get
            {
                if (qtyChgReqProperty == null)
                    qtyChgReqProperty = GetBooleanProperty("PODetail.QtyChgReq");
                return qtyChgReqProperty.Value;
            }
            set
            {
                if (qtyChgReqProperty == null)
                    qtyChgReqProperty = GetBooleanProperty("PODetail.QtyChgReq");
                qtyChgReqProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumChgReqProperty;
        public string PartNumChgReq
        {
            get
            {
                if (partNumChgReqProperty == null)
                    partNumChgReqProperty = GetStringProperty("PODetail.PartNumChgReq");
                return partNumChgReqProperty.Value;
            }
            set
            {
                if (partNumChgReqProperty == null)
                    partNumChgReqProperty = GetStringProperty("PODetail.PartNumChgReq");
                partNumChgReqProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumChgReqProperty;
        public string RevisionNumChgReq
        {
            get
            {
                if (revisionNumChgReqProperty == null)
                    revisionNumChgReqProperty = GetStringProperty("PODetail.RevisionNumChgReq");
                return revisionNumChgReqProperty.Value;
            }
            set
            {
                if (revisionNumChgReqProperty == null)
                    revisionNumChgReqProperty = GetStringProperty("PODetail.RevisionNumChgReq");
                revisionNumChgReqProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> confirmDateProperty;
        public DateTime ConfirmDate
        {
            get
            {
                if (confirmDateProperty == null)
                    confirmDateProperty = GetDateTimeProperty("PODetail.ConfirmDate");
                return confirmDateProperty.Value;
            }
            set
            {
                if (confirmDateProperty == null)
                    confirmDateProperty = GetDateTimeProperty("PODetail.ConfirmDate");
                confirmDateProperty.Value = value;
            }
        }

        protected RowProperty<string> confirmViaProperty;
        public string ConfirmVia
        {
            get
            {
                if (confirmViaProperty == null)
                    confirmViaProperty = GetStringProperty("PODetail.ConfirmVia");
                return confirmViaProperty.Value;
            }
            set
            {
                if (confirmViaProperty == null)
                    confirmViaProperty = GetStringProperty("PODetail.ConfirmVia");
                confirmViaProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prcChgReqProperty;
        public decimal PrcChgReq
        {
            get
            {
                if (prcChgReqProperty == null)
                    prcChgReqProperty = GetDecimalProperty("PODetail.PrcChgReq");
                return prcChgReqProperty.Value;
            }
            set
            {
                if (prcChgReqProperty == null)
                    prcChgReqProperty = GetDecimalProperty("PODetail.PrcChgReq");
                prcChgReqProperty.Value = value;
            }
        }

        protected RowProperty<string> purchCodeProperty;
        public string PurchCode
        {
            get
            {
                if (purchCodeProperty == null)
                    purchCodeProperty = GetStringProperty("PODetail.PurchCode");
                return purchCodeProperty.Value;
            }
            set
            {
                if (purchCodeProperty == null)
                    purchCodeProperty = GetStringProperty("PODetail.PurchCode");
                purchCodeProperty.Value = value;
            }
        }

        protected RowProperty<int> orderNumProperty;
        public int OrderNum
        {
            get
            {
                if (orderNumProperty == null)
                    orderNumProperty = GetIntegerProperty("PODetail.OrderNum");
                return orderNumProperty.Value;
            }
            set
            {
                if (orderNumProperty == null)
                    orderNumProperty = GetIntegerProperty("PODetail.OrderNum");
                orderNumProperty.Value = value;
            }
        }

        protected RowProperty<int> orderLineProperty;
        public int OrderLine
        {
            get
            {
                if (orderLineProperty == null)
                    orderLineProperty = GetIntegerProperty("PODetail.OrderLine");
                return orderLineProperty.Value;
            }
            set
            {
                if (orderLineProperty == null)
                    orderLineProperty = GetIntegerProperty("PODetail.OrderLine");
                orderLineProperty.Value = value;
            }
        }

        protected RowProperty<string> extCompanyProperty;
        public string ExtCompany
        {
            get
            {
                if (extCompanyProperty == null)
                    extCompanyProperty = GetStringProperty("PODetail.ExtCompany");
                return extCompanyProperty.Value;
            }
            set
            {
                if (extCompanyProperty == null)
                    extCompanyProperty = GetStringProperty("PODetail.ExtCompany");
                extCompanyProperty.Value = value;
            }
        }

        protected RowProperty<bool> linkedProperty;
        public bool Linked
        {
            get
            {
                if (linkedProperty == null)
                    linkedProperty = GetBooleanProperty("PODetail.Linked");
                return linkedProperty.Value;
            }
            set
            {
                if (linkedProperty == null)
                    linkedProperty = GetBooleanProperty("PODetail.Linked");
                linkedProperty.Value = value;
            }
        }

        protected RowProperty<string> glbCompanyProperty;
        public string GlbCompany
        {
            get
            {
                if (glbCompanyProperty == null)
                    glbCompanyProperty = GetStringProperty("PODetail.GlbCompany");
                return glbCompanyProperty.Value;
            }
            set
            {
                if (glbCompanyProperty == null)
                    glbCompanyProperty = GetStringProperty("PODetail.GlbCompany");
                glbCompanyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> contractQtyProperty;
        public decimal ContractQty
        {
            get
            {
                if (contractQtyProperty == null)
                    contractQtyProperty = GetDecimalProperty("PODetail.ContractQty");
                return contractQtyProperty.Value;
            }
            set
            {
                if (contractQtyProperty == null)
                    contractQtyProperty = GetDecimalProperty("PODetail.ContractQty");
                contractQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> contractUnitCostProperty;
        public decimal ContractUnitCost
        {
            get
            {
                if (contractUnitCostProperty == null)
                    contractUnitCostProperty = GetDecimalProperty("PODetail.ContractUnitCost");
                return contractUnitCostProperty.Value;
            }
            set
            {
                if (contractUnitCostProperty == null)
                    contractUnitCostProperty = GetDecimalProperty("PODetail.ContractUnitCost");
                contractUnitCostProperty.Value = value;
            }
        }

        protected RowProperty<bool> contractActiveProperty;
        public bool ContractActive
        {
            get
            {
                if (contractActiveProperty == null)
                    contractActiveProperty = GetBooleanProperty("PODetail.ContractActive");
                return contractActiveProperty.Value;
            }
            set
            {
                if (contractActiveProperty == null)
                    contractActiveProperty = GetBooleanProperty("PODetail.ContractActive");
                contractActiveProperty.Value = value;
            }
        }

        protected RowProperty<decimal> contractDocUnitCostProperty;
        public decimal ContractDocUnitCost
        {
            get
            {
                if (contractDocUnitCostProperty == null)
                    contractDocUnitCostProperty = GetDecimalProperty("PODetail.ContractDocUnitCost");
                return contractDocUnitCostProperty.Value;
            }
            set
            {
                if (contractDocUnitCostProperty == null)
                    contractDocUnitCostProperty = GetDecimalProperty("PODetail.ContractDocUnitCost");
                contractDocUnitCostProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region POHeader Table

    [Serializable()]
    public abstract partial class POHeaderBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : POHeaderBase<T, R>, new()
        where R : POHeaderRow, new()
    {
        protected POHeaderBase() : base() { }

        protected static Schema.POHeader schemaTable;
        public static Schema.POHeader SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.POHeader)V8Schema.Instance.TablesDictionary["POHeader"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        public static T Fill(DataContext context, params string[] columnNames)
        {
            return EditTable<T, R>.Fetch(context, null, columnNames);
        }

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.POHeader.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPONumCriteria;
        public static T FillByPONum(DataContext context, string companyNum, int pONum, params string[] columnNames)
        {
            if (fillByPONumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.POHeader.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.POHeader.PONum]));
                fillByPONumCriteria = list.ToArray();
            }
            fillByPONumCriteria[0].Value = companyNum;
            fillByPONumCriteria[1].Value = pONum;
            return EditTable<T, R>.Fetch(context, fillByPONumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class POHeader : POHeaderBase<POHeader, POHeaderRow>
    {
        public POHeader() : base() { }
    }

    #region POHeaderRow

    [Serializable()]
    public class POHeaderRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("POHeader.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("POHeader.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> entryPersonProperty;
        public string EntryPerson
        {
            get
            {
                if (entryPersonProperty == null)
                    entryPersonProperty = GetStringProperty("POHeader.EntryPerson");
                return entryPersonProperty.Value;
            }
            set
            {
                if (entryPersonProperty == null)
                    entryPersonProperty = GetStringProperty("POHeader.EntryPerson");
                entryPersonProperty.Value = value;
            }
        }

        protected RowProperty<string> fobProperty;
        public string FOB
        {
            get
            {
                if (fobProperty == null)
                    fobProperty = GetStringProperty("POHeader.FOB");
                return fobProperty.Value;
            }
            set
            {
                if (fobProperty == null)
                    fobProperty = GetStringProperty("POHeader.FOB");
                fobProperty.Value = value;
            }
        }

        protected RowProperty<string> shipAddress3Property;
        public string ShipAddress3
        {
            get
            {
                if (shipAddress3Property == null)
                    shipAddress3Property = GetStringProperty("POHeader.ShipAddress3");
                return shipAddress3Property.Value;
            }
            set
            {
                if (shipAddress3Property == null)
                    shipAddress3Property = GetStringProperty("POHeader.ShipAddress3");
                shipAddress3Property.Value = value;
            }
        }

        protected RowProperty<DateTime> orderDateProperty;
        public DateTime OrderDate
        {
            get
            {
                if (orderDateProperty == null)
                    orderDateProperty = GetDateTimeProperty("POHeader.OrderDate");
                return orderDateProperty.Value;
            }
            set
            {
                if (orderDateProperty == null)
                    orderDateProperty = GetDateTimeProperty("POHeader.OrderDate");
                orderDateProperty.Value = value;
            }
        }

        protected RowProperty<int> pONumProperty;
        public int PONum
        {
            get
            {
                if (pONumProperty == null)
                    pONumProperty = GetIntegerProperty("POHeader.PONum");
                return pONumProperty.Value;
            }
            set
            {
                if (pONumProperty == null)
                    pONumProperty = GetIntegerProperty("POHeader.PONum");
                pONumProperty.Value = value;
            }
        }

        protected RowProperty<string> shipCountryProperty;
        public string ShipCountry
        {
            get
            {
                if (shipCountryProperty == null)
                    shipCountryProperty = GetStringProperty("POHeader.ShipCountry");
                return shipCountryProperty.Value;
            }
            set
            {
                if (shipCountryProperty == null)
                    shipCountryProperty = GetStringProperty("POHeader.ShipCountry");
                shipCountryProperty.Value = value;
            }
        }

        protected RowProperty<string> commentTextProperty;
        public string CommentText
        {
            get
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("POHeader.CommentText");
                return commentTextProperty.Value;
            }
            set
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("POHeader.CommentText");
                commentTextProperty.Value = value;
            }
        }

        protected RowProperty<int> prcConNumProperty;
        public int PrcConNum
        {
            get
            {
                if (prcConNumProperty == null)
                    prcConNumProperty = GetIntegerProperty("POHeader.PrcConNum");
                return prcConNumProperty.Value;
            }
            set
            {
                if (prcConNumProperty == null)
                    prcConNumProperty = GetIntegerProperty("POHeader.PrcConNum");
                prcConNumProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("POHeader.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("POHeader.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<string> shipNameProperty;
        public string ShipName
        {
            get
            {
                if (shipNameProperty == null)
                    shipNameProperty = GetStringProperty("POHeader.ShipName");
                return shipNameProperty.Value;
            }
            set
            {
                if (shipNameProperty == null)
                    shipNameProperty = GetStringProperty("POHeader.ShipName");
                shipNameProperty.Value = value;
            }
        }

        protected RowProperty<string> purPointProperty;
        public string PurPoint
        {
            get
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("POHeader.PurPoint");
                return purPointProperty.Value;
            }
            set
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("POHeader.PurPoint");
                purPointProperty.Value = value;
            }
        }

        protected RowProperty<string> shipStateProperty;
        public string ShipState
        {
            get
            {
                if (shipStateProperty == null)
                    shipStateProperty = GetStringProperty("POHeader.ShipState");
                return shipStateProperty.Value;
            }
            set
            {
                if (shipStateProperty == null)
                    shipStateProperty = GetStringProperty("POHeader.ShipState");
                shipStateProperty.Value = value;
            }
        }

        protected RowProperty<string> shipViaCodeProperty;
        public string ShipViaCode
        {
            get
            {
                if (shipViaCodeProperty == null)
                    shipViaCodeProperty = GetStringProperty("POHeader.ShipViaCode");
                return shipViaCodeProperty.Value;
            }
            set
            {
                if (shipViaCodeProperty == null)
                    shipViaCodeProperty = GetStringProperty("POHeader.ShipViaCode");
                shipViaCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> shipZIPProperty;
        public string ShipZIP
        {
            get
            {
                if (shipZIPProperty == null)
                    shipZIPProperty = GetStringProperty("POHeader.ShipZIP");
                return shipZIPProperty.Value;
            }
            set
            {
                if (shipZIPProperty == null)
                    shipZIPProperty = GetStringProperty("POHeader.ShipZIP");
                shipZIPProperty.Value = value;
            }
        }

        protected RowProperty<string> termsCodeProperty;
        public string TermsCode
        {
            get
            {
                if (termsCodeProperty == null)
                    termsCodeProperty = GetStringProperty("POHeader.TermsCode");
                return termsCodeProperty.Value;
            }
            set
            {
                if (termsCodeProperty == null)
                    termsCodeProperty = GetStringProperty("POHeader.TermsCode");
                termsCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> orderHeldProperty;
        public bool OrderHeld
        {
            get
            {
                if (orderHeldProperty == null)
                    orderHeldProperty = GetBooleanProperty("POHeader.OrderHeld");
                return orderHeldProperty.Value;
            }
            set
            {
                if (orderHeldProperty == null)
                    orderHeldProperty = GetBooleanProperty("POHeader.OrderHeld");
                orderHeldProperty.Value = value;
            }
        }

        protected RowProperty<bool> openOrderProperty;
        public bool OpenOrder
        {
            get
            {
                if (openOrderProperty == null)
                    openOrderProperty = GetBooleanProperty("POHeader.OpenOrder");
                return openOrderProperty.Value;
            }
            set
            {
                if (openOrderProperty == null)
                    openOrderProperty = GetBooleanProperty("POHeader.OpenOrder");
                openOrderProperty.Value = value;
            }
        }

        protected RowProperty<string> buyerIDProperty;
        public string BuyerID
        {
            get
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("POHeader.BuyerID");
                return buyerIDProperty.Value;
            }
            set
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("POHeader.BuyerID");
                buyerIDProperty.Value = value;
            }
        }

        protected RowProperty<string> userChar1Property;
        public string UserChar1
        {
            get
            {
                if (userChar1Property == null)
                    userChar1Property = GetStringProperty("POHeader.UserChar1");
                return userChar1Property.Value;
            }
            set
            {
                if (userChar1Property == null)
                    userChar1Property = GetStringProperty("POHeader.UserChar1");
                userChar1Property.Value = value;
            }
        }

        protected RowProperty<bool> freightPPProperty;
        public bool FreightPP
        {
            get
            {
                if (freightPPProperty == null)
                    freightPPProperty = GetBooleanProperty("POHeader.FreightPP");
                return freightPPProperty.Value;
            }
            set
            {
                if (freightPPProperty == null)
                    freightPPProperty = GetBooleanProperty("POHeader.FreightPP");
                freightPPProperty.Value = value;
            }
        }

        protected RowProperty<string> userChar2Property;
        public string UserChar2
        {
            get
            {
                if (userChar2Property == null)
                    userChar2Property = GetStringProperty("POHeader.UserChar2");
                return userChar2Property.Value;
            }
            set
            {
                if (userChar2Property == null)
                    userChar2Property = GetStringProperty("POHeader.UserChar2");
                userChar2Property.Value = value;
            }
        }

        protected RowProperty<string> userChar3Property;
        public string UserChar3
        {
            get
            {
                if (userChar3Property == null)
                    userChar3Property = GetStringProperty("POHeader.UserChar3");
                return userChar3Property.Value;
            }
            set
            {
                if (userChar3Property == null)
                    userChar3Property = GetStringProperty("POHeader.UserChar3");
                userChar3Property.Value = value;
            }
        }

        protected RowProperty<bool> voidOrderProperty;
        public bool VoidOrder
        {
            get
            {
                if (voidOrderProperty == null)
                    voidOrderProperty = GetBooleanProperty("POHeader.VoidOrder");
                return voidOrderProperty.Value;
            }
            set
            {
                if (voidOrderProperty == null)
                    voidOrderProperty = GetBooleanProperty("POHeader.VoidOrder");
                voidOrderProperty.Value = value;
            }
        }

        protected RowProperty<string> userChar4Property;
        public string UserChar4
        {
            get
            {
                if (userChar4Property == null)
                    userChar4Property = GetStringProperty("POHeader.UserChar4");
                return userChar4Property.Value;
            }
            set
            {
                if (userChar4Property == null)
                    userChar4Property = GetStringProperty("POHeader.UserChar4");
                userChar4Property.Value = value;
            }
        }

        protected RowProperty<string> shipAddress1Property;
        public string ShipAddress1
        {
            get
            {
                if (shipAddress1Property == null)
                    shipAddress1Property = GetStringProperty("POHeader.ShipAddress1");
                return shipAddress1Property.Value;
            }
            set
            {
                if (shipAddress1Property == null)
                    shipAddress1Property = GetStringProperty("POHeader.ShipAddress1");
                shipAddress1Property.Value = value;
            }
        }

        protected RowProperty<string> shipAddress2Property;
        public string ShipAddress2
        {
            get
            {
                if (shipAddress2Property == null)
                    shipAddress2Property = GetStringProperty("POHeader.ShipAddress2");
                return shipAddress2Property.Value;
            }
            set
            {
                if (shipAddress2Property == null)
                    shipAddress2Property = GetStringProperty("POHeader.ShipAddress2");
                shipAddress2Property.Value = value;
            }
        }

        protected RowProperty<string> shipCityProperty;
        public string ShipCity
        {
            get
            {
                if (shipCityProperty == null)
                    shipCityProperty = GetStringProperty("POHeader.ShipCity");
                return shipCityProperty.Value;
            }
            set
            {
                if (shipCityProperty == null)
                    shipCityProperty = GetStringProperty("POHeader.ShipCity");
                shipCityProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate1Property;
        public DateTime UserDate1
        {
            get
            {
                if (userDate1Property == null)
                    userDate1Property = GetDateTimeProperty("POHeader.UserDate1");
                return userDate1Property.Value;
            }
            set
            {
                if (userDate1Property == null)
                    userDate1Property = GetDateTimeProperty("POHeader.UserDate1");
                userDate1Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate2Property;
        public DateTime UserDate2
        {
            get
            {
                if (userDate2Property == null)
                    userDate2Property = GetDateTimeProperty("POHeader.UserDate2");
                return userDate2Property.Value;
            }
            set
            {
                if (userDate2Property == null)
                    userDate2Property = GetDateTimeProperty("POHeader.UserDate2");
                userDate2Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate3Property;
        public DateTime UserDate3
        {
            get
            {
                if (userDate3Property == null)
                    userDate3Property = GetDateTimeProperty("POHeader.UserDate3");
                return userDate3Property.Value;
            }
            set
            {
                if (userDate3Property == null)
                    userDate3Property = GetDateTimeProperty("POHeader.UserDate3");
                userDate3Property.Value = value;
            }
        }

        protected RowProperty<DateTime> userDate4Property;
        public DateTime UserDate4
        {
            get
            {
                if (userDate4Property == null)
                    userDate4Property = GetDateTimeProperty("POHeader.UserDate4");
                return userDate4Property.Value;
            }
            set
            {
                if (userDate4Property == null)
                    userDate4Property = GetDateTimeProperty("POHeader.UserDate4");
                userDate4Property.Value = value;
            }
        }

        protected RowProperty<decimal> userDecimal1Property;
        public decimal UserDecimal1
        {
            get
            {
                if (userDecimal1Property == null)
                    userDecimal1Property = GetDecimalProperty("POHeader.UserDecimal1");
                return userDecimal1Property.Value;
            }
            set
            {
                if (userDecimal1Property == null)
                    userDecimal1Property = GetDecimalProperty("POHeader.UserDecimal1");
                userDecimal1Property.Value = value;
            }
        }

        protected RowProperty<decimal> userDecimal2Property;
        public decimal UserDecimal2
        {
            get
            {
                if (userDecimal2Property == null)
                    userDecimal2Property = GetDecimalProperty("POHeader.UserDecimal2");
                return userDecimal2Property.Value;
            }
            set
            {
                if (userDecimal2Property == null)
                    userDecimal2Property = GetDecimalProperty("POHeader.UserDecimal2");
                userDecimal2Property.Value = value;
            }
        }

        protected RowProperty<int> userInteger1Property;
        public int UserInteger1
        {
            get
            {
                if (userInteger1Property == null)
                    userInteger1Property = GetIntegerProperty("POHeader.UserInteger1");
                return userInteger1Property.Value;
            }
            set
            {
                if (userInteger1Property == null)
                    userInteger1Property = GetIntegerProperty("POHeader.UserInteger1");
                userInteger1Property.Value = value;
            }
        }

        protected RowProperty<int> userInteger2Property;
        public int UserInteger2
        {
            get
            {
                if (userInteger2Property == null)
                    userInteger2Property = GetIntegerProperty("POHeader.UserInteger2");
                return userInteger2Property.Value;
            }
            set
            {
                if (userInteger2Property == null)
                    userInteger2Property = GetIntegerProperty("POHeader.UserInteger2");
                userInteger2Property.Value = value;
            }
        }

        protected RowProperty<string> shipToConNameProperty;
        public string ShipToConName
        {
            get
            {
                if (shipToConNameProperty == null)
                    shipToConNameProperty = GetStringProperty("POHeader.ShipToConName");
                return shipToConNameProperty.Value;
            }
            set
            {
                if (shipToConNameProperty == null)
                    shipToConNameProperty = GetStringProperty("POHeader.ShipToConName");
                shipToConNameProperty.Value = value;
            }
        }

        protected RowProperty<bool> readyToPrintProperty;
        public bool ReadyToPrint
        {
            get
            {
                if (readyToPrintProperty == null)
                    readyToPrintProperty = GetBooleanProperty("POHeader.ReadyToPrint");
                return readyToPrintProperty.Value;
            }
            set
            {
                if (readyToPrintProperty == null)
                    readyToPrintProperty = GetBooleanProperty("POHeader.ReadyToPrint");
                readyToPrintProperty.Value = value;
            }
        }

        protected RowProperty<string> printAsProperty;
        public string PrintAs
        {
            get
            {
                if (printAsProperty == null)
                    printAsProperty = GetStringProperty("POHeader.PrintAs");
                return printAsProperty.Value;
            }
            set
            {
                if (printAsProperty == null)
                    printAsProperty = GetStringProperty("POHeader.PrintAs");
                printAsProperty.Value = value;
            }
        }

        protected RowProperty<string> currencyCodeProperty;
        public string CurrencyCode
        {
            get
            {
                if (currencyCodeProperty == null)
                    currencyCodeProperty = GetStringProperty("POHeader.CurrencyCode");
                return currencyCodeProperty.Value;
            }
            set
            {
                if (currencyCodeProperty == null)
                    currencyCodeProperty = GetStringProperty("POHeader.CurrencyCode");
                currencyCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> exchangeRateProperty;
        public decimal ExchangeRate
        {
            get
            {
                if (exchangeRateProperty == null)
                    exchangeRateProperty = GetDecimalProperty("POHeader.ExchangeRate");
                return exchangeRateProperty.Value;
            }
            set
            {
                if (exchangeRateProperty == null)
                    exchangeRateProperty = GetDecimalProperty("POHeader.ExchangeRate");
                exchangeRateProperty.Value = value;
            }
        }

        protected RowProperty<bool> lockRateProperty;
        public bool LockRate
        {
            get
            {
                if (lockRateProperty == null)
                    lockRateProperty = GetBooleanProperty("POHeader.LockRate");
                return lockRateProperty.Value;
            }
            set
            {
                if (lockRateProperty == null)
                    lockRateProperty = GetBooleanProperty("POHeader.LockRate");
                lockRateProperty.Value = value;
            }
        }

        protected RowProperty<string> refCodeProperty;
        public string RefCode
        {
            get
            {
                if (refCodeProperty == null)
                    refCodeProperty = GetStringProperty("POHeader.RefCode");
                return refCodeProperty.Value;
            }
            set
            {
                if (refCodeProperty == null)
                    refCodeProperty = GetStringProperty("POHeader.RefCode");
                refCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> docToRefProperty;
        public bool DocToRef
        {
            get
            {
                if (docToRefProperty == null)
                    docToRefProperty = GetBooleanProperty("POHeader.DocToRef");
                return docToRefProperty.Value;
            }
            set
            {
                if (docToRefProperty == null)
                    docToRefProperty = GetBooleanProperty("POHeader.DocToRef");
                docToRefProperty.Value = value;
            }
        }

        protected RowProperty<bool> refToBaseProperty;
        public bool RefToBase
        {
            get
            {
                if (refToBaseProperty == null)
                    refToBaseProperty = GetBooleanProperty("POHeader.RefToBase");
                return refToBaseProperty.Value;
            }
            set
            {
                if (refToBaseProperty == null)
                    refToBaseProperty = GetBooleanProperty("POHeader.RefToBase");
                refToBaseProperty.Value = value;
            }
        }

        protected RowProperty<decimal> refToBaseRateProperty;
        public decimal RefToBaseRate
        {
            get
            {
                if (refToBaseRateProperty == null)
                    refToBaseRateProperty = GetDecimalProperty("POHeader.RefToBaseRate");
                return refToBaseRateProperty.Value;
            }
            set
            {
                if (refToBaseRateProperty == null)
                    refToBaseRateProperty = GetDecimalProperty("POHeader.RefToBaseRate");
                refToBaseRateProperty.Value = value;
            }
        }

        protected RowProperty<int> shipCountryNumProperty;
        public int ShipCountryNum
        {
            get
            {
                if (shipCountryNumProperty == null)
                    shipCountryNumProperty = GetIntegerProperty("POHeader.ShipCountryNum");
                return shipCountryNumProperty.Value;
            }
            set
            {
                if (shipCountryNumProperty == null)
                    shipCountryNumProperty = GetIntegerProperty("POHeader.ShipCountryNum");
                shipCountryNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> logChangesProperty;
        public bool LogChanges
        {
            get
            {
                if (logChangesProperty == null)
                    logChangesProperty = GetBooleanProperty("POHeader.LogChanges");
                return logChangesProperty.Value;
            }
            set
            {
                if (logChangesProperty == null)
                    logChangesProperty = GetBooleanProperty("POHeader.LogChanges");
                logChangesProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> approvedDateProperty;
        public DateTime ApprovedDate
        {
            get
            {
                if (approvedDateProperty == null)
                    approvedDateProperty = GetDateTimeProperty("POHeader.ApprovedDate");
                return approvedDateProperty.Value;
            }
            set
            {
                if (approvedDateProperty == null)
                    approvedDateProperty = GetDateTimeProperty("POHeader.ApprovedDate");
                approvedDateProperty.Value = value;
            }
        }

        protected RowProperty<string> approvedByProperty;
        public string ApprovedBy
        {
            get
            {
                if (approvedByProperty == null)
                    approvedByProperty = GetStringProperty("POHeader.ApprovedBy");
                return approvedByProperty.Value;
            }
            set
            {
                if (approvedByProperty == null)
                    approvedByProperty = GetStringProperty("POHeader.ApprovedBy");
                approvedByProperty.Value = value;
            }
        }

        protected RowProperty<bool> approveProperty;
        public bool Approve
        {
            get
            {
                if (approveProperty == null)
                    approveProperty = GetBooleanProperty("POHeader.Approve");
                return approveProperty.Value;
            }
            set
            {
                if (approveProperty == null)
                    approveProperty = GetBooleanProperty("POHeader.Approve");
                approveProperty.Value = value;
            }
        }

        protected RowProperty<string> approvalStatusProperty;
        public string ApprovalStatus
        {
            get
            {
                if (approvalStatusProperty == null)
                    approvalStatusProperty = GetStringProperty("POHeader.ApprovalStatus");
                return approvalStatusProperty.Value;
            }
            set
            {
                if (approvalStatusProperty == null)
                    approvalStatusProperty = GetStringProperty("POHeader.ApprovalStatus");
                approvalStatusProperty.Value = value;
            }
        }

        protected RowProperty<decimal> approvedAmountProperty;
        public decimal ApprovedAmount
        {
            get
            {
                if (approvedAmountProperty == null)
                    approvedAmountProperty = GetDecimalProperty("POHeader.ApprovedAmount");
                return approvedAmountProperty.Value;
            }
            set
            {
                if (approvedAmountProperty == null)
                    approvedAmountProperty = GetDecimalProperty("POHeader.ApprovedAmount");
                approvedAmountProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> postDateProperty;
        public DateTime PostDate
        {
            get
            {
                if (postDateProperty == null)
                    postDateProperty = GetDateTimeProperty("POHeader.PostDate");
                return postDateProperty.Value;
            }
            set
            {
                if (postDateProperty == null)
                    postDateProperty = GetDateTimeProperty("POHeader.PostDate");
                postDateProperty.Value = value;
            }
        }

        protected RowProperty<bool> confirmReqProperty;
        public bool ConfirmReq
        {
            get
            {
                if (confirmReqProperty == null)
                    confirmReqProperty = GetBooleanProperty("POHeader.ConfirmReq");
                return confirmReqProperty.Value;
            }
            set
            {
                if (confirmReqProperty == null)
                    confirmReqProperty = GetBooleanProperty("POHeader.ConfirmReq");
                confirmReqProperty.Value = value;
            }
        }

        protected RowProperty<bool> confirmedProperty;
        public bool Confirmed
        {
            get
            {
                if (confirmedProperty == null)
                    confirmedProperty = GetBooleanProperty("POHeader.Confirmed");
                return confirmedProperty.Value;
            }
            set
            {
                if (confirmedProperty == null)
                    confirmedProperty = GetBooleanProperty("POHeader.Confirmed");
                confirmedProperty.Value = value;
            }
        }

        protected RowProperty<string> confirmViaProperty;
        public string ConfirmVia
        {
            get
            {
                if (confirmViaProperty == null)
                    confirmViaProperty = GetStringProperty("POHeader.ConfirmVia");
                return confirmViaProperty.Value;
            }
            set
            {
                if (confirmViaProperty == null)
                    confirmViaProperty = GetStringProperty("POHeader.ConfirmVia");
                confirmViaProperty.Value = value;
            }
        }

        protected RowProperty<bool> postToWebProperty;
        public bool PostToWeb
        {
            get
            {
                if (postToWebProperty == null)
                    postToWebProperty = GetBooleanProperty("POHeader.PostToWeb");
                return postToWebProperty.Value;
            }
            set
            {
                if (postToWebProperty == null)
                    postToWebProperty = GetBooleanProperty("POHeader.PostToWeb");
                postToWebProperty.Value = value;
            }
        }

        protected RowProperty<int> orderNumProperty;
        public int OrderNum
        {
            get
            {
                if (orderNumProperty == null)
                    orderNumProperty = GetIntegerProperty("POHeader.OrderNum");
                return orderNumProperty.Value;
            }
            set
            {
                if (orderNumProperty == null)
                    orderNumProperty = GetIntegerProperty("POHeader.OrderNum");
                orderNumProperty.Value = value;
            }
        }

        protected RowProperty<string> legalNumberProperty;
        public string LegalNumber
        {
            get
            {
                if (legalNumberProperty == null)
                    legalNumberProperty = GetStringProperty("POHeader.LegalNumber");
                return legalNumberProperty.Value;
            }
            set
            {
                if (legalNumberProperty == null)
                    legalNumberProperty = GetStringProperty("POHeader.LegalNumber");
                legalNumberProperty.Value = value;
            }
        }

        protected RowProperty<string> vendorRefNumProperty;
        public string VendorRefNum
        {
            get
            {
                if (vendorRefNumProperty == null)
                    vendorRefNumProperty = GetStringProperty("POHeader.VendorRefNum");
                return vendorRefNumProperty.Value;
            }
            set
            {
                if (vendorRefNumProperty == null)
                    vendorRefNumProperty = GetStringProperty("POHeader.VendorRefNum");
                vendorRefNumProperty.Value = value;
            }
        }

        protected RowProperty<string> extCompanyProperty;
        public string ExtCompany
        {
            get
            {
                if (extCompanyProperty == null)
                    extCompanyProperty = GetStringProperty("POHeader.ExtCompany");
                return extCompanyProperty.Value;
            }
            set
            {
                if (extCompanyProperty == null)
                    extCompanyProperty = GetStringProperty("POHeader.ExtCompany");
                extCompanyProperty.Value = value;
            }
        }

        protected RowProperty<bool> linkedProperty;
        public bool Linked
        {
            get
            {
                if (linkedProperty == null)
                    linkedProperty = GetBooleanProperty("POHeader.Linked");
                return linkedProperty.Value;
            }
            set
            {
                if (linkedProperty == null)
                    linkedProperty = GetBooleanProperty("POHeader.Linked");
                linkedProperty.Value = value;
            }
        }

        protected RowProperty<string> xRefPONumProperty;
        public string XRefPONum
        {
            get
            {
                if (xRefPONumProperty == null)
                    xRefPONumProperty = GetStringProperty("POHeader.XRefPONum");
                return xRefPONumProperty.Value;
            }
            set
            {
                if (xRefPONumProperty == null)
                    xRefPONumProperty = GetStringProperty("POHeader.XRefPONum");
                xRefPONumProperty.Value = value;
            }
        }

        protected RowProperty<bool> consolidatedPOProperty;
        public bool ConsolidatedPO
        {
            get
            {
                if (consolidatedPOProperty == null)
                    consolidatedPOProperty = GetBooleanProperty("POHeader.ConsolidatedPO");
                return consolidatedPOProperty.Value;
            }
            set
            {
                if (consolidatedPOProperty == null)
                    consolidatedPOProperty = GetBooleanProperty("POHeader.ConsolidatedPO");
                consolidatedPOProperty.Value = value;
            }
        }

        protected RowProperty<string> glbCompanyProperty;
        public string GlbCompany
        {
            get
            {
                if (glbCompanyProperty == null)
                    glbCompanyProperty = GetStringProperty("POHeader.GlbCompany");
                return glbCompanyProperty.Value;
            }
            set
            {
                if (glbCompanyProperty == null)
                    glbCompanyProperty = GetStringProperty("POHeader.GlbCompany");
                glbCompanyProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> contractStartDateProperty;
        public DateTime ContractStartDate
        {
            get
            {
                if (contractStartDateProperty == null)
                    contractStartDateProperty = GetDateTimeProperty("POHeader.ContractStartDate");
                return contractStartDateProperty.Value;
            }
            set
            {
                if (contractStartDateProperty == null)
                    contractStartDateProperty = GetDateTimeProperty("POHeader.ContractStartDate");
                contractStartDateProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> contractEndDateProperty;
        public DateTime ContractEndDate
        {
            get
            {
                if (contractEndDateProperty == null)
                    contractEndDateProperty = GetDateTimeProperty("POHeader.ContractEndDate");
                return contractEndDateProperty.Value;
            }
            set
            {
                if (contractEndDateProperty == null)
                    contractEndDateProperty = GetDateTimeProperty("POHeader.ContractEndDate");
                contractEndDateProperty.Value = value;
            }
        }

        protected RowProperty<bool> contractOrderProperty;
        public bool ContractOrder
        {
            get
            {
                if (contractOrderProperty == null)
                    contractOrderProperty = GetBooleanProperty("POHeader.ContractOrder");
                return contractOrderProperty.Value;
            }
            set
            {
                if (contractOrderProperty == null)
                    contractOrderProperty = GetBooleanProperty("POHeader.ContractOrder");
                contractOrderProperty.Value = value;
            }
        }

        protected RowProperty<bool> printHeaderAddressProperty;
        public bool PrintHeaderAddress
        {
            get
            {
                if (printHeaderAddressProperty == null)
                    printHeaderAddressProperty = GetBooleanProperty("POHeader.PrintHeaderAddress");
                return printHeaderAddressProperty.Value;
            }
            set
            {
                if (printHeaderAddressProperty == null)
                    printHeaderAddressProperty = GetBooleanProperty("POHeader.PrintHeaderAddress");
                printHeaderAddressProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region PORel Table

    [Serializable()]
    public abstract partial class PORelBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PORelBase<T, R>, new()
        where R : PORelRow, new()
    {
        protected PORelBase() : base() { }

        protected static Schema.PORel schemaTable;
        public static Schema.PORel SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PORel)V8Schema.Instance.TablesDictionary["PORel"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPONumCriteria;
        public static T FillByPONum(DataContext context, string companyNum, int pONum, params string[] columnNames)
        {
            if (fillByPONumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PONum]));
                fillByPONumCriteria = list.ToArray();
            }
            fillByPONumCriteria[0].Value = companyNum;
            fillByPONumCriteria[1].Value = pONum;
            return EditTable<T, R>.Fetch(context, fillByPONumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPOLineCriteria;
        public static T FillByPOLine(DataContext context, string companyNum, int pONum, int pOLine, params string[] columnNames)
        {
            if (fillByPOLineCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PONum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.POLine]));
                fillByPOLineCriteria = list.ToArray();
            }
            fillByPOLineCriteria[0].Value = companyNum;
            fillByPOLineCriteria[1].Value = pONum;
            fillByPOLineCriteria[2].Value = pOLine;
            return EditTable<T, R>.Fetch(context, fillByPOLineCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPORelNumCriteria;
        public static T FillByPORelNum(DataContext context, string companyNum, int pONum, int pOLine, int pORelNum, params string[] columnNames)
        {
            if (fillByPORelNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PONum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.POLine]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PORelNum]));
                fillByPORelNumCriteria = list.ToArray();
            }
            fillByPORelNumCriteria[0].Value = companyNum;
            fillByPORelNumCriteria[1].Value = pONum;
            fillByPORelNumCriteria[2].Value = pOLine;
            fillByPORelNumCriteria[3].Value = pORelNum;
            return EditTable<T, R>.Fetch(context, fillByPORelNumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PORel : PORelBase<PORel, PORelRow>
    {
        public PORel() : base() { }
    }

    #region PORelRow

    [Serializable()]
    public class PORelRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PORel.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PORel.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<int> pOLineProperty;
        public int POLine
        {
            get
            {
                if (pOLineProperty == null)
                    pOLineProperty = GetIntegerProperty("PORel.POLine");
                return pOLineProperty.Value;
            }
            set
            {
                if (pOLineProperty == null)
                    pOLineProperty = GetIntegerProperty("PORel.POLine");
                pOLineProperty.Value = value;
            }
        }

        protected RowProperty<int> pONumProperty;
        public int PONum
        {
            get
            {
                if (pONumProperty == null)
                    pONumProperty = GetIntegerProperty("PORel.PONum");
                return pONumProperty.Value;
            }
            set
            {
                if (pONumProperty == null)
                    pONumProperty = GetIntegerProperty("PORel.PONum");
                pONumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> relQtyProperty;
        public decimal RelQty
        {
            get
            {
                if (relQtyProperty == null)
                    relQtyProperty = GetDecimalProperty("PORel.RelQty");
                return relQtyProperty.Value;
            }
            set
            {
                if (relQtyProperty == null)
                    relQtyProperty = GetDecimalProperty("PORel.RelQty");
                relQtyProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> dueDateProperty;
        public DateTime DueDate
        {
            get
            {
                if (dueDateProperty == null)
                    dueDateProperty = GetDateTimeProperty("PORel.DueDate");
                return dueDateProperty.Value;
            }
            set
            {
                if (dueDateProperty == null)
                    dueDateProperty = GetDateTimeProperty("PORel.DueDate");
                dueDateProperty.Value = value;
            }
        }

        protected RowProperty<int> pORelNumProperty;
        public int PORelNum
        {
            get
            {
                if (pORelNumProperty == null)
                    pORelNumProperty = GetIntegerProperty("PORel.PORelNum");
                return pORelNumProperty.Value;
            }
            set
            {
                if (pORelNumProperty == null)
                    pORelNumProperty = GetIntegerProperty("PORel.PORelNum");
                pORelNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> openReleaseProperty;
        public bool OpenRelease
        {
            get
            {
                if (openReleaseProperty == null)
                    openReleaseProperty = GetBooleanProperty("PORel.OpenRelease");
                return openReleaseProperty.Value;
            }
            set
            {
                if (openReleaseProperty == null)
                    openReleaseProperty = GetBooleanProperty("PORel.OpenRelease");
                openReleaseProperty.Value = value;
            }
        }

        protected RowProperty<bool> voidReleaseProperty;
        public bool VoidRelease
        {
            get
            {
                if (voidReleaseProperty == null)
                    voidReleaseProperty = GetBooleanProperty("PORel.VoidRelease");
                return voidReleaseProperty.Value;
            }
            set
            {
                if (voidReleaseProperty == null)
                    voidReleaseProperty = GetBooleanProperty("PORel.VoidRelease");
                voidReleaseProperty.Value = value;
            }
        }

        protected RowProperty<string> jobNumProperty;
        public string JobNum
        {
            get
            {
                if (jobNumProperty == null)
                    jobNumProperty = GetStringProperty("PORel.JobNum");
                return jobNumProperty.Value;
            }
            set
            {
                if (jobNumProperty == null)
                    jobNumProperty = GetStringProperty("PORel.JobNum");
                jobNumProperty.Value = value;
            }
        }

        protected RowProperty<int> assemblySeqProperty;
        public int AssemblySeq
        {
            get
            {
                if (assemblySeqProperty == null)
                    assemblySeqProperty = GetIntegerProperty("PORel.AssemblySeq");
                return assemblySeqProperty.Value;
            }
            set
            {
                if (assemblySeqProperty == null)
                    assemblySeqProperty = GetIntegerProperty("PORel.AssemblySeq");
                assemblySeqProperty.Value = value;
            }
        }

        protected RowProperty<string> jobSeqTypeProperty;
        public string JobSeqType
        {
            get
            {
                if (jobSeqTypeProperty == null)
                    jobSeqTypeProperty = GetStringProperty("PORel.JobSeqType");
                return jobSeqTypeProperty.Value;
            }
            set
            {
                if (jobSeqTypeProperty == null)
                    jobSeqTypeProperty = GetStringProperty("PORel.JobSeqType");
                jobSeqTypeProperty.Value = value;
            }
        }

        protected RowProperty<int> jobSeqProperty;
        public int JobSeq
        {
            get
            {
                if (jobSeqProperty == null)
                    jobSeqProperty = GetIntegerProperty("PORel.JobSeq");
                return jobSeqProperty.Value;
            }
            set
            {
                if (jobSeqProperty == null)
                    jobSeqProperty = GetIntegerProperty("PORel.JobSeq");
                jobSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> warehouseCodeProperty;
        public string WarehouseCode
        {
            get
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PORel.WarehouseCode");
                return warehouseCodeProperty.Value;
            }
            set
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PORel.WarehouseCode");
                warehouseCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> receivedQtyProperty;
        public decimal ReceivedQty
        {
            get
            {
                if (receivedQtyProperty == null)
                    receivedQtyProperty = GetDecimalProperty("PORel.ReceivedQty");
                return receivedQtyProperty.Value;
            }
            set
            {
                if (receivedQtyProperty == null)
                    receivedQtyProperty = GetDecimalProperty("PORel.ReceivedQty");
                receivedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> xRelQtyProperty;
        public decimal XRelQty
        {
            get
            {
                if (xRelQtyProperty == null)
                    xRelQtyProperty = GetDecimalProperty("PORel.XRelQty");
                return xRelQtyProperty.Value;
            }
            set
            {
                if (xRelQtyProperty == null)
                    xRelQtyProperty = GetDecimalProperty("PORel.XRelQty");
                xRelQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> purchasingFactorProperty;
        public decimal PurchasingFactor
        {
            get
            {
                if (purchasingFactorProperty == null)
                    purchasingFactorProperty = GetDecimalProperty("PORel.PurchasingFactor");
                return purchasingFactorProperty.Value;
            }
            set
            {
                if (purchasingFactorProperty == null)
                    purchasingFactorProperty = GetDecimalProperty("PORel.PurchasingFactor");
                purchasingFactorProperty.Value = value;
            }
        }

        protected RowProperty<string> expDivisionProperty;
        public string ExpDivision
        {
            get
            {
                if (expDivisionProperty == null)
                    expDivisionProperty = GetStringProperty("PORel.ExpDivision");
                return expDivisionProperty.Value;
            }
            set
            {
                if (expDivisionProperty == null)
                    expDivisionProperty = GetStringProperty("PORel.ExpDivision");
                expDivisionProperty.Value = value;
            }
        }

        protected RowProperty<string> expGLDeptProperty;
        public string ExpGLDept
        {
            get
            {
                if (expGLDeptProperty == null)
                    expGLDeptProperty = GetStringProperty("PORel.ExpGLDept");
                return expGLDeptProperty.Value;
            }
            set
            {
                if (expGLDeptProperty == null)
                    expGLDeptProperty = GetStringProperty("PORel.ExpGLDept");
                expGLDeptProperty.Value = value;
            }
        }

        protected RowProperty<string> expChartProperty;
        public string ExpChart
        {
            get
            {
                if (expChartProperty == null)
                    expChartProperty = GetStringProperty("PORel.ExpChart");
                return expChartProperty.Value;
            }
            set
            {
                if (expChartProperty == null)
                    expChartProperty = GetStringProperty("PORel.ExpChart");
                expChartProperty.Value = value;
            }
        }

        protected RowProperty<bool> expOverrideProperty;
        public bool ExpOverride
        {
            get
            {
                if (expOverrideProperty == null)
                    expOverrideProperty = GetBooleanProperty("PORel.ExpOverride");
                return expOverrideProperty.Value;
            }
            set
            {
                if (expOverrideProperty == null)
                    expOverrideProperty = GetBooleanProperty("PORel.ExpOverride");
                expOverrideProperty.Value = value;
            }
        }

        protected RowProperty<int> reqNumProperty;
        public int ReqNum
        {
            get
            {
                if (reqNumProperty == null)
                    reqNumProperty = GetIntegerProperty("PORel.ReqNum");
                return reqNumProperty.Value;
            }
            set
            {
                if (reqNumProperty == null)
                    reqNumProperty = GetIntegerProperty("PORel.ReqNum");
                reqNumProperty.Value = value;
            }
        }

        protected RowProperty<int> reqLineProperty;
        public int ReqLine
        {
            get
            {
                if (reqLineProperty == null)
                    reqLineProperty = GetIntegerProperty("PORel.ReqLine");
                return reqLineProperty.Value;
            }
            set
            {
                if (reqLineProperty == null)
                    reqLineProperty = GetIntegerProperty("PORel.ReqLine");
                reqLineProperty.Value = value;
            }
        }

        protected RowProperty<string> plantNumProperty;
        public string PlantNum
        {
            get
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PORel.PlantNum");
                return plantNumProperty.Value;
            }
            set
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PORel.PlantNum");
                plantNumProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> promiseDtProperty;
        public DateTime PromiseDt
        {
            get
            {
                if (promiseDtProperty == null)
                    promiseDtProperty = GetDateTimeProperty("PORel.PromiseDt");
                return promiseDtProperty.Value;
            }
            set
            {
                if (promiseDtProperty == null)
                    promiseDtProperty = GetDateTimeProperty("PORel.PromiseDt");
                promiseDtProperty.Value = value;
            }
        }

        protected RowProperty<string> projectIDProperty;
        public string ProjectID
        {
            get
            {
                if (projectIDProperty == null)
                    projectIDProperty = GetStringProperty("PORel.ProjectID");
                return projectIDProperty.Value;
            }
            set
            {
                if (projectIDProperty == null)
                    projectIDProperty = GetStringProperty("PORel.ProjectID");
                projectIDProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> reqChgDateProperty;
        public DateTime ReqChgDate
        {
            get
            {
                if (reqChgDateProperty == null)
                    reqChgDateProperty = GetDateTimeProperty("PORel.ReqChgDate");
                return reqChgDateProperty.Value;
            }
            set
            {
                if (reqChgDateProperty == null)
                    reqChgDateProperty = GetDateTimeProperty("PORel.ReqChgDate");
                reqChgDateProperty.Value = value;
            }
        }

        protected RowProperty<bool> confirmedProperty;
        public bool Confirmed
        {
            get
            {
                if (confirmedProperty == null)
                    confirmedProperty = GetBooleanProperty("PORel.Confirmed");
                return confirmedProperty.Value;
            }
            set
            {
                if (confirmedProperty == null)
                    confirmedProperty = GetBooleanProperty("PORel.Confirmed");
                confirmedProperty.Value = value;
            }
        }

        protected RowProperty<decimal> reqChgQtyProperty;
        public decimal ReqChgQty
        {
            get
            {
                if (reqChgQtyProperty == null)
                    reqChgQtyProperty = GetDecimalProperty("PORel.ReqChgQty");
                return reqChgQtyProperty.Value;
            }
            set
            {
                if (reqChgQtyProperty == null)
                    reqChgQtyProperty = GetDecimalProperty("PORel.ReqChgQty");
                reqChgQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> lockRelProperty;
        public string LockRel
        {
            get
            {
                if (lockRelProperty == null)
                    lockRelProperty = GetStringProperty("PORel.LockRel");
                return lockRelProperty.Value;
            }
            set
            {
                if (lockRelProperty == null)
                    lockRelProperty = GetStringProperty("PORel.LockRel");
                lockRelProperty.Value = value;
            }
        }

        protected RowProperty<string> refCodeProperty;
        public string RefCode
        {
            get
            {
                if (refCodeProperty == null)
                    refCodeProperty = GetStringProperty("PORel.RefCode");
                return refCodeProperty.Value;
            }
            set
            {
                if (refCodeProperty == null)
                    refCodeProperty = GetStringProperty("PORel.RefCode");
                refCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> refCodeDescProperty;
        public string RefCodeDesc
        {
            get
            {
                if (refCodeDescProperty == null)
                    refCodeDescProperty = GetStringProperty("PORel.RefCodeDesc");
                return refCodeDescProperty.Value;
            }
            set
            {
                if (refCodeDescProperty == null)
                    refCodeDescProperty = GetStringProperty("PORel.RefCodeDesc");
                refCodeDescProperty.Value = value;
            }
        }

        protected RowProperty<string> refTypeProperty;
        public string RefType
        {
            get
            {
                if (refTypeProperty == null)
                    refTypeProperty = GetStringProperty("PORel.RefType");
                return refTypeProperty.Value;
            }
            set
            {
                if (refTypeProperty == null)
                    refTypeProperty = GetStringProperty("PORel.RefType");
                refTypeProperty.Value = value;
            }
        }

        protected RowProperty<int> orderNumProperty;
        public int OrderNum
        {
            get
            {
                if (orderNumProperty == null)
                    orderNumProperty = GetIntegerProperty("PORel.OrderNum");
                return orderNumProperty.Value;
            }
            set
            {
                if (orderNumProperty == null)
                    orderNumProperty = GetIntegerProperty("PORel.OrderNum");
                orderNumProperty.Value = value;
            }
        }

        protected RowProperty<int> orderLineProperty;
        public int OrderLine
        {
            get
            {
                if (orderLineProperty == null)
                    orderLineProperty = GetIntegerProperty("PORel.OrderLine");
                return orderLineProperty.Value;
            }
            set
            {
                if (orderLineProperty == null)
                    orderLineProperty = GetIntegerProperty("PORel.OrderLine");
                orderLineProperty.Value = value;
            }
        }

        protected RowProperty<int> orderRelNumProperty;
        public int OrderRelNum
        {
            get
            {
                if (orderRelNumProperty == null)
                    orderRelNumProperty = GetIntegerProperty("PORel.OrderRelNum");
                return orderRelNumProperty.Value;
            }
            set
            {
                if (orderRelNumProperty == null)
                    orderRelNumProperty = GetIntegerProperty("PORel.OrderRelNum");
                orderRelNumProperty.Value = value;
            }
        }

        protected RowProperty<string> confirmViaProperty;
        public string ConfirmVia
        {
            get
            {
                if (confirmViaProperty == null)
                    confirmViaProperty = GetStringProperty("PORel.ConfirmVia");
                return confirmViaProperty.Value;
            }
            set
            {
                if (confirmViaProperty == null)
                    confirmViaProperty = GetStringProperty("PORel.ConfirmVia");
                confirmViaProperty.Value = value;
            }
        }

        protected RowProperty<string> extCompanyProperty;
        public string ExtCompany
        {
            get
            {
                if (extCompanyProperty == null)
                    extCompanyProperty = GetStringProperty("PORel.ExtCompany");
                return extCompanyProperty.Value;
            }
            set
            {
                if (extCompanyProperty == null)
                    extCompanyProperty = GetStringProperty("PORel.ExtCompany");
                extCompanyProperty.Value = value;
            }
        }

        protected RowProperty<bool> linkedProperty;
        public bool Linked
        {
            get
            {
                if (linkedProperty == null)
                    linkedProperty = GetBooleanProperty("PORel.Linked");
                return linkedProperty.Value;
            }
            set
            {
                if (linkedProperty == null)
                    linkedProperty = GetBooleanProperty("PORel.Linked");
                linkedProperty.Value = value;
            }
        }

        protected RowProperty<string> refDisplayAccountProperty;
        public string RefDisplayAccount
        {
            get
            {
                if (refDisplayAccountProperty == null)
                    refDisplayAccountProperty = GetStringProperty("PORel.RefDisplayAccount");
                return refDisplayAccountProperty.Value;
            }
            set
            {
                if (refDisplayAccountProperty == null)
                    refDisplayAccountProperty = GetStringProperty("PORel.RefDisplayAccount");
                refDisplayAccountProperty.Value = value;
            }
        }

        protected RowProperty<decimal> shippedQtyProperty;
        public decimal ShippedQty
        {
            get
            {
                if (shippedQtyProperty == null)
                    shippedQtyProperty = GetDecimalProperty("PORel.ShippedQty");
                return shippedQtyProperty.Value;
            }
            set
            {
                if (shippedQtyProperty == null)
                    shippedQtyProperty = GetDecimalProperty("PORel.ShippedQty");
                shippedQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> tranTypeProperty;
        public string TranType
        {
            get
            {
                if (tranTypeProperty == null)
                    tranTypeProperty = GetStringProperty("PORel.TranType");
                return tranTypeProperty.Value;
            }
            set
            {
                if (tranTypeProperty == null)
                    tranTypeProperty = GetStringProperty("PORel.TranType");
                tranTypeProperty.Value = value;
            }
        }

        protected RowProperty<string> refAcctChartProperty;
        public string RefAcctChart
        {
            get
            {
                if (refAcctChartProperty == null)
                    refAcctChartProperty = GetStringProperty("PORel.RefAcctChart");
                return refAcctChartProperty.Value;
            }
            set
            {
                if (refAcctChartProperty == null)
                    refAcctChartProperty = GetStringProperty("PORel.RefAcctChart");
                refAcctChartProperty.Value = value;
            }
        }

        protected RowProperty<string> refAcctDivProperty;
        public string RefAcctDiv
        {
            get
            {
                if (refAcctDivProperty == null)
                    refAcctDivProperty = GetStringProperty("PORel.RefAcctDiv");
                return refAcctDivProperty.Value;
            }
            set
            {
                if (refAcctDivProperty == null)
                    refAcctDivProperty = GetStringProperty("PORel.RefAcctDiv");
                refAcctDivProperty.Value = value;
            }
        }

        protected RowProperty<string> refAcctDeptProperty;
        public string RefAcctDept
        {
            get
            {
                if (refAcctDeptProperty == null)
                    refAcctDeptProperty = GetStringProperty("PORel.RefAcctDept");
                return refAcctDeptProperty.Value;
            }
            set
            {
                if (refAcctDeptProperty == null)
                    refAcctDeptProperty = GetStringProperty("PORel.RefAcctDept");
                refAcctDeptProperty.Value = value;
            }
        }

        protected RowProperty<string> glbCompanyProperty;
        public string GlbCompany
        {
            get
            {
                if (glbCompanyProperty == null)
                    glbCompanyProperty = GetStringProperty("PORel.GlbCompany");
                return glbCompanyProperty.Value;
            }
            set
            {
                if (glbCompanyProperty == null)
                    glbCompanyProperty = GetStringProperty("PORel.GlbCompany");
                glbCompanyProperty.Value = value;
            }
        }

        protected RowProperty<string> glbPlantProperty;
        public string GlbPlant
        {
            get
            {
                if (glbPlantProperty == null)
                    glbPlantProperty = GetStringProperty("PORel.GlbPlant");
                return glbPlantProperty.Value;
            }
            set
            {
                if (glbPlantProperty == null)
                    glbPlantProperty = GetStringProperty("PORel.GlbPlant");
                glbPlantProperty.Value = value;
            }
        }

        protected RowProperty<string> glbWarehouseProperty;
        public string GlbWarehouse
        {
            get
            {
                if (glbWarehouseProperty == null)
                    glbWarehouseProperty = GetStringProperty("PORel.GlbWarehouse");
                return glbWarehouseProperty.Value;
            }
            set
            {
                if (glbWarehouseProperty == null)
                    glbWarehouseProperty = GetStringProperty("PORel.GlbWarehouse");
                glbWarehouseProperty.Value = value;
            }
        }

        protected RowProperty<bool> glbCreateJobMtlProperty;
        public bool GlbCreateJobMtl
        {
            get
            {
                if (glbCreateJobMtlProperty == null)
                    glbCreateJobMtlProperty = GetBooleanProperty("PORel.GlbCreateJobMtl");
                return glbCreateJobMtlProperty.Value;
            }
            set
            {
                if (glbCreateJobMtlProperty == null)
                    glbCreateJobMtlProperty = GetBooleanProperty("PORel.GlbCreateJobMtl");
                glbCreateJobMtlProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> shippedDateProperty;
        public DateTime ShippedDate
        {
            get
            {
                if (shippedDateProperty == null)
                    shippedDateProperty = GetDateTimeProperty("PORel.ShippedDate");
                return shippedDateProperty.Value;
            }
            set
            {
                if (shippedDateProperty == null)
                    shippedDateProperty = GetDateTimeProperty("PORel.ShippedDate");
                shippedDateProperty.Value = value;
            }
        }

        protected RowProperty<int> containerIDProperty;
        public int ContainerID
        {
            get
            {
                if (containerIDProperty == null)
                    containerIDProperty = GetIntegerProperty("PORel.ContainerID");
                return containerIDProperty.Value;
            }
            set
            {
                if (containerIDProperty == null)
                    containerIDProperty = GetIntegerProperty("PORel.ContainerID");
                containerIDProperty.Value = value;
            }
        }

        protected RowProperty<string> purchasingFactorDirectionProperty;
        public string PurchasingFactorDirection
        {
            get
            {
                if (purchasingFactorDirectionProperty == null)
                    purchasingFactorDirectionProperty = GetStringProperty("PORel.PurchasingFactorDirection");
                return purchasingFactorDirectionProperty.Value;
            }
            set
            {
                if (purchasingFactorDirectionProperty == null)
                    purchasingFactorDirectionProperty = GetStringProperty("PORel.PurchasingFactorDirection");
                purchasingFactorDirectionProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> previousDueDateProperty;
        public DateTime PreviousDueDate
        {
            get
            {
                if (previousDueDateProperty == null)
                    previousDueDateProperty = GetDateTimeProperty("PORel.PreviousDueDate");
                return previousDueDateProperty.Value;
            }
            set
            {
                if (previousDueDateProperty == null)
                    previousDueDateProperty = GetDateTimeProperty("PORel.PreviousDueDate");
                previousDueDateProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region PurAgent Table

    [Serializable()]
    public abstract partial class PurAgentBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PurAgentBase<T, R>, new()
        where R : PurAgentRow, new()
    {
        protected PurAgentBase() : base() { }

        protected static Schema.PurAgent schemaTable;
        public static Schema.PurAgent SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PurAgent)V8Schema.Instance.TablesDictionary["PurAgent"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PurAgent.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByBuyerIDCriteria;
        public static T FillByBuyerID(DataContext context, string companyNum, string buyerID, params string[] columnNames)
        {
            if (fillByBuyerIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PurAgent.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PurAgent.BuyerID]));
                fillByBuyerIDCriteria = list.ToArray();
            }
            fillByBuyerIDCriteria[0].Value = companyNum;
            fillByBuyerIDCriteria[1].Value = buyerID;
            return EditTable<T, R>.Fetch(context, fillByBuyerIDCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PurAgent : PurAgentBase<PurAgent, PurAgentRow>
    {
        public PurAgent() : base() { }
    }

    #region PurAgentRow

    [Serializable()]
    public class PurAgentRow : DataRow
    {
        protected RowProperty<bool> inActiveProperty;
        public bool InActive
        {
            get
            {
                if (inActiveProperty == null)
                    inActiveProperty = GetBooleanProperty("PurAgent.InActive");
                return inActiveProperty.Value;
            }
            set
            {
                if (inActiveProperty == null)
                    inActiveProperty = GetBooleanProperty("PurAgent.InActive");
                inActiveProperty.Value = value;
            }
        }

        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PurAgent.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PurAgent.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> buyerIDProperty;
        public string BuyerID
        {
            get
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("PurAgent.BuyerID");
                return buyerIDProperty.Value;
            }
            set
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("PurAgent.BuyerID");
                buyerIDProperty.Value = value;
            }
        }

        protected RowProperty<string> nameProperty;
        public string Name
        {
            get
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("PurAgent.Name");
                return nameProperty.Value;
            }
            set
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("PurAgent.Name");
                nameProperty.Value = value;
            }
        }

        protected RowProperty<string> approvalPersonProperty;
        public string ApprovalPerson
        {
            get
            {
                if (approvalPersonProperty == null)
                    approvalPersonProperty = GetStringProperty("PurAgent.ApprovalPerson");
                return approvalPersonProperty.Value;
            }
            set
            {
                if (approvalPersonProperty == null)
                    approvalPersonProperty = GetStringProperty("PurAgent.ApprovalPerson");
                approvalPersonProperty.Value = value;
            }
        }

        protected RowProperty<decimal> pOLimitProperty;
        public decimal POLimit
        {
            get
            {
                if (pOLimitProperty == null)
                    pOLimitProperty = GetDecimalProperty("PurAgent.POLimit");
                return pOLimitProperty.Value;
            }
            set
            {
                if (pOLimitProperty == null)
                    pOLimitProperty = GetDecimalProperty("PurAgent.POLimit");
                pOLimitProperty.Value = value;
            }
        }

        protected RowProperty<string> eMailAddressProperty;
        public string EMailAddress
        {
            get
            {
                if (eMailAddressProperty == null)
                    eMailAddressProperty = GetStringProperty("PurAgent.EMailAddress");
                return eMailAddressProperty.Value;
            }
            set
            {
                if (eMailAddressProperty == null)
                    eMailAddressProperty = GetStringProperty("PurAgent.EMailAddress");
                eMailAddressProperty.Value = value;
            }
        }

        protected RowProperty<bool> consolidatedPurchasingProperty;
        public bool ConsolidatedPurchasing
        {
            get
            {
                if (consolidatedPurchasingProperty == null)
                    consolidatedPurchasingProperty = GetBooleanProperty("PurAgent.ConsolidatedPurchasing");
                return consolidatedPurchasingProperty.Value;
            }
            set
            {
                if (consolidatedPurchasingProperty == null)
                    consolidatedPurchasingProperty = GetBooleanProperty("PurAgent.ConsolidatedPurchasing");
                consolidatedPurchasingProperty.Value = value;
            }
        }

        protected RowProperty<string> cnvEmpIDProperty;
        public string CnvEmpID
        {
            get
            {
                if (cnvEmpIDProperty == null)
                    cnvEmpIDProperty = GetStringProperty("PurAgent.CnvEmpID");
                return cnvEmpIDProperty.Value;
            }
            set
            {
                if (cnvEmpIDProperty == null)
                    cnvEmpIDProperty = GetStringProperty("PurAgent.CnvEmpID");
                cnvEmpIDProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region Vendor Table

    [Serializable()]
    public abstract partial class VendorBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : VendorBase<T, R>, new()
        where R : VendorRow, new()
    {
        protected VendorBase() : base() { }

        protected static Schema.Vendor schemaTable;
        public static Schema.Vendor SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.Vendor)V8Schema.Instance.TablesDictionary["Vendor"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Vendor.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByVendorNumCriteria;
        public static T FillByVendorNum(DataContext context, string companyNum, int vendorNum, params string[] columnNames)
        {
            if (fillByVendorNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Vendor.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.Vendor.VendorNum]));
                fillByVendorNumCriteria = list.ToArray();
            }
            fillByVendorNumCriteria[0].Value = companyNum;
            fillByVendorNumCriteria[1].Value = vendorNum;
            return EditTable<T, R>.Fetch(context, fillByVendorNumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class Vendor : VendorBase<Vendor, VendorRow>
    {
        public Vendor() : base() { }
    }

    #region VendorRow

    [Serializable()]
    public class VendorRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Vendor.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Vendor.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> vendorIDProperty;
        public string VendorID
        {
            get
            {
                if (vendorIDProperty == null)
                    vendorIDProperty = GetStringProperty("Vendor.VendorID");
                return vendorIDProperty.Value;
            }
            set
            {
                if (vendorIDProperty == null)
                    vendorIDProperty = GetStringProperty("Vendor.VendorID");
                vendorIDProperty.Value = value;
            }
        }

        protected RowProperty<string> address1Property;
        public string Address1
        {
            get
            {
                if (address1Property == null)
                    address1Property = GetStringProperty("Vendor.Address1");
                return address1Property.Value;
            }
            set
            {
                if (address1Property == null)
                    address1Property = GetStringProperty("Vendor.Address1");
                address1Property.Value = value;
            }
        }

        protected RowProperty<string> address2Property;
        public string Address2
        {
            get
            {
                if (address2Property == null)
                    address2Property = GetStringProperty("Vendor.Address2");
                return address2Property.Value;
            }
            set
            {
                if (address2Property == null)
                    address2Property = GetStringProperty("Vendor.Address2");
                address2Property.Value = value;
            }
        }

        protected RowProperty<string> cityProperty;
        public string City
        {
            get
            {
                if (cityProperty == null)
                    cityProperty = GetStringProperty("Vendor.City");
                return cityProperty.Value;
            }
            set
            {
                if (cityProperty == null)
                    cityProperty = GetStringProperty("Vendor.City");
                cityProperty.Value = value;
            }
        }

        protected RowProperty<string> countryProperty;
        public string Country
        {
            get
            {
                if (countryProperty == null)
                    countryProperty = GetStringProperty("Vendor.Country");
                return countryProperty.Value;
            }
            set
            {
                if (countryProperty == null)
                    countryProperty = GetStringProperty("Vendor.Country");
                countryProperty.Value = value;
            }
        }

        protected RowProperty<string> groupCodeProperty;
        public string GroupCode
        {
            get
            {
                if (groupCodeProperty == null)
                    groupCodeProperty = GetStringProperty("Vendor.GroupCode");
                return groupCodeProperty.Value;
            }
            set
            {
                if (groupCodeProperty == null)
                    groupCodeProperty = GetStringProperty("Vendor.GroupCode");
                groupCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> nameProperty;
        public string Name
        {
            get
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("Vendor.Name");
                return nameProperty.Value;
            }
            set
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("Vendor.Name");
                nameProperty.Value = value;
            }
        }

        protected RowProperty<string> expenseDivProperty;
        public string ExpenseDiv
        {
            get
            {
                if (expenseDivProperty == null)
                    expenseDivProperty = GetStringProperty("Vendor.ExpenseDiv");
                return expenseDivProperty.Value;
            }
            set
            {
                if (expenseDivProperty == null)
                    expenseDivProperty = GetStringProperty("Vendor.ExpenseDiv");
                expenseDivProperty.Value = value;
            }
        }

        protected RowProperty<string> taxPayerIDProperty;
        public string TaxPayerID
        {
            get
            {
                if (taxPayerIDProperty == null)
                    taxPayerIDProperty = GetStringProperty("Vendor.TaxPayerID");
                return taxPayerIDProperty.Value;
            }
            set
            {
                if (taxPayerIDProperty == null)
                    taxPayerIDProperty = GetStringProperty("Vendor.TaxPayerID");
                taxPayerIDProperty.Value = value;
            }
        }

        protected RowProperty<string> faxNumProperty;
        public string FaxNum
        {
            get
            {
                if (faxNumProperty == null)
                    faxNumProperty = GetStringProperty("Vendor.FaxNum");
                return faxNumProperty.Value;
            }
            set
            {
                if (faxNumProperty == null)
                    faxNumProperty = GetStringProperty("Vendor.FaxNum");
                faxNumProperty.Value = value;
            }
        }

        protected RowProperty<string> purPointProperty;
        public string PurPoint
        {
            get
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("Vendor.PurPoint");
                return purPointProperty.Value;
            }
            set
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("Vendor.PurPoint");
                purPointProperty.Value = value;
            }
        }

        protected RowProperty<string> stateProperty;
        public string State
        {
            get
            {
                if (stateProperty == null)
                    stateProperty = GetStringProperty("Vendor.State");
                return stateProperty.Value;
            }
            set
            {
                if (stateProperty == null)
                    stateProperty = GetStringProperty("Vendor.State");
                stateProperty.Value = value;
            }
        }

        protected RowProperty<string> termsCodeProperty;
        public string TermsCode
        {
            get
            {
                if (termsCodeProperty == null)
                    termsCodeProperty = GetStringProperty("Vendor.TermsCode");
                return termsCodeProperty.Value;
            }
            set
            {
                if (termsCodeProperty == null)
                    termsCodeProperty = GetStringProperty("Vendor.TermsCode");
                termsCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> zipProperty;
        public string ZIP
        {
            get
            {
                if (zipProperty == null)
                    zipProperty = GetStringProperty("Vendor.ZIP");
                return zipProperty.Value;
            }
            set
            {
                if (zipProperty == null)
                    zipProperty = GetStringProperty("Vendor.ZIP");
                zipProperty.Value = value;
            }
        }

        protected RowProperty<bool> print1099Property;
        public bool Print1099
        {
            get
            {
                if (print1099Property == null)
                    print1099Property = GetBooleanProperty("Vendor.Print1099");
                return print1099Property.Value;
            }
            set
            {
                if (print1099Property == null)
                    print1099Property = GetBooleanProperty("Vendor.Print1099");
                print1099Property.Value = value;
            }
        }

        protected RowProperty<string> expenseChartProperty;
        public string ExpenseChart
        {
            get
            {
                if (expenseChartProperty == null)
                    expenseChartProperty = GetStringProperty("Vendor.ExpenseChart");
                return expenseChartProperty.Value;
            }
            set
            {
                if (expenseChartProperty == null)
                    expenseChartProperty = GetStringProperty("Vendor.ExpenseChart");
                expenseChartProperty.Value = value;
            }
        }

        protected RowProperty<string> expenseDeptProperty;
        public string ExpenseDept
        {
            get
            {
                if (expenseDeptProperty == null)
                    expenseDeptProperty = GetStringProperty("Vendor.ExpenseDept");
                return expenseDeptProperty.Value;
            }
            set
            {
                if (expenseDeptProperty == null)
                    expenseDeptProperty = GetStringProperty("Vendor.ExpenseDept");
                expenseDeptProperty.Value = value;
            }
        }

        protected RowProperty<bool> oneCheckProperty;
        public bool OneCheck
        {
            get
            {
                if (oneCheckProperty == null)
                    oneCheckProperty = GetBooleanProperty("Vendor.OneCheck");
                return oneCheckProperty.Value;
            }
            set
            {
                if (oneCheckProperty == null)
                    oneCheckProperty = GetBooleanProperty("Vendor.OneCheck");
                oneCheckProperty.Value = value;
            }
        }

        protected RowProperty<bool> printLabelsProperty;
        public bool PrintLabels
        {
            get
            {
                if (printLabelsProperty == null)
                    printLabelsProperty = GetBooleanProperty("Vendor.PrintLabels");
                return printLabelsProperty.Value;
            }
            set
            {
                if (printLabelsProperty == null)
                    printLabelsProperty = GetBooleanProperty("Vendor.PrintLabels");
                printLabelsProperty.Value = value;
            }
        }

        protected RowProperty<bool> inactiveProperty;
        public bool Inactive
        {
            get
            {
                if (inactiveProperty == null)
                    inactiveProperty = GetBooleanProperty("Vendor.Inactive");
                return inactiveProperty.Value;
            }
            set
            {
                if (inactiveProperty == null)
                    inactiveProperty = GetBooleanProperty("Vendor.Inactive");
                inactiveProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("Vendor.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("Vendor.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<string> phoneNumProperty;
        public string PhoneNum
        {
            get
            {
                if (phoneNumProperty == null)
                    phoneNumProperty = GetStringProperty("Vendor.PhoneNum");
                return phoneNumProperty.Value;
            }
            set
            {
                if (phoneNumProperty == null)
                    phoneNumProperty = GetStringProperty("Vendor.PhoneNum");
                phoneNumProperty.Value = value;
            }
        }

        protected RowProperty<string> commentProperty;
        public string Comment
        {
            get
            {
                if (commentProperty == null)
                    commentProperty = GetStringProperty("Vendor.Comment");
                return commentProperty.Value;
            }
            set
            {
                if (commentProperty == null)
                    commentProperty = GetStringProperty("Vendor.Comment");
                commentProperty.Value = value;
            }
        }

        protected RowProperty<string> address3Property;
        public string Address3
        {
            get
            {
                if (address3Property == null)
                    address3Property = GetStringProperty("Vendor.Address3");
                return address3Property.Value;
            }
            set
            {
                if (address3Property == null)
                    address3Property = GetStringProperty("Vendor.Address3");
                address3Property.Value = value;
            }
        }

        protected RowProperty<bool> payHoldProperty;
        public bool PayHold
        {
            get
            {
                if (payHoldProperty == null)
                    payHoldProperty = GetBooleanProperty("Vendor.PayHold");
                return payHoldProperty.Value;
            }
            set
            {
                if (payHoldProperty == null)
                    payHoldProperty = GetBooleanProperty("Vendor.PayHold");
                payHoldProperty.Value = value;
            }
        }

        protected RowProperty<int> primPConProperty;
        public int PrimPCon
        {
            get
            {
                if (primPConProperty == null)
                    primPConProperty = GetIntegerProperty("Vendor.PrimPCon");
                return primPConProperty.Value;
            }
            set
            {
                if (primPConProperty == null)
                    primPConProperty = GetIntegerProperty("Vendor.PrimPCon");
                primPConProperty.Value = value;
            }
        }

        protected RowProperty<string> accountRefProperty;
        public string AccountRef
        {
            get
            {
                if (accountRefProperty == null)
                    accountRefProperty = GetStringProperty("Vendor.AccountRef");
                return accountRefProperty.Value;
            }
            set
            {
                if (accountRefProperty == null)
                    accountRefProperty = GetStringProperty("Vendor.AccountRef");
                accountRefProperty.Value = value;
            }
        }

        protected RowProperty<string> aPAcctIDProperty;
        public string APAcctID
        {
            get
            {
                if (aPAcctIDProperty == null)
                    aPAcctIDProperty = GetStringProperty("Vendor.APAcctID");
                return aPAcctIDProperty.Value;
            }
            set
            {
                if (aPAcctIDProperty == null)
                    aPAcctIDProperty = GetStringProperty("Vendor.APAcctID");
                aPAcctIDProperty.Value = value;
            }
        }

        protected RowProperty<string> defaultFOBProperty;
        public string DefaultFOB
        {
            get
            {
                if (defaultFOBProperty == null)
                    defaultFOBProperty = GetStringProperty("Vendor.DefaultFOB");
                return defaultFOBProperty.Value;
            }
            set
            {
                if (defaultFOBProperty == null)
                    defaultFOBProperty = GetStringProperty("Vendor.DefaultFOB");
                defaultFOBProperty.Value = value;
            }
        }

        protected RowProperty<bool> rcvInspectionReqProperty;
        public bool RcvInspectionReq
        {
            get
            {
                if (rcvInspectionReqProperty == null)
                    rcvInspectionReqProperty = GetBooleanProperty("Vendor.RcvInspectionReq");
                return rcvInspectionReqProperty.Value;
            }
            set
            {
                if (rcvInspectionReqProperty == null)
                    rcvInspectionReqProperty = GetBooleanProperty("Vendor.RcvInspectionReq");
                rcvInspectionReqProperty.Value = value;
            }
        }

        protected RowProperty<string> currencyCodeProperty;
        public string CurrencyCode
        {
            get
            {
                if (currencyCodeProperty == null)
                    currencyCodeProperty = GetStringProperty("Vendor.CurrencyCode");
                return currencyCodeProperty.Value;
            }
            set
            {
                if (currencyCodeProperty == null)
                    currencyCodeProperty = GetStringProperty("Vendor.CurrencyCode");
                currencyCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> taxRegionCodeProperty;
        public string TaxRegionCode
        {
            get
            {
                if (taxRegionCodeProperty == null)
                    taxRegionCodeProperty = GetStringProperty("Vendor.TaxRegionCode");
                return taxRegionCodeProperty.Value;
            }
            set
            {
                if (taxRegionCodeProperty == null)
                    taxRegionCodeProperty = GetStringProperty("Vendor.TaxRegionCode");
                taxRegionCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> langNameIDProperty;
        public string LangNameID
        {
            get
            {
                if (langNameIDProperty == null)
                    langNameIDProperty = GetStringProperty("Vendor.LangNameID");
                return langNameIDProperty.Value;
            }
            set
            {
                if (langNameIDProperty == null)
                    langNameIDProperty = GetStringProperty("Vendor.LangNameID");
                langNameIDProperty.Value = value;
            }
        }

        protected RowProperty<int> countryNumProperty;
        public int CountryNum
        {
            get
            {
                if (countryNumProperty == null)
                    countryNumProperty = GetIntegerProperty("Vendor.CountryNum");
                return countryNumProperty.Value;
            }
            set
            {
                if (countryNumProperty == null)
                    countryNumProperty = GetIntegerProperty("Vendor.CountryNum");
                countryNumProperty.Value = value;
            }
        }

        protected RowProperty<string> formatStrProperty;
        public string FormatStr
        {
            get
            {
                if (formatStrProperty == null)
                    formatStrProperty = GetStringProperty("Vendor.FormatStr");
                return formatStrProperty.Value;
            }
            set
            {
                if (formatStrProperty == null)
                    formatStrProperty = GetStringProperty("Vendor.FormatStr");
                formatStrProperty.Value = value;
            }
        }

        protected RowProperty<string> borderCrossingProperty;
        public string BorderCrossing
        {
            get
            {
                if (borderCrossingProperty == null)
                    borderCrossingProperty = GetStringProperty("Vendor.BorderCrossing");
                return borderCrossingProperty.Value;
            }
            set
            {
                if (borderCrossingProperty == null)
                    borderCrossingProperty = GetStringProperty("Vendor.BorderCrossing");
                borderCrossingProperty.Value = value;
            }
        }

        protected RowProperty<bool> elecPaymentProperty;
        public bool ElecPayment
        {
            get
            {
                if (elecPaymentProperty == null)
                    elecPaymentProperty = GetBooleanProperty("Vendor.ElecPayment");
                return elecPaymentProperty.Value;
            }
            set
            {
                if (elecPaymentProperty == null)
                    elecPaymentProperty = GetBooleanProperty("Vendor.ElecPayment");
                elecPaymentProperty.Value = value;
            }
        }

        protected RowProperty<string> primaryBankIDProperty;
        public string PrimaryBankID
        {
            get
            {
                if (primaryBankIDProperty == null)
                    primaryBankIDProperty = GetStringProperty("Vendor.PrimaryBankID");
                return primaryBankIDProperty.Value;
            }
            set
            {
                if (primaryBankIDProperty == null)
                    primaryBankIDProperty = GetStringProperty("Vendor.PrimaryBankID");
                primaryBankIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> approvedProperty;
        public bool Approved
        {
            get
            {
                if (approvedProperty == null)
                    approvedProperty = GetBooleanProperty("Vendor.Approved");
                return approvedProperty.Value;
            }
            set
            {
                if (approvedProperty == null)
                    approvedProperty = GetBooleanProperty("Vendor.Approved");
                approvedProperty.Value = value;
            }
        }

        protected RowProperty<bool> iCVendProperty;
        public bool ICVend
        {
            get
            {
                if (iCVendProperty == null)
                    iCVendProperty = GetBooleanProperty("Vendor.ICVend");
                return iCVendProperty.Value;
            }
            set
            {
                if (iCVendProperty == null)
                    iCVendProperty = GetBooleanProperty("Vendor.ICVend");
                iCVendProperty.Value = value;
            }
        }

        protected RowProperty<string> eMailAddressProperty;
        public string EMailAddress
        {
            get
            {
                if (eMailAddressProperty == null)
                    eMailAddressProperty = GetStringProperty("Vendor.EMailAddress");
                return eMailAddressProperty.Value;
            }
            set
            {
                if (eMailAddressProperty == null)
                    eMailAddressProperty = GetStringProperty("Vendor.EMailAddress");
                eMailAddressProperty.Value = value;
            }
        }

        protected RowProperty<bool> webVendorProperty;
        public bool WebVendor
        {
            get
            {
                if (webVendorProperty == null)
                    webVendorProperty = GetBooleanProperty("Vendor.WebVendor");
                return webVendorProperty.Value;
            }
            set
            {
                if (webVendorProperty == null)
                    webVendorProperty = GetBooleanProperty("Vendor.WebVendor");
                webVendorProperty.Value = value;
            }
        }

        protected RowProperty<string> vendURLProperty;
        public string VendURL
        {
            get
            {
                if (vendURLProperty == null)
                    vendURLProperty = GetStringProperty("Vendor.VendURL");
                return vendURLProperty.Value;
            }
            set
            {
                if (vendURLProperty == null)
                    vendURLProperty = GetStringProperty("Vendor.VendURL");
                vendURLProperty.Value = value;
            }
        }

        protected RowProperty<int> earlyBufferProperty;
        public int EarlyBuffer
        {
            get
            {
                if (earlyBufferProperty == null)
                    earlyBufferProperty = GetIntegerProperty("Vendor.EarlyBuffer");
                return earlyBufferProperty.Value;
            }
            set
            {
                if (earlyBufferProperty == null)
                    earlyBufferProperty = GetIntegerProperty("Vendor.EarlyBuffer");
                earlyBufferProperty.Value = value;
            }
        }

        protected RowProperty<int> lateBufferProperty;
        public int LateBuffer
        {
            get
            {
                if (lateBufferProperty == null)
                    lateBufferProperty = GetIntegerProperty("Vendor.LateBuffer");
                return lateBufferProperty.Value;
            }
            set
            {
                if (lateBufferProperty == null)
                    lateBufferProperty = GetIntegerProperty("Vendor.LateBuffer");
                lateBufferProperty.Value = value;
            }
        }

        protected RowProperty<string> onTimeRatingProperty;
        public string OnTimeRating
        {
            get
            {
                if (onTimeRatingProperty == null)
                    onTimeRatingProperty = GetStringProperty("Vendor.OnTimeRating");
                return onTimeRatingProperty.Value;
            }
            set
            {
                if (onTimeRatingProperty == null)
                    onTimeRatingProperty = GetStringProperty("Vendor.OnTimeRating");
                onTimeRatingProperty.Value = value;
            }
        }

        protected RowProperty<string> qualityRatingProperty;
        public string QualityRating
        {
            get
            {
                if (qualityRatingProperty == null)
                    qualityRatingProperty = GetStringProperty("Vendor.QualityRating");
                return qualityRatingProperty.Value;
            }
            set
            {
                if (qualityRatingProperty == null)
                    qualityRatingProperty = GetStringProperty("Vendor.QualityRating");
                qualityRatingProperty.Value = value;
            }
        }

        protected RowProperty<string> priceRatingProperty;
        public string PriceRating
        {
            get
            {
                if (priceRatingProperty == null)
                    priceRatingProperty = GetStringProperty("Vendor.PriceRating");
                return priceRatingProperty.Value;
            }
            set
            {
                if (priceRatingProperty == null)
                    priceRatingProperty = GetStringProperty("Vendor.PriceRating");
                priceRatingProperty.Value = value;
            }
        }

        protected RowProperty<string> serviceRatingProperty;
        public string ServiceRating
        {
            get
            {
                if (serviceRatingProperty == null)
                    serviceRatingProperty = GetStringProperty("Vendor.ServiceRating");
                return serviceRatingProperty.Value;
            }
            set
            {
                if (serviceRatingProperty == null)
                    serviceRatingProperty = GetStringProperty("Vendor.ServiceRating");
                serviceRatingProperty.Value = value;
            }
        }

        protected RowProperty<string> externalIdProperty;
        public string ExternalId
        {
            get
            {
                if (externalIdProperty == null)
                    externalIdProperty = GetStringProperty("Vendor.ExternalId");
                return externalIdProperty.Value;
            }
            set
            {
                if (externalIdProperty == null)
                    externalIdProperty = GetStringProperty("Vendor.ExternalId");
                externalIdProperty.Value = value;
            }
        }

        protected RowProperty<int> vendPILimitProperty;
        public int VendPILimit
        {
            get
            {
                if (vendPILimitProperty == null)
                    vendPILimitProperty = GetIntegerProperty("Vendor.VendPILimit");
                return vendPILimitProperty.Value;
            }
            set
            {
                if (vendPILimitProperty == null)
                    vendPILimitProperty = GetIntegerProperty("Vendor.VendPILimit");
                vendPILimitProperty.Value = value;
            }
        }

        protected RowProperty<bool> globalVendorProperty;
        public bool GlobalVendor
        {
            get
            {
                if (globalVendorProperty == null)
                    globalVendorProperty = GetBooleanProperty("Vendor.GlobalVendor");
                return globalVendorProperty.Value;
            }
            set
            {
                if (globalVendorProperty == null)
                    globalVendorProperty = GetBooleanProperty("Vendor.GlobalVendor");
                globalVendorProperty.Value = value;
            }
        }

        protected RowProperty<bool> iCTraderProperty;
        public bool ICTrader
        {
            get
            {
                if (iCTraderProperty == null)
                    iCTraderProperty = GetBooleanProperty("Vendor.ICTrader");
                return iCTraderProperty.Value;
            }
            set
            {
                if (iCTraderProperty == null)
                    iCTraderProperty = GetBooleanProperty("Vendor.ICTrader");
                iCTraderProperty.Value = value;
            }
        }

        protected RowProperty<string> taxAuthorityCodeProperty;
        public string TaxAuthorityCode
        {
            get
            {
                if (taxAuthorityCodeProperty == null)
                    taxAuthorityCodeProperty = GetStringProperty("Vendor.TaxAuthorityCode");
                return taxAuthorityCodeProperty.Value;
            }
            set
            {
                if (taxAuthorityCodeProperty == null)
                    taxAuthorityCodeProperty = GetStringProperty("Vendor.TaxAuthorityCode");
                taxAuthorityCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> globalLockProperty;
        public bool GlobalLock
        {
            get
            {
                if (globalLockProperty == null)
                    globalLockProperty = GetBooleanProperty("Vendor.GlobalLock");
                return globalLockProperty.Value;
            }
            set
            {
                if (globalLockProperty == null)
                    globalLockProperty = GetBooleanProperty("Vendor.GlobalLock");
                globalLockProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minOrderValueProperty;
        public decimal Min_Order_Value
        {
            get
            {
                if (minOrderValueProperty == null)
                    minOrderValueProperty = GetDecimalProperty("Vendor.Min_Order_Value");
                return minOrderValueProperty.Value;
            }
            set
            {
                if (minOrderValueProperty == null)
                    minOrderValueProperty = GetDecimalProperty("Vendor.Min_Order_Value");
                minOrderValueProperty.Value = value;
            }
        }

        protected RowProperty<string> calendarIDProperty;
        public string CalendarID
        {
            get
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("Vendor.CalendarID");
                return calendarIDProperty.Value;
            }
            set
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("Vendor.CalendarID");
                calendarIDProperty.Value = value;
            }
        }

        protected RowProperty<string> eDICodeProperty;
        public string EDICode
        {
            get
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("Vendor.EDICode");
                return eDICodeProperty.Value;
            }
            set
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("Vendor.EDICode");
                eDICodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> localPurchasingProperty;
        public bool LocalPurchasing
        {
            get
            {
                if (localPurchasingProperty == null)
                    localPurchasingProperty = GetBooleanProperty("Vendor.LocalPurchasing");
                return localPurchasingProperty.Value;
            }
            set
            {
                if (localPurchasingProperty == null)
                    localPurchasingProperty = GetBooleanProperty("Vendor.LocalPurchasing");
                localPurchasingProperty.Value = value;
            }
        }

        protected RowProperty<bool> consolidatedPurchasingProperty;
        public bool ConsolidatedPurchasing
        {
            get
            {
                if (consolidatedPurchasingProperty == null)
                    consolidatedPurchasingProperty = GetBooleanProperty("Vendor.ConsolidatedPurchasing");
                return consolidatedPurchasingProperty.Value;
            }
            set
            {
                if (consolidatedPurchasingProperty == null)
                    consolidatedPurchasingProperty = GetBooleanProperty("Vendor.ConsolidatedPurchasing");
                consolidatedPurchasingProperty.Value = value;
            }
        }

        protected RowProperty<bool> satDeliveryProperty;
        public bool SatDelivery
        {
            get
            {
                if (satDeliveryProperty == null)
                    satDeliveryProperty = GetBooleanProperty("Vendor.SatDelivery");
                return satDeliveryProperty.Value;
            }
            set
            {
                if (satDeliveryProperty == null)
                    satDeliveryProperty = GetBooleanProperty("Vendor.SatDelivery");
                satDeliveryProperty.Value = value;
            }
        }

        protected RowProperty<bool> satPickupProperty;
        public bool SatPickup
        {
            get
            {
                if (satPickupProperty == null)
                    satPickupProperty = GetBooleanProperty("Vendor.SatPickup");
                return satPickupProperty.Value;
            }
            set
            {
                if (satPickupProperty == null)
                    satPickupProperty = GetBooleanProperty("Vendor.SatPickup");
                satPickupProperty.Value = value;
            }
        }

        protected RowProperty<bool> hazmatProperty;
        public bool Hazmat
        {
            get
            {
                if (hazmatProperty == null)
                    hazmatProperty = GetBooleanProperty("Vendor.Hazmat");
                return hazmatProperty.Value;
            }
            set
            {
                if (hazmatProperty == null)
                    hazmatProperty = GetBooleanProperty("Vendor.Hazmat");
                hazmatProperty.Value = value;
            }
        }

        protected RowProperty<bool> docOnlyProperty;
        public bool DocOnly
        {
            get
            {
                if (docOnlyProperty == null)
                    docOnlyProperty = GetBooleanProperty("Vendor.DocOnly");
                return docOnlyProperty.Value;
            }
            set
            {
                if (docOnlyProperty == null)
                    docOnlyProperty = GetBooleanProperty("Vendor.DocOnly");
                docOnlyProperty.Value = value;
            }
        }

        protected RowProperty<string> refNotesProperty;
        public string RefNotes
        {
            get
            {
                if (refNotesProperty == null)
                    refNotesProperty = GetStringProperty("Vendor.RefNotes");
                return refNotesProperty.Value;
            }
            set
            {
                if (refNotesProperty == null)
                    refNotesProperty = GetStringProperty("Vendor.RefNotes");
                refNotesProperty.Value = value;
            }
        }

        protected RowProperty<bool> applyChrgProperty;
        public bool ApplyChrg
        {
            get
            {
                if (applyChrgProperty == null)
                    applyChrgProperty = GetBooleanProperty("Vendor.ApplyChrg");
                return applyChrgProperty.Value;
            }
            set
            {
                if (applyChrgProperty == null)
                    applyChrgProperty = GetBooleanProperty("Vendor.ApplyChrg");
                applyChrgProperty.Value = value;
            }
        }

        protected RowProperty<decimal> chrgAmountProperty;
        public decimal ChrgAmount
        {
            get
            {
                if (chrgAmountProperty == null)
                    chrgAmountProperty = GetDecimalProperty("Vendor.ChrgAmount");
                return chrgAmountProperty.Value;
            }
            set
            {
                if (chrgAmountProperty == null)
                    chrgAmountProperty = GetDecimalProperty("Vendor.ChrgAmount");
                chrgAmountProperty.Value = value;
            }
        }

        protected RowProperty<bool> codProperty;
        public bool COD
        {
            get
            {
                if (codProperty == null)
                    codProperty = GetBooleanProperty("Vendor.COD");
                return codProperty.Value;
            }
            set
            {
                if (codProperty == null)
                    codProperty = GetBooleanProperty("Vendor.COD");
                codProperty.Value = value;
            }
        }

        protected RowProperty<bool> cODFreightProperty;
        public bool CODFreight
        {
            get
            {
                if (cODFreightProperty == null)
                    cODFreightProperty = GetBooleanProperty("Vendor.CODFreight");
                return cODFreightProperty.Value;
            }
            set
            {
                if (cODFreightProperty == null)
                    cODFreightProperty = GetBooleanProperty("Vendor.CODFreight");
                cODFreightProperty.Value = value;
            }
        }

        protected RowProperty<bool> cODCheckProperty;
        public bool CODCheck
        {
            get
            {
                if (cODCheckProperty == null)
                    cODCheckProperty = GetBooleanProperty("Vendor.CODCheck");
                return cODCheckProperty.Value;
            }
            set
            {
                if (cODCheckProperty == null)
                    cODCheckProperty = GetBooleanProperty("Vendor.CODCheck");
                cODCheckProperty.Value = value;
            }
        }

        protected RowProperty<decimal> cODAmountProperty;
        public decimal CODAmount
        {
            get
            {
                if (cODAmountProperty == null)
                    cODAmountProperty = GetDecimalProperty("Vendor.CODAmount");
                return cODAmountProperty.Value;
            }
            set
            {
                if (cODAmountProperty == null)
                    cODAmountProperty = GetDecimalProperty("Vendor.CODAmount");
                cODAmountProperty.Value = value;
            }
        }

        protected RowProperty<string> groundTypeProperty;
        public string GroundType
        {
            get
            {
                if (groundTypeProperty == null)
                    groundTypeProperty = GetStringProperty("Vendor.GroundType");
                return groundTypeProperty.Value;
            }
            set
            {
                if (groundTypeProperty == null)
                    groundTypeProperty = GetStringProperty("Vendor.GroundType");
                groundTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> notifyFlagProperty;
        public bool NotifyFlag
        {
            get
            {
                if (notifyFlagProperty == null)
                    notifyFlagProperty = GetBooleanProperty("Vendor.NotifyFlag");
                return notifyFlagProperty.Value;
            }
            set
            {
                if (notifyFlagProperty == null)
                    notifyFlagProperty = GetBooleanProperty("Vendor.NotifyFlag");
                notifyFlagProperty.Value = value;
            }
        }

        protected RowProperty<string> notifyEMailProperty;
        public string NotifyEMail
        {
            get
            {
                if (notifyEMailProperty == null)
                    notifyEMailProperty = GetStringProperty("Vendor.NotifyEMail");
                return notifyEMailProperty.Value;
            }
            set
            {
                if (notifyEMailProperty == null)
                    notifyEMailProperty = GetStringProperty("Vendor.NotifyEMail");
                notifyEMailProperty.Value = value;
            }
        }

        protected RowProperty<bool> declaredInsProperty;
        public bool DeclaredIns
        {
            get
            {
                if (declaredInsProperty == null)
                    declaredInsProperty = GetBooleanProperty("Vendor.DeclaredIns");
                return declaredInsProperty.Value;
            }
            set
            {
                if (declaredInsProperty == null)
                    declaredInsProperty = GetBooleanProperty("Vendor.DeclaredIns");
                declaredInsProperty.Value = value;
            }
        }

        protected RowProperty<decimal> declaredAmtProperty;
        public decimal DeclaredAmt
        {
            get
            {
                if (declaredAmtProperty == null)
                    declaredAmtProperty = GetDecimalProperty("Vendor.DeclaredAmt");
                return declaredAmtProperty.Value;
            }
            set
            {
                if (declaredAmtProperty == null)
                    declaredAmtProperty = GetDecimalProperty("Vendor.DeclaredAmt");
                declaredAmtProperty.Value = value;
            }
        }

        protected RowProperty<bool> resDeliveryProperty;
        public bool ResDelivery
        {
            get
            {
                if (resDeliveryProperty == null)
                    resDeliveryProperty = GetBooleanProperty("Vendor.ResDelivery");
                return resDeliveryProperty.Value;
            }
            set
            {
                if (resDeliveryProperty == null)
                    resDeliveryProperty = GetBooleanProperty("Vendor.ResDelivery");
                resDeliveryProperty.Value = value;
            }
        }

        protected RowProperty<bool> servSignatureProperty;
        public bool ServSignature
        {
            get
            {
                if (servSignatureProperty == null)
                    servSignatureProperty = GetBooleanProperty("Vendor.ServSignature");
                return servSignatureProperty.Value;
            }
            set
            {
                if (servSignatureProperty == null)
                    servSignatureProperty = GetBooleanProperty("Vendor.ServSignature");
                servSignatureProperty.Value = value;
            }
        }

        protected RowProperty<bool> servAlertProperty;
        public bool ServAlert
        {
            get
            {
                if (servAlertProperty == null)
                    servAlertProperty = GetBooleanProperty("Vendor.ServAlert");
                return servAlertProperty.Value;
            }
            set
            {
                if (servAlertProperty == null)
                    servAlertProperty = GetBooleanProperty("Vendor.ServAlert");
                servAlertProperty.Value = value;
            }
        }

        protected RowProperty<bool> servHomeDelProperty;
        public bool ServHomeDel
        {
            get
            {
                if (servHomeDelProperty == null)
                    servHomeDelProperty = GetBooleanProperty("Vendor.ServHomeDel");
                return servHomeDelProperty.Value;
            }
            set
            {
                if (servHomeDelProperty == null)
                    servHomeDelProperty = GetBooleanProperty("Vendor.ServHomeDel");
                servHomeDelProperty.Value = value;
            }
        }

        protected RowProperty<string> deliveryTypeProperty;
        public string DeliveryType
        {
            get
            {
                if (deliveryTypeProperty == null)
                    deliveryTypeProperty = GetStringProperty("Vendor.DeliveryType");
                return deliveryTypeProperty.Value;
            }
            set
            {
                if (deliveryTypeProperty == null)
                    deliveryTypeProperty = GetStringProperty("Vendor.DeliveryType");
                deliveryTypeProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> servDeliveryDateProperty;
        public DateTime ServDeliveryDate
        {
            get
            {
                if (servDeliveryDateProperty == null)
                    servDeliveryDateProperty = GetDateTimeProperty("Vendor.ServDeliveryDate");
                return servDeliveryDateProperty.Value;
            }
            set
            {
                if (servDeliveryDateProperty == null)
                    servDeliveryDateProperty = GetDateTimeProperty("Vendor.ServDeliveryDate");
                servDeliveryDateProperty.Value = value;
            }
        }

        protected RowProperty<string> servPhoneProperty;
        public string ServPhone
        {
            get
            {
                if (servPhoneProperty == null)
                    servPhoneProperty = GetStringProperty("Vendor.ServPhone");
                return servPhoneProperty.Value;
            }
            set
            {
                if (servPhoneProperty == null)
                    servPhoneProperty = GetStringProperty("Vendor.ServPhone");
                servPhoneProperty.Value = value;
            }
        }

        protected RowProperty<string> servInstructProperty;
        public string ServInstruct
        {
            get
            {
                if (servInstructProperty == null)
                    servInstructProperty = GetStringProperty("Vendor.ServInstruct");
                return servInstructProperty.Value;
            }
            set
            {
                if (servInstructProperty == null)
                    servInstructProperty = GetStringProperty("Vendor.ServInstruct");
                servInstructProperty.Value = value;
            }
        }

        protected RowProperty<bool> servReleaseProperty;
        public bool ServRelease
        {
            get
            {
                if (servReleaseProperty == null)
                    servReleaseProperty = GetBooleanProperty("Vendor.ServRelease");
                return servReleaseProperty.Value;
            }
            set
            {
                if (servReleaseProperty == null)
                    servReleaseProperty = GetBooleanProperty("Vendor.ServRelease");
                servReleaseProperty.Value = value;
            }
        }

        protected RowProperty<string> servAuthNumProperty;
        public string ServAuthNum
        {
            get
            {
                if (servAuthNumProperty == null)
                    servAuthNumProperty = GetStringProperty("Vendor.ServAuthNum");
                return servAuthNumProperty.Value;
            }
            set
            {
                if (servAuthNumProperty == null)
                    servAuthNumProperty = GetStringProperty("Vendor.ServAuthNum");
                servAuthNumProperty.Value = value;
            }
        }

        protected RowProperty<string> servRef1Property;
        public string ServRef1
        {
            get
            {
                if (servRef1Property == null)
                    servRef1Property = GetStringProperty("Vendor.ServRef1");
                return servRef1Property.Value;
            }
            set
            {
                if (servRef1Property == null)
                    servRef1Property = GetStringProperty("Vendor.ServRef1");
                servRef1Property.Value = value;
            }
        }

        protected RowProperty<string> servRef2Property;
        public string ServRef2
        {
            get
            {
                if (servRef2Property == null)
                    servRef2Property = GetStringProperty("Vendor.ServRef2");
                return servRef2Property.Value;
            }
            set
            {
                if (servRef2Property == null)
                    servRef2Property = GetStringProperty("Vendor.ServRef2");
                servRef2Property.Value = value;
            }
        }

        protected RowProperty<string> servRef3Property;
        public string ServRef3
        {
            get
            {
                if (servRef3Property == null)
                    servRef3Property = GetStringProperty("Vendor.ServRef3");
                return servRef3Property.Value;
            }
            set
            {
                if (servRef3Property == null)
                    servRef3Property = GetStringProperty("Vendor.ServRef3");
                servRef3Property.Value = value;
            }
        }

        protected RowProperty<string> servRef4Property;
        public string ServRef4
        {
            get
            {
                if (servRef4Property == null)
                    servRef4Property = GetStringProperty("Vendor.ServRef4");
                return servRef4Property.Value;
            }
            set
            {
                if (servRef4Property == null)
                    servRef4Property = GetStringProperty("Vendor.ServRef4");
                servRef4Property.Value = value;
            }
        }

        protected RowProperty<string> servRef5Property;
        public string ServRef5
        {
            get
            {
                if (servRef5Property == null)
                    servRef5Property = GetStringProperty("Vendor.ServRef5");
                return servRef5Property.Value;
            }
            set
            {
                if (servRef5Property == null)
                    servRef5Property = GetStringProperty("Vendor.ServRef5");
                servRef5Property.Value = value;
            }
        }

        protected RowProperty<bool> cPayProperty;
        public bool CPay
        {
            get
            {
                if (cPayProperty == null)
                    cPayProperty = GetBooleanProperty("Vendor.CPay");
                return cPayProperty.Value;
            }
            set
            {
                if (cPayProperty == null)
                    cPayProperty = GetBooleanProperty("Vendor.CPay");
                cPayProperty.Value = value;
            }
        }

        protected RowProperty<bool> intrntlShipProperty;
        public bool IntrntlShip
        {
            get
            {
                if (intrntlShipProperty == null)
                    intrntlShipProperty = GetBooleanProperty("Vendor.IntrntlShip");
                return intrntlShipProperty.Value;
            }
            set
            {
                if (intrntlShipProperty == null)
                    intrntlShipProperty = GetBooleanProperty("Vendor.IntrntlShip");
                intrntlShipProperty.Value = value;
            }
        }

        protected RowProperty<bool> certOfOriginProperty;
        public bool CertOfOrigin
        {
            get
            {
                if (certOfOriginProperty == null)
                    certOfOriginProperty = GetBooleanProperty("Vendor.CertOfOrigin");
                return certOfOriginProperty.Value;
            }
            set
            {
                if (certOfOriginProperty == null)
                    certOfOriginProperty = GetBooleanProperty("Vendor.CertOfOrigin");
                certOfOriginProperty.Value = value;
            }
        }

        protected RowProperty<bool> commercialInvoiceProperty;
        public bool CommercialInvoice
        {
            get
            {
                if (commercialInvoiceProperty == null)
                    commercialInvoiceProperty = GetBooleanProperty("Vendor.CommercialInvoice");
                return commercialInvoiceProperty.Value;
            }
            set
            {
                if (commercialInvoiceProperty == null)
                    commercialInvoiceProperty = GetBooleanProperty("Vendor.CommercialInvoice");
                commercialInvoiceProperty.Value = value;
            }
        }

        protected RowProperty<bool> shipExprtDeclartnProperty;
        public bool ShipExprtDeclartn
        {
            get
            {
                if (shipExprtDeclartnProperty == null)
                    shipExprtDeclartnProperty = GetBooleanProperty("Vendor.ShipExprtDeclartn");
                return shipExprtDeclartnProperty.Value;
            }
            set
            {
                if (shipExprtDeclartnProperty == null)
                    shipExprtDeclartnProperty = GetBooleanProperty("Vendor.ShipExprtDeclartn");
                shipExprtDeclartnProperty.Value = value;
            }
        }

        protected RowProperty<bool> letterOfInstrProperty;
        public bool LetterOfInstr
        {
            get
            {
                if (letterOfInstrProperty == null)
                    letterOfInstrProperty = GetBooleanProperty("Vendor.LetterOfInstr");
                return letterOfInstrProperty.Value;
            }
            set
            {
                if (letterOfInstrProperty == null)
                    letterOfInstrProperty = GetBooleanProperty("Vendor.LetterOfInstr");
                letterOfInstrProperty.Value = value;
            }
        }

        protected RowProperty<string> ffidProperty;
        public string FFID
        {
            get
            {
                if (ffidProperty == null)
                    ffidProperty = GetStringProperty("Vendor.FFID");
                return ffidProperty.Value;
            }
            set
            {
                if (ffidProperty == null)
                    ffidProperty = GetStringProperty("Vendor.FFID");
                ffidProperty.Value = value;
            }
        }

        protected RowProperty<string> fFCompNameProperty;
        public string FFCompName
        {
            get
            {
                if (fFCompNameProperty == null)
                    fFCompNameProperty = GetStringProperty("Vendor.FFCompName");
                return fFCompNameProperty.Value;
            }
            set
            {
                if (fFCompNameProperty == null)
                    fFCompNameProperty = GetStringProperty("Vendor.FFCompName");
                fFCompNameProperty.Value = value;
            }
        }

        protected RowProperty<string> fFContactProperty;
        public string FFContact
        {
            get
            {
                if (fFContactProperty == null)
                    fFContactProperty = GetStringProperty("Vendor.FFContact");
                return fFContactProperty.Value;
            }
            set
            {
                if (fFContactProperty == null)
                    fFContactProperty = GetStringProperty("Vendor.FFContact");
                fFContactProperty.Value = value;
            }
        }

        protected RowProperty<string> fFAddress1Property;
        public string FFAddress1
        {
            get
            {
                if (fFAddress1Property == null)
                    fFAddress1Property = GetStringProperty("Vendor.FFAddress1");
                return fFAddress1Property.Value;
            }
            set
            {
                if (fFAddress1Property == null)
                    fFAddress1Property = GetStringProperty("Vendor.FFAddress1");
                fFAddress1Property.Value = value;
            }
        }

        protected RowProperty<string> fFAddress2Property;
        public string FFAddress2
        {
            get
            {
                if (fFAddress2Property == null)
                    fFAddress2Property = GetStringProperty("Vendor.FFAddress2");
                return fFAddress2Property.Value;
            }
            set
            {
                if (fFAddress2Property == null)
                    fFAddress2Property = GetStringProperty("Vendor.FFAddress2");
                fFAddress2Property.Value = value;
            }
        }

        protected RowProperty<string> fFAddress3Property;
        public string FFAddress3
        {
            get
            {
                if (fFAddress3Property == null)
                    fFAddress3Property = GetStringProperty("Vendor.FFAddress3");
                return fFAddress3Property.Value;
            }
            set
            {
                if (fFAddress3Property == null)
                    fFAddress3Property = GetStringProperty("Vendor.FFAddress3");
                fFAddress3Property.Value = value;
            }
        }

        protected RowProperty<string> fFCityProperty;
        public string FFCity
        {
            get
            {
                if (fFCityProperty == null)
                    fFCityProperty = GetStringProperty("Vendor.FFCity");
                return fFCityProperty.Value;
            }
            set
            {
                if (fFCityProperty == null)
                    fFCityProperty = GetStringProperty("Vendor.FFCity");
                fFCityProperty.Value = value;
            }
        }

        protected RowProperty<string> fFStateProperty;
        public string FFState
        {
            get
            {
                if (fFStateProperty == null)
                    fFStateProperty = GetStringProperty("Vendor.FFState");
                return fFStateProperty.Value;
            }
            set
            {
                if (fFStateProperty == null)
                    fFStateProperty = GetStringProperty("Vendor.FFState");
                fFStateProperty.Value = value;
            }
        }

        protected RowProperty<string> fFZipProperty;
        public string FFZip
        {
            get
            {
                if (fFZipProperty == null)
                    fFZipProperty = GetStringProperty("Vendor.FFZip");
                return fFZipProperty.Value;
            }
            set
            {
                if (fFZipProperty == null)
                    fFZipProperty = GetStringProperty("Vendor.FFZip");
                fFZipProperty.Value = value;
            }
        }

        protected RowProperty<string> fFCountryProperty;
        public string FFCountry
        {
            get
            {
                if (fFCountryProperty == null)
                    fFCountryProperty = GetStringProperty("Vendor.FFCountry");
                return fFCountryProperty.Value;
            }
            set
            {
                if (fFCountryProperty == null)
                    fFCountryProperty = GetStringProperty("Vendor.FFCountry");
                fFCountryProperty.Value = value;
            }
        }

        protected RowProperty<bool> nonStdPkgProperty;
        public bool NonStdPkg
        {
            get
            {
                if (nonStdPkgProperty == null)
                    nonStdPkgProperty = GetBooleanProperty("Vendor.NonStdPkg");
                return nonStdPkgProperty.Value;
            }
            set
            {
                if (nonStdPkgProperty == null)
                    nonStdPkgProperty = GetBooleanProperty("Vendor.NonStdPkg");
                nonStdPkgProperty.Value = value;
            }
        }

        protected RowProperty<int> deliveryConfProperty;
        public int DeliveryConf
        {
            get
            {
                if (deliveryConfProperty == null)
                    deliveryConfProperty = GetIntegerProperty("Vendor.DeliveryConf");
                return deliveryConfProperty.Value;
            }
            set
            {
                if (deliveryConfProperty == null)
                    deliveryConfProperty = GetIntegerProperty("Vendor.DeliveryConf");
                deliveryConfProperty.Value = value;
            }
        }

        protected RowProperty<bool> addlHdlgFlagProperty;
        public bool AddlHdlgFlag
        {
            get
            {
                if (addlHdlgFlagProperty == null)
                    addlHdlgFlagProperty = GetBooleanProperty("Vendor.AddlHdlgFlag");
                return addlHdlgFlagProperty.Value;
            }
            set
            {
                if (addlHdlgFlagProperty == null)
                    addlHdlgFlagProperty = GetBooleanProperty("Vendor.AddlHdlgFlag");
                addlHdlgFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> individualPackIDsProperty;
        public bool IndividualPackIDs
        {
            get
            {
                if (individualPackIDsProperty == null)
                    individualPackIDsProperty = GetBooleanProperty("Vendor.IndividualPackIDs");
                return individualPackIDsProperty.Value;
            }
            set
            {
                if (individualPackIDsProperty == null)
                    individualPackIDsProperty = GetBooleanProperty("Vendor.IndividualPackIDs");
                individualPackIDsProperty.Value = value;
            }
        }

        protected RowProperty<string> uPSQVShipFromNameProperty;
        public string UPSQVShipFromName
        {
            get
            {
                if (uPSQVShipFromNameProperty == null)
                    uPSQVShipFromNameProperty = GetStringProperty("Vendor.UPSQVShipFromName");
                return uPSQVShipFromNameProperty.Value;
            }
            set
            {
                if (uPSQVShipFromNameProperty == null)
                    uPSQVShipFromNameProperty = GetStringProperty("Vendor.UPSQVShipFromName");
                uPSQVShipFromNameProperty.Value = value;
            }
        }

        protected RowProperty<string> uPSQVMemoProperty;
        public string UPSQVMemo
        {
            get
            {
                if (uPSQVMemoProperty == null)
                    uPSQVMemoProperty = GetStringProperty("Vendor.UPSQVMemo");
                return uPSQVMemoProperty.Value;
            }
            set
            {
                if (uPSQVMemoProperty == null)
                    uPSQVMemoProperty = GetStringProperty("Vendor.UPSQVMemo");
                uPSQVMemoProperty.Value = value;
            }
        }

        protected RowProperty<bool> uPSQuantumViewProperty;
        public bool UPSQuantumView
        {
            get
            {
                if (uPSQuantumViewProperty == null)
                    uPSQuantumViewProperty = GetBooleanProperty("Vendor.UPSQuantumView");
                return uPSQuantumViewProperty.Value;
            }
            set
            {
                if (uPSQuantumViewProperty == null)
                    uPSQuantumViewProperty = GetBooleanProperty("Vendor.UPSQuantumView");
                uPSQuantumViewProperty.Value = value;
            }
        }

        protected RowProperty<int> fFCountryNumProperty;
        public int FFCountryNum
        {
            get
            {
                if (fFCountryNumProperty == null)
                    fFCountryNumProperty = GetIntegerProperty("Vendor.FFCountryNum");
                return fFCountryNumProperty.Value;
            }
            set
            {
                if (fFCountryNumProperty == null)
                    fFCountryNumProperty = GetIntegerProperty("Vendor.FFCountryNum");
                fFCountryNumProperty.Value = value;
            }
        }

        protected RowProperty<string> fFPhoneNumProperty;
        public string FFPhoneNum
        {
            get
            {
                if (fFPhoneNumProperty == null)
                    fFPhoneNumProperty = GetStringProperty("Vendor.FFPhoneNum");
                return fFPhoneNumProperty.Value;
            }
            set
            {
                if (fFPhoneNumProperty == null)
                    fFPhoneNumProperty = GetStringProperty("Vendor.FFPhoneNum");
                fFPhoneNumProperty.Value = value;
            }
        }

        protected RowProperty<string> revChargeMethodProperty;
        public string RevChargeMethod
        {
            get
            {
                if (revChargeMethodProperty == null)
                    revChargeMethodProperty = GetStringProperty("Vendor.RevChargeMethod");
                return revChargeMethodProperty.Value;
            }
            set
            {
                if (revChargeMethodProperty == null)
                    revChargeMethodProperty = GetStringProperty("Vendor.RevChargeMethod");
                revChargeMethodProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #region VendorPP Table

    [Serializable()]
    public abstract partial class VendorPPBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : VendorPPBase<T, R>, new()
        where R : VendorPPRow, new()
    {
        protected VendorPPBase() : base() { }

        protected static Schema.VendorPP schemaTable;
        public static Schema.VendorPP SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.VendorPP)V8Schema.Instance.TablesDictionary["VendorPP"];
                }
                return schemaTable;
            }
        }

        #region Fill Methods

        protected static ICriteriaValue[] fillByCompanyNumCriteria;
        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByVendorNumCriteria;
        public static T FillByVendorNum(DataContext context, string companyNum, int vendorNum, params string[] columnNames)
        {
            if (fillByVendorNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.VendorPP.VendorNum]));
                fillByVendorNumCriteria = list.ToArray();
            }
            fillByVendorNumCriteria[0].Value = companyNum;
            fillByVendorNumCriteria[1].Value = vendorNum;
            return EditTable<T, R>.Fetch(context, fillByVendorNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPurPointCriteria;
        public static T FillByPurPoint(DataContext context, string companyNum, int vendorNum, string purPoint, params string[] columnNames)
        {
            if (fillByPurPointCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.CompanyNum]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.VendorPP.VendorNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.PurPoint]));
                fillByPurPointCriteria = list.ToArray();
            }
            fillByPurPointCriteria[0].Value = companyNum;
            fillByPurPointCriteria[1].Value = vendorNum;
            fillByPurPointCriteria[2].Value = purPoint;
            return EditTable<T, R>.Fetch(context, fillByPurPointCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class VendorPP : VendorPPBase<VendorPP, VendorPPRow>
    {
        public VendorPP() : base() { }
    }

    #region VendorPPRow

    [Serializable()]
    public class VendorPPRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("VendorPP.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("VendorPP.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> purPointProperty;
        public string PurPoint
        {
            get
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("VendorPP.PurPoint");
                return purPointProperty.Value;
            }
            set
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("VendorPP.PurPoint");
                purPointProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("VendorPP.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("VendorPP.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<string> address1Property;
        public string Address1
        {
            get
            {
                if (address1Property == null)
                    address1Property = GetStringProperty("VendorPP.Address1");
                return address1Property.Value;
            }
            set
            {
                if (address1Property == null)
                    address1Property = GetStringProperty("VendorPP.Address1");
                address1Property.Value = value;
            }
        }

        protected RowProperty<string> address2Property;
        public string Address2
        {
            get
            {
                if (address2Property == null)
                    address2Property = GetStringProperty("VendorPP.Address2");
                return address2Property.Value;
            }
            set
            {
                if (address2Property == null)
                    address2Property = GetStringProperty("VendorPP.Address2");
                address2Property.Value = value;
            }
        }

        protected RowProperty<string> cityProperty;
        public string City
        {
            get
            {
                if (cityProperty == null)
                    cityProperty = GetStringProperty("VendorPP.City");
                return cityProperty.Value;
            }
            set
            {
                if (cityProperty == null)
                    cityProperty = GetStringProperty("VendorPP.City");
                cityProperty.Value = value;
            }
        }

        protected RowProperty<string> countryProperty;
        public string Country
        {
            get
            {
                if (countryProperty == null)
                    countryProperty = GetStringProperty("VendorPP.Country");
                return countryProperty.Value;
            }
            set
            {
                if (countryProperty == null)
                    countryProperty = GetStringProperty("VendorPP.Country");
                countryProperty.Value = value;
            }
        }

        protected RowProperty<string> nameProperty;
        public string Name
        {
            get
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("VendorPP.Name");
                return nameProperty.Value;
            }
            set
            {
                if (nameProperty == null)
                    nameProperty = GetStringProperty("VendorPP.Name");
                nameProperty.Value = value;
            }
        }

        protected RowProperty<string> stateProperty;
        public string State
        {
            get
            {
                if (stateProperty == null)
                    stateProperty = GetStringProperty("VendorPP.State");
                return stateProperty.Value;
            }
            set
            {
                if (stateProperty == null)
                    stateProperty = GetStringProperty("VendorPP.State");
                stateProperty.Value = value;
            }
        }

        protected RowProperty<string> zipProperty;
        public string Zip
        {
            get
            {
                if (zipProperty == null)
                    zipProperty = GetStringProperty("VendorPP.Zip");
                return zipProperty.Value;
            }
            set
            {
                if (zipProperty == null)
                    zipProperty = GetStringProperty("VendorPP.Zip");
                zipProperty.Value = value;
            }
        }

        protected RowProperty<string> address3Property;
        public string Address3
        {
            get
            {
                if (address3Property == null)
                    address3Property = GetStringProperty("VendorPP.Address3");
                return address3Property.Value;
            }
            set
            {
                if (address3Property == null)
                    address3Property = GetStringProperty("VendorPP.Address3");
                address3Property.Value = value;
            }
        }

        protected RowProperty<int> primPConProperty;
        public int PrimPCon
        {
            get
            {
                if (primPConProperty == null)
                    primPConProperty = GetIntegerProperty("VendorPP.PrimPCon");
                return primPConProperty.Value;
            }
            set
            {
                if (primPConProperty == null)
                    primPConProperty = GetIntegerProperty("VendorPP.PrimPCon");
                primPConProperty.Value = value;
            }
        }

        protected RowProperty<string> langNameIDProperty;
        public string LangNameID
        {
            get
            {
                if (langNameIDProperty == null)
                    langNameIDProperty = GetStringProperty("VendorPP.LangNameID");
                return langNameIDProperty.Value;
            }
            set
            {
                if (langNameIDProperty == null)
                    langNameIDProperty = GetStringProperty("VendorPP.LangNameID");
                langNameIDProperty.Value = value;
            }
        }

        protected RowProperty<int> countryNumProperty;
        public int CountryNum
        {
            get
            {
                if (countryNumProperty == null)
                    countryNumProperty = GetIntegerProperty("VendorPP.CountryNum");
                return countryNumProperty.Value;
            }
            set
            {
                if (countryNumProperty == null)
                    countryNumProperty = GetIntegerProperty("VendorPP.CountryNum");
                countryNumProperty.Value = value;
            }
        }

        protected RowProperty<string> formatStrProperty;
        public string FormatStr
        {
            get
            {
                if (formatStrProperty == null)
                    formatStrProperty = GetStringProperty("VendorPP.FormatStr");
                return formatStrProperty.Value;
            }
            set
            {
                if (formatStrProperty == null)
                    formatStrProperty = GetStringProperty("VendorPP.FormatStr");
                formatStrProperty.Value = value;
            }
        }

        protected RowProperty<string> borderCrossingProperty;
        public string BorderCrossing
        {
            get
            {
                if (borderCrossingProperty == null)
                    borderCrossingProperty = GetStringProperty("VendorPP.BorderCrossing");
                return borderCrossingProperty.Value;
            }
            set
            {
                if (borderCrossingProperty == null)
                    borderCrossingProperty = GetStringProperty("VendorPP.BorderCrossing");
                borderCrossingProperty.Value = value;
            }
        }

        protected RowProperty<string> eMailAddressProperty;
        public string EMailAddress
        {
            get
            {
                if (eMailAddressProperty == null)
                    eMailAddressProperty = GetStringProperty("VendorPP.EMailAddress");
                return eMailAddressProperty.Value;
            }
            set
            {
                if (eMailAddressProperty == null)
                    eMailAddressProperty = GetStringProperty("VendorPP.EMailAddress");
                eMailAddressProperty.Value = value;
            }
        }

        protected RowProperty<string> externalIdProperty;
        public string ExternalId
        {
            get
            {
                if (externalIdProperty == null)
                    externalIdProperty = GetStringProperty("VendorPP.ExternalId");
                return externalIdProperty.Value;
            }
            set
            {
                if (externalIdProperty == null)
                    externalIdProperty = GetStringProperty("VendorPP.ExternalId");
                externalIdProperty.Value = value;
            }
        }

        protected RowProperty<string> taxAuthorityCodeProperty;
        public string TaxAuthorityCode
        {
            get
            {
                if (taxAuthorityCodeProperty == null)
                    taxAuthorityCodeProperty = GetStringProperty("VendorPP.TaxAuthorityCode");
                return taxAuthorityCodeProperty.Value;
            }
            set
            {
                if (taxAuthorityCodeProperty == null)
                    taxAuthorityCodeProperty = GetStringProperty("VendorPP.TaxAuthorityCode");
                taxAuthorityCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> globalLockProperty;
        public bool GlobalLock
        {
            get
            {
                if (globalLockProperty == null)
                    globalLockProperty = GetBooleanProperty("VendorPP.GlobalLock");
                return globalLockProperty.Value;
            }
            set
            {
                if (globalLockProperty == null)
                    globalLockProperty = GetBooleanProperty("VendorPP.GlobalLock");
                globalLockProperty.Value = value;
            }
        }

        protected RowProperty<string> eDICodeProperty;
        public string EDICode
        {
            get
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("VendorPP.EDICode");
                return eDICodeProperty.Value;
            }
            set
            {
                if (eDICodeProperty == null)
                    eDICodeProperty = GetStringProperty("VendorPP.EDICode");
                eDICodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> resDeliveryProperty;
        public bool ResDelivery
        {
            get
            {
                if (resDeliveryProperty == null)
                    resDeliveryProperty = GetBooleanProperty("VendorPP.ResDelivery");
                return resDeliveryProperty.Value;
            }
            set
            {
                if (resDeliveryProperty == null)
                    resDeliveryProperty = GetBooleanProperty("VendorPP.ResDelivery");
                resDeliveryProperty.Value = value;
            }
        }

        protected RowProperty<bool> satDeliveryProperty;
        public bool SatDelivery
        {
            get
            {
                if (satDeliveryProperty == null)
                    satDeliveryProperty = GetBooleanProperty("VendorPP.SatDelivery");
                return satDeliveryProperty.Value;
            }
            set
            {
                if (satDeliveryProperty == null)
                    satDeliveryProperty = GetBooleanProperty("VendorPP.SatDelivery");
                satDeliveryProperty.Value = value;
            }
        }

        protected RowProperty<bool> satPickupProperty;
        public bool SatPickup
        {
            get
            {
                if (satPickupProperty == null)
                    satPickupProperty = GetBooleanProperty("VendorPP.SatPickup");
                return satPickupProperty.Value;
            }
            set
            {
                if (satPickupProperty == null)
                    satPickupProperty = GetBooleanProperty("VendorPP.SatPickup");
                satPickupProperty.Value = value;
            }
        }

        protected RowProperty<bool> hazmatProperty;
        public bool Hazmat
        {
            get
            {
                if (hazmatProperty == null)
                    hazmatProperty = GetBooleanProperty("VendorPP.Hazmat");
                return hazmatProperty.Value;
            }
            set
            {
                if (hazmatProperty == null)
                    hazmatProperty = GetBooleanProperty("VendorPP.Hazmat");
                hazmatProperty.Value = value;
            }
        }

        protected RowProperty<bool> docOnlyProperty;
        public bool DocOnly
        {
            get
            {
                if (docOnlyProperty == null)
                    docOnlyProperty = GetBooleanProperty("VendorPP.DocOnly");
                return docOnlyProperty.Value;
            }
            set
            {
                if (docOnlyProperty == null)
                    docOnlyProperty = GetBooleanProperty("VendorPP.DocOnly");
                docOnlyProperty.Value = value;
            }
        }

        protected RowProperty<string> refNotesProperty;
        public string RefNotes
        {
            get
            {
                if (refNotesProperty == null)
                    refNotesProperty = GetStringProperty("VendorPP.RefNotes");
                return refNotesProperty.Value;
            }
            set
            {
                if (refNotesProperty == null)
                    refNotesProperty = GetStringProperty("VendorPP.RefNotes");
                refNotesProperty.Value = value;
            }
        }

        protected RowProperty<bool> applyChrgProperty;
        public bool ApplyChrg
        {
            get
            {
                if (applyChrgProperty == null)
                    applyChrgProperty = GetBooleanProperty("VendorPP.ApplyChrg");
                return applyChrgProperty.Value;
            }
            set
            {
                if (applyChrgProperty == null)
                    applyChrgProperty = GetBooleanProperty("VendorPP.ApplyChrg");
                applyChrgProperty.Value = value;
            }
        }

        protected RowProperty<decimal> chrgAmountProperty;
        public decimal ChrgAmount
        {
            get
            {
                if (chrgAmountProperty == null)
                    chrgAmountProperty = GetDecimalProperty("VendorPP.ChrgAmount");
                return chrgAmountProperty.Value;
            }
            set
            {
                if (chrgAmountProperty == null)
                    chrgAmountProperty = GetDecimalProperty("VendorPP.ChrgAmount");
                chrgAmountProperty.Value = value;
            }
        }

        protected RowProperty<bool> codProperty;
        public bool COD
        {
            get
            {
                if (codProperty == null)
                    codProperty = GetBooleanProperty("VendorPP.COD");
                return codProperty.Value;
            }
            set
            {
                if (codProperty == null)
                    codProperty = GetBooleanProperty("VendorPP.COD");
                codProperty.Value = value;
            }
        }

        protected RowProperty<bool> cODFreightProperty;
        public bool CODFreight
        {
            get
            {
                if (cODFreightProperty == null)
                    cODFreightProperty = GetBooleanProperty("VendorPP.CODFreight");
                return cODFreightProperty.Value;
            }
            set
            {
                if (cODFreightProperty == null)
                    cODFreightProperty = GetBooleanProperty("VendorPP.CODFreight");
                cODFreightProperty.Value = value;
            }
        }

        protected RowProperty<bool> cODCheckProperty;
        public bool CODCheck
        {
            get
            {
                if (cODCheckProperty == null)
                    cODCheckProperty = GetBooleanProperty("VendorPP.CODCheck");
                return cODCheckProperty.Value;
            }
            set
            {
                if (cODCheckProperty == null)
                    cODCheckProperty = GetBooleanProperty("VendorPP.CODCheck");
                cODCheckProperty.Value = value;
            }
        }

        protected RowProperty<decimal> cODAmountProperty;
        public decimal CODAmount
        {
            get
            {
                if (cODAmountProperty == null)
                    cODAmountProperty = GetDecimalProperty("VendorPP.CODAmount");
                return cODAmountProperty.Value;
            }
            set
            {
                if (cODAmountProperty == null)
                    cODAmountProperty = GetDecimalProperty("VendorPP.CODAmount");
                cODAmountProperty.Value = value;
            }
        }

        protected RowProperty<string> groundTypeProperty;
        public string GroundType
        {
            get
            {
                if (groundTypeProperty == null)
                    groundTypeProperty = GetStringProperty("VendorPP.GroundType");
                return groundTypeProperty.Value;
            }
            set
            {
                if (groundTypeProperty == null)
                    groundTypeProperty = GetStringProperty("VendorPP.GroundType");
                groundTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> notifyFlagProperty;
        public bool NotifyFlag
        {
            get
            {
                if (notifyFlagProperty == null)
                    notifyFlagProperty = GetBooleanProperty("VendorPP.NotifyFlag");
                return notifyFlagProperty.Value;
            }
            set
            {
                if (notifyFlagProperty == null)
                    notifyFlagProperty = GetBooleanProperty("VendorPP.NotifyFlag");
                notifyFlagProperty.Value = value;
            }
        }

        protected RowProperty<string> notifyEMailProperty;
        public string NotifyEMail
        {
            get
            {
                if (notifyEMailProperty == null)
                    notifyEMailProperty = GetStringProperty("VendorPP.NotifyEMail");
                return notifyEMailProperty.Value;
            }
            set
            {
                if (notifyEMailProperty == null)
                    notifyEMailProperty = GetStringProperty("VendorPP.NotifyEMail");
                notifyEMailProperty.Value = value;
            }
        }

        protected RowProperty<bool> declaredInsProperty;
        public bool DeclaredIns
        {
            get
            {
                if (declaredInsProperty == null)
                    declaredInsProperty = GetBooleanProperty("VendorPP.DeclaredIns");
                return declaredInsProperty.Value;
            }
            set
            {
                if (declaredInsProperty == null)
                    declaredInsProperty = GetBooleanProperty("VendorPP.DeclaredIns");
                declaredInsProperty.Value = value;
            }
        }

        protected RowProperty<decimal> declaredAmtProperty;
        public decimal DeclaredAmt
        {
            get
            {
                if (declaredAmtProperty == null)
                    declaredAmtProperty = GetDecimalProperty("VendorPP.DeclaredAmt");
                return declaredAmtProperty.Value;
            }
            set
            {
                if (declaredAmtProperty == null)
                    declaredAmtProperty = GetDecimalProperty("VendorPP.DeclaredAmt");
                declaredAmtProperty.Value = value;
            }
        }

        protected RowProperty<bool> servSignatureProperty;
        public bool ServSignature
        {
            get
            {
                if (servSignatureProperty == null)
                    servSignatureProperty = GetBooleanProperty("VendorPP.ServSignature");
                return servSignatureProperty.Value;
            }
            set
            {
                if (servSignatureProperty == null)
                    servSignatureProperty = GetBooleanProperty("VendorPP.ServSignature");
                servSignatureProperty.Value = value;
            }
        }

        protected RowProperty<bool> servAlertProperty;
        public bool ServAlert
        {
            get
            {
                if (servAlertProperty == null)
                    servAlertProperty = GetBooleanProperty("VendorPP.ServAlert");
                return servAlertProperty.Value;
            }
            set
            {
                if (servAlertProperty == null)
                    servAlertProperty = GetBooleanProperty("VendorPP.ServAlert");
                servAlertProperty.Value = value;
            }
        }

        protected RowProperty<bool> servHomeDelProperty;
        public bool ServHomeDel
        {
            get
            {
                if (servHomeDelProperty == null)
                    servHomeDelProperty = GetBooleanProperty("VendorPP.ServHomeDel");
                return servHomeDelProperty.Value;
            }
            set
            {
                if (servHomeDelProperty == null)
                    servHomeDelProperty = GetBooleanProperty("VendorPP.ServHomeDel");
                servHomeDelProperty.Value = value;
            }
        }

        protected RowProperty<string> deliveryTypeProperty;
        public string DeliveryType
        {
            get
            {
                if (deliveryTypeProperty == null)
                    deliveryTypeProperty = GetStringProperty("VendorPP.DeliveryType");
                return deliveryTypeProperty.Value;
            }
            set
            {
                if (deliveryTypeProperty == null)
                    deliveryTypeProperty = GetStringProperty("VendorPP.DeliveryType");
                deliveryTypeProperty.Value = value;
            }
        }

        protected RowProperty<DateTime> servDeliveryDateProperty;
        public DateTime ServDeliveryDate
        {
            get
            {
                if (servDeliveryDateProperty == null)
                    servDeliveryDateProperty = GetDateTimeProperty("VendorPP.ServDeliveryDate");
                return servDeliveryDateProperty.Value;
            }
            set
            {
                if (servDeliveryDateProperty == null)
                    servDeliveryDateProperty = GetDateTimeProperty("VendorPP.ServDeliveryDate");
                servDeliveryDateProperty.Value = value;
            }
        }

        protected RowProperty<string> servPhoneProperty;
        public string ServPhone
        {
            get
            {
                if (servPhoneProperty == null)
                    servPhoneProperty = GetStringProperty("VendorPP.ServPhone");
                return servPhoneProperty.Value;
            }
            set
            {
                if (servPhoneProperty == null)
                    servPhoneProperty = GetStringProperty("VendorPP.ServPhone");
                servPhoneProperty.Value = value;
            }
        }

        protected RowProperty<string> servInstructProperty;
        public string ServInstruct
        {
            get
            {
                if (servInstructProperty == null)
                    servInstructProperty = GetStringProperty("VendorPP.ServInstruct");
                return servInstructProperty.Value;
            }
            set
            {
                if (servInstructProperty == null)
                    servInstructProperty = GetStringProperty("VendorPP.ServInstruct");
                servInstructProperty.Value = value;
            }
        }

        protected RowProperty<bool> servReleaseProperty;
        public bool ServRelease
        {
            get
            {
                if (servReleaseProperty == null)
                    servReleaseProperty = GetBooleanProperty("VendorPP.ServRelease");
                return servReleaseProperty.Value;
            }
            set
            {
                if (servReleaseProperty == null)
                    servReleaseProperty = GetBooleanProperty("VendorPP.ServRelease");
                servReleaseProperty.Value = value;
            }
        }

        protected RowProperty<string> servAuthNumProperty;
        public string ServAuthNum
        {
            get
            {
                if (servAuthNumProperty == null)
                    servAuthNumProperty = GetStringProperty("VendorPP.ServAuthNum");
                return servAuthNumProperty.Value;
            }
            set
            {
                if (servAuthNumProperty == null)
                    servAuthNumProperty = GetStringProperty("VendorPP.ServAuthNum");
                servAuthNumProperty.Value = value;
            }
        }

        protected RowProperty<string> servRef1Property;
        public string ServRef1
        {
            get
            {
                if (servRef1Property == null)
                    servRef1Property = GetStringProperty("VendorPP.ServRef1");
                return servRef1Property.Value;
            }
            set
            {
                if (servRef1Property == null)
                    servRef1Property = GetStringProperty("VendorPP.ServRef1");
                servRef1Property.Value = value;
            }
        }

        protected RowProperty<string> servRef2Property;
        public string ServRef2
        {
            get
            {
                if (servRef2Property == null)
                    servRef2Property = GetStringProperty("VendorPP.ServRef2");
                return servRef2Property.Value;
            }
            set
            {
                if (servRef2Property == null)
                    servRef2Property = GetStringProperty("VendorPP.ServRef2");
                servRef2Property.Value = value;
            }
        }

        protected RowProperty<string> servRef3Property;
        public string ServRef3
        {
            get
            {
                if (servRef3Property == null)
                    servRef3Property = GetStringProperty("VendorPP.ServRef3");
                return servRef3Property.Value;
            }
            set
            {
                if (servRef3Property == null)
                    servRef3Property = GetStringProperty("VendorPP.ServRef3");
                servRef3Property.Value = value;
            }
        }

        protected RowProperty<string> servRef4Property;
        public string ServRef4
        {
            get
            {
                if (servRef4Property == null)
                    servRef4Property = GetStringProperty("VendorPP.ServRef4");
                return servRef4Property.Value;
            }
            set
            {
                if (servRef4Property == null)
                    servRef4Property = GetStringProperty("VendorPP.ServRef4");
                servRef4Property.Value = value;
            }
        }

        protected RowProperty<string> servRef5Property;
        public string ServRef5
        {
            get
            {
                if (servRef5Property == null)
                    servRef5Property = GetStringProperty("VendorPP.ServRef5");
                return servRef5Property.Value;
            }
            set
            {
                if (servRef5Property == null)
                    servRef5Property = GetStringProperty("VendorPP.ServRef5");
                servRef5Property.Value = value;
            }
        }

        protected RowProperty<bool> overrideCarrierProperty;
        public bool OverrideCarrier
        {
            get
            {
                if (overrideCarrierProperty == null)
                    overrideCarrierProperty = GetBooleanProperty("VendorPP.OverrideCarrier");
                return overrideCarrierProperty.Value;
            }
            set
            {
                if (overrideCarrierProperty == null)
                    overrideCarrierProperty = GetBooleanProperty("VendorPP.OverrideCarrier");
                overrideCarrierProperty.Value = value;
            }
        }

        protected RowProperty<bool> overrideServiceProperty;
        public bool OverrideService
        {
            get
            {
                if (overrideServiceProperty == null)
                    overrideServiceProperty = GetBooleanProperty("VendorPP.OverrideService");
                return overrideServiceProperty.Value;
            }
            set
            {
                if (overrideServiceProperty == null)
                    overrideServiceProperty = GetBooleanProperty("VendorPP.OverrideService");
                overrideServiceProperty.Value = value;
            }
        }

        protected RowProperty<bool> individualPackIDsProperty;
        public bool IndividualPackIDs
        {
            get
            {
                if (individualPackIDsProperty == null)
                    individualPackIDsProperty = GetBooleanProperty("VendorPP.IndividualPackIDs");
                return individualPackIDsProperty.Value;
            }
            set
            {
                if (individualPackIDsProperty == null)
                    individualPackIDsProperty = GetBooleanProperty("VendorPP.IndividualPackIDs");
                individualPackIDsProperty.Value = value;
            }
        }

        protected RowProperty<bool> intrntlShipProperty;
        public bool IntrntlShip
        {
            get
            {
                if (intrntlShipProperty == null)
                    intrntlShipProperty = GetBooleanProperty("VendorPP.IntrntlShip");
                return intrntlShipProperty.Value;
            }
            set
            {
                if (intrntlShipProperty == null)
                    intrntlShipProperty = GetBooleanProperty("VendorPP.IntrntlShip");
                intrntlShipProperty.Value = value;
            }
        }

        protected RowProperty<bool> certOfOriginProperty;
        public bool CertOfOrigin
        {
            get
            {
                if (certOfOriginProperty == null)
                    certOfOriginProperty = GetBooleanProperty("VendorPP.CertOfOrigin");
                return certOfOriginProperty.Value;
            }
            set
            {
                if (certOfOriginProperty == null)
                    certOfOriginProperty = GetBooleanProperty("VendorPP.CertOfOrigin");
                certOfOriginProperty.Value = value;
            }
        }

        protected RowProperty<bool> commercialInvoiceProperty;
        public bool CommercialInvoice
        {
            get
            {
                if (commercialInvoiceProperty == null)
                    commercialInvoiceProperty = GetBooleanProperty("VendorPP.CommercialInvoice");
                return commercialInvoiceProperty.Value;
            }
            set
            {
                if (commercialInvoiceProperty == null)
                    commercialInvoiceProperty = GetBooleanProperty("VendorPP.CommercialInvoice");
                commercialInvoiceProperty.Value = value;
            }
        }

        protected RowProperty<bool> shipExprtDeclartnProperty;
        public bool ShipExprtDeclartn
        {
            get
            {
                if (shipExprtDeclartnProperty == null)
                    shipExprtDeclartnProperty = GetBooleanProperty("VendorPP.ShipExprtDeclartn");
                return shipExprtDeclartnProperty.Value;
            }
            set
            {
                if (shipExprtDeclartnProperty == null)
                    shipExprtDeclartnProperty = GetBooleanProperty("VendorPP.ShipExprtDeclartn");
                shipExprtDeclartnProperty.Value = value;
            }
        }

        protected RowProperty<bool> letterOfInstrProperty;
        public bool LetterOfInstr
        {
            get
            {
                if (letterOfInstrProperty == null)
                    letterOfInstrProperty = GetBooleanProperty("VendorPP.LetterOfInstr");
                return letterOfInstrProperty.Value;
            }
            set
            {
                if (letterOfInstrProperty == null)
                    letterOfInstrProperty = GetBooleanProperty("VendorPP.LetterOfInstr");
                letterOfInstrProperty.Value = value;
            }
        }

        protected RowProperty<string> ffidProperty;
        public string FFID
        {
            get
            {
                if (ffidProperty == null)
                    ffidProperty = GetStringProperty("VendorPP.FFID");
                return ffidProperty.Value;
            }
            set
            {
                if (ffidProperty == null)
                    ffidProperty = GetStringProperty("VendorPP.FFID");
                ffidProperty.Value = value;
            }
        }

        protected RowProperty<string> fFCompNameProperty;
        public string FFCompName
        {
            get
            {
                if (fFCompNameProperty == null)
                    fFCompNameProperty = GetStringProperty("VendorPP.FFCompName");
                return fFCompNameProperty.Value;
            }
            set
            {
                if (fFCompNameProperty == null)
                    fFCompNameProperty = GetStringProperty("VendorPP.FFCompName");
                fFCompNameProperty.Value = value;
            }
        }

        protected RowProperty<string> fFContactProperty;
        public string FFContact
        {
            get
            {
                if (fFContactProperty == null)
                    fFContactProperty = GetStringProperty("VendorPP.FFContact");
                return fFContactProperty.Value;
            }
            set
            {
                if (fFContactProperty == null)
                    fFContactProperty = GetStringProperty("VendorPP.FFContact");
                fFContactProperty.Value = value;
            }
        }

        protected RowProperty<string> fFAddress1Property;
        public string FFAddress1
        {
            get
            {
                if (fFAddress1Property == null)
                    fFAddress1Property = GetStringProperty("VendorPP.FFAddress1");
                return fFAddress1Property.Value;
            }
            set
            {
                if (fFAddress1Property == null)
                    fFAddress1Property = GetStringProperty("VendorPP.FFAddress1");
                fFAddress1Property.Value = value;
            }
        }

        protected RowProperty<string> fFAddress2Property;
        public string FFAddress2
        {
            get
            {
                if (fFAddress2Property == null)
                    fFAddress2Property = GetStringProperty("VendorPP.FFAddress2");
                return fFAddress2Property.Value;
            }
            set
            {
                if (fFAddress2Property == null)
                    fFAddress2Property = GetStringProperty("VendorPP.FFAddress2");
                fFAddress2Property.Value = value;
            }
        }

        protected RowProperty<string> fFAddress3Property;
        public string FFAddress3
        {
            get
            {
                if (fFAddress3Property == null)
                    fFAddress3Property = GetStringProperty("VendorPP.FFAddress3");
                return fFAddress3Property.Value;
            }
            set
            {
                if (fFAddress3Property == null)
                    fFAddress3Property = GetStringProperty("VendorPP.FFAddress3");
                fFAddress3Property.Value = value;
            }
        }

        protected RowProperty<string> fFCityProperty;
        public string FFCity
        {
            get
            {
                if (fFCityProperty == null)
                    fFCityProperty = GetStringProperty("VendorPP.FFCity");
                return fFCityProperty.Value;
            }
            set
            {
                if (fFCityProperty == null)
                    fFCityProperty = GetStringProperty("VendorPP.FFCity");
                fFCityProperty.Value = value;
            }
        }

        protected RowProperty<string> fFStateProperty;
        public string FFState
        {
            get
            {
                if (fFStateProperty == null)
                    fFStateProperty = GetStringProperty("VendorPP.FFState");
                return fFStateProperty.Value;
            }
            set
            {
                if (fFStateProperty == null)
                    fFStateProperty = GetStringProperty("VendorPP.FFState");
                fFStateProperty.Value = value;
            }
        }

        protected RowProperty<string> fFZipProperty;
        public string FFZip
        {
            get
            {
                if (fFZipProperty == null)
                    fFZipProperty = GetStringProperty("VendorPP.FFZip");
                return fFZipProperty.Value;
            }
            set
            {
                if (fFZipProperty == null)
                    fFZipProperty = GetStringProperty("VendorPP.FFZip");
                fFZipProperty.Value = value;
            }
        }

        protected RowProperty<string> fFCountryProperty;
        public string FFCountry
        {
            get
            {
                if (fFCountryProperty == null)
                    fFCountryProperty = GetStringProperty("VendorPP.FFCountry");
                return fFCountryProperty.Value;
            }
            set
            {
                if (fFCountryProperty == null)
                    fFCountryProperty = GetStringProperty("VendorPP.FFCountry");
                fFCountryProperty.Value = value;
            }
        }

        protected RowProperty<bool> nonStdPkgProperty;
        public bool NonStdPkg
        {
            get
            {
                if (nonStdPkgProperty == null)
                    nonStdPkgProperty = GetBooleanProperty("VendorPP.NonStdPkg");
                return nonStdPkgProperty.Value;
            }
            set
            {
                if (nonStdPkgProperty == null)
                    nonStdPkgProperty = GetBooleanProperty("VendorPP.NonStdPkg");
                nonStdPkgProperty.Value = value;
            }
        }

        protected RowProperty<int> deliveryConfProperty;
        public int DeliveryConf
        {
            get
            {
                if (deliveryConfProperty == null)
                    deliveryConfProperty = GetIntegerProperty("VendorPP.DeliveryConf");
                return deliveryConfProperty.Value;
            }
            set
            {
                if (deliveryConfProperty == null)
                    deliveryConfProperty = GetIntegerProperty("VendorPP.DeliveryConf");
                deliveryConfProperty.Value = value;
            }
        }

        protected RowProperty<bool> addlHdlgFlagProperty;
        public bool AddlHdlgFlag
        {
            get
            {
                if (addlHdlgFlagProperty == null)
                    addlHdlgFlagProperty = GetBooleanProperty("VendorPP.AddlHdlgFlag");
                return addlHdlgFlagProperty.Value;
            }
            set
            {
                if (addlHdlgFlagProperty == null)
                    addlHdlgFlagProperty = GetBooleanProperty("VendorPP.AddlHdlgFlag");
                addlHdlgFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> uPSQuantumViewProperty;
        public bool UPSQuantumView
        {
            get
            {
                if (uPSQuantumViewProperty == null)
                    uPSQuantumViewProperty = GetBooleanProperty("VendorPP.UPSQuantumView");
                return uPSQuantumViewProperty.Value;
            }
            set
            {
                if (uPSQuantumViewProperty == null)
                    uPSQuantumViewProperty = GetBooleanProperty("VendorPP.UPSQuantumView");
                uPSQuantumViewProperty.Value = value;
            }
        }

        protected RowProperty<string> uPSQVShipFromNameProperty;
        public string UPSQVShipFromName
        {
            get
            {
                if (uPSQVShipFromNameProperty == null)
                    uPSQVShipFromNameProperty = GetStringProperty("VendorPP.UPSQVShipFromName");
                return uPSQVShipFromNameProperty.Value;
            }
            set
            {
                if (uPSQVShipFromNameProperty == null)
                    uPSQVShipFromNameProperty = GetStringProperty("VendorPP.UPSQVShipFromName");
                uPSQVShipFromNameProperty.Value = value;
            }
        }

        protected RowProperty<string> uPSQVMemoProperty;
        public string UPSQVMemo
        {
            get
            {
                if (uPSQVMemoProperty == null)
                    uPSQVMemoProperty = GetStringProperty("VendorPP.UPSQVMemo");
                return uPSQVMemoProperty.Value;
            }
            set
            {
                if (uPSQVMemoProperty == null)
                    uPSQVMemoProperty = GetStringProperty("VendorPP.UPSQVMemo");
                uPSQVMemoProperty.Value = value;
            }
        }

        protected RowProperty<string> fFPhoneNumProperty;
        public string FFPhoneNum
        {
            get
            {
                if (fFPhoneNumProperty == null)
                    fFPhoneNumProperty = GetStringProperty("VendorPP.FFPhoneNum");
                return fFPhoneNumProperty.Value;
            }
            set
            {
                if (fFPhoneNumProperty == null)
                    fFPhoneNumProperty = GetStringProperty("VendorPP.FFPhoneNum");
                fFPhoneNumProperty.Value = value;
            }
        }

        protected RowProperty<int> fFCountryNumProperty;
        public int FFCountryNum
        {
            get
            {
                if (fFCountryNumProperty == null)
                    fFCountryNumProperty = GetIntegerProperty("VendorPP.FFCountryNum");
                return fFCountryNumProperty.Value;
            }
            set
            {
                if (fFCountryNumProperty == null)
                    fFCountryNumProperty = GetIntegerProperty("VendorPP.FFCountryNum");
                fFCountryNumProperty.Value = value;
            }
        }

    }

    #endregion

    #endregion

    #endregion
}


//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using SFEpic.Data;

//namespace SFEpic.Data.V8
//{
//    [Serializable()]
//    public partial class V8Schema : SFEpic.Data.DbSchema
//    {
//        protected V8Schema()
//            : base("V8Schema")
//        {
//        }

//        protected static V8Schema instance;
//        public static V8Schema Instance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new V8Schema();
//                }
//                return instance;
//            }
//        }

//        #region Schema Table Names

//        public const string Company = "Company";
//        public const string Part = "Part";
//        public const string PODetail = "PODetail";
//        public const string POHeader = "POHeader";
//        public const string PORel = "PORel";
//        public const string PurAgent = "PurAgent";
//        public const string Vendor = "Vendor";
//        public const string VendorPP = "VendorPP";

//        #endregion

//        protected virtual Schema.Company GetCompanySchemaTable()
//        {
//            return new Schema.Company();
//        }

//        protected virtual Schema.Part GetPartSchemaTable()
//        {
//            return new Schema.Part();
//        }

//        protected virtual Schema.PODetail GetPODetailSchemaTable()
//        {
//            return new Schema.PODetail();
//        }

//        protected virtual Schema.POHeader GetPOHeaderSchemaTable()
//        {
//            return new Schema.POHeader();
//        }

//        protected virtual Schema.PORel GetPORelSchemaTable()
//        {
//            return new Schema.PORel();
//        }

//        protected virtual Schema.PurAgent GetPurAgentSchemaTable()
//        {
//            return new Schema.PurAgent();
//        }

//        protected virtual Schema.Vendor GetVendorSchemaTable()
//        {
//            return new Schema.Vendor();
//        }

//        protected virtual Schema.VendorPP GetVendorPPSchemaTable()
//        {
//            return new Schema.VendorPP();
//        }

//        protected override void InitTablesCore()
//        {
//            tablesList.Add(GetCompanySchemaTable());
//            tablesList.Add(GetPartSchemaTable());
//            tablesList.Add(GetPODetailSchemaTable());
//            tablesList.Add(GetPOHeaderSchemaTable());
//            tablesList.Add(GetPORelSchemaTable());
//            tablesList.Add(GetPurAgentSchemaTable());
//            tablesList.Add(GetVendorSchemaTable());
//            tablesList.Add(GetVendorPPSchemaTable());
//        }
//    }

//    namespace Schema
//    {
//        [Serializable()]
//        public partial class Company : SFEpic.Data.SchemaTable
//        {
//            public Company()
//                : base("Company")
//            {
//            }

//            #region Field Name Constants

//            public const string CompanyNum = "Company.CompanyNum";
//            public const string Name = "Company.Name";
//            public const string Address1 = "Company.Address1";
//            public const string Address2 = "Company.Address2";
//            public const string City = "Company.City";
//            public const string Country = "Company.Country";
//            public const string FaxNum = "Company.FaxNum";
//            public const string PhoneNum = "Company.PhoneNum";
//            public const string State = "Company.State";
//            public const string Zip = "Company.Zip";
//            public const string FEIN = "Company.FEIN";
//            public const string StateTaxID = "Company.StateTaxID";
//            public const string CurrentFiscalYear = "Company.CurrentFiscalYear";
//            public const string Address3 = "Company.Address3";
//            public const string EDICode = "Company.EDICode";
//            public const string TaxRegionCode = "Company.TaxRegionCode";
//            public const string CountryNum = "Company.CountryNum";
//            public const string Number = "Company.Number";
//            public const string FRxDSN = "Company.FRxDSN";
//            public const string EschedFileSet = "Company.EschedFileSet";
//            public const string EMailLinkPort = "Company.EMailLinkPort";
//            public const string MfgSys = "Company.MfgSys";
//            public const string ExternalID = "Company.ExternalID";
//            public const string SerialNum = "Company.SerialNum";
//            public const string EmailFromAddr = "Company.EmailFromAddr";
//            public const string EmailFromLabel = "Company.EmailFromLabel";
//            public const string SMTPServer = "Company.SMTPServer";
//            public const string SMTPPort = "Company.SMTPPort";
//            public const string LogoFile = "Company.LogoFile";
//            public const string EmpPhotoPath = "Company.EmpPhotoPath";
//            public const string CalendarID = "Company.CalendarID";
//            public const string AuxMailAddr = "Company.AuxMailAddr";
//            public const string FrxUserid = "Company.FrxUserid";
//            public const string FRxPassWord = "Company.FRxPassWord";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 100, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address1", 100, schemaColumnName: "Address1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address2", 100, schemaColumnName: "Address2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "City", 100, schemaColumnName: "City", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Country", 100, schemaColumnName: "Country", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FaxNum", 40, schemaColumnName: "FaxNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PhoneNum", 40, schemaColumnName: "PhoneNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "State", 100, schemaColumnName: "State", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Zip", 20, schemaColumnName: "Zip", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FEIN", 24, schemaColumnName: "FEIN", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "StateTaxID", 40, schemaColumnName: "StateTaxID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CurrentFiscalYear", schemaColumnName: "CurrentFiscalYear", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address3", 100, schemaColumnName: "Address3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxRegionCode", 8, schemaColumnName: "TaxRegionCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountryNum", schemaColumnName: "CountryNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "Number", schemaColumnName: "Number", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FRxDSN", 40, schemaColumnName: "FRxDSN", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EschedFileSet", 16, schemaColumnName: "EschedFileSet", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailLinkPort", 80, schemaColumnName: "EMailLinkPort", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MfgSys", 16, schemaColumnName: "MfgSys", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExternalID", 40, schemaColumnName: "ExternalID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SerialNum", 25, 0, schemaColumnName: "SerialNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EmailFromAddr", 100, schemaColumnName: "EmailFromAddr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EmailFromLabel", 100, schemaColumnName: "EmailFromLabel", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SMTPServer", 100, schemaColumnName: "SMTPServer", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SMTPPort", schemaColumnName: "SMTPPort", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LogoFile", 100, schemaColumnName: "LogoFile", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EmpPhotoPath", 160, schemaColumnName: "EmpPhotoPath", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CalendarID", 16, schemaColumnName: "CalendarID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AuxMailAddr", 512, schemaColumnName: "AuxMailAddr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FrxUserid", 40, schemaColumnName: "FrxUserid", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FRxPassWord", 40, schemaColumnName: "FRxPassWord", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["Company.CompanyNum"]);
//            }
//        }
//        [Serializable()]
//        public partial class Part : SFEpic.Data.SchemaTable
//        {
//            public Part()
//                : base("Part")
//            {
//            }

//            #region Field Name Constants

//            public const string PartNum = "Part.PartNum";
//            public const string PartDescription = "Part.PartDescription";
//            public const string ProdCode = "Part.ProdCode";
//            public const string ClassID = "Part.ClassID";
//            public const string IUM = "Part.IUM";
//            public const string PUM = "Part.PUM";
//            public const string TypeCode = "Part.TypeCode";
//            public const string PurchasingFactor = "Part.PurchasingFactor";
//            public const string PricePerCode = "Part.PricePerCode";
//            public const string ExpenseChart = "Part.ExpenseChart";
//            public const string ExpenseDiv = "Part.ExpenseDiv";
//            public const string UnitPrice = "Part.UnitPrice";
//            public const string TrackLots = "Part.TrackLots";
//            public const string ExpenseDept = "Part.ExpenseDept";
//            public const string LowLevelCode = "Part.LowLevelCode";
//            public const string SearchWord = "Part.SearchWord";
//            public const string MfgComment = "Part.MfgComment";
//            public const string Method = "Part.Method";
//            public const string PurComment = "Part.PurComment";
//            public const string CompanyNum = "Part.CompanyNum";
//            public const string CostMethod = "Part.CostMethod";
//            public const string UserChar1 = "Part.UserChar1";
//            public const string UserChar2 = "Part.UserChar2";
//            public const string UserChar3 = "Part.UserChar3";
//            public const string UserChar4 = "Part.UserChar4";
//            public const string UserDate1 = "Part.UserDate1";
//            public const string UserDate2 = "Part.UserDate2";
//            public const string UserDate3 = "Part.UserDate3";
//            public const string UserDate4 = "Part.UserDate4";
//            public const string UserDecimal1 = "Part.UserDecimal1";
//            public const string UserDecimal2 = "Part.UserDecimal2";
//            public const string UserInteger1 = "Part.UserInteger1";
//            public const string UserInteger2 = "Part.UserInteger2";
//            public const string NonStock = "Part.NonStock";
//            public const string TaxCatID = "Part.TaxCatID";
//            public const string UserDecimal3 = "Part.UserDecimal3";
//            public const string UserDecimal4 = "Part.UserDecimal4";
//            public const string InActive = "Part.InActive";
//            public const string TrackDimension = "Part.TrackDimension";
//            public const string DefaultDim = "Part.DefaultDim";
//            public const string TrackSerialNum = "Part.TrackSerialNum";
//            public const string CommodityCode = "Part.CommodityCode";
//            public const string WarrantyCode = "Part.WarrantyCode";
//            public const string InternalUnitPrice = "Part.InternalUnitPrice";
//            public const string InternalPricePerCode = "Part.InternalPricePerCode";
//            public const string PhantomBOM = "Part.PhantomBOM";
//            public const string SalesUM = "Part.SalesUM";
//            public const string SellingFactor = "Part.SellingFactor";
//            public const string MtlBurRate = "Part.MtlBurRate";
//            public const string WholeUnit = "Part.WholeUnit";
//            public const string NetWeight = "Part.NetWeight";
//            public const string UsePartRev = "Part.UsePartRev";
//            public const string PartsPerContainer = "Part.PartsPerContainer";
//            public const string PartLength = "Part.PartLength";
//            public const string PartWidth = "Part.PartWidth";
//            public const string PartHeight = "Part.PartHeight";
//            public const string LotShelfLife = "Part.LotShelfLife";
//            public const string WebPart = "Part.WebPart";
//            public const string RunOut = "Part.RunOut";
//            public const string SubPart = "Part.SubPart";
//            public const string Diameter = "Part.Diameter";
//            public const string Gravity = "Part.Gravity";
//            public const string OnHold = "Part.OnHold";
//            public const string OnHoldDate = "Part.OnHoldDate";
//            public const string OnHoldReasonCode = "Part.OnHoldReasonCode";
//            public const string AnalysisCode = "Part.AnalysisCode";
//            public const string GlobalPart = "Part.GlobalPart";
//            public const string Mtl_AnalysisCode = "Part.Mtl_AnalysisCode";
//            public const string ISSuppUnitsFactor = "Part.ISSuppUnitsFactor";
//            public const string GlobalLock = "Part.GlobalLock";
//            public const string PDMObjID = "Part.PDMObjID";
//            public const string ImageFileName = "Part.ImageFileName";
//            public const string SNRequiredWhenIn = "Part.SNRequiredWhenIn";
//            public const string ISOrigCountry = "Part.ISOrigCountry";
//            public const string SNFormat = "Part.SNFormat";
//            public const string SNPrefix = "Part.SNPrefix";
//            public const string SNBaseDataType = "Part.SNBaseDataType";
//            public const string Constrained = "Part.Constrained";
//            public const string UPCCode1 = "Part.UPCCode1";
//            public const string UPCCode2 = "Part.UPCCode2";
//            public const string UPCCode3 = "Part.UPCCode3";
//            public const string EDICode = "Part.EDICode";
//            public const string ConsolidatedPurchasing = "Part.ConsolidatedPurchasing";
//            public const string WebInStock = "Part.WebInStock";
//            public const string PurchasingFactorDirection = "Part.PurchasingFactorDirection";
//            public const string SellingFactorDirection = "Part.SellingFactorDirection";
//            public const string MDPV = "Part.MDPV";
//            public const string ReturnableContainer = "Part.ReturnableContainer";
//            public const string RecDocReq = "Part.RecDocReq";
//            public const string ShipDocReq = "Part.ShipDocReq";
//            public const string NetVolume = "Part.NetVolume";
//            public const string QtyBearing = "Part.QtyBearing";
//            public const string HazSub = "Part.HazSub";
//            public const string HazGvrnmtID = "Part.HazGvrnmtID";
//            public const string HazPackInstr = "Part.HazPackInstr";
//            public const string NAFTAOrigCountry = "Part.NAFTAOrigCountry";
//            public const string NAFTAProd = "Part.NAFTAProd";
//            public const string NAFTAPref = "Part.NAFTAPref";
//            public const string ExpLicType = "Part.ExpLicType";
//            public const string ExpLicNumber = "Part.ExpLicNumber";
//            public const string ECCNNumber = "Part.ECCNNumber";
//            public const string AESExp = "Part.AESExp";
//            public const string HTS = "Part.HTS";
//            public const string UseHTSDesc = "Part.UseHTSDesc";
//            public const string SchedBcode = "Part.SchedBcode";
//            public const string HazItem = "Part.HazItem";
//            public const string HazTechName = "Part.HazTechName";
//            public const string HazClass = "Part.HazClass";
//            public const string RevChargeMethod = "Part.RevChargeMethod";
//            public const string RCUnderThreshold = "Part.RCUnderThreshold";
//            public const string RCOverThreshold = "Part.RCOverThreshold";
//            public const string OwnershipStatus = "Part.OwnershipStatus";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartDescription", 2000, schemaColumnName: "PartDescription", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ProdCode", 16, schemaColumnName: "ProdCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ClassID", 8, schemaColumnName: "ClassID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "IUM", 4, schemaColumnName: "IUM", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PUM", 4, schemaColumnName: "PUM", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TypeCode", 2, schemaColumnName: "TypeCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PurchasingFactor", 25, 4, schemaColumnName: "PurchasingFactor", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PricePerCode", 2, schemaColumnName: "PricePerCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseChart", 100, schemaColumnName: "ExpenseChart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDiv", 100, schemaColumnName: "ExpenseDiv", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UnitPrice", 25, 5, schemaColumnName: "UnitPrice", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackLots", schemaColumnName: "TrackLots", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDept", 100, schemaColumnName: "ExpenseDept", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LowLevelCode", schemaColumnName: "LowLevelCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SearchWord", 16, schemaColumnName: "SearchWord", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MfgComment", 2000, schemaColumnName: "MfgComment", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Method", schemaColumnName: "Method", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurComment", 2000, schemaColumnName: "PurComment", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CostMethod", 2, schemaColumnName: "CostMethod", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar1", 60, schemaColumnName: "UserChar1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar2", 60, schemaColumnName: "UserChar2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar3", 60, schemaColumnName: "UserChar3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar4", 60, schemaColumnName: "UserChar4", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate1", schemaColumnName: "UserDate1", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate2", schemaColumnName: "UserDate2", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate3", schemaColumnName: "UserDate3", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate4", schemaColumnName: "UserDate4", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal1", 25, 2, schemaColumnName: "UserDecimal1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal2", 25, 2, schemaColumnName: "UserDecimal2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger1", schemaColumnName: "UserInteger1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger2", schemaColumnName: "UserInteger2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStock", schemaColumnName: "NonStock", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxCatID", 20, schemaColumnName: "TaxCatID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal3", 25, 5, schemaColumnName: "UserDecimal3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal4", 25, 5, schemaColumnName: "UserDecimal4", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "InActive", schemaColumnName: "InActive", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackDimension", schemaColumnName: "TrackDimension", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DefaultDim", 12, schemaColumnName: "DefaultDim", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackSerialNum", schemaColumnName: "TrackSerialNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommodityCode", 16, schemaColumnName: "CommodityCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarrantyCode", 16, schemaColumnName: "WarrantyCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "InternalUnitPrice", 25, 5, schemaColumnName: "InternalUnitPrice", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InternalPricePerCode", 2, schemaColumnName: "InternalPricePerCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PhantomBOM", schemaColumnName: "PhantomBOM", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SalesUM", 4, schemaColumnName: "SalesUM", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SellingFactor", 25, 8, schemaColumnName: "SellingFactor", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MtlBurRate", 25, 2, schemaColumnName: "MtlBurRate", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WholeUnit", schemaColumnName: "WholeUnit", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "NetWeight", 25, 5, schemaColumnName: "NetWeight", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UsePartRev", schemaColumnName: "UsePartRev", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PartsPerContainer", schemaColumnName: "PartsPerContainer", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PartLength", 25, 5, schemaColumnName: "PartLength", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PartWidth", 25, 5, schemaColumnName: "PartWidth", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PartHeight", 25, 5, schemaColumnName: "PartHeight", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LotShelfLife", schemaColumnName: "LotShelfLife", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebPart", schemaColumnName: "WebPart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RunOut", schemaColumnName: "RunOut", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SubPart", 100, schemaColumnName: "SubPart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Diameter", 25, 5, schemaColumnName: "Diameter", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Gravity", 25, 5, schemaColumnName: "Gravity", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OnHold", schemaColumnName: "OnHold", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "OnHoldDate", schemaColumnName: "OnHoldDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OnHoldReasonCode", 10, schemaColumnName: "OnHoldReasonCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AnalysisCode", 16, schemaColumnName: "AnalysisCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalPart", schemaColumnName: "GlobalPart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Mtl_AnalysisCode", 16, schemaColumnName: "Mtl-AnalysisCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ISSuppUnitsFactor", 25, 8, schemaColumnName: "ISSuppUnitsFactor", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalLock", schemaColumnName: "GlobalLock", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PDMObjID", 16, schemaColumnName: "PDMObjID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ImageFileName", 512, schemaColumnName: "ImageFileName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNRequiredWhenIn", 48, schemaColumnName: "SNRequiredWhenIn", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ISOrigCountry", 12, schemaColumnName: "ISOrigCountry", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNFormat", 20, schemaColumnName: "SNFormat", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNPrefix", 60, schemaColumnName: "SNPrefix", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNBaseDataType", 20, schemaColumnName: "SNBaseDataType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Constrained", schemaColumnName: "Constrained", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPCCode1", 40, schemaColumnName: "UPCCode1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPCCode2", 40, schemaColumnName: "UPCCode2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPCCode3", 40, schemaColumnName: "UPCCode3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPurchasing", schemaColumnName: "ConsolidatedPurchasing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebInStock", schemaColumnName: "WebInStock", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurchasingFactorDirection", 2, schemaColumnName: "PurchasingFactorDirection", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SellingFactorDirection", 2, schemaColumnName: "SellingFactorDirection", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "MDPV", schemaColumnName: "MDPV", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ReturnableContainer", 60, schemaColumnName: "ReturnableContainer", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RecDocReq", schemaColumnName: "RecDocReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShipDocReq", schemaColumnName: "ShipDocReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "NetVolume", 20, 5, schemaColumnName: "NetVolume", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "QtyBearing", schemaColumnName: "QtyBearing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazSub", 16, schemaColumnName: "HazSub", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazGvrnmtID", 16, schemaColumnName: "HazGvrnmtID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazPackInstr", 2000, schemaColumnName: "HazPackInstr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NAFTAOrigCountry", 12, schemaColumnName: "NAFTAOrigCountry", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NAFTAProd", 16, schemaColumnName: "NAFTAProd", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NAFTAPref", 16, schemaColumnName: "NAFTAPref", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpLicType", 16, schemaColumnName: "ExpLicType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpLicNumber", 50, schemaColumnName: "ExpLicNumber", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ECCNNumber", 50, schemaColumnName: "ECCNNumber", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AESExp", 16, schemaColumnName: "AESExp", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HTS", 20, schemaColumnName: "HTS", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseHTSDesc", schemaColumnName: "UseHTSDesc", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SchedBcode", 16, schemaColumnName: "SchedBcode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "HazItem", schemaColumnName: "HazItem", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazTechName", 80, schemaColumnName: "HazTechName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "HazClass", 16, schemaColumnName: "HazClass", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevChargeMethod", 16, schemaColumnName: "RevChargeMethod", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RCUnderThreshold", 17, 2, schemaColumnName: "RCUnderThreshold", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RCOverThreshold", 17, 2, schemaColumnName: "RCOverThreshold", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OwnershipStatus", 16, schemaColumnName: "OwnershipStatus", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["Part.CompanyNum"]);
//                primaryKeysList.Add(columnsDictionary["Part.PartNum"]);
//            }
//        }
//        [Serializable()]
//        public partial class PODetail : SFEpic.Data.SchemaTable
//        {
//            public PODetail()
//                : base("PODetail")
//            {
//            }

//            #region Field Name Constants

//            public const string CompanyNum = "PODetail.CompanyNum";
//            public const string VoidLine = "PODetail.VoidLine";
//            public const string PONUM = "PODetail.PONUM";
//            public const string Taxable = "PODetail.Taxable";
//            public const string OrderQty = "PODetail.OrderQty";
//            public const string IUM = "PODetail.IUM";
//            public const string OpenLine = "PODetail.OpenLine";
//            public const string POLine = "PODetail.POLine";
//            public const string XOrderQty = "PODetail.XOrderQty";
//            public const string UnitCost = "PODetail.UnitCost";
//            public const string CommentText = "PODetail.CommentText";
//            public const string PUM = "PODetail.PUM";
//            public const string LineDesc = "PODetail.LineDesc";
//            public const string PartNum = "PODetail.PartNum";
//            public const string CostPerCode = "PODetail.CostPerCode";
//            public const string VenPartNum = "PODetail.VenPartNum";
//            public const string ClassID = "PODetail.ClassID";
//            public const string RevisionNum = "PODetail.RevisionNum";
//            public const string RcvInspectionReq = "PODetail.RcvInspectionReq";
//            public const string DocUnitCost = "PODetail.DocUnitCost";
//            public const string VendorNum = "PODetail.VendorNum";
//            public const string AdvancePayBal = "PODetail.AdvancePayBal";
//            public const string DocAdvancePayBal = "PODetail.DocAdvancePayBal";
//            public const string Confirmed = "PODetail.Confirmed";
//            public const string DateChgReq = "PODetail.DateChgReq";
//            public const string QtyChgReq = "PODetail.QtyChgReq";
//            public const string PartNumChgReq = "PODetail.PartNumChgReq";
//            public const string RevisionNumChgReq = "PODetail.RevisionNumChgReq";
//            public const string ConfirmDate = "PODetail.ConfirmDate";
//            public const string ConfirmVia = "PODetail.ConfirmVia";
//            public const string PrcChgReq = "PODetail.PrcChgReq";
//            public const string PurchCode = "PODetail.PurchCode";
//            public const string OrderNum = "PODetail.OrderNum";
//            public const string OrderLine = "PODetail.OrderLine";
//            public const string ExtCompany = "PODetail.ExtCompany";
//            public const string Linked = "PODetail.Linked";
//            public const string GlbCompany = "PODetail.GlbCompany";
//            public const string ContractQty = "PODetail.ContractQty";
//            public const string ContractUnitCost = "PODetail.ContractUnitCost";
//            public const string ContractActive = "PODetail.ContractActive";
//            public const string ContractDocUnitCost = "PODetail.ContractDocUnitCost";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "VoidLine", schemaColumnName: "VoidLine", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PONUM", schemaColumnName: "PONUM", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Taxable", schemaColumnName: "Taxable", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "OrderQty", 25, 2, schemaColumnName: "OrderQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "IUM", 4, schemaColumnName: "IUM", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OpenLine", schemaColumnName: "OpenLine", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "POLine", schemaColumnName: "POLine", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "XOrderQty", 25, 2, schemaColumnName: "XOrderQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UnitCost", 25, 5, schemaColumnName: "UnitCost", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommentText", 2000, schemaColumnName: "CommentText", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PUM", 4, schemaColumnName: "PUM", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LineDesc", 2000, schemaColumnName: "LineDesc", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CostPerCode", 2, schemaColumnName: "CostPerCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VenPartNum", 100, schemaColumnName: "VenPartNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ClassID", 8, schemaColumnName: "ClassID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RcvInspectionReq", schemaColumnName: "RcvInspectionReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DocUnitCost", 25, 5, schemaColumnName: "DocUnitCost", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AdvancePayBal", 25, 2, schemaColumnName: "AdvancePayBal", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DocAdvancePayBal", 25, 2, schemaColumnName: "DocAdvancePayBal", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Confirmed", schemaColumnName: "Confirmed", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DateChgReq", schemaColumnName: "DateChgReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "QtyChgReq", schemaColumnName: "QtyChgReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNumChgReq", 100, schemaColumnName: "PartNumChgReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNumChgReq", 24, schemaColumnName: "RevisionNumChgReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ConfirmDate", schemaColumnName: "ConfirmDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConfirmVia", 16, schemaColumnName: "ConfirmVia", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PrcChgReq", 25, 5, schemaColumnName: "PrcChgReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurchCode", 16, schemaColumnName: "PurchCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderNum", schemaColumnName: "OrderNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderLine", schemaColumnName: "OrderLine", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExtCompany", 16, schemaColumnName: "ExtCompany", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Linked", schemaColumnName: "Linked", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbCompany", 16, schemaColumnName: "GlbCompany", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ContractQty", 17, 2, schemaColumnName: "ContractQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ContractUnitCost", 17, 5, schemaColumnName: "ContractUnitCost", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ContractActive", schemaColumnName: "ContractActive", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ContractDocUnitCost", 17, 5, schemaColumnName: "ContractDocUnitCost", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["PODetail.CompanyNum"]);
//                primaryKeysList.Add(columnsDictionary["PODetail.PONUM"]);
//                primaryKeysList.Add(columnsDictionary["PODetail.POLine"]);
//            }
//        }
//        [Serializable()]
//        public partial class POHeader : SFEpic.Data.SchemaTable
//        {
//            public POHeader()
//                : base("POHeader")
//            {
//            }

//            #region Field Name Constants

//            public const string CompanyNum = "POHeader.CompanyNum";
//            public const string EntryPerson = "POHeader.EntryPerson";
//            public const string FOB = "POHeader.FOB";
//            public const string ShipAddress3 = "POHeader.ShipAddress3";
//            public const string OrderDate = "POHeader.OrderDate";
//            public const string PONum = "POHeader.PONum";
//            public const string ShipCountry = "POHeader.ShipCountry";
//            public const string CommentText = "POHeader.CommentText";
//            public const string PrcConNum = "POHeader.PrcConNum";
//            public const string VendorNum = "POHeader.VendorNum";
//            public const string ShipName = "POHeader.ShipName";
//            public const string PurPoint = "POHeader.PurPoint";
//            public const string ShipState = "POHeader.ShipState";
//            public const string ShipViaCode = "POHeader.ShipViaCode";
//            public const string ShipZIP = "POHeader.ShipZIP";
//            public const string TermsCode = "POHeader.TermsCode";
//            public const string OrderHeld = "POHeader.OrderHeld";
//            public const string OpenOrder = "POHeader.OpenOrder";
//            public const string BuyerID = "POHeader.BuyerID";
//            public const string UserChar1 = "POHeader.UserChar1";
//            public const string FreightPP = "POHeader.FreightPP";
//            public const string UserChar2 = "POHeader.UserChar2";
//            public const string UserChar3 = "POHeader.UserChar3";
//            public const string VoidOrder = "POHeader.VoidOrder";
//            public const string UserChar4 = "POHeader.UserChar4";
//            public const string ShipAddress1 = "POHeader.ShipAddress1";
//            public const string ShipAddress2 = "POHeader.ShipAddress2";
//            public const string ShipCity = "POHeader.ShipCity";
//            public const string UserDate1 = "POHeader.UserDate1";
//            public const string UserDate2 = "POHeader.UserDate2";
//            public const string UserDate3 = "POHeader.UserDate3";
//            public const string UserDate4 = "POHeader.UserDate4";
//            public const string UserDecimal1 = "POHeader.UserDecimal1";
//            public const string UserDecimal2 = "POHeader.UserDecimal2";
//            public const string UserInteger1 = "POHeader.UserInteger1";
//            public const string UserInteger2 = "POHeader.UserInteger2";
//            public const string ShipToConName = "POHeader.ShipToConName";
//            public const string ReadyToPrint = "POHeader.ReadyToPrint";
//            public const string PrintAs = "POHeader.PrintAs";
//            public const string CurrencyCode = "POHeader.CurrencyCode";
//            public const string ExchangeRate = "POHeader.ExchangeRate";
//            public const string LockRate = "POHeader.LockRate";
//            public const string RefCode = "POHeader.RefCode";
//            public const string DocToRef = "POHeader.DocToRef";
//            public const string RefToBase = "POHeader.RefToBase";
//            public const string RefToBaseRate = "POHeader.RefToBaseRate";
//            public const string ShipCountryNum = "POHeader.ShipCountryNum";
//            public const string LogChanges = "POHeader.LogChanges";
//            public const string ApprovedDate = "POHeader.ApprovedDate";
//            public const string ApprovedBy = "POHeader.ApprovedBy";
//            public const string Approve = "POHeader.Approve";
//            public const string ApprovalStatus = "POHeader.ApprovalStatus";
//            public const string ApprovedAmount = "POHeader.ApprovedAmount";
//            public const string PostDate = "POHeader.PostDate";
//            public const string ConfirmReq = "POHeader.ConfirmReq";
//            public const string Confirmed = "POHeader.Confirmed";
//            public const string ConfirmVia = "POHeader.ConfirmVia";
//            public const string PostToWeb = "POHeader.PostToWeb";
//            public const string OrderNum = "POHeader.OrderNum";
//            public const string LegalNumber = "POHeader.LegalNumber";
//            public const string VendorRefNum = "POHeader.VendorRefNum";
//            public const string ExtCompany = "POHeader.ExtCompany";
//            public const string Linked = "POHeader.Linked";
//            public const string XRefPONum = "POHeader.XRefPONum";
//            public const string ConsolidatedPO = "POHeader.ConsolidatedPO";
//            public const string GlbCompany = "POHeader.GlbCompany";
//            public const string ContractStartDate = "POHeader.ContractStartDate";
//            public const string ContractEndDate = "POHeader.ContractEndDate";
//            public const string ContractOrder = "POHeader.ContractOrder";
//            public const string PrintHeaderAddress = "POHeader.PrintHeaderAddress";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EntryPerson", 40, schemaColumnName: "EntryPerson", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FOB", 30, schemaColumnName: "FOB", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipAddress3", 100, schemaColumnName: "ShipAddress3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "OrderDate", schemaColumnName: "OrderDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PONum", schemaColumnName: "PONum", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipCountry", 100, schemaColumnName: "ShipCountry", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommentText", 2000, schemaColumnName: "CommentText", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrcConNum", schemaColumnName: "PrcConNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipName", 100, schemaColumnName: "ShipName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipState", 100, schemaColumnName: "ShipState", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipViaCode", 8, schemaColumnName: "ShipViaCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipZIP", 20, schemaColumnName: "ShipZIP", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TermsCode", 8, schemaColumnName: "TermsCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OrderHeld", schemaColumnName: "OrderHeld", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OpenOrder", schemaColumnName: "OpenOrder", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BuyerID", 16, schemaColumnName: "BuyerID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar1", 60, schemaColumnName: "UserChar1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "FreightPP", schemaColumnName: "FreightPP", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar2", 60, schemaColumnName: "UserChar2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar3", 60, schemaColumnName: "UserChar3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "VoidOrder", schemaColumnName: "VoidOrder", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UserChar4", 60, schemaColumnName: "UserChar4", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipAddress1", 100, schemaColumnName: "ShipAddress1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipAddress2", 100, schemaColumnName: "ShipAddress2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipCity", 100, schemaColumnName: "ShipCity", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate1", schemaColumnName: "UserDate1", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate2", schemaColumnName: "UserDate2", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate3", schemaColumnName: "UserDate3", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "UserDate4", schemaColumnName: "UserDate4", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal1", 25, 2, schemaColumnName: "UserDecimal1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UserDecimal2", 25, 2, schemaColumnName: "UserDecimal2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger1", schemaColumnName: "UserInteger1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "UserInteger2", schemaColumnName: "UserInteger2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ShipToConName", 100, schemaColumnName: "ShipToConName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ReadyToPrint", schemaColumnName: "ReadyToPrint", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PrintAs", 2, schemaColumnName: "PrintAs", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CurrencyCode", 8, schemaColumnName: "CurrencyCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ExchangeRate", 25, 10, schemaColumnName: "ExchangeRate", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LockRate", schemaColumnName: "LockRate", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCode", 8, schemaColumnName: "RefCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DocToRef", schemaColumnName: "DocToRef", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RefToBase", schemaColumnName: "RefToBase", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RefToBaseRate", 25, 6, schemaColumnName: "RefToBaseRate", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ShipCountryNum", schemaColumnName: "ShipCountryNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LogChanges", schemaColumnName: "LogChanges", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ApprovedDate", schemaColumnName: "ApprovedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovedBy", 40, schemaColumnName: "ApprovedBy", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Approve", schemaColumnName: "Approve", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovalStatus", 2, schemaColumnName: "ApprovalStatus", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ApprovedAmount", 25, 2, schemaColumnName: "ApprovedAmount", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "PostDate", schemaColumnName: "PostDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConfirmReq", schemaColumnName: "ConfirmReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Confirmed", schemaColumnName: "Confirmed", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConfirmVia", 16, schemaColumnName: "ConfirmVia", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PostToWeb", schemaColumnName: "PostToWeb", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderNum", schemaColumnName: "OrderNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LegalNumber", 40, schemaColumnName: "LegalNumber", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VendorRefNum", 60, schemaColumnName: "VendorRefNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExtCompany", 16, schemaColumnName: "ExtCompany", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Linked", schemaColumnName: "Linked", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "XRefPONum", 100, schemaColumnName: "XRefPONum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPO", schemaColumnName: "ConsolidatedPO", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbCompany", 16, schemaColumnName: "GlbCompany", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ContractStartDate", schemaColumnName: "ContractStartDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ContractEndDate", schemaColumnName: "ContractEndDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ContractOrder", schemaColumnName: "ContractOrder", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrintHeaderAddress", schemaColumnName: "PrintHeaderAddress", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["POHeader.CompanyNum"]);
//                primaryKeysList.Add(columnsDictionary["POHeader.PONum"]);
//            }
//        }
//        [Serializable()]
//        public partial class PORel : SFEpic.Data.SchemaTable
//        {
//            public PORel()
//                : base("PORel")
//            {
//            }

//            #region Field Name Constants

//            public const string CompanyNum = "PORel.CompanyNum";
//            public const string POLine = "PORel.POLine";
//            public const string PONum = "PORel.PONum";
//            public const string RelQty = "PORel.RelQty";
//            public const string DueDate = "PORel.DueDate";
//            public const string PORelNum = "PORel.PORelNum";
//            public const string OpenRelease = "PORel.OpenRelease";
//            public const string VoidRelease = "PORel.VoidRelease";
//            public const string JobNum = "PORel.JobNum";
//            public const string AssemblySeq = "PORel.AssemblySeq";
//            public const string JobSeqType = "PORel.JobSeqType";
//            public const string JobSeq = "PORel.JobSeq";
//            public const string WarehouseCode = "PORel.WarehouseCode";
//            public const string ReceivedQty = "PORel.ReceivedQty";
//            public const string XRelQty = "PORel.XRelQty";
//            public const string PurchasingFactor = "PORel.PurchasingFactor";
//            public const string ExpDivision = "PORel.ExpDivision";
//            public const string ExpGLDept = "PORel.ExpGLDept";
//            public const string ExpChart = "PORel.ExpChart";
//            public const string ExpOverride = "PORel.ExpOverride";
//            public const string ReqNum = "PORel.ReqNum";
//            public const string ReqLine = "PORel.ReqLine";
//            public const string PlantNum = "PORel.PlantNum";
//            public const string PromiseDt = "PORel.PromiseDt";
//            public const string ProjectID = "PORel.ProjectID";
//            public const string ReqChgDate = "PORel.ReqChgDate";
//            public const string Confirmed = "PORel.Confirmed";
//            public const string ReqChgQty = "PORel.ReqChgQty";
//            public const string LockRel = "PORel.LockRel";
//            public const string RefCode = "PORel.RefCode";
//            public const string RefCodeDesc = "PORel.RefCodeDesc";
//            public const string RefType = "PORel.RefType";
//            public const string OrderNum = "PORel.OrderNum";
//            public const string OrderLine = "PORel.OrderLine";
//            public const string OrderRelNum = "PORel.OrderRelNum";
//            public const string ConfirmVia = "PORel.ConfirmVia";
//            public const string ExtCompany = "PORel.ExtCompany";
//            public const string Linked = "PORel.Linked";
//            public const string RefDisplayAccount = "PORel.RefDisplayAccount";
//            public const string ShippedQty = "PORel.ShippedQty";
//            public const string TranType = "PORel.TranType";
//            public const string RefAcctChart = "PORel.RefAcctChart";
//            public const string RefAcctDiv = "PORel.RefAcctDiv";
//            public const string RefAcctDept = "PORel.RefAcctDept";
//            public const string GlbCompany = "PORel.GlbCompany";
//            public const string GlbPlant = "PORel.GlbPlant";
//            public const string GlbWarehouse = "PORel.GlbWarehouse";
//            public const string GlbCreateJobMtl = "PORel.GlbCreateJobMtl";
//            public const string ShippedDate = "PORel.ShippedDate";
//            public const string ContainerID = "PORel.ContainerID";
//            public const string PurchasingFactorDirection = "PORel.PurchasingFactorDirection";
//            public const string PreviousDueDate = "PORel.PreviousDueDate";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "POLine", schemaColumnName: "POLine", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PONum", schemaColumnName: "PONum", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RelQty", 25, 2, schemaColumnName: "RelQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "DueDate", schemaColumnName: "DueDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PORelNum", schemaColumnName: "PORelNum", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OpenRelease", schemaColumnName: "OpenRelease", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "VoidRelease", schemaColumnName: "VoidRelease", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "JobNum", 28, schemaColumnName: "JobNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "AssemblySeq", schemaColumnName: "AssemblySeq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "JobSeqType", 2, schemaColumnName: "JobSeqType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "JobSeq", schemaColumnName: "JobSeq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarehouseCode", 16, schemaColumnName: "WarehouseCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ReceivedQty", 25, 2, schemaColumnName: "ReceivedQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "XRelQty", 25, 2, schemaColumnName: "XRelQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PurchasingFactor", 25, 4, schemaColumnName: "PurchasingFactor", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpDivision", 100, schemaColumnName: "ExpDivision", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpGLDept", 100, schemaColumnName: "ExpGLDept", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpChart", 100, schemaColumnName: "ExpChart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ExpOverride", schemaColumnName: "ExpOverride", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReqNum", schemaColumnName: "ReqNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReqLine", schemaColumnName: "ReqLine", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "PromiseDt", schemaColumnName: "PromiseDt", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ProjectID", 50, schemaColumnName: "ProjectID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ReqChgDate", schemaColumnName: "ReqChgDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Confirmed", schemaColumnName: "Confirmed", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ReqChgQty", 25, 2, schemaColumnName: "ReqChgQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LockRel", 16, schemaColumnName: "LockRel", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCode", 16, schemaColumnName: "RefCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCodeDesc", 60, schemaColumnName: "RefCodeDesc", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefType", 16, schemaColumnName: "RefType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderNum", schemaColumnName: "OrderNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderLine", schemaColumnName: "OrderLine", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OrderRelNum", schemaColumnName: "OrderRelNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConfirmVia", 16, schemaColumnName: "ConfirmVia", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExtCompany", 16, schemaColumnName: "ExtCompany", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Linked", schemaColumnName: "Linked", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefDisplayAccount", 130, schemaColumnName: "RefDisplayAccount", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ShippedQty", 25, 2, schemaColumnName: "ShippedQty", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TranType", 14, schemaColumnName: "TranType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefAcctChart", 100, schemaColumnName: "RefAcctChart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefAcctDiv", 100, schemaColumnName: "RefAcctDiv", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefAcctDept", 100, schemaColumnName: "RefAcctDept", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbCompany", 16, schemaColumnName: "GlbCompany", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbPlant", 16, schemaColumnName: "GlbPlant", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GlbWarehouse", 16, schemaColumnName: "GlbWarehouse", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlbCreateJobMtl", schemaColumnName: "GlbCreateJobMtl", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ShippedDate", schemaColumnName: "ShippedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ContainerID", schemaColumnName: "ContainerID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurchasingFactorDirection", 2, schemaColumnName: "PurchasingFactorDirection", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "PreviousDueDate", schemaColumnName: "PreviousDueDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                SchemaColumn col = null;
//                col = columnsDictionary["PORel.CompanyNum"];
//                col.IsPrimaryKey = true;
//                primaryKeysList.Add(col);
//                col = columnsDictionary["PORel.PONum"];
//                col.IsPrimaryKey = true;
//                primaryKeysList.Add(col);
//                col = columnsDictionary["PORel.POLine"];
//                col.IsPrimaryKey = true;
//                primaryKeysList.Add(col);
//                col = columnsDictionary["PORel.PORelNum"];
//                col.IsPrimaryKey = true;
//                primaryKeysList.Add(col);
//            }
//        }
//        [Serializable()]
//        public partial class PurAgent : SFEpic.Data.SchemaTable
//        {
//            public PurAgent()
//                : base("PurAgent")
//            {
//            }

//            #region Field Name Constants

//            public const string InActive = "PurAgent.InActive";
//            public const string CompanyNum = "PurAgent.CompanyNum";
//            public const string BuyerID = "PurAgent.BuyerID";
//            public const string Name = "PurAgent.Name";
//            public const string ApprovalPerson = "PurAgent.ApprovalPerson";
//            public const string POLimit = "PurAgent.POLimit";
//            public const string EMailAddress = "PurAgent.EMailAddress";
//            public const string ConsolidatedPurchasing = "PurAgent.ConsolidatedPurchasing";
//            public const string CnvEmpID = "PurAgent.CnvEmpID";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "InActive", schemaColumnName: "InActive", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BuyerID", 16, schemaColumnName: "BuyerID", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 60, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovalPerson", 16, schemaColumnName: "ApprovalPerson", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "POLimit", 25, 2, schemaColumnName: "POLimit", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailAddress", 100, schemaColumnName: "EMailAddress", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPurchasing", schemaColumnName: "ConsolidatedPurchasing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CnvEmpID", 16, schemaColumnName: "CnvEmpID", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["PurAgent.CompanyNum"]);
//                primaryKeysList.Add(columnsDictionary["PurAgent.BuyerID"]);
//            }
//        }
//        [Serializable()]
//        public partial class Vendor : SFEpic.Data.SchemaTable
//        {
//            public Vendor()
//                : base("Vendor")
//            {
//            }

//            #region Field Name Constants

//            public const string CompanyNum = "Vendor.CompanyNum";
//            public const string VendorID = "Vendor.VendorID";
//            public const string Address1 = "Vendor.Address1";
//            public const string Address2 = "Vendor.Address2";
//            public const string City = "Vendor.City";
//            public const string Country = "Vendor.Country";
//            public const string GroupCode = "Vendor.GroupCode";
//            public const string Name = "Vendor.Name";
//            public const string ExpenseDiv = "Vendor.ExpenseDiv";
//            public const string TaxPayerID = "Vendor.TaxPayerID";
//            public const string FaxNum = "Vendor.FaxNum";
//            public const string PurPoint = "Vendor.PurPoint";
//            public const string State = "Vendor.State";
//            public const string TermsCode = "Vendor.TermsCode";
//            public const string ZIP = "Vendor.ZIP";
//            public const string Print1099 = "Vendor.Print1099";
//            public const string ExpenseChart = "Vendor.ExpenseChart";
//            public const string ExpenseDept = "Vendor.ExpenseDept";
//            public const string OneCheck = "Vendor.OneCheck";
//            public const string PrintLabels = "Vendor.PrintLabels";
//            public const string Inactive = "Vendor.Inactive";
//            public const string VendorNum = "Vendor.VendorNum";
//            public const string PhoneNum = "Vendor.PhoneNum";
//            public const string Comment = "Vendor.Comment";
//            public const string Address3 = "Vendor.Address3";
//            public const string PayHold = "Vendor.PayHold";
//            public const string PrimPCon = "Vendor.PrimPCon";
//            public const string AccountRef = "Vendor.AccountRef";
//            public const string APAcctID = "Vendor.APAcctID";
//            public const string DefaultFOB = "Vendor.DefaultFOB";
//            public const string RcvInspectionReq = "Vendor.RcvInspectionReq";
//            public const string CurrencyCode = "Vendor.CurrencyCode";
//            public const string TaxRegionCode = "Vendor.TaxRegionCode";
//            public const string LangNameID = "Vendor.LangNameID";
//            public const string CountryNum = "Vendor.CountryNum";
//            public const string FormatStr = "Vendor.FormatStr";
//            public const string BorderCrossing = "Vendor.BorderCrossing";
//            public const string ElecPayment = "Vendor.ElecPayment";
//            public const string PrimaryBankID = "Vendor.PrimaryBankID";
//            public const string Approved = "Vendor.Approved";
//            public const string ICVend = "Vendor.ICVend";
//            public const string EMailAddress = "Vendor.EMailAddress";
//            public const string WebVendor = "Vendor.WebVendor";
//            public const string VendURL = "Vendor.VendURL";
//            public const string EarlyBuffer = "Vendor.EarlyBuffer";
//            public const string LateBuffer = "Vendor.LateBuffer";
//            public const string OnTimeRating = "Vendor.OnTimeRating";
//            public const string QualityRating = "Vendor.QualityRating";
//            public const string PriceRating = "Vendor.PriceRating";
//            public const string ServiceRating = "Vendor.ServiceRating";
//            public const string ExternalId = "Vendor.ExternalId";
//            public const string VendPILimit = "Vendor.VendPILimit";
//            public const string GlobalVendor = "Vendor.GlobalVendor";
//            public const string ICTrader = "Vendor.ICTrader";
//            public const string TaxAuthorityCode = "Vendor.TaxAuthorityCode";
//            public const string GlobalLock = "Vendor.GlobalLock";
//            public const string Min_Order_Value = "Vendor.Min_Order_Value";
//            public const string CalendarID = "Vendor.CalendarID";
//            public const string EDICode = "Vendor.EDICode";
//            public const string LocalPurchasing = "Vendor.LocalPurchasing";
//            public const string ConsolidatedPurchasing = "Vendor.ConsolidatedPurchasing";
//            public const string SatDelivery = "Vendor.SatDelivery";
//            public const string SatPickup = "Vendor.SatPickup";
//            public const string Hazmat = "Vendor.Hazmat";
//            public const string DocOnly = "Vendor.DocOnly";
//            public const string RefNotes = "Vendor.RefNotes";
//            public const string ApplyChrg = "Vendor.ApplyChrg";
//            public const string ChrgAmount = "Vendor.ChrgAmount";
//            public const string COD = "Vendor.COD";
//            public const string CODFreight = "Vendor.CODFreight";
//            public const string CODCheck = "Vendor.CODCheck";
//            public const string CODAmount = "Vendor.CODAmount";
//            public const string GroundType = "Vendor.GroundType";
//            public const string NotifyFlag = "Vendor.NotifyFlag";
//            public const string NotifyEMail = "Vendor.NotifyEMail";
//            public const string DeclaredIns = "Vendor.DeclaredIns";
//            public const string DeclaredAmt = "Vendor.DeclaredAmt";
//            public const string ResDelivery = "Vendor.ResDelivery";
//            public const string ServSignature = "Vendor.ServSignature";
//            public const string ServAlert = "Vendor.ServAlert";
//            public const string ServHomeDel = "Vendor.ServHomeDel";
//            public const string DeliveryType = "Vendor.DeliveryType";
//            public const string ServDeliveryDate = "Vendor.ServDeliveryDate";
//            public const string ServPhone = "Vendor.ServPhone";
//            public const string ServInstruct = "Vendor.ServInstruct";
//            public const string ServRelease = "Vendor.ServRelease";
//            public const string ServAuthNum = "Vendor.ServAuthNum";
//            public const string ServRef1 = "Vendor.ServRef1";
//            public const string ServRef2 = "Vendor.ServRef2";
//            public const string ServRef3 = "Vendor.ServRef3";
//            public const string ServRef4 = "Vendor.ServRef4";
//            public const string ServRef5 = "Vendor.ServRef5";
//            public const string CPay = "Vendor.CPay";
//            public const string IntrntlShip = "Vendor.IntrntlShip";
//            public const string CertOfOrigin = "Vendor.CertOfOrigin";
//            public const string CommercialInvoice = "Vendor.CommercialInvoice";
//            public const string ShipExprtDeclartn = "Vendor.ShipExprtDeclartn";
//            public const string LetterOfInstr = "Vendor.LetterOfInstr";
//            public const string FFID = "Vendor.FFID";
//            public const string FFCompName = "Vendor.FFCompName";
//            public const string FFContact = "Vendor.FFContact";
//            public const string FFAddress1 = "Vendor.FFAddress1";
//            public const string FFAddress2 = "Vendor.FFAddress2";
//            public const string FFAddress3 = "Vendor.FFAddress3";
//            public const string FFCity = "Vendor.FFCity";
//            public const string FFState = "Vendor.FFState";
//            public const string FFZip = "Vendor.FFZip";
//            public const string FFCountry = "Vendor.FFCountry";
//            public const string NonStdPkg = "Vendor.NonStdPkg";
//            public const string DeliveryConf = "Vendor.DeliveryConf";
//            public const string AddlHdlgFlag = "Vendor.AddlHdlgFlag";
//            public const string IndividualPackIDs = "Vendor.IndividualPackIDs";
//            public const string UPSQVShipFromName = "Vendor.UPSQVShipFromName";
//            public const string UPSQVMemo = "Vendor.UPSQVMemo";
//            public const string UPSQuantumView = "Vendor.UPSQuantumView";
//            public const string FFCountryNum = "Vendor.FFCountryNum";
//            public const string FFPhoneNum = "Vendor.FFPhoneNum";
//            public const string RevChargeMethod = "Vendor.RevChargeMethod";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VendorID", 16, schemaColumnName: "VendorID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address1", 100, schemaColumnName: "Address1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address2", 100, schemaColumnName: "Address2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "City", 100, schemaColumnName: "City", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Country", 100, schemaColumnName: "Country", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroupCode", 8, schemaColumnName: "GroupCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 100, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDiv", 100, schemaColumnName: "ExpenseDiv", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxPayerID", 40, schemaColumnName: "TaxPayerID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FaxNum", 40, schemaColumnName: "FaxNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "State", 100, schemaColumnName: "State", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TermsCode", 8, schemaColumnName: "TermsCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ZIP", 20, schemaColumnName: "ZIP", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Print1099", schemaColumnName: "Print1099", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseChart", 100, schemaColumnName: "ExpenseChart", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExpenseDept", 100, schemaColumnName: "ExpenseDept", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OneCheck", schemaColumnName: "OneCheck", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrintLabels", schemaColumnName: "PrintLabels", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Inactive", schemaColumnName: "Inactive", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PhoneNum", 40, schemaColumnName: "PhoneNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Comment", 2000, schemaColumnName: "Comment", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address3", 100, schemaColumnName: "Address3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PayHold", schemaColumnName: "PayHold", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimPCon", schemaColumnName: "PrimPCon", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AccountRef", 40, schemaColumnName: "AccountRef", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APAcctID", 10, schemaColumnName: "APAcctID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DefaultFOB", 30, schemaColumnName: "DefaultFOB", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RcvInspectionReq", schemaColumnName: "RcvInspectionReq", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CurrencyCode", 8, schemaColumnName: "CurrencyCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxRegionCode", 8, schemaColumnName: "TaxRegionCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LangNameID", 16, schemaColumnName: "LangNameID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountryNum", schemaColumnName: "CountryNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FormatStr", 100, schemaColumnName: "FormatStr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BorderCrossing", 8, schemaColumnName: "BorderCrossing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ElecPayment", schemaColumnName: "ElecPayment", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PrimaryBankID", 18, schemaColumnName: "PrimaryBankID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Approved", schemaColumnName: "Approved", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ICVend", schemaColumnName: "ICVend", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailAddress", 100, schemaColumnName: "EMailAddress", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebVendor", schemaColumnName: "WebVendor", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "VendURL", 2000, schemaColumnName: "VendURL", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "EarlyBuffer", schemaColumnName: "EarlyBuffer", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LateBuffer", schemaColumnName: "LateBuffer", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OnTimeRating", 8, schemaColumnName: "OnTimeRating", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "QualityRating", 8, schemaColumnName: "QualityRating", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PriceRating", 8, schemaColumnName: "PriceRating", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServiceRating", 8, schemaColumnName: "ServiceRating", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExternalId", 80, schemaColumnName: "ExternalId", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendPILimit", schemaColumnName: "VendPILimit", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalVendor", schemaColumnName: "GlobalVendor", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ICTrader", schemaColumnName: "ICTrader", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxAuthorityCode", 16, schemaColumnName: "TaxAuthorityCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalLock", schemaColumnName: "GlobalLock", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Min_Order_Value", 25, 2, schemaColumnName: "Min-Order-Value", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CalendarID", 16, schemaColumnName: "CalendarID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LocalPurchasing", schemaColumnName: "LocalPurchasing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ConsolidatedPurchasing", schemaColumnName: "ConsolidatedPurchasing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatDelivery", schemaColumnName: "SatDelivery", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatPickup", schemaColumnName: "SatPickup", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Hazmat", schemaColumnName: "Hazmat", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DocOnly", schemaColumnName: "DocOnly", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefNotes", 1000, schemaColumnName: "RefNotes", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ApplyChrg", schemaColumnName: "ApplyChrg", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ChrgAmount", 17, 2, schemaColumnName: "ChrgAmount", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "COD", schemaColumnName: "COD", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODFreight", schemaColumnName: "CODFreight", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODCheck", schemaColumnName: "CODCheck", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "CODAmount", 17, 2, schemaColumnName: "CODAmount", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroundType", 16, schemaColumnName: "GroundType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NotifyFlag", schemaColumnName: "NotifyFlag", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NotifyEMail", 1000, schemaColumnName: "NotifyEMail", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DeclaredIns", schemaColumnName: "DeclaredIns", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DeclaredAmt", 17, 2, schemaColumnName: "DeclaredAmt", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ResDelivery", schemaColumnName: "ResDelivery", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServSignature", schemaColumnName: "ServSignature", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServAlert", schemaColumnName: "ServAlert", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServHomeDel", schemaColumnName: "ServHomeDel", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DeliveryType", 16, schemaColumnName: "DeliveryType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ServDeliveryDate", schemaColumnName: "ServDeliveryDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServPhone", 40, schemaColumnName: "ServPhone", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServInstruct", 200, schemaColumnName: "ServInstruct", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServRelease", schemaColumnName: "ServRelease", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServAuthNum", 100, schemaColumnName: "ServAuthNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef1", 100, schemaColumnName: "ServRef1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef2", 100, schemaColumnName: "ServRef2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef3", 100, schemaColumnName: "ServRef3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef4", 100, schemaColumnName: "ServRef4", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef5", 100, schemaColumnName: "ServRef5", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CPay", schemaColumnName: "CPay", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IntrntlShip", schemaColumnName: "IntrntlShip", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CertOfOrigin", schemaColumnName: "CertOfOrigin", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CommercialInvoice", schemaColumnName: "CommercialInvoice", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShipExprtDeclartn", schemaColumnName: "ShipExprtDeclartn", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LetterOfInstr", schemaColumnName: "LetterOfInstr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFID", 16, schemaColumnName: "FFID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCompName", 100, schemaColumnName: "FFCompName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFContact", 100, schemaColumnName: "FFContact", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress1", 100, schemaColumnName: "FFAddress1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress2", 100, schemaColumnName: "FFAddress2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress3", 100, schemaColumnName: "FFAddress3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCity", 100, schemaColumnName: "FFCity", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFState", 100, schemaColumnName: "FFState", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFZip", 20, schemaColumnName: "FFZip", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCountry", 100, schemaColumnName: "FFCountry", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStdPkg", schemaColumnName: "NonStdPkg", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "DeliveryConf", schemaColumnName: "DeliveryConf", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AddlHdlgFlag", schemaColumnName: "AddlHdlgFlag", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IndividualPackIDs", schemaColumnName: "IndividualPackIDs", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVShipFromName", 100, schemaColumnName: "UPSQVShipFromName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVMemo", 2000, schemaColumnName: "UPSQVMemo", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UPSQuantumView", schemaColumnName: "UPSQuantumView", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FFCountryNum", schemaColumnName: "FFCountryNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFPhoneNum", 40, schemaColumnName: "FFPhoneNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevChargeMethod", 16, schemaColumnName: "RevChargeMethod", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["Vendor.CompanyNum"]);
//                primaryKeysList.Add(columnsDictionary["Vendor.VendorNum"]);
//            }
//        }
//        [Serializable()]
//        public partial class VendorPP : SFEpic.Data.SchemaTable
//        {
//            public VendorPP()
//                : base("VendorPP")
//            {
//            }

//            #region Field Name Constants

//            public const string CompanyNum = "VendorPP.CompanyNum";
//            public const string PurPoint = "VendorPP.PurPoint";
//            public const string VendorNum = "VendorPP.VendorNum";
//            public const string Address1 = "VendorPP.Address1";
//            public const string Address2 = "VendorPP.Address2";
//            public const string City = "VendorPP.City";
//            public const string Country = "VendorPP.Country";
//            public const string Name = "VendorPP.Name";
//            public const string State = "VendorPP.State";
//            public const string Zip = "VendorPP.Zip";
//            public const string Address3 = "VendorPP.Address3";
//            public const string PrimPCon = "VendorPP.PrimPCon";
//            public const string LangNameID = "VendorPP.LangNameID";
//            public const string CountryNum = "VendorPP.CountryNum";
//            public const string FormatStr = "VendorPP.FormatStr";
//            public const string BorderCrossing = "VendorPP.BorderCrossing";
//            public const string EMailAddress = "VendorPP.EMailAddress";
//            public const string ExternalId = "VendorPP.ExternalId";
//            public const string TaxAuthorityCode = "VendorPP.TaxAuthorityCode";
//            public const string GlobalLock = "VendorPP.GlobalLock";
//            public const string EDICode = "VendorPP.EDICode";
//            public const string ResDelivery = "VendorPP.ResDelivery";
//            public const string SatDelivery = "VendorPP.SatDelivery";
//            public const string SatPickup = "VendorPP.SatPickup";
//            public const string Hazmat = "VendorPP.Hazmat";
//            public const string DocOnly = "VendorPP.DocOnly";
//            public const string RefNotes = "VendorPP.RefNotes";
//            public const string ApplyChrg = "VendorPP.ApplyChrg";
//            public const string ChrgAmount = "VendorPP.ChrgAmount";
//            public const string COD = "VendorPP.COD";
//            public const string CODFreight = "VendorPP.CODFreight";
//            public const string CODCheck = "VendorPP.CODCheck";
//            public const string CODAmount = "VendorPP.CODAmount";
//            public const string GroundType = "VendorPP.GroundType";
//            public const string NotifyFlag = "VendorPP.NotifyFlag";
//            public const string NotifyEMail = "VendorPP.NotifyEMail";
//            public const string DeclaredIns = "VendorPP.DeclaredIns";
//            public const string DeclaredAmt = "VendorPP.DeclaredAmt";
//            public const string ServSignature = "VendorPP.ServSignature";
//            public const string ServAlert = "VendorPP.ServAlert";
//            public const string ServHomeDel = "VendorPP.ServHomeDel";
//            public const string DeliveryType = "VendorPP.DeliveryType";
//            public const string ServDeliveryDate = "VendorPP.ServDeliveryDate";
//            public const string ServPhone = "VendorPP.ServPhone";
//            public const string ServInstruct = "VendorPP.ServInstruct";
//            public const string ServRelease = "VendorPP.ServRelease";
//            public const string ServAuthNum = "VendorPP.ServAuthNum";
//            public const string ServRef1 = "VendorPP.ServRef1";
//            public const string ServRef2 = "VendorPP.ServRef2";
//            public const string ServRef3 = "VendorPP.ServRef3";
//            public const string ServRef4 = "VendorPP.ServRef4";
//            public const string ServRef5 = "VendorPP.ServRef5";
//            public const string OverrideCarrier = "VendorPP.OverrideCarrier";
//            public const string OverrideService = "VendorPP.OverrideService";
//            public const string IndividualPackIDs = "VendorPP.IndividualPackIDs";
//            public const string IntrntlShip = "VendorPP.IntrntlShip";
//            public const string CertOfOrigin = "VendorPP.CertOfOrigin";
//            public const string CommercialInvoice = "VendorPP.CommercialInvoice";
//            public const string ShipExprtDeclartn = "VendorPP.ShipExprtDeclartn";
//            public const string LetterOfInstr = "VendorPP.LetterOfInstr";
//            public const string FFID = "VendorPP.FFID";
//            public const string FFCompName = "VendorPP.FFCompName";
//            public const string FFContact = "VendorPP.FFContact";
//            public const string FFAddress1 = "VendorPP.FFAddress1";
//            public const string FFAddress2 = "VendorPP.FFAddress2";
//            public const string FFAddress3 = "VendorPP.FFAddress3";
//            public const string FFCity = "VendorPP.FFCity";
//            public const string FFState = "VendorPP.FFState";
//            public const string FFZip = "VendorPP.FFZip";
//            public const string FFCountry = "VendorPP.FFCountry";
//            public const string NonStdPkg = "VendorPP.NonStdPkg";
//            public const string DeliveryConf = "VendorPP.DeliveryConf";
//            public const string AddlHdlgFlag = "VendorPP.AddlHdlgFlag";
//            public const string UPSQuantumView = "VendorPP.UPSQuantumView";
//            public const string UPSQVShipFromName = "VendorPP.UPSQVShipFromName";
//            public const string UPSQVMemo = "VendorPP.UPSQVMemo";
//            public const string FFPhoneNum = "VendorPP.FFPhoneNum";
//            public const string FFCountryNum = "VendorPP.FFCountryNum";

//            #endregion

//            protected override void InitColumnsCore(ref int seq)
//            {
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address1", 100, schemaColumnName: "Address1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address2", 100, schemaColumnName: "Address2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "City", 100, schemaColumnName: "City", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Country", 100, schemaColumnName: "Country", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Name", 100, schemaColumnName: "Name", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "State", 100, schemaColumnName: "State", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Zip", 20, schemaColumnName: "Zip", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Address3", 100, schemaColumnName: "Address3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimPCon", schemaColumnName: "PrimPCon", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LangNameID", 16, schemaColumnName: "LangNameID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountryNum", schemaColumnName: "CountryNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FormatStr", 100, schemaColumnName: "FormatStr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BorderCrossing", 8, schemaColumnName: "BorderCrossing", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EMailAddress", 100, schemaColumnName: "EMailAddress", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ExternalId", 40, schemaColumnName: "ExternalId", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TaxAuthorityCode", 16, schemaColumnName: "TaxAuthorityCode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalLock", schemaColumnName: "GlobalLock", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EDICode", 30, schemaColumnName: "EDICode", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ResDelivery", schemaColumnName: "ResDelivery", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatDelivery", schemaColumnName: "SatDelivery", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SatPickup", schemaColumnName: "SatPickup", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Hazmat", schemaColumnName: "Hazmat", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DocOnly", schemaColumnName: "DocOnly", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefNotes", 1000, schemaColumnName: "RefNotes", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ApplyChrg", schemaColumnName: "ApplyChrg", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ChrgAmount", 17, 2, schemaColumnName: "ChrgAmount", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "COD", schemaColumnName: "COD", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODFreight", schemaColumnName: "CODFreight", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CODCheck", schemaColumnName: "CODCheck", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "CODAmount", 17, 2, schemaColumnName: "CODAmount", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroundType", 16, schemaColumnName: "GroundType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NotifyFlag", schemaColumnName: "NotifyFlag", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NotifyEMail", 1000, schemaColumnName: "NotifyEMail", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DeclaredIns", schemaColumnName: "DeclaredIns", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DeclaredAmt", 17, 2, schemaColumnName: "DeclaredAmt", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServSignature", schemaColumnName: "ServSignature", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServAlert", schemaColumnName: "ServAlert", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServHomeDel", schemaColumnName: "ServHomeDel", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DeliveryType", 16, schemaColumnName: "DeliveryType", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ServDeliveryDate", schemaColumnName: "ServDeliveryDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServPhone", 40, schemaColumnName: "ServPhone", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServInstruct", 200, schemaColumnName: "ServInstruct", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ServRelease", schemaColumnName: "ServRelease", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServAuthNum", 100, schemaColumnName: "ServAuthNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef1", 100, schemaColumnName: "ServRef1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef2", 100, schemaColumnName: "ServRef2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef3", 100, schemaColumnName: "ServRef3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef4", 100, schemaColumnName: "ServRef4", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ServRef5", 100, schemaColumnName: "ServRef5", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OverrideCarrier", schemaColumnName: "OverrideCarrier", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OverrideService", schemaColumnName: "OverrideService", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IndividualPackIDs", schemaColumnName: "IndividualPackIDs", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IntrntlShip", schemaColumnName: "IntrntlShip", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CertOfOrigin", schemaColumnName: "CertOfOrigin", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CommercialInvoice", schemaColumnName: "CommercialInvoice", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShipExprtDeclartn", schemaColumnName: "ShipExprtDeclartn", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LetterOfInstr", schemaColumnName: "LetterOfInstr", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFID", 16, schemaColumnName: "FFID", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCompName", 100, schemaColumnName: "FFCompName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFContact", 100, schemaColumnName: "FFContact", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress1", 100, schemaColumnName: "FFAddress1", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress2", 100, schemaColumnName: "FFAddress2", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFAddress3", 100, schemaColumnName: "FFAddress3", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCity", 100, schemaColumnName: "FFCity", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFState", 100, schemaColumnName: "FFState", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFZip", 20, schemaColumnName: "FFZip", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFCountry", 100, schemaColumnName: "FFCountry", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStdPkg", schemaColumnName: "NonStdPkg", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "DeliveryConf", schemaColumnName: "DeliveryConf", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AddlHdlgFlag", schemaColumnName: "AddlHdlgFlag", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UPSQuantumView", schemaColumnName: "UPSQuantumView", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVShipFromName", 100, schemaColumnName: "UPSQVShipFromName", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UPSQVMemo", 2000, schemaColumnName: "UPSQVMemo", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FFPhoneNum", 40, schemaColumnName: "FFPhoneNum", ordinalSequence: seq++, isRequired: false));
//                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FFCountryNum", schemaColumnName: "FFCountryNum", ordinalSequence: seq++, isRequired: false));
//            }

//            protected override void InitPrimaryKeysCore()
//            {
//                primaryKeysList.Add(columnsDictionary["VendorPP.CompanyNum"]);
//                primaryKeysList.Add(columnsDictionary["VendorPP.VendorNum"]);
//                primaryKeysList.Add(columnsDictionary["VendorPP.PurPoint"]);
//            }
//        }
//    }

//    #region Tables

//    #region Company Table

//    //[Serializable()]
//    //public partial class Company : SFEpic.Data.EditTable<Company>
//    //{
//    //    public Company() : base() { }

//    //    new protected static Schema.Company schemaTable;
//    //    new public static Schema.Company SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.Company)V8Schema.Instance.TablesDictionary["Company"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static Company FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Company.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return Company.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new CompanyRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var companyRowsList = new ObservableCollection<CompanyRow>();
//    //        rowsList = companyRowsList;
//    //        rows = new ReadOnlyObservableCollection<CompanyRow>(companyRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<CompanyRow> rows;
//    //    new public ReadOnlyObservableCollection<CompanyRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public CompanyRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region CompanyRow

//    [Serializable()]
//    public class CompanyRow : DataRow
//    {
//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("Company.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("Company.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nameProperty;
//        public string Name
//        {
//            get
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("Company.Name");
//                return nameProperty.Value;
//            }
//            set
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("Company.Name");
//                nameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> address1Property;
//        public string Address1
//        {
//            get
//            {
//                if (address1Property == null)
//                    address1Property = GetStringProperty("Company.Address1");
//                return address1Property.Value;
//            }
//            set
//            {
//                if (address1Property == null)
//                    address1Property = GetStringProperty("Company.Address1");
//                address1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> address2Property;
//        public string Address2
//        {
//            get
//            {
//                if (address2Property == null)
//                    address2Property = GetStringProperty("Company.Address2");
//                return address2Property.Value;
//            }
//            set
//            {
//                if (address2Property == null)
//                    address2Property = GetStringProperty("Company.Address2");
//                address2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> cityProperty;
//        public string City
//        {
//            get
//            {
//                if (cityProperty == null)
//                    cityProperty = GetStringProperty("Company.City");
//                return cityProperty.Value;
//            }
//            set
//            {
//                if (cityProperty == null)
//                    cityProperty = GetStringProperty("Company.City");
//                cityProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> countryProperty;
//        public string Country
//        {
//            get
//            {
//                if (countryProperty == null)
//                    countryProperty = GetStringProperty("Company.Country");
//                return countryProperty.Value;
//            }
//            set
//            {
//                if (countryProperty == null)
//                    countryProperty = GetStringProperty("Company.Country");
//                countryProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> faxNumProperty;
//        public string FaxNum
//        {
//            get
//            {
//                if (faxNumProperty == null)
//                    faxNumProperty = GetStringProperty("Company.FaxNum");
//                return faxNumProperty.Value;
//            }
//            set
//            {
//                if (faxNumProperty == null)
//                    faxNumProperty = GetStringProperty("Company.FaxNum");
//                faxNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> phoneNumProperty;
//        public string PhoneNum
//        {
//            get
//            {
//                if (phoneNumProperty == null)
//                    phoneNumProperty = GetStringProperty("Company.PhoneNum");
//                return phoneNumProperty.Value;
//            }
//            set
//            {
//                if (phoneNumProperty == null)
//                    phoneNumProperty = GetStringProperty("Company.PhoneNum");
//                phoneNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> stateProperty;
//        public string State
//        {
//            get
//            {
//                if (stateProperty == null)
//                    stateProperty = GetStringProperty("Company.State");
//                return stateProperty.Value;
//            }
//            set
//            {
//                if (stateProperty == null)
//                    stateProperty = GetStringProperty("Company.State");
//                stateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> zipProperty;
//        public string Zip
//        {
//            get
//            {
//                if (zipProperty == null)
//                    zipProperty = GetStringProperty("Company.Zip");
//                return zipProperty.Value;
//            }
//            set
//            {
//                if (zipProperty == null)
//                    zipProperty = GetStringProperty("Company.Zip");
//                zipProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> feinProperty;
//        public string FEIN
//        {
//            get
//            {
//                if (feinProperty == null)
//                    feinProperty = GetStringProperty("Company.FEIN");
//                return feinProperty.Value;
//            }
//            set
//            {
//                if (feinProperty == null)
//                    feinProperty = GetStringProperty("Company.FEIN");
//                feinProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> stateTaxIDProperty;
//        public string StateTaxID
//        {
//            get
//            {
//                if (stateTaxIDProperty == null)
//                    stateTaxIDProperty = GetStringProperty("Company.StateTaxID");
//                return stateTaxIDProperty.Value;
//            }
//            set
//            {
//                if (stateTaxIDProperty == null)
//                    stateTaxIDProperty = GetStringProperty("Company.StateTaxID");
//                stateTaxIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> currentFiscalYearProperty;
//        public int CurrentFiscalYear
//        {
//            get
//            {
//                if (currentFiscalYearProperty == null)
//                    currentFiscalYearProperty = GetIntegerProperty("Company.CurrentFiscalYear");
//                return currentFiscalYearProperty.Value;
//            }
//            set
//            {
//                if (currentFiscalYearProperty == null)
//                    currentFiscalYearProperty = GetIntegerProperty("Company.CurrentFiscalYear");
//                currentFiscalYearProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> address3Property;
//        public string Address3
//        {
//            get
//            {
//                if (address3Property == null)
//                    address3Property = GetStringProperty("Company.Address3");
//                return address3Property.Value;
//            }
//            set
//            {
//                if (address3Property == null)
//                    address3Property = GetStringProperty("Company.Address3");
//                address3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> eDICodeProperty;
//        public string EDICode
//        {
//            get
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("Company.EDICode");
//                return eDICodeProperty.Value;
//            }
//            set
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("Company.EDICode");
//                eDICodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> taxRegionCodeProperty;
//        public string TaxRegionCode
//        {
//            get
//            {
//                if (taxRegionCodeProperty == null)
//                    taxRegionCodeProperty = GetStringProperty("Company.TaxRegionCode");
//                return taxRegionCodeProperty.Value;
//            }
//            set
//            {
//                if (taxRegionCodeProperty == null)
//                    taxRegionCodeProperty = GetStringProperty("Company.TaxRegionCode");
//                taxRegionCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> countryNumProperty;
//        public int CountryNum
//        {
//            get
//            {
//                if (countryNumProperty == null)
//                    countryNumProperty = GetIntegerProperty("Company.CountryNum");
//                return countryNumProperty.Value;
//            }
//            set
//            {
//                if (countryNumProperty == null)
//                    countryNumProperty = GetIntegerProperty("Company.CountryNum");
//                countryNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> numberProperty;
//        public int Number
//        {
//            get
//            {
//                if (numberProperty == null)
//                    numberProperty = GetIntegerProperty("Company.Number");
//                return numberProperty.Value;
//            }
//            set
//            {
//                if (numberProperty == null)
//                    numberProperty = GetIntegerProperty("Company.Number");
//                numberProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fRxDSNProperty;
//        public string FRxDSN
//        {
//            get
//            {
//                if (fRxDSNProperty == null)
//                    fRxDSNProperty = GetStringProperty("Company.FRxDSN");
//                return fRxDSNProperty.Value;
//            }
//            set
//            {
//                if (fRxDSNProperty == null)
//                    fRxDSNProperty = GetStringProperty("Company.FRxDSN");
//                fRxDSNProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eschedFileSetProperty;
//        public string EschedFileSet
//        {
//            get
//            {
//                if (eschedFileSetProperty == null)
//                    eschedFileSetProperty = GetStringProperty("Company.EschedFileSet");
//                return eschedFileSetProperty.Value;
//            }
//            set
//            {
//                if (eschedFileSetProperty == null)
//                    eschedFileSetProperty = GetStringProperty("Company.EschedFileSet");
//                eschedFileSetProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eMailLinkPortProperty;
//        public string EMailLinkPort
//        {
//            get
//            {
//                if (eMailLinkPortProperty == null)
//                    eMailLinkPortProperty = GetStringProperty("Company.EMailLinkPort");
//                return eMailLinkPortProperty.Value;
//            }
//            set
//            {
//                if (eMailLinkPortProperty == null)
//                    eMailLinkPortProperty = GetStringProperty("Company.EMailLinkPort");
//                eMailLinkPortProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> mfgSysProperty;
//        public string MfgSys
//        {
//            get
//            {
//                if (mfgSysProperty == null)
//                    mfgSysProperty = GetStringProperty("Company.MfgSys");
//                return mfgSysProperty.Value;
//            }
//            set
//            {
//                if (mfgSysProperty == null)
//                    mfgSysProperty = GetStringProperty("Company.MfgSys");
//                mfgSysProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> externalIDProperty;
//        public string ExternalID
//        {
//            get
//            {
//                if (externalIDProperty == null)
//                    externalIDProperty = GetStringProperty("Company.ExternalID");
//                return externalIDProperty.Value;
//            }
//            set
//            {
//                if (externalIDProperty == null)
//                    externalIDProperty = GetStringProperty("Company.ExternalID");
//                externalIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> serialNumProperty;
//        public decimal SerialNum
//        {
//            get
//            {
//                if (serialNumProperty == null)
//                    serialNumProperty = GetDecimalProperty("Company.SerialNum");
//                return serialNumProperty.Value;
//            }
//            set
//            {
//                if (serialNumProperty == null)
//                    serialNumProperty = GetDecimalProperty("Company.SerialNum");
//                serialNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> emailFromAddrProperty;
//        public string EmailFromAddr
//        {
//            get
//            {
//                if (emailFromAddrProperty == null)
//                    emailFromAddrProperty = GetStringProperty("Company.EmailFromAddr");
//                return emailFromAddrProperty.Value;
//            }
//            set
//            {
//                if (emailFromAddrProperty == null)
//                    emailFromAddrProperty = GetStringProperty("Company.EmailFromAddr");
//                emailFromAddrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> emailFromLabelProperty;
//        public string EmailFromLabel
//        {
//            get
//            {
//                if (emailFromLabelProperty == null)
//                    emailFromLabelProperty = GetStringProperty("Company.EmailFromLabel");
//                return emailFromLabelProperty.Value;
//            }
//            set
//            {
//                if (emailFromLabelProperty == null)
//                    emailFromLabelProperty = GetStringProperty("Company.EmailFromLabel");
//                emailFromLabelProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> sMTPServerProperty;
//        public string SMTPServer
//        {
//            get
//            {
//                if (sMTPServerProperty == null)
//                    sMTPServerProperty = GetStringProperty("Company.SMTPServer");
//                return sMTPServerProperty.Value;
//            }
//            set
//            {
//                if (sMTPServerProperty == null)
//                    sMTPServerProperty = GetStringProperty("Company.SMTPServer");
//                sMTPServerProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> sMTPPortProperty;
//        public int SMTPPort
//        {
//            get
//            {
//                if (sMTPPortProperty == null)
//                    sMTPPortProperty = GetIntegerProperty("Company.SMTPPort");
//                return sMTPPortProperty.Value;
//            }
//            set
//            {
//                if (sMTPPortProperty == null)
//                    sMTPPortProperty = GetIntegerProperty("Company.SMTPPort");
//                sMTPPortProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> logoFileProperty;
//        public string LogoFile
//        {
//            get
//            {
//                if (logoFileProperty == null)
//                    logoFileProperty = GetStringProperty("Company.LogoFile");
//                return logoFileProperty.Value;
//            }
//            set
//            {
//                if (logoFileProperty == null)
//                    logoFileProperty = GetStringProperty("Company.LogoFile");
//                logoFileProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> empPhotoPathProperty;
//        public string EmpPhotoPath
//        {
//            get
//            {
//                if (empPhotoPathProperty == null)
//                    empPhotoPathProperty = GetStringProperty("Company.EmpPhotoPath");
//                return empPhotoPathProperty.Value;
//            }
//            set
//            {
//                if (empPhotoPathProperty == null)
//                    empPhotoPathProperty = GetStringProperty("Company.EmpPhotoPath");
//                empPhotoPathProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> calendarIDProperty;
//        public string CalendarID
//        {
//            get
//            {
//                if (calendarIDProperty == null)
//                    calendarIDProperty = GetStringProperty("Company.CalendarID");
//                return calendarIDProperty.Value;
//            }
//            set
//            {
//                if (calendarIDProperty == null)
//                    calendarIDProperty = GetStringProperty("Company.CalendarID");
//                calendarIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> auxMailAddrProperty;
//        public string AuxMailAddr
//        {
//            get
//            {
//                if (auxMailAddrProperty == null)
//                    auxMailAddrProperty = GetStringProperty("Company.AuxMailAddr");
//                return auxMailAddrProperty.Value;
//            }
//            set
//            {
//                if (auxMailAddrProperty == null)
//                    auxMailAddrProperty = GetStringProperty("Company.AuxMailAddr");
//                auxMailAddrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> frxUseridProperty;
//        public string FrxUserid
//        {
//            get
//            {
//                if (frxUseridProperty == null)
//                    frxUseridProperty = GetStringProperty("Company.FrxUserid");
//                return frxUseridProperty.Value;
//            }
//            set
//            {
//                if (frxUseridProperty == null)
//                    frxUseridProperty = GetStringProperty("Company.FrxUserid");
//                frxUseridProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fRxPassWordProperty;
//        public string FRxPassWord
//        {
//            get
//            {
//                if (fRxPassWordProperty == null)
//                    fRxPassWordProperty = GetStringProperty("Company.FRxPassWord");
//                return fRxPassWordProperty.Value;
//            }
//            set
//            {
//                if (fRxPassWordProperty == null)
//                    fRxPassWordProperty = GetStringProperty("Company.FRxPassWord");
//                fRxPassWordProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region Part Table

//    //[Serializable()]
//    //public partial class Part : SFEpic.Data.EditTable<Part>
//    //{
//    //    public Part() : base() { }

//    //    new protected static Schema.Part schemaTable;
//    //    new public static Schema.Part SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.Part)V8Schema.Instance.TablesDictionary["Part"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static Part FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return Part.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByPartNumCriteria;
//    //    public static Part FillByPartNum(DataContext context, string companyNum, string partNum, params string[] columnNames)
//    //    {
//    //        if (fillByPartNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.CompanyNum]));
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.PartNum]));
//    //            fillByPartNumCriteria = list.ToArray();
//    //        }
//    //        fillByPartNumCriteria[0].Value = companyNum;
//    //        fillByPartNumCriteria[1].Value = partNum;
//    //        return Part.Fetch(context, fillByPartNumCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new PartRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var partRowsList = new ObservableCollection<PartRow>();
//    //        rowsList = partRowsList;
//    //        rows = new ReadOnlyObservableCollection<PartRow>(partRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<PartRow> rows;
//    //    new public ReadOnlyObservableCollection<PartRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public PartRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region PartRow

//    [Serializable()]
//    public class PartRow : DataRow
//    {
//        protected RowProperty<string> partNumProperty;
//        public string PartNum
//        {
//            get
//            {
//                if (partNumProperty == null)
//                    partNumProperty = GetStringProperty("Part.PartNum");
//                return partNumProperty.Value;
//            }
//            set
//            {
//                if (partNumProperty == null)
//                    partNumProperty = GetStringProperty("Part.PartNum");
//                partNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> partDescriptionProperty;
//        public string PartDescription
//        {
//            get
//            {
//                if (partDescriptionProperty == null)
//                    partDescriptionProperty = GetStringProperty("Part.PartDescription");
//                return partDescriptionProperty.Value;
//            }
//            set
//            {
//                if (partDescriptionProperty == null)
//                    partDescriptionProperty = GetStringProperty("Part.PartDescription");
//                partDescriptionProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> prodCodeProperty;
//        public string ProdCode
//        {
//            get
//            {
//                if (prodCodeProperty == null)
//                    prodCodeProperty = GetStringProperty("Part.ProdCode");
//                return prodCodeProperty.Value;
//            }
//            set
//            {
//                if (prodCodeProperty == null)
//                    prodCodeProperty = GetStringProperty("Part.ProdCode");
//                prodCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> classIDProperty;
//        public string ClassID
//        {
//            get
//            {
//                if (classIDProperty == null)
//                    classIDProperty = GetStringProperty("Part.ClassID");
//                return classIDProperty.Value;
//            }
//            set
//            {
//                if (classIDProperty == null)
//                    classIDProperty = GetStringProperty("Part.ClassID");
//                classIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> iumProperty;
//        public string IUM
//        {
//            get
//            {
//                if (iumProperty == null)
//                    iumProperty = GetStringProperty("Part.IUM");
//                return iumProperty.Value;
//            }
//            set
//            {
//                if (iumProperty == null)
//                    iumProperty = GetStringProperty("Part.IUM");
//                iumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> pumProperty;
//        public string PUM
//        {
//            get
//            {
//                if (pumProperty == null)
//                    pumProperty = GetStringProperty("Part.PUM");
//                return pumProperty.Value;
//            }
//            set
//            {
//                if (pumProperty == null)
//                    pumProperty = GetStringProperty("Part.PUM");
//                pumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> typeCodeProperty;
//        public string TypeCode
//        {
//            get
//            {
//                if (typeCodeProperty == null)
//                    typeCodeProperty = GetStringProperty("Part.TypeCode");
//                return typeCodeProperty.Value;
//            }
//            set
//            {
//                if (typeCodeProperty == null)
//                    typeCodeProperty = GetStringProperty("Part.TypeCode");
//                typeCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> purchasingFactorProperty;
//        public decimal PurchasingFactor
//        {
//            get
//            {
//                if (purchasingFactorProperty == null)
//                    purchasingFactorProperty = GetDecimalProperty("Part.PurchasingFactor");
//                return purchasingFactorProperty.Value;
//            }
//            set
//            {
//                if (purchasingFactorProperty == null)
//                    purchasingFactorProperty = GetDecimalProperty("Part.PurchasingFactor");
//                purchasingFactorProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> pricePerCodeProperty;
//        public string PricePerCode
//        {
//            get
//            {
//                if (pricePerCodeProperty == null)
//                    pricePerCodeProperty = GetStringProperty("Part.PricePerCode");
//                return pricePerCodeProperty.Value;
//            }
//            set
//            {
//                if (pricePerCodeProperty == null)
//                    pricePerCodeProperty = GetStringProperty("Part.PricePerCode");
//                pricePerCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expenseChartProperty;
//        public string ExpenseChart
//        {
//            get
//            {
//                if (expenseChartProperty == null)
//                    expenseChartProperty = GetStringProperty("Part.ExpenseChart");
//                return expenseChartProperty.Value;
//            }
//            set
//            {
//                if (expenseChartProperty == null)
//                    expenseChartProperty = GetStringProperty("Part.ExpenseChart");
//                expenseChartProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expenseDivProperty;
//        public string ExpenseDiv
//        {
//            get
//            {
//                if (expenseDivProperty == null)
//                    expenseDivProperty = GetStringProperty("Part.ExpenseDiv");
//                return expenseDivProperty.Value;
//            }
//            set
//            {
//                if (expenseDivProperty == null)
//                    expenseDivProperty = GetStringProperty("Part.ExpenseDiv");
//                expenseDivProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> unitPriceProperty;
//        public decimal UnitPrice
//        {
//            get
//            {
//                if (unitPriceProperty == null)
//                    unitPriceProperty = GetDecimalProperty("Part.UnitPrice");
//                return unitPriceProperty.Value;
//            }
//            set
//            {
//                if (unitPriceProperty == null)
//                    unitPriceProperty = GetDecimalProperty("Part.UnitPrice");
//                unitPriceProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> trackLotsProperty;
//        public bool TrackLots
//        {
//            get
//            {
//                if (trackLotsProperty == null)
//                    trackLotsProperty = GetBooleanProperty("Part.TrackLots");
//                return trackLotsProperty.Value;
//            }
//            set
//            {
//                if (trackLotsProperty == null)
//                    trackLotsProperty = GetBooleanProperty("Part.TrackLots");
//                trackLotsProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expenseDeptProperty;
//        public string ExpenseDept
//        {
//            get
//            {
//                if (expenseDeptProperty == null)
//                    expenseDeptProperty = GetStringProperty("Part.ExpenseDept");
//                return expenseDeptProperty.Value;
//            }
//            set
//            {
//                if (expenseDeptProperty == null)
//                    expenseDeptProperty = GetStringProperty("Part.ExpenseDept");
//                expenseDeptProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> lowLevelCodeProperty;
//        public int LowLevelCode
//        {
//            get
//            {
//                if (lowLevelCodeProperty == null)
//                    lowLevelCodeProperty = GetIntegerProperty("Part.LowLevelCode");
//                return lowLevelCodeProperty.Value;
//            }
//            set
//            {
//                if (lowLevelCodeProperty == null)
//                    lowLevelCodeProperty = GetIntegerProperty("Part.LowLevelCode");
//                lowLevelCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> searchWordProperty;
//        public string SearchWord
//        {
//            get
//            {
//                if (searchWordProperty == null)
//                    searchWordProperty = GetStringProperty("Part.SearchWord");
//                return searchWordProperty.Value;
//            }
//            set
//            {
//                if (searchWordProperty == null)
//                    searchWordProperty = GetStringProperty("Part.SearchWord");
//                searchWordProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> mfgCommentProperty;
//        public string MfgComment
//        {
//            get
//            {
//                if (mfgCommentProperty == null)
//                    mfgCommentProperty = GetStringProperty("Part.MfgComment");
//                return mfgCommentProperty.Value;
//            }
//            set
//            {
//                if (mfgCommentProperty == null)
//                    mfgCommentProperty = GetStringProperty("Part.MfgComment");
//                mfgCommentProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> methodProperty;
//        public bool Method
//        {
//            get
//            {
//                if (methodProperty == null)
//                    methodProperty = GetBooleanProperty("Part.Method");
//                return methodProperty.Value;
//            }
//            set
//            {
//                if (methodProperty == null)
//                    methodProperty = GetBooleanProperty("Part.Method");
//                methodProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purCommentProperty;
//        public string PurComment
//        {
//            get
//            {
//                if (purCommentProperty == null)
//                    purCommentProperty = GetStringProperty("Part.PurComment");
//                return purCommentProperty.Value;
//            }
//            set
//            {
//                if (purCommentProperty == null)
//                    purCommentProperty = GetStringProperty("Part.PurComment");
//                purCommentProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("Part.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("Part.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> costMethodProperty;
//        public string CostMethod
//        {
//            get
//            {
//                if (costMethodProperty == null)
//                    costMethodProperty = GetStringProperty("Part.CostMethod");
//                return costMethodProperty.Value;
//            }
//            set
//            {
//                if (costMethodProperty == null)
//                    costMethodProperty = GetStringProperty("Part.CostMethod");
//                costMethodProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar1Property;
//        public string UserChar1
//        {
//            get
//            {
//                if (userChar1Property == null)
//                    userChar1Property = GetStringProperty("Part.UserChar1");
//                return userChar1Property.Value;
//            }
//            set
//            {
//                if (userChar1Property == null)
//                    userChar1Property = GetStringProperty("Part.UserChar1");
//                userChar1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar2Property;
//        public string UserChar2
//        {
//            get
//            {
//                if (userChar2Property == null)
//                    userChar2Property = GetStringProperty("Part.UserChar2");
//                return userChar2Property.Value;
//            }
//            set
//            {
//                if (userChar2Property == null)
//                    userChar2Property = GetStringProperty("Part.UserChar2");
//                userChar2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar3Property;
//        public string UserChar3
//        {
//            get
//            {
//                if (userChar3Property == null)
//                    userChar3Property = GetStringProperty("Part.UserChar3");
//                return userChar3Property.Value;
//            }
//            set
//            {
//                if (userChar3Property == null)
//                    userChar3Property = GetStringProperty("Part.UserChar3");
//                userChar3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar4Property;
//        public string UserChar4
//        {
//            get
//            {
//                if (userChar4Property == null)
//                    userChar4Property = GetStringProperty("Part.UserChar4");
//                return userChar4Property.Value;
//            }
//            set
//            {
//                if (userChar4Property == null)
//                    userChar4Property = GetStringProperty("Part.UserChar4");
//                userChar4Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate1Property;
//        public DateTime UserDate1
//        {
//            get
//            {
//                if (userDate1Property == null)
//                    userDate1Property = GetDateTimeProperty("Part.UserDate1");
//                return userDate1Property.Value;
//            }
//            set
//            {
//                if (userDate1Property == null)
//                    userDate1Property = GetDateTimeProperty("Part.UserDate1");
//                userDate1Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate2Property;
//        public DateTime UserDate2
//        {
//            get
//            {
//                if (userDate2Property == null)
//                    userDate2Property = GetDateTimeProperty("Part.UserDate2");
//                return userDate2Property.Value;
//            }
//            set
//            {
//                if (userDate2Property == null)
//                    userDate2Property = GetDateTimeProperty("Part.UserDate2");
//                userDate2Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate3Property;
//        public DateTime UserDate3
//        {
//            get
//            {
//                if (userDate3Property == null)
//                    userDate3Property = GetDateTimeProperty("Part.UserDate3");
//                return userDate3Property.Value;
//            }
//            set
//            {
//                if (userDate3Property == null)
//                    userDate3Property = GetDateTimeProperty("Part.UserDate3");
//                userDate3Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate4Property;
//        public DateTime UserDate4
//        {
//            get
//            {
//                if (userDate4Property == null)
//                    userDate4Property = GetDateTimeProperty("Part.UserDate4");
//                return userDate4Property.Value;
//            }
//            set
//            {
//                if (userDate4Property == null)
//                    userDate4Property = GetDateTimeProperty("Part.UserDate4");
//                userDate4Property.Value = value;
//            }
//        }

//        protected RowProperty<decimal> userDecimal1Property;
//        public decimal UserDecimal1
//        {
//            get
//            {
//                if (userDecimal1Property == null)
//                    userDecimal1Property = GetDecimalProperty("Part.UserDecimal1");
//                return userDecimal1Property.Value;
//            }
//            set
//            {
//                if (userDecimal1Property == null)
//                    userDecimal1Property = GetDecimalProperty("Part.UserDecimal1");
//                userDecimal1Property.Value = value;
//            }
//        }

//        protected RowProperty<decimal> userDecimal2Property;
//        public decimal UserDecimal2
//        {
//            get
//            {
//                if (userDecimal2Property == null)
//                    userDecimal2Property = GetDecimalProperty("Part.UserDecimal2");
//                return userDecimal2Property.Value;
//            }
//            set
//            {
//                if (userDecimal2Property == null)
//                    userDecimal2Property = GetDecimalProperty("Part.UserDecimal2");
//                userDecimal2Property.Value = value;
//            }
//        }

//        protected RowProperty<int> userInteger1Property;
//        public int UserInteger1
//        {
//            get
//            {
//                if (userInteger1Property == null)
//                    userInteger1Property = GetIntegerProperty("Part.UserInteger1");
//                return userInteger1Property.Value;
//            }
//            set
//            {
//                if (userInteger1Property == null)
//                    userInteger1Property = GetIntegerProperty("Part.UserInteger1");
//                userInteger1Property.Value = value;
//            }
//        }

//        protected RowProperty<int> userInteger2Property;
//        public int UserInteger2
//        {
//            get
//            {
//                if (userInteger2Property == null)
//                    userInteger2Property = GetIntegerProperty("Part.UserInteger2");
//                return userInteger2Property.Value;
//            }
//            set
//            {
//                if (userInteger2Property == null)
//                    userInteger2Property = GetIntegerProperty("Part.UserInteger2");
//                userInteger2Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> nonStockProperty;
//        public bool NonStock
//        {
//            get
//            {
//                if (nonStockProperty == null)
//                    nonStockProperty = GetBooleanProperty("Part.NonStock");
//                return nonStockProperty.Value;
//            }
//            set
//            {
//                if (nonStockProperty == null)
//                    nonStockProperty = GetBooleanProperty("Part.NonStock");
//                nonStockProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> taxCatIDProperty;
//        public string TaxCatID
//        {
//            get
//            {
//                if (taxCatIDProperty == null)
//                    taxCatIDProperty = GetStringProperty("Part.TaxCatID");
//                return taxCatIDProperty.Value;
//            }
//            set
//            {
//                if (taxCatIDProperty == null)
//                    taxCatIDProperty = GetStringProperty("Part.TaxCatID");
//                taxCatIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> userDecimal3Property;
//        public decimal UserDecimal3
//        {
//            get
//            {
//                if (userDecimal3Property == null)
//                    userDecimal3Property = GetDecimalProperty("Part.UserDecimal3");
//                return userDecimal3Property.Value;
//            }
//            set
//            {
//                if (userDecimal3Property == null)
//                    userDecimal3Property = GetDecimalProperty("Part.UserDecimal3");
//                userDecimal3Property.Value = value;
//            }
//        }

//        protected RowProperty<decimal> userDecimal4Property;
//        public decimal UserDecimal4
//        {
//            get
//            {
//                if (userDecimal4Property == null)
//                    userDecimal4Property = GetDecimalProperty("Part.UserDecimal4");
//                return userDecimal4Property.Value;
//            }
//            set
//            {
//                if (userDecimal4Property == null)
//                    userDecimal4Property = GetDecimalProperty("Part.UserDecimal4");
//                userDecimal4Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> inActiveProperty;
//        public bool InActive
//        {
//            get
//            {
//                if (inActiveProperty == null)
//                    inActiveProperty = GetBooleanProperty("Part.InActive");
//                return inActiveProperty.Value;
//            }
//            set
//            {
//                if (inActiveProperty == null)
//                    inActiveProperty = GetBooleanProperty("Part.InActive");
//                inActiveProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> trackDimensionProperty;
//        public bool TrackDimension
//        {
//            get
//            {
//                if (trackDimensionProperty == null)
//                    trackDimensionProperty = GetBooleanProperty("Part.TrackDimension");
//                return trackDimensionProperty.Value;
//            }
//            set
//            {
//                if (trackDimensionProperty == null)
//                    trackDimensionProperty = GetBooleanProperty("Part.TrackDimension");
//                trackDimensionProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> defaultDimProperty;
//        public string DefaultDim
//        {
//            get
//            {
//                if (defaultDimProperty == null)
//                    defaultDimProperty = GetStringProperty("Part.DefaultDim");
//                return defaultDimProperty.Value;
//            }
//            set
//            {
//                if (defaultDimProperty == null)
//                    defaultDimProperty = GetStringProperty("Part.DefaultDim");
//                defaultDimProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> trackSerialNumProperty;
//        public bool TrackSerialNum
//        {
//            get
//            {
//                if (trackSerialNumProperty == null)
//                    trackSerialNumProperty = GetBooleanProperty("Part.TrackSerialNum");
//                return trackSerialNumProperty.Value;
//            }
//            set
//            {
//                if (trackSerialNumProperty == null)
//                    trackSerialNumProperty = GetBooleanProperty("Part.TrackSerialNum");
//                trackSerialNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> commodityCodeProperty;
//        public string CommodityCode
//        {
//            get
//            {
//                if (commodityCodeProperty == null)
//                    commodityCodeProperty = GetStringProperty("Part.CommodityCode");
//                return commodityCodeProperty.Value;
//            }
//            set
//            {
//                if (commodityCodeProperty == null)
//                    commodityCodeProperty = GetStringProperty("Part.CommodityCode");
//                commodityCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> warrantyCodeProperty;
//        public string WarrantyCode
//        {
//            get
//            {
//                if (warrantyCodeProperty == null)
//                    warrantyCodeProperty = GetStringProperty("Part.WarrantyCode");
//                return warrantyCodeProperty.Value;
//            }
//            set
//            {
//                if (warrantyCodeProperty == null)
//                    warrantyCodeProperty = GetStringProperty("Part.WarrantyCode");
//                warrantyCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> internalUnitPriceProperty;
//        public decimal InternalUnitPrice
//        {
//            get
//            {
//                if (internalUnitPriceProperty == null)
//                    internalUnitPriceProperty = GetDecimalProperty("Part.InternalUnitPrice");
//                return internalUnitPriceProperty.Value;
//            }
//            set
//            {
//                if (internalUnitPriceProperty == null)
//                    internalUnitPriceProperty = GetDecimalProperty("Part.InternalUnitPrice");
//                internalUnitPriceProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> internalPricePerCodeProperty;
//        public string InternalPricePerCode
//        {
//            get
//            {
//                if (internalPricePerCodeProperty == null)
//                    internalPricePerCodeProperty = GetStringProperty("Part.InternalPricePerCode");
//                return internalPricePerCodeProperty.Value;
//            }
//            set
//            {
//                if (internalPricePerCodeProperty == null)
//                    internalPricePerCodeProperty = GetStringProperty("Part.InternalPricePerCode");
//                internalPricePerCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> phantomBOMProperty;
//        public bool PhantomBOM
//        {
//            get
//            {
//                if (phantomBOMProperty == null)
//                    phantomBOMProperty = GetBooleanProperty("Part.PhantomBOM");
//                return phantomBOMProperty.Value;
//            }
//            set
//            {
//                if (phantomBOMProperty == null)
//                    phantomBOMProperty = GetBooleanProperty("Part.PhantomBOM");
//                phantomBOMProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> salesUMProperty;
//        public string SalesUM
//        {
//            get
//            {
//                if (salesUMProperty == null)
//                    salesUMProperty = GetStringProperty("Part.SalesUM");
//                return salesUMProperty.Value;
//            }
//            set
//            {
//                if (salesUMProperty == null)
//                    salesUMProperty = GetStringProperty("Part.SalesUM");
//                salesUMProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> sellingFactorProperty;
//        public decimal SellingFactor
//        {
//            get
//            {
//                if (sellingFactorProperty == null)
//                    sellingFactorProperty = GetDecimalProperty("Part.SellingFactor");
//                return sellingFactorProperty.Value;
//            }
//            set
//            {
//                if (sellingFactorProperty == null)
//                    sellingFactorProperty = GetDecimalProperty("Part.SellingFactor");
//                sellingFactorProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> mtlBurRateProperty;
//        public decimal MtlBurRate
//        {
//            get
//            {
//                if (mtlBurRateProperty == null)
//                    mtlBurRateProperty = GetDecimalProperty("Part.MtlBurRate");
//                return mtlBurRateProperty.Value;
//            }
//            set
//            {
//                if (mtlBurRateProperty == null)
//                    mtlBurRateProperty = GetDecimalProperty("Part.MtlBurRate");
//                mtlBurRateProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> wholeUnitProperty;
//        public bool WholeUnit
//        {
//            get
//            {
//                if (wholeUnitProperty == null)
//                    wholeUnitProperty = GetBooleanProperty("Part.WholeUnit");
//                return wholeUnitProperty.Value;
//            }
//            set
//            {
//                if (wholeUnitProperty == null)
//                    wholeUnitProperty = GetBooleanProperty("Part.WholeUnit");
//                wholeUnitProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> netWeightProperty;
//        public decimal NetWeight
//        {
//            get
//            {
//                if (netWeightProperty == null)
//                    netWeightProperty = GetDecimalProperty("Part.NetWeight");
//                return netWeightProperty.Value;
//            }
//            set
//            {
//                if (netWeightProperty == null)
//                    netWeightProperty = GetDecimalProperty("Part.NetWeight");
//                netWeightProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> usePartRevProperty;
//        public bool UsePartRev
//        {
//            get
//            {
//                if (usePartRevProperty == null)
//                    usePartRevProperty = GetBooleanProperty("Part.UsePartRev");
//                return usePartRevProperty.Value;
//            }
//            set
//            {
//                if (usePartRevProperty == null)
//                    usePartRevProperty = GetBooleanProperty("Part.UsePartRev");
//                usePartRevProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> partsPerContainerProperty;
//        public int PartsPerContainer
//        {
//            get
//            {
//                if (partsPerContainerProperty == null)
//                    partsPerContainerProperty = GetIntegerProperty("Part.PartsPerContainer");
//                return partsPerContainerProperty.Value;
//            }
//            set
//            {
//                if (partsPerContainerProperty == null)
//                    partsPerContainerProperty = GetIntegerProperty("Part.PartsPerContainer");
//                partsPerContainerProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> partLengthProperty;
//        public decimal PartLength
//        {
//            get
//            {
//                if (partLengthProperty == null)
//                    partLengthProperty = GetDecimalProperty("Part.PartLength");
//                return partLengthProperty.Value;
//            }
//            set
//            {
//                if (partLengthProperty == null)
//                    partLengthProperty = GetDecimalProperty("Part.PartLength");
//                partLengthProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> partWidthProperty;
//        public decimal PartWidth
//        {
//            get
//            {
//                if (partWidthProperty == null)
//                    partWidthProperty = GetDecimalProperty("Part.PartWidth");
//                return partWidthProperty.Value;
//            }
//            set
//            {
//                if (partWidthProperty == null)
//                    partWidthProperty = GetDecimalProperty("Part.PartWidth");
//                partWidthProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> partHeightProperty;
//        public decimal PartHeight
//        {
//            get
//            {
//                if (partHeightProperty == null)
//                    partHeightProperty = GetDecimalProperty("Part.PartHeight");
//                return partHeightProperty.Value;
//            }
//            set
//            {
//                if (partHeightProperty == null)
//                    partHeightProperty = GetDecimalProperty("Part.PartHeight");
//                partHeightProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> lotShelfLifeProperty;
//        public int LotShelfLife
//        {
//            get
//            {
//                if (lotShelfLifeProperty == null)
//                    lotShelfLifeProperty = GetIntegerProperty("Part.LotShelfLife");
//                return lotShelfLifeProperty.Value;
//            }
//            set
//            {
//                if (lotShelfLifeProperty == null)
//                    lotShelfLifeProperty = GetIntegerProperty("Part.LotShelfLife");
//                lotShelfLifeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> webPartProperty;
//        public bool WebPart
//        {
//            get
//            {
//                if (webPartProperty == null)
//                    webPartProperty = GetBooleanProperty("Part.WebPart");
//                return webPartProperty.Value;
//            }
//            set
//            {
//                if (webPartProperty == null)
//                    webPartProperty = GetBooleanProperty("Part.WebPart");
//                webPartProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> runOutProperty;
//        public bool RunOut
//        {
//            get
//            {
//                if (runOutProperty == null)
//                    runOutProperty = GetBooleanProperty("Part.RunOut");
//                return runOutProperty.Value;
//            }
//            set
//            {
//                if (runOutProperty == null)
//                    runOutProperty = GetBooleanProperty("Part.RunOut");
//                runOutProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> subPartProperty;
//        public string SubPart
//        {
//            get
//            {
//                if (subPartProperty == null)
//                    subPartProperty = GetStringProperty("Part.SubPart");
//                return subPartProperty.Value;
//            }
//            set
//            {
//                if (subPartProperty == null)
//                    subPartProperty = GetStringProperty("Part.SubPart");
//                subPartProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> diameterProperty;
//        public decimal Diameter
//        {
//            get
//            {
//                if (diameterProperty == null)
//                    diameterProperty = GetDecimalProperty("Part.Diameter");
//                return diameterProperty.Value;
//            }
//            set
//            {
//                if (diameterProperty == null)
//                    diameterProperty = GetDecimalProperty("Part.Diameter");
//                diameterProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> gravityProperty;
//        public decimal Gravity
//        {
//            get
//            {
//                if (gravityProperty == null)
//                    gravityProperty = GetDecimalProperty("Part.Gravity");
//                return gravityProperty.Value;
//            }
//            set
//            {
//                if (gravityProperty == null)
//                    gravityProperty = GetDecimalProperty("Part.Gravity");
//                gravityProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> onHoldProperty;
//        public bool OnHold
//        {
//            get
//            {
//                if (onHoldProperty == null)
//                    onHoldProperty = GetBooleanProperty("Part.OnHold");
//                return onHoldProperty.Value;
//            }
//            set
//            {
//                if (onHoldProperty == null)
//                    onHoldProperty = GetBooleanProperty("Part.OnHold");
//                onHoldProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> onHoldDateProperty;
//        public DateTime OnHoldDate
//        {
//            get
//            {
//                if (onHoldDateProperty == null)
//                    onHoldDateProperty = GetDateTimeProperty("Part.OnHoldDate");
//                return onHoldDateProperty.Value;
//            }
//            set
//            {
//                if (onHoldDateProperty == null)
//                    onHoldDateProperty = GetDateTimeProperty("Part.OnHoldDate");
//                onHoldDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> onHoldReasonCodeProperty;
//        public string OnHoldReasonCode
//        {
//            get
//            {
//                if (onHoldReasonCodeProperty == null)
//                    onHoldReasonCodeProperty = GetStringProperty("Part.OnHoldReasonCode");
//                return onHoldReasonCodeProperty.Value;
//            }
//            set
//            {
//                if (onHoldReasonCodeProperty == null)
//                    onHoldReasonCodeProperty = GetStringProperty("Part.OnHoldReasonCode");
//                onHoldReasonCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> analysisCodeProperty;
//        public string AnalysisCode
//        {
//            get
//            {
//                if (analysisCodeProperty == null)
//                    analysisCodeProperty = GetStringProperty("Part.AnalysisCode");
//                return analysisCodeProperty.Value;
//            }
//            set
//            {
//                if (analysisCodeProperty == null)
//                    analysisCodeProperty = GetStringProperty("Part.AnalysisCode");
//                analysisCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> globalPartProperty;
//        public bool GlobalPart
//        {
//            get
//            {
//                if (globalPartProperty == null)
//                    globalPartProperty = GetBooleanProperty("Part.GlobalPart");
//                return globalPartProperty.Value;
//            }
//            set
//            {
//                if (globalPartProperty == null)
//                    globalPartProperty = GetBooleanProperty("Part.GlobalPart");
//                globalPartProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> mtlAnalysisCodeProperty;
//        public string Mtl_AnalysisCode
//        {
//            get
//            {
//                if (mtlAnalysisCodeProperty == null)
//                    mtlAnalysisCodeProperty = GetStringProperty("Part.Mtl_AnalysisCode");
//                return mtlAnalysisCodeProperty.Value;
//            }
//            set
//            {
//                if (mtlAnalysisCodeProperty == null)
//                    mtlAnalysisCodeProperty = GetStringProperty("Part.Mtl_AnalysisCode");
//                mtlAnalysisCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> iSSuppUnitsFactorProperty;
//        public decimal ISSuppUnitsFactor
//        {
//            get
//            {
//                if (iSSuppUnitsFactorProperty == null)
//                    iSSuppUnitsFactorProperty = GetDecimalProperty("Part.ISSuppUnitsFactor");
//                return iSSuppUnitsFactorProperty.Value;
//            }
//            set
//            {
//                if (iSSuppUnitsFactorProperty == null)
//                    iSSuppUnitsFactorProperty = GetDecimalProperty("Part.ISSuppUnitsFactor");
//                iSSuppUnitsFactorProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> globalLockProperty;
//        public bool GlobalLock
//        {
//            get
//            {
//                if (globalLockProperty == null)
//                    globalLockProperty = GetBooleanProperty("Part.GlobalLock");
//                return globalLockProperty.Value;
//            }
//            set
//            {
//                if (globalLockProperty == null)
//                    globalLockProperty = GetBooleanProperty("Part.GlobalLock");
//                globalLockProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> pDMObjIDProperty;
//        public string PDMObjID
//        {
//            get
//            {
//                if (pDMObjIDProperty == null)
//                    pDMObjIDProperty = GetStringProperty("Part.PDMObjID");
//                return pDMObjIDProperty.Value;
//            }
//            set
//            {
//                if (pDMObjIDProperty == null)
//                    pDMObjIDProperty = GetStringProperty("Part.PDMObjID");
//                pDMObjIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> imageFileNameProperty;
//        public string ImageFileName
//        {
//            get
//            {
//                if (imageFileNameProperty == null)
//                    imageFileNameProperty = GetStringProperty("Part.ImageFileName");
//                return imageFileNameProperty.Value;
//            }
//            set
//            {
//                if (imageFileNameProperty == null)
//                    imageFileNameProperty = GetStringProperty("Part.ImageFileName");
//                imageFileNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> sNRequiredWhenInProperty;
//        public string SNRequiredWhenIn
//        {
//            get
//            {
//                if (sNRequiredWhenInProperty == null)
//                    sNRequiredWhenInProperty = GetStringProperty("Part.SNRequiredWhenIn");
//                return sNRequiredWhenInProperty.Value;
//            }
//            set
//            {
//                if (sNRequiredWhenInProperty == null)
//                    sNRequiredWhenInProperty = GetStringProperty("Part.SNRequiredWhenIn");
//                sNRequiredWhenInProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> iSOrigCountryProperty;
//        public string ISOrigCountry
//        {
//            get
//            {
//                if (iSOrigCountryProperty == null)
//                    iSOrigCountryProperty = GetStringProperty("Part.ISOrigCountry");
//                return iSOrigCountryProperty.Value;
//            }
//            set
//            {
//                if (iSOrigCountryProperty == null)
//                    iSOrigCountryProperty = GetStringProperty("Part.ISOrigCountry");
//                iSOrigCountryProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> sNFormatProperty;
//        public string SNFormat
//        {
//            get
//            {
//                if (sNFormatProperty == null)
//                    sNFormatProperty = GetStringProperty("Part.SNFormat");
//                return sNFormatProperty.Value;
//            }
//            set
//            {
//                if (sNFormatProperty == null)
//                    sNFormatProperty = GetStringProperty("Part.SNFormat");
//                sNFormatProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> sNPrefixProperty;
//        public string SNPrefix
//        {
//            get
//            {
//                if (sNPrefixProperty == null)
//                    sNPrefixProperty = GetStringProperty("Part.SNPrefix");
//                return sNPrefixProperty.Value;
//            }
//            set
//            {
//                if (sNPrefixProperty == null)
//                    sNPrefixProperty = GetStringProperty("Part.SNPrefix");
//                sNPrefixProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> sNBaseDataTypeProperty;
//        public string SNBaseDataType
//        {
//            get
//            {
//                if (sNBaseDataTypeProperty == null)
//                    sNBaseDataTypeProperty = GetStringProperty("Part.SNBaseDataType");
//                return sNBaseDataTypeProperty.Value;
//            }
//            set
//            {
//                if (sNBaseDataTypeProperty == null)
//                    sNBaseDataTypeProperty = GetStringProperty("Part.SNBaseDataType");
//                sNBaseDataTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> constrainedProperty;
//        public bool Constrained
//        {
//            get
//            {
//                if (constrainedProperty == null)
//                    constrainedProperty = GetBooleanProperty("Part.Constrained");
//                return constrainedProperty.Value;
//            }
//            set
//            {
//                if (constrainedProperty == null)
//                    constrainedProperty = GetBooleanProperty("Part.Constrained");
//                constrainedProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> uPCCode1Property;
//        public string UPCCode1
//        {
//            get
//            {
//                if (uPCCode1Property == null)
//                    uPCCode1Property = GetStringProperty("Part.UPCCode1");
//                return uPCCode1Property.Value;
//            }
//            set
//            {
//                if (uPCCode1Property == null)
//                    uPCCode1Property = GetStringProperty("Part.UPCCode1");
//                uPCCode1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> uPCCode2Property;
//        public string UPCCode2
//        {
//            get
//            {
//                if (uPCCode2Property == null)
//                    uPCCode2Property = GetStringProperty("Part.UPCCode2");
//                return uPCCode2Property.Value;
//            }
//            set
//            {
//                if (uPCCode2Property == null)
//                    uPCCode2Property = GetStringProperty("Part.UPCCode2");
//                uPCCode2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> uPCCode3Property;
//        public string UPCCode3
//        {
//            get
//            {
//                if (uPCCode3Property == null)
//                    uPCCode3Property = GetStringProperty("Part.UPCCode3");
//                return uPCCode3Property.Value;
//            }
//            set
//            {
//                if (uPCCode3Property == null)
//                    uPCCode3Property = GetStringProperty("Part.UPCCode3");
//                uPCCode3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> eDICodeProperty;
//        public string EDICode
//        {
//            get
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("Part.EDICode");
//                return eDICodeProperty.Value;
//            }
//            set
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("Part.EDICode");
//                eDICodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> consolidatedPurchasingProperty;
//        public bool ConsolidatedPurchasing
//        {
//            get
//            {
//                if (consolidatedPurchasingProperty == null)
//                    consolidatedPurchasingProperty = GetBooleanProperty("Part.ConsolidatedPurchasing");
//                return consolidatedPurchasingProperty.Value;
//            }
//            set
//            {
//                if (consolidatedPurchasingProperty == null)
//                    consolidatedPurchasingProperty = GetBooleanProperty("Part.ConsolidatedPurchasing");
//                consolidatedPurchasingProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> webInStockProperty;
//        public bool WebInStock
//        {
//            get
//            {
//                if (webInStockProperty == null)
//                    webInStockProperty = GetBooleanProperty("Part.WebInStock");
//                return webInStockProperty.Value;
//            }
//            set
//            {
//                if (webInStockProperty == null)
//                    webInStockProperty = GetBooleanProperty("Part.WebInStock");
//                webInStockProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purchasingFactorDirectionProperty;
//        public string PurchasingFactorDirection
//        {
//            get
//            {
//                if (purchasingFactorDirectionProperty == null)
//                    purchasingFactorDirectionProperty = GetStringProperty("Part.PurchasingFactorDirection");
//                return purchasingFactorDirectionProperty.Value;
//            }
//            set
//            {
//                if (purchasingFactorDirectionProperty == null)
//                    purchasingFactorDirectionProperty = GetStringProperty("Part.PurchasingFactorDirection");
//                purchasingFactorDirectionProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> sellingFactorDirectionProperty;
//        public string SellingFactorDirection
//        {
//            get
//            {
//                if (sellingFactorDirectionProperty == null)
//                    sellingFactorDirectionProperty = GetStringProperty("Part.SellingFactorDirection");
//                return sellingFactorDirectionProperty.Value;
//            }
//            set
//            {
//                if (sellingFactorDirectionProperty == null)
//                    sellingFactorDirectionProperty = GetStringProperty("Part.SellingFactorDirection");
//                sellingFactorDirectionProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> mdpvProperty;
//        public int MDPV
//        {
//            get
//            {
//                if (mdpvProperty == null)
//                    mdpvProperty = GetIntegerProperty("Part.MDPV");
//                return mdpvProperty.Value;
//            }
//            set
//            {
//                if (mdpvProperty == null)
//                    mdpvProperty = GetIntegerProperty("Part.MDPV");
//                mdpvProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> returnableContainerProperty;
//        public string ReturnableContainer
//        {
//            get
//            {
//                if (returnableContainerProperty == null)
//                    returnableContainerProperty = GetStringProperty("Part.ReturnableContainer");
//                return returnableContainerProperty.Value;
//            }
//            set
//            {
//                if (returnableContainerProperty == null)
//                    returnableContainerProperty = GetStringProperty("Part.ReturnableContainer");
//                returnableContainerProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> recDocReqProperty;
//        public bool RecDocReq
//        {
//            get
//            {
//                if (recDocReqProperty == null)
//                    recDocReqProperty = GetBooleanProperty("Part.RecDocReq");
//                return recDocReqProperty.Value;
//            }
//            set
//            {
//                if (recDocReqProperty == null)
//                    recDocReqProperty = GetBooleanProperty("Part.RecDocReq");
//                recDocReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> shipDocReqProperty;
//        public bool ShipDocReq
//        {
//            get
//            {
//                if (shipDocReqProperty == null)
//                    shipDocReqProperty = GetBooleanProperty("Part.ShipDocReq");
//                return shipDocReqProperty.Value;
//            }
//            set
//            {
//                if (shipDocReqProperty == null)
//                    shipDocReqProperty = GetBooleanProperty("Part.ShipDocReq");
//                shipDocReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> netVolumeProperty;
//        public decimal NetVolume
//        {
//            get
//            {
//                if (netVolumeProperty == null)
//                    netVolumeProperty = GetDecimalProperty("Part.NetVolume");
//                return netVolumeProperty.Value;
//            }
//            set
//            {
//                if (netVolumeProperty == null)
//                    netVolumeProperty = GetDecimalProperty("Part.NetVolume");
//                netVolumeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> qtyBearingProperty;
//        public bool QtyBearing
//        {
//            get
//            {
//                if (qtyBearingProperty == null)
//                    qtyBearingProperty = GetBooleanProperty("Part.QtyBearing");
//                return qtyBearingProperty.Value;
//            }
//            set
//            {
//                if (qtyBearingProperty == null)
//                    qtyBearingProperty = GetBooleanProperty("Part.QtyBearing");
//                qtyBearingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> hazSubProperty;
//        public string HazSub
//        {
//            get
//            {
//                if (hazSubProperty == null)
//                    hazSubProperty = GetStringProperty("Part.HazSub");
//                return hazSubProperty.Value;
//            }
//            set
//            {
//                if (hazSubProperty == null)
//                    hazSubProperty = GetStringProperty("Part.HazSub");
//                hazSubProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> hazGvrnmtIDProperty;
//        public string HazGvrnmtID
//        {
//            get
//            {
//                if (hazGvrnmtIDProperty == null)
//                    hazGvrnmtIDProperty = GetStringProperty("Part.HazGvrnmtID");
//                return hazGvrnmtIDProperty.Value;
//            }
//            set
//            {
//                if (hazGvrnmtIDProperty == null)
//                    hazGvrnmtIDProperty = GetStringProperty("Part.HazGvrnmtID");
//                hazGvrnmtIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> hazPackInstrProperty;
//        public string HazPackInstr
//        {
//            get
//            {
//                if (hazPackInstrProperty == null)
//                    hazPackInstrProperty = GetStringProperty("Part.HazPackInstr");
//                return hazPackInstrProperty.Value;
//            }
//            set
//            {
//                if (hazPackInstrProperty == null)
//                    hazPackInstrProperty = GetStringProperty("Part.HazPackInstr");
//                hazPackInstrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nAFTAOrigCountryProperty;
//        public string NAFTAOrigCountry
//        {
//            get
//            {
//                if (nAFTAOrigCountryProperty == null)
//                    nAFTAOrigCountryProperty = GetStringProperty("Part.NAFTAOrigCountry");
//                return nAFTAOrigCountryProperty.Value;
//            }
//            set
//            {
//                if (nAFTAOrigCountryProperty == null)
//                    nAFTAOrigCountryProperty = GetStringProperty("Part.NAFTAOrigCountry");
//                nAFTAOrigCountryProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nAFTAProdProperty;
//        public string NAFTAProd
//        {
//            get
//            {
//                if (nAFTAProdProperty == null)
//                    nAFTAProdProperty = GetStringProperty("Part.NAFTAProd");
//                return nAFTAProdProperty.Value;
//            }
//            set
//            {
//                if (nAFTAProdProperty == null)
//                    nAFTAProdProperty = GetStringProperty("Part.NAFTAProd");
//                nAFTAProdProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nAFTAPrefProperty;
//        public string NAFTAPref
//        {
//            get
//            {
//                if (nAFTAPrefProperty == null)
//                    nAFTAPrefProperty = GetStringProperty("Part.NAFTAPref");
//                return nAFTAPrefProperty.Value;
//            }
//            set
//            {
//                if (nAFTAPrefProperty == null)
//                    nAFTAPrefProperty = GetStringProperty("Part.NAFTAPref");
//                nAFTAPrefProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expLicTypeProperty;
//        public string ExpLicType
//        {
//            get
//            {
//                if (expLicTypeProperty == null)
//                    expLicTypeProperty = GetStringProperty("Part.ExpLicType");
//                return expLicTypeProperty.Value;
//            }
//            set
//            {
//                if (expLicTypeProperty == null)
//                    expLicTypeProperty = GetStringProperty("Part.ExpLicType");
//                expLicTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expLicNumberProperty;
//        public string ExpLicNumber
//        {
//            get
//            {
//                if (expLicNumberProperty == null)
//                    expLicNumberProperty = GetStringProperty("Part.ExpLicNumber");
//                return expLicNumberProperty.Value;
//            }
//            set
//            {
//                if (expLicNumberProperty == null)
//                    expLicNumberProperty = GetStringProperty("Part.ExpLicNumber");
//                expLicNumberProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eCCNNumberProperty;
//        public string ECCNNumber
//        {
//            get
//            {
//                if (eCCNNumberProperty == null)
//                    eCCNNumberProperty = GetStringProperty("Part.ECCNNumber");
//                return eCCNNumberProperty.Value;
//            }
//            set
//            {
//                if (eCCNNumberProperty == null)
//                    eCCNNumberProperty = GetStringProperty("Part.ECCNNumber");
//                eCCNNumberProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> aESExpProperty;
//        public string AESExp
//        {
//            get
//            {
//                if (aESExpProperty == null)
//                    aESExpProperty = GetStringProperty("Part.AESExp");
//                return aESExpProperty.Value;
//            }
//            set
//            {
//                if (aESExpProperty == null)
//                    aESExpProperty = GetStringProperty("Part.AESExp");
//                aESExpProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> htsProperty;
//        public string HTS
//        {
//            get
//            {
//                if (htsProperty == null)
//                    htsProperty = GetStringProperty("Part.HTS");
//                return htsProperty.Value;
//            }
//            set
//            {
//                if (htsProperty == null)
//                    htsProperty = GetStringProperty("Part.HTS");
//                htsProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> useHTSDescProperty;
//        public bool UseHTSDesc
//        {
//            get
//            {
//                if (useHTSDescProperty == null)
//                    useHTSDescProperty = GetBooleanProperty("Part.UseHTSDesc");
//                return useHTSDescProperty.Value;
//            }
//            set
//            {
//                if (useHTSDescProperty == null)
//                    useHTSDescProperty = GetBooleanProperty("Part.UseHTSDesc");
//                useHTSDescProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> schedBcodeProperty;
//        public string SchedBcode
//        {
//            get
//            {
//                if (schedBcodeProperty == null)
//                    schedBcodeProperty = GetStringProperty("Part.SchedBcode");
//                return schedBcodeProperty.Value;
//            }
//            set
//            {
//                if (schedBcodeProperty == null)
//                    schedBcodeProperty = GetStringProperty("Part.SchedBcode");
//                schedBcodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> hazItemProperty;
//        public bool HazItem
//        {
//            get
//            {
//                if (hazItemProperty == null)
//                    hazItemProperty = GetBooleanProperty("Part.HazItem");
//                return hazItemProperty.Value;
//            }
//            set
//            {
//                if (hazItemProperty == null)
//                    hazItemProperty = GetBooleanProperty("Part.HazItem");
//                hazItemProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> hazTechNameProperty;
//        public string HazTechName
//        {
//            get
//            {
//                if (hazTechNameProperty == null)
//                    hazTechNameProperty = GetStringProperty("Part.HazTechName");
//                return hazTechNameProperty.Value;
//            }
//            set
//            {
//                if (hazTechNameProperty == null)
//                    hazTechNameProperty = GetStringProperty("Part.HazTechName");
//                hazTechNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> hazClassProperty;
//        public string HazClass
//        {
//            get
//            {
//                if (hazClassProperty == null)
//                    hazClassProperty = GetStringProperty("Part.HazClass");
//                return hazClassProperty.Value;
//            }
//            set
//            {
//                if (hazClassProperty == null)
//                    hazClassProperty = GetStringProperty("Part.HazClass");
//                hazClassProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> revChargeMethodProperty;
//        public string RevChargeMethod
//        {
//            get
//            {
//                if (revChargeMethodProperty == null)
//                    revChargeMethodProperty = GetStringProperty("Part.RevChargeMethod");
//                return revChargeMethodProperty.Value;
//            }
//            set
//            {
//                if (revChargeMethodProperty == null)
//                    revChargeMethodProperty = GetStringProperty("Part.RevChargeMethod");
//                revChargeMethodProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> rCUnderThresholdProperty;
//        public decimal RCUnderThreshold
//        {
//            get
//            {
//                if (rCUnderThresholdProperty == null)
//                    rCUnderThresholdProperty = GetDecimalProperty("Part.RCUnderThreshold");
//                return rCUnderThresholdProperty.Value;
//            }
//            set
//            {
//                if (rCUnderThresholdProperty == null)
//                    rCUnderThresholdProperty = GetDecimalProperty("Part.RCUnderThreshold");
//                rCUnderThresholdProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> rCOverThresholdProperty;
//        public decimal RCOverThreshold
//        {
//            get
//            {
//                if (rCOverThresholdProperty == null)
//                    rCOverThresholdProperty = GetDecimalProperty("Part.RCOverThreshold");
//                return rCOverThresholdProperty.Value;
//            }
//            set
//            {
//                if (rCOverThresholdProperty == null)
//                    rCOverThresholdProperty = GetDecimalProperty("Part.RCOverThreshold");
//                rCOverThresholdProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> ownershipStatusProperty;
//        public string OwnershipStatus
//        {
//            get
//            {
//                if (ownershipStatusProperty == null)
//                    ownershipStatusProperty = GetStringProperty("Part.OwnershipStatus");
//                return ownershipStatusProperty.Value;
//            }
//            set
//            {
//                if (ownershipStatusProperty == null)
//                    ownershipStatusProperty = GetStringProperty("Part.OwnershipStatus");
//                ownershipStatusProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region PODetail Table

//    //[Serializable()]
//    //public partial class PODetail : SFEpic.Data.EditTable<PODetail>
//    //{
//    //    public PODetail() : base() { }

//    //    new protected static Schema.PODetail schemaTable;
//    //    new public static Schema.PODetail SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.PODetail)V8Schema.Instance.TablesDictionary["PODetail"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static PODetail FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PODetail.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return PODetail.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByPONUMCriteria;
//    //    public static PODetail FillByPONUM(DataContext context, string companyNum, int ponum, params string[] columnNames)
//    //    {
//    //        if (fillByPONUMCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PODetail.CompanyNum]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PODetail.PONUM]));
//    //            fillByPONUMCriteria = list.ToArray();
//    //        }
//    //        fillByPONUMCriteria[0].Value = companyNum;
//    //        fillByPONUMCriteria[1].Value = ponum;
//    //        return PODetail.Fetch(context, fillByPONUMCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByPOLineCriteria;
//    //    public static PODetail FillByPOLine(DataContext context, string companyNum, int ponum, int pOLine, params string[] columnNames)
//    //    {
//    //        if (fillByPOLineCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PODetail.CompanyNum]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PODetail.PONUM]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PODetail.POLine]));
//    //            fillByPOLineCriteria = list.ToArray();
//    //        }
//    //        fillByPOLineCriteria[0].Value = companyNum;
//    //        fillByPOLineCriteria[1].Value = ponum;
//    //        fillByPOLineCriteria[2].Value = pOLine;
//    //        return PODetail.Fetch(context, fillByPOLineCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new PODetailRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var pODetailRowsList = new ObservableCollection<PODetailRow>();
//    //        rowsList = pODetailRowsList;
//    //        rows = new ReadOnlyObservableCollection<PODetailRow>(pODetailRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<PODetailRow> rows;
//    //    new public ReadOnlyObservableCollection<PODetailRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public PODetailRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region PODetailRow

//    [Serializable()]
//    public class PODetailRow : DataRow
//    {
//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("PODetail.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("PODetail.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> voidLineProperty;
//        public bool VoidLine
//        {
//            get
//            {
//                if (voidLineProperty == null)
//                    voidLineProperty = GetBooleanProperty("PODetail.VoidLine");
//                return voidLineProperty.Value;
//            }
//            set
//            {
//                if (voidLineProperty == null)
//                    voidLineProperty = GetBooleanProperty("PODetail.VoidLine");
//                voidLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> ponumProperty;
//        public int PONUM
//        {
//            get
//            {
//                if (ponumProperty == null)
//                    ponumProperty = GetIntegerProperty("PODetail.PONUM");
//                return ponumProperty.Value;
//            }
//            set
//            {
//                if (ponumProperty == null)
//                    ponumProperty = GetIntegerProperty("PODetail.PONUM");
//                ponumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> taxableProperty;
//        public bool Taxable
//        {
//            get
//            {
//                if (taxableProperty == null)
//                    taxableProperty = GetBooleanProperty("PODetail.Taxable");
//                return taxableProperty.Value;
//            }
//            set
//            {
//                if (taxableProperty == null)
//                    taxableProperty = GetBooleanProperty("PODetail.Taxable");
//                taxableProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> orderQtyProperty;
//        public decimal OrderQty
//        {
//            get
//            {
//                if (orderQtyProperty == null)
//                    orderQtyProperty = GetDecimalProperty("PODetail.OrderQty");
//                return orderQtyProperty.Value;
//            }
//            set
//            {
//                if (orderQtyProperty == null)
//                    orderQtyProperty = GetDecimalProperty("PODetail.OrderQty");
//                orderQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> iumProperty;
//        public string IUM
//        {
//            get
//            {
//                if (iumProperty == null)
//                    iumProperty = GetStringProperty("PODetail.IUM");
//                return iumProperty.Value;
//            }
//            set
//            {
//                if (iumProperty == null)
//                    iumProperty = GetStringProperty("PODetail.IUM");
//                iumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> openLineProperty;
//        public bool OpenLine
//        {
//            get
//            {
//                if (openLineProperty == null)
//                    openLineProperty = GetBooleanProperty("PODetail.OpenLine");
//                return openLineProperty.Value;
//            }
//            set
//            {
//                if (openLineProperty == null)
//                    openLineProperty = GetBooleanProperty("PODetail.OpenLine");
//                openLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> pOLineProperty;
//        public int POLine
//        {
//            get
//            {
//                if (pOLineProperty == null)
//                    pOLineProperty = GetIntegerProperty("PODetail.POLine");
//                return pOLineProperty.Value;
//            }
//            set
//            {
//                if (pOLineProperty == null)
//                    pOLineProperty = GetIntegerProperty("PODetail.POLine");
//                pOLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> xOrderQtyProperty;
//        public decimal XOrderQty
//        {
//            get
//            {
//                if (xOrderQtyProperty == null)
//                    xOrderQtyProperty = GetDecimalProperty("PODetail.XOrderQty");
//                return xOrderQtyProperty.Value;
//            }
//            set
//            {
//                if (xOrderQtyProperty == null)
//                    xOrderQtyProperty = GetDecimalProperty("PODetail.XOrderQty");
//                xOrderQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> unitCostProperty;
//        public decimal UnitCost
//        {
//            get
//            {
//                if (unitCostProperty == null)
//                    unitCostProperty = GetDecimalProperty("PODetail.UnitCost");
//                return unitCostProperty.Value;
//            }
//            set
//            {
//                if (unitCostProperty == null)
//                    unitCostProperty = GetDecimalProperty("PODetail.UnitCost");
//                unitCostProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> commentTextProperty;
//        public string CommentText
//        {
//            get
//            {
//                if (commentTextProperty == null)
//                    commentTextProperty = GetStringProperty("PODetail.CommentText");
//                return commentTextProperty.Value;
//            }
//            set
//            {
//                if (commentTextProperty == null)
//                    commentTextProperty = GetStringProperty("PODetail.CommentText");
//                commentTextProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> pumProperty;
//        public string PUM
//        {
//            get
//            {
//                if (pumProperty == null)
//                    pumProperty = GetStringProperty("PODetail.PUM");
//                return pumProperty.Value;
//            }
//            set
//            {
//                if (pumProperty == null)
//                    pumProperty = GetStringProperty("PODetail.PUM");
//                pumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> lineDescProperty;
//        public string LineDesc
//        {
//            get
//            {
//                if (lineDescProperty == null)
//                    lineDescProperty = GetStringProperty("PODetail.LineDesc");
//                return lineDescProperty.Value;
//            }
//            set
//            {
//                if (lineDescProperty == null)
//                    lineDescProperty = GetStringProperty("PODetail.LineDesc");
//                lineDescProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> partNumProperty;
//        public string PartNum
//        {
//            get
//            {
//                if (partNumProperty == null)
//                    partNumProperty = GetStringProperty("PODetail.PartNum");
//                return partNumProperty.Value;
//            }
//            set
//            {
//                if (partNumProperty == null)
//                    partNumProperty = GetStringProperty("PODetail.PartNum");
//                partNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> costPerCodeProperty;
//        public string CostPerCode
//        {
//            get
//            {
//                if (costPerCodeProperty == null)
//                    costPerCodeProperty = GetStringProperty("PODetail.CostPerCode");
//                return costPerCodeProperty.Value;
//            }
//            set
//            {
//                if (costPerCodeProperty == null)
//                    costPerCodeProperty = GetStringProperty("PODetail.CostPerCode");
//                costPerCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> venPartNumProperty;
//        public string VenPartNum
//        {
//            get
//            {
//                if (venPartNumProperty == null)
//                    venPartNumProperty = GetStringProperty("PODetail.VenPartNum");
//                return venPartNumProperty.Value;
//            }
//            set
//            {
//                if (venPartNumProperty == null)
//                    venPartNumProperty = GetStringProperty("PODetail.VenPartNum");
//                venPartNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> classIDProperty;
//        public string ClassID
//        {
//            get
//            {
//                if (classIDProperty == null)
//                    classIDProperty = GetStringProperty("PODetail.ClassID");
//                return classIDProperty.Value;
//            }
//            set
//            {
//                if (classIDProperty == null)
//                    classIDProperty = GetStringProperty("PODetail.ClassID");
//                classIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> revisionNumProperty;
//        public string RevisionNum
//        {
//            get
//            {
//                if (revisionNumProperty == null)
//                    revisionNumProperty = GetStringProperty("PODetail.RevisionNum");
//                return revisionNumProperty.Value;
//            }
//            set
//            {
//                if (revisionNumProperty == null)
//                    revisionNumProperty = GetStringProperty("PODetail.RevisionNum");
//                revisionNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> rcvInspectionReqProperty;
//        public bool RcvInspectionReq
//        {
//            get
//            {
//                if (rcvInspectionReqProperty == null)
//                    rcvInspectionReqProperty = GetBooleanProperty("PODetail.RcvInspectionReq");
//                return rcvInspectionReqProperty.Value;
//            }
//            set
//            {
//                if (rcvInspectionReqProperty == null)
//                    rcvInspectionReqProperty = GetBooleanProperty("PODetail.RcvInspectionReq");
//                rcvInspectionReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> docUnitCostProperty;
//        public decimal DocUnitCost
//        {
//            get
//            {
//                if (docUnitCostProperty == null)
//                    docUnitCostProperty = GetDecimalProperty("PODetail.DocUnitCost");
//                return docUnitCostProperty.Value;
//            }
//            set
//            {
//                if (docUnitCostProperty == null)
//                    docUnitCostProperty = GetDecimalProperty("PODetail.DocUnitCost");
//                docUnitCostProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> vendorNumProperty;
//        public int VendorNum
//        {
//            get
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("PODetail.VendorNum");
//                return vendorNumProperty.Value;
//            }
//            set
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("PODetail.VendorNum");
//                vendorNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> advancePayBalProperty;
//        public decimal AdvancePayBal
//        {
//            get
//            {
//                if (advancePayBalProperty == null)
//                    advancePayBalProperty = GetDecimalProperty("PODetail.AdvancePayBal");
//                return advancePayBalProperty.Value;
//            }
//            set
//            {
//                if (advancePayBalProperty == null)
//                    advancePayBalProperty = GetDecimalProperty("PODetail.AdvancePayBal");
//                advancePayBalProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> docAdvancePayBalProperty;
//        public decimal DocAdvancePayBal
//        {
//            get
//            {
//                if (docAdvancePayBalProperty == null)
//                    docAdvancePayBalProperty = GetDecimalProperty("PODetail.DocAdvancePayBal");
//                return docAdvancePayBalProperty.Value;
//            }
//            set
//            {
//                if (docAdvancePayBalProperty == null)
//                    docAdvancePayBalProperty = GetDecimalProperty("PODetail.DocAdvancePayBal");
//                docAdvancePayBalProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> confirmedProperty;
//        public bool Confirmed
//        {
//            get
//            {
//                if (confirmedProperty == null)
//                    confirmedProperty = GetBooleanProperty("PODetail.Confirmed");
//                return confirmedProperty.Value;
//            }
//            set
//            {
//                if (confirmedProperty == null)
//                    confirmedProperty = GetBooleanProperty("PODetail.Confirmed");
//                confirmedProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> dateChgReqProperty;
//        public bool DateChgReq
//        {
//            get
//            {
//                if (dateChgReqProperty == null)
//                    dateChgReqProperty = GetBooleanProperty("PODetail.DateChgReq");
//                return dateChgReqProperty.Value;
//            }
//            set
//            {
//                if (dateChgReqProperty == null)
//                    dateChgReqProperty = GetBooleanProperty("PODetail.DateChgReq");
//                dateChgReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> qtyChgReqProperty;
//        public bool QtyChgReq
//        {
//            get
//            {
//                if (qtyChgReqProperty == null)
//                    qtyChgReqProperty = GetBooleanProperty("PODetail.QtyChgReq");
//                return qtyChgReqProperty.Value;
//            }
//            set
//            {
//                if (qtyChgReqProperty == null)
//                    qtyChgReqProperty = GetBooleanProperty("PODetail.QtyChgReq");
//                qtyChgReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> partNumChgReqProperty;
//        public string PartNumChgReq
//        {
//            get
//            {
//                if (partNumChgReqProperty == null)
//                    partNumChgReqProperty = GetStringProperty("PODetail.PartNumChgReq");
//                return partNumChgReqProperty.Value;
//            }
//            set
//            {
//                if (partNumChgReqProperty == null)
//                    partNumChgReqProperty = GetStringProperty("PODetail.PartNumChgReq");
//                partNumChgReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> revisionNumChgReqProperty;
//        public string RevisionNumChgReq
//        {
//            get
//            {
//                if (revisionNumChgReqProperty == null)
//                    revisionNumChgReqProperty = GetStringProperty("PODetail.RevisionNumChgReq");
//                return revisionNumChgReqProperty.Value;
//            }
//            set
//            {
//                if (revisionNumChgReqProperty == null)
//                    revisionNumChgReqProperty = GetStringProperty("PODetail.RevisionNumChgReq");
//                revisionNumChgReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> confirmDateProperty;
//        public DateTime ConfirmDate
//        {
//            get
//            {
//                if (confirmDateProperty == null)
//                    confirmDateProperty = GetDateTimeProperty("PODetail.ConfirmDate");
//                return confirmDateProperty.Value;
//            }
//            set
//            {
//                if (confirmDateProperty == null)
//                    confirmDateProperty = GetDateTimeProperty("PODetail.ConfirmDate");
//                confirmDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> confirmViaProperty;
//        public string ConfirmVia
//        {
//            get
//            {
//                if (confirmViaProperty == null)
//                    confirmViaProperty = GetStringProperty("PODetail.ConfirmVia");
//                return confirmViaProperty.Value;
//            }
//            set
//            {
//                if (confirmViaProperty == null)
//                    confirmViaProperty = GetStringProperty("PODetail.ConfirmVia");
//                confirmViaProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> prcChgReqProperty;
//        public decimal PrcChgReq
//        {
//            get
//            {
//                if (prcChgReqProperty == null)
//                    prcChgReqProperty = GetDecimalProperty("PODetail.PrcChgReq");
//                return prcChgReqProperty.Value;
//            }
//            set
//            {
//                if (prcChgReqProperty == null)
//                    prcChgReqProperty = GetDecimalProperty("PODetail.PrcChgReq");
//                prcChgReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purchCodeProperty;
//        public string PurchCode
//        {
//            get
//            {
//                if (purchCodeProperty == null)
//                    purchCodeProperty = GetStringProperty("PODetail.PurchCode");
//                return purchCodeProperty.Value;
//            }
//            set
//            {
//                if (purchCodeProperty == null)
//                    purchCodeProperty = GetStringProperty("PODetail.PurchCode");
//                purchCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> orderNumProperty;
//        public int OrderNum
//        {
//            get
//            {
//                if (orderNumProperty == null)
//                    orderNumProperty = GetIntegerProperty("PODetail.OrderNum");
//                return orderNumProperty.Value;
//            }
//            set
//            {
//                if (orderNumProperty == null)
//                    orderNumProperty = GetIntegerProperty("PODetail.OrderNum");
//                orderNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> orderLineProperty;
//        public int OrderLine
//        {
//            get
//            {
//                if (orderLineProperty == null)
//                    orderLineProperty = GetIntegerProperty("PODetail.OrderLine");
//                return orderLineProperty.Value;
//            }
//            set
//            {
//                if (orderLineProperty == null)
//                    orderLineProperty = GetIntegerProperty("PODetail.OrderLine");
//                orderLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> extCompanyProperty;
//        public string ExtCompany
//        {
//            get
//            {
//                if (extCompanyProperty == null)
//                    extCompanyProperty = GetStringProperty("PODetail.ExtCompany");
//                return extCompanyProperty.Value;
//            }
//            set
//            {
//                if (extCompanyProperty == null)
//                    extCompanyProperty = GetStringProperty("PODetail.ExtCompany");
//                extCompanyProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> linkedProperty;
//        public bool Linked
//        {
//            get
//            {
//                if (linkedProperty == null)
//                    linkedProperty = GetBooleanProperty("PODetail.Linked");
//                return linkedProperty.Value;
//            }
//            set
//            {
//                if (linkedProperty == null)
//                    linkedProperty = GetBooleanProperty("PODetail.Linked");
//                linkedProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> glbCompanyProperty;
//        public string GlbCompany
//        {
//            get
//            {
//                if (glbCompanyProperty == null)
//                    glbCompanyProperty = GetStringProperty("PODetail.GlbCompany");
//                return glbCompanyProperty.Value;
//            }
//            set
//            {
//                if (glbCompanyProperty == null)
//                    glbCompanyProperty = GetStringProperty("PODetail.GlbCompany");
//                glbCompanyProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> contractQtyProperty;
//        public decimal ContractQty
//        {
//            get
//            {
//                if (contractQtyProperty == null)
//                    contractQtyProperty = GetDecimalProperty("PODetail.ContractQty");
//                return contractQtyProperty.Value;
//            }
//            set
//            {
//                if (contractQtyProperty == null)
//                    contractQtyProperty = GetDecimalProperty("PODetail.ContractQty");
//                contractQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> contractUnitCostProperty;
//        public decimal ContractUnitCost
//        {
//            get
//            {
//                if (contractUnitCostProperty == null)
//                    contractUnitCostProperty = GetDecimalProperty("PODetail.ContractUnitCost");
//                return contractUnitCostProperty.Value;
//            }
//            set
//            {
//                if (contractUnitCostProperty == null)
//                    contractUnitCostProperty = GetDecimalProperty("PODetail.ContractUnitCost");
//                contractUnitCostProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> contractActiveProperty;
//        public bool ContractActive
//        {
//            get
//            {
//                if (contractActiveProperty == null)
//                    contractActiveProperty = GetBooleanProperty("PODetail.ContractActive");
//                return contractActiveProperty.Value;
//            }
//            set
//            {
//                if (contractActiveProperty == null)
//                    contractActiveProperty = GetBooleanProperty("PODetail.ContractActive");
//                contractActiveProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> contractDocUnitCostProperty;
//        public decimal ContractDocUnitCost
//        {
//            get
//            {
//                if (contractDocUnitCostProperty == null)
//                    contractDocUnitCostProperty = GetDecimalProperty("PODetail.ContractDocUnitCost");
//                return contractDocUnitCostProperty.Value;
//            }
//            set
//            {
//                if (contractDocUnitCostProperty == null)
//                    contractDocUnitCostProperty = GetDecimalProperty("PODetail.ContractDocUnitCost");
//                contractDocUnitCostProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region POHeader Table

//    //[Serializable()]
//    //public partial class POHeader : SFEpic.Data.EditTable<POHeader>
//    //{
//    //    public POHeader() : base() { }

//    //    new protected static Schema.POHeader schemaTable;
//    //    new public static Schema.POHeader SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.POHeader)V8Schema.Instance.TablesDictionary["POHeader"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static POHeader FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.POHeader.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return POHeader.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByPONumCriteria;
//    //    public static POHeader FillByPONum(DataContext context, string companyNum, int pONum, params string[] columnNames)
//    //    {
//    //        if (fillByPONumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.POHeader.CompanyNum]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.POHeader.PONum]));
//    //            fillByPONumCriteria = list.ToArray();
//    //        }
//    //        fillByPONumCriteria[0].Value = companyNum;
//    //        fillByPONumCriteria[1].Value = pONum;
//    //        return POHeader.Fetch(context, fillByPONumCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new POHeaderRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var pOHeaderRowsList = new ObservableCollection<POHeaderRow>();
//    //        rowsList = pOHeaderRowsList;
//    //        rows = new ReadOnlyObservableCollection<POHeaderRow>(pOHeaderRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<POHeaderRow> rows;
//    //    new public ReadOnlyObservableCollection<POHeaderRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public POHeaderRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region POHeaderRow

//    [Serializable()]
//    public class POHeaderRow : DataRow
//    {
//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("POHeader.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("POHeader.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> entryPersonProperty;
//        public string EntryPerson
//        {
//            get
//            {
//                if (entryPersonProperty == null)
//                    entryPersonProperty = GetStringProperty("POHeader.EntryPerson");
//                return entryPersonProperty.Value;
//            }
//            set
//            {
//                if (entryPersonProperty == null)
//                    entryPersonProperty = GetStringProperty("POHeader.EntryPerson");
//                entryPersonProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fobProperty;
//        public string FOB
//        {
//            get
//            {
//                if (fobProperty == null)
//                    fobProperty = GetStringProperty("POHeader.FOB");
//                return fobProperty.Value;
//            }
//            set
//            {
//                if (fobProperty == null)
//                    fobProperty = GetStringProperty("POHeader.FOB");
//                fobProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> shipAddress3Property;
//        public string ShipAddress3
//        {
//            get
//            {
//                if (shipAddress3Property == null)
//                    shipAddress3Property = GetStringProperty("POHeader.ShipAddress3");
//                return shipAddress3Property.Value;
//            }
//            set
//            {
//                if (shipAddress3Property == null)
//                    shipAddress3Property = GetStringProperty("POHeader.ShipAddress3");
//                shipAddress3Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> orderDateProperty;
//        public DateTime OrderDate
//        {
//            get
//            {
//                if (orderDateProperty == null)
//                    orderDateProperty = GetDateTimeProperty("POHeader.OrderDate");
//                return orderDateProperty.Value;
//            }
//            set
//            {
//                if (orderDateProperty == null)
//                    orderDateProperty = GetDateTimeProperty("POHeader.OrderDate");
//                orderDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> pONumProperty;
//        public int PONum
//        {
//            get
//            {
//                if (pONumProperty == null)
//                    pONumProperty = GetIntegerProperty("POHeader.PONum");
//                return pONumProperty.Value;
//            }
//            set
//            {
//                if (pONumProperty == null)
//                    pONumProperty = GetIntegerProperty("POHeader.PONum");
//                pONumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> shipCountryProperty;
//        public string ShipCountry
//        {
//            get
//            {
//                if (shipCountryProperty == null)
//                    shipCountryProperty = GetStringProperty("POHeader.ShipCountry");
//                return shipCountryProperty.Value;
//            }
//            set
//            {
//                if (shipCountryProperty == null)
//                    shipCountryProperty = GetStringProperty("POHeader.ShipCountry");
//                shipCountryProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> commentTextProperty;
//        public string CommentText
//        {
//            get
//            {
//                if (commentTextProperty == null)
//                    commentTextProperty = GetStringProperty("POHeader.CommentText");
//                return commentTextProperty.Value;
//            }
//            set
//            {
//                if (commentTextProperty == null)
//                    commentTextProperty = GetStringProperty("POHeader.CommentText");
//                commentTextProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> prcConNumProperty;
//        public int PrcConNum
//        {
//            get
//            {
//                if (prcConNumProperty == null)
//                    prcConNumProperty = GetIntegerProperty("POHeader.PrcConNum");
//                return prcConNumProperty.Value;
//            }
//            set
//            {
//                if (prcConNumProperty == null)
//                    prcConNumProperty = GetIntegerProperty("POHeader.PrcConNum");
//                prcConNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> vendorNumProperty;
//        public int VendorNum
//        {
//            get
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("POHeader.VendorNum");
//                return vendorNumProperty.Value;
//            }
//            set
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("POHeader.VendorNum");
//                vendorNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> shipNameProperty;
//        public string ShipName
//        {
//            get
//            {
//                if (shipNameProperty == null)
//                    shipNameProperty = GetStringProperty("POHeader.ShipName");
//                return shipNameProperty.Value;
//            }
//            set
//            {
//                if (shipNameProperty == null)
//                    shipNameProperty = GetStringProperty("POHeader.ShipName");
//                shipNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purPointProperty;
//        public string PurPoint
//        {
//            get
//            {
//                if (purPointProperty == null)
//                    purPointProperty = GetStringProperty("POHeader.PurPoint");
//                return purPointProperty.Value;
//            }
//            set
//            {
//                if (purPointProperty == null)
//                    purPointProperty = GetStringProperty("POHeader.PurPoint");
//                purPointProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> shipStateProperty;
//        public string ShipState
//        {
//            get
//            {
//                if (shipStateProperty == null)
//                    shipStateProperty = GetStringProperty("POHeader.ShipState");
//                return shipStateProperty.Value;
//            }
//            set
//            {
//                if (shipStateProperty == null)
//                    shipStateProperty = GetStringProperty("POHeader.ShipState");
//                shipStateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> shipViaCodeProperty;
//        public string ShipViaCode
//        {
//            get
//            {
//                if (shipViaCodeProperty == null)
//                    shipViaCodeProperty = GetStringProperty("POHeader.ShipViaCode");
//                return shipViaCodeProperty.Value;
//            }
//            set
//            {
//                if (shipViaCodeProperty == null)
//                    shipViaCodeProperty = GetStringProperty("POHeader.ShipViaCode");
//                shipViaCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> shipZIPProperty;
//        public string ShipZIP
//        {
//            get
//            {
//                if (shipZIPProperty == null)
//                    shipZIPProperty = GetStringProperty("POHeader.ShipZIP");
//                return shipZIPProperty.Value;
//            }
//            set
//            {
//                if (shipZIPProperty == null)
//                    shipZIPProperty = GetStringProperty("POHeader.ShipZIP");
//                shipZIPProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> termsCodeProperty;
//        public string TermsCode
//        {
//            get
//            {
//                if (termsCodeProperty == null)
//                    termsCodeProperty = GetStringProperty("POHeader.TermsCode");
//                return termsCodeProperty.Value;
//            }
//            set
//            {
//                if (termsCodeProperty == null)
//                    termsCodeProperty = GetStringProperty("POHeader.TermsCode");
//                termsCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> orderHeldProperty;
//        public bool OrderHeld
//        {
//            get
//            {
//                if (orderHeldProperty == null)
//                    orderHeldProperty = GetBooleanProperty("POHeader.OrderHeld");
//                return orderHeldProperty.Value;
//            }
//            set
//            {
//                if (orderHeldProperty == null)
//                    orderHeldProperty = GetBooleanProperty("POHeader.OrderHeld");
//                orderHeldProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> openOrderProperty;
//        public bool OpenOrder
//        {
//            get
//            {
//                if (openOrderProperty == null)
//                    openOrderProperty = GetBooleanProperty("POHeader.OpenOrder");
//                return openOrderProperty.Value;
//            }
//            set
//            {
//                if (openOrderProperty == null)
//                    openOrderProperty = GetBooleanProperty("POHeader.OpenOrder");
//                openOrderProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> buyerIDProperty;
//        public string BuyerID
//        {
//            get
//            {
//                if (buyerIDProperty == null)
//                    buyerIDProperty = GetStringProperty("POHeader.BuyerID");
//                return buyerIDProperty.Value;
//            }
//            set
//            {
//                if (buyerIDProperty == null)
//                    buyerIDProperty = GetStringProperty("POHeader.BuyerID");
//                buyerIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar1Property;
//        public string UserChar1
//        {
//            get
//            {
//                if (userChar1Property == null)
//                    userChar1Property = GetStringProperty("POHeader.UserChar1");
//                return userChar1Property.Value;
//            }
//            set
//            {
//                if (userChar1Property == null)
//                    userChar1Property = GetStringProperty("POHeader.UserChar1");
//                userChar1Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> freightPPProperty;
//        public bool FreightPP
//        {
//            get
//            {
//                if (freightPPProperty == null)
//                    freightPPProperty = GetBooleanProperty("POHeader.FreightPP");
//                return freightPPProperty.Value;
//            }
//            set
//            {
//                if (freightPPProperty == null)
//                    freightPPProperty = GetBooleanProperty("POHeader.FreightPP");
//                freightPPProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar2Property;
//        public string UserChar2
//        {
//            get
//            {
//                if (userChar2Property == null)
//                    userChar2Property = GetStringProperty("POHeader.UserChar2");
//                return userChar2Property.Value;
//            }
//            set
//            {
//                if (userChar2Property == null)
//                    userChar2Property = GetStringProperty("POHeader.UserChar2");
//                userChar2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar3Property;
//        public string UserChar3
//        {
//            get
//            {
//                if (userChar3Property == null)
//                    userChar3Property = GetStringProperty("POHeader.UserChar3");
//                return userChar3Property.Value;
//            }
//            set
//            {
//                if (userChar3Property == null)
//                    userChar3Property = GetStringProperty("POHeader.UserChar3");
//                userChar3Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> voidOrderProperty;
//        public bool VoidOrder
//        {
//            get
//            {
//                if (voidOrderProperty == null)
//                    voidOrderProperty = GetBooleanProperty("POHeader.VoidOrder");
//                return voidOrderProperty.Value;
//            }
//            set
//            {
//                if (voidOrderProperty == null)
//                    voidOrderProperty = GetBooleanProperty("POHeader.VoidOrder");
//                voidOrderProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> userChar4Property;
//        public string UserChar4
//        {
//            get
//            {
//                if (userChar4Property == null)
//                    userChar4Property = GetStringProperty("POHeader.UserChar4");
//                return userChar4Property.Value;
//            }
//            set
//            {
//                if (userChar4Property == null)
//                    userChar4Property = GetStringProperty("POHeader.UserChar4");
//                userChar4Property.Value = value;
//            }
//        }

//        protected RowProperty<string> shipAddress1Property;
//        public string ShipAddress1
//        {
//            get
//            {
//                if (shipAddress1Property == null)
//                    shipAddress1Property = GetStringProperty("POHeader.ShipAddress1");
//                return shipAddress1Property.Value;
//            }
//            set
//            {
//                if (shipAddress1Property == null)
//                    shipAddress1Property = GetStringProperty("POHeader.ShipAddress1");
//                shipAddress1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> shipAddress2Property;
//        public string ShipAddress2
//        {
//            get
//            {
//                if (shipAddress2Property == null)
//                    shipAddress2Property = GetStringProperty("POHeader.ShipAddress2");
//                return shipAddress2Property.Value;
//            }
//            set
//            {
//                if (shipAddress2Property == null)
//                    shipAddress2Property = GetStringProperty("POHeader.ShipAddress2");
//                shipAddress2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> shipCityProperty;
//        public string ShipCity
//        {
//            get
//            {
//                if (shipCityProperty == null)
//                    shipCityProperty = GetStringProperty("POHeader.ShipCity");
//                return shipCityProperty.Value;
//            }
//            set
//            {
//                if (shipCityProperty == null)
//                    shipCityProperty = GetStringProperty("POHeader.ShipCity");
//                shipCityProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate1Property;
//        public DateTime UserDate1
//        {
//            get
//            {
//                if (userDate1Property == null)
//                    userDate1Property = GetDateTimeProperty("POHeader.UserDate1");
//                return userDate1Property.Value;
//            }
//            set
//            {
//                if (userDate1Property == null)
//                    userDate1Property = GetDateTimeProperty("POHeader.UserDate1");
//                userDate1Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate2Property;
//        public DateTime UserDate2
//        {
//            get
//            {
//                if (userDate2Property == null)
//                    userDate2Property = GetDateTimeProperty("POHeader.UserDate2");
//                return userDate2Property.Value;
//            }
//            set
//            {
//                if (userDate2Property == null)
//                    userDate2Property = GetDateTimeProperty("POHeader.UserDate2");
//                userDate2Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate3Property;
//        public DateTime UserDate3
//        {
//            get
//            {
//                if (userDate3Property == null)
//                    userDate3Property = GetDateTimeProperty("POHeader.UserDate3");
//                return userDate3Property.Value;
//            }
//            set
//            {
//                if (userDate3Property == null)
//                    userDate3Property = GetDateTimeProperty("POHeader.UserDate3");
//                userDate3Property.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> userDate4Property;
//        public DateTime UserDate4
//        {
//            get
//            {
//                if (userDate4Property == null)
//                    userDate4Property = GetDateTimeProperty("POHeader.UserDate4");
//                return userDate4Property.Value;
//            }
//            set
//            {
//                if (userDate4Property == null)
//                    userDate4Property = GetDateTimeProperty("POHeader.UserDate4");
//                userDate4Property.Value = value;
//            }
//        }

//        protected RowProperty<decimal> userDecimal1Property;
//        public decimal UserDecimal1
//        {
//            get
//            {
//                if (userDecimal1Property == null)
//                    userDecimal1Property = GetDecimalProperty("POHeader.UserDecimal1");
//                return userDecimal1Property.Value;
//            }
//            set
//            {
//                if (userDecimal1Property == null)
//                    userDecimal1Property = GetDecimalProperty("POHeader.UserDecimal1");
//                userDecimal1Property.Value = value;
//            }
//        }

//        protected RowProperty<decimal> userDecimal2Property;
//        public decimal UserDecimal2
//        {
//            get
//            {
//                if (userDecimal2Property == null)
//                    userDecimal2Property = GetDecimalProperty("POHeader.UserDecimal2");
//                return userDecimal2Property.Value;
//            }
//            set
//            {
//                if (userDecimal2Property == null)
//                    userDecimal2Property = GetDecimalProperty("POHeader.UserDecimal2");
//                userDecimal2Property.Value = value;
//            }
//        }

//        protected RowProperty<int> userInteger1Property;
//        public int UserInteger1
//        {
//            get
//            {
//                if (userInteger1Property == null)
//                    userInteger1Property = GetIntegerProperty("POHeader.UserInteger1");
//                return userInteger1Property.Value;
//            }
//            set
//            {
//                if (userInteger1Property == null)
//                    userInteger1Property = GetIntegerProperty("POHeader.UserInteger1");
//                userInteger1Property.Value = value;
//            }
//        }

//        protected RowProperty<int> userInteger2Property;
//        public int UserInteger2
//        {
//            get
//            {
//                if (userInteger2Property == null)
//                    userInteger2Property = GetIntegerProperty("POHeader.UserInteger2");
//                return userInteger2Property.Value;
//            }
//            set
//            {
//                if (userInteger2Property == null)
//                    userInteger2Property = GetIntegerProperty("POHeader.UserInteger2");
//                userInteger2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> shipToConNameProperty;
//        public string ShipToConName
//        {
//            get
//            {
//                if (shipToConNameProperty == null)
//                    shipToConNameProperty = GetStringProperty("POHeader.ShipToConName");
//                return shipToConNameProperty.Value;
//            }
//            set
//            {
//                if (shipToConNameProperty == null)
//                    shipToConNameProperty = GetStringProperty("POHeader.ShipToConName");
//                shipToConNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> readyToPrintProperty;
//        public bool ReadyToPrint
//        {
//            get
//            {
//                if (readyToPrintProperty == null)
//                    readyToPrintProperty = GetBooleanProperty("POHeader.ReadyToPrint");
//                return readyToPrintProperty.Value;
//            }
//            set
//            {
//                if (readyToPrintProperty == null)
//                    readyToPrintProperty = GetBooleanProperty("POHeader.ReadyToPrint");
//                readyToPrintProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> printAsProperty;
//        public string PrintAs
//        {
//            get
//            {
//                if (printAsProperty == null)
//                    printAsProperty = GetStringProperty("POHeader.PrintAs");
//                return printAsProperty.Value;
//            }
//            set
//            {
//                if (printAsProperty == null)
//                    printAsProperty = GetStringProperty("POHeader.PrintAs");
//                printAsProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> currencyCodeProperty;
//        public string CurrencyCode
//        {
//            get
//            {
//                if (currencyCodeProperty == null)
//                    currencyCodeProperty = GetStringProperty("POHeader.CurrencyCode");
//                return currencyCodeProperty.Value;
//            }
//            set
//            {
//                if (currencyCodeProperty == null)
//                    currencyCodeProperty = GetStringProperty("POHeader.CurrencyCode");
//                currencyCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> exchangeRateProperty;
//        public decimal ExchangeRate
//        {
//            get
//            {
//                if (exchangeRateProperty == null)
//                    exchangeRateProperty = GetDecimalProperty("POHeader.ExchangeRate");
//                return exchangeRateProperty.Value;
//            }
//            set
//            {
//                if (exchangeRateProperty == null)
//                    exchangeRateProperty = GetDecimalProperty("POHeader.ExchangeRate");
//                exchangeRateProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> lockRateProperty;
//        public bool LockRate
//        {
//            get
//            {
//                if (lockRateProperty == null)
//                    lockRateProperty = GetBooleanProperty("POHeader.LockRate");
//                return lockRateProperty.Value;
//            }
//            set
//            {
//                if (lockRateProperty == null)
//                    lockRateProperty = GetBooleanProperty("POHeader.LockRate");
//                lockRateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refCodeProperty;
//        public string RefCode
//        {
//            get
//            {
//                if (refCodeProperty == null)
//                    refCodeProperty = GetStringProperty("POHeader.RefCode");
//                return refCodeProperty.Value;
//            }
//            set
//            {
//                if (refCodeProperty == null)
//                    refCodeProperty = GetStringProperty("POHeader.RefCode");
//                refCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> docToRefProperty;
//        public bool DocToRef
//        {
//            get
//            {
//                if (docToRefProperty == null)
//                    docToRefProperty = GetBooleanProperty("POHeader.DocToRef");
//                return docToRefProperty.Value;
//            }
//            set
//            {
//                if (docToRefProperty == null)
//                    docToRefProperty = GetBooleanProperty("POHeader.DocToRef");
//                docToRefProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> refToBaseProperty;
//        public bool RefToBase
//        {
//            get
//            {
//                if (refToBaseProperty == null)
//                    refToBaseProperty = GetBooleanProperty("POHeader.RefToBase");
//                return refToBaseProperty.Value;
//            }
//            set
//            {
//                if (refToBaseProperty == null)
//                    refToBaseProperty = GetBooleanProperty("POHeader.RefToBase");
//                refToBaseProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> refToBaseRateProperty;
//        public decimal RefToBaseRate
//        {
//            get
//            {
//                if (refToBaseRateProperty == null)
//                    refToBaseRateProperty = GetDecimalProperty("POHeader.RefToBaseRate");
//                return refToBaseRateProperty.Value;
//            }
//            set
//            {
//                if (refToBaseRateProperty == null)
//                    refToBaseRateProperty = GetDecimalProperty("POHeader.RefToBaseRate");
//                refToBaseRateProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> shipCountryNumProperty;
//        public int ShipCountryNum
//        {
//            get
//            {
//                if (shipCountryNumProperty == null)
//                    shipCountryNumProperty = GetIntegerProperty("POHeader.ShipCountryNum");
//                return shipCountryNumProperty.Value;
//            }
//            set
//            {
//                if (shipCountryNumProperty == null)
//                    shipCountryNumProperty = GetIntegerProperty("POHeader.ShipCountryNum");
//                shipCountryNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> logChangesProperty;
//        public bool LogChanges
//        {
//            get
//            {
//                if (logChangesProperty == null)
//                    logChangesProperty = GetBooleanProperty("POHeader.LogChanges");
//                return logChangesProperty.Value;
//            }
//            set
//            {
//                if (logChangesProperty == null)
//                    logChangesProperty = GetBooleanProperty("POHeader.LogChanges");
//                logChangesProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> approvedDateProperty;
//        public DateTime ApprovedDate
//        {
//            get
//            {
//                if (approvedDateProperty == null)
//                    approvedDateProperty = GetDateTimeProperty("POHeader.ApprovedDate");
//                return approvedDateProperty.Value;
//            }
//            set
//            {
//                if (approvedDateProperty == null)
//                    approvedDateProperty = GetDateTimeProperty("POHeader.ApprovedDate");
//                approvedDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> approvedByProperty;
//        public string ApprovedBy
//        {
//            get
//            {
//                if (approvedByProperty == null)
//                    approvedByProperty = GetStringProperty("POHeader.ApprovedBy");
//                return approvedByProperty.Value;
//            }
//            set
//            {
//                if (approvedByProperty == null)
//                    approvedByProperty = GetStringProperty("POHeader.ApprovedBy");
//                approvedByProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> approveProperty;
//        public bool Approve
//        {
//            get
//            {
//                if (approveProperty == null)
//                    approveProperty = GetBooleanProperty("POHeader.Approve");
//                return approveProperty.Value;
//            }
//            set
//            {
//                if (approveProperty == null)
//                    approveProperty = GetBooleanProperty("POHeader.Approve");
//                approveProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> approvalStatusProperty;
//        public string ApprovalStatus
//        {
//            get
//            {
//                if (approvalStatusProperty == null)
//                    approvalStatusProperty = GetStringProperty("POHeader.ApprovalStatus");
//                return approvalStatusProperty.Value;
//            }
//            set
//            {
//                if (approvalStatusProperty == null)
//                    approvalStatusProperty = GetStringProperty("POHeader.ApprovalStatus");
//                approvalStatusProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> approvedAmountProperty;
//        public decimal ApprovedAmount
//        {
//            get
//            {
//                if (approvedAmountProperty == null)
//                    approvedAmountProperty = GetDecimalProperty("POHeader.ApprovedAmount");
//                return approvedAmountProperty.Value;
//            }
//            set
//            {
//                if (approvedAmountProperty == null)
//                    approvedAmountProperty = GetDecimalProperty("POHeader.ApprovedAmount");
//                approvedAmountProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> postDateProperty;
//        public DateTime PostDate
//        {
//            get
//            {
//                if (postDateProperty == null)
//                    postDateProperty = GetDateTimeProperty("POHeader.PostDate");
//                return postDateProperty.Value;
//            }
//            set
//            {
//                if (postDateProperty == null)
//                    postDateProperty = GetDateTimeProperty("POHeader.PostDate");
//                postDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> confirmReqProperty;
//        public bool ConfirmReq
//        {
//            get
//            {
//                if (confirmReqProperty == null)
//                    confirmReqProperty = GetBooleanProperty("POHeader.ConfirmReq");
//                return confirmReqProperty.Value;
//            }
//            set
//            {
//                if (confirmReqProperty == null)
//                    confirmReqProperty = GetBooleanProperty("POHeader.ConfirmReq");
//                confirmReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> confirmedProperty;
//        public bool Confirmed
//        {
//            get
//            {
//                if (confirmedProperty == null)
//                    confirmedProperty = GetBooleanProperty("POHeader.Confirmed");
//                return confirmedProperty.Value;
//            }
//            set
//            {
//                if (confirmedProperty == null)
//                    confirmedProperty = GetBooleanProperty("POHeader.Confirmed");
//                confirmedProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> confirmViaProperty;
//        public string ConfirmVia
//        {
//            get
//            {
//                if (confirmViaProperty == null)
//                    confirmViaProperty = GetStringProperty("POHeader.ConfirmVia");
//                return confirmViaProperty.Value;
//            }
//            set
//            {
//                if (confirmViaProperty == null)
//                    confirmViaProperty = GetStringProperty("POHeader.ConfirmVia");
//                confirmViaProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> postToWebProperty;
//        public bool PostToWeb
//        {
//            get
//            {
//                if (postToWebProperty == null)
//                    postToWebProperty = GetBooleanProperty("POHeader.PostToWeb");
//                return postToWebProperty.Value;
//            }
//            set
//            {
//                if (postToWebProperty == null)
//                    postToWebProperty = GetBooleanProperty("POHeader.PostToWeb");
//                postToWebProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> orderNumProperty;
//        public int OrderNum
//        {
//            get
//            {
//                if (orderNumProperty == null)
//                    orderNumProperty = GetIntegerProperty("POHeader.OrderNum");
//                return orderNumProperty.Value;
//            }
//            set
//            {
//                if (orderNumProperty == null)
//                    orderNumProperty = GetIntegerProperty("POHeader.OrderNum");
//                orderNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> legalNumberProperty;
//        public string LegalNumber
//        {
//            get
//            {
//                if (legalNumberProperty == null)
//                    legalNumberProperty = GetStringProperty("POHeader.LegalNumber");
//                return legalNumberProperty.Value;
//            }
//            set
//            {
//                if (legalNumberProperty == null)
//                    legalNumberProperty = GetStringProperty("POHeader.LegalNumber");
//                legalNumberProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> vendorRefNumProperty;
//        public string VendorRefNum
//        {
//            get
//            {
//                if (vendorRefNumProperty == null)
//                    vendorRefNumProperty = GetStringProperty("POHeader.VendorRefNum");
//                return vendorRefNumProperty.Value;
//            }
//            set
//            {
//                if (vendorRefNumProperty == null)
//                    vendorRefNumProperty = GetStringProperty("POHeader.VendorRefNum");
//                vendorRefNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> extCompanyProperty;
//        public string ExtCompany
//        {
//            get
//            {
//                if (extCompanyProperty == null)
//                    extCompanyProperty = GetStringProperty("POHeader.ExtCompany");
//                return extCompanyProperty.Value;
//            }
//            set
//            {
//                if (extCompanyProperty == null)
//                    extCompanyProperty = GetStringProperty("POHeader.ExtCompany");
//                extCompanyProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> linkedProperty;
//        public bool Linked
//        {
//            get
//            {
//                if (linkedProperty == null)
//                    linkedProperty = GetBooleanProperty("POHeader.Linked");
//                return linkedProperty.Value;
//            }
//            set
//            {
//                if (linkedProperty == null)
//                    linkedProperty = GetBooleanProperty("POHeader.Linked");
//                linkedProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> xRefPONumProperty;
//        public string XRefPONum
//        {
//            get
//            {
//                if (xRefPONumProperty == null)
//                    xRefPONumProperty = GetStringProperty("POHeader.XRefPONum");
//                return xRefPONumProperty.Value;
//            }
//            set
//            {
//                if (xRefPONumProperty == null)
//                    xRefPONumProperty = GetStringProperty("POHeader.XRefPONum");
//                xRefPONumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> consolidatedPOProperty;
//        public bool ConsolidatedPO
//        {
//            get
//            {
//                if (consolidatedPOProperty == null)
//                    consolidatedPOProperty = GetBooleanProperty("POHeader.ConsolidatedPO");
//                return consolidatedPOProperty.Value;
//            }
//            set
//            {
//                if (consolidatedPOProperty == null)
//                    consolidatedPOProperty = GetBooleanProperty("POHeader.ConsolidatedPO");
//                consolidatedPOProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> glbCompanyProperty;
//        public string GlbCompany
//        {
//            get
//            {
//                if (glbCompanyProperty == null)
//                    glbCompanyProperty = GetStringProperty("POHeader.GlbCompany");
//                return glbCompanyProperty.Value;
//            }
//            set
//            {
//                if (glbCompanyProperty == null)
//                    glbCompanyProperty = GetStringProperty("POHeader.GlbCompany");
//                glbCompanyProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> contractStartDateProperty;
//        public DateTime ContractStartDate
//        {
//            get
//            {
//                if (contractStartDateProperty == null)
//                    contractStartDateProperty = GetDateTimeProperty("POHeader.ContractStartDate");
//                return contractStartDateProperty.Value;
//            }
//            set
//            {
//                if (contractStartDateProperty == null)
//                    contractStartDateProperty = GetDateTimeProperty("POHeader.ContractStartDate");
//                contractStartDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> contractEndDateProperty;
//        public DateTime ContractEndDate
//        {
//            get
//            {
//                if (contractEndDateProperty == null)
//                    contractEndDateProperty = GetDateTimeProperty("POHeader.ContractEndDate");
//                return contractEndDateProperty.Value;
//            }
//            set
//            {
//                if (contractEndDateProperty == null)
//                    contractEndDateProperty = GetDateTimeProperty("POHeader.ContractEndDate");
//                contractEndDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> contractOrderProperty;
//        public bool ContractOrder
//        {
//            get
//            {
//                if (contractOrderProperty == null)
//                    contractOrderProperty = GetBooleanProperty("POHeader.ContractOrder");
//                return contractOrderProperty.Value;
//            }
//            set
//            {
//                if (contractOrderProperty == null)
//                    contractOrderProperty = GetBooleanProperty("POHeader.ContractOrder");
//                contractOrderProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> printHeaderAddressProperty;
//        public bool PrintHeaderAddress
//        {
//            get
//            {
//                if (printHeaderAddressProperty == null)
//                    printHeaderAddressProperty = GetBooleanProperty("POHeader.PrintHeaderAddress");
//                return printHeaderAddressProperty.Value;
//            }
//            set
//            {
//                if (printHeaderAddressProperty == null)
//                    printHeaderAddressProperty = GetBooleanProperty("POHeader.PrintHeaderAddress");
//                printHeaderAddressProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region PORel Table

//    [Serializable()]
//    public abstract partial class PORelBase<T, R> : SFEpic.Data.EditTable<T, R>
//        where T:PORelBase<T, R>, new()
//        where R:PORelRow, new()
//    {
//        public PORelBase() : base() { }

//        protected static Schema.PORel schemaTable;
//        public static Schema.PORel SchemaTable
//        {
//            get
//            {
//                if (schemaTable == null)
//                {
//                    schemaTable = (Schema.PORel)V8Schema.Instance.TablesDictionary["PORel"];
//                }
//                return schemaTable;
//            }
//        }

//        #region Fill Methods

//        protected static ICriteriaValue[] fillByCompanyNumCriteria;
//        public static T FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//        {
//            if (fillByCompanyNumCriteria == null)
//            {
//                var list = new List<ICriteriaValue>();
//                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
//                fillByCompanyNumCriteria = list.ToArray();
//            }
//            fillByCompanyNumCriteria[0].Value = companyNum;
//            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
//        }


//        //public static PORelBase<T> FillByPONum(DataContext context, string companyNum, int pONum, params string[] columnNames)
//        //{
//        //    return FillByPONum<PORel>(context, companyNum, pONum, columnNames);
//        //}

//        protected static ICriteriaValue[] fillByPONumCriteria;
//        public static T FillByPONum(DataContext context, string companyNum, int pONum, params string[] columnNames)
//        {
//            if (fillByPONumCriteria == null)
//            {
//                var list = new List<ICriteriaValue>();
//                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
//                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PONum]));
//                fillByPONumCriteria = list.ToArray();
//            }
//            fillByPONumCriteria[0].Value = companyNum;
//            fillByPONumCriteria[1].Value = pONum;
//            return EditTable<T, R>.Fetch(context, fillByPONumCriteria, columnNames);
//        }

//        protected static ICriteriaValue[] fillByPOLineCriteria;
//        public static T FillByPOLine(DataContext context, string companyNum, int pONum, int pOLine, params string[] columnNames)
//        {
//            if (fillByPOLineCriteria == null)
//            {
//                var list = new List<ICriteriaValue>();
//                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
//                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PONum]));
//                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.POLine]));
//                fillByPOLineCriteria = list.ToArray();
//            }
//            fillByPOLineCriteria[0].Value = companyNum;
//            fillByPOLineCriteria[1].Value = pONum;
//            fillByPOLineCriteria[2].Value = pOLine;
//            return EditTable<T, R>.Fetch(context, fillByPOLineCriteria, columnNames);
//        }

//        protected static ICriteriaValue[] fillByPORelNumCriteria;
//        public static T FillByPORelNum(DataContext context, string companyNum, int pONum, int pOLine, int pORelNum, params string[] columnNames)
//        {
//            if (fillByPORelNumCriteria == null)
//            {
//                var list = new List<ICriteriaValue>();
//                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PORel.CompanyNum]));
//                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PONum]));
//                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.POLine]));
//                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PORel.PORelNum]));
//                fillByPORelNumCriteria = list.ToArray();
//            }
//            fillByPORelNumCriteria[0].Value = companyNum;
//            fillByPORelNumCriteria[1].Value = pONum;
//            fillByPORelNumCriteria[2].Value = pOLine;
//            fillByPORelNumCriteria[3].Value = pORelNum;
//            return EditTable<T, R>.Fetch(context, fillByPORelNumCriteria, columnNames);
//        }

//        #endregion

//        //protected override void InitRowLists()
//        //{
//        //    var pORelRowsList = new ObservableCollection<PORelRow>();
//        //    rowsList = pORelRowsList;
//        //    rows = new ReadOnlyObservableCollection<PORelRow>(pORelRowsList);
//        //    readOnlyRowsList = rows;
//        //}

//    }

//    [Serializable()]
//    public class PORel : PORelBase<PORel, PORelRow>
//    {
//    }

//    #region PORelRow

//    [Serializable()]
//    public class PORelRow : DataRow
//    {
//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("PORel.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("PORel.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> pOLineProperty;
//        public int POLine
//        {
//            get
//            {
//                if (pOLineProperty == null)
//                    pOLineProperty = GetIntegerProperty("PORel.POLine");
//                return pOLineProperty.Value;
//            }
//            set
//            {
//                if (pOLineProperty == null)
//                    pOLineProperty = GetIntegerProperty("PORel.POLine");
//                pOLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> pONumProperty;
//        public int PONum
//        {
//            get
//            {
//                if (pONumProperty == null)
//                    pONumProperty = GetIntegerProperty("PORel.PONum");
//                return pONumProperty.Value;
//            }
//            set
//            {
//                if (pONumProperty == null)
//                    pONumProperty = GetIntegerProperty("PORel.PONum");
//                pONumProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> relQtyProperty;
//        public decimal RelQty
//        {
//            get
//            {
//                if (relQtyProperty == null)
//                    relQtyProperty = GetDecimalProperty("PORel.RelQty");
//                return relQtyProperty.Value;
//            }
//            set
//            {
//                if (relQtyProperty == null)
//                    relQtyProperty = GetDecimalProperty("PORel.RelQty");
//                relQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> dueDateProperty;
//        public DateTime DueDate
//        {
//            get
//            {
//                if (dueDateProperty == null)
//                    dueDateProperty = GetDateTimeProperty("PORel.DueDate");
//                return dueDateProperty.Value;
//            }
//            set
//            {
//                if (dueDateProperty == null)
//                    dueDateProperty = GetDateTimeProperty("PORel.DueDate");
//                dueDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> pORelNumProperty;
//        public int PORelNum
//        {
//            get
//            {
//                if (pORelNumProperty == null)
//                    pORelNumProperty = GetIntegerProperty("PORel.PORelNum");
//                return pORelNumProperty.Value;
//            }
//            set
//            {
//                if (pORelNumProperty == null)
//                    pORelNumProperty = GetIntegerProperty("PORel.PORelNum");
//                pORelNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> openReleaseProperty;
//        public bool OpenRelease
//        {
//            get
//            {
//                if (openReleaseProperty == null)
//                    openReleaseProperty = GetBooleanProperty("PORel.OpenRelease");
//                return openReleaseProperty.Value;
//            }
//            set
//            {
//                if (openReleaseProperty == null)
//                    openReleaseProperty = GetBooleanProperty("PORel.OpenRelease");
//                openReleaseProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> voidReleaseProperty;
//        public bool VoidRelease
//        {
//            get
//            {
//                if (voidReleaseProperty == null)
//                    voidReleaseProperty = GetBooleanProperty("PORel.VoidRelease");
//                return voidReleaseProperty.Value;
//            }
//            set
//            {
//                if (voidReleaseProperty == null)
//                    voidReleaseProperty = GetBooleanProperty("PORel.VoidRelease");
//                voidReleaseProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> jobNumProperty;
//        public string JobNum
//        {
//            get
//            {
//                if (jobNumProperty == null)
//                    jobNumProperty = GetStringProperty("PORel.JobNum");
//                return jobNumProperty.Value;
//            }
//            set
//            {
//                if (jobNumProperty == null)
//                    jobNumProperty = GetStringProperty("PORel.JobNum");
//                jobNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> assemblySeqProperty;
//        public int AssemblySeq
//        {
//            get
//            {
//                if (assemblySeqProperty == null)
//                    assemblySeqProperty = GetIntegerProperty("PORel.AssemblySeq");
//                return assemblySeqProperty.Value;
//            }
//            set
//            {
//                if (assemblySeqProperty == null)
//                    assemblySeqProperty = GetIntegerProperty("PORel.AssemblySeq");
//                assemblySeqProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> jobSeqTypeProperty;
//        public string JobSeqType
//        {
//            get
//            {
//                if (jobSeqTypeProperty == null)
//                    jobSeqTypeProperty = GetStringProperty("PORel.JobSeqType");
//                return jobSeqTypeProperty.Value;
//            }
//            set
//            {
//                if (jobSeqTypeProperty == null)
//                    jobSeqTypeProperty = GetStringProperty("PORel.JobSeqType");
//                jobSeqTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> jobSeqProperty;
//        public int JobSeq
//        {
//            get
//            {
//                if (jobSeqProperty == null)
//                    jobSeqProperty = GetIntegerProperty("PORel.JobSeq");
//                return jobSeqProperty.Value;
//            }
//            set
//            {
//                if (jobSeqProperty == null)
//                    jobSeqProperty = GetIntegerProperty("PORel.JobSeq");
//                jobSeqProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> warehouseCodeProperty;
//        public string WarehouseCode
//        {
//            get
//            {
//                if (warehouseCodeProperty == null)
//                    warehouseCodeProperty = GetStringProperty("PORel.WarehouseCode");
//                return warehouseCodeProperty.Value;
//            }
//            set
//            {
//                if (warehouseCodeProperty == null)
//                    warehouseCodeProperty = GetStringProperty("PORel.WarehouseCode");
//                warehouseCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> receivedQtyProperty;
//        public decimal ReceivedQty
//        {
//            get
//            {
//                if (receivedQtyProperty == null)
//                    receivedQtyProperty = GetDecimalProperty("PORel.ReceivedQty");
//                return receivedQtyProperty.Value;
//            }
//            set
//            {
//                if (receivedQtyProperty == null)
//                    receivedQtyProperty = GetDecimalProperty("PORel.ReceivedQty");
//                receivedQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> xRelQtyProperty;
//        public decimal XRelQty
//        {
//            get
//            {
//                if (xRelQtyProperty == null)
//                    xRelQtyProperty = GetDecimalProperty("PORel.XRelQty");
//                return xRelQtyProperty.Value;
//            }
//            set
//            {
//                if (xRelQtyProperty == null)
//                    xRelQtyProperty = GetDecimalProperty("PORel.XRelQty");
//                xRelQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> purchasingFactorProperty;
//        public decimal PurchasingFactor
//        {
//            get
//            {
//                if (purchasingFactorProperty == null)
//                    purchasingFactorProperty = GetDecimalProperty("PORel.PurchasingFactor");
//                return purchasingFactorProperty.Value;
//            }
//            set
//            {
//                if (purchasingFactorProperty == null)
//                    purchasingFactorProperty = GetDecimalProperty("PORel.PurchasingFactor");
//                purchasingFactorProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expDivisionProperty;
//        public string ExpDivision
//        {
//            get
//            {
//                if (expDivisionProperty == null)
//                    expDivisionProperty = GetStringProperty("PORel.ExpDivision");
//                return expDivisionProperty.Value;
//            }
//            set
//            {
//                if (expDivisionProperty == null)
//                    expDivisionProperty = GetStringProperty("PORel.ExpDivision");
//                expDivisionProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expGLDeptProperty;
//        public string ExpGLDept
//        {
//            get
//            {
//                if (expGLDeptProperty == null)
//                    expGLDeptProperty = GetStringProperty("PORel.ExpGLDept");
//                return expGLDeptProperty.Value;
//            }
//            set
//            {
//                if (expGLDeptProperty == null)
//                    expGLDeptProperty = GetStringProperty("PORel.ExpGLDept");
//                expGLDeptProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expChartProperty;
//        public string ExpChart
//        {
//            get
//            {
//                if (expChartProperty == null)
//                    expChartProperty = GetStringProperty("PORel.ExpChart");
//                return expChartProperty.Value;
//            }
//            set
//            {
//                if (expChartProperty == null)
//                    expChartProperty = GetStringProperty("PORel.ExpChart");
//                expChartProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> expOverrideProperty;
//        public bool ExpOverride
//        {
//            get
//            {
//                if (expOverrideProperty == null)
//                    expOverrideProperty = GetBooleanProperty("PORel.ExpOverride");
//                return expOverrideProperty.Value;
//            }
//            set
//            {
//                if (expOverrideProperty == null)
//                    expOverrideProperty = GetBooleanProperty("PORel.ExpOverride");
//                expOverrideProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> reqNumProperty;
//        public int ReqNum
//        {
//            get
//            {
//                if (reqNumProperty == null)
//                    reqNumProperty = GetIntegerProperty("PORel.ReqNum");
//                return reqNumProperty.Value;
//            }
//            set
//            {
//                if (reqNumProperty == null)
//                    reqNumProperty = GetIntegerProperty("PORel.ReqNum");
//                reqNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> reqLineProperty;
//        public int ReqLine
//        {
//            get
//            {
//                if (reqLineProperty == null)
//                    reqLineProperty = GetIntegerProperty("PORel.ReqLine");
//                return reqLineProperty.Value;
//            }
//            set
//            {
//                if (reqLineProperty == null)
//                    reqLineProperty = GetIntegerProperty("PORel.ReqLine");
//                reqLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> plantNumProperty;
//        public string PlantNum
//        {
//            get
//            {
//                if (plantNumProperty == null)
//                    plantNumProperty = GetStringProperty("PORel.PlantNum");
//                return plantNumProperty.Value;
//            }
//            set
//            {
//                if (plantNumProperty == null)
//                    plantNumProperty = GetStringProperty("PORel.PlantNum");
//                plantNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> promiseDtProperty;
//        public DateTime PromiseDt
//        {
//            get
//            {
//                if (promiseDtProperty == null)
//                    promiseDtProperty = GetDateTimeProperty("PORel.PromiseDt");
//                return promiseDtProperty.Value;
//            }
//            set
//            {
//                if (promiseDtProperty == null)
//                    promiseDtProperty = GetDateTimeProperty("PORel.PromiseDt");
//                promiseDtProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> projectIDProperty;
//        public string ProjectID
//        {
//            get
//            {
//                if (projectIDProperty == null)
//                    projectIDProperty = GetStringProperty("PORel.ProjectID");
//                return projectIDProperty.Value;
//            }
//            set
//            {
//                if (projectIDProperty == null)
//                    projectIDProperty = GetStringProperty("PORel.ProjectID");
//                projectIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> reqChgDateProperty;
//        public DateTime ReqChgDate
//        {
//            get
//            {
//                if (reqChgDateProperty == null)
//                    reqChgDateProperty = GetDateTimeProperty("PORel.ReqChgDate");
//                return reqChgDateProperty.Value;
//            }
//            set
//            {
//                if (reqChgDateProperty == null)
//                    reqChgDateProperty = GetDateTimeProperty("PORel.ReqChgDate");
//                reqChgDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> confirmedProperty;
//        public bool Confirmed
//        {
//            get
//            {
//                if (confirmedProperty == null)
//                    confirmedProperty = GetBooleanProperty("PORel.Confirmed");
//                return confirmedProperty.Value;
//            }
//            set
//            {
//                if (confirmedProperty == null)
//                    confirmedProperty = GetBooleanProperty("PORel.Confirmed");
//                confirmedProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> reqChgQtyProperty;
//        public decimal ReqChgQty
//        {
//            get
//            {
//                if (reqChgQtyProperty == null)
//                    reqChgQtyProperty = GetDecimalProperty("PORel.ReqChgQty");
//                return reqChgQtyProperty.Value;
//            }
//            set
//            {
//                if (reqChgQtyProperty == null)
//                    reqChgQtyProperty = GetDecimalProperty("PORel.ReqChgQty");
//                reqChgQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> lockRelProperty;
//        public string LockRel
//        {
//            get
//            {
//                if (lockRelProperty == null)
//                    lockRelProperty = GetStringProperty("PORel.LockRel");
//                return lockRelProperty.Value;
//            }
//            set
//            {
//                if (lockRelProperty == null)
//                    lockRelProperty = GetStringProperty("PORel.LockRel");
//                lockRelProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refCodeProperty;
//        public string RefCode
//        {
//            get
//            {
//                if (refCodeProperty == null)
//                    refCodeProperty = GetStringProperty("PORel.RefCode");
//                return refCodeProperty.Value;
//            }
//            set
//            {
//                if (refCodeProperty == null)
//                    refCodeProperty = GetStringProperty("PORel.RefCode");
//                refCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refCodeDescProperty;
//        public string RefCodeDesc
//        {
//            get
//            {
//                if (refCodeDescProperty == null)
//                    refCodeDescProperty = GetStringProperty("PORel.RefCodeDesc");
//                return refCodeDescProperty.Value;
//            }
//            set
//            {
//                if (refCodeDescProperty == null)
//                    refCodeDescProperty = GetStringProperty("PORel.RefCodeDesc");
//                refCodeDescProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refTypeProperty;
//        public string RefType
//        {
//            get
//            {
//                if (refTypeProperty == null)
//                    refTypeProperty = GetStringProperty("PORel.RefType");
//                return refTypeProperty.Value;
//            }
//            set
//            {
//                if (refTypeProperty == null)
//                    refTypeProperty = GetStringProperty("PORel.RefType");
//                refTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> orderNumProperty;
//        public int OrderNum
//        {
//            get
//            {
//                if (orderNumProperty == null)
//                    orderNumProperty = GetIntegerProperty("PORel.OrderNum");
//                return orderNumProperty.Value;
//            }
//            set
//            {
//                if (orderNumProperty == null)
//                    orderNumProperty = GetIntegerProperty("PORel.OrderNum");
//                orderNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> orderLineProperty;
//        public int OrderLine
//        {
//            get
//            {
//                if (orderLineProperty == null)
//                    orderLineProperty = GetIntegerProperty("PORel.OrderLine");
//                return orderLineProperty.Value;
//            }
//            set
//            {
//                if (orderLineProperty == null)
//                    orderLineProperty = GetIntegerProperty("PORel.OrderLine");
//                orderLineProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> orderRelNumProperty;
//        public int OrderRelNum
//        {
//            get
//            {
//                if (orderRelNumProperty == null)
//                    orderRelNumProperty = GetIntegerProperty("PORel.OrderRelNum");
//                return orderRelNumProperty.Value;
//            }
//            set
//            {
//                if (orderRelNumProperty == null)
//                    orderRelNumProperty = GetIntegerProperty("PORel.OrderRelNum");
//                orderRelNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> confirmViaProperty;
//        public string ConfirmVia
//        {
//            get
//            {
//                if (confirmViaProperty == null)
//                    confirmViaProperty = GetStringProperty("PORel.ConfirmVia");
//                return confirmViaProperty.Value;
//            }
//            set
//            {
//                if (confirmViaProperty == null)
//                    confirmViaProperty = GetStringProperty("PORel.ConfirmVia");
//                confirmViaProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> extCompanyProperty;
//        public string ExtCompany
//        {
//            get
//            {
//                if (extCompanyProperty == null)
//                    extCompanyProperty = GetStringProperty("PORel.ExtCompany");
//                return extCompanyProperty.Value;
//            }
//            set
//            {
//                if (extCompanyProperty == null)
//                    extCompanyProperty = GetStringProperty("PORel.ExtCompany");
//                extCompanyProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> linkedProperty;
//        public bool Linked
//        {
//            get
//            {
//                if (linkedProperty == null)
//                    linkedProperty = GetBooleanProperty("PORel.Linked");
//                return linkedProperty.Value;
//            }
//            set
//            {
//                if (linkedProperty == null)
//                    linkedProperty = GetBooleanProperty("PORel.Linked");
//                linkedProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refDisplayAccountProperty;
//        public string RefDisplayAccount
//        {
//            get
//            {
//                if (refDisplayAccountProperty == null)
//                    refDisplayAccountProperty = GetStringProperty("PORel.RefDisplayAccount");
//                return refDisplayAccountProperty.Value;
//            }
//            set
//            {
//                if (refDisplayAccountProperty == null)
//                    refDisplayAccountProperty = GetStringProperty("PORel.RefDisplayAccount");
//                refDisplayAccountProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> shippedQtyProperty;
//        public decimal ShippedQty
//        {
//            get
//            {
//                if (shippedQtyProperty == null)
//                    shippedQtyProperty = GetDecimalProperty("PORel.ShippedQty");
//                return shippedQtyProperty.Value;
//            }
//            set
//            {
//                if (shippedQtyProperty == null)
//                    shippedQtyProperty = GetDecimalProperty("PORel.ShippedQty");
//                shippedQtyProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> tranTypeProperty;
//        public string TranType
//        {
//            get
//            {
//                if (tranTypeProperty == null)
//                    tranTypeProperty = GetStringProperty("PORel.TranType");
//                return tranTypeProperty.Value;
//            }
//            set
//            {
//                if (tranTypeProperty == null)
//                    tranTypeProperty = GetStringProperty("PORel.TranType");
//                tranTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refAcctChartProperty;
//        public string RefAcctChart
//        {
//            get
//            {
//                if (refAcctChartProperty == null)
//                    refAcctChartProperty = GetStringProperty("PORel.RefAcctChart");
//                return refAcctChartProperty.Value;
//            }
//            set
//            {
//                if (refAcctChartProperty == null)
//                    refAcctChartProperty = GetStringProperty("PORel.RefAcctChart");
//                refAcctChartProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refAcctDivProperty;
//        public string RefAcctDiv
//        {
//            get
//            {
//                if (refAcctDivProperty == null)
//                    refAcctDivProperty = GetStringProperty("PORel.RefAcctDiv");
//                return refAcctDivProperty.Value;
//            }
//            set
//            {
//                if (refAcctDivProperty == null)
//                    refAcctDivProperty = GetStringProperty("PORel.RefAcctDiv");
//                refAcctDivProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refAcctDeptProperty;
//        public string RefAcctDept
//        {
//            get
//            {
//                if (refAcctDeptProperty == null)
//                    refAcctDeptProperty = GetStringProperty("PORel.RefAcctDept");
//                return refAcctDeptProperty.Value;
//            }
//            set
//            {
//                if (refAcctDeptProperty == null)
//                    refAcctDeptProperty = GetStringProperty("PORel.RefAcctDept");
//                refAcctDeptProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> glbCompanyProperty;
//        public string GlbCompany
//        {
//            get
//            {
//                if (glbCompanyProperty == null)
//                    glbCompanyProperty = GetStringProperty("PORel.GlbCompany");
//                return glbCompanyProperty.Value;
//            }
//            set
//            {
//                if (glbCompanyProperty == null)
//                    glbCompanyProperty = GetStringProperty("PORel.GlbCompany");
//                glbCompanyProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> glbPlantProperty;
//        public string GlbPlant
//        {
//            get
//            {
//                if (glbPlantProperty == null)
//                    glbPlantProperty = GetStringProperty("PORel.GlbPlant");
//                return glbPlantProperty.Value;
//            }
//            set
//            {
//                if (glbPlantProperty == null)
//                    glbPlantProperty = GetStringProperty("PORel.GlbPlant");
//                glbPlantProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> glbWarehouseProperty;
//        public string GlbWarehouse
//        {
//            get
//            {
//                if (glbWarehouseProperty == null)
//                    glbWarehouseProperty = GetStringProperty("PORel.GlbWarehouse");
//                return glbWarehouseProperty.Value;
//            }
//            set
//            {
//                if (glbWarehouseProperty == null)
//                    glbWarehouseProperty = GetStringProperty("PORel.GlbWarehouse");
//                glbWarehouseProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> glbCreateJobMtlProperty;
//        public bool GlbCreateJobMtl
//        {
//            get
//            {
//                if (glbCreateJobMtlProperty == null)
//                    glbCreateJobMtlProperty = GetBooleanProperty("PORel.GlbCreateJobMtl");
//                return glbCreateJobMtlProperty.Value;
//            }
//            set
//            {
//                if (glbCreateJobMtlProperty == null)
//                    glbCreateJobMtlProperty = GetBooleanProperty("PORel.GlbCreateJobMtl");
//                glbCreateJobMtlProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> shippedDateProperty;
//        public DateTime ShippedDate
//        {
//            get
//            {
//                if (shippedDateProperty == null)
//                    shippedDateProperty = GetDateTimeProperty("PORel.ShippedDate");
//                return shippedDateProperty.Value;
//            }
//            set
//            {
//                if (shippedDateProperty == null)
//                    shippedDateProperty = GetDateTimeProperty("PORel.ShippedDate");
//                shippedDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> containerIDProperty;
//        public int ContainerID
//        {
//            get
//            {
//                if (containerIDProperty == null)
//                    containerIDProperty = GetIntegerProperty("PORel.ContainerID");
//                return containerIDProperty.Value;
//            }
//            set
//            {
//                if (containerIDProperty == null)
//                    containerIDProperty = GetIntegerProperty("PORel.ContainerID");
//                containerIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purchasingFactorDirectionProperty;
//        public string PurchasingFactorDirection
//        {
//            get
//            {
//                if (purchasingFactorDirectionProperty == null)
//                    purchasingFactorDirectionProperty = GetStringProperty("PORel.PurchasingFactorDirection");
//                return purchasingFactorDirectionProperty.Value;
//            }
//            set
//            {
//                if (purchasingFactorDirectionProperty == null)
//                    purchasingFactorDirectionProperty = GetStringProperty("PORel.PurchasingFactorDirection");
//                purchasingFactorDirectionProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> previousDueDateProperty;
//        public DateTime PreviousDueDate
//        {
//            get
//            {
//                if (previousDueDateProperty == null)
//                    previousDueDateProperty = GetDateTimeProperty("PORel.PreviousDueDate");
//                return previousDueDateProperty.Value;
//            }
//            set
//            {
//                if (previousDueDateProperty == null)
//                    previousDueDateProperty = GetDateTimeProperty("PORel.PreviousDueDate");
//                previousDueDateProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region PurAgent Table

//    //[Serializable()]
//    //public partial class PurAgent : SFEpic.Data.EditTable<PurAgent>
//    //{
//    //    public PurAgent() : base() { }

//    //    new protected static Schema.PurAgent schemaTable;
//    //    new public static Schema.PurAgent SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.PurAgent)V8Schema.Instance.TablesDictionary["PurAgent"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static PurAgent FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PurAgent.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return PurAgent.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByBuyerIDCriteria;
//    //    public static PurAgent FillByBuyerID(DataContext context, string companyNum, string buyerID, params string[] columnNames)
//    //    {
//    //        if (fillByBuyerIDCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PurAgent.CompanyNum]));
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PurAgent.BuyerID]));
//    //            fillByBuyerIDCriteria = list.ToArray();
//    //        }
//    //        fillByBuyerIDCriteria[0].Value = companyNum;
//    //        fillByBuyerIDCriteria[1].Value = buyerID;
//    //        return PurAgent.Fetch(context, fillByBuyerIDCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new PurAgentRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var purAgentRowsList = new ObservableCollection<PurAgentRow>();
//    //        rowsList = purAgentRowsList;
//    //        rows = new ReadOnlyObservableCollection<PurAgentRow>(purAgentRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<PurAgentRow> rows;
//    //    new public ReadOnlyObservableCollection<PurAgentRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public PurAgentRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region PurAgentRow

//    [Serializable()]
//    public class PurAgentRow : DataRow
//    {
//        protected RowProperty<bool> inActiveProperty;
//        public bool InActive
//        {
//            get
//            {
//                if (inActiveProperty == null)
//                    inActiveProperty = GetBooleanProperty("PurAgent.InActive");
//                return inActiveProperty.Value;
//            }
//            set
//            {
//                if (inActiveProperty == null)
//                    inActiveProperty = GetBooleanProperty("PurAgent.InActive");
//                inActiveProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("PurAgent.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("PurAgent.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> buyerIDProperty;
//        public string BuyerID
//        {
//            get
//            {
//                if (buyerIDProperty == null)
//                    buyerIDProperty = GetStringProperty("PurAgent.BuyerID");
//                return buyerIDProperty.Value;
//            }
//            set
//            {
//                if (buyerIDProperty == null)
//                    buyerIDProperty = GetStringProperty("PurAgent.BuyerID");
//                buyerIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nameProperty;
//        public string Name
//        {
//            get
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("PurAgent.Name");
//                return nameProperty.Value;
//            }
//            set
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("PurAgent.Name");
//                nameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> approvalPersonProperty;
//        public string ApprovalPerson
//        {
//            get
//            {
//                if (approvalPersonProperty == null)
//                    approvalPersonProperty = GetStringProperty("PurAgent.ApprovalPerson");
//                return approvalPersonProperty.Value;
//            }
//            set
//            {
//                if (approvalPersonProperty == null)
//                    approvalPersonProperty = GetStringProperty("PurAgent.ApprovalPerson");
//                approvalPersonProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> pOLimitProperty;
//        public decimal POLimit
//        {
//            get
//            {
//                if (pOLimitProperty == null)
//                    pOLimitProperty = GetDecimalProperty("PurAgent.POLimit");
//                return pOLimitProperty.Value;
//            }
//            set
//            {
//                if (pOLimitProperty == null)
//                    pOLimitProperty = GetDecimalProperty("PurAgent.POLimit");
//                pOLimitProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eMailAddressProperty;
//        public string EMailAddress
//        {
//            get
//            {
//                if (eMailAddressProperty == null)
//                    eMailAddressProperty = GetStringProperty("PurAgent.EMailAddress");
//                return eMailAddressProperty.Value;
//            }
//            set
//            {
//                if (eMailAddressProperty == null)
//                    eMailAddressProperty = GetStringProperty("PurAgent.EMailAddress");
//                eMailAddressProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> consolidatedPurchasingProperty;
//        public bool ConsolidatedPurchasing
//        {
//            get
//            {
//                if (consolidatedPurchasingProperty == null)
//                    consolidatedPurchasingProperty = GetBooleanProperty("PurAgent.ConsolidatedPurchasing");
//                return consolidatedPurchasingProperty.Value;
//            }
//            set
//            {
//                if (consolidatedPurchasingProperty == null)
//                    consolidatedPurchasingProperty = GetBooleanProperty("PurAgent.ConsolidatedPurchasing");
//                consolidatedPurchasingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> cnvEmpIDProperty;
//        public string CnvEmpID
//        {
//            get
//            {
//                if (cnvEmpIDProperty == null)
//                    cnvEmpIDProperty = GetStringProperty("PurAgent.CnvEmpID");
//                return cnvEmpIDProperty.Value;
//            }
//            set
//            {
//                if (cnvEmpIDProperty == null)
//                    cnvEmpIDProperty = GetStringProperty("PurAgent.CnvEmpID");
//                cnvEmpIDProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region Vendor Table

//    //[Serializable()]
//    //public partial class Vendor : SFEpic.Data.EditTable<Vendor>
//    //{
//    //    public Vendor() : base() { }

//    //    new protected static Schema.Vendor schemaTable;
//    //    new public static Schema.Vendor SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.Vendor)V8Schema.Instance.TablesDictionary["Vendor"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static Vendor FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Vendor.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return Vendor.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByVendorNumCriteria;
//    //    public static Vendor FillByVendorNum(DataContext context, string companyNum, int vendorNum, params string[] columnNames)
//    //    {
//    //        if (fillByVendorNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Vendor.CompanyNum]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.Vendor.VendorNum]));
//    //            fillByVendorNumCriteria = list.ToArray();
//    //        }
//    //        fillByVendorNumCriteria[0].Value = companyNum;
//    //        fillByVendorNumCriteria[1].Value = vendorNum;
//    //        return Vendor.Fetch(context, fillByVendorNumCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new VendorRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var vendorRowsList = new ObservableCollection<VendorRow>();
//    //        rowsList = vendorRowsList;
//    //        rows = new ReadOnlyObservableCollection<VendorRow>(vendorRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<VendorRow> rows;
//    //    new public ReadOnlyObservableCollection<VendorRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public VendorRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region VendorRow

//    [Serializable()]
//    public class VendorRow : DataRow
//    {
//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("Vendor.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("Vendor.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> vendorIDProperty;
//        public string VendorID
//        {
//            get
//            {
//                if (vendorIDProperty == null)
//                    vendorIDProperty = GetStringProperty("Vendor.VendorID");
//                return vendorIDProperty.Value;
//            }
//            set
//            {
//                if (vendorIDProperty == null)
//                    vendorIDProperty = GetStringProperty("Vendor.VendorID");
//                vendorIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> address1Property;
//        public string Address1
//        {
//            get
//            {
//                if (address1Property == null)
//                    address1Property = GetStringProperty("Vendor.Address1");
//                return address1Property.Value;
//            }
//            set
//            {
//                if (address1Property == null)
//                    address1Property = GetStringProperty("Vendor.Address1");
//                address1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> address2Property;
//        public string Address2
//        {
//            get
//            {
//                if (address2Property == null)
//                    address2Property = GetStringProperty("Vendor.Address2");
//                return address2Property.Value;
//            }
//            set
//            {
//                if (address2Property == null)
//                    address2Property = GetStringProperty("Vendor.Address2");
//                address2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> cityProperty;
//        public string City
//        {
//            get
//            {
//                if (cityProperty == null)
//                    cityProperty = GetStringProperty("Vendor.City");
//                return cityProperty.Value;
//            }
//            set
//            {
//                if (cityProperty == null)
//                    cityProperty = GetStringProperty("Vendor.City");
//                cityProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> countryProperty;
//        public string Country
//        {
//            get
//            {
//                if (countryProperty == null)
//                    countryProperty = GetStringProperty("Vendor.Country");
//                return countryProperty.Value;
//            }
//            set
//            {
//                if (countryProperty == null)
//                    countryProperty = GetStringProperty("Vendor.Country");
//                countryProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> groupCodeProperty;
//        public string GroupCode
//        {
//            get
//            {
//                if (groupCodeProperty == null)
//                    groupCodeProperty = GetStringProperty("Vendor.GroupCode");
//                return groupCodeProperty.Value;
//            }
//            set
//            {
//                if (groupCodeProperty == null)
//                    groupCodeProperty = GetStringProperty("Vendor.GroupCode");
//                groupCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nameProperty;
//        public string Name
//        {
//            get
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("Vendor.Name");
//                return nameProperty.Value;
//            }
//            set
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("Vendor.Name");
//                nameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expenseDivProperty;
//        public string ExpenseDiv
//        {
//            get
//            {
//                if (expenseDivProperty == null)
//                    expenseDivProperty = GetStringProperty("Vendor.ExpenseDiv");
//                return expenseDivProperty.Value;
//            }
//            set
//            {
//                if (expenseDivProperty == null)
//                    expenseDivProperty = GetStringProperty("Vendor.ExpenseDiv");
//                expenseDivProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> taxPayerIDProperty;
//        public string TaxPayerID
//        {
//            get
//            {
//                if (taxPayerIDProperty == null)
//                    taxPayerIDProperty = GetStringProperty("Vendor.TaxPayerID");
//                return taxPayerIDProperty.Value;
//            }
//            set
//            {
//                if (taxPayerIDProperty == null)
//                    taxPayerIDProperty = GetStringProperty("Vendor.TaxPayerID");
//                taxPayerIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> faxNumProperty;
//        public string FaxNum
//        {
//            get
//            {
//                if (faxNumProperty == null)
//                    faxNumProperty = GetStringProperty("Vendor.FaxNum");
//                return faxNumProperty.Value;
//            }
//            set
//            {
//                if (faxNumProperty == null)
//                    faxNumProperty = GetStringProperty("Vendor.FaxNum");
//                faxNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purPointProperty;
//        public string PurPoint
//        {
//            get
//            {
//                if (purPointProperty == null)
//                    purPointProperty = GetStringProperty("Vendor.PurPoint");
//                return purPointProperty.Value;
//            }
//            set
//            {
//                if (purPointProperty == null)
//                    purPointProperty = GetStringProperty("Vendor.PurPoint");
//                purPointProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> stateProperty;
//        public string State
//        {
//            get
//            {
//                if (stateProperty == null)
//                    stateProperty = GetStringProperty("Vendor.State");
//                return stateProperty.Value;
//            }
//            set
//            {
//                if (stateProperty == null)
//                    stateProperty = GetStringProperty("Vendor.State");
//                stateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> termsCodeProperty;
//        public string TermsCode
//        {
//            get
//            {
//                if (termsCodeProperty == null)
//                    termsCodeProperty = GetStringProperty("Vendor.TermsCode");
//                return termsCodeProperty.Value;
//            }
//            set
//            {
//                if (termsCodeProperty == null)
//                    termsCodeProperty = GetStringProperty("Vendor.TermsCode");
//                termsCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> zipProperty;
//        public string ZIP
//        {
//            get
//            {
//                if (zipProperty == null)
//                    zipProperty = GetStringProperty("Vendor.ZIP");
//                return zipProperty.Value;
//            }
//            set
//            {
//                if (zipProperty == null)
//                    zipProperty = GetStringProperty("Vendor.ZIP");
//                zipProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> print1099Property;
//        public bool Print1099
//        {
//            get
//            {
//                if (print1099Property == null)
//                    print1099Property = GetBooleanProperty("Vendor.Print1099");
//                return print1099Property.Value;
//            }
//            set
//            {
//                if (print1099Property == null)
//                    print1099Property = GetBooleanProperty("Vendor.Print1099");
//                print1099Property.Value = value;
//            }
//        }

//        protected RowProperty<string> expenseChartProperty;
//        public string ExpenseChart
//        {
//            get
//            {
//                if (expenseChartProperty == null)
//                    expenseChartProperty = GetStringProperty("Vendor.ExpenseChart");
//                return expenseChartProperty.Value;
//            }
//            set
//            {
//                if (expenseChartProperty == null)
//                    expenseChartProperty = GetStringProperty("Vendor.ExpenseChart");
//                expenseChartProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> expenseDeptProperty;
//        public string ExpenseDept
//        {
//            get
//            {
//                if (expenseDeptProperty == null)
//                    expenseDeptProperty = GetStringProperty("Vendor.ExpenseDept");
//                return expenseDeptProperty.Value;
//            }
//            set
//            {
//                if (expenseDeptProperty == null)
//                    expenseDeptProperty = GetStringProperty("Vendor.ExpenseDept");
//                expenseDeptProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> oneCheckProperty;
//        public bool OneCheck
//        {
//            get
//            {
//                if (oneCheckProperty == null)
//                    oneCheckProperty = GetBooleanProperty("Vendor.OneCheck");
//                return oneCheckProperty.Value;
//            }
//            set
//            {
//                if (oneCheckProperty == null)
//                    oneCheckProperty = GetBooleanProperty("Vendor.OneCheck");
//                oneCheckProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> printLabelsProperty;
//        public bool PrintLabels
//        {
//            get
//            {
//                if (printLabelsProperty == null)
//                    printLabelsProperty = GetBooleanProperty("Vendor.PrintLabels");
//                return printLabelsProperty.Value;
//            }
//            set
//            {
//                if (printLabelsProperty == null)
//                    printLabelsProperty = GetBooleanProperty("Vendor.PrintLabels");
//                printLabelsProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> inactiveProperty;
//        public bool Inactive
//        {
//            get
//            {
//                if (inactiveProperty == null)
//                    inactiveProperty = GetBooleanProperty("Vendor.Inactive");
//                return inactiveProperty.Value;
//            }
//            set
//            {
//                if (inactiveProperty == null)
//                    inactiveProperty = GetBooleanProperty("Vendor.Inactive");
//                inactiveProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> vendorNumProperty;
//        public int VendorNum
//        {
//            get
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("Vendor.VendorNum");
//                return vendorNumProperty.Value;
//            }
//            set
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("Vendor.VendorNum");
//                vendorNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> phoneNumProperty;
//        public string PhoneNum
//        {
//            get
//            {
//                if (phoneNumProperty == null)
//                    phoneNumProperty = GetStringProperty("Vendor.PhoneNum");
//                return phoneNumProperty.Value;
//            }
//            set
//            {
//                if (phoneNumProperty == null)
//                    phoneNumProperty = GetStringProperty("Vendor.PhoneNum");
//                phoneNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> commentProperty;
//        public string Comment
//        {
//            get
//            {
//                if (commentProperty == null)
//                    commentProperty = GetStringProperty("Vendor.Comment");
//                return commentProperty.Value;
//            }
//            set
//            {
//                if (commentProperty == null)
//                    commentProperty = GetStringProperty("Vendor.Comment");
//                commentProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> address3Property;
//        public string Address3
//        {
//            get
//            {
//                if (address3Property == null)
//                    address3Property = GetStringProperty("Vendor.Address3");
//                return address3Property.Value;
//            }
//            set
//            {
//                if (address3Property == null)
//                    address3Property = GetStringProperty("Vendor.Address3");
//                address3Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> payHoldProperty;
//        public bool PayHold
//        {
//            get
//            {
//                if (payHoldProperty == null)
//                    payHoldProperty = GetBooleanProperty("Vendor.PayHold");
//                return payHoldProperty.Value;
//            }
//            set
//            {
//                if (payHoldProperty == null)
//                    payHoldProperty = GetBooleanProperty("Vendor.PayHold");
//                payHoldProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> primPConProperty;
//        public int PrimPCon
//        {
//            get
//            {
//                if (primPConProperty == null)
//                    primPConProperty = GetIntegerProperty("Vendor.PrimPCon");
//                return primPConProperty.Value;
//            }
//            set
//            {
//                if (primPConProperty == null)
//                    primPConProperty = GetIntegerProperty("Vendor.PrimPCon");
//                primPConProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> accountRefProperty;
//        public string AccountRef
//        {
//            get
//            {
//                if (accountRefProperty == null)
//                    accountRefProperty = GetStringProperty("Vendor.AccountRef");
//                return accountRefProperty.Value;
//            }
//            set
//            {
//                if (accountRefProperty == null)
//                    accountRefProperty = GetStringProperty("Vendor.AccountRef");
//                accountRefProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> aPAcctIDProperty;
//        public string APAcctID
//        {
//            get
//            {
//                if (aPAcctIDProperty == null)
//                    aPAcctIDProperty = GetStringProperty("Vendor.APAcctID");
//                return aPAcctIDProperty.Value;
//            }
//            set
//            {
//                if (aPAcctIDProperty == null)
//                    aPAcctIDProperty = GetStringProperty("Vendor.APAcctID");
//                aPAcctIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> defaultFOBProperty;
//        public string DefaultFOB
//        {
//            get
//            {
//                if (defaultFOBProperty == null)
//                    defaultFOBProperty = GetStringProperty("Vendor.DefaultFOB");
//                return defaultFOBProperty.Value;
//            }
//            set
//            {
//                if (defaultFOBProperty == null)
//                    defaultFOBProperty = GetStringProperty("Vendor.DefaultFOB");
//                defaultFOBProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> rcvInspectionReqProperty;
//        public bool RcvInspectionReq
//        {
//            get
//            {
//                if (rcvInspectionReqProperty == null)
//                    rcvInspectionReqProperty = GetBooleanProperty("Vendor.RcvInspectionReq");
//                return rcvInspectionReqProperty.Value;
//            }
//            set
//            {
//                if (rcvInspectionReqProperty == null)
//                    rcvInspectionReqProperty = GetBooleanProperty("Vendor.RcvInspectionReq");
//                rcvInspectionReqProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> currencyCodeProperty;
//        public string CurrencyCode
//        {
//            get
//            {
//                if (currencyCodeProperty == null)
//                    currencyCodeProperty = GetStringProperty("Vendor.CurrencyCode");
//                return currencyCodeProperty.Value;
//            }
//            set
//            {
//                if (currencyCodeProperty == null)
//                    currencyCodeProperty = GetStringProperty("Vendor.CurrencyCode");
//                currencyCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> taxRegionCodeProperty;
//        public string TaxRegionCode
//        {
//            get
//            {
//                if (taxRegionCodeProperty == null)
//                    taxRegionCodeProperty = GetStringProperty("Vendor.TaxRegionCode");
//                return taxRegionCodeProperty.Value;
//            }
//            set
//            {
//                if (taxRegionCodeProperty == null)
//                    taxRegionCodeProperty = GetStringProperty("Vendor.TaxRegionCode");
//                taxRegionCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> langNameIDProperty;
//        public string LangNameID
//        {
//            get
//            {
//                if (langNameIDProperty == null)
//                    langNameIDProperty = GetStringProperty("Vendor.LangNameID");
//                return langNameIDProperty.Value;
//            }
//            set
//            {
//                if (langNameIDProperty == null)
//                    langNameIDProperty = GetStringProperty("Vendor.LangNameID");
//                langNameIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> countryNumProperty;
//        public int CountryNum
//        {
//            get
//            {
//                if (countryNumProperty == null)
//                    countryNumProperty = GetIntegerProperty("Vendor.CountryNum");
//                return countryNumProperty.Value;
//            }
//            set
//            {
//                if (countryNumProperty == null)
//                    countryNumProperty = GetIntegerProperty("Vendor.CountryNum");
//                countryNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> formatStrProperty;
//        public string FormatStr
//        {
//            get
//            {
//                if (formatStrProperty == null)
//                    formatStrProperty = GetStringProperty("Vendor.FormatStr");
//                return formatStrProperty.Value;
//            }
//            set
//            {
//                if (formatStrProperty == null)
//                    formatStrProperty = GetStringProperty("Vendor.FormatStr");
//                formatStrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> borderCrossingProperty;
//        public string BorderCrossing
//        {
//            get
//            {
//                if (borderCrossingProperty == null)
//                    borderCrossingProperty = GetStringProperty("Vendor.BorderCrossing");
//                return borderCrossingProperty.Value;
//            }
//            set
//            {
//                if (borderCrossingProperty == null)
//                    borderCrossingProperty = GetStringProperty("Vendor.BorderCrossing");
//                borderCrossingProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> elecPaymentProperty;
//        public bool ElecPayment
//        {
//            get
//            {
//                if (elecPaymentProperty == null)
//                    elecPaymentProperty = GetBooleanProperty("Vendor.ElecPayment");
//                return elecPaymentProperty.Value;
//            }
//            set
//            {
//                if (elecPaymentProperty == null)
//                    elecPaymentProperty = GetBooleanProperty("Vendor.ElecPayment");
//                elecPaymentProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> primaryBankIDProperty;
//        public string PrimaryBankID
//        {
//            get
//            {
//                if (primaryBankIDProperty == null)
//                    primaryBankIDProperty = GetStringProperty("Vendor.PrimaryBankID");
//                return primaryBankIDProperty.Value;
//            }
//            set
//            {
//                if (primaryBankIDProperty == null)
//                    primaryBankIDProperty = GetStringProperty("Vendor.PrimaryBankID");
//                primaryBankIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> approvedProperty;
//        public bool Approved
//        {
//            get
//            {
//                if (approvedProperty == null)
//                    approvedProperty = GetBooleanProperty("Vendor.Approved");
//                return approvedProperty.Value;
//            }
//            set
//            {
//                if (approvedProperty == null)
//                    approvedProperty = GetBooleanProperty("Vendor.Approved");
//                approvedProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> iCVendProperty;
//        public bool ICVend
//        {
//            get
//            {
//                if (iCVendProperty == null)
//                    iCVendProperty = GetBooleanProperty("Vendor.ICVend");
//                return iCVendProperty.Value;
//            }
//            set
//            {
//                if (iCVendProperty == null)
//                    iCVendProperty = GetBooleanProperty("Vendor.ICVend");
//                iCVendProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eMailAddressProperty;
//        public string EMailAddress
//        {
//            get
//            {
//                if (eMailAddressProperty == null)
//                    eMailAddressProperty = GetStringProperty("Vendor.EMailAddress");
//                return eMailAddressProperty.Value;
//            }
//            set
//            {
//                if (eMailAddressProperty == null)
//                    eMailAddressProperty = GetStringProperty("Vendor.EMailAddress");
//                eMailAddressProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> webVendorProperty;
//        public bool WebVendor
//        {
//            get
//            {
//                if (webVendorProperty == null)
//                    webVendorProperty = GetBooleanProperty("Vendor.WebVendor");
//                return webVendorProperty.Value;
//            }
//            set
//            {
//                if (webVendorProperty == null)
//                    webVendorProperty = GetBooleanProperty("Vendor.WebVendor");
//                webVendorProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> vendURLProperty;
//        public string VendURL
//        {
//            get
//            {
//                if (vendURLProperty == null)
//                    vendURLProperty = GetStringProperty("Vendor.VendURL");
//                return vendURLProperty.Value;
//            }
//            set
//            {
//                if (vendURLProperty == null)
//                    vendURLProperty = GetStringProperty("Vendor.VendURL");
//                vendURLProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> earlyBufferProperty;
//        public int EarlyBuffer
//        {
//            get
//            {
//                if (earlyBufferProperty == null)
//                    earlyBufferProperty = GetIntegerProperty("Vendor.EarlyBuffer");
//                return earlyBufferProperty.Value;
//            }
//            set
//            {
//                if (earlyBufferProperty == null)
//                    earlyBufferProperty = GetIntegerProperty("Vendor.EarlyBuffer");
//                earlyBufferProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> lateBufferProperty;
//        public int LateBuffer
//        {
//            get
//            {
//                if (lateBufferProperty == null)
//                    lateBufferProperty = GetIntegerProperty("Vendor.LateBuffer");
//                return lateBufferProperty.Value;
//            }
//            set
//            {
//                if (lateBufferProperty == null)
//                    lateBufferProperty = GetIntegerProperty("Vendor.LateBuffer");
//                lateBufferProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> onTimeRatingProperty;
//        public string OnTimeRating
//        {
//            get
//            {
//                if (onTimeRatingProperty == null)
//                    onTimeRatingProperty = GetStringProperty("Vendor.OnTimeRating");
//                return onTimeRatingProperty.Value;
//            }
//            set
//            {
//                if (onTimeRatingProperty == null)
//                    onTimeRatingProperty = GetStringProperty("Vendor.OnTimeRating");
//                onTimeRatingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> qualityRatingProperty;
//        public string QualityRating
//        {
//            get
//            {
//                if (qualityRatingProperty == null)
//                    qualityRatingProperty = GetStringProperty("Vendor.QualityRating");
//                return qualityRatingProperty.Value;
//            }
//            set
//            {
//                if (qualityRatingProperty == null)
//                    qualityRatingProperty = GetStringProperty("Vendor.QualityRating");
//                qualityRatingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> priceRatingProperty;
//        public string PriceRating
//        {
//            get
//            {
//                if (priceRatingProperty == null)
//                    priceRatingProperty = GetStringProperty("Vendor.PriceRating");
//                return priceRatingProperty.Value;
//            }
//            set
//            {
//                if (priceRatingProperty == null)
//                    priceRatingProperty = GetStringProperty("Vendor.PriceRating");
//                priceRatingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> serviceRatingProperty;
//        public string ServiceRating
//        {
//            get
//            {
//                if (serviceRatingProperty == null)
//                    serviceRatingProperty = GetStringProperty("Vendor.ServiceRating");
//                return serviceRatingProperty.Value;
//            }
//            set
//            {
//                if (serviceRatingProperty == null)
//                    serviceRatingProperty = GetStringProperty("Vendor.ServiceRating");
//                serviceRatingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> externalIdProperty;
//        public string ExternalId
//        {
//            get
//            {
//                if (externalIdProperty == null)
//                    externalIdProperty = GetStringProperty("Vendor.ExternalId");
//                return externalIdProperty.Value;
//            }
//            set
//            {
//                if (externalIdProperty == null)
//                    externalIdProperty = GetStringProperty("Vendor.ExternalId");
//                externalIdProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> vendPILimitProperty;
//        public int VendPILimit
//        {
//            get
//            {
//                if (vendPILimitProperty == null)
//                    vendPILimitProperty = GetIntegerProperty("Vendor.VendPILimit");
//                return vendPILimitProperty.Value;
//            }
//            set
//            {
//                if (vendPILimitProperty == null)
//                    vendPILimitProperty = GetIntegerProperty("Vendor.VendPILimit");
//                vendPILimitProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> globalVendorProperty;
//        public bool GlobalVendor
//        {
//            get
//            {
//                if (globalVendorProperty == null)
//                    globalVendorProperty = GetBooleanProperty("Vendor.GlobalVendor");
//                return globalVendorProperty.Value;
//            }
//            set
//            {
//                if (globalVendorProperty == null)
//                    globalVendorProperty = GetBooleanProperty("Vendor.GlobalVendor");
//                globalVendorProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> iCTraderProperty;
//        public bool ICTrader
//        {
//            get
//            {
//                if (iCTraderProperty == null)
//                    iCTraderProperty = GetBooleanProperty("Vendor.ICTrader");
//                return iCTraderProperty.Value;
//            }
//            set
//            {
//                if (iCTraderProperty == null)
//                    iCTraderProperty = GetBooleanProperty("Vendor.ICTrader");
//                iCTraderProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> taxAuthorityCodeProperty;
//        public string TaxAuthorityCode
//        {
//            get
//            {
//                if (taxAuthorityCodeProperty == null)
//                    taxAuthorityCodeProperty = GetStringProperty("Vendor.TaxAuthorityCode");
//                return taxAuthorityCodeProperty.Value;
//            }
//            set
//            {
//                if (taxAuthorityCodeProperty == null)
//                    taxAuthorityCodeProperty = GetStringProperty("Vendor.TaxAuthorityCode");
//                taxAuthorityCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> globalLockProperty;
//        public bool GlobalLock
//        {
//            get
//            {
//                if (globalLockProperty == null)
//                    globalLockProperty = GetBooleanProperty("Vendor.GlobalLock");
//                return globalLockProperty.Value;
//            }
//            set
//            {
//                if (globalLockProperty == null)
//                    globalLockProperty = GetBooleanProperty("Vendor.GlobalLock");
//                globalLockProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> minOrderValueProperty;
//        public decimal Min_Order_Value
//        {
//            get
//            {
//                if (minOrderValueProperty == null)
//                    minOrderValueProperty = GetDecimalProperty("Vendor.Min_Order_Value");
//                return minOrderValueProperty.Value;
//            }
//            set
//            {
//                if (minOrderValueProperty == null)
//                    minOrderValueProperty = GetDecimalProperty("Vendor.Min_Order_Value");
//                minOrderValueProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> calendarIDProperty;
//        public string CalendarID
//        {
//            get
//            {
//                if (calendarIDProperty == null)
//                    calendarIDProperty = GetStringProperty("Vendor.CalendarID");
//                return calendarIDProperty.Value;
//            }
//            set
//            {
//                if (calendarIDProperty == null)
//                    calendarIDProperty = GetStringProperty("Vendor.CalendarID");
//                calendarIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eDICodeProperty;
//        public string EDICode
//        {
//            get
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("Vendor.EDICode");
//                return eDICodeProperty.Value;
//            }
//            set
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("Vendor.EDICode");
//                eDICodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> localPurchasingProperty;
//        public bool LocalPurchasing
//        {
//            get
//            {
//                if (localPurchasingProperty == null)
//                    localPurchasingProperty = GetBooleanProperty("Vendor.LocalPurchasing");
//                return localPurchasingProperty.Value;
//            }
//            set
//            {
//                if (localPurchasingProperty == null)
//                    localPurchasingProperty = GetBooleanProperty("Vendor.LocalPurchasing");
//                localPurchasingProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> consolidatedPurchasingProperty;
//        public bool ConsolidatedPurchasing
//        {
//            get
//            {
//                if (consolidatedPurchasingProperty == null)
//                    consolidatedPurchasingProperty = GetBooleanProperty("Vendor.ConsolidatedPurchasing");
//                return consolidatedPurchasingProperty.Value;
//            }
//            set
//            {
//                if (consolidatedPurchasingProperty == null)
//                    consolidatedPurchasingProperty = GetBooleanProperty("Vendor.ConsolidatedPurchasing");
//                consolidatedPurchasingProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> satDeliveryProperty;
//        public bool SatDelivery
//        {
//            get
//            {
//                if (satDeliveryProperty == null)
//                    satDeliveryProperty = GetBooleanProperty("Vendor.SatDelivery");
//                return satDeliveryProperty.Value;
//            }
//            set
//            {
//                if (satDeliveryProperty == null)
//                    satDeliveryProperty = GetBooleanProperty("Vendor.SatDelivery");
//                satDeliveryProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> satPickupProperty;
//        public bool SatPickup
//        {
//            get
//            {
//                if (satPickupProperty == null)
//                    satPickupProperty = GetBooleanProperty("Vendor.SatPickup");
//                return satPickupProperty.Value;
//            }
//            set
//            {
//                if (satPickupProperty == null)
//                    satPickupProperty = GetBooleanProperty("Vendor.SatPickup");
//                satPickupProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> hazmatProperty;
//        public bool Hazmat
//        {
//            get
//            {
//                if (hazmatProperty == null)
//                    hazmatProperty = GetBooleanProperty("Vendor.Hazmat");
//                return hazmatProperty.Value;
//            }
//            set
//            {
//                if (hazmatProperty == null)
//                    hazmatProperty = GetBooleanProperty("Vendor.Hazmat");
//                hazmatProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> docOnlyProperty;
//        public bool DocOnly
//        {
//            get
//            {
//                if (docOnlyProperty == null)
//                    docOnlyProperty = GetBooleanProperty("Vendor.DocOnly");
//                return docOnlyProperty.Value;
//            }
//            set
//            {
//                if (docOnlyProperty == null)
//                    docOnlyProperty = GetBooleanProperty("Vendor.DocOnly");
//                docOnlyProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refNotesProperty;
//        public string RefNotes
//        {
//            get
//            {
//                if (refNotesProperty == null)
//                    refNotesProperty = GetStringProperty("Vendor.RefNotes");
//                return refNotesProperty.Value;
//            }
//            set
//            {
//                if (refNotesProperty == null)
//                    refNotesProperty = GetStringProperty("Vendor.RefNotes");
//                refNotesProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> applyChrgProperty;
//        public bool ApplyChrg
//        {
//            get
//            {
//                if (applyChrgProperty == null)
//                    applyChrgProperty = GetBooleanProperty("Vendor.ApplyChrg");
//                return applyChrgProperty.Value;
//            }
//            set
//            {
//                if (applyChrgProperty == null)
//                    applyChrgProperty = GetBooleanProperty("Vendor.ApplyChrg");
//                applyChrgProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> chrgAmountProperty;
//        public decimal ChrgAmount
//        {
//            get
//            {
//                if (chrgAmountProperty == null)
//                    chrgAmountProperty = GetDecimalProperty("Vendor.ChrgAmount");
//                return chrgAmountProperty.Value;
//            }
//            set
//            {
//                if (chrgAmountProperty == null)
//                    chrgAmountProperty = GetDecimalProperty("Vendor.ChrgAmount");
//                chrgAmountProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> codProperty;
//        public bool COD
//        {
//            get
//            {
//                if (codProperty == null)
//                    codProperty = GetBooleanProperty("Vendor.COD");
//                return codProperty.Value;
//            }
//            set
//            {
//                if (codProperty == null)
//                    codProperty = GetBooleanProperty("Vendor.COD");
//                codProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> cODFreightProperty;
//        public bool CODFreight
//        {
//            get
//            {
//                if (cODFreightProperty == null)
//                    cODFreightProperty = GetBooleanProperty("Vendor.CODFreight");
//                return cODFreightProperty.Value;
//            }
//            set
//            {
//                if (cODFreightProperty == null)
//                    cODFreightProperty = GetBooleanProperty("Vendor.CODFreight");
//                cODFreightProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> cODCheckProperty;
//        public bool CODCheck
//        {
//            get
//            {
//                if (cODCheckProperty == null)
//                    cODCheckProperty = GetBooleanProperty("Vendor.CODCheck");
//                return cODCheckProperty.Value;
//            }
//            set
//            {
//                if (cODCheckProperty == null)
//                    cODCheckProperty = GetBooleanProperty("Vendor.CODCheck");
//                cODCheckProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> cODAmountProperty;
//        public decimal CODAmount
//        {
//            get
//            {
//                if (cODAmountProperty == null)
//                    cODAmountProperty = GetDecimalProperty("Vendor.CODAmount");
//                return cODAmountProperty.Value;
//            }
//            set
//            {
//                if (cODAmountProperty == null)
//                    cODAmountProperty = GetDecimalProperty("Vendor.CODAmount");
//                cODAmountProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> groundTypeProperty;
//        public string GroundType
//        {
//            get
//            {
//                if (groundTypeProperty == null)
//                    groundTypeProperty = GetStringProperty("Vendor.GroundType");
//                return groundTypeProperty.Value;
//            }
//            set
//            {
//                if (groundTypeProperty == null)
//                    groundTypeProperty = GetStringProperty("Vendor.GroundType");
//                groundTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> notifyFlagProperty;
//        public bool NotifyFlag
//        {
//            get
//            {
//                if (notifyFlagProperty == null)
//                    notifyFlagProperty = GetBooleanProperty("Vendor.NotifyFlag");
//                return notifyFlagProperty.Value;
//            }
//            set
//            {
//                if (notifyFlagProperty == null)
//                    notifyFlagProperty = GetBooleanProperty("Vendor.NotifyFlag");
//                notifyFlagProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> notifyEMailProperty;
//        public string NotifyEMail
//        {
//            get
//            {
//                if (notifyEMailProperty == null)
//                    notifyEMailProperty = GetStringProperty("Vendor.NotifyEMail");
//                return notifyEMailProperty.Value;
//            }
//            set
//            {
//                if (notifyEMailProperty == null)
//                    notifyEMailProperty = GetStringProperty("Vendor.NotifyEMail");
//                notifyEMailProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> declaredInsProperty;
//        public bool DeclaredIns
//        {
//            get
//            {
//                if (declaredInsProperty == null)
//                    declaredInsProperty = GetBooleanProperty("Vendor.DeclaredIns");
//                return declaredInsProperty.Value;
//            }
//            set
//            {
//                if (declaredInsProperty == null)
//                    declaredInsProperty = GetBooleanProperty("Vendor.DeclaredIns");
//                declaredInsProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> declaredAmtProperty;
//        public decimal DeclaredAmt
//        {
//            get
//            {
//                if (declaredAmtProperty == null)
//                    declaredAmtProperty = GetDecimalProperty("Vendor.DeclaredAmt");
//                return declaredAmtProperty.Value;
//            }
//            set
//            {
//                if (declaredAmtProperty == null)
//                    declaredAmtProperty = GetDecimalProperty("Vendor.DeclaredAmt");
//                declaredAmtProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> resDeliveryProperty;
//        public bool ResDelivery
//        {
//            get
//            {
//                if (resDeliveryProperty == null)
//                    resDeliveryProperty = GetBooleanProperty("Vendor.ResDelivery");
//                return resDeliveryProperty.Value;
//            }
//            set
//            {
//                if (resDeliveryProperty == null)
//                    resDeliveryProperty = GetBooleanProperty("Vendor.ResDelivery");
//                resDeliveryProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servSignatureProperty;
//        public bool ServSignature
//        {
//            get
//            {
//                if (servSignatureProperty == null)
//                    servSignatureProperty = GetBooleanProperty("Vendor.ServSignature");
//                return servSignatureProperty.Value;
//            }
//            set
//            {
//                if (servSignatureProperty == null)
//                    servSignatureProperty = GetBooleanProperty("Vendor.ServSignature");
//                servSignatureProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servAlertProperty;
//        public bool ServAlert
//        {
//            get
//            {
//                if (servAlertProperty == null)
//                    servAlertProperty = GetBooleanProperty("Vendor.ServAlert");
//                return servAlertProperty.Value;
//            }
//            set
//            {
//                if (servAlertProperty == null)
//                    servAlertProperty = GetBooleanProperty("Vendor.ServAlert");
//                servAlertProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servHomeDelProperty;
//        public bool ServHomeDel
//        {
//            get
//            {
//                if (servHomeDelProperty == null)
//                    servHomeDelProperty = GetBooleanProperty("Vendor.ServHomeDel");
//                return servHomeDelProperty.Value;
//            }
//            set
//            {
//                if (servHomeDelProperty == null)
//                    servHomeDelProperty = GetBooleanProperty("Vendor.ServHomeDel");
//                servHomeDelProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> deliveryTypeProperty;
//        public string DeliveryType
//        {
//            get
//            {
//                if (deliveryTypeProperty == null)
//                    deliveryTypeProperty = GetStringProperty("Vendor.DeliveryType");
//                return deliveryTypeProperty.Value;
//            }
//            set
//            {
//                if (deliveryTypeProperty == null)
//                    deliveryTypeProperty = GetStringProperty("Vendor.DeliveryType");
//                deliveryTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> servDeliveryDateProperty;
//        public DateTime ServDeliveryDate
//        {
//            get
//            {
//                if (servDeliveryDateProperty == null)
//                    servDeliveryDateProperty = GetDateTimeProperty("Vendor.ServDeliveryDate");
//                return servDeliveryDateProperty.Value;
//            }
//            set
//            {
//                if (servDeliveryDateProperty == null)
//                    servDeliveryDateProperty = GetDateTimeProperty("Vendor.ServDeliveryDate");
//                servDeliveryDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servPhoneProperty;
//        public string ServPhone
//        {
//            get
//            {
//                if (servPhoneProperty == null)
//                    servPhoneProperty = GetStringProperty("Vendor.ServPhone");
//                return servPhoneProperty.Value;
//            }
//            set
//            {
//                if (servPhoneProperty == null)
//                    servPhoneProperty = GetStringProperty("Vendor.ServPhone");
//                servPhoneProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servInstructProperty;
//        public string ServInstruct
//        {
//            get
//            {
//                if (servInstructProperty == null)
//                    servInstructProperty = GetStringProperty("Vendor.ServInstruct");
//                return servInstructProperty.Value;
//            }
//            set
//            {
//                if (servInstructProperty == null)
//                    servInstructProperty = GetStringProperty("Vendor.ServInstruct");
//                servInstructProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servReleaseProperty;
//        public bool ServRelease
//        {
//            get
//            {
//                if (servReleaseProperty == null)
//                    servReleaseProperty = GetBooleanProperty("Vendor.ServRelease");
//                return servReleaseProperty.Value;
//            }
//            set
//            {
//                if (servReleaseProperty == null)
//                    servReleaseProperty = GetBooleanProperty("Vendor.ServRelease");
//                servReleaseProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servAuthNumProperty;
//        public string ServAuthNum
//        {
//            get
//            {
//                if (servAuthNumProperty == null)
//                    servAuthNumProperty = GetStringProperty("Vendor.ServAuthNum");
//                return servAuthNumProperty.Value;
//            }
//            set
//            {
//                if (servAuthNumProperty == null)
//                    servAuthNumProperty = GetStringProperty("Vendor.ServAuthNum");
//                servAuthNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef1Property;
//        public string ServRef1
//        {
//            get
//            {
//                if (servRef1Property == null)
//                    servRef1Property = GetStringProperty("Vendor.ServRef1");
//                return servRef1Property.Value;
//            }
//            set
//            {
//                if (servRef1Property == null)
//                    servRef1Property = GetStringProperty("Vendor.ServRef1");
//                servRef1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef2Property;
//        public string ServRef2
//        {
//            get
//            {
//                if (servRef2Property == null)
//                    servRef2Property = GetStringProperty("Vendor.ServRef2");
//                return servRef2Property.Value;
//            }
//            set
//            {
//                if (servRef2Property == null)
//                    servRef2Property = GetStringProperty("Vendor.ServRef2");
//                servRef2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef3Property;
//        public string ServRef3
//        {
//            get
//            {
//                if (servRef3Property == null)
//                    servRef3Property = GetStringProperty("Vendor.ServRef3");
//                return servRef3Property.Value;
//            }
//            set
//            {
//                if (servRef3Property == null)
//                    servRef3Property = GetStringProperty("Vendor.ServRef3");
//                servRef3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef4Property;
//        public string ServRef4
//        {
//            get
//            {
//                if (servRef4Property == null)
//                    servRef4Property = GetStringProperty("Vendor.ServRef4");
//                return servRef4Property.Value;
//            }
//            set
//            {
//                if (servRef4Property == null)
//                    servRef4Property = GetStringProperty("Vendor.ServRef4");
//                servRef4Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef5Property;
//        public string ServRef5
//        {
//            get
//            {
//                if (servRef5Property == null)
//                    servRef5Property = GetStringProperty("Vendor.ServRef5");
//                return servRef5Property.Value;
//            }
//            set
//            {
//                if (servRef5Property == null)
//                    servRef5Property = GetStringProperty("Vendor.ServRef5");
//                servRef5Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> cPayProperty;
//        public bool CPay
//        {
//            get
//            {
//                if (cPayProperty == null)
//                    cPayProperty = GetBooleanProperty("Vendor.CPay");
//                return cPayProperty.Value;
//            }
//            set
//            {
//                if (cPayProperty == null)
//                    cPayProperty = GetBooleanProperty("Vendor.CPay");
//                cPayProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> intrntlShipProperty;
//        public bool IntrntlShip
//        {
//            get
//            {
//                if (intrntlShipProperty == null)
//                    intrntlShipProperty = GetBooleanProperty("Vendor.IntrntlShip");
//                return intrntlShipProperty.Value;
//            }
//            set
//            {
//                if (intrntlShipProperty == null)
//                    intrntlShipProperty = GetBooleanProperty("Vendor.IntrntlShip");
//                intrntlShipProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> certOfOriginProperty;
//        public bool CertOfOrigin
//        {
//            get
//            {
//                if (certOfOriginProperty == null)
//                    certOfOriginProperty = GetBooleanProperty("Vendor.CertOfOrigin");
//                return certOfOriginProperty.Value;
//            }
//            set
//            {
//                if (certOfOriginProperty == null)
//                    certOfOriginProperty = GetBooleanProperty("Vendor.CertOfOrigin");
//                certOfOriginProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> commercialInvoiceProperty;
//        public bool CommercialInvoice
//        {
//            get
//            {
//                if (commercialInvoiceProperty == null)
//                    commercialInvoiceProperty = GetBooleanProperty("Vendor.CommercialInvoice");
//                return commercialInvoiceProperty.Value;
//            }
//            set
//            {
//                if (commercialInvoiceProperty == null)
//                    commercialInvoiceProperty = GetBooleanProperty("Vendor.CommercialInvoice");
//                commercialInvoiceProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> shipExprtDeclartnProperty;
//        public bool ShipExprtDeclartn
//        {
//            get
//            {
//                if (shipExprtDeclartnProperty == null)
//                    shipExprtDeclartnProperty = GetBooleanProperty("Vendor.ShipExprtDeclartn");
//                return shipExprtDeclartnProperty.Value;
//            }
//            set
//            {
//                if (shipExprtDeclartnProperty == null)
//                    shipExprtDeclartnProperty = GetBooleanProperty("Vendor.ShipExprtDeclartn");
//                shipExprtDeclartnProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> letterOfInstrProperty;
//        public bool LetterOfInstr
//        {
//            get
//            {
//                if (letterOfInstrProperty == null)
//                    letterOfInstrProperty = GetBooleanProperty("Vendor.LetterOfInstr");
//                return letterOfInstrProperty.Value;
//            }
//            set
//            {
//                if (letterOfInstrProperty == null)
//                    letterOfInstrProperty = GetBooleanProperty("Vendor.LetterOfInstr");
//                letterOfInstrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> ffidProperty;
//        public string FFID
//        {
//            get
//            {
//                if (ffidProperty == null)
//                    ffidProperty = GetStringProperty("Vendor.FFID");
//                return ffidProperty.Value;
//            }
//            set
//            {
//                if (ffidProperty == null)
//                    ffidProperty = GetStringProperty("Vendor.FFID");
//                ffidProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFCompNameProperty;
//        public string FFCompName
//        {
//            get
//            {
//                if (fFCompNameProperty == null)
//                    fFCompNameProperty = GetStringProperty("Vendor.FFCompName");
//                return fFCompNameProperty.Value;
//            }
//            set
//            {
//                if (fFCompNameProperty == null)
//                    fFCompNameProperty = GetStringProperty("Vendor.FFCompName");
//                fFCompNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFContactProperty;
//        public string FFContact
//        {
//            get
//            {
//                if (fFContactProperty == null)
//                    fFContactProperty = GetStringProperty("Vendor.FFContact");
//                return fFContactProperty.Value;
//            }
//            set
//            {
//                if (fFContactProperty == null)
//                    fFContactProperty = GetStringProperty("Vendor.FFContact");
//                fFContactProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFAddress1Property;
//        public string FFAddress1
//        {
//            get
//            {
//                if (fFAddress1Property == null)
//                    fFAddress1Property = GetStringProperty("Vendor.FFAddress1");
//                return fFAddress1Property.Value;
//            }
//            set
//            {
//                if (fFAddress1Property == null)
//                    fFAddress1Property = GetStringProperty("Vendor.FFAddress1");
//                fFAddress1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> fFAddress2Property;
//        public string FFAddress2
//        {
//            get
//            {
//                if (fFAddress2Property == null)
//                    fFAddress2Property = GetStringProperty("Vendor.FFAddress2");
//                return fFAddress2Property.Value;
//            }
//            set
//            {
//                if (fFAddress2Property == null)
//                    fFAddress2Property = GetStringProperty("Vendor.FFAddress2");
//                fFAddress2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> fFAddress3Property;
//        public string FFAddress3
//        {
//            get
//            {
//                if (fFAddress3Property == null)
//                    fFAddress3Property = GetStringProperty("Vendor.FFAddress3");
//                return fFAddress3Property.Value;
//            }
//            set
//            {
//                if (fFAddress3Property == null)
//                    fFAddress3Property = GetStringProperty("Vendor.FFAddress3");
//                fFAddress3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> fFCityProperty;
//        public string FFCity
//        {
//            get
//            {
//                if (fFCityProperty == null)
//                    fFCityProperty = GetStringProperty("Vendor.FFCity");
//                return fFCityProperty.Value;
//            }
//            set
//            {
//                if (fFCityProperty == null)
//                    fFCityProperty = GetStringProperty("Vendor.FFCity");
//                fFCityProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFStateProperty;
//        public string FFState
//        {
//            get
//            {
//                if (fFStateProperty == null)
//                    fFStateProperty = GetStringProperty("Vendor.FFState");
//                return fFStateProperty.Value;
//            }
//            set
//            {
//                if (fFStateProperty == null)
//                    fFStateProperty = GetStringProperty("Vendor.FFState");
//                fFStateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFZipProperty;
//        public string FFZip
//        {
//            get
//            {
//                if (fFZipProperty == null)
//                    fFZipProperty = GetStringProperty("Vendor.FFZip");
//                return fFZipProperty.Value;
//            }
//            set
//            {
//                if (fFZipProperty == null)
//                    fFZipProperty = GetStringProperty("Vendor.FFZip");
//                fFZipProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFCountryProperty;
//        public string FFCountry
//        {
//            get
//            {
//                if (fFCountryProperty == null)
//                    fFCountryProperty = GetStringProperty("Vendor.FFCountry");
//                return fFCountryProperty.Value;
//            }
//            set
//            {
//                if (fFCountryProperty == null)
//                    fFCountryProperty = GetStringProperty("Vendor.FFCountry");
//                fFCountryProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> nonStdPkgProperty;
//        public bool NonStdPkg
//        {
//            get
//            {
//                if (nonStdPkgProperty == null)
//                    nonStdPkgProperty = GetBooleanProperty("Vendor.NonStdPkg");
//                return nonStdPkgProperty.Value;
//            }
//            set
//            {
//                if (nonStdPkgProperty == null)
//                    nonStdPkgProperty = GetBooleanProperty("Vendor.NonStdPkg");
//                nonStdPkgProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> deliveryConfProperty;
//        public int DeliveryConf
//        {
//            get
//            {
//                if (deliveryConfProperty == null)
//                    deliveryConfProperty = GetIntegerProperty("Vendor.DeliveryConf");
//                return deliveryConfProperty.Value;
//            }
//            set
//            {
//                if (deliveryConfProperty == null)
//                    deliveryConfProperty = GetIntegerProperty("Vendor.DeliveryConf");
//                deliveryConfProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> addlHdlgFlagProperty;
//        public bool AddlHdlgFlag
//        {
//            get
//            {
//                if (addlHdlgFlagProperty == null)
//                    addlHdlgFlagProperty = GetBooleanProperty("Vendor.AddlHdlgFlag");
//                return addlHdlgFlagProperty.Value;
//            }
//            set
//            {
//                if (addlHdlgFlagProperty == null)
//                    addlHdlgFlagProperty = GetBooleanProperty("Vendor.AddlHdlgFlag");
//                addlHdlgFlagProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> individualPackIDsProperty;
//        public bool IndividualPackIDs
//        {
//            get
//            {
//                if (individualPackIDsProperty == null)
//                    individualPackIDsProperty = GetBooleanProperty("Vendor.IndividualPackIDs");
//                return individualPackIDsProperty.Value;
//            }
//            set
//            {
//                if (individualPackIDsProperty == null)
//                    individualPackIDsProperty = GetBooleanProperty("Vendor.IndividualPackIDs");
//                individualPackIDsProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> uPSQVShipFromNameProperty;
//        public string UPSQVShipFromName
//        {
//            get
//            {
//                if (uPSQVShipFromNameProperty == null)
//                    uPSQVShipFromNameProperty = GetStringProperty("Vendor.UPSQVShipFromName");
//                return uPSQVShipFromNameProperty.Value;
//            }
//            set
//            {
//                if (uPSQVShipFromNameProperty == null)
//                    uPSQVShipFromNameProperty = GetStringProperty("Vendor.UPSQVShipFromName");
//                uPSQVShipFromNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> uPSQVMemoProperty;
//        public string UPSQVMemo
//        {
//            get
//            {
//                if (uPSQVMemoProperty == null)
//                    uPSQVMemoProperty = GetStringProperty("Vendor.UPSQVMemo");
//                return uPSQVMemoProperty.Value;
//            }
//            set
//            {
//                if (uPSQVMemoProperty == null)
//                    uPSQVMemoProperty = GetStringProperty("Vendor.UPSQVMemo");
//                uPSQVMemoProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> uPSQuantumViewProperty;
//        public bool UPSQuantumView
//        {
//            get
//            {
//                if (uPSQuantumViewProperty == null)
//                    uPSQuantumViewProperty = GetBooleanProperty("Vendor.UPSQuantumView");
//                return uPSQuantumViewProperty.Value;
//            }
//            set
//            {
//                if (uPSQuantumViewProperty == null)
//                    uPSQuantumViewProperty = GetBooleanProperty("Vendor.UPSQuantumView");
//                uPSQuantumViewProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> fFCountryNumProperty;
//        public int FFCountryNum
//        {
//            get
//            {
//                if (fFCountryNumProperty == null)
//                    fFCountryNumProperty = GetIntegerProperty("Vendor.FFCountryNum");
//                return fFCountryNumProperty.Value;
//            }
//            set
//            {
//                if (fFCountryNumProperty == null)
//                    fFCountryNumProperty = GetIntegerProperty("Vendor.FFCountryNum");
//                fFCountryNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFPhoneNumProperty;
//        public string FFPhoneNum
//        {
//            get
//            {
//                if (fFPhoneNumProperty == null)
//                    fFPhoneNumProperty = GetStringProperty("Vendor.FFPhoneNum");
//                return fFPhoneNumProperty.Value;
//            }
//            set
//            {
//                if (fFPhoneNumProperty == null)
//                    fFPhoneNumProperty = GetStringProperty("Vendor.FFPhoneNum");
//                fFPhoneNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> revChargeMethodProperty;
//        public string RevChargeMethod
//        {
//            get
//            {
//                if (revChargeMethodProperty == null)
//                    revChargeMethodProperty = GetStringProperty("Vendor.RevChargeMethod");
//                return revChargeMethodProperty.Value;
//            }
//            set
//            {
//                if (revChargeMethodProperty == null)
//                    revChargeMethodProperty = GetStringProperty("Vendor.RevChargeMethod");
//                revChargeMethodProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #region VendorPP Table

//    //[Serializable()]
//    //public partial class VendorPP : SFEpic.Data.EditTable<VendorPP>
//    //{
//    //    public VendorPP() : base() { }

//    //    new protected static Schema.VendorPP schemaTable;
//    //    new public static Schema.VendorPP SchemaTable
//    //    {
//    //        get
//    //        {
//    //            if (schemaTable == null)
//    //            {
//    //                schemaTable = (Schema.VendorPP)V8Schema.Instance.TablesDictionary["VendorPP"];
//    //            }
//    //            return schemaTable;
//    //        }
//    //    }

//    //    #region Fill Methods

//    //    protected static ICriteriaValue[] fillByCompanyNumCriteria;
//    //    public static VendorPP FillByCompanyNum(DataContext context, string companyNum, params string[] columnNames)
//    //    {
//    //        if (fillByCompanyNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.CompanyNum]));
//    //            fillByCompanyNumCriteria = list.ToArray();
//    //        }
//    //        fillByCompanyNumCriteria[0].Value = companyNum;
//    //        return VendorPP.Fetch(context, fillByCompanyNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByVendorNumCriteria;
//    //    public static VendorPP FillByVendorNum(DataContext context, string companyNum, int vendorNum, params string[] columnNames)
//    //    {
//    //        if (fillByVendorNumCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.CompanyNum]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.VendorPP.VendorNum]));
//    //            fillByVendorNumCriteria = list.ToArray();
//    //        }
//    //        fillByVendorNumCriteria[0].Value = companyNum;
//    //        fillByVendorNumCriteria[1].Value = vendorNum;
//    //        return VendorPP.Fetch(context, fillByVendorNumCriteria, columnNames);
//    //    }

//    //    protected static ICriteriaValue[] fillByPurPointCriteria;
//    //    public static VendorPP FillByPurPoint(DataContext context, string companyNum, int vendorNum, string purPoint, params string[] columnNames)
//    //    {
//    //        if (fillByPurPointCriteria == null)
//    //        {
//    //            var list = new List<ICriteriaValue>();
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.CompanyNum]));
//    //            list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.VendorPP.VendorNum]));
//    //            list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.VendorPP.PurPoint]));
//    //            fillByPurPointCriteria = list.ToArray();
//    //        }
//    //        fillByPurPointCriteria[0].Value = companyNum;
//    //        fillByPurPointCriteria[1].Value = vendorNum;
//    //        fillByPurPointCriteria[2].Value = purPoint;
//    //        return VendorPP.Fetch(context, fillByPurPointCriteria, columnNames);
//    //    }

//    //    #endregion

//    //    protected override DataRow GetNewDataRowCore()
//    //    {
//    //        return new VendorPPRow();
//    //    }

//    //    protected override void InitRowLists()
//    //    {
//    //        var vendorPPRowsList = new ObservableCollection<VendorPPRow>();
//    //        rowsList = vendorPPRowsList;
//    //        rows = new ReadOnlyObservableCollection<VendorPPRow>(vendorPPRowsList);
//    //        readOnlyRowsList = rows;
//    //    }

//    //    protected ReadOnlyObservableCollection<VendorPPRow> rows;
//    //    new public ReadOnlyObservableCollection<VendorPPRow> Rows
//    //    {
//    //        get
//    //        {
//    //            return rows;
//    //        }
//    //    }

//    //    public VendorPPRow this[int index]
//    //    {
//    //        get
//    //        {
//    //            return rows[index];
//    //        }
//    //    }
//    //}

//    #region VendorPPRow

//    [Serializable()]
//    public class VendorPPRow : DataRow
//    {
//        protected RowProperty<string> companyNumProperty;
//        public string CompanyNum
//        {
//            get
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("VendorPP.CompanyNum");
//                return companyNumProperty.Value;
//            }
//            set
//            {
//                if (companyNumProperty == null)
//                    companyNumProperty = GetStringProperty("VendorPP.CompanyNum");
//                companyNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> purPointProperty;
//        public string PurPoint
//        {
//            get
//            {
//                if (purPointProperty == null)
//                    purPointProperty = GetStringProperty("VendorPP.PurPoint");
//                return purPointProperty.Value;
//            }
//            set
//            {
//                if (purPointProperty == null)
//                    purPointProperty = GetStringProperty("VendorPP.PurPoint");
//                purPointProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> vendorNumProperty;
//        public int VendorNum
//        {
//            get
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("VendorPP.VendorNum");
//                return vendorNumProperty.Value;
//            }
//            set
//            {
//                if (vendorNumProperty == null)
//                    vendorNumProperty = GetIntegerProperty("VendorPP.VendorNum");
//                vendorNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> address1Property;
//        public string Address1
//        {
//            get
//            {
//                if (address1Property == null)
//                    address1Property = GetStringProperty("VendorPP.Address1");
//                return address1Property.Value;
//            }
//            set
//            {
//                if (address1Property == null)
//                    address1Property = GetStringProperty("VendorPP.Address1");
//                address1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> address2Property;
//        public string Address2
//        {
//            get
//            {
//                if (address2Property == null)
//                    address2Property = GetStringProperty("VendorPP.Address2");
//                return address2Property.Value;
//            }
//            set
//            {
//                if (address2Property == null)
//                    address2Property = GetStringProperty("VendorPP.Address2");
//                address2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> cityProperty;
//        public string City
//        {
//            get
//            {
//                if (cityProperty == null)
//                    cityProperty = GetStringProperty("VendorPP.City");
//                return cityProperty.Value;
//            }
//            set
//            {
//                if (cityProperty == null)
//                    cityProperty = GetStringProperty("VendorPP.City");
//                cityProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> countryProperty;
//        public string Country
//        {
//            get
//            {
//                if (countryProperty == null)
//                    countryProperty = GetStringProperty("VendorPP.Country");
//                return countryProperty.Value;
//            }
//            set
//            {
//                if (countryProperty == null)
//                    countryProperty = GetStringProperty("VendorPP.Country");
//                countryProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> nameProperty;
//        public string Name
//        {
//            get
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("VendorPP.Name");
//                return nameProperty.Value;
//            }
//            set
//            {
//                if (nameProperty == null)
//                    nameProperty = GetStringProperty("VendorPP.Name");
//                nameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> stateProperty;
//        public string State
//        {
//            get
//            {
//                if (stateProperty == null)
//                    stateProperty = GetStringProperty("VendorPP.State");
//                return stateProperty.Value;
//            }
//            set
//            {
//                if (stateProperty == null)
//                    stateProperty = GetStringProperty("VendorPP.State");
//                stateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> zipProperty;
//        public string Zip
//        {
//            get
//            {
//                if (zipProperty == null)
//                    zipProperty = GetStringProperty("VendorPP.Zip");
//                return zipProperty.Value;
//            }
//            set
//            {
//                if (zipProperty == null)
//                    zipProperty = GetStringProperty("VendorPP.Zip");
//                zipProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> address3Property;
//        public string Address3
//        {
//            get
//            {
//                if (address3Property == null)
//                    address3Property = GetStringProperty("VendorPP.Address3");
//                return address3Property.Value;
//            }
//            set
//            {
//                if (address3Property == null)
//                    address3Property = GetStringProperty("VendorPP.Address3");
//                address3Property.Value = value;
//            }
//        }

//        protected RowProperty<int> primPConProperty;
//        public int PrimPCon
//        {
//            get
//            {
//                if (primPConProperty == null)
//                    primPConProperty = GetIntegerProperty("VendorPP.PrimPCon");
//                return primPConProperty.Value;
//            }
//            set
//            {
//                if (primPConProperty == null)
//                    primPConProperty = GetIntegerProperty("VendorPP.PrimPCon");
//                primPConProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> langNameIDProperty;
//        public string LangNameID
//        {
//            get
//            {
//                if (langNameIDProperty == null)
//                    langNameIDProperty = GetStringProperty("VendorPP.LangNameID");
//                return langNameIDProperty.Value;
//            }
//            set
//            {
//                if (langNameIDProperty == null)
//                    langNameIDProperty = GetStringProperty("VendorPP.LangNameID");
//                langNameIDProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> countryNumProperty;
//        public int CountryNum
//        {
//            get
//            {
//                if (countryNumProperty == null)
//                    countryNumProperty = GetIntegerProperty("VendorPP.CountryNum");
//                return countryNumProperty.Value;
//            }
//            set
//            {
//                if (countryNumProperty == null)
//                    countryNumProperty = GetIntegerProperty("VendorPP.CountryNum");
//                countryNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> formatStrProperty;
//        public string FormatStr
//        {
//            get
//            {
//                if (formatStrProperty == null)
//                    formatStrProperty = GetStringProperty("VendorPP.FormatStr");
//                return formatStrProperty.Value;
//            }
//            set
//            {
//                if (formatStrProperty == null)
//                    formatStrProperty = GetStringProperty("VendorPP.FormatStr");
//                formatStrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> borderCrossingProperty;
//        public string BorderCrossing
//        {
//            get
//            {
//                if (borderCrossingProperty == null)
//                    borderCrossingProperty = GetStringProperty("VendorPP.BorderCrossing");
//                return borderCrossingProperty.Value;
//            }
//            set
//            {
//                if (borderCrossingProperty == null)
//                    borderCrossingProperty = GetStringProperty("VendorPP.BorderCrossing");
//                borderCrossingProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eMailAddressProperty;
//        public string EMailAddress
//        {
//            get
//            {
//                if (eMailAddressProperty == null)
//                    eMailAddressProperty = GetStringProperty("VendorPP.EMailAddress");
//                return eMailAddressProperty.Value;
//            }
//            set
//            {
//                if (eMailAddressProperty == null)
//                    eMailAddressProperty = GetStringProperty("VendorPP.EMailAddress");
//                eMailAddressProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> externalIdProperty;
//        public string ExternalId
//        {
//            get
//            {
//                if (externalIdProperty == null)
//                    externalIdProperty = GetStringProperty("VendorPP.ExternalId");
//                return externalIdProperty.Value;
//            }
//            set
//            {
//                if (externalIdProperty == null)
//                    externalIdProperty = GetStringProperty("VendorPP.ExternalId");
//                externalIdProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> taxAuthorityCodeProperty;
//        public string TaxAuthorityCode
//        {
//            get
//            {
//                if (taxAuthorityCodeProperty == null)
//                    taxAuthorityCodeProperty = GetStringProperty("VendorPP.TaxAuthorityCode");
//                return taxAuthorityCodeProperty.Value;
//            }
//            set
//            {
//                if (taxAuthorityCodeProperty == null)
//                    taxAuthorityCodeProperty = GetStringProperty("VendorPP.TaxAuthorityCode");
//                taxAuthorityCodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> globalLockProperty;
//        public bool GlobalLock
//        {
//            get
//            {
//                if (globalLockProperty == null)
//                    globalLockProperty = GetBooleanProperty("VendorPP.GlobalLock");
//                return globalLockProperty.Value;
//            }
//            set
//            {
//                if (globalLockProperty == null)
//                    globalLockProperty = GetBooleanProperty("VendorPP.GlobalLock");
//                globalLockProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> eDICodeProperty;
//        public string EDICode
//        {
//            get
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("VendorPP.EDICode");
//                return eDICodeProperty.Value;
//            }
//            set
//            {
//                if (eDICodeProperty == null)
//                    eDICodeProperty = GetStringProperty("VendorPP.EDICode");
//                eDICodeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> resDeliveryProperty;
//        public bool ResDelivery
//        {
//            get
//            {
//                if (resDeliveryProperty == null)
//                    resDeliveryProperty = GetBooleanProperty("VendorPP.ResDelivery");
//                return resDeliveryProperty.Value;
//            }
//            set
//            {
//                if (resDeliveryProperty == null)
//                    resDeliveryProperty = GetBooleanProperty("VendorPP.ResDelivery");
//                resDeliveryProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> satDeliveryProperty;
//        public bool SatDelivery
//        {
//            get
//            {
//                if (satDeliveryProperty == null)
//                    satDeliveryProperty = GetBooleanProperty("VendorPP.SatDelivery");
//                return satDeliveryProperty.Value;
//            }
//            set
//            {
//                if (satDeliveryProperty == null)
//                    satDeliveryProperty = GetBooleanProperty("VendorPP.SatDelivery");
//                satDeliveryProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> satPickupProperty;
//        public bool SatPickup
//        {
//            get
//            {
//                if (satPickupProperty == null)
//                    satPickupProperty = GetBooleanProperty("VendorPP.SatPickup");
//                return satPickupProperty.Value;
//            }
//            set
//            {
//                if (satPickupProperty == null)
//                    satPickupProperty = GetBooleanProperty("VendorPP.SatPickup");
//                satPickupProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> hazmatProperty;
//        public bool Hazmat
//        {
//            get
//            {
//                if (hazmatProperty == null)
//                    hazmatProperty = GetBooleanProperty("VendorPP.Hazmat");
//                return hazmatProperty.Value;
//            }
//            set
//            {
//                if (hazmatProperty == null)
//                    hazmatProperty = GetBooleanProperty("VendorPP.Hazmat");
//                hazmatProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> docOnlyProperty;
//        public bool DocOnly
//        {
//            get
//            {
//                if (docOnlyProperty == null)
//                    docOnlyProperty = GetBooleanProperty("VendorPP.DocOnly");
//                return docOnlyProperty.Value;
//            }
//            set
//            {
//                if (docOnlyProperty == null)
//                    docOnlyProperty = GetBooleanProperty("VendorPP.DocOnly");
//                docOnlyProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> refNotesProperty;
//        public string RefNotes
//        {
//            get
//            {
//                if (refNotesProperty == null)
//                    refNotesProperty = GetStringProperty("VendorPP.RefNotes");
//                return refNotesProperty.Value;
//            }
//            set
//            {
//                if (refNotesProperty == null)
//                    refNotesProperty = GetStringProperty("VendorPP.RefNotes");
//                refNotesProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> applyChrgProperty;
//        public bool ApplyChrg
//        {
//            get
//            {
//                if (applyChrgProperty == null)
//                    applyChrgProperty = GetBooleanProperty("VendorPP.ApplyChrg");
//                return applyChrgProperty.Value;
//            }
//            set
//            {
//                if (applyChrgProperty == null)
//                    applyChrgProperty = GetBooleanProperty("VendorPP.ApplyChrg");
//                applyChrgProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> chrgAmountProperty;
//        public decimal ChrgAmount
//        {
//            get
//            {
//                if (chrgAmountProperty == null)
//                    chrgAmountProperty = GetDecimalProperty("VendorPP.ChrgAmount");
//                return chrgAmountProperty.Value;
//            }
//            set
//            {
//                if (chrgAmountProperty == null)
//                    chrgAmountProperty = GetDecimalProperty("VendorPP.ChrgAmount");
//                chrgAmountProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> codProperty;
//        public bool COD
//        {
//            get
//            {
//                if (codProperty == null)
//                    codProperty = GetBooleanProperty("VendorPP.COD");
//                return codProperty.Value;
//            }
//            set
//            {
//                if (codProperty == null)
//                    codProperty = GetBooleanProperty("VendorPP.COD");
//                codProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> cODFreightProperty;
//        public bool CODFreight
//        {
//            get
//            {
//                if (cODFreightProperty == null)
//                    cODFreightProperty = GetBooleanProperty("VendorPP.CODFreight");
//                return cODFreightProperty.Value;
//            }
//            set
//            {
//                if (cODFreightProperty == null)
//                    cODFreightProperty = GetBooleanProperty("VendorPP.CODFreight");
//                cODFreightProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> cODCheckProperty;
//        public bool CODCheck
//        {
//            get
//            {
//                if (cODCheckProperty == null)
//                    cODCheckProperty = GetBooleanProperty("VendorPP.CODCheck");
//                return cODCheckProperty.Value;
//            }
//            set
//            {
//                if (cODCheckProperty == null)
//                    cODCheckProperty = GetBooleanProperty("VendorPP.CODCheck");
//                cODCheckProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> cODAmountProperty;
//        public decimal CODAmount
//        {
//            get
//            {
//                if (cODAmountProperty == null)
//                    cODAmountProperty = GetDecimalProperty("VendorPP.CODAmount");
//                return cODAmountProperty.Value;
//            }
//            set
//            {
//                if (cODAmountProperty == null)
//                    cODAmountProperty = GetDecimalProperty("VendorPP.CODAmount");
//                cODAmountProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> groundTypeProperty;
//        public string GroundType
//        {
//            get
//            {
//                if (groundTypeProperty == null)
//                    groundTypeProperty = GetStringProperty("VendorPP.GroundType");
//                return groundTypeProperty.Value;
//            }
//            set
//            {
//                if (groundTypeProperty == null)
//                    groundTypeProperty = GetStringProperty("VendorPP.GroundType");
//                groundTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> notifyFlagProperty;
//        public bool NotifyFlag
//        {
//            get
//            {
//                if (notifyFlagProperty == null)
//                    notifyFlagProperty = GetBooleanProperty("VendorPP.NotifyFlag");
//                return notifyFlagProperty.Value;
//            }
//            set
//            {
//                if (notifyFlagProperty == null)
//                    notifyFlagProperty = GetBooleanProperty("VendorPP.NotifyFlag");
//                notifyFlagProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> notifyEMailProperty;
//        public string NotifyEMail
//        {
//            get
//            {
//                if (notifyEMailProperty == null)
//                    notifyEMailProperty = GetStringProperty("VendorPP.NotifyEMail");
//                return notifyEMailProperty.Value;
//            }
//            set
//            {
//                if (notifyEMailProperty == null)
//                    notifyEMailProperty = GetStringProperty("VendorPP.NotifyEMail");
//                notifyEMailProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> declaredInsProperty;
//        public bool DeclaredIns
//        {
//            get
//            {
//                if (declaredInsProperty == null)
//                    declaredInsProperty = GetBooleanProperty("VendorPP.DeclaredIns");
//                return declaredInsProperty.Value;
//            }
//            set
//            {
//                if (declaredInsProperty == null)
//                    declaredInsProperty = GetBooleanProperty("VendorPP.DeclaredIns");
//                declaredInsProperty.Value = value;
//            }
//        }

//        protected RowProperty<decimal> declaredAmtProperty;
//        public decimal DeclaredAmt
//        {
//            get
//            {
//                if (declaredAmtProperty == null)
//                    declaredAmtProperty = GetDecimalProperty("VendorPP.DeclaredAmt");
//                return declaredAmtProperty.Value;
//            }
//            set
//            {
//                if (declaredAmtProperty == null)
//                    declaredAmtProperty = GetDecimalProperty("VendorPP.DeclaredAmt");
//                declaredAmtProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servSignatureProperty;
//        public bool ServSignature
//        {
//            get
//            {
//                if (servSignatureProperty == null)
//                    servSignatureProperty = GetBooleanProperty("VendorPP.ServSignature");
//                return servSignatureProperty.Value;
//            }
//            set
//            {
//                if (servSignatureProperty == null)
//                    servSignatureProperty = GetBooleanProperty("VendorPP.ServSignature");
//                servSignatureProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servAlertProperty;
//        public bool ServAlert
//        {
//            get
//            {
//                if (servAlertProperty == null)
//                    servAlertProperty = GetBooleanProperty("VendorPP.ServAlert");
//                return servAlertProperty.Value;
//            }
//            set
//            {
//                if (servAlertProperty == null)
//                    servAlertProperty = GetBooleanProperty("VendorPP.ServAlert");
//                servAlertProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servHomeDelProperty;
//        public bool ServHomeDel
//        {
//            get
//            {
//                if (servHomeDelProperty == null)
//                    servHomeDelProperty = GetBooleanProperty("VendorPP.ServHomeDel");
//                return servHomeDelProperty.Value;
//            }
//            set
//            {
//                if (servHomeDelProperty == null)
//                    servHomeDelProperty = GetBooleanProperty("VendorPP.ServHomeDel");
//                servHomeDelProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> deliveryTypeProperty;
//        public string DeliveryType
//        {
//            get
//            {
//                if (deliveryTypeProperty == null)
//                    deliveryTypeProperty = GetStringProperty("VendorPP.DeliveryType");
//                return deliveryTypeProperty.Value;
//            }
//            set
//            {
//                if (deliveryTypeProperty == null)
//                    deliveryTypeProperty = GetStringProperty("VendorPP.DeliveryType");
//                deliveryTypeProperty.Value = value;
//            }
//        }

//        protected RowProperty<DateTime> servDeliveryDateProperty;
//        public DateTime ServDeliveryDate
//        {
//            get
//            {
//                if (servDeliveryDateProperty == null)
//                    servDeliveryDateProperty = GetDateTimeProperty("VendorPP.ServDeliveryDate");
//                return servDeliveryDateProperty.Value;
//            }
//            set
//            {
//                if (servDeliveryDateProperty == null)
//                    servDeliveryDateProperty = GetDateTimeProperty("VendorPP.ServDeliveryDate");
//                servDeliveryDateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servPhoneProperty;
//        public string ServPhone
//        {
//            get
//            {
//                if (servPhoneProperty == null)
//                    servPhoneProperty = GetStringProperty("VendorPP.ServPhone");
//                return servPhoneProperty.Value;
//            }
//            set
//            {
//                if (servPhoneProperty == null)
//                    servPhoneProperty = GetStringProperty("VendorPP.ServPhone");
//                servPhoneProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servInstructProperty;
//        public string ServInstruct
//        {
//            get
//            {
//                if (servInstructProperty == null)
//                    servInstructProperty = GetStringProperty("VendorPP.ServInstruct");
//                return servInstructProperty.Value;
//            }
//            set
//            {
//                if (servInstructProperty == null)
//                    servInstructProperty = GetStringProperty("VendorPP.ServInstruct");
//                servInstructProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> servReleaseProperty;
//        public bool ServRelease
//        {
//            get
//            {
//                if (servReleaseProperty == null)
//                    servReleaseProperty = GetBooleanProperty("VendorPP.ServRelease");
//                return servReleaseProperty.Value;
//            }
//            set
//            {
//                if (servReleaseProperty == null)
//                    servReleaseProperty = GetBooleanProperty("VendorPP.ServRelease");
//                servReleaseProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servAuthNumProperty;
//        public string ServAuthNum
//        {
//            get
//            {
//                if (servAuthNumProperty == null)
//                    servAuthNumProperty = GetStringProperty("VendorPP.ServAuthNum");
//                return servAuthNumProperty.Value;
//            }
//            set
//            {
//                if (servAuthNumProperty == null)
//                    servAuthNumProperty = GetStringProperty("VendorPP.ServAuthNum");
//                servAuthNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef1Property;
//        public string ServRef1
//        {
//            get
//            {
//                if (servRef1Property == null)
//                    servRef1Property = GetStringProperty("VendorPP.ServRef1");
//                return servRef1Property.Value;
//            }
//            set
//            {
//                if (servRef1Property == null)
//                    servRef1Property = GetStringProperty("VendorPP.ServRef1");
//                servRef1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef2Property;
//        public string ServRef2
//        {
//            get
//            {
//                if (servRef2Property == null)
//                    servRef2Property = GetStringProperty("VendorPP.ServRef2");
//                return servRef2Property.Value;
//            }
//            set
//            {
//                if (servRef2Property == null)
//                    servRef2Property = GetStringProperty("VendorPP.ServRef2");
//                servRef2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef3Property;
//        public string ServRef3
//        {
//            get
//            {
//                if (servRef3Property == null)
//                    servRef3Property = GetStringProperty("VendorPP.ServRef3");
//                return servRef3Property.Value;
//            }
//            set
//            {
//                if (servRef3Property == null)
//                    servRef3Property = GetStringProperty("VendorPP.ServRef3");
//                servRef3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef4Property;
//        public string ServRef4
//        {
//            get
//            {
//                if (servRef4Property == null)
//                    servRef4Property = GetStringProperty("VendorPP.ServRef4");
//                return servRef4Property.Value;
//            }
//            set
//            {
//                if (servRef4Property == null)
//                    servRef4Property = GetStringProperty("VendorPP.ServRef4");
//                servRef4Property.Value = value;
//            }
//        }

//        protected RowProperty<string> servRef5Property;
//        public string ServRef5
//        {
//            get
//            {
//                if (servRef5Property == null)
//                    servRef5Property = GetStringProperty("VendorPP.ServRef5");
//                return servRef5Property.Value;
//            }
//            set
//            {
//                if (servRef5Property == null)
//                    servRef5Property = GetStringProperty("VendorPP.ServRef5");
//                servRef5Property.Value = value;
//            }
//        }

//        protected RowProperty<bool> overrideCarrierProperty;
//        public bool OverrideCarrier
//        {
//            get
//            {
//                if (overrideCarrierProperty == null)
//                    overrideCarrierProperty = GetBooleanProperty("VendorPP.OverrideCarrier");
//                return overrideCarrierProperty.Value;
//            }
//            set
//            {
//                if (overrideCarrierProperty == null)
//                    overrideCarrierProperty = GetBooleanProperty("VendorPP.OverrideCarrier");
//                overrideCarrierProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> overrideServiceProperty;
//        public bool OverrideService
//        {
//            get
//            {
//                if (overrideServiceProperty == null)
//                    overrideServiceProperty = GetBooleanProperty("VendorPP.OverrideService");
//                return overrideServiceProperty.Value;
//            }
//            set
//            {
//                if (overrideServiceProperty == null)
//                    overrideServiceProperty = GetBooleanProperty("VendorPP.OverrideService");
//                overrideServiceProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> individualPackIDsProperty;
//        public bool IndividualPackIDs
//        {
//            get
//            {
//                if (individualPackIDsProperty == null)
//                    individualPackIDsProperty = GetBooleanProperty("VendorPP.IndividualPackIDs");
//                return individualPackIDsProperty.Value;
//            }
//            set
//            {
//                if (individualPackIDsProperty == null)
//                    individualPackIDsProperty = GetBooleanProperty("VendorPP.IndividualPackIDs");
//                individualPackIDsProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> intrntlShipProperty;
//        public bool IntrntlShip
//        {
//            get
//            {
//                if (intrntlShipProperty == null)
//                    intrntlShipProperty = GetBooleanProperty("VendorPP.IntrntlShip");
//                return intrntlShipProperty.Value;
//            }
//            set
//            {
//                if (intrntlShipProperty == null)
//                    intrntlShipProperty = GetBooleanProperty("VendorPP.IntrntlShip");
//                intrntlShipProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> certOfOriginProperty;
//        public bool CertOfOrigin
//        {
//            get
//            {
//                if (certOfOriginProperty == null)
//                    certOfOriginProperty = GetBooleanProperty("VendorPP.CertOfOrigin");
//                return certOfOriginProperty.Value;
//            }
//            set
//            {
//                if (certOfOriginProperty == null)
//                    certOfOriginProperty = GetBooleanProperty("VendorPP.CertOfOrigin");
//                certOfOriginProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> commercialInvoiceProperty;
//        public bool CommercialInvoice
//        {
//            get
//            {
//                if (commercialInvoiceProperty == null)
//                    commercialInvoiceProperty = GetBooleanProperty("VendorPP.CommercialInvoice");
//                return commercialInvoiceProperty.Value;
//            }
//            set
//            {
//                if (commercialInvoiceProperty == null)
//                    commercialInvoiceProperty = GetBooleanProperty("VendorPP.CommercialInvoice");
//                commercialInvoiceProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> shipExprtDeclartnProperty;
//        public bool ShipExprtDeclartn
//        {
//            get
//            {
//                if (shipExprtDeclartnProperty == null)
//                    shipExprtDeclartnProperty = GetBooleanProperty("VendorPP.ShipExprtDeclartn");
//                return shipExprtDeclartnProperty.Value;
//            }
//            set
//            {
//                if (shipExprtDeclartnProperty == null)
//                    shipExprtDeclartnProperty = GetBooleanProperty("VendorPP.ShipExprtDeclartn");
//                shipExprtDeclartnProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> letterOfInstrProperty;
//        public bool LetterOfInstr
//        {
//            get
//            {
//                if (letterOfInstrProperty == null)
//                    letterOfInstrProperty = GetBooleanProperty("VendorPP.LetterOfInstr");
//                return letterOfInstrProperty.Value;
//            }
//            set
//            {
//                if (letterOfInstrProperty == null)
//                    letterOfInstrProperty = GetBooleanProperty("VendorPP.LetterOfInstr");
//                letterOfInstrProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> ffidProperty;
//        public string FFID
//        {
//            get
//            {
//                if (ffidProperty == null)
//                    ffidProperty = GetStringProperty("VendorPP.FFID");
//                return ffidProperty.Value;
//            }
//            set
//            {
//                if (ffidProperty == null)
//                    ffidProperty = GetStringProperty("VendorPP.FFID");
//                ffidProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFCompNameProperty;
//        public string FFCompName
//        {
//            get
//            {
//                if (fFCompNameProperty == null)
//                    fFCompNameProperty = GetStringProperty("VendorPP.FFCompName");
//                return fFCompNameProperty.Value;
//            }
//            set
//            {
//                if (fFCompNameProperty == null)
//                    fFCompNameProperty = GetStringProperty("VendorPP.FFCompName");
//                fFCompNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFContactProperty;
//        public string FFContact
//        {
//            get
//            {
//                if (fFContactProperty == null)
//                    fFContactProperty = GetStringProperty("VendorPP.FFContact");
//                return fFContactProperty.Value;
//            }
//            set
//            {
//                if (fFContactProperty == null)
//                    fFContactProperty = GetStringProperty("VendorPP.FFContact");
//                fFContactProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFAddress1Property;
//        public string FFAddress1
//        {
//            get
//            {
//                if (fFAddress1Property == null)
//                    fFAddress1Property = GetStringProperty("VendorPP.FFAddress1");
//                return fFAddress1Property.Value;
//            }
//            set
//            {
//                if (fFAddress1Property == null)
//                    fFAddress1Property = GetStringProperty("VendorPP.FFAddress1");
//                fFAddress1Property.Value = value;
//            }
//        }

//        protected RowProperty<string> fFAddress2Property;
//        public string FFAddress2
//        {
//            get
//            {
//                if (fFAddress2Property == null)
//                    fFAddress2Property = GetStringProperty("VendorPP.FFAddress2");
//                return fFAddress2Property.Value;
//            }
//            set
//            {
//                if (fFAddress2Property == null)
//                    fFAddress2Property = GetStringProperty("VendorPP.FFAddress2");
//                fFAddress2Property.Value = value;
//            }
//        }

//        protected RowProperty<string> fFAddress3Property;
//        public string FFAddress3
//        {
//            get
//            {
//                if (fFAddress3Property == null)
//                    fFAddress3Property = GetStringProperty("VendorPP.FFAddress3");
//                return fFAddress3Property.Value;
//            }
//            set
//            {
//                if (fFAddress3Property == null)
//                    fFAddress3Property = GetStringProperty("VendorPP.FFAddress3");
//                fFAddress3Property.Value = value;
//            }
//        }

//        protected RowProperty<string> fFCityProperty;
//        public string FFCity
//        {
//            get
//            {
//                if (fFCityProperty == null)
//                    fFCityProperty = GetStringProperty("VendorPP.FFCity");
//                return fFCityProperty.Value;
//            }
//            set
//            {
//                if (fFCityProperty == null)
//                    fFCityProperty = GetStringProperty("VendorPP.FFCity");
//                fFCityProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFStateProperty;
//        public string FFState
//        {
//            get
//            {
//                if (fFStateProperty == null)
//                    fFStateProperty = GetStringProperty("VendorPP.FFState");
//                return fFStateProperty.Value;
//            }
//            set
//            {
//                if (fFStateProperty == null)
//                    fFStateProperty = GetStringProperty("VendorPP.FFState");
//                fFStateProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFZipProperty;
//        public string FFZip
//        {
//            get
//            {
//                if (fFZipProperty == null)
//                    fFZipProperty = GetStringProperty("VendorPP.FFZip");
//                return fFZipProperty.Value;
//            }
//            set
//            {
//                if (fFZipProperty == null)
//                    fFZipProperty = GetStringProperty("VendorPP.FFZip");
//                fFZipProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFCountryProperty;
//        public string FFCountry
//        {
//            get
//            {
//                if (fFCountryProperty == null)
//                    fFCountryProperty = GetStringProperty("VendorPP.FFCountry");
//                return fFCountryProperty.Value;
//            }
//            set
//            {
//                if (fFCountryProperty == null)
//                    fFCountryProperty = GetStringProperty("VendorPP.FFCountry");
//                fFCountryProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> nonStdPkgProperty;
//        public bool NonStdPkg
//        {
//            get
//            {
//                if (nonStdPkgProperty == null)
//                    nonStdPkgProperty = GetBooleanProperty("VendorPP.NonStdPkg");
//                return nonStdPkgProperty.Value;
//            }
//            set
//            {
//                if (nonStdPkgProperty == null)
//                    nonStdPkgProperty = GetBooleanProperty("VendorPP.NonStdPkg");
//                nonStdPkgProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> deliveryConfProperty;
//        public int DeliveryConf
//        {
//            get
//            {
//                if (deliveryConfProperty == null)
//                    deliveryConfProperty = GetIntegerProperty("VendorPP.DeliveryConf");
//                return deliveryConfProperty.Value;
//            }
//            set
//            {
//                if (deliveryConfProperty == null)
//                    deliveryConfProperty = GetIntegerProperty("VendorPP.DeliveryConf");
//                deliveryConfProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> addlHdlgFlagProperty;
//        public bool AddlHdlgFlag
//        {
//            get
//            {
//                if (addlHdlgFlagProperty == null)
//                    addlHdlgFlagProperty = GetBooleanProperty("VendorPP.AddlHdlgFlag");
//                return addlHdlgFlagProperty.Value;
//            }
//            set
//            {
//                if (addlHdlgFlagProperty == null)
//                    addlHdlgFlagProperty = GetBooleanProperty("VendorPP.AddlHdlgFlag");
//                addlHdlgFlagProperty.Value = value;
//            }
//        }

//        protected RowProperty<bool> uPSQuantumViewProperty;
//        public bool UPSQuantumView
//        {
//            get
//            {
//                if (uPSQuantumViewProperty == null)
//                    uPSQuantumViewProperty = GetBooleanProperty("VendorPP.UPSQuantumView");
//                return uPSQuantumViewProperty.Value;
//            }
//            set
//            {
//                if (uPSQuantumViewProperty == null)
//                    uPSQuantumViewProperty = GetBooleanProperty("VendorPP.UPSQuantumView");
//                uPSQuantumViewProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> uPSQVShipFromNameProperty;
//        public string UPSQVShipFromName
//        {
//            get
//            {
//                if (uPSQVShipFromNameProperty == null)
//                    uPSQVShipFromNameProperty = GetStringProperty("VendorPP.UPSQVShipFromName");
//                return uPSQVShipFromNameProperty.Value;
//            }
//            set
//            {
//                if (uPSQVShipFromNameProperty == null)
//                    uPSQVShipFromNameProperty = GetStringProperty("VendorPP.UPSQVShipFromName");
//                uPSQVShipFromNameProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> uPSQVMemoProperty;
//        public string UPSQVMemo
//        {
//            get
//            {
//                if (uPSQVMemoProperty == null)
//                    uPSQVMemoProperty = GetStringProperty("VendorPP.UPSQVMemo");
//                return uPSQVMemoProperty.Value;
//            }
//            set
//            {
//                if (uPSQVMemoProperty == null)
//                    uPSQVMemoProperty = GetStringProperty("VendorPP.UPSQVMemo");
//                uPSQVMemoProperty.Value = value;
//            }
//        }

//        protected RowProperty<string> fFPhoneNumProperty;
//        public string FFPhoneNum
//        {
//            get
//            {
//                if (fFPhoneNumProperty == null)
//                    fFPhoneNumProperty = GetStringProperty("VendorPP.FFPhoneNum");
//                return fFPhoneNumProperty.Value;
//            }
//            set
//            {
//                if (fFPhoneNumProperty == null)
//                    fFPhoneNumProperty = GetStringProperty("VendorPP.FFPhoneNum");
//                fFPhoneNumProperty.Value = value;
//            }
//        }

//        protected RowProperty<int> fFCountryNumProperty;
//        public int FFCountryNum
//        {
//            get
//            {
//                if (fFCountryNumProperty == null)
//                    fFCountryNumProperty = GetIntegerProperty("VendorPP.FFCountryNum");
//                return fFCountryNumProperty.Value;
//            }
//            set
//            {
//                if (fFCountryNumProperty == null)
//                    fFCountryNumProperty = GetIntegerProperty("VendorPP.FFCountryNum");
//                fFCountryNumProperty.Value = value;
//            }
//        }

//    }

//    #endregion

//    #endregion

//    #endregion
//}
