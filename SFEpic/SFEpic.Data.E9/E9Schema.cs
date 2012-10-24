using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Data;

namespace SFEpic.Data.E9
{
    [Serializable()]
    public partial class E9Schema : SFEpic.Data.DbSchema
    {
        protected E9Schema()
            : base("E9Schema")
        {
        }

        protected static E9Schema instance;
        public static E9Schema Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new E9Schema();
                }
                return instance;
            }
        }

        #region Schema Table Names

        public const string Company = "Company";
        public const string ECORev = "ECORev";
        public const string OpMaster = "OpMaster";
        public const string Part = "Part";
        public const string PartBin = "PartBin";
        public const string PartCost = "PartCost";
        public const string PartMtl = "PartMtl";
        public const string PartOpDtl = "PartOpDtl";
        public const string PartOpr = "PartOpr";
        public const string PartPlant = "PartPlant";
        public const string PartRev = "PartRev";
        public const string PartUOM = "PartUOM";
        public const string PartWhse = "PartWhse";
        public const string PlantWhse = "PlantWhse";
        public const string Resource = "Resource";
        public const string ResourceGroup = "ResourceGroup";
        public const string UOM = "UOM";
        public const string UOMClass = "UOMClass";
        public const string UOMConv = "UOMConv";

        #endregion

        protected virtual Schema.Company GetCompanySchemaTable()
        {
            return new Schema.Company();
        }

        protected virtual Schema.ECORev GetECORevSchemaTable()
        {
            return new Schema.ECORev();
        }

        protected virtual Schema.OpMasDtl GetOpMasDtlSchemaTable()
        {
            return new Schema.OpMasDtl();
        }

        protected virtual Schema.OpMaster GetOpMasterSchemaTable()
        {
            return new Schema.OpMaster();
        }

        protected virtual Schema.Part GetPartSchemaTable()
        {
            return new Schema.Part();
        }

        protected virtual Schema.PartBin GetPartBinSchemaTable()
        {
            return new Schema.PartBin();
        }

        protected virtual Schema.PartCost GetPartCostSchemaTable()
        {
            return new Schema.PartCost();
        }

        protected virtual Schema.PartMtl GetPartMtlSchemaTable()
        {
            return new Schema.PartMtl();
        }

        protected virtual Schema.PartOpDtl GetPartOpDtlSchemaTable()
        {
            return new Schema.PartOpDtl();
        }

        protected virtual Schema.PartOpr GetPartOprSchemaTable()
        {
            return new Schema.PartOpr();
        }

        protected virtual Schema.PartPlant GetPartPlantSchemaTable()
        {
            return new Schema.PartPlant();
        }

        protected virtual Schema.PartRev GetPartRevSchemaTable()
        {
            return new Schema.PartRev();
        }

        protected virtual Schema.PartUOM GetPartUOMSchemaTable()
        {
            return new Schema.PartUOM();
        }

        protected virtual Schema.PartWhse GetPartWhseSchemaTable()
        {
            return new Schema.PartWhse();
        }

        protected virtual Schema.PlantWhse GetPlantWhseSchemaTable()
        {
            return new Schema.PlantWhse();
        }

        protected virtual Schema.Resource GetResourceSchemaTable()
        {
            return new Schema.Resource();
        }

        protected virtual Schema.ResourceGroup GetResourceGroupSchemaTable()
        {
            return new Schema.ResourceGroup();
        }

        protected virtual Schema.UOM GetUOMSchemaTable()
        {
            return new Schema.UOM();
        }

        protected virtual Schema.UOMClass GetUOMClassSchemaTable()
        {
            return new Schema.UOMClass();
        }

        protected virtual Schema.UOMConv GetUOMConvSchemaTable()
        {
            return new Schema.UOMConv();
        }

        protected override void InitTablesCore()
        {
            tablesList.Add(GetCompanySchemaTable());
            tablesList.Add(GetECORevSchemaTable());
            tablesList.Add(GetOpMasDtlSchemaTable());
            tablesList.Add(GetOpMasterSchemaTable());
            tablesList.Add(GetPartSchemaTable());
            tablesList.Add(GetPartBinSchemaTable());
            tablesList.Add(GetPartCostSchemaTable());
            tablesList.Add(GetPartMtlSchemaTable());
            tablesList.Add(GetPartOpDtlSchemaTable());
            tablesList.Add(GetPartOprSchemaTable());
            tablesList.Add(GetPartPlantSchemaTable());
            tablesList.Add(GetPartRevSchemaTable());
            tablesList.Add(GetPartUOMSchemaTable());
            tablesList.Add(GetPartWhseSchemaTable());
            tablesList.Add(GetPlantWhseSchemaTable());
            tablesList.Add(GetResourceSchemaTable());
            tablesList.Add(GetResourceGroupSchemaTable());
            tablesList.Add(GetUOMSchemaTable());
            tablesList.Add(GetUOMClassSchemaTable());
            tablesList.Add(GetUOMConvSchemaTable());
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
            public const string FiscalCalendarID = "Company.FiscalCalendarID";
            public const string SysRowID = "Company.SysRowID";
            public const string SysRevID = "Company.SysRevID";
            public const string AttachNetworkRoot = "Company.AttachNetworkRoot";
            public const string AttachSharePointRoot = "Company.AttachSharePointRoot";
            public const string AttachDefaultMechanism = "Company.AttachDefaultMechanism";
            public const string EnableFileSys = "Company.EnableFileSys";
            public const string EnableSharePoint = "Company.EnableSharePoint";
            public const string AllowDefaultDoc = "Company.AllowDefaultDoc";
            public const string MetadataPath = "Company.MetadataPath";
            public const string WinWebURL = "Company.WinWebURL";
            public const string TrackSysActivity = "Company.TrackSysActivity";
            public const string TrackPersonalizationChg = "Company.TrackPersonalizationChg";
            public const string BitFlag = "Company.BitFlag";
            public const string WasWrittenByAspacia = "Company.CheckBox20";

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
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FiscalCalendarID", 24, schemaColumnName: "FiscalCalendarID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AttachNetworkRoot", 512, schemaColumnName: "AttachNetworkRoot", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AttachSharePointRoot", 512, schemaColumnName: "AttachSharePointRoot", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "AttachDefaultMechanism", schemaColumnName: "AttachDefaultMechanism", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "EnableFileSys", schemaColumnName: "EnableFileSys", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "EnableSharePoint", schemaColumnName: "EnableSharePoint", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AllowDefaultDoc", schemaColumnName: "AllowDefaultDoc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MetadataPath", 512, schemaColumnName: "MetadataPath", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WinWebURL", 512, schemaColumnName: "WinWebURL", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackSysActivity", schemaColumnName: "TrackSysActivity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackPersonalizationChg", schemaColumnName: "TrackPersonalizationChg", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
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
        public partial class ECORev : SFEpic.Data.SchemaTable
        {
            public ECORev()
                : base("ECORev")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "ECORev.CompanyNum";
            public const string PartNum = "ECORev.PartNum";
            public const string RevShortDesc = "ECORev.RevShortDesc";
            public const string RevDescription = "ECORev.RevDescription";
            public const string RevisionNum = "ECORev.RevisionNum";
            public const string Approved = "ECORev.Approved";
            public const string ApprovedDate = "ECORev.ApprovedDate";
            public const string ApprovedBy = "ECORev.ApprovedBy";
            public const string EffectiveDate = "ECORev.EffectiveDate";
            public const string AutoRecOpr = "ECORev.AutoRecOpr";
            public const string TLRLaborCost = "ECORev.TLRLaborCost";
            public const string TLRBurdenCost = "ECORev.TLRBurdenCost";
            public const string TLRMaterialCost = "ECORev.TLRMaterialCost";
            public const string TLRSubcontractCost = "ECORev.TLRSubcontractCost";
            public const string TLRSetupLaborCost = "ECORev.TLRSetupLaborCost";
            public const string TLRSetupBurdenCost = "ECORev.TLRSetupBurdenCost";
            public const string LLRLaborCost = "ECORev.LLRLaborCost";
            public const string LLRBurdenCost = "ECORev.LLRBurdenCost";
            public const string LLRMaterialCost = "ECORev.LLRMaterialCost";
            public const string LLRSetupLaborCost = "ECORev.LLRSetupLaborCost";
            public const string LLRSetupBurdenCost = "ECORev.LLRSetupBurdenCost";
            public const string RollupDate = "ECORev.RollupDate";
            public const string LLRSubcontractCost = "ECORev.LLRSubcontractCost";
            public const string DrawNum = "ECORev.DrawNum";
            public const string Method = "ECORev.Method";
            public const string ECO = "ECORev.ECO";
            public const string FinalOpr = "ECORev.FinalOpr";
            public const string TLRMtlBurCost = "ECORev.TLRMtlBurCost";
            public const string LLRMtlBurCost = "ECORev.LLRMtlBurCost";
            public const string GroupID = "ECORev.GroupID";
            public const string CheckInRevisionNum = "ECORev.CheckInRevisionNum";
            public const string CheckInDate = "ECORev.CheckInDate";
            public const string CheckedOut = "ECORev.CheckedOut";
            public const string CheckOutDate = "ECORev.CheckOutDate";
            public const string SearchWord = "ECORev.SearchWord";
            public const string PartDescription = "ECORev.PartDescription";
            public const string CheckedOutBy = "ECORev.CheckedOutBy";
            public const string PDMObjID = "ECORev.PDMObjID";
            public const string RevLocked = "ECORev.RevLocked";
            public const string RevLockedBy = "ECORev.RevLockedBy";
            public const string AltMethod = "ECORev.AltMethod";
            public const string PlantNum = "ECORev.PlantNum";
            public const string ParentAltMethod = "ECORev.ParentAltMethod";
            public const string UseStaging = "ECORev.UseStaging";
            public const string RevLockedInfo = "ECORev.RevLockedInfo";
            public const string UseAltRevForParts = "ECORev.UseAltRevForParts";
            public const string SysRowID = "ECORev.SysRowID";
            public const string SysRevID = "ECORev.SysRevID";
            public const string BitFlag = "ECORev.BitFlag";
            public const string ValRefDes = "ECORev.ValRefDes";
            public const string WasWrittenByAspacia = "ECORev.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevShortDesc", 60, schemaColumnName: "RevShortDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevDescription", 2000, schemaColumnName: "RevDescription", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Approved", schemaColumnName: "Approved", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ApprovedDate", schemaColumnName: "ApprovedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovedBy", 40, schemaColumnName: "ApprovedBy", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "EffectiveDate", schemaColumnName: "EffectiveDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "AutoRecOpr", schemaColumnName: "AutoRecOpr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRLaborCost", 25, 5, schemaColumnName: "TLRLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRBurdenCost", 25, 5, schemaColumnName: "TLRBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRMaterialCost", 25, 5, schemaColumnName: "TLRMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRSubcontractCost", 25, 5, schemaColumnName: "TLRSubcontractCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRSetupLaborCost", 25, 5, schemaColumnName: "TLRSetupLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRSetupBurdenCost", 25, 5, schemaColumnName: "TLRSetupBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRLaborCost", 25, 5, schemaColumnName: "LLRLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRBurdenCost", 25, 5, schemaColumnName: "LLRBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRMaterialCost", 25, 5, schemaColumnName: "LLRMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRSetupLaborCost", 25, 5, schemaColumnName: "LLRSetupLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRSetupBurdenCost", 25, 5, schemaColumnName: "LLRSetupBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "RollupDate", schemaColumnName: "RollupDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRSubcontractCost", 25, 5, schemaColumnName: "LLRSubcontractCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DrawNum", 50, schemaColumnName: "DrawNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Method", schemaColumnName: "Method", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ECO", 20, schemaColumnName: "ECO", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FinalOpr", schemaColumnName: "FinalOpr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRMtlBurCost", 25, 5, schemaColumnName: "TLRMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRMtlBurCost", 25, 5, schemaColumnName: "LLRMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "GroupID", 60, schemaColumnName: "GroupID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CheckInRevisionNum", 24, schemaColumnName: "CheckInRevisionNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "CheckInDate", schemaColumnName: "CheckInDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CheckedOut", schemaColumnName: "CheckedOut", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "CheckOutDate", schemaColumnName: "CheckOutDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SearchWord", 16, schemaColumnName: "SearchWord", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartDescription", 2000, schemaColumnName: "PartDescription", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CheckedOutBy", 40, schemaColumnName: "CheckedOutBy", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PDMObjID", 16, schemaColumnName: "PDMObjID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RevLocked", schemaColumnName: "RevLocked", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevLockedBy", 40, schemaColumnName: "RevLockedBy", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethod", 24, schemaColumnName: "AltMethod", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ParentAltMethod", 24, schemaColumnName: "ParentAltMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseStaging", schemaColumnName: "UseStaging", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevLockedInfo", 2000, schemaColumnName: "RevLockedInfo", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseAltRevForParts", schemaColumnName: "UseAltRevForParts", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ValRefDes", schemaColumnName: "ValRefDes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["ECORev.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["ECORev.GroupID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["ECORev.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["ECORev.RevisionNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["ECORev.AltMethod"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class OpMaster : SFEpic.Data.SchemaTable
        {
            public OpMaster()
                : base("OpMaster")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "OpMaster.CompanyNum";
            public const string OpCode = "OpMaster.OpCode";
            public const string OpDesc = "OpMaster.OpDesc";
            public const string Obsolete803_ProdLRate = "OpMaster.Obsolete803_ProdLRate";
            public const string Obsolete803_SetupLRate = "OpMaster.Obsolete803_SetupLRate";
            public const string OpTextID = "OpMaster.OpTextID";
            public const string Obsolete803_QSetupLRate = "OpMaster.Obsolete803_QSetupLRate";
            public const string Obsolete803_QProdLRate = "OpMaster.Obsolete803_QProdLRate";
            public const string BuyerID = "OpMaster.BuyerID";
            public const string APSPrepOpF = "OpMaster.APSPrepOpF";
            public const string OPType = "OpMaster.OPType";
            public const string CommentText = "OpMaster.CommentText";
            public const string BillLaborRate = "OpMaster.BillLaborRate";
            public const string EstLabHours = "OpMaster.EstLabHours";
            public const string SchedPrecedence = "OpMaster.SchedPrecedence";
            public const string AnalysisCode = "OpMaster.AnalysisCode";
            public const string PrimarySetupOpDtl = "OpMaster.PrimarySetupOpDtl";
            public const string PrimaryProdOpDtl = "OpMaster.PrimaryProdOpDtl";
            public const string VendorNum = "OpMaster.VendorNum";
            public const string Subcontract = "OpMaster.Subcontract";
            public const string PrdYldRecalcExpected = "OpMaster.PrdYldRecalcExpected";
            public const string PrdYldRecalcUnderPct = "OpMaster.PrdYldRecalcUnderPct";
            public const string PrdYldShopWrnAlert = "OpMaster.PrdYldShopWrnAlert";
            public const string PrdYldShopWrn = "OpMaster.PrdYldShopWrn";
            public const string PrdYldShopWrnUnderPct = "OpMaster.PrdYldShopWrnUnderPct";
            public const string PrdYldShopWrnOverPct = "OpMaster.PrdYldShopWrnOverPct";
            public const string SysRowID = "OpMaster.SysRowID";
            public const string SysRevID = "OpMaster.SysRevID";
            public const string RestrictSubstance = "OpMaster.RestrictSubstance";
            public const string BitFlag = "OpMaster.BitFlag";
            public const string WasWrittenByAspacia = "OpMaster.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpCode", 16, schemaColumnName: "OpCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpDesc", 60, schemaColumnName: "OpDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete803_ProdLRate", 25, 6, schemaColumnName: "Obsolete803-ProdLRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete803_SetupLRate", 25, 6, schemaColumnName: "Obsolete803-SetupLRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpTextID", 8, schemaColumnName: "OpTextID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete803_QSetupLRate", 25, 6, schemaColumnName: "Obsolete803-QSetupLRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete803_QProdLRate", 25, 6, schemaColumnName: "Obsolete803-QProdLRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BuyerID", 16, schemaColumnName: "BuyerID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "APSPrepOpF", schemaColumnName: "APSPrepOpF", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OPType", 6, schemaColumnName: "OPType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommentText", 2000, schemaColumnName: "CommentText", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BillLaborRate", 25, 5, schemaColumnName: "BillLaborRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstLabHours", 25, 2, schemaColumnName: "EstLabHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SchedPrecedence", schemaColumnName: "SchedPrecedence", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AnalysisCode", 16, schemaColumnName: "AnalysisCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimarySetupOpDtl", schemaColumnName: "PrimarySetupOpDtl", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimaryProdOpDtl", schemaColumnName: "PrimaryProdOpDtl", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Subcontract", schemaColumnName: "Subcontract", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrdYldRecalcExpected", schemaColumnName: "PrdYldRecalcExpected", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrdYldRecalcUnderPct", schemaColumnName: "PrdYldRecalcUnderPct", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrdYldShopWrnAlert", schemaColumnName: "PrdYldShopWrnAlert", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PrdYldShopWrn", schemaColumnName: "PrdYldShopWrn", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrdYldShopWrnUnderPct", schemaColumnName: "PrdYldShopWrnUnderPct", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrdYldShopWrnOverPct", schemaColumnName: "PrdYldShopWrnOverPct", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RestrictSubstance", schemaColumnName: "RestrictSubstance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["OpMaster.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["OpMaster.OpCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }

        [Serializable()]
        public partial class OpMasDtl : SFEpic.Data.SchemaTable
        {
            public OpMasDtl()
                : base("OpMasDtl")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "OpMasDtl.CompanyNum";
            public const string OpCode = "OpMasDtl.OpCode";
            public const string SetupOrProd = "OpMasDtl.SetupOrProd";
            public const string OpDtlSeq = "OpMasDtl.OpDtlSeq";
            public const string SysRowID = "OpMasDtl.SysRowID";
            public const string SysRevID = "OpMasDtl.SysRevID";
            public const string BitFlag = "OpMasDtl.BitFlag";
            public const string WasWrittenByAspacia = "OpMasDtl.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpCode", 16, schemaColumnName: "OpCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SetupOrProd", 2, schemaColumnName: "SetupOrProd", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OpDtlSeq", schemaColumnName: "OpDtlSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["OpMasDtl.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["OpMasDtl.OpCode"];
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
            public const string OBS900_ExpenseChart = "Part.OBS900_ExpenseChart";
            public const string OBS900_ExpenseDiv = "Part.OBS900_ExpenseDiv";
            public const string UnitPrice = "Part.UnitPrice";
            public const string TrackLots = "Part.TrackLots";
            public const string OBS900_ExpenseDept = "Part.OBS900_ExpenseDept";
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
            public const string SNFormat = "Part.SNFormat";
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
            public const string Obsolete90_SNRequiredWhenIn = "Part.Obsolete90_SNRequiredWhenIn";
            public const string SNPrefix = "Part.SNPrefix";
            public const string SNBaseDataType = "Part.SNBaseDataType";
            public const string ISOrigCountry = "Part.ISOrigCountry";
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
            public const string RevChargeMethod = "Part.RevChargeMethod";
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
            public const string RCUnderThreshold = "Part.RCUnderThreshold";
            public const string RCOverThreshold = "Part.RCOverThreshold";
            public const string OwnershipStatus = "Part.OwnershipStatus";
            public const string UOMClassID = "Part.UOMClassID";
            public const string SNMask = "Part.SNMask";
            public const string SNMaskExample = "Part.SNMaskExample";
            public const string SNMaskSuffix = "Part.SNMaskSuffix";
            public const string SNMaskPrefix = "Part.SNMaskPrefix";
            public const string SNLastUsedSeq = "Part.SNLastUsedSeq";
            public const string UseMaskSeq = "Part.UseMaskSeq";
            public const string NetWeightUOM = "Part.NetWeightUOM";
            public const string NetVolumeUOM = "Part.NetVolumeUOM";
            public const string LotBatch = "Part.LotBatch";
            public const string LotMfgBatch = "Part.LotMfgBatch";
            public const string LotMfgLot = "Part.LotMfgLot";
            public const string LotHeat = "Part.LotHeat";
            public const string LotFirmware = "Part.LotFirmware";
            public const string LotBeforeDt = "Part.LotBeforeDt";
            public const string LotMfgDt = "Part.LotMfgDt";
            public const string LotCureDt = "Part.LotCureDt";
            public const string LotExpDt = "Part.LotExpDt";
            public const string LotPrefix = "Part.LotPrefix";
            public const string LotUseGlobalSeq = "Part.LotUseGlobalSeq";
            public const string LotNxtNum = "Part.LotNxtNum";
            public const string LotDigits = "Part.LotDigits";
            public const string LotAppendDate = "Part.LotAppendDate";
            public const string LotSeqID = "Part.LotSeqID";
            public const string LotLeadingZeros = "Part.LotLeadingZeros";
            public const string SysRowID = "Part.SysRowID";
            public const string SysRevID = "Part.SysRevID";
            public const string BuyToOrder = "Part.BuyToOrder";
            public const string DropShip = "Part.DropShip";
            public const string BitFlag = "Part.BitFlag";
            public const string IsConfigured = "Part.IsConfigured";
            public const string ExtConfig = "Part.ExtConfig";
            public const string RefCategory = "Part.RefCategory";
            public const string WasWrittenByAspacia = "Part.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartDescription", 2000, schemaColumnName: "PartDescription", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ProdCode", 16, schemaColumnName: "ProdCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ClassID", 8, schemaColumnName: "ClassID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "IUM", 12, schemaColumnName: "IUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PUM", 12, schemaColumnName: "PUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TypeCode", 2, schemaColumnName: "TypeCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PurchasingFactor", 25, 4, schemaColumnName: "PurchasingFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PricePerCode", 2, schemaColumnName: "PricePerCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OBS900_ExpenseChart", 100, schemaColumnName: "OBS900-ExpenseChart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OBS900_ExpenseDiv", 100, schemaColumnName: "OBS900-ExpenseDiv", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UnitPrice", 25, 5, schemaColumnName: "UnitPrice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackLots", schemaColumnName: "TrackLots", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OBS900_ExpenseDept", 100, schemaColumnName: "OBS900-ExpenseDept", ordinalSequence: seq++, isRequired: false));
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
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommodityCode", 24, schemaColumnName: "CommodityCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarrantyCode", 16, schemaColumnName: "WarrantyCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "InternalUnitPrice", 25, 5, schemaColumnName: "InternalUnitPrice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InternalPricePerCode", 2, schemaColumnName: "InternalPricePerCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PhantomBOM", schemaColumnName: "PhantomBOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SalesUM", 12, schemaColumnName: "SalesUM", ordinalSequence: seq++, isRequired: false));
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
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNFormat", 160, schemaColumnName: "SNFormat", ordinalSequence: seq++, isRequired: false));
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
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete90_SNRequiredWhenIn", 48, schemaColumnName: "Obsolete90-SNRequiredWhenIn", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNPrefix", 60, schemaColumnName: "SNPrefix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNBaseDataType", 20, schemaColumnName: "SNBaseDataType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ISOrigCountry", 12, schemaColumnName: "ISOrigCountry", ordinalSequence: seq++, isRequired: false));
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
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevChargeMethod", 16, schemaColumnName: "RevChargeMethod", ordinalSequence: seq++, isRequired: false));
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
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RCUnderThreshold", 17, 3, schemaColumnName: "RCUnderThreshold", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RCOverThreshold", 17, 3, schemaColumnName: "RCOverThreshold", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OwnershipStatus", 16, schemaColumnName: "OwnershipStatus", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMClassID", 24, schemaColumnName: "UOMClassID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMask", 40, schemaColumnName: "SNMask", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMaskExample", 160, schemaColumnName: "SNMaskExample", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMaskSuffix", 20, schemaColumnName: "SNMaskSuffix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMaskPrefix", 20, schemaColumnName: "SNMaskPrefix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNLastUsedSeq", 80, schemaColumnName: "SNLastUsedSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseMaskSeq", schemaColumnName: "UseMaskSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NetWeightUOM", 12, schemaColumnName: "NetWeightUOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NetVolumeUOM", 12, schemaColumnName: "NetVolumeUOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotBatch", schemaColumnName: "LotBatch", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotMfgBatch", schemaColumnName: "LotMfgBatch", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotMfgLot", schemaColumnName: "LotMfgLot", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotHeat", schemaColumnName: "LotHeat", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotFirmware", schemaColumnName: "LotFirmware", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotBeforeDt", schemaColumnName: "LotBeforeDt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotMfgDt", schemaColumnName: "LotMfgDt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotCureDt", schemaColumnName: "LotCureDt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotExpDt", schemaColumnName: "LotExpDt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LotPrefix", 40, schemaColumnName: "LotPrefix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotUseGlobalSeq", schemaColumnName: "LotUseGlobalSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LotNxtNum", schemaColumnName: "LotNxtNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LotDigits", schemaColumnName: "LotDigits", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LotAppendDate", 20, schemaColumnName: "LotAppendDate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LotSeqID", 24, schemaColumnName: "LotSeqID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LotLeadingZeros", schemaColumnName: "LotLeadingZeros", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BuyToOrder", schemaColumnName: "BuyToOrder", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DropShip", schemaColumnName: "DropShip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "IsConfigured", schemaColumnName: "IsConfigured", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ExtConfig", schemaColumnName: "ExtConfig", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RefCategory", 16, schemaColumnName: "RefCategory", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
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
        public partial class PartBin : SFEpic.Data.SchemaTable
        {
            public PartBin()
                : base("PartBin")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartBin.CompanyNum";
            public const string PartNum = "PartBin.PartNum";
            public const string WarehouseCode = "PartBin.WarehouseCode";
            public const string BinNum = "PartBin.BinNum";
            public const string OnhandQty = "PartBin.OnhandQty";
            public const string LotNum = "PartBin.LotNum";
            public const string DimCode = "PartBin.DimCode";
            public const string SysRowID = "PartBin.SysRowID";
            public const string SysRevID = "PartBin.SysRevID";
            public const string AllocatedQty = "PartBin.AllocatedQty";
            public const string SalesAllocatedQty = "PartBin.SalesAllocatedQty";
            public const string JobAllocatedQty = "PartBin.JobAllocatedQty";
            public const string TFOrdAllocatedQty = "PartBin.TFOrdAllocatedQty";
            public const string SalesPickingQty = "PartBin.SalesPickingQty";
            public const string SalesPickedQty = "PartBin.SalesPickedQty";
            public const string BitFlag = "PartBin.BitFlag";
            public const string JobPickingQty = "PartBin.JobPickingQty";
            public const string JobPickedQty = "PartBin.JobPickedQty";
            public const string TFOrdPickingQty = "PartBin.TFOrdPickingQty";
            public const string TFOrdPickedQty = "PartBin.TFOrdPickedQty";
            public const string ShippingQty = "PartBin.ShippingQty";
            public const string WasWrittenByAspacia = "PartBin.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarehouseCode", 16, schemaColumnName: "WarehouseCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BinNum", 20, schemaColumnName: "BinNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "OnhandQty", 25, 8, schemaColumnName: "OnhandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LotNum", 60, schemaColumnName: "LotNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DimCode", 12, schemaColumnName: "DimCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AllocatedQty", 23, 8, schemaColumnName: "AllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesAllocatedQty", 23, 8, schemaColumnName: "SalesAllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobAllocatedQty", 23, 8, schemaColumnName: "JobAllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdAllocatedQty", 23, 8, schemaColumnName: "TFOrdAllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesPickingQty", 23, 8, schemaColumnName: "SalesPickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesPickedQty", 23, 8, schemaColumnName: "SalesPickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobPickingQty", 23, 8, schemaColumnName: "JobPickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobPickedQty", 23, 8, schemaColumnName: "JobPickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdPickingQty", 23, 8, schemaColumnName: "TFOrdPickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdPickedQty", 23, 8, schemaColumnName: "TFOrdPickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ShippingQty", 23, 8, schemaColumnName: "ShippingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartBin.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartBin.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartBin.WarehouseCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartBin.BinNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartBin.DimCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartBin.LotNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartCost : SFEpic.Data.SchemaTable
        {
            public PartCost()
                : base("PartCost")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartCost.CompanyNum";
            public const string PartNum = "PartCost.PartNum";
            public const string AvgLaborCost = "PartCost.AvgLaborCost";
            public const string AvgBurdenCost = "PartCost.AvgBurdenCost";
            public const string AvgMaterialCost = "PartCost.AvgMaterialCost";
            public const string AvgSubContCost = "PartCost.AvgSubContCost";
            public const string AvgMtlBurCost = "PartCost.AvgMtlBurCost";
            public const string StdLaborCost = "PartCost.StdLaborCost";
            public const string StdBurdenCost = "PartCost.StdBurdenCost";
            public const string StdMaterialCost = "PartCost.StdMaterialCost";
            public const string StdSubContCost = "PartCost.StdSubContCost";
            public const string StdMtlBurCost = "PartCost.StdMtlBurCost";
            public const string LastLaborCost = "PartCost.LastLaborCost";
            public const string LastBurdenCost = "PartCost.LastBurdenCost";
            public const string LastMaterialCost = "PartCost.LastMaterialCost";
            public const string LastSubContCost = "PartCost.LastSubContCost";
            public const string LastMtlBurCost = "PartCost.LastMtlBurCost";
            public const string CostID = "PartCost.CostID";
            public const string FIFOAvgLaborCost = "PartCost.FIFOAvgLaborCost";
            public const string FIFOAvgBurdenCost = "PartCost.FIFOAvgBurdenCost";
            public const string FIFOAvgMaterialCost = "PartCost.FIFOAvgMaterialCost";
            public const string FIFOAvgSubContCost = "PartCost.FIFOAvgSubContCost";
            public const string FIFOAvgMtlBurCost = "PartCost.FIFOAvgMtlBurCost";
            public const string SysRowID = "PartCost.SysRowID";
            public const string SysRevID = "PartCost.SysRevID";
            public const string BitFlag = "PartCost.BitFlag";
            public const string WasWrittenByAspacia = "PartCost.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AvgLaborCost", 25, 5, schemaColumnName: "AvgLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AvgBurdenCost", 25, 5, schemaColumnName: "AvgBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AvgMaterialCost", 25, 5, schemaColumnName: "AvgMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AvgSubContCost", 25, 5, schemaColumnName: "AvgSubContCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AvgMtlBurCost", 25, 5, schemaColumnName: "AvgMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "StdLaborCost", 25, 5, schemaColumnName: "StdLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "StdBurdenCost", 25, 5, schemaColumnName: "StdBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "StdMaterialCost", 25, 5, schemaColumnName: "StdMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "StdSubContCost", 25, 5, schemaColumnName: "StdSubContCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "StdMtlBurCost", 25, 5, schemaColumnName: "StdMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LastLaborCost", 25, 5, schemaColumnName: "LastLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LastBurdenCost", 25, 5, schemaColumnName: "LastBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LastMaterialCost", 25, 5, schemaColumnName: "LastMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LastSubContCost", 25, 5, schemaColumnName: "LastSubContCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LastMtlBurCost", 25, 5, schemaColumnName: "LastMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CostID", 16, schemaColumnName: "CostID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "FIFOAvgLaborCost", 20, 5, schemaColumnName: "FIFOAvgLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "FIFOAvgBurdenCost", 20, 5, schemaColumnName: "FIFOAvgBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "FIFOAvgMaterialCost", 20, 5, schemaColumnName: "FIFOAvgMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "FIFOAvgSubContCost", 20, 5, schemaColumnName: "FIFOAvgSubContCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "FIFOAvgMtlBurCost", 20, 5, schemaColumnName: "FIFOAvgMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartCost.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartCost.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartCost.CostID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartMtl : SFEpic.Data.SchemaTable
        {
            public PartMtl()
                : base("PartMtl")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartMtl.CompanyNum";
            public const string PartNum = "PartMtl.PartNum";
            public const string RevisionNum = "PartMtl.RevisionNum";
            public const string MtlSeq = "PartMtl.MtlSeq";
            public const string QtyPer = "PartMtl.QtyPer";
            public const string MtlPartNum = "PartMtl.MtlPartNum";
            public const string FindNum = "PartMtl.FindNum";
            public const string FixedQty = "PartMtl.FixedQty";
            public const string RelatedOperation = "PartMtl.RelatedOperation";
            public const string OverRideMfgComments = "PartMtl.OverRideMfgComments";
            public const string SalvagePartNum = "PartMtl.SalvagePartNum";
            public const string SalvageDescription = "PartMtl.SalvageDescription";
            public const string SalvageQtyPer = "PartMtl.SalvageQtyPer";
            public const string SalvageUM = "PartMtl.SalvageUM";
            public const string SalvageUnitCredit = "PartMtl.SalvageUnitCredit";
            public const string MfgComment = "PartMtl.MfgComment";
            public const string OverRidePurComments = "PartMtl.OverRidePurComments";
            public const string PurComment = "PartMtl.PurComment";
            public const string EstScrap = "PartMtl.EstScrap";
            public const string EstScrapType = "PartMtl.EstScrapType";
            public const string PullAsAsm = "PartMtl.PullAsAsm";
            public const string ViewAsAsm = "PartMtl.ViewAsAsm";
            public const string APSSchedulerName = "PartMtl.APSSchedulerName";
            public const string APSSLDate = "PartMtl.APSSLDate";
            public const string APSSLTime = "PartMtl.APSSLTime";
            public const string APSInsertDirection = "PartMtl.APSInsertDirection";
            public const string APSInsertCriteria = "PartMtl.APSInsertCriteria";
            public const string APSAttrib1 = "PartMtl.APSAttrib1";
            public const string APSAttrib2 = "PartMtl.APSAttrib2";
            public const string APSAttrib3 = "PartMtl.APSAttrib3";
            public const string APSAttrib4 = "PartMtl.APSAttrib4";
            public const string APSAddResType = "PartMtl.APSAddResType";
            public const string SalvageMtlBurRate = "PartMtl.SalvageMtlBurRate";
            public const string SalvageEstMtlBurUnitCredit = "PartMtl.SalvageEstMtlBurUnitCredit";
            public const string MtlBurRate = "PartMtl.MtlBurRate";
            public const string EstMtlBurUnitCost = "PartMtl.EstMtlBurUnitCost";
            public const string RFQNeeded = "PartMtl.RFQNeeded";
            public const string RFQVendQuotes = "PartMtl.RFQVendQuotes";
            public const string AnalysisCode = "PartMtl.AnalysisCode";
            public const string ReqdInPlant = "PartMtl.ReqdInPlant";
            public const string AltMethod = "PartMtl.AltMethod";
            public const string BaseMethodOverridden = "PartMtl.BaseMethodOverridden";
            public const string RelatedStage = "PartMtl.RelatedStage";
            public const string ParentAltMethod = "PartMtl.ParentAltMethod";
            public const string ParentMtlSeq = "PartMtl.ParentMtlSeq";
            public const string UOMCode = "PartMtl.UOMCode";
            public const string SysRowID = "PartMtl.SysRowID";
            public const string SysRevID = "PartMtl.SysRevID";
            public const string Weight = "PartMtl.Weight";
            public const string WeightUOM = "PartMtl.WeightUOM";
            public const string RuleTag = "PartMtl.RuleTag";
            public const string BitFlag = "PartMtl.BitFlag";
            public const string ReqRefDes = "PartMtl.ReqRefDes";
            public const string WasWrittenByAspacia = "PartMtl.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "MtlSeq", schemaColumnName: "MtlSeq", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QtyPer", 25, 8, schemaColumnName: "QtyPer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MtlPartNum", 100, schemaColumnName: "MtlPartNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "FindNum", 20, schemaColumnName: "FindNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "FixedQty", schemaColumnName: "FixedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "RelatedOperation", schemaColumnName: "RelatedOperation", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OverRideMfgComments", schemaColumnName: "OverRideMfgComments", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SalvagePartNum", 100, schemaColumnName: "SalvagePartNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SalvageDescription", 2000, schemaColumnName: "SalvageDescription", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalvageQtyPer", 25, 8, schemaColumnName: "SalvageQtyPer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SalvageUM", 12, schemaColumnName: "SalvageUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalvageUnitCredit", 25, 5, schemaColumnName: "SalvageUnitCredit", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MfgComment", 2000, schemaColumnName: "MfgComment", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OverRidePurComments", schemaColumnName: "OverRidePurComments", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurComment", 2000, schemaColumnName: "PurComment", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstScrap", 25, 2, schemaColumnName: "EstScrap", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EstScrapType", 2, schemaColumnName: "EstScrapType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PullAsAsm", schemaColumnName: "PullAsAsm", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ViewAsAsm", schemaColumnName: "ViewAsAsm", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSSchedulerName", 22, schemaColumnName: "APSSchedulerName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "APSSLDate", schemaColumnName: "APSSLDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSSLTime", 25, 2, schemaColumnName: "APSSLTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSInsertDirection", 2, schemaColumnName: "APSInsertDirection", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSInsertCriteria", 2, schemaColumnName: "APSInsertCriteria", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSAttrib1", 25, 2, schemaColumnName: "APSAttrib1", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSAttrib2", 25, 2, schemaColumnName: "APSAttrib2", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSAttrib3", 25, 2, schemaColumnName: "APSAttrib3", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSAttrib4", 25, 2, schemaColumnName: "APSAttrib4", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSAddResType", 2, schemaColumnName: "APSAddResType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalvageMtlBurRate", 25, 2, schemaColumnName: "SalvageMtlBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalvageEstMtlBurUnitCredit", 25, 5, schemaColumnName: "SalvageEstMtlBurUnitCredit", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MtlBurRate", 25, 2, schemaColumnName: "MtlBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstMtlBurUnitCost", 25, 5, schemaColumnName: "EstMtlBurUnitCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RFQNeeded", schemaColumnName: "RFQNeeded", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "RFQVendQuotes", schemaColumnName: "RFQVendQuotes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AnalysisCode", 16, schemaColumnName: "AnalysisCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ReqdInPlant", 16, schemaColumnName: "ReqdInPlant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethod", 24, schemaColumnName: "AltMethod", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BaseMethodOverridden", schemaColumnName: "BaseMethodOverridden", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RelatedStage", 16, schemaColumnName: "RelatedStage", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ParentAltMethod", 24, schemaColumnName: "ParentAltMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ParentMtlSeq", schemaColumnName: "ParentMtlSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMCode", 12, schemaColumnName: "UOMCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Weight", 20, 5, schemaColumnName: "Weight", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WeightUOM", 12, schemaColumnName: "WeightUOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RuleTag", 16, schemaColumnName: "RuleTag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReqRefDes", schemaColumnName: "ReqRefDes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartMtl.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartMtl.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartMtl.RevisionNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartMtl.AltMethod"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartMtl.MtlSeq"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartOpDtl : SFEpic.Data.SchemaTable
        {
            public PartOpDtl()
                : base("PartOpDtl")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartOpDtl.CompanyNum";
            public const string PartNum = "PartOpDtl.PartNum";
            public const string RevisionNum = "PartOpDtl.RevisionNum";
            public const string OprSeq = "PartOpDtl.OprSeq";
            public const string OpDtlSeq = "PartOpDtl.OpDtlSeq";
            public const string CapabilityID = "PartOpDtl.CapabilityID";
            public const string ResourceGrpID = "PartOpDtl.ResourceGrpID";
            public const string ResourceID = "PartOpDtl.ResourceID";
            public const string Obsolete803_SchedResourceID = "PartOpDtl.Obsolete803_SchedResourceID";
            public const string SetupHours = "PartOpDtl.SetupHours";
            public const string ProdHours = "PartOpDtl.ProdHours";
            public const string NumResources = "PartOpDtl.NumResources";
            public const string SetupOrProd = "PartOpDtl.SetupOrProd";
            public const string AltMethod = "PartOpDtl.AltMethod";
            public const string BaseMethodOverridden = "PartOpDtl.BaseMethodOverridden";
            public const string OpDtlDesc = "PartOpDtl.OpDtlDesc";
            public const string ParentAltMethod = "PartOpDtl.ParentAltMethod";
            public const string ParentOprSeq = "PartOpDtl.ParentOprSeq";
            public const string ParentOpDtlSeq = "PartOpDtl.ParentOpDtlSeq";
            public const string ConcurrentCapacity = "PartOpDtl.ConcurrentCapacity";
            public const string DailyProdRate = "PartOpDtl.DailyProdRate";
            public const string ProdCrewSize = "PartOpDtl.ProdCrewSize";
            public const string SetUpCrewSize = "PartOpDtl.SetUpCrewSize";
            public const string SysRowID = "PartOpDtl.SysRowID";
            public const string SysRevID = "PartOpDtl.SysRevID";
            public const string BitFlag = "PartOpDtl.BitFlag";
            public const string WasWrittenByAspacia = "PartOpDtl.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OprSeq", schemaColumnName: "OprSeq", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OpDtlSeq", schemaColumnName: "OpDtlSeq", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CapabilityID", 16, schemaColumnName: "CapabilityID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceGrpID", 16, schemaColumnName: "ResourceGrpID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceID", 24, schemaColumnName: "ResourceID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete803_SchedResourceID", 16, schemaColumnName: "Obsolete803-SchedResourceID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetupHours", 25, 2, schemaColumnName: "SetupHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdHours", 25, 5, schemaColumnName: "ProdHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "NumResources", schemaColumnName: "NumResources", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SetupOrProd", 2, schemaColumnName: "SetupOrProd", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethod", 24, schemaColumnName: "AltMethod", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BaseMethodOverridden", schemaColumnName: "BaseMethodOverridden", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpDtlDesc", 60, schemaColumnName: "OpDtlDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ParentAltMethod", 24, schemaColumnName: "ParentAltMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ParentOprSeq", schemaColumnName: "ParentOprSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ParentOpDtlSeq", schemaColumnName: "ParentOpDtlSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ConcurrentCapacity", 25, 2, schemaColumnName: "ConcurrentCapacity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DailyProdRate", 25, 6, schemaColumnName: "DailyProdRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdCrewSize", 25, 2, schemaColumnName: "ProdCrewSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetUpCrewSize", 25, 2, schemaColumnName: "SetUpCrewSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartOpDtl.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpDtl.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpDtl.RevisionNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpDtl.AltMethod"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpDtl.OprSeq"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpDtl.OpDtlSeq"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartOpr : SFEpic.Data.SchemaTable
        {
            public PartOpr()
                : base("PartOpr")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartOpr.CompanyNum";
            public const string PartNum = "PartOpr.PartNum";
            public const string RevisionNum = "PartOpr.RevisionNum";
            public const string OprSeq = "PartOpr.OprSeq";
            public const string OpCode = "PartOpr.OpCode";
            public const string OpStdID = "PartOpr.OpStdID";
            public const string EstSetHours = "PartOpr.EstSetHours";
            public const string EstProdHours = "PartOpr.EstProdHours";
            public const string ProdStandard = "PartOpr.ProdStandard";
            public const string StdFormat = "PartOpr.StdFormat";
            public const string StdBasis = "PartOpr.StdBasis";
            public const string OpsPerPart = "PartOpr.OpsPerPart";
            public const string QtyPer = "PartOpr.QtyPer";
            public const string Machines = "PartOpr.Machines";
            public const string SetUpCrewSize = "PartOpr.SetUpCrewSize";
            public const string ProdCrewSize = "PartOpr.ProdCrewSize";
            public const string EstScrap = "PartOpr.EstScrap";
            public const string EstScrapType = "PartOpr.EstScrapType";
            public const string SubContract = "PartOpr.SubContract";
            public const string IUM = "PartOpr.IUM";
            public const string EstUnitCost = "PartOpr.EstUnitCost";
            public const string DaysOut = "PartOpr.DaysOut";
            public const string Obsolete803_BrkQty = "PartOpr.Obsolete803_BrkQty";
            public const string VendorNum = "PartOpr.VendorNum";
            public const string PurPoint = "PartOpr.PurPoint";
            public const string CommentText = "PartOpr.CommentText";
            public const string SchedRelation = "PartOpr.SchedRelation";
            public const string RunQty = "PartOpr.RunQty";
            public const string SubPartNum = "PartOpr.SubPartNum";
            public const string Obsolete803_PBrkCost = "PartOpr.Obsolete803_PBrkCost";
            public const string Obsolete803_PBrkStdRate = "PartOpr.Obsolete803_PBrkStdRate";
            public const string AddlSetupHours = "PartOpr.AddlSetupHours";
            public const string AddlSetUpQty = "PartOpr.AddlSetUpQty";
            public const string APSPrepOp = "PartOpr.APSPrepOp";
            public const string APSNextOp = "PartOpr.APSNextOp";
            public const string APSAltOp = "PartOpr.APSAltOp";
            public const string APSSpecificResource = "PartOpr.APSSpecificResource";
            public const string APSCycleTime = "PartOpr.APSCycleTime";
            public const string APSConstantTime = "PartOpr.APSConstantTime";
            public const string APSSetupGroup = "PartOpr.APSSetupGroup";
            public const string APSMakeFactor = "PartOpr.APSMakeFactor";
            public const string APSContainerSize = "PartOpr.APSContainerSize";
            public const string APSSchedulerName = "PartOpr.APSSchedulerName";
            public const string APSMaxLength = "PartOpr.APSMaxLength";
            public const string APSTransferTime = "PartOpr.APSTransferTime";
            public const string APSEffectiveness = "PartOpr.APSEffectiveness";
            public const string APSOperationClass = "PartOpr.APSOperationClass";
            public const string APSAuxResource = "PartOpr.APSAuxResource";
            public const string APSAddResource = "PartOpr.APSAddResource";
            public const string LaborEntryMethod = "PartOpr.LaborEntryMethod";
            public const string FAQty = "PartOpr.FAQty";
            public const string RFQNeeded = "PartOpr.RFQNeeded";
            public const string RFQVendQuotes = "PartOpr.RFQVendQuotes";
            public const string SetupGroup = "PartOpr.SetupGroup";
            public const string AnalysisCode = "PartOpr.AnalysisCode";
            public const string PrimarySetupOpDtl = "PartOpr.PrimarySetupOpDtl";
            public const string PrimaryProdOpDtl = "PartOpr.PrimaryProdOpDtl";
            public const string RtgGroup = "PartOpr.RtgGroup";
            public const string AltMethod = "PartOpr.AltMethod";
            public const string BaseMethodOverridden = "PartOpr.BaseMethodOverridden";
            public const string StageNumber = "PartOpr.StageNumber";
            public const string OpDesc = "PartOpr.OpDesc";
            public const string ParentAltMethod = "PartOpr.ParentAltMethod";
            public const string ParentOprSeq = "PartOpr.ParentOprSeq";
            public const string PBrkCost07 = "PartOpr.PBrkCost07";
            public const string PBrkCost08 = "PartOpr.PBrkCost08";
            public const string PBrkCost09 = "PartOpr.PBrkCost09";
            public const string PBrkCost10 = "PartOpr.PBrkCost10";
            public const string PBrkStdRate01 = "PartOpr.PBrkStdRate01";
            public const string PBrkStdRate02 = "PartOpr.PBrkStdRate02";
            public const string PBrkStdRate03 = "PartOpr.PBrkStdRate03";
            public const string PBrkStdRate04 = "PartOpr.PBrkStdRate04";
            public const string PBrkStdRate05 = "PartOpr.PBrkStdRate05";
            public const string PBrkStdRate06 = "PartOpr.PBrkStdRate06";
            public const string PBrkStdRate07 = "PartOpr.PBrkStdRate07";
            public const string PBrkStdRate08 = "PartOpr.PBrkStdRate08";
            public const string PBrkStdRate09 = "PartOpr.PBrkStdRate09";
            public const string PBrkStdRate10 = "PartOpr.PBrkStdRate10";
            public const string BrkQty01 = "PartOpr.BrkQty01";
            public const string BrkQty02 = "PartOpr.BrkQty02";
            public const string BrkQty03 = "PartOpr.BrkQty03";
            public const string BrkQty04 = "PartOpr.BrkQty04";
            public const string BrkQty05 = "PartOpr.BrkQty05";
            public const string BrkQty06 = "PartOpr.BrkQty06";
            public const string BrkQty07 = "PartOpr.BrkQty07";
            public const string BrkQty08 = "PartOpr.BrkQty08";
            public const string BrkQty09 = "PartOpr.BrkQty09";
            public const string BrkQty10 = "PartOpr.BrkQty10";
            public const string PBrkCost01 = "PartOpr.PBrkCost01";
            public const string PBrkCost02 = "PartOpr.PBrkCost02";
            public const string PBrkCost03 = "PartOpr.PBrkCost03";
            public const string PBrkCost04 = "PartOpr.PBrkCost04";
            public const string PBrkCost05 = "PartOpr.PBrkCost05";
            public const string PBrkCost06 = "PartOpr.PBrkCost06";
            public const string SNRequiredOpr = "PartOpr.SNRequiredOpr";
            public const string SNRequiredSubConShip = "PartOpr.SNRequiredSubConShip";
            public const string SysRowID = "PartOpr.SysRowID";
            public const string SysRevID = "PartOpr.SysRevID";
            public const string Weight = "PartOpr.Weight";
            public const string WeightUOM = "PartOpr.WeightUOM";
            public const string BitFlag = "PartOpr.BitFlag";
            public const string WasWrittenByAspacia = "PartOpr.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OprSeq", schemaColumnName: "OprSeq", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpCode", 16, schemaColumnName: "OpCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpStdID", 10, schemaColumnName: "OpStdID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstSetHours", 25, 2, schemaColumnName: "EstSetHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstProdHours", 25, 5, schemaColumnName: "EstProdHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdStandard", 25, 8, schemaColumnName: "ProdStandard", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "StdFormat", 4, schemaColumnName: "StdFormat", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "StdBasis", 2, schemaColumnName: "StdBasis", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "OpsPerPart", schemaColumnName: "OpsPerPart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QtyPer", 25, 8, schemaColumnName: "QtyPer", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "Machines", schemaColumnName: "Machines", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetUpCrewSize", 25, 2, schemaColumnName: "SetUpCrewSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdCrewSize", 25, 2, schemaColumnName: "ProdCrewSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstScrap", 25, 2, schemaColumnName: "EstScrap", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "EstScrapType", 2, schemaColumnName: "EstScrapType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SubContract", schemaColumnName: "SubContract", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "IUM", 12, schemaColumnName: "IUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "EstUnitCost", 25, 5, schemaColumnName: "EstUnitCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DaysOut", 25, 2, schemaColumnName: "DaysOut", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete803_BrkQty", 280, schemaColumnName: "Obsolete803-BrkQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CommentText", 2000, schemaColumnName: "CommentText", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SchedRelation", 4, schemaColumnName: "SchedRelation", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "RunQty", 25, 8, schemaColumnName: "RunQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SubPartNum", 100, schemaColumnName: "SubPartNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete803_PBrkCost", 320, schemaColumnName: "Obsolete803-PBrkCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete803_PBrkStdRate", 280, schemaColumnName: "Obsolete803-PBrkStdRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AddlSetupHours", 25, 2, schemaColumnName: "AddlSetupHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AddlSetUpQty", 25, 8, schemaColumnName: "AddlSetUpQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "APSPrepOp", schemaColumnName: "APSPrepOp", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "APSNextOp", schemaColumnName: "APSNextOp", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "APSAltOp", schemaColumnName: "APSAltOp", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSSpecificResource", 22, schemaColumnName: "APSSpecificResource", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSCycleTime", 25, 4, schemaColumnName: "APSCycleTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSConstantTime", 25, 4, schemaColumnName: "APSConstantTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "APSSetupGroup", schemaColumnName: "APSSetupGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "APSMakeFactor", schemaColumnName: "APSMakeFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSContainerSize", 25, 2, schemaColumnName: "APSContainerSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSSchedulerName", 22, schemaColumnName: "APSSchedulerName", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSMaxLength", 25, 2, schemaColumnName: "APSMaxLength", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSTransferTime", 25, 2, schemaColumnName: "APSTransferTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "APSEffectiveness", 25, 3, schemaColumnName: "APSEffectiveness", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSOperationClass", 2, schemaColumnName: "APSOperationClass", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSAuxResource", 200, schemaColumnName: "APSAuxResource", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "APSAddResource", 200, schemaColumnName: "APSAddResource", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LaborEntryMethod", 2, schemaColumnName: "LaborEntryMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "FAQty", 25, 8, schemaColumnName: "FAQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "RFQNeeded", schemaColumnName: "RFQNeeded", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "RFQVendQuotes", schemaColumnName: "RFQVendQuotes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SetupGroup", 16, schemaColumnName: "SetupGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AnalysisCode", 16, schemaColumnName: "AnalysisCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimarySetupOpDtl", schemaColumnName: "PrimarySetupOpDtl", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrimaryProdOpDtl", schemaColumnName: "PrimaryProdOpDtl", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "RtgGroup", schemaColumnName: "RtgGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethod", 24, schemaColumnName: "AltMethod", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BaseMethodOverridden", schemaColumnName: "BaseMethodOverridden", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "StageNumber", 16, schemaColumnName: "StageNumber", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpDesc", 60, schemaColumnName: "OpDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ParentAltMethod", 24, schemaColumnName: "ParentAltMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ParentOprSeq", schemaColumnName: "ParentOprSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost07", 28, 5, schemaColumnName: "PBrkCost07", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost08", 28, 5, schemaColumnName: "PBrkCost08", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost09", 28, 5, schemaColumnName: "PBrkCost09", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost10", 28, 5, schemaColumnName: "PBrkCost10", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate01", 28, 5, schemaColumnName: "PBrkStdRate01", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate02", 28, 5, schemaColumnName: "PBrkStdRate02", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate03", 28, 5, schemaColumnName: "PBrkStdRate03", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate04", 28, 5, schemaColumnName: "PBrkStdRate04", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate05", 28, 5, schemaColumnName: "PBrkStdRate05", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate06", 28, 5, schemaColumnName: "PBrkStdRate06", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate07", 28, 5, schemaColumnName: "PBrkStdRate07", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate08", 28, 5, schemaColumnName: "PBrkStdRate08", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate09", 28, 5, schemaColumnName: "PBrkStdRate09", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkStdRate10", 28, 5, schemaColumnName: "PBrkStdRate10", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty01", 28, 8, schemaColumnName: "BrkQty01", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty02", 28, 8, schemaColumnName: "BrkQty02", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty03", 28, 8, schemaColumnName: "BrkQty03", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty04", 28, 8, schemaColumnName: "BrkQty04", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty05", 28, 8, schemaColumnName: "BrkQty05", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty06", 28, 8, schemaColumnName: "BrkQty06", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty07", 28, 8, schemaColumnName: "BrkQty07", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty08", 28, 8, schemaColumnName: "BrkQty08", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty09", 28, 8, schemaColumnName: "BrkQty09", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BrkQty10", 28, 8, schemaColumnName: "BrkQty10", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost01", 28, 5, schemaColumnName: "PBrkCost01", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost02", 28, 5, schemaColumnName: "PBrkCost02", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost03", 28, 5, schemaColumnName: "PBrkCost03", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost04", 28, 5, schemaColumnName: "PBrkCost04", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost05", 28, 5, schemaColumnName: "PBrkCost05", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PBrkCost06", 28, 5, schemaColumnName: "PBrkCost06", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SNRequiredOpr", schemaColumnName: "SNRequiredOpr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SNRequiredSubConShip", schemaColumnName: "SNRequiredSubConShip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Weight", 20, 5, schemaColumnName: "Weight", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WeightUOM", 12, schemaColumnName: "WeightUOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartOpr.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpr.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpr.RevisionNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpr.AltMethod"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartOpr.OprSeq"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartPlant : SFEpic.Data.SchemaTable
        {
            public PartPlant()
                : base("PartPlant")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartPlant.CompanyNum";
            public const string PartNum = "PartPlant.PartNum";
            public const string PrimWhse = "PartPlant.PrimWhse";
            public const string MinimumQty = "PartPlant.MinimumQty";
            public const string MaximumQty = "PartPlant.MaximumQty";
            public const string SafetyQty = "PartPlant.SafetyQty";
            public const string MinOrderQty = "PartPlant.MinOrderQty";
            public const string LeadTime = "PartPlant.LeadTime";
            public const string MinMfgLotSize = "PartPlant.MinMfgLotSize";
            public const string Obsolete900_MinAbc = "PartPlant.Obsolete900_MinAbc";
            public const string Obsolete900_SystemAbc = "PartPlant.Obsolete900_SystemAbc";
            public const string VendorNum = "PartPlant.VendorNum";
            public const string Obsolete900_AllocQty = "PartPlant.Obsolete900_AllocQty";
            public const string PurPoint = "PartPlant.PurPoint";
            public const string BackFlush = "PartPlant.BackFlush";
            public const string MfgLotSize = "PartPlant.MfgLotSize";
            public const string PlantNum = "PartPlant.PlantNum";
            public const string MaxMfgLotSize = "PartPlant.MaxMfgLotSize";
            public const string MfgLotMultiple = "PartPlant.MfgLotMultiple";
            public const string MRPRecalcNeeded = "PartPlant.MRPRecalcNeeded";
            public const string ProcessMRP = "PartPlant.ProcessMRP";
            public const string GenerateSugg = "PartPlant.GenerateSugg";
            public const string DaysOfSupply = "PartPlant.DaysOfSupply";
            public const string ReOrderLevel = "PartPlant.ReOrderLevel";
            public const string GetFromLocalWhse = "PartPlant.GetFromLocalWhse";
            public const string ForecastTime = "PartPlant.ForecastTime";
            public const string TransferPlant = "PartPlant.TransferPlant";
            public const string SourceType = "PartPlant.SourceType";
            public const string TransferLeadTime = "PartPlant.TransferLeadTime";
            public const string PlanTimeFence = "PartPlant.PlanTimeFence";
            public const string ReschedOutDelta = "PartPlant.ReschedOutDelta";
            public const string ReschedInDelta = "PartPlant.ReschedInDelta";
            public const string NonStock = "PartPlant.NonStock";
            public const string PhantomBOM = "PartPlant.PhantomBOM";
            public const string BuyerID = "PartPlant.BuyerID";
            public const string PersonID = "PartPlant.PersonID";
            public const string CostMethod = "PartPlant.CostMethod";
            public const string PrepTime = "PartPlant.PrepTime";
            public const string ReceiveTime = "PartPlant.ReceiveTime";
            public const string AltMethod = "PartPlant.AltMethod";
            public const string KitTime = "PartPlant.KitTime";
            public const string KitAllowUpdate = "PartPlant.KitAllowUpdate";
            public const string KitBackFlush = "PartPlant.KitBackFlush";
            public const string KitPricing = "PartPlant.KitPricing";
            public const string KitPrintCompsPS = "PartPlant.KitPrintCompsPS";
            public const string KitPrintCompsInv = "PartPlant.KitPrintCompsInv";
            public const string KitShipComplete = "PartPlant.KitShipComplete";
            public const string KitAllowChangeParms = "PartPlant.KitAllowChangeParms";
            public const string ShortHorizonMaxMfgLotSize = "PartPlant.ShortHorizonMaxMfgLotSize";
            public const string ShortHorizonDays = "PartPlant.ShortHorizonDays";
            public const string ShortHorizonMinMfgLotSize = "PartPlant.ShortHorizonMinMfgLotSize";
            public const string LimitProdYldRecalc = "PartPlant.LimitProdYldRecalc";
            public const string QtyBearing = "PartPlant.QtyBearing";
            public const string MRPLastScheduledDate = "PartPlant.MRPLastScheduledDate";
            public const string MRPLastCutOffDate = "PartPlant.MRPLastCutOffDate";
            public const string MRPLastRunDate = "PartPlant.MRPLastRunDate";
            public const string MRPLastRunTime = "PartPlant.MRPLastRunTime";
            public const string ShortHorizonDaysSupp = "PartPlant.ShortHorizonDaysSupp";
            public const string SNBaseDataType = "PartPlant.SNBaseDataType";
            public const string SNFormat = "PartPlant.SNFormat";
            public const string SNPrefix = "PartPlant.SNPrefix";
            public const string SNMaskSuffix = "PartPlant.SNMaskSuffix";
            public const string SNMaskPrefix = "PartPlant.SNMaskPrefix";
            public const string SNLastUsedSeq = "PartPlant.SNLastUsedSeq";
            public const string SNMask = "PartPlant.SNMask";
            public const string SNMaskExample = "PartPlant.SNMaskExample";
            public const string UseMaskSeq = "PartPlant.UseMaskSeq";
            public const string SysRowID = "PartPlant.SysRowID";
            public const string SysRevID = "PartPlant.SysRevID";
            public const string BuyToOrder = "PartPlant.BuyToOrder";
            public const string DropShip = "PartPlant.DropShip";
            public const string CalcQty = "PartPlant.CalcQty";
            public const string CalcValue = "PartPlant.CalcValue";
            public const string QtyAdjTolerance = "PartPlant.QtyAdjTolerance";
            public const string PcntTolerance = "PartPlant.PcntTolerance";
            public const string CalcPcnt = "PartPlant.CalcPcnt";
            public const string QtyTolerance = "PartPlant.QtyTolerance";
            public const string ValueTolerance = "PartPlant.ValueTolerance";
            public const string ReservedQty = "PartPlant.ReservedQty";
            public const string AllocatedQty = "PartPlant.AllocatedQty";
            public const string XRefPartNum = "PartPlant.XRefPartNum";
            public const string XRefPartType = "PartPlant.XRefPartType";
            public const string DemandQty = "PartPlant.DemandQty";
            public const string BitFlag = "PartPlant.BitFlag";
            public const string WasWrittenByAspacia = "PartPlant.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PrimWhse", 16, schemaColumnName: "PrimWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MinimumQty", 25, 8, schemaColumnName: "MinimumQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MaximumQty", 25, 8, schemaColumnName: "MaximumQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SafetyQty", 25, 8, schemaColumnName: "SafetyQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MinOrderQty", 25, 8, schemaColumnName: "MinOrderQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "LeadTime", schemaColumnName: "LeadTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MinMfgLotSize", 25, 2, schemaColumnName: "MinMfgLotSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete900_MinAbc", 2, schemaColumnName: "Obsolete900-MinAbc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Obsolete900_SystemAbc", 2, schemaColumnName: "Obsolete900-SystemAbc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete900_AllocQty", 25, 8, schemaColumnName: "Obsolete900-AllocQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PurPoint", 8, schemaColumnName: "PurPoint", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BackFlush", schemaColumnName: "BackFlush", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MfgLotSize", 25, 2, schemaColumnName: "MfgLotSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MaxMfgLotSize", 25, 2, schemaColumnName: "MaxMfgLotSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MfgLotMultiple", 25, 2, schemaColumnName: "MfgLotMultiple", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "MRPRecalcNeeded", schemaColumnName: "MRPRecalcNeeded", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ProcessMRP", schemaColumnName: "ProcessMRP", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GenerateSugg", schemaColumnName: "GenerateSugg", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "DaysOfSupply", schemaColumnName: "DaysOfSupply", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ReOrderLevel", schemaColumnName: "ReOrderLevel", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GetFromLocalWhse", schemaColumnName: "GetFromLocalWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ForecastTime", schemaColumnName: "ForecastTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "TransferPlant", 16, schemaColumnName: "TransferPlant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SourceType", 2, schemaColumnName: "SourceType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "TransferLeadTime", schemaColumnName: "TransferLeadTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PlanTimeFence", schemaColumnName: "PlanTimeFence", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReschedOutDelta", schemaColumnName: "ReschedOutDelta", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReschedInDelta", schemaColumnName: "ReschedInDelta", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "NonStock", schemaColumnName: "NonStock", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PhantomBOM", schemaColumnName: "PhantomBOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BuyerID", 16, schemaColumnName: "BuyerID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PersonID", 16, schemaColumnName: "PersonID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CostMethod", 2, schemaColumnName: "CostMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "PrepTime", schemaColumnName: "PrepTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReceiveTime", schemaColumnName: "ReceiveTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethod", 24, schemaColumnName: "AltMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "KitTime", schemaColumnName: "KitTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "KitAllowUpdate", schemaColumnName: "KitAllowUpdate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "KitBackFlush", schemaColumnName: "KitBackFlush", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "KitPricing", 2, schemaColumnName: "KitPricing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "KitPrintCompsPS", schemaColumnName: "KitPrintCompsPS", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "KitPrintCompsInv", schemaColumnName: "KitPrintCompsInv", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "KitShipComplete", schemaColumnName: "KitShipComplete", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "KitAllowChangeParms", schemaColumnName: "KitAllowChangeParms", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ShortHorizonMaxMfgLotSize", 17, 2, schemaColumnName: "ShortHorizonMaxMfgLotSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ShortHorizonDays", schemaColumnName: "ShortHorizonDays", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ShortHorizonMinMfgLotSize", 17, 2, schemaColumnName: "ShortHorizonMinMfgLotSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "LimitProdYldRecalc", schemaColumnName: "LimitProdYldRecalc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "QtyBearing", schemaColumnName: "QtyBearing", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "MRPLastScheduledDate", schemaColumnName: "MRPLastScheduledDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "MRPLastCutOffDate", schemaColumnName: "MRPLastCutOffDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "MRPLastRunDate", schemaColumnName: "MRPLastRunDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "MRPLastRunTime", schemaColumnName: "MRPLastRunTime", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ShortHorizonDaysSupp", schemaColumnName: "ShortHorizonDaysSupp", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNBaseDataType", 20, schemaColumnName: "SNBaseDataType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNFormat", 160, schemaColumnName: "SNFormat", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNPrefix", 60, schemaColumnName: "SNPrefix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMaskSuffix", 20, schemaColumnName: "SNMaskSuffix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMaskPrefix", 20, schemaColumnName: "SNMaskPrefix", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNLastUsedSeq", 80, schemaColumnName: "SNLastUsedSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMask", 40, schemaColumnName: "SNMask", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SNMaskExample", 160, schemaColumnName: "SNMaskExample", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseMaskSeq", schemaColumnName: "UseMaskSeq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BuyToOrder", schemaColumnName: "BuyToOrder", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DropShip", schemaColumnName: "DropShip", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcQty", schemaColumnName: "CalcQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcValue", schemaColumnName: "CalcValue", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QtyAdjTolerance", 23, 8, schemaColumnName: "QtyAdjTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PcntTolerance", 17, 2, schemaColumnName: "PcntTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcPcnt", schemaColumnName: "CalcPcnt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QtyTolerance", 15, 0, schemaColumnName: "QtyTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ValueTolerance", 15, 0, schemaColumnName: "ValueTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ReservedQty", 23, 8, schemaColumnName: "ReservedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AllocatedQty", 23, 8, schemaColumnName: "AllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "XRefPartNum", 100, schemaColumnName: "XRefPartNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "XRefPartType", 2, schemaColumnName: "XRefPartType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DemandQty", 23, 8, schemaColumnName: "DemandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartPlant.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartPlant.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartPlant.PlantNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartRev : SFEpic.Data.SchemaTable
        {
            public PartRev()
                : base("PartRev")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartRev.CompanyNum";
            public const string PartNum = "PartRev.PartNum";
            public const string RevShortDesc = "PartRev.RevShortDesc";
            public const string RevDescription = "PartRev.RevDescription";
            public const string RevisionNum = "PartRev.RevisionNum";
            public const string Approved = "PartRev.Approved";
            public const string ApprovedDate = "PartRev.ApprovedDate";
            public const string ApprovedBy = "PartRev.ApprovedBy";
            public const string EffectiveDate = "PartRev.EffectiveDate";
            public const string AutoRecOpr = "PartRev.AutoRecOpr";
            public const string TLRLaborCost = "PartRev.TLRLaborCost";
            public const string TLRBurdenCost = "PartRev.TLRBurdenCost";
            public const string TLRMaterialCost = "PartRev.TLRMaterialCost";
            public const string TLRSubcontractCost = "PartRev.TLRSubcontractCost";
            public const string TLRSetupLaborCost = "PartRev.TLRSetupLaborCost";
            public const string TLRSetupBurdenCost = "PartRev.TLRSetupBurdenCost";
            public const string LLRLaborCost = "PartRev.LLRLaborCost";
            public const string LLRBurdenCost = "PartRev.LLRBurdenCost";
            public const string LLRMaterialCost = "PartRev.LLRMaterialCost";
            public const string LLRSetupLaborCost = "PartRev.LLRSetupLaborCost";
            public const string LLRSetupBurdenCost = "PartRev.LLRSetupBurdenCost";
            public const string RollupDate = "PartRev.RollupDate";
            public const string LLRSubcontractCost = "PartRev.LLRSubcontractCost";
            public const string DrawNum = "PartRev.DrawNum";
            public const string Method = "PartRev.Method";
            public const string ECO = "PartRev.ECO";
            public const string FinalOpr = "PartRev.FinalOpr";
            public const string TLRMtlBurCost = "PartRev.TLRMtlBurCost";
            public const string LLRMtlBurCost = "PartRev.LLRMtlBurCost";
            public const string PDMObjID = "PartRev.PDMObjID";
            public const string Configured = "PartRev.Configured";
            public const string WebConfigured = "PartRev.WebConfigured";
            public const string ShowInputPrice = "PartRev.ShowInputPrice";
            public const string AltMethod = "PartRev.AltMethod";
            public const string AltMethodDesc = "PartRev.AltMethodDesc";
            public const string PlantNum = "PartRev.PlantNum";
            public const string ParentAltMethod = "PartRev.ParentAltMethod";
            public const string UseStaging = "PartRev.UseStaging";
            public const string UseAltRevForParts = "PartRev.UseAltRevForParts";
            public const string OwnershipStatus = "PartRev.OwnershipStatus";
            public const string SysRowID = "PartRev.SysRowID";
            public const string SysRevID = "PartRev.SysRevID";
            public const string BitFlag = "PartRev.BitFlag";
            public const string ExtConfig = "PartRev.ExtConfig";
            public const string ValRefDes = "PartRev.ValRefDes";
            public const string PcEntprsConf = "PartRev.PcEntprsConf";
            public const string PcGlobalPart = "PartRev.PcGlobalPart";
            public const string GlobalRev = "PartRev.GlobalRev";
            public const string WasWrittenByAspacia = "PartRev.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevShortDesc", 60, schemaColumnName: "RevShortDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevDescription", 2000, schemaColumnName: "RevDescription", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "RevisionNum", 24, schemaColumnName: "RevisionNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Approved", schemaColumnName: "Approved", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "ApprovedDate", schemaColumnName: "ApprovedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ApprovedBy", 40, schemaColumnName: "ApprovedBy", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "EffectiveDate", schemaColumnName: "EffectiveDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "AutoRecOpr", schemaColumnName: "AutoRecOpr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRLaborCost", 25, 5, schemaColumnName: "TLRLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRBurdenCost", 25, 5, schemaColumnName: "TLRBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRMaterialCost", 25, 5, schemaColumnName: "TLRMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRSubcontractCost", 25, 5, schemaColumnName: "TLRSubcontractCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRSetupLaborCost", 25, 5, schemaColumnName: "TLRSetupLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRSetupBurdenCost", 25, 5, schemaColumnName: "TLRSetupBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRLaborCost", 25, 5, schemaColumnName: "LLRLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRBurdenCost", 25, 5, schemaColumnName: "LLRBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRMaterialCost", 25, 5, schemaColumnName: "LLRMaterialCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRSetupLaborCost", 25, 5, schemaColumnName: "LLRSetupLaborCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRSetupBurdenCost", 25, 5, schemaColumnName: "LLRSetupBurdenCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "RollupDate", schemaColumnName: "RollupDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRSubcontractCost", 25, 5, schemaColumnName: "LLRSubcontractCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DrawNum", 50, schemaColumnName: "DrawNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Method", schemaColumnName: "Method", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ECO", 20, schemaColumnName: "ECO", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FinalOpr", schemaColumnName: "FinalOpr", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TLRMtlBurCost", 25, 5, schemaColumnName: "TLRMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "LLRMtlBurCost", 25, 5, schemaColumnName: "LLRMtlBurCost", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PDMObjID", 16, schemaColumnName: "PDMObjID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Configured", schemaColumnName: "Configured", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WebConfigured", schemaColumnName: "WebConfigured", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ShowInputPrice", schemaColumnName: "ShowInputPrice", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethod", 24, schemaColumnName: "AltMethod", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AltMethodDesc", 60, schemaColumnName: "AltMethodDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ParentAltMethod", 24, schemaColumnName: "ParentAltMethod", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseStaging", schemaColumnName: "UseStaging", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseAltRevForParts", schemaColumnName: "UseAltRevForParts", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OwnershipStatus", 16, schemaColumnName: "OwnershipStatus", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ExtConfig", schemaColumnName: "ExtConfig", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ValRefDes", schemaColumnName: "ValRefDes", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PcEntprsConf", schemaColumnName: "PcEntprsConf", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PcGlobalPart", schemaColumnName: "PcGlobalPart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GlobalRev", schemaColumnName: "GlobalRev", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartRev.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartRev.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartRev.RevisionNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartRev.AltMethod"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartUOM : SFEpic.Data.SchemaTable
        {
            public PartUOM()
                : base("PartUOM")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PartUOM.CompanyNum";
            public const string PartNum = "PartUOM.PartNum";
            public const string UOMCode = "PartUOM.UOMCode";
            public const string ConvFactor = "PartUOM.ConvFactor";
            public const string Active = "PartUOM.Active";
            public const string TrackOnHand = "PartUOM.TrackOnHand";
            public const string NetVolume = "PartUOM.NetVolume";
            public const string NetVolumeUOM = "PartUOM.NetVolumeUOM";
            public const string SysRowID = "PartUOM.SysRowID";
            public const string SysRevID = "PartUOM.SysRevID";
            public const string BitFlag = "PartUOM.BitFlag";
            public const string HasBeenUsed = "PartUOM.HasBeenUsed";
            public const string ConvOperator = "PartUOM.ConvOperator";
            public const string WasWrittenByAspacia = "PartUOM.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMCode", 12, schemaColumnName: "UOMCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ConvFactor", 22, 7, schemaColumnName: "ConvFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Active", schemaColumnName: "Active", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackOnHand", schemaColumnName: "TrackOnHand", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "NetVolume", 20, 5, schemaColumnName: "NetVolume", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "NetVolumeUOM", 12, schemaColumnName: "NetVolumeUOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "HasBeenUsed", schemaColumnName: "HasBeenUsed", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConvOperator", 16, schemaColumnName: "ConvOperator", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartUOM.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartUOM.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartUOM.UOMCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PartWhse : SFEpic.Data.SchemaTable
        {
            public PartWhse()
                : base("PartWhse")
            {
            }

            #region Field Name Constants

            public const string PartNum = "PartWhse.PartNum";
            public const string CountedDate = "PartWhse.CountedDate";
            public const string WarehouseCode = "PartWhse.WarehouseCode";
            public const string CompanyNum = "PartWhse.CompanyNum";
            public const string Obsolete900_AllocQty = "PartWhse.Obsolete900_AllocQty";
            public const string NonNettableQty = "PartWhse.NonNettableQty";
            public const string Obsolete900_SalesAllocQty = "PartWhse.Obsolete900_SalesAllocQty";
            public const string SalesReservedQty = "PartWhse.SalesReservedQty";
            public const string OnHandQty = "PartWhse.OnHandQty";
            public const string SalesPickedQty = "PartWhse.SalesPickedQty";
            public const string SalesPickingQty = "PartWhse.SalesPickingQty";
            public const string JobReservedQty = "PartWhse.JobReservedQty";
            public const string Obsolete900_JobUnfirmAllocQty = "PartWhse.Obsolete900_JobUnfirmAllocQty";
            public const string Obsolete900_JobAllocQty = "PartWhse.Obsolete900_JobAllocQty";
            public const string KBCode = "PartWhse.KBCode";
            public const string MinimumQty = "PartWhse.MinimumQty";
            public const string MaximumQty = "PartWhse.MaximumQty";
            public const string SafetyQty = "PartWhse.SafetyQty";
            public const string KBPONUM = "PartWhse.KBPONUM";
            public const string KBPOLine = "PartWhse.KBPOLine";
            public const string KBWarehouseCode = "PartWhse.KBWarehouseCode";
            public const string KBBinNum = "PartWhse.KBBinNum";
            public const string KBPlant = "PartWhse.KBPlant";
            public const string KBQty = "PartWhse.KBQty";
            public const string SysRevID = "PartWhse.SysRevID";
            public const string SysRowID = "PartWhse.SysRowID";
            public const string CalcPcnt = "PartWhse.CalcPcnt";
            public const string CalcQty = "PartWhse.CalcQty";
            public const string CalcValue = "PartWhse.CalcValue";
            public const string QtyAdjTolerance = "PartWhse.QtyAdjTolerance";
            public const string CalcQtyAdj = "PartWhse.CalcQtyAdj";
            public const string MinAbc = "PartWhse.MinAbc";
            public const string SystemAbc = "PartWhse.SystemAbc";
            public const string ManualABC = "PartWhse.ManualABC";
            public const string LastCCDate = "PartWhse.LastCCDate";
            public const string OvrrideCountFreq = "PartWhse.OvrrideCountFreq";
            public const string CountFreq = "PartWhse.CountFreq";
            public const string PcntTolerance = "PartWhse.PcntTolerance";
            public const string ValueTolerance = "PartWhse.ValueTolerance";
            public const string QtyTolerance = "PartWhse.QtyTolerance";
            public const string AllocatedQty = "PartWhse.AllocatedQty";
            public const string ReservedQty = "PartWhse.ReservedQty";
            public const string JobAllocatedQty = "PartWhse.JobAllocatedQty";
            public const string UnfirmJobDemandQty = "PartWhse.UnfirmJobDemandQty";
            public const string TFOrdReservedQty = "PartWhse.TFOrdReservedQty";
            public const string TFOrdAllocatedQty = "PartWhse.TFOrdAllocatedQty";
            public const string SalesAllocatedQty = "PartWhse.SalesAllocatedQty";
            public const string SalesDemandQty = "PartWhse.SalesDemandQty";
            public const string JobDemandQty = "PartWhse.JobDemandQty";
            public const string JobPickingQty = "PartWhse.JobPickingQty";
            public const string JobPickedQty = "PartWhse.JobPickedQty";
            public const string TFOrdDemandQty = "PartWhse.TFOrdDemandQty";
            public const string TFOrdPickingQty = "PartWhse.TFOrdPickingQty";
            public const string TFOrdPickedQty = "PartWhse.TFOrdPickedQty";
            public const string DemandQty = "PartWhse.DemandQty";
            public const string BitFlag = "PartWhse.BitFlag";
            public const string PickingQty = "PartWhse.PickingQty";
            public const string PickedQty = "PartWhse.PickedQty";
            public const string WasWrittenByAspacia = "PartWhse.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "CountedDate", schemaColumnName: "CountedDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarehouseCode", 16, schemaColumnName: "WarehouseCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete900_AllocQty", 25, 8, schemaColumnName: "Obsolete900-AllocQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "NonNettableQty", 25, 8, schemaColumnName: "NonNettableQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete900_SalesAllocQty", 25, 8, schemaColumnName: "Obsolete900-SalesAllocQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesReservedQty", 25, 8, schemaColumnName: "SalesReservedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "OnHandQty", 25, 8, schemaColumnName: "OnHandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesPickedQty", 25, 8, schemaColumnName: "SalesPickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesPickingQty", 25, 8, schemaColumnName: "SalesPickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobReservedQty", 25, 8, schemaColumnName: "JobReservedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete900_JobUnfirmAllocQty", 25, 8, schemaColumnName: "Obsolete900-JobUnfirmAllocQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "Obsolete900_JobAllocQty", 25, 8, schemaColumnName: "Obsolete900-JobAllocQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "KBCode", 16, schemaColumnName: "KBCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MinimumQty", 25, 8, schemaColumnName: "MinimumQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MaximumQty", 25, 8, schemaColumnName: "MaximumQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SafetyQty", 25, 8, schemaColumnName: "SafetyQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "KBPONUM", schemaColumnName: "KBPONUM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "KBPOLine", schemaColumnName: "KBPOLine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "KBWarehouseCode", 16, schemaColumnName: "KBWarehouseCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "KBBinNum", 20, schemaColumnName: "KBBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "KBPlant", 16, schemaColumnName: "KBPlant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "KBQty", 25, 8, schemaColumnName: "KBQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcPcnt", schemaColumnName: "CalcPcnt", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcQty", schemaColumnName: "CalcQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcValue", schemaColumnName: "CalcValue", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QtyAdjTolerance", 23, 8, schemaColumnName: "QtyAdjTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "CalcQtyAdj", schemaColumnName: "CalcQtyAdj", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "MinAbc", 2, schemaColumnName: "MinAbc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SystemAbc", 2, schemaColumnName: "SystemAbc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "ManualABC", schemaColumnName: "ManualABC", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "LastCCDate", schemaColumnName: "LastCCDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "OvrrideCountFreq", schemaColumnName: "OvrrideCountFreq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "CountFreq", schemaColumnName: "CountFreq", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PcntTolerance", 17, 2, schemaColumnName: "PcntTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ValueTolerance", 15, 0, schemaColumnName: "ValueTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QtyTolerance", 15, 0, schemaColumnName: "QtyTolerance", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "AllocatedQty", 23, 8, schemaColumnName: "AllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ReservedQty", 23, 8, schemaColumnName: "ReservedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobAllocatedQty", 23, 8, schemaColumnName: "JobAllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "UnfirmJobDemandQty", 23, 8, schemaColumnName: "UnfirmJobDemandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdReservedQty", 23, 8, schemaColumnName: "TFOrdReservedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdAllocatedQty", 23, 8, schemaColumnName: "TFOrdAllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesAllocatedQty", 23, 8, schemaColumnName: "SalesAllocatedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SalesDemandQty", 23, 8, schemaColumnName: "SalesDemandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobDemandQty", 23, 8, schemaColumnName: "JobDemandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobPickingQty", 23, 8, schemaColumnName: "JobPickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "JobPickedQty", 23, 8, schemaColumnName: "JobPickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdDemandQty", 23, 8, schemaColumnName: "TFOrdDemandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdPickingQty", 23, 8, schemaColumnName: "TFOrdPickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "TFOrdPickedQty", 23, 8, schemaColumnName: "TFOrdPickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DemandQty", 23, 8, schemaColumnName: "DemandQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PickingQty", 23, 8, schemaColumnName: "PickingQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "PickedQty", 23, 8, schemaColumnName: "PickedQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PartWhse.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartWhse.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PartWhse.WarehouseCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class PlantWhse : SFEpic.Data.SchemaTable
        {
            public PlantWhse()
                : base("PlantWhse")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "PlantWhse.CompanyNum";
            public const string PlantNum = "PlantWhse.PlantNum";
            public const string WarehouseCode = "PlantWhse.WarehouseCode";
            public const string PartNum = "PlantWhse.PartNum";
            public const string PrimBin = "PlantWhse.PrimBin";
            public const string SysRowID = "PlantWhse.SysRowID";
            public const string SysRevID = "PlantWhse.SysRevID";
            public const string BitFlag = "PlantWhse.BitFlag";
            public const string WasWrittenByAspacia = "PlantWhse.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "WarehouseCode", 16, schemaColumnName: "WarehouseCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PartNum", 100, schemaColumnName: "PartNum", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PrimBin", 20, schemaColumnName: "PrimBin", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["PlantWhse.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PlantWhse.PlantNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PlantWhse.PartNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["PlantWhse.WarehouseCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class Resource : SFEpic.Data.SchemaTable
        {
            public Resource()
                : base("Resource")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "Resource.CompanyNum";
            public const string ResourceID = "Resource.ResourceID";
            public const string Description = "Resource.Description";
            public const string NextMaintDate = "Resource.NextMaintDate";
            public const string ResourceGrpID = "Resource.ResourceGrpID";
            public const string OutputWhse = "Resource.OutputWhse";
            public const string OutputBinNum = "Resource.OutputBinNum";
            public const string BackflushWhse = "Resource.BackflushWhse";
            public const string BackflushBinNum = "Resource.BackflushBinNum";
            public const string InputWhse = "Resource.InputWhse";
            public const string InputBinNum = "Resource.InputBinNum";
            public const string ResourceType = "Resource.ResourceType";
            public const string TrackProdQty = "Resource.TrackProdQty";
            public const string LinkedPart = "Resource.LinkedPart";
            public const string AssetNum = "Resource.AssetNum";
            public const string Inactive = "Resource.Inactive";
            public const string ConcurrentCapacity = "Resource.ConcurrentCapacity";
            public const string ProdBurRate = "Resource.ProdBurRate";
            public const string SetupBurRate = "Resource.SetupBurRate";
            public const string QProdBurRate = "Resource.QProdBurRate";
            public const string QSetupBurRate = "Resource.QSetupBurRate";
            public const string ProdLabRate = "Resource.ProdLabRate";
            public const string SetupLabRate = "Resource.SetupLabRate";
            public const string QProdLabRate = "Resource.QProdLabRate";
            public const string QSetupLabRate = "Resource.QSetupLabRate";
            public const string QBurdenType = "Resource.QBurdenType";
            public const string VendorNum = "Resource.VendorNum";
            public const string BurdenType = "Resource.BurdenType";
            public const string GetDefaultBurdenFromGroup = "Resource.GetDefaultBurdenFromGroup";
            public const string Finite = "Resource.Finite";
            public const string CalendarID = "Resource.CalendarID";
            public const string InformOverload = "Resource.InformOverload";
            public const string MinOverloadPerc = "Resource.MinOverloadPerc";
            public const string AllowManualOverride = "Resource.AllowManualOverride";
            public const string MoveHours = "Resource.MoveHours";
            public const string QueHours = "Resource.QueHours";
            public const string GetDefaultMQFromGroup = "Resource.GetDefaultMQFromGroup";
            public const string OpCode = "Resource.OpCode";
            public const string OpStdID = "Resource.OpStdID";
            public const string GetDefaultLaborFromGroup = "Resource.GetDefaultLaborFromGroup";
            public const string FiniteHorizon = "Resource.FiniteHorizon";
            public const string AutoMove = "Resource.AutoMove";
            public const string SplitOperations = "Resource.SplitOperations";
            public const string DailyProdQty = "Resource.DailyProdQty";
            public const string BillLaborRate = "Resource.BillLaborRate";
            public const string DailyProdRate = "Resource.DailyProdRate";
            public const string GetDefaultWhseFromGroup = "Resource.GetDefaultWhseFromGroup";
            public const string Location = "Resource.Location";
            public const string SysRowID = "Resource.SysRowID";
            public const string SysRevID = "Resource.SysRevID";
            public const string BitFlag = "Resource.BitFlag";
            public const string WasWrittenByAspacia = "Resource.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceID", 24, schemaColumnName: "ResourceID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Description", 60, schemaColumnName: "Description", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDateSchemaColumn(this, "NextMaintDate", schemaColumnName: "NextMaintDate", ordinalSequence: seq++, isRequired: false, isNullable: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceGrpID", 16, schemaColumnName: "ResourceGrpID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OutputWhse", 16, schemaColumnName: "OutputWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OutputBinNum", 20, schemaColumnName: "OutputBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BackflushWhse", 16, schemaColumnName: "BackflushWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BackflushBinNum", 20, schemaColumnName: "BackflushBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InputWhse", 16, schemaColumnName: "InputWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InputBinNum", 20, schemaColumnName: "InputBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceType", 16, schemaColumnName: "ResourceType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "TrackProdQty", schemaColumnName: "TrackProdQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "LinkedPart", 100, schemaColumnName: "LinkedPart", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "AssetNum", 40, schemaColumnName: "AssetNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Inactive", schemaColumnName: "Inactive", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ConcurrentCapacity", 25, 2, schemaColumnName: "ConcurrentCapacity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdBurRate", 25, 6, schemaColumnName: "ProdBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetupBurRate", 25, 6, schemaColumnName: "SetupBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QProdBurRate", 25, 5, schemaColumnName: "QProdBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QSetupBurRate", 25, 5, schemaColumnName: "QSetupBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdLabRate", 25, 6, schemaColumnName: "ProdLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetupLabRate", 25, 5, schemaColumnName: "SetupLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QProdLabRate", 25, 5, schemaColumnName: "QProdLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QSetupLabRate", 25, 5, schemaColumnName: "QSetupLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "QBurdenType", 16, schemaColumnName: "QBurdenType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "VendorNum", schemaColumnName: "VendorNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BurdenType", 16, schemaColumnName: "BurdenType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GetDefaultBurdenFromGroup", schemaColumnName: "GetDefaultBurdenFromGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Finite", schemaColumnName: "Finite", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CalendarID", 16, schemaColumnName: "CalendarID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "InformOverload", schemaColumnName: "InformOverload", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MinOverloadPerc", 25, 0, schemaColumnName: "MinOverloadPerc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AllowManualOverride", schemaColumnName: "AllowManualOverride", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MoveHours", 25, 2, schemaColumnName: "MoveHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QueHours", 25, 2, schemaColumnName: "QueHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GetDefaultMQFromGroup", schemaColumnName: "GetDefaultMQFromGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpCode", 16, schemaColumnName: "OpCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpStdID", 10, schemaColumnName: "OpStdID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GetDefaultLaborFromGroup", schemaColumnName: "GetDefaultLaborFromGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FiniteHorizon", schemaColumnName: "FiniteHorizon", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AutoMove", schemaColumnName: "AutoMove", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SplitOperations", schemaColumnName: "SplitOperations", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DailyProdQty", 25, 6, schemaColumnName: "DailyProdQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BillLaborRate", 25, 5, schemaColumnName: "BillLaborRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DailyProdRate", 25, 6, schemaColumnName: "DailyProdRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "GetDefaultWhseFromGroup", schemaColumnName: "GetDefaultWhseFromGroup", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Location", schemaColumnName: "Location", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["Resource.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["Resource.ResourceID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class ResourceGroup : SFEpic.Data.SchemaTable
        {
            public ResourceGroup()
                : base("ResourceGroup")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "ResourceGroup.CompanyNum";
            public const string ResourceGrpID = "ResourceGroup.ResourceGrpID";
            public const string Description = "ResourceGroup.Description";
            public const string NumberOfMachines = "ResourceGroup.NumberOfMachines";
            public const string SchMachine = "ResourceGroup.SchMachine";
            public const string BurdenType = "ResourceGroup.BurdenType";
            public const string MoveHours = "ResourceGroup.MoveHours";
            public const string JCDeptNum = "ResourceGroup.JCDeptNum";
            public const string QueHours = "ResourceGroup.QueHours";
            public const string OpCode = "ResourceGroup.OpCode";
            public const string ProdBurRate = "ResourceGroup.ProdBurRate";
            public const string SetupBurRate = "ResourceGroup.SetupBurRate";
            public const string SplitBurden = "ResourceGroup.SplitBurden";
            public const string ProdCrewSize = "ResourceGroup.ProdCrewSize";
            public const string SetupCrewSize = "ResourceGroup.SetupCrewSize";
            public const string OpStdID = "ResourceGroup.OpStdID";
            public const string QProdBurRate = "ResourceGroup.QProdBurRate";
            public const string QSetupBurRate = "ResourceGroup.QSetupBurRate";
            public const string ReloadNum = "ResourceGroup.ReloadNum";
            public const string ReloadStatus = "ResourceGroup.ReloadStatus";
            public const string Obsolete803_Finite = "ResourceGroup.Obsolete803_Finite";
            public const string DailyCapacity = "ResourceGroup.DailyCapacity";
            public const string QBurdenType = "ResourceGroup.QBurdenType";
            public const string BurdenEQLabor = "ResourceGroup.BurdenEQLabor";
            public const string PlantNum = "ResourceGroup.PlantNum";
            public const string SplitOperations = "ResourceGroup.SplitOperations";
            public const string ResourceType = "ResourceGroup.ResourceType";
            public const string InputWhse = "ResourceGroup.InputWhse";
            public const string InputBinNum = "ResourceGroup.InputBinNum";
            public const string OutputWhse = "ResourceGroup.OutputWhse";
            public const string OutputBinNum = "ResourceGroup.OutputBinNum";
            public const string BackflushWhse = "ResourceGroup.BackflushWhse";
            public const string BackflushBinNum = "ResourceGroup.BackflushBinNum";
            public const string InformOverload = "ResourceGroup.InformOverload";
            public const string MinOverloadPerc = "ResourceGroup.MinOverloadPerc";
            public const string BackflushEmpID = "ResourceGroup.BackflushEmpID";
            public const string SubContract = "ResourceGroup.SubContract";
            public const string AutoMove = "ResourceGroup.AutoMove";
            public const string UseEstimates = "ResourceGroup.UseEstimates";
            public const string CalendarID = "ResourceGroup.CalendarID";
            public const string Inactive = "ResourceGroup.Inactive";
            public const string FiniteHorizon = "ResourceGroup.FiniteHorizon";
            public const string ProdLabRate = "ResourceGroup.ProdLabRate";
            public const string SetupLabRate = "ResourceGroup.SetupLabRate";
            public const string QProdLabRate = "ResourceGroup.QProdLabRate";
            public const string QSetupLabRate = "ResourceGroup.QSetupLabRate";
            public const string AllowManualOverride = "ResourceGroup.AllowManualOverride";
            public const string DailyProdQty = "ResourceGroup.DailyProdQty";
            public const string BillLaborRate = "ResourceGroup.BillLaborRate";
            public const string DailyProdRate = "ResourceGroup.DailyProdRate";
            public const string Location = "ResourceGroup.Location";
            public const string DistributeLoad = "ResourceGroup.DistributeLoad";
            public const string SysRowID = "ResourceGroup.SysRowID";
            public const string SysRevID = "ResourceGroup.SysRevID";
            public const string BitFlag = "ResourceGroup.BitFlag";
            public const string WasWrittenByAspacia = "ResourceGroup.CheckBox20";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceGrpID", 16, schemaColumnName: "ResourceGrpID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Description", 60, schemaColumnName: "Description", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "NumberOfMachines", schemaColumnName: "NumberOfMachines", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SchMachine", schemaColumnName: "SchMachine", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BurdenType", 16, schemaColumnName: "BurdenType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MoveHours", 25, 2, schemaColumnName: "MoveHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "JCDeptNum", 16, schemaColumnName: "JCDept", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QueHours", 25, 2, schemaColumnName: "QueHours", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpCode", 16, schemaColumnName: "OpCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdBurRate", 25, 6, schemaColumnName: "ProdBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetupBurRate", 25, 6, schemaColumnName: "SetupBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SplitBurden", schemaColumnName: "SplitBurden", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdCrewSize", 25, 2, schemaColumnName: "ProdCrewSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetupCrewSize", 25, 2, schemaColumnName: "SetupCrewSize", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OpStdID", 10, schemaColumnName: "OpStdID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QProdBurRate", 25, 5, schemaColumnName: "QProdBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QSetupBurRate", 25, 5, schemaColumnName: "QSetupBurRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "ReloadNum", schemaColumnName: "ReloadNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ReloadStatus", 16, schemaColumnName: "ReloadStatus", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Obsolete803_Finite", schemaColumnName: "Obsolete803-Finite", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DailyCapacity", 140, schemaColumnName: "DailyCapacity", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "QBurdenType", 16, schemaColumnName: "QBurdenType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BurdenEQLabor", schemaColumnName: "BurdenEQLabor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "PlantNum", 16, schemaColumnName: "Plant", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SplitOperations", schemaColumnName: "SplitOperations", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ResourceType", 2, schemaColumnName: "ResourceType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InputWhse", 16, schemaColumnName: "InputWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "InputBinNum", 20, schemaColumnName: "InputBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OutputWhse", 16, schemaColumnName: "OutputWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "OutputBinNum", 20, schemaColumnName: "OutputBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BackflushWhse", 16, schemaColumnName: "BackflushWhse", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BackflushBinNum", 20, schemaColumnName: "BackflushBinNum", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "InformOverload", schemaColumnName: "InformOverload", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "MinOverloadPerc", 25, 0, schemaColumnName: "MinOverloadPerc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BackflushEmpID", 16, schemaColumnName: "BackflushEmpID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "SubContract", schemaColumnName: "SubContract", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AutoMove", schemaColumnName: "AutoMove", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "UseEstimates", schemaColumnName: "UseEstimates", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CalendarID", 16, schemaColumnName: "CalendarID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Inactive", schemaColumnName: "Inactive", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "FiniteHorizon", schemaColumnName: "FiniteHorizon", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ProdLabRate", 25, 6, schemaColumnName: "ProdLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "SetupLabRate", 25, 5, schemaColumnName: "SetupLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QProdLabRate", 25, 5, schemaColumnName: "QProdLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "QSetupLabRate", 25, 5, schemaColumnName: "QSetupLabRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AllowManualOverride", schemaColumnName: "AllowManualOverride", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DailyProdQty", 25, 6, schemaColumnName: "DailyProdQty", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "BillLaborRate", 25, 5, schemaColumnName: "BillLaborRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "DailyProdRate", 25, 6, schemaColumnName: "DailyProdRate", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Location", schemaColumnName: "Location", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "DistributeLoad", schemaColumnName: "DistributeLoad", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox20", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["ResourceGroup.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["ResourceGroup.ResourceGrpID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class UOM : SFEpic.Data.SchemaTable
        {
            public UOM()
                : base("UOM")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "UOM.CompanyNum";
            public const string UOMCode = "UOM.UOMCode";
            public const string UOMDesc = "UOM.UOMDesc";
            public const string Fractions = "UOM.Fractions";
            public const string Active = "UOM.Active";
            public const string UOMSymbol = "UOM.UOMSymbol";
            public const string AllowDecimals = "UOM.AllowDecimals";
            public const string NumOfDec = "UOM.NumOfDec";
            public const string Rounding = "UOM.Rounding";
            public const string SysRowID = "UOM.SysRowID";
            public const string SysRevID = "UOM.SysRevID";
            public const string BitFlag = "UOM.BitFlag";
            public const string WasWrittenByAspacia = "UOM.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMCode", 12, schemaColumnName: "UOMCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMDesc", 60, schemaColumnName: "UOMDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Fractions", 16, schemaColumnName: "Fractions", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Active", schemaColumnName: "Active", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMSymbol", 12, schemaColumnName: "UOMSymbol", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AllowDecimals", schemaColumnName: "AllowDecimals", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "NumOfDec", schemaColumnName: "NumOfDec", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Rounding", 6, schemaColumnName: "Rounding", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["UOM.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["UOM.UOMCode"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class UOMClass : SFEpic.Data.SchemaTable
        {
            public UOMClass()
                : base("UOMClass")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "UOMClass.CompanyNum";
            public const string UOMClassID = "UOMClass.UOMClassID";
            public const string Description = "UOMClass.Description";
            public const string ClassType = "UOMClass.ClassType";
            public const string BaseUOMCode = "UOMClass.BaseUOMCode";
            public const string PartSpecific = "UOMClass.PartSpecific";
            public const string DefUomCode = "UOMClass.DefUomCode";
            public const string SysRowID = "UOMClass.SysRowID";
            public const string SysRevID = "UOMClass.SysRevID";
            public const string Active = "UOMClass.Active";
            public const string BitFlag = "UOMClass.BitFlag";
            public const string WasWrittenByAspacia = "UOMClass.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMClassID", 24, schemaColumnName: "UOMClassID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Description", 60, schemaColumnName: "Description", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ClassType", 16, schemaColumnName: "ClassType", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "BaseUOMCode", 12, schemaColumnName: "BaseUOMCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PartSpecific", schemaColumnName: "PartSpecific", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "DefUomCode", 16, schemaColumnName: "DefUomCode", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Active", schemaColumnName: "Active", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["UOMClass.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["UOMClass.UOMClassID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
            }
        }
        [Serializable()]
        public partial class UOMConv : SFEpic.Data.SchemaTable
        {
            public UOMConv()
                : base("UOMConv")
            {
            }

            #region Field Name Constants

            public const string CompanyNum = "UOMConv.CompanyNum";
            public const string UOMClassID = "UOMConv.UOMClassID";
            public const string UOMCode = "UOMConv.UOMCode";
            public const string ConvFactor = "UOMConv.ConvFactor";
            public const string UOMDesc = "UOMConv.UOMDesc";
            public const string BaseUOM83 = "UOMConv.BaseUOM83";
            public const string UOMCode83 = "UOMConv.UOMCode83";
            public const string Fractions = "UOMConv.Fractions";
            public const string StdUOM = "UOMConv.StdUOM";
            public const string Active = "UOMConv.Active";
            public const string UOMSymbol = "UOMConv.UOMSymbol";
            public const string NumOfDec = "UOMConv.NumOfDec";
            public const string Rounding = "UOMConv.Rounding";
            public const string AllowDecimals = "UOMConv.AllowDecimals";
            public const string PartSpecific = "UOMConv.PartSpecific";
            public const string SysRowID = "UOMConv.SysRowID";
            public const string SysRevID = "UOMConv.SysRevID";
            public const string BitFlag = "UOMConv.BitFlag";
            public const string HasBeenUsed = "UOMConv.HasBeenUsed";
            public const string ConvOperator = "UOMConv.ConvOperator";
            public const string WasWrittenByAspacia = "UOMConv.CheckBox05";

            #endregion

            protected override void InitColumnsCore(ref int seq)
            {
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMClassID", 24, schemaColumnName: "UOMClassID", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMCode", 12, schemaColumnName: "UOMCode", ordinalSequence: seq++, isRequired: true));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetDecimalSchemaColumn(this, "ConvFactor", 22, 7, schemaColumnName: "ConvFactor", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMDesc", 60, schemaColumnName: "UOMDesc", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "BaseUOM83", schemaColumnName: "BaseUOM83", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMCode83", 16, schemaColumnName: "UOMCode83", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Fractions", 16, schemaColumnName: "Fractions", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "StdUOM", schemaColumnName: "StdUOM", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "Active", schemaColumnName: "Active", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "UOMSymbol", 12, schemaColumnName: "UOMSymbol", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "NumOfDec", schemaColumnName: "NumOfDec", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "Rounding", 6, schemaColumnName: "Rounding", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "AllowDecimals", schemaColumnName: "AllowDecimals", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "PartSpecific", schemaColumnName: "PartSpecific", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "SysRowID", 72, schemaColumnName: "SysRowID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "SysRevID", schemaColumnName: "SysRevID", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetIntegerSchemaColumn(this, "BitFlag", schemaColumnName: "BitFlag", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "HasBeenUsed", schemaColumnName: "HasBeenUsed", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetTextSchemaColumn(this, "ConvOperator", 16, schemaColumnName: "ConvOperator", ordinalSequence: seq++, isRequired: false));
                columnsList.Add(SFEpic.Data.SchemaColumnFactory.GetBooleanSchemaColumn(this, "WasWrittenByAspacia", schemaColumnName: "CheckBox05", ordinalSequence: seq++, isRequired: false, defaultValue: "True"));
            }

            protected override void InitPrimaryKeysCore()
            {
                SchemaColumn col = null;
                col = columnsDictionary["UOMConv.CompanyNum"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["UOMConv.UOMClassID"];
                col.IsPrimaryKey = true;
                primaryKeysList.Add(col);
                col = columnsDictionary["UOMConv.UOMCode"];
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
                    schemaTable = (Schema.Company)E9Schema.Instance.TablesDictionary["Company"];
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

        protected RowProperty<string> fiscalCalendarIDProperty;
        public string FiscalCalendarID
        {
            get
            {
                if (fiscalCalendarIDProperty == null)
                    fiscalCalendarIDProperty = GetStringProperty("Company.FiscalCalendarID");
                return fiscalCalendarIDProperty.Value;
            }
            set
            {
                if (fiscalCalendarIDProperty == null)
                    fiscalCalendarIDProperty = GetStringProperty("Company.FiscalCalendarID");
                fiscalCalendarIDProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("Company.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("Company.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("Company.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("Company.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<string> attachNetworkRootProperty;
        public string AttachNetworkRoot
        {
            get
            {
                if (attachNetworkRootProperty == null)
                    attachNetworkRootProperty = GetStringProperty("Company.AttachNetworkRoot");
                return attachNetworkRootProperty.Value;
            }
            set
            {
                if (attachNetworkRootProperty == null)
                    attachNetworkRootProperty = GetStringProperty("Company.AttachNetworkRoot");
                attachNetworkRootProperty.Value = value;
            }
        }

        protected RowProperty<string> attachSharePointRootProperty;
        public string AttachSharePointRoot
        {
            get
            {
                if (attachSharePointRootProperty == null)
                    attachSharePointRootProperty = GetStringProperty("Company.AttachSharePointRoot");
                return attachSharePointRootProperty.Value;
            }
            set
            {
                if (attachSharePointRootProperty == null)
                    attachSharePointRootProperty = GetStringProperty("Company.AttachSharePointRoot");
                attachSharePointRootProperty.Value = value;
            }
        }

        protected RowProperty<int> attachDefaultMechanismProperty;
        public int AttachDefaultMechanism
        {
            get
            {
                if (attachDefaultMechanismProperty == null)
                    attachDefaultMechanismProperty = GetIntegerProperty("Company.AttachDefaultMechanism");
                return attachDefaultMechanismProperty.Value;
            }
            set
            {
                if (attachDefaultMechanismProperty == null)
                    attachDefaultMechanismProperty = GetIntegerProperty("Company.AttachDefaultMechanism");
                attachDefaultMechanismProperty.Value = value;
            }
        }

        protected RowProperty<bool> enableFileSysProperty;
        public bool EnableFileSys
        {
            get
            {
                if (enableFileSysProperty == null)
                    enableFileSysProperty = GetBooleanProperty("Company.EnableFileSys");
                return enableFileSysProperty.Value;
            }
            set
            {
                if (enableFileSysProperty == null)
                    enableFileSysProperty = GetBooleanProperty("Company.EnableFileSys");
                enableFileSysProperty.Value = value;
            }
        }

        protected RowProperty<bool> enableSharePointProperty;
        public bool EnableSharePoint
        {
            get
            {
                if (enableSharePointProperty == null)
                    enableSharePointProperty = GetBooleanProperty("Company.EnableSharePoint");
                return enableSharePointProperty.Value;
            }
            set
            {
                if (enableSharePointProperty == null)
                    enableSharePointProperty = GetBooleanProperty("Company.EnableSharePoint");
                enableSharePointProperty.Value = value;
            }
        }

        protected RowProperty<bool> allowDefaultDocProperty;
        public bool AllowDefaultDoc
        {
            get
            {
                if (allowDefaultDocProperty == null)
                    allowDefaultDocProperty = GetBooleanProperty("Company.AllowDefaultDoc");
                return allowDefaultDocProperty.Value;
            }
            set
            {
                if (allowDefaultDocProperty == null)
                    allowDefaultDocProperty = GetBooleanProperty("Company.AllowDefaultDoc");
                allowDefaultDocProperty.Value = value;
            }
        }

        protected RowProperty<string> metadataPathProperty;
        public string MetadataPath
        {
            get
            {
                if (metadataPathProperty == null)
                    metadataPathProperty = GetStringProperty("Company.MetadataPath");
                return metadataPathProperty.Value;
            }
            set
            {
                if (metadataPathProperty == null)
                    metadataPathProperty = GetStringProperty("Company.MetadataPath");
                metadataPathProperty.Value = value;
            }
        }

        protected RowProperty<string> winWebURLProperty;
        public string WinWebURL
        {
            get
            {
                if (winWebURLProperty == null)
                    winWebURLProperty = GetStringProperty("Company.WinWebURL");
                return winWebURLProperty.Value;
            }
            set
            {
                if (winWebURLProperty == null)
                    winWebURLProperty = GetStringProperty("Company.WinWebURL");
                winWebURLProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackSysActivityProperty;
        public bool TrackSysActivity
        {
            get
            {
                if (trackSysActivityProperty == null)
                    trackSysActivityProperty = GetBooleanProperty("Company.TrackSysActivity");
                return trackSysActivityProperty.Value;
            }
            set
            {
                if (trackSysActivityProperty == null)
                    trackSysActivityProperty = GetBooleanProperty("Company.TrackSysActivity");
                trackSysActivityProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackPersonalizationChgProperty;
        public bool TrackPersonalizationChg
        {
            get
            {
                if (trackPersonalizationChgProperty == null)
                    trackPersonalizationChgProperty = GetBooleanProperty("Company.TrackPersonalizationChg");
                return trackPersonalizationChgProperty.Value;
            }
            set
            {
                if (trackPersonalizationChgProperty == null)
                    trackPersonalizationChgProperty = GetBooleanProperty("Company.TrackPersonalizationChg");
                trackPersonalizationChgProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("Company.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("Company.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("Company.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("Company.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region ECORev Table

    [Serializable()]
    public abstract partial class ECORevBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : ECORevBase<T, R>, new()
        where R : ECORevRow, new()
    {
        protected ECORevBase() : base() { }

        protected static Schema.ECORev schemaTable;
        public static Schema.ECORev SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.ECORev)E9Schema.Instance.TablesDictionary["ECORev"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByGroupIDCriteria;
        public static T FillByGroupID(DataContext context, string companyNum, string groupID, params string[] columnNames)
        {
            if (fillByGroupIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.GroupID]));
                fillByGroupIDCriteria = list.ToArray();
            }
            fillByGroupIDCriteria[0].Value = companyNum;
            fillByGroupIDCriteria[1].Value = groupID;
            return EditTable<T, R>.Fetch(context, fillByGroupIDCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPartNumCriteria;
        public static T FillByPartNum(DataContext context, string companyNum, string groupID, string partNum, params string[] columnNames)
        {
            if (fillByPartNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.GroupID]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = groupID;
            fillByPartNumCriteria[2].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByRevisionNumCriteria;
        public static T FillByRevisionNum(DataContext context, string companyNum, string groupID, string partNum, string revisionNum, params string[] columnNames)
        {
            if (fillByRevisionNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.GroupID]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.RevisionNum]));
                fillByRevisionNumCriteria = list.ToArray();
            }
            fillByRevisionNumCriteria[0].Value = companyNum;
            fillByRevisionNumCriteria[1].Value = groupID;
            fillByRevisionNumCriteria[2].Value = partNum;
            fillByRevisionNumCriteria[3].Value = revisionNum;
            return EditTable<T, R>.Fetch(context, fillByRevisionNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByAltMethodCriteria;
        public static T FillByAltMethod(DataContext context, string companyNum, string groupID, string partNum, string revisionNum, string altMethod, params string[] columnNames)
        {
            if (fillByAltMethodCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.GroupID]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.AltMethod]));
                fillByAltMethodCriteria = list.ToArray();
            }
            fillByAltMethodCriteria[0].Value = companyNum;
            fillByAltMethodCriteria[1].Value = groupID;
            fillByAltMethodCriteria[2].Value = partNum;
            fillByAltMethodCriteria[3].Value = revisionNum;
            fillByAltMethodCriteria[4].Value = altMethod;
            return EditTable<T, R>.Fetch(context, fillByAltMethodCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class ECORev : ECORevBase<ECORev, ECORevRow>
    {
        public ECORev() : base() { }
    }

    #region ECORevRow

    [Serializable()]
    public class ECORevRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("ECORev.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("ECORev.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("ECORev.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("ECORev.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> revShortDescProperty;
        public string RevShortDesc
        {
            get
            {
                if (revShortDescProperty == null)
                    revShortDescProperty = GetStringProperty("ECORev.RevShortDesc");
                return revShortDescProperty.Value;
            }
            set
            {
                if (revShortDescProperty == null)
                    revShortDescProperty = GetStringProperty("ECORev.RevShortDesc");
                revShortDescProperty.Value = value;
            }
        }

        protected RowProperty<string> revDescriptionProperty;
        public string RevDescription
        {
            get
            {
                if (revDescriptionProperty == null)
                    revDescriptionProperty = GetStringProperty("ECORev.RevDescription");
                return revDescriptionProperty.Value;
            }
            set
            {
                if (revDescriptionProperty == null)
                    revDescriptionProperty = GetStringProperty("ECORev.RevDescription");
                revDescriptionProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumProperty;
        public string RevisionNum
        {
            get
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("ECORev.RevisionNum");
                return revisionNumProperty.Value;
            }
            set
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("ECORev.RevisionNum");
                revisionNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> approvedProperty;
        public bool Approved
        {
            get
            {
                if (approvedProperty == null)
                    approvedProperty = GetBooleanProperty("ECORev.Approved");
                return approvedProperty.Value;
            }
            set
            {
                if (approvedProperty == null)
                    approvedProperty = GetBooleanProperty("ECORev.Approved");
                approvedProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> approvedDateProperty;
        public DateTime? ApprovedDate
        {
            get
            {
                if (approvedDateProperty == null)
                    approvedDateProperty = GetNullableDateTimeProperty("ECORev.ApprovedDate");
                return approvedDateProperty.Value;
            }
            set
            {
                if (approvedDateProperty == null)
                    approvedDateProperty = GetNullableDateTimeProperty("ECORev.ApprovedDate");
                approvedDateProperty.Value = value;
            }
        }

        protected RowProperty<string> approvedByProperty;
        public string ApprovedBy
        {
            get
            {
                if (approvedByProperty == null)
                    approvedByProperty = GetStringProperty("ECORev.ApprovedBy");
                return approvedByProperty.Value;
            }
            set
            {
                if (approvedByProperty == null)
                    approvedByProperty = GetStringProperty("ECORev.ApprovedBy");
                approvedByProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> effectiveDateProperty;
        public DateTime? EffectiveDate
        {
            get
            {
                if (effectiveDateProperty == null)
                    effectiveDateProperty = GetNullableDateTimeProperty("ECORev.EffectiveDate");
                return effectiveDateProperty.Value;
            }
            set
            {
                if (effectiveDateProperty == null)
                    effectiveDateProperty = GetNullableDateTimeProperty("ECORev.EffectiveDate");
                effectiveDateProperty.Value = value;
            }
        }

        protected RowProperty<int> autoRecOprProperty;
        public int AutoRecOpr
        {
            get
            {
                if (autoRecOprProperty == null)
                    autoRecOprProperty = GetIntegerProperty("ECORev.AutoRecOpr");
                return autoRecOprProperty.Value;
            }
            set
            {
                if (autoRecOprProperty == null)
                    autoRecOprProperty = GetIntegerProperty("ECORev.AutoRecOpr");
                autoRecOprProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRLaborCostProperty;
        public decimal TLRLaborCost
        {
            get
            {
                if (tLRLaborCostProperty == null)
                    tLRLaborCostProperty = GetDecimalProperty("ECORev.TLRLaborCost");
                return tLRLaborCostProperty.Value;
            }
            set
            {
                if (tLRLaborCostProperty == null)
                    tLRLaborCostProperty = GetDecimalProperty("ECORev.TLRLaborCost");
                tLRLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRBurdenCostProperty;
        public decimal TLRBurdenCost
        {
            get
            {
                if (tLRBurdenCostProperty == null)
                    tLRBurdenCostProperty = GetDecimalProperty("ECORev.TLRBurdenCost");
                return tLRBurdenCostProperty.Value;
            }
            set
            {
                if (tLRBurdenCostProperty == null)
                    tLRBurdenCostProperty = GetDecimalProperty("ECORev.TLRBurdenCost");
                tLRBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRMaterialCostProperty;
        public decimal TLRMaterialCost
        {
            get
            {
                if (tLRMaterialCostProperty == null)
                    tLRMaterialCostProperty = GetDecimalProperty("ECORev.TLRMaterialCost");
                return tLRMaterialCostProperty.Value;
            }
            set
            {
                if (tLRMaterialCostProperty == null)
                    tLRMaterialCostProperty = GetDecimalProperty("ECORev.TLRMaterialCost");
                tLRMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRSubcontractCostProperty;
        public decimal TLRSubcontractCost
        {
            get
            {
                if (tLRSubcontractCostProperty == null)
                    tLRSubcontractCostProperty = GetDecimalProperty("ECORev.TLRSubcontractCost");
                return tLRSubcontractCostProperty.Value;
            }
            set
            {
                if (tLRSubcontractCostProperty == null)
                    tLRSubcontractCostProperty = GetDecimalProperty("ECORev.TLRSubcontractCost");
                tLRSubcontractCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRSetupLaborCostProperty;
        public decimal TLRSetupLaborCost
        {
            get
            {
                if (tLRSetupLaborCostProperty == null)
                    tLRSetupLaborCostProperty = GetDecimalProperty("ECORev.TLRSetupLaborCost");
                return tLRSetupLaborCostProperty.Value;
            }
            set
            {
                if (tLRSetupLaborCostProperty == null)
                    tLRSetupLaborCostProperty = GetDecimalProperty("ECORev.TLRSetupLaborCost");
                tLRSetupLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRSetupBurdenCostProperty;
        public decimal TLRSetupBurdenCost
        {
            get
            {
                if (tLRSetupBurdenCostProperty == null)
                    tLRSetupBurdenCostProperty = GetDecimalProperty("ECORev.TLRSetupBurdenCost");
                return tLRSetupBurdenCostProperty.Value;
            }
            set
            {
                if (tLRSetupBurdenCostProperty == null)
                    tLRSetupBurdenCostProperty = GetDecimalProperty("ECORev.TLRSetupBurdenCost");
                tLRSetupBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRLaborCostProperty;
        public decimal LLRLaborCost
        {
            get
            {
                if (lLRLaborCostProperty == null)
                    lLRLaborCostProperty = GetDecimalProperty("ECORev.LLRLaborCost");
                return lLRLaborCostProperty.Value;
            }
            set
            {
                if (lLRLaborCostProperty == null)
                    lLRLaborCostProperty = GetDecimalProperty("ECORev.LLRLaborCost");
                lLRLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRBurdenCostProperty;
        public decimal LLRBurdenCost
        {
            get
            {
                if (lLRBurdenCostProperty == null)
                    lLRBurdenCostProperty = GetDecimalProperty("ECORev.LLRBurdenCost");
                return lLRBurdenCostProperty.Value;
            }
            set
            {
                if (lLRBurdenCostProperty == null)
                    lLRBurdenCostProperty = GetDecimalProperty("ECORev.LLRBurdenCost");
                lLRBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRMaterialCostProperty;
        public decimal LLRMaterialCost
        {
            get
            {
                if (lLRMaterialCostProperty == null)
                    lLRMaterialCostProperty = GetDecimalProperty("ECORev.LLRMaterialCost");
                return lLRMaterialCostProperty.Value;
            }
            set
            {
                if (lLRMaterialCostProperty == null)
                    lLRMaterialCostProperty = GetDecimalProperty("ECORev.LLRMaterialCost");
                lLRMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRSetupLaborCostProperty;
        public decimal LLRSetupLaborCost
        {
            get
            {
                if (lLRSetupLaborCostProperty == null)
                    lLRSetupLaborCostProperty = GetDecimalProperty("ECORev.LLRSetupLaborCost");
                return lLRSetupLaborCostProperty.Value;
            }
            set
            {
                if (lLRSetupLaborCostProperty == null)
                    lLRSetupLaborCostProperty = GetDecimalProperty("ECORev.LLRSetupLaborCost");
                lLRSetupLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRSetupBurdenCostProperty;
        public decimal LLRSetupBurdenCost
        {
            get
            {
                if (lLRSetupBurdenCostProperty == null)
                    lLRSetupBurdenCostProperty = GetDecimalProperty("ECORev.LLRSetupBurdenCost");
                return lLRSetupBurdenCostProperty.Value;
            }
            set
            {
                if (lLRSetupBurdenCostProperty == null)
                    lLRSetupBurdenCostProperty = GetDecimalProperty("ECORev.LLRSetupBurdenCost");
                lLRSetupBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> rollupDateProperty;
        public DateTime? RollupDate
        {
            get
            {
                if (rollupDateProperty == null)
                    rollupDateProperty = GetNullableDateTimeProperty("ECORev.RollupDate");
                return rollupDateProperty.Value;
            }
            set
            {
                if (rollupDateProperty == null)
                    rollupDateProperty = GetNullableDateTimeProperty("ECORev.RollupDate");
                rollupDateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRSubcontractCostProperty;
        public decimal LLRSubcontractCost
        {
            get
            {
                if (lLRSubcontractCostProperty == null)
                    lLRSubcontractCostProperty = GetDecimalProperty("ECORev.LLRSubcontractCost");
                return lLRSubcontractCostProperty.Value;
            }
            set
            {
                if (lLRSubcontractCostProperty == null)
                    lLRSubcontractCostProperty = GetDecimalProperty("ECORev.LLRSubcontractCost");
                lLRSubcontractCostProperty.Value = value;
            }
        }

        protected RowProperty<string> drawNumProperty;
        public string DrawNum
        {
            get
            {
                if (drawNumProperty == null)
                    drawNumProperty = GetStringProperty("ECORev.DrawNum");
                return drawNumProperty.Value;
            }
            set
            {
                if (drawNumProperty == null)
                    drawNumProperty = GetStringProperty("ECORev.DrawNum");
                drawNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> methodProperty;
        public bool Method
        {
            get
            {
                if (methodProperty == null)
                    methodProperty = GetBooleanProperty("ECORev.Method");
                return methodProperty.Value;
            }
            set
            {
                if (methodProperty == null)
                    methodProperty = GetBooleanProperty("ECORev.Method");
                methodProperty.Value = value;
            }
        }

        protected RowProperty<string> ecoProperty;
        public string ECO
        {
            get
            {
                if (ecoProperty == null)
                    ecoProperty = GetStringProperty("ECORev.ECO");
                return ecoProperty.Value;
            }
            set
            {
                if (ecoProperty == null)
                    ecoProperty = GetStringProperty("ECORev.ECO");
                ecoProperty.Value = value;
            }
        }

        protected RowProperty<int> finalOprProperty;
        public int FinalOpr
        {
            get
            {
                if (finalOprProperty == null)
                    finalOprProperty = GetIntegerProperty("ECORev.FinalOpr");
                return finalOprProperty.Value;
            }
            set
            {
                if (finalOprProperty == null)
                    finalOprProperty = GetIntegerProperty("ECORev.FinalOpr");
                finalOprProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRMtlBurCostProperty;
        public decimal TLRMtlBurCost
        {
            get
            {
                if (tLRMtlBurCostProperty == null)
                    tLRMtlBurCostProperty = GetDecimalProperty("ECORev.TLRMtlBurCost");
                return tLRMtlBurCostProperty.Value;
            }
            set
            {
                if (tLRMtlBurCostProperty == null)
                    tLRMtlBurCostProperty = GetDecimalProperty("ECORev.TLRMtlBurCost");
                tLRMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRMtlBurCostProperty;
        public decimal LLRMtlBurCost
        {
            get
            {
                if (lLRMtlBurCostProperty == null)
                    lLRMtlBurCostProperty = GetDecimalProperty("ECORev.LLRMtlBurCost");
                return lLRMtlBurCostProperty.Value;
            }
            set
            {
                if (lLRMtlBurCostProperty == null)
                    lLRMtlBurCostProperty = GetDecimalProperty("ECORev.LLRMtlBurCost");
                lLRMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<string> groupIDProperty;
        public string GroupID
        {
            get
            {
                if (groupIDProperty == null)
                    groupIDProperty = GetStringProperty("ECORev.GroupID");
                return groupIDProperty.Value;
            }
            set
            {
                if (groupIDProperty == null)
                    groupIDProperty = GetStringProperty("ECORev.GroupID");
                groupIDProperty.Value = value;
            }
        }

        protected RowProperty<string> checkInRevisionNumProperty;
        public string CheckInRevisionNum
        {
            get
            {
                if (checkInRevisionNumProperty == null)
                    checkInRevisionNumProperty = GetStringProperty("ECORev.CheckInRevisionNum");
                return checkInRevisionNumProperty.Value;
            }
            set
            {
                if (checkInRevisionNumProperty == null)
                    checkInRevisionNumProperty = GetStringProperty("ECORev.CheckInRevisionNum");
                checkInRevisionNumProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> checkInDateProperty;
        public DateTime? CheckInDate
        {
            get
            {
                if (checkInDateProperty == null)
                    checkInDateProperty = GetNullableDateTimeProperty("ECORev.CheckInDate");
                return checkInDateProperty.Value;
            }
            set
            {
                if (checkInDateProperty == null)
                    checkInDateProperty = GetNullableDateTimeProperty("ECORev.CheckInDate");
                checkInDateProperty.Value = value;
            }
        }

        protected RowProperty<bool> checkedOutProperty;
        public bool CheckedOut
        {
            get
            {
                if (checkedOutProperty == null)
                    checkedOutProperty = GetBooleanProperty("ECORev.CheckedOut");
                return checkedOutProperty.Value;
            }
            set
            {
                if (checkedOutProperty == null)
                    checkedOutProperty = GetBooleanProperty("ECORev.CheckedOut");
                checkedOutProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> checkOutDateProperty;
        public DateTime? CheckOutDate
        {
            get
            {
                if (checkOutDateProperty == null)
                    checkOutDateProperty = GetNullableDateTimeProperty("ECORev.CheckOutDate");
                return checkOutDateProperty.Value;
            }
            set
            {
                if (checkOutDateProperty == null)
                    checkOutDateProperty = GetNullableDateTimeProperty("ECORev.CheckOutDate");
                checkOutDateProperty.Value = value;
            }
        }

        protected RowProperty<string> searchWordProperty;
        public string SearchWord
        {
            get
            {
                if (searchWordProperty == null)
                    searchWordProperty = GetStringProperty("ECORev.SearchWord");
                return searchWordProperty.Value;
            }
            set
            {
                if (searchWordProperty == null)
                    searchWordProperty = GetStringProperty("ECORev.SearchWord");
                searchWordProperty.Value = value;
            }
        }

        protected RowProperty<string> partDescriptionProperty;
        public string PartDescription
        {
            get
            {
                if (partDescriptionProperty == null)
                    partDescriptionProperty = GetStringProperty("ECORev.PartDescription");
                return partDescriptionProperty.Value;
            }
            set
            {
                if (partDescriptionProperty == null)
                    partDescriptionProperty = GetStringProperty("ECORev.PartDescription");
                partDescriptionProperty.Value = value;
            }
        }

        protected RowProperty<string> checkedOutByProperty;
        public string CheckedOutBy
        {
            get
            {
                if (checkedOutByProperty == null)
                    checkedOutByProperty = GetStringProperty("ECORev.CheckedOutBy");
                return checkedOutByProperty.Value;
            }
            set
            {
                if (checkedOutByProperty == null)
                    checkedOutByProperty = GetStringProperty("ECORev.CheckedOutBy");
                checkedOutByProperty.Value = value;
            }
        }

        protected RowProperty<string> pDMObjIDProperty;
        public string PDMObjID
        {
            get
            {
                if (pDMObjIDProperty == null)
                    pDMObjIDProperty = GetStringProperty("ECORev.PDMObjID");
                return pDMObjIDProperty.Value;
            }
            set
            {
                if (pDMObjIDProperty == null)
                    pDMObjIDProperty = GetStringProperty("ECORev.PDMObjID");
                pDMObjIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> revLockedProperty;
        public bool RevLocked
        {
            get
            {
                if (revLockedProperty == null)
                    revLockedProperty = GetBooleanProperty("ECORev.RevLocked");
                return revLockedProperty.Value;
            }
            set
            {
                if (revLockedProperty == null)
                    revLockedProperty = GetBooleanProperty("ECORev.RevLocked");
                revLockedProperty.Value = value;
            }
        }

        protected RowProperty<string> revLockedByProperty;
        public string RevLockedBy
        {
            get
            {
                if (revLockedByProperty == null)
                    revLockedByProperty = GetStringProperty("ECORev.RevLockedBy");
                return revLockedByProperty.Value;
            }
            set
            {
                if (revLockedByProperty == null)
                    revLockedByProperty = GetStringProperty("ECORev.RevLockedBy");
                revLockedByProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodProperty;
        public string AltMethod
        {
            get
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("ECORev.AltMethod");
                return altMethodProperty.Value;
            }
            set
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("ECORev.AltMethod");
                altMethodProperty.Value = value;
            }
        }

        protected RowProperty<string> plantNumProperty;
        public string PlantNum
        {
            get
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("ECORev.PlantNum");
                return plantNumProperty.Value;
            }
            set
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("ECORev.PlantNum");
                plantNumProperty.Value = value;
            }
        }

        protected RowProperty<string> parentAltMethodProperty;
        public string ParentAltMethod
        {
            get
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("ECORev.ParentAltMethod");
                return parentAltMethodProperty.Value;
            }
            set
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("ECORev.ParentAltMethod");
                parentAltMethodProperty.Value = value;
            }
        }

        protected RowProperty<bool> useStagingProperty;
        public bool UseStaging
        {
            get
            {
                if (useStagingProperty == null)
                    useStagingProperty = GetBooleanProperty("ECORev.UseStaging");
                return useStagingProperty.Value;
            }
            set
            {
                if (useStagingProperty == null)
                    useStagingProperty = GetBooleanProperty("ECORev.UseStaging");
                useStagingProperty.Value = value;
            }
        }

        protected RowProperty<string> revLockedInfoProperty;
        public string RevLockedInfo
        {
            get
            {
                if (revLockedInfoProperty == null)
                    revLockedInfoProperty = GetStringProperty("ECORev.RevLockedInfo");
                return revLockedInfoProperty.Value;
            }
            set
            {
                if (revLockedInfoProperty == null)
                    revLockedInfoProperty = GetStringProperty("ECORev.RevLockedInfo");
                revLockedInfoProperty.Value = value;
            }
        }

        protected RowProperty<bool> useAltRevForPartsProperty;
        public bool UseAltRevForParts
        {
            get
            {
                if (useAltRevForPartsProperty == null)
                    useAltRevForPartsProperty = GetBooleanProperty("ECORev.UseAltRevForParts");
                return useAltRevForPartsProperty.Value;
            }
            set
            {
                if (useAltRevForPartsProperty == null)
                    useAltRevForPartsProperty = GetBooleanProperty("ECORev.UseAltRevForParts");
                useAltRevForPartsProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("ECORev.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("ECORev.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("ECORev.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("ECORev.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("ECORev.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("ECORev.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> valRefDesProperty;
        public bool ValRefDes
        {
            get
            {
                if (valRefDesProperty == null)
                    valRefDesProperty = GetBooleanProperty("ECORev.ValRefDes");
                return valRefDesProperty.Value;
            }
            set
            {
                if (valRefDesProperty == null)
                    valRefDesProperty = GetBooleanProperty("ECORev.ValRefDes");
                valRefDesProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("ECORev.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("ECORev.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region OpMaster Table

    [Serializable()]
    public abstract partial class OpMasterBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : OpMasterBase<T, R>, new()
        where R : OpMasterRow, new()
    {
        protected OpMasterBase() : base() { }

        protected static Schema.OpMaster schemaTable;
        public static Schema.OpMaster SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.OpMaster)E9Schema.Instance.TablesDictionary["OpMaster"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.OpMaster.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByOpCodeCriteria;
        public static T FillByOpCode(DataContext context, string companyNum, string opCode, params string[] columnNames)
        {
            if (fillByOpCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.OpMaster.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.OpMaster.OpCode]));
                fillByOpCodeCriteria = list.ToArray();
            }
            fillByOpCodeCriteria[0].Value = companyNum;
            fillByOpCodeCriteria[1].Value = opCode;
            return EditTable<T, R>.Fetch(context, fillByOpCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class OpMaster : OpMasterBase<OpMaster, OpMasterRow>
    {
        public OpMaster() : base() { }
    }

    #region OpMasterRow

    [Serializable()]
    public class OpMasterRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("OpMaster.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("OpMaster.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> opCodeProperty;
        public string OpCode
        {
            get
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("OpMaster.OpCode");
                return opCodeProperty.Value;
            }
            set
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("OpMaster.OpCode");
                opCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> opDescProperty;
        public string OpDesc
        {
            get
            {
                if (opDescProperty == null)
                    opDescProperty = GetStringProperty("OpMaster.OpDesc");
                return opDescProperty.Value;
            }
            set
            {
                if (opDescProperty == null)
                    opDescProperty = GetStringProperty("OpMaster.OpDesc");
                opDescProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete803ProdLRateProperty;
        public decimal Obsolete803_ProdLRate
        {
            get
            {
                if (obsolete803ProdLRateProperty == null)
                    obsolete803ProdLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_ProdLRate");
                return obsolete803ProdLRateProperty.Value;
            }
            set
            {
                if (obsolete803ProdLRateProperty == null)
                    obsolete803ProdLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_ProdLRate");
                obsolete803ProdLRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete803SetupLRateProperty;
        public decimal Obsolete803_SetupLRate
        {
            get
            {
                if (obsolete803SetupLRateProperty == null)
                    obsolete803SetupLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_SetupLRate");
                return obsolete803SetupLRateProperty.Value;
            }
            set
            {
                if (obsolete803SetupLRateProperty == null)
                    obsolete803SetupLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_SetupLRate");
                obsolete803SetupLRateProperty.Value = value;
            }
        }

        protected RowProperty<string> opTextIDProperty;
        public string OpTextID
        {
            get
            {
                if (opTextIDProperty == null)
                    opTextIDProperty = GetStringProperty("OpMaster.OpTextID");
                return opTextIDProperty.Value;
            }
            set
            {
                if (opTextIDProperty == null)
                    opTextIDProperty = GetStringProperty("OpMaster.OpTextID");
                opTextIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete803QSetupLRateProperty;
        public decimal Obsolete803_QSetupLRate
        {
            get
            {
                if (obsolete803QSetupLRateProperty == null)
                    obsolete803QSetupLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_QSetupLRate");
                return obsolete803QSetupLRateProperty.Value;
            }
            set
            {
                if (obsolete803QSetupLRateProperty == null)
                    obsolete803QSetupLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_QSetupLRate");
                obsolete803QSetupLRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete803QProdLRateProperty;
        public decimal Obsolete803_QProdLRate
        {
            get
            {
                if (obsolete803QProdLRateProperty == null)
                    obsolete803QProdLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_QProdLRate");
                return obsolete803QProdLRateProperty.Value;
            }
            set
            {
                if (obsolete803QProdLRateProperty == null)
                    obsolete803QProdLRateProperty = GetDecimalProperty("OpMaster.Obsolete803_QProdLRate");
                obsolete803QProdLRateProperty.Value = value;
            }
        }

        protected RowProperty<string> buyerIDProperty;
        public string BuyerID
        {
            get
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("OpMaster.BuyerID");
                return buyerIDProperty.Value;
            }
            set
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("OpMaster.BuyerID");
                buyerIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> aPSPrepOpFProperty;
        public bool APSPrepOpF
        {
            get
            {
                if (aPSPrepOpFProperty == null)
                    aPSPrepOpFProperty = GetBooleanProperty("OpMaster.APSPrepOpF");
                return aPSPrepOpFProperty.Value;
            }
            set
            {
                if (aPSPrepOpFProperty == null)
                    aPSPrepOpFProperty = GetBooleanProperty("OpMaster.APSPrepOpF");
                aPSPrepOpFProperty.Value = value;
            }
        }

        protected RowProperty<string> oPTypeProperty;
        public string OPType
        {
            get
            {
                if (oPTypeProperty == null)
                    oPTypeProperty = GetStringProperty("OpMaster.OPType");
                return oPTypeProperty.Value;
            }
            set
            {
                if (oPTypeProperty == null)
                    oPTypeProperty = GetStringProperty("OpMaster.OPType");
                oPTypeProperty.Value = value;
            }
        }

        protected RowProperty<string> commentTextProperty;
        public string CommentText
        {
            get
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("OpMaster.CommentText");
                return commentTextProperty.Value;
            }
            set
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("OpMaster.CommentText");
                commentTextProperty.Value = value;
            }
        }

        protected RowProperty<decimal> billLaborRateProperty;
        public decimal BillLaborRate
        {
            get
            {
                if (billLaborRateProperty == null)
                    billLaborRateProperty = GetDecimalProperty("OpMaster.BillLaborRate");
                return billLaborRateProperty.Value;
            }
            set
            {
                if (billLaborRateProperty == null)
                    billLaborRateProperty = GetDecimalProperty("OpMaster.BillLaborRate");
                billLaborRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estLabHoursProperty;
        public decimal EstLabHours
        {
            get
            {
                if (estLabHoursProperty == null)
                    estLabHoursProperty = GetDecimalProperty("OpMaster.EstLabHours");
                return estLabHoursProperty.Value;
            }
            set
            {
                if (estLabHoursProperty == null)
                    estLabHoursProperty = GetDecimalProperty("OpMaster.EstLabHours");
                estLabHoursProperty.Value = value;
            }
        }

        protected RowProperty<int> schedPrecedenceProperty;
        public int SchedPrecedence
        {
            get
            {
                if (schedPrecedenceProperty == null)
                    schedPrecedenceProperty = GetIntegerProperty("OpMaster.SchedPrecedence");
                return schedPrecedenceProperty.Value;
            }
            set
            {
                if (schedPrecedenceProperty == null)
                    schedPrecedenceProperty = GetIntegerProperty("OpMaster.SchedPrecedence");
                schedPrecedenceProperty.Value = value;
            }
        }

        protected RowProperty<string> analysisCodeProperty;
        public string AnalysisCode
        {
            get
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("OpMaster.AnalysisCode");
                return analysisCodeProperty.Value;
            }
            set
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("OpMaster.AnalysisCode");
                analysisCodeProperty.Value = value;
            }
        }

        protected RowProperty<int> primarySetupOpDtlProperty;
        public int PrimarySetupOpDtl
        {
            get
            {
                if (primarySetupOpDtlProperty == null)
                    primarySetupOpDtlProperty = GetIntegerProperty("OpMaster.PrimarySetupOpDtl");
                return primarySetupOpDtlProperty.Value;
            }
            set
            {
                if (primarySetupOpDtlProperty == null)
                    primarySetupOpDtlProperty = GetIntegerProperty("OpMaster.PrimarySetupOpDtl");
                primarySetupOpDtlProperty.Value = value;
            }
        }

        protected RowProperty<int> primaryProdOpDtlProperty;
        public int PrimaryProdOpDtl
        {
            get
            {
                if (primaryProdOpDtlProperty == null)
                    primaryProdOpDtlProperty = GetIntegerProperty("OpMaster.PrimaryProdOpDtl");
                return primaryProdOpDtlProperty.Value;
            }
            set
            {
                if (primaryProdOpDtlProperty == null)
                    primaryProdOpDtlProperty = GetIntegerProperty("OpMaster.PrimaryProdOpDtl");
                primaryProdOpDtlProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("OpMaster.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("OpMaster.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> subcontractProperty;
        public bool Subcontract
        {
            get
            {
                if (subcontractProperty == null)
                    subcontractProperty = GetBooleanProperty("OpMaster.Subcontract");
                return subcontractProperty.Value;
            }
            set
            {
                if (subcontractProperty == null)
                    subcontractProperty = GetBooleanProperty("OpMaster.Subcontract");
                subcontractProperty.Value = value;
            }
        }

        protected RowProperty<bool> prdYldRecalcExpectedProperty;
        public bool PrdYldRecalcExpected
        {
            get
            {
                if (prdYldRecalcExpectedProperty == null)
                    prdYldRecalcExpectedProperty = GetBooleanProperty("OpMaster.PrdYldRecalcExpected");
                return prdYldRecalcExpectedProperty.Value;
            }
            set
            {
                if (prdYldRecalcExpectedProperty == null)
                    prdYldRecalcExpectedProperty = GetBooleanProperty("OpMaster.PrdYldRecalcExpected");
                prdYldRecalcExpectedProperty.Value = value;
            }
        }

        protected RowProperty<int> prdYldRecalcUnderPctProperty;
        public int PrdYldRecalcUnderPct
        {
            get
            {
                if (prdYldRecalcUnderPctProperty == null)
                    prdYldRecalcUnderPctProperty = GetIntegerProperty("OpMaster.PrdYldRecalcUnderPct");
                return prdYldRecalcUnderPctProperty.Value;
            }
            set
            {
                if (prdYldRecalcUnderPctProperty == null)
                    prdYldRecalcUnderPctProperty = GetIntegerProperty("OpMaster.PrdYldRecalcUnderPct");
                prdYldRecalcUnderPctProperty.Value = value;
            }
        }

        protected RowProperty<bool> prdYldShopWrnAlertProperty;
        public bool PrdYldShopWrnAlert
        {
            get
            {
                if (prdYldShopWrnAlertProperty == null)
                    prdYldShopWrnAlertProperty = GetBooleanProperty("OpMaster.PrdYldShopWrnAlert");
                return prdYldShopWrnAlertProperty.Value;
            }
            set
            {
                if (prdYldShopWrnAlertProperty == null)
                    prdYldShopWrnAlertProperty = GetBooleanProperty("OpMaster.PrdYldShopWrnAlert");
                prdYldShopWrnAlertProperty.Value = value;
            }
        }

        protected RowProperty<bool> prdYldShopWrnProperty;
        public bool PrdYldShopWrn
        {
            get
            {
                if (prdYldShopWrnProperty == null)
                    prdYldShopWrnProperty = GetBooleanProperty("OpMaster.PrdYldShopWrn");
                return prdYldShopWrnProperty.Value;
            }
            set
            {
                if (prdYldShopWrnProperty == null)
                    prdYldShopWrnProperty = GetBooleanProperty("OpMaster.PrdYldShopWrn");
                prdYldShopWrnProperty.Value = value;
            }
        }

        protected RowProperty<int> prdYldShopWrnUnderPctProperty;
        public int PrdYldShopWrnUnderPct
        {
            get
            {
                if (prdYldShopWrnUnderPctProperty == null)
                    prdYldShopWrnUnderPctProperty = GetIntegerProperty("OpMaster.PrdYldShopWrnUnderPct");
                return prdYldShopWrnUnderPctProperty.Value;
            }
            set
            {
                if (prdYldShopWrnUnderPctProperty == null)
                    prdYldShopWrnUnderPctProperty = GetIntegerProperty("OpMaster.PrdYldShopWrnUnderPct");
                prdYldShopWrnUnderPctProperty.Value = value;
            }
        }

        protected RowProperty<int> prdYldShopWrnOverPctProperty;
        public int PrdYldShopWrnOverPct
        {
            get
            {
                if (prdYldShopWrnOverPctProperty == null)
                    prdYldShopWrnOverPctProperty = GetIntegerProperty("OpMaster.PrdYldShopWrnOverPct");
                return prdYldShopWrnOverPctProperty.Value;
            }
            set
            {
                if (prdYldShopWrnOverPctProperty == null)
                    prdYldShopWrnOverPctProperty = GetIntegerProperty("OpMaster.PrdYldShopWrnOverPct");
                prdYldShopWrnOverPctProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("OpMaster.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("OpMaster.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("OpMaster.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("OpMaster.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> restrictSubstanceProperty;
        public bool RestrictSubstance
        {
            get
            {
                if (restrictSubstanceProperty == null)
                    restrictSubstanceProperty = GetBooleanProperty("OpMaster.RestrictSubstance");
                return restrictSubstanceProperty.Value;
            }
            set
            {
                if (restrictSubstanceProperty == null)
                    restrictSubstanceProperty = GetBooleanProperty("OpMaster.RestrictSubstance");
                restrictSubstanceProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("OpMaster.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("OpMaster.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("OpMaster.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("OpMaster.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region OpMasDtl Table

    [Serializable()]
    public abstract partial class OpMasDtlBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : OpMasDtlBase<T, R>, new()
        where R : OpMasDtlRow, new()
    {
        protected OpMasDtlBase() : base() { }

        protected static Schema.OpMasDtl schemaTable;
        public static Schema.OpMasDtl SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.OpMasDtl)E9Schema.Instance.TablesDictionary["OpMasDtl"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.OpMasDtl.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByOpCodeCriteria;
        public static T FillByOpCode(DataContext context, string companyNum, string opCode, params string[] columnNames)
        {
            if (fillByOpCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.OpMasDtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.OpMasDtl.OpCode]));
                fillByOpCodeCriteria = list.ToArray();
            }
            fillByOpCodeCriteria[0].Value = companyNum;
            fillByOpCodeCriteria[1].Value = opCode;
            return EditTable<T, R>.Fetch(context, fillByOpCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class OpMasDtl : OpMasDtlBase<OpMasDtl, OpMasDtlRow>
    {
        public OpMasDtl() : base() { }
    }

    #region OpMasDtlRow

    [Serializable()]
    public class OpMasDtlRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("OpMasDtl.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("OpMasDtl.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> opCodeProperty;
        public string OpCode
        {
            get
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("OpMasDtl.OpCode");
                return opCodeProperty.Value;
            }
            set
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("OpMasDtl.OpCode");
                opCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> setupOrProdProperty;
        public string SetupOrProd
        {
            get
            {
                if (setupOrProdProperty == null)
                    setupOrProdProperty = GetStringProperty("OpMasDtl.SetupOrProd");
                return setupOrProdProperty.Value;
            }
            set
            {
                if (setupOrProdProperty == null)
                    setupOrProdProperty = GetStringProperty("OpMasDtl.SetupOrProd");
                setupOrProdProperty.Value = value;
            }
        }

        protected RowProperty<int> opDtlSeqProperty;
        public int OpDtlSeq
        {
            get
            {
                if (opDtlSeqProperty == null)
                    opDtlSeqProperty = GetIntegerProperty("OpMasDtl.OpDtlSeq");
                return opDtlSeqProperty.Value;
            }
            set
            {
                if (opDtlSeqProperty == null)
                    opDtlSeqProperty = GetIntegerProperty("OpMasDtl.OpDtlSeq");
                opDtlSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("OpMasDtl.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("OpMasDtl.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("OpMasDtl.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("OpMasDtl.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("OpMasDtl.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("OpMasDtl.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("OpMasDtl.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("OpMasDtl.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
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
                    schemaTable = (Schema.Part)E9Schema.Instance.TablesDictionary["Part"];
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

        protected RowProperty<string> oBS900ExpenseChartProperty;
        public string OBS900_ExpenseChart
        {
            get
            {
                if (oBS900ExpenseChartProperty == null)
                    oBS900ExpenseChartProperty = GetStringProperty("Part.OBS900_ExpenseChart");
                return oBS900ExpenseChartProperty.Value;
            }
            set
            {
                if (oBS900ExpenseChartProperty == null)
                    oBS900ExpenseChartProperty = GetStringProperty("Part.OBS900_ExpenseChart");
                oBS900ExpenseChartProperty.Value = value;
            }
        }

        protected RowProperty<string> oBS900ExpenseDivProperty;
        public string OBS900_ExpenseDiv
        {
            get
            {
                if (oBS900ExpenseDivProperty == null)
                    oBS900ExpenseDivProperty = GetStringProperty("Part.OBS900_ExpenseDiv");
                return oBS900ExpenseDivProperty.Value;
            }
            set
            {
                if (oBS900ExpenseDivProperty == null)
                    oBS900ExpenseDivProperty = GetStringProperty("Part.OBS900_ExpenseDiv");
                oBS900ExpenseDivProperty.Value = value;
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

        protected RowProperty<string> oBS900ExpenseDeptProperty;
        public string OBS900_ExpenseDept
        {
            get
            {
                if (oBS900ExpenseDeptProperty == null)
                    oBS900ExpenseDeptProperty = GetStringProperty("Part.OBS900_ExpenseDept");
                return oBS900ExpenseDeptProperty.Value;
            }
            set
            {
                if (oBS900ExpenseDeptProperty == null)
                    oBS900ExpenseDeptProperty = GetStringProperty("Part.OBS900_ExpenseDept");
                oBS900ExpenseDeptProperty.Value = value;
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

        protected RowProperty<DateTime?> userDate1Property;
        public DateTime? UserDate1
        {
            get
            {
                if (userDate1Property == null)
                    userDate1Property = GetNullableDateTimeProperty("Part.UserDate1");
                return userDate1Property.Value;
            }
            set
            {
                if (userDate1Property == null)
                    userDate1Property = GetNullableDateTimeProperty("Part.UserDate1");
                userDate1Property.Value = value;
            }
        }

        protected RowProperty<DateTime?> userDate2Property;
        public DateTime? UserDate2
        {
            get
            {
                if (userDate2Property == null)
                    userDate2Property = GetNullableDateTimeProperty("Part.UserDate2");
                return userDate2Property.Value;
            }
            set
            {
                if (userDate2Property == null)
                    userDate2Property = GetNullableDateTimeProperty("Part.UserDate2");
                userDate2Property.Value = value;
            }
        }

        protected RowProperty<DateTime?> userDate3Property;
        public DateTime? UserDate3
        {
            get
            {
                if (userDate3Property == null)
                    userDate3Property = GetNullableDateTimeProperty("Part.UserDate3");
                return userDate3Property.Value;
            }
            set
            {
                if (userDate3Property == null)
                    userDate3Property = GetNullableDateTimeProperty("Part.UserDate3");
                userDate3Property.Value = value;
            }
        }

        protected RowProperty<DateTime?> userDate4Property;
        public DateTime? UserDate4
        {
            get
            {
                if (userDate4Property == null)
                    userDate4Property = GetNullableDateTimeProperty("Part.UserDate4");
                return userDate4Property.Value;
            }
            set
            {
                if (userDate4Property == null)
                    userDate4Property = GetNullableDateTimeProperty("Part.UserDate4");
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

        protected RowProperty<DateTime?> onHoldDateProperty;
        public DateTime? OnHoldDate
        {
            get
            {
                if (onHoldDateProperty == null)
                    onHoldDateProperty = GetNullableDateTimeProperty("Part.OnHoldDate");
                return onHoldDateProperty.Value;
            }
            set
            {
                if (onHoldDateProperty == null)
                    onHoldDateProperty = GetNullableDateTimeProperty("Part.OnHoldDate");
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

        protected RowProperty<string> obsolete90SNRequiredWhenInProperty;
        public string Obsolete90_SNRequiredWhenIn
        {
            get
            {
                if (obsolete90SNRequiredWhenInProperty == null)
                    obsolete90SNRequiredWhenInProperty = GetStringProperty("Part.Obsolete90_SNRequiredWhenIn");
                return obsolete90SNRequiredWhenInProperty.Value;
            }
            set
            {
                if (obsolete90SNRequiredWhenInProperty == null)
                    obsolete90SNRequiredWhenInProperty = GetStringProperty("Part.Obsolete90_SNRequiredWhenIn");
                obsolete90SNRequiredWhenInProperty.Value = value;
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

        protected RowProperty<string> uOMClassIDProperty;
        public string UOMClassID
        {
            get
            {
                if (uOMClassIDProperty == null)
                    uOMClassIDProperty = GetStringProperty("Part.UOMClassID");
                return uOMClassIDProperty.Value;
            }
            set
            {
                if (uOMClassIDProperty == null)
                    uOMClassIDProperty = GetStringProperty("Part.UOMClassID");
                uOMClassIDProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskProperty;
        public string SNMask
        {
            get
            {
                if (sNMaskProperty == null)
                    sNMaskProperty = GetStringProperty("Part.SNMask");
                return sNMaskProperty.Value;
            }
            set
            {
                if (sNMaskProperty == null)
                    sNMaskProperty = GetStringProperty("Part.SNMask");
                sNMaskProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskExampleProperty;
        public string SNMaskExample
        {
            get
            {
                if (sNMaskExampleProperty == null)
                    sNMaskExampleProperty = GetStringProperty("Part.SNMaskExample");
                return sNMaskExampleProperty.Value;
            }
            set
            {
                if (sNMaskExampleProperty == null)
                    sNMaskExampleProperty = GetStringProperty("Part.SNMaskExample");
                sNMaskExampleProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskSuffixProperty;
        public string SNMaskSuffix
        {
            get
            {
                if (sNMaskSuffixProperty == null)
                    sNMaskSuffixProperty = GetStringProperty("Part.SNMaskSuffix");
                return sNMaskSuffixProperty.Value;
            }
            set
            {
                if (sNMaskSuffixProperty == null)
                    sNMaskSuffixProperty = GetStringProperty("Part.SNMaskSuffix");
                sNMaskSuffixProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskPrefixProperty;
        public string SNMaskPrefix
        {
            get
            {
                if (sNMaskPrefixProperty == null)
                    sNMaskPrefixProperty = GetStringProperty("Part.SNMaskPrefix");
                return sNMaskPrefixProperty.Value;
            }
            set
            {
                if (sNMaskPrefixProperty == null)
                    sNMaskPrefixProperty = GetStringProperty("Part.SNMaskPrefix");
                sNMaskPrefixProperty.Value = value;
            }
        }

        protected RowProperty<string> sNLastUsedSeqProperty;
        public string SNLastUsedSeq
        {
            get
            {
                if (sNLastUsedSeqProperty == null)
                    sNLastUsedSeqProperty = GetStringProperty("Part.SNLastUsedSeq");
                return sNLastUsedSeqProperty.Value;
            }
            set
            {
                if (sNLastUsedSeqProperty == null)
                    sNLastUsedSeqProperty = GetStringProperty("Part.SNLastUsedSeq");
                sNLastUsedSeqProperty.Value = value;
            }
        }

        protected RowProperty<bool> useMaskSeqProperty;
        public bool UseMaskSeq
        {
            get
            {
                if (useMaskSeqProperty == null)
                    useMaskSeqProperty = GetBooleanProperty("Part.UseMaskSeq");
                return useMaskSeqProperty.Value;
            }
            set
            {
                if (useMaskSeqProperty == null)
                    useMaskSeqProperty = GetBooleanProperty("Part.UseMaskSeq");
                useMaskSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> netWeightUOMProperty;
        public string NetWeightUOM
        {
            get
            {
                if (netWeightUOMProperty == null)
                    netWeightUOMProperty = GetStringProperty("Part.NetWeightUOM");
                return netWeightUOMProperty.Value;
            }
            set
            {
                if (netWeightUOMProperty == null)
                    netWeightUOMProperty = GetStringProperty("Part.NetWeightUOM");
                netWeightUOMProperty.Value = value;
            }
        }

        protected RowProperty<string> netVolumeUOMProperty;
        public string NetVolumeUOM
        {
            get
            {
                if (netVolumeUOMProperty == null)
                    netVolumeUOMProperty = GetStringProperty("Part.NetVolumeUOM");
                return netVolumeUOMProperty.Value;
            }
            set
            {
                if (netVolumeUOMProperty == null)
                    netVolumeUOMProperty = GetStringProperty("Part.NetVolumeUOM");
                netVolumeUOMProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotBatchProperty;
        public bool LotBatch
        {
            get
            {
                if (lotBatchProperty == null)
                    lotBatchProperty = GetBooleanProperty("Part.LotBatch");
                return lotBatchProperty.Value;
            }
            set
            {
                if (lotBatchProperty == null)
                    lotBatchProperty = GetBooleanProperty("Part.LotBatch");
                lotBatchProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotMfgBatchProperty;
        public bool LotMfgBatch
        {
            get
            {
                if (lotMfgBatchProperty == null)
                    lotMfgBatchProperty = GetBooleanProperty("Part.LotMfgBatch");
                return lotMfgBatchProperty.Value;
            }
            set
            {
                if (lotMfgBatchProperty == null)
                    lotMfgBatchProperty = GetBooleanProperty("Part.LotMfgBatch");
                lotMfgBatchProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotMfgLotProperty;
        public bool LotMfgLot
        {
            get
            {
                if (lotMfgLotProperty == null)
                    lotMfgLotProperty = GetBooleanProperty("Part.LotMfgLot");
                return lotMfgLotProperty.Value;
            }
            set
            {
                if (lotMfgLotProperty == null)
                    lotMfgLotProperty = GetBooleanProperty("Part.LotMfgLot");
                lotMfgLotProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotHeatProperty;
        public bool LotHeat
        {
            get
            {
                if (lotHeatProperty == null)
                    lotHeatProperty = GetBooleanProperty("Part.LotHeat");
                return lotHeatProperty.Value;
            }
            set
            {
                if (lotHeatProperty == null)
                    lotHeatProperty = GetBooleanProperty("Part.LotHeat");
                lotHeatProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotFirmwareProperty;
        public bool LotFirmware
        {
            get
            {
                if (lotFirmwareProperty == null)
                    lotFirmwareProperty = GetBooleanProperty("Part.LotFirmware");
                return lotFirmwareProperty.Value;
            }
            set
            {
                if (lotFirmwareProperty == null)
                    lotFirmwareProperty = GetBooleanProperty("Part.LotFirmware");
                lotFirmwareProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotBeforeDtProperty;
        public bool LotBeforeDt
        {
            get
            {
                if (lotBeforeDtProperty == null)
                    lotBeforeDtProperty = GetBooleanProperty("Part.LotBeforeDt");
                return lotBeforeDtProperty.Value;
            }
            set
            {
                if (lotBeforeDtProperty == null)
                    lotBeforeDtProperty = GetBooleanProperty("Part.LotBeforeDt");
                lotBeforeDtProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotMfgDtProperty;
        public bool LotMfgDt
        {
            get
            {
                if (lotMfgDtProperty == null)
                    lotMfgDtProperty = GetBooleanProperty("Part.LotMfgDt");
                return lotMfgDtProperty.Value;
            }
            set
            {
                if (lotMfgDtProperty == null)
                    lotMfgDtProperty = GetBooleanProperty("Part.LotMfgDt");
                lotMfgDtProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotCureDtProperty;
        public bool LotCureDt
        {
            get
            {
                if (lotCureDtProperty == null)
                    lotCureDtProperty = GetBooleanProperty("Part.LotCureDt");
                return lotCureDtProperty.Value;
            }
            set
            {
                if (lotCureDtProperty == null)
                    lotCureDtProperty = GetBooleanProperty("Part.LotCureDt");
                lotCureDtProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotExpDtProperty;
        public bool LotExpDt
        {
            get
            {
                if (lotExpDtProperty == null)
                    lotExpDtProperty = GetBooleanProperty("Part.LotExpDt");
                return lotExpDtProperty.Value;
            }
            set
            {
                if (lotExpDtProperty == null)
                    lotExpDtProperty = GetBooleanProperty("Part.LotExpDt");
                lotExpDtProperty.Value = value;
            }
        }

        protected RowProperty<string> lotPrefixProperty;
        public string LotPrefix
        {
            get
            {
                if (lotPrefixProperty == null)
                    lotPrefixProperty = GetStringProperty("Part.LotPrefix");
                return lotPrefixProperty.Value;
            }
            set
            {
                if (lotPrefixProperty == null)
                    lotPrefixProperty = GetStringProperty("Part.LotPrefix");
                lotPrefixProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotUseGlobalSeqProperty;
        public bool LotUseGlobalSeq
        {
            get
            {
                if (lotUseGlobalSeqProperty == null)
                    lotUseGlobalSeqProperty = GetBooleanProperty("Part.LotUseGlobalSeq");
                return lotUseGlobalSeqProperty.Value;
            }
            set
            {
                if (lotUseGlobalSeqProperty == null)
                    lotUseGlobalSeqProperty = GetBooleanProperty("Part.LotUseGlobalSeq");
                lotUseGlobalSeqProperty.Value = value;
            }
        }

        protected RowProperty<int> lotNxtNumProperty;
        public int LotNxtNum
        {
            get
            {
                if (lotNxtNumProperty == null)
                    lotNxtNumProperty = GetIntegerProperty("Part.LotNxtNum");
                return lotNxtNumProperty.Value;
            }
            set
            {
                if (lotNxtNumProperty == null)
                    lotNxtNumProperty = GetIntegerProperty("Part.LotNxtNum");
                lotNxtNumProperty.Value = value;
            }
        }

        protected RowProperty<int> lotDigitsProperty;
        public int LotDigits
        {
            get
            {
                if (lotDigitsProperty == null)
                    lotDigitsProperty = GetIntegerProperty("Part.LotDigits");
                return lotDigitsProperty.Value;
            }
            set
            {
                if (lotDigitsProperty == null)
                    lotDigitsProperty = GetIntegerProperty("Part.LotDigits");
                lotDigitsProperty.Value = value;
            }
        }

        protected RowProperty<string> lotAppendDateProperty;
        public string LotAppendDate
        {
            get
            {
                if (lotAppendDateProperty == null)
                    lotAppendDateProperty = GetStringProperty("Part.LotAppendDate");
                return lotAppendDateProperty.Value;
            }
            set
            {
                if (lotAppendDateProperty == null)
                    lotAppendDateProperty = GetStringProperty("Part.LotAppendDate");
                lotAppendDateProperty.Value = value;
            }
        }

        protected RowProperty<string> lotSeqIDProperty;
        public string LotSeqID
        {
            get
            {
                if (lotSeqIDProperty == null)
                    lotSeqIDProperty = GetStringProperty("Part.LotSeqID");
                return lotSeqIDProperty.Value;
            }
            set
            {
                if (lotSeqIDProperty == null)
                    lotSeqIDProperty = GetStringProperty("Part.LotSeqID");
                lotSeqIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> lotLeadingZerosProperty;
        public bool LotLeadingZeros
        {
            get
            {
                if (lotLeadingZerosProperty == null)
                    lotLeadingZerosProperty = GetBooleanProperty("Part.LotLeadingZeros");
                return lotLeadingZerosProperty.Value;
            }
            set
            {
                if (lotLeadingZerosProperty == null)
                    lotLeadingZerosProperty = GetBooleanProperty("Part.LotLeadingZeros");
                lotLeadingZerosProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("Part.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("Part.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("Part.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("Part.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> buyToOrderProperty;
        public bool BuyToOrder
        {
            get
            {
                if (buyToOrderProperty == null)
                    buyToOrderProperty = GetBooleanProperty("Part.BuyToOrder");
                return buyToOrderProperty.Value;
            }
            set
            {
                if (buyToOrderProperty == null)
                    buyToOrderProperty = GetBooleanProperty("Part.BuyToOrder");
                buyToOrderProperty.Value = value;
            }
        }

        protected RowProperty<bool> dropShipProperty;
        public bool DropShip
        {
            get
            {
                if (dropShipProperty == null)
                    dropShipProperty = GetBooleanProperty("Part.DropShip");
                return dropShipProperty.Value;
            }
            set
            {
                if (dropShipProperty == null)
                    dropShipProperty = GetBooleanProperty("Part.DropShip");
                dropShipProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("Part.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("Part.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> isConfiguredProperty;
        public bool IsConfigured
        {
            get
            {
                if (isConfiguredProperty == null)
                    isConfiguredProperty = GetBooleanProperty("Part.IsConfigured");
                return isConfiguredProperty.Value;
            }
            set
            {
                if (isConfiguredProperty == null)
                    isConfiguredProperty = GetBooleanProperty("Part.IsConfigured");
                isConfiguredProperty.Value = value;
            }
        }

        protected RowProperty<bool> extConfigProperty;
        public bool ExtConfig
        {
            get
            {
                if (extConfigProperty == null)
                    extConfigProperty = GetBooleanProperty("Part.ExtConfig");
                return extConfigProperty.Value;
            }
            set
            {
                if (extConfigProperty == null)
                    extConfigProperty = GetBooleanProperty("Part.ExtConfig");
                extConfigProperty.Value = value;
            }
        }

        protected RowProperty<string> refCategoryProperty;
        public string RefCategory
        {
            get
            {
                if (refCategoryProperty == null)
                    refCategoryProperty = GetStringProperty("Part.RefCategory");
                return refCategoryProperty.Value;
            }
            set
            {
                if (refCategoryProperty == null)
                    refCategoryProperty = GetStringProperty("Part.RefCategory");
                refCategoryProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("Part.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("Part.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartBin Table

    [Serializable()]
    public abstract partial class PartBinBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartBinBase<T, R>, new()
        where R : PartBinRow, new()
    {
        protected PartBinBase() : base() { }

        protected static Schema.PartBin schemaTable;
        public static Schema.PartBin SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartBin)E9Schema.Instance.TablesDictionary["PartBin"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByWarehouseCodeCriteria;
        public static T FillByWarehouseCode(DataContext context, string companyNum, string partNum, string warehouseCode, params string[] columnNames)
        {
            if (fillByWarehouseCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.WarehouseCode]));
                fillByWarehouseCodeCriteria = list.ToArray();
            }
            fillByWarehouseCodeCriteria[0].Value = companyNum;
            fillByWarehouseCodeCriteria[1].Value = partNum;
            fillByWarehouseCodeCriteria[2].Value = warehouseCode;
            return EditTable<T, R>.Fetch(context, fillByWarehouseCodeCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByBinNumCriteria;
        public static T FillByBinNum(DataContext context, string companyNum, string partNum, string warehouseCode, string binNum, params string[] columnNames)
        {
            if (fillByBinNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.WarehouseCode]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.BinNum]));
                fillByBinNumCriteria = list.ToArray();
            }
            fillByBinNumCriteria[0].Value = companyNum;
            fillByBinNumCriteria[1].Value = partNum;
            fillByBinNumCriteria[2].Value = warehouseCode;
            fillByBinNumCriteria[3].Value = binNum;
            return EditTable<T, R>.Fetch(context, fillByBinNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByDimCodeCriteria;
        public static T FillByDimCode(DataContext context, string companyNum, string partNum, string warehouseCode, string binNum, string dimCode, params string[] columnNames)
        {
            if (fillByDimCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.WarehouseCode]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.BinNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.DimCode]));
                fillByDimCodeCriteria = list.ToArray();
            }
            fillByDimCodeCriteria[0].Value = companyNum;
            fillByDimCodeCriteria[1].Value = partNum;
            fillByDimCodeCriteria[2].Value = warehouseCode;
            fillByDimCodeCriteria[3].Value = binNum;
            fillByDimCodeCriteria[4].Value = dimCode;
            return EditTable<T, R>.Fetch(context, fillByDimCodeCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByLotNumCriteria;
        public static T FillByLotNum(DataContext context, string companyNum, string partNum, string warehouseCode, string binNum, string dimCode, string lotNum, params string[] columnNames)
        {
            if (fillByLotNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.WarehouseCode]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.BinNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.DimCode]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartBin.LotNum]));
                fillByLotNumCriteria = list.ToArray();
            }
            fillByLotNumCriteria[0].Value = companyNum;
            fillByLotNumCriteria[1].Value = partNum;
            fillByLotNumCriteria[2].Value = warehouseCode;
            fillByLotNumCriteria[3].Value = binNum;
            fillByLotNumCriteria[4].Value = dimCode;
            fillByLotNumCriteria[5].Value = lotNum;
            return EditTable<T, R>.Fetch(context, fillByLotNumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartBin : PartBinBase<PartBin, PartBinRow>
    {
        public PartBin() : base() { }
    }

    #region PartBinRow

    [Serializable()]
    public class PartBinRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartBin.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartBin.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartBin.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartBin.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> warehouseCodeProperty;
        public string WarehouseCode
        {
            get
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PartBin.WarehouseCode");
                return warehouseCodeProperty.Value;
            }
            set
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PartBin.WarehouseCode");
                warehouseCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> binNumProperty;
        public string BinNum
        {
            get
            {
                if (binNumProperty == null)
                    binNumProperty = GetStringProperty("PartBin.BinNum");
                return binNumProperty.Value;
            }
            set
            {
                if (binNumProperty == null)
                    binNumProperty = GetStringProperty("PartBin.BinNum");
                binNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> onhandQtyProperty;
        public decimal OnhandQty
        {
            get
            {
                if (onhandQtyProperty == null)
                    onhandQtyProperty = GetDecimalProperty("PartBin.OnhandQty");
                return onhandQtyProperty.Value;
            }
            set
            {
                if (onhandQtyProperty == null)
                    onhandQtyProperty = GetDecimalProperty("PartBin.OnhandQty");
                onhandQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> lotNumProperty;
        public string LotNum
        {
            get
            {
                if (lotNumProperty == null)
                    lotNumProperty = GetStringProperty("PartBin.LotNum");
                return lotNumProperty.Value;
            }
            set
            {
                if (lotNumProperty == null)
                    lotNumProperty = GetStringProperty("PartBin.LotNum");
                lotNumProperty.Value = value;
            }
        }

        protected RowProperty<string> dimCodeProperty;
        public string DimCode
        {
            get
            {
                if (dimCodeProperty == null)
                    dimCodeProperty = GetStringProperty("PartBin.DimCode");
                return dimCodeProperty.Value;
            }
            set
            {
                if (dimCodeProperty == null)
                    dimCodeProperty = GetStringProperty("PartBin.DimCode");
                dimCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartBin.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartBin.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartBin.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartBin.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> allocatedQtyProperty;
        public decimal AllocatedQty
        {
            get
            {
                if (allocatedQtyProperty == null)
                    allocatedQtyProperty = GetDecimalProperty("PartBin.AllocatedQty");
                return allocatedQtyProperty.Value;
            }
            set
            {
                if (allocatedQtyProperty == null)
                    allocatedQtyProperty = GetDecimalProperty("PartBin.AllocatedQty");
                allocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesAllocatedQtyProperty;
        public decimal SalesAllocatedQty
        {
            get
            {
                if (salesAllocatedQtyProperty == null)
                    salesAllocatedQtyProperty = GetDecimalProperty("PartBin.SalesAllocatedQty");
                return salesAllocatedQtyProperty.Value;
            }
            set
            {
                if (salesAllocatedQtyProperty == null)
                    salesAllocatedQtyProperty = GetDecimalProperty("PartBin.SalesAllocatedQty");
                salesAllocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobAllocatedQtyProperty;
        public decimal JobAllocatedQty
        {
            get
            {
                if (jobAllocatedQtyProperty == null)
                    jobAllocatedQtyProperty = GetDecimalProperty("PartBin.JobAllocatedQty");
                return jobAllocatedQtyProperty.Value;
            }
            set
            {
                if (jobAllocatedQtyProperty == null)
                    jobAllocatedQtyProperty = GetDecimalProperty("PartBin.JobAllocatedQty");
                jobAllocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdAllocatedQtyProperty;
        public decimal TFOrdAllocatedQty
        {
            get
            {
                if (tFOrdAllocatedQtyProperty == null)
                    tFOrdAllocatedQtyProperty = GetDecimalProperty("PartBin.TFOrdAllocatedQty");
                return tFOrdAllocatedQtyProperty.Value;
            }
            set
            {
                if (tFOrdAllocatedQtyProperty == null)
                    tFOrdAllocatedQtyProperty = GetDecimalProperty("PartBin.TFOrdAllocatedQty");
                tFOrdAllocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesPickingQtyProperty;
        public decimal SalesPickingQty
        {
            get
            {
                if (salesPickingQtyProperty == null)
                    salesPickingQtyProperty = GetDecimalProperty("PartBin.SalesPickingQty");
                return salesPickingQtyProperty.Value;
            }
            set
            {
                if (salesPickingQtyProperty == null)
                    salesPickingQtyProperty = GetDecimalProperty("PartBin.SalesPickingQty");
                salesPickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesPickedQtyProperty;
        public decimal SalesPickedQty
        {
            get
            {
                if (salesPickedQtyProperty == null)
                    salesPickedQtyProperty = GetDecimalProperty("PartBin.SalesPickedQty");
                return salesPickedQtyProperty.Value;
            }
            set
            {
                if (salesPickedQtyProperty == null)
                    salesPickedQtyProperty = GetDecimalProperty("PartBin.SalesPickedQty");
                salesPickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartBin.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartBin.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobPickingQtyProperty;
        public decimal JobPickingQty
        {
            get
            {
                if (jobPickingQtyProperty == null)
                    jobPickingQtyProperty = GetDecimalProperty("PartBin.JobPickingQty");
                return jobPickingQtyProperty.Value;
            }
            set
            {
                if (jobPickingQtyProperty == null)
                    jobPickingQtyProperty = GetDecimalProperty("PartBin.JobPickingQty");
                jobPickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobPickedQtyProperty;
        public decimal JobPickedQty
        {
            get
            {
                if (jobPickedQtyProperty == null)
                    jobPickedQtyProperty = GetDecimalProperty("PartBin.JobPickedQty");
                return jobPickedQtyProperty.Value;
            }
            set
            {
                if (jobPickedQtyProperty == null)
                    jobPickedQtyProperty = GetDecimalProperty("PartBin.JobPickedQty");
                jobPickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdPickingQtyProperty;
        public decimal TFOrdPickingQty
        {
            get
            {
                if (tFOrdPickingQtyProperty == null)
                    tFOrdPickingQtyProperty = GetDecimalProperty("PartBin.TFOrdPickingQty");
                return tFOrdPickingQtyProperty.Value;
            }
            set
            {
                if (tFOrdPickingQtyProperty == null)
                    tFOrdPickingQtyProperty = GetDecimalProperty("PartBin.TFOrdPickingQty");
                tFOrdPickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdPickedQtyProperty;
        public decimal TFOrdPickedQty
        {
            get
            {
                if (tFOrdPickedQtyProperty == null)
                    tFOrdPickedQtyProperty = GetDecimalProperty("PartBin.TFOrdPickedQty");
                return tFOrdPickedQtyProperty.Value;
            }
            set
            {
                if (tFOrdPickedQtyProperty == null)
                    tFOrdPickedQtyProperty = GetDecimalProperty("PartBin.TFOrdPickedQty");
                tFOrdPickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> shippingQtyProperty;
        public decimal ShippingQty
        {
            get
            {
                if (shippingQtyProperty == null)
                    shippingQtyProperty = GetDecimalProperty("PartBin.ShippingQty");
                return shippingQtyProperty.Value;
            }
            set
            {
                if (shippingQtyProperty == null)
                    shippingQtyProperty = GetDecimalProperty("PartBin.ShippingQty");
                shippingQtyProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartBin.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartBin.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartCost Table

    [Serializable()]
    public abstract partial class PartCostBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartCostBase<T, R>, new()
        where R : PartCostRow, new()
    {
        protected PartCostBase() : base() { }

        protected static Schema.PartCost schemaTable;
        public static Schema.PartCost SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartCost)E9Schema.Instance.TablesDictionary["PartCost"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartCost.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartCost.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartCost.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByCostIDCriteria;
        public static T FillByCostID(DataContext context, string companyNum, string partNum, string costID, params string[] columnNames)
        {
            if (fillByCostIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartCost.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartCost.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartCost.CostID]));
                fillByCostIDCriteria = list.ToArray();
            }
            fillByCostIDCriteria[0].Value = companyNum;
            fillByCostIDCriteria[1].Value = partNum;
            fillByCostIDCriteria[2].Value = costID;
            return EditTable<T, R>.Fetch(context, fillByCostIDCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartCost : PartCostBase<PartCost, PartCostRow>
    {
        public PartCost() : base() { }
    }

    #region PartCostRow

    [Serializable()]
    public class PartCostRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartCost.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartCost.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartCost.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartCost.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> avgLaborCostProperty;
        public decimal AvgLaborCost
        {
            get
            {
                if (avgLaborCostProperty == null)
                    avgLaborCostProperty = GetDecimalProperty("PartCost.AvgLaborCost");
                return avgLaborCostProperty.Value;
            }
            set
            {
                if (avgLaborCostProperty == null)
                    avgLaborCostProperty = GetDecimalProperty("PartCost.AvgLaborCost");
                avgLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> avgBurdenCostProperty;
        public decimal AvgBurdenCost
        {
            get
            {
                if (avgBurdenCostProperty == null)
                    avgBurdenCostProperty = GetDecimalProperty("PartCost.AvgBurdenCost");
                return avgBurdenCostProperty.Value;
            }
            set
            {
                if (avgBurdenCostProperty == null)
                    avgBurdenCostProperty = GetDecimalProperty("PartCost.AvgBurdenCost");
                avgBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> avgMaterialCostProperty;
        public decimal AvgMaterialCost
        {
            get
            {
                if (avgMaterialCostProperty == null)
                    avgMaterialCostProperty = GetDecimalProperty("PartCost.AvgMaterialCost");
                return avgMaterialCostProperty.Value;
            }
            set
            {
                if (avgMaterialCostProperty == null)
                    avgMaterialCostProperty = GetDecimalProperty("PartCost.AvgMaterialCost");
                avgMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> avgSubContCostProperty;
        public decimal AvgSubContCost
        {
            get
            {
                if (avgSubContCostProperty == null)
                    avgSubContCostProperty = GetDecimalProperty("PartCost.AvgSubContCost");
                return avgSubContCostProperty.Value;
            }
            set
            {
                if (avgSubContCostProperty == null)
                    avgSubContCostProperty = GetDecimalProperty("PartCost.AvgSubContCost");
                avgSubContCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> avgMtlBurCostProperty;
        public decimal AvgMtlBurCost
        {
            get
            {
                if (avgMtlBurCostProperty == null)
                    avgMtlBurCostProperty = GetDecimalProperty("PartCost.AvgMtlBurCost");
                return avgMtlBurCostProperty.Value;
            }
            set
            {
                if (avgMtlBurCostProperty == null)
                    avgMtlBurCostProperty = GetDecimalProperty("PartCost.AvgMtlBurCost");
                avgMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> stdLaborCostProperty;
        public decimal StdLaborCost
        {
            get
            {
                if (stdLaborCostProperty == null)
                    stdLaborCostProperty = GetDecimalProperty("PartCost.StdLaborCost");
                return stdLaborCostProperty.Value;
            }
            set
            {
                if (stdLaborCostProperty == null)
                    stdLaborCostProperty = GetDecimalProperty("PartCost.StdLaborCost");
                stdLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> stdBurdenCostProperty;
        public decimal StdBurdenCost
        {
            get
            {
                if (stdBurdenCostProperty == null)
                    stdBurdenCostProperty = GetDecimalProperty("PartCost.StdBurdenCost");
                return stdBurdenCostProperty.Value;
            }
            set
            {
                if (stdBurdenCostProperty == null)
                    stdBurdenCostProperty = GetDecimalProperty("PartCost.StdBurdenCost");
                stdBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> stdMaterialCostProperty;
        public decimal StdMaterialCost
        {
            get
            {
                if (stdMaterialCostProperty == null)
                    stdMaterialCostProperty = GetDecimalProperty("PartCost.StdMaterialCost");
                return stdMaterialCostProperty.Value;
            }
            set
            {
                if (stdMaterialCostProperty == null)
                    stdMaterialCostProperty = GetDecimalProperty("PartCost.StdMaterialCost");
                stdMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> stdSubContCostProperty;
        public decimal StdSubContCost
        {
            get
            {
                if (stdSubContCostProperty == null)
                    stdSubContCostProperty = GetDecimalProperty("PartCost.StdSubContCost");
                return stdSubContCostProperty.Value;
            }
            set
            {
                if (stdSubContCostProperty == null)
                    stdSubContCostProperty = GetDecimalProperty("PartCost.StdSubContCost");
                stdSubContCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> stdMtlBurCostProperty;
        public decimal StdMtlBurCost
        {
            get
            {
                if (stdMtlBurCostProperty == null)
                    stdMtlBurCostProperty = GetDecimalProperty("PartCost.StdMtlBurCost");
                return stdMtlBurCostProperty.Value;
            }
            set
            {
                if (stdMtlBurCostProperty == null)
                    stdMtlBurCostProperty = GetDecimalProperty("PartCost.StdMtlBurCost");
                stdMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lastLaborCostProperty;
        public decimal LastLaborCost
        {
            get
            {
                if (lastLaborCostProperty == null)
                    lastLaborCostProperty = GetDecimalProperty("PartCost.LastLaborCost");
                return lastLaborCostProperty.Value;
            }
            set
            {
                if (lastLaborCostProperty == null)
                    lastLaborCostProperty = GetDecimalProperty("PartCost.LastLaborCost");
                lastLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lastBurdenCostProperty;
        public decimal LastBurdenCost
        {
            get
            {
                if (lastBurdenCostProperty == null)
                    lastBurdenCostProperty = GetDecimalProperty("PartCost.LastBurdenCost");
                return lastBurdenCostProperty.Value;
            }
            set
            {
                if (lastBurdenCostProperty == null)
                    lastBurdenCostProperty = GetDecimalProperty("PartCost.LastBurdenCost");
                lastBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lastMaterialCostProperty;
        public decimal LastMaterialCost
        {
            get
            {
                if (lastMaterialCostProperty == null)
                    lastMaterialCostProperty = GetDecimalProperty("PartCost.LastMaterialCost");
                return lastMaterialCostProperty.Value;
            }
            set
            {
                if (lastMaterialCostProperty == null)
                    lastMaterialCostProperty = GetDecimalProperty("PartCost.LastMaterialCost");
                lastMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lastSubContCostProperty;
        public decimal LastSubContCost
        {
            get
            {
                if (lastSubContCostProperty == null)
                    lastSubContCostProperty = GetDecimalProperty("PartCost.LastSubContCost");
                return lastSubContCostProperty.Value;
            }
            set
            {
                if (lastSubContCostProperty == null)
                    lastSubContCostProperty = GetDecimalProperty("PartCost.LastSubContCost");
                lastSubContCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lastMtlBurCostProperty;
        public decimal LastMtlBurCost
        {
            get
            {
                if (lastMtlBurCostProperty == null)
                    lastMtlBurCostProperty = GetDecimalProperty("PartCost.LastMtlBurCost");
                return lastMtlBurCostProperty.Value;
            }
            set
            {
                if (lastMtlBurCostProperty == null)
                    lastMtlBurCostProperty = GetDecimalProperty("PartCost.LastMtlBurCost");
                lastMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<string> costIDProperty;
        public string CostID
        {
            get
            {
                if (costIDProperty == null)
                    costIDProperty = GetStringProperty("PartCost.CostID");
                return costIDProperty.Value;
            }
            set
            {
                if (costIDProperty == null)
                    costIDProperty = GetStringProperty("PartCost.CostID");
                costIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> fIFOAvgLaborCostProperty;
        public decimal FIFOAvgLaborCost
        {
            get
            {
                if (fIFOAvgLaborCostProperty == null)
                    fIFOAvgLaborCostProperty = GetDecimalProperty("PartCost.FIFOAvgLaborCost");
                return fIFOAvgLaborCostProperty.Value;
            }
            set
            {
                if (fIFOAvgLaborCostProperty == null)
                    fIFOAvgLaborCostProperty = GetDecimalProperty("PartCost.FIFOAvgLaborCost");
                fIFOAvgLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> fIFOAvgBurdenCostProperty;
        public decimal FIFOAvgBurdenCost
        {
            get
            {
                if (fIFOAvgBurdenCostProperty == null)
                    fIFOAvgBurdenCostProperty = GetDecimalProperty("PartCost.FIFOAvgBurdenCost");
                return fIFOAvgBurdenCostProperty.Value;
            }
            set
            {
                if (fIFOAvgBurdenCostProperty == null)
                    fIFOAvgBurdenCostProperty = GetDecimalProperty("PartCost.FIFOAvgBurdenCost");
                fIFOAvgBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> fIFOAvgMaterialCostProperty;
        public decimal FIFOAvgMaterialCost
        {
            get
            {
                if (fIFOAvgMaterialCostProperty == null)
                    fIFOAvgMaterialCostProperty = GetDecimalProperty("PartCost.FIFOAvgMaterialCost");
                return fIFOAvgMaterialCostProperty.Value;
            }
            set
            {
                if (fIFOAvgMaterialCostProperty == null)
                    fIFOAvgMaterialCostProperty = GetDecimalProperty("PartCost.FIFOAvgMaterialCost");
                fIFOAvgMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> fIFOAvgSubContCostProperty;
        public decimal FIFOAvgSubContCost
        {
            get
            {
                if (fIFOAvgSubContCostProperty == null)
                    fIFOAvgSubContCostProperty = GetDecimalProperty("PartCost.FIFOAvgSubContCost");
                return fIFOAvgSubContCostProperty.Value;
            }
            set
            {
                if (fIFOAvgSubContCostProperty == null)
                    fIFOAvgSubContCostProperty = GetDecimalProperty("PartCost.FIFOAvgSubContCost");
                fIFOAvgSubContCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> fIFOAvgMtlBurCostProperty;
        public decimal FIFOAvgMtlBurCost
        {
            get
            {
                if (fIFOAvgMtlBurCostProperty == null)
                    fIFOAvgMtlBurCostProperty = GetDecimalProperty("PartCost.FIFOAvgMtlBurCost");
                return fIFOAvgMtlBurCostProperty.Value;
            }
            set
            {
                if (fIFOAvgMtlBurCostProperty == null)
                    fIFOAvgMtlBurCostProperty = GetDecimalProperty("PartCost.FIFOAvgMtlBurCost");
                fIFOAvgMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartCost.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartCost.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartCost.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartCost.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartCost.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartCost.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartCost.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartCost.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartMtl Table

    [Serializable()]
    public abstract partial class PartMtlBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartMtlBase<T, R>, new()
        where R : PartMtlRow, new()
    {
        protected PartMtlBase() : base() { }

        protected static Schema.PartMtl schemaTable;
        public static Schema.PartMtl SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartMtl)E9Schema.Instance.TablesDictionary["PartMtl"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByRevisionNumCriteria;
        public static T FillByRevisionNum(DataContext context, string companyNum, string partNum, string revisionNum, params string[] columnNames)
        {
            if (fillByRevisionNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.RevisionNum]));
                fillByRevisionNumCriteria = list.ToArray();
            }
            fillByRevisionNumCriteria[0].Value = companyNum;
            fillByRevisionNumCriteria[1].Value = partNum;
            fillByRevisionNumCriteria[2].Value = revisionNum;
            return EditTable<T, R>.Fetch(context, fillByRevisionNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByAltMethodCriteria;
        public static T FillByAltMethod(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, params string[] columnNames)
        {
            if (fillByAltMethodCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.AltMethod]));
                fillByAltMethodCriteria = list.ToArray();
            }
            fillByAltMethodCriteria[0].Value = companyNum;
            fillByAltMethodCriteria[1].Value = partNum;
            fillByAltMethodCriteria[2].Value = revisionNum;
            fillByAltMethodCriteria[3].Value = altMethod;
            return EditTable<T, R>.Fetch(context, fillByAltMethodCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByMtlSeqCriteria;
        public static T FillByMtlSeq(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, int mtlSeq, params string[] columnNames)
        {
            if (fillByMtlSeqCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartMtl.AltMethod]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PartMtl.MtlSeq]));
                fillByMtlSeqCriteria = list.ToArray();
            }
            fillByMtlSeqCriteria[0].Value = companyNum;
            fillByMtlSeqCriteria[1].Value = partNum;
            fillByMtlSeqCriteria[2].Value = revisionNum;
            fillByMtlSeqCriteria[3].Value = altMethod;
            fillByMtlSeqCriteria[4].Value = mtlSeq;
            return EditTable<T, R>.Fetch(context, fillByMtlSeqCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartMtl : PartMtlBase<PartMtl, PartMtlRow>
    {
        public PartMtl() : base() { }
    }

    #region PartMtlRow

    [Serializable()]
    public class PartMtlRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartMtl.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartMtl.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartMtl.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartMtl.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumProperty;
        public string RevisionNum
        {
            get
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartMtl.RevisionNum");
                return revisionNumProperty.Value;
            }
            set
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartMtl.RevisionNum");
                revisionNumProperty.Value = value;
            }
        }

        protected RowProperty<int> mtlSeqProperty;
        public int MtlSeq
        {
            get
            {
                if (mtlSeqProperty == null)
                    mtlSeqProperty = GetIntegerProperty("PartMtl.MtlSeq");
                return mtlSeqProperty.Value;
            }
            set
            {
                if (mtlSeqProperty == null)
                    mtlSeqProperty = GetIntegerProperty("PartMtl.MtlSeq");
                mtlSeqProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qtyPerProperty;
        public decimal QtyPer
        {
            get
            {
                if (qtyPerProperty == null)
                    qtyPerProperty = GetDecimalProperty("PartMtl.QtyPer");
                return qtyPerProperty.Value;
            }
            set
            {
                if (qtyPerProperty == null)
                    qtyPerProperty = GetDecimalProperty("PartMtl.QtyPer");
                qtyPerProperty.Value = value;
            }
        }

        protected RowProperty<string> mtlPartNumProperty;
        public string MtlPartNum
        {
            get
            {
                if (mtlPartNumProperty == null)
                    mtlPartNumProperty = GetStringProperty("PartMtl.MtlPartNum");
                return mtlPartNumProperty.Value;
            }
            set
            {
                if (mtlPartNumProperty == null)
                    mtlPartNumProperty = GetStringProperty("PartMtl.MtlPartNum");
                mtlPartNumProperty.Value = value;
            }
        }

        protected RowProperty<string> findNumProperty;
        public string FindNum
        {
            get
            {
                if (findNumProperty == null)
                    findNumProperty = GetStringProperty("PartMtl.FindNum");
                return findNumProperty.Value;
            }
            set
            {
                if (findNumProperty == null)
                    findNumProperty = GetStringProperty("PartMtl.FindNum");
                findNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> fixedQtyProperty;
        public bool FixedQty
        {
            get
            {
                if (fixedQtyProperty == null)
                    fixedQtyProperty = GetBooleanProperty("PartMtl.FixedQty");
                return fixedQtyProperty.Value;
            }
            set
            {
                if (fixedQtyProperty == null)
                    fixedQtyProperty = GetBooleanProperty("PartMtl.FixedQty");
                fixedQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> relatedOperationProperty;
        public int RelatedOperation
        {
            get
            {
                if (relatedOperationProperty == null)
                    relatedOperationProperty = GetIntegerProperty("PartMtl.RelatedOperation");
                return relatedOperationProperty.Value;
            }
            set
            {
                if (relatedOperationProperty == null)
                    relatedOperationProperty = GetIntegerProperty("PartMtl.RelatedOperation");
                relatedOperationProperty.Value = value;
            }
        }

        protected RowProperty<bool> overRideMfgCommentsProperty;
        public bool OverRideMfgComments
        {
            get
            {
                if (overRideMfgCommentsProperty == null)
                    overRideMfgCommentsProperty = GetBooleanProperty("PartMtl.OverRideMfgComments");
                return overRideMfgCommentsProperty.Value;
            }
            set
            {
                if (overRideMfgCommentsProperty == null)
                    overRideMfgCommentsProperty = GetBooleanProperty("PartMtl.OverRideMfgComments");
                overRideMfgCommentsProperty.Value = value;
            }
        }

        protected RowProperty<string> salvagePartNumProperty;
        public string SalvagePartNum
        {
            get
            {
                if (salvagePartNumProperty == null)
                    salvagePartNumProperty = GetStringProperty("PartMtl.SalvagePartNum");
                return salvagePartNumProperty.Value;
            }
            set
            {
                if (salvagePartNumProperty == null)
                    salvagePartNumProperty = GetStringProperty("PartMtl.SalvagePartNum");
                salvagePartNumProperty.Value = value;
            }
        }

        protected RowProperty<string> salvageDescriptionProperty;
        public string SalvageDescription
        {
            get
            {
                if (salvageDescriptionProperty == null)
                    salvageDescriptionProperty = GetStringProperty("PartMtl.SalvageDescription");
                return salvageDescriptionProperty.Value;
            }
            set
            {
                if (salvageDescriptionProperty == null)
                    salvageDescriptionProperty = GetStringProperty("PartMtl.SalvageDescription");
                salvageDescriptionProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salvageQtyPerProperty;
        public decimal SalvageQtyPer
        {
            get
            {
                if (salvageQtyPerProperty == null)
                    salvageQtyPerProperty = GetDecimalProperty("PartMtl.SalvageQtyPer");
                return salvageQtyPerProperty.Value;
            }
            set
            {
                if (salvageQtyPerProperty == null)
                    salvageQtyPerProperty = GetDecimalProperty("PartMtl.SalvageQtyPer");
                salvageQtyPerProperty.Value = value;
            }
        }

        protected RowProperty<string> salvageUMProperty;
        public string SalvageUM
        {
            get
            {
                if (salvageUMProperty == null)
                    salvageUMProperty = GetStringProperty("PartMtl.SalvageUM");
                return salvageUMProperty.Value;
            }
            set
            {
                if (salvageUMProperty == null)
                    salvageUMProperty = GetStringProperty("PartMtl.SalvageUM");
                salvageUMProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salvageUnitCreditProperty;
        public decimal SalvageUnitCredit
        {
            get
            {
                if (salvageUnitCreditProperty == null)
                    salvageUnitCreditProperty = GetDecimalProperty("PartMtl.SalvageUnitCredit");
                return salvageUnitCreditProperty.Value;
            }
            set
            {
                if (salvageUnitCreditProperty == null)
                    salvageUnitCreditProperty = GetDecimalProperty("PartMtl.SalvageUnitCredit");
                salvageUnitCreditProperty.Value = value;
            }
        }

        protected RowProperty<string> mfgCommentProperty;
        public string MfgComment
        {
            get
            {
                if (mfgCommentProperty == null)
                    mfgCommentProperty = GetStringProperty("PartMtl.MfgComment");
                return mfgCommentProperty.Value;
            }
            set
            {
                if (mfgCommentProperty == null)
                    mfgCommentProperty = GetStringProperty("PartMtl.MfgComment");
                mfgCommentProperty.Value = value;
            }
        }

        protected RowProperty<bool> overRidePurCommentsProperty;
        public bool OverRidePurComments
        {
            get
            {
                if (overRidePurCommentsProperty == null)
                    overRidePurCommentsProperty = GetBooleanProperty("PartMtl.OverRidePurComments");
                return overRidePurCommentsProperty.Value;
            }
            set
            {
                if (overRidePurCommentsProperty == null)
                    overRidePurCommentsProperty = GetBooleanProperty("PartMtl.OverRidePurComments");
                overRidePurCommentsProperty.Value = value;
            }
        }

        protected RowProperty<string> purCommentProperty;
        public string PurComment
        {
            get
            {
                if (purCommentProperty == null)
                    purCommentProperty = GetStringProperty("PartMtl.PurComment");
                return purCommentProperty.Value;
            }
            set
            {
                if (purCommentProperty == null)
                    purCommentProperty = GetStringProperty("PartMtl.PurComment");
                purCommentProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estScrapProperty;
        public decimal EstScrap
        {
            get
            {
                if (estScrapProperty == null)
                    estScrapProperty = GetDecimalProperty("PartMtl.EstScrap");
                return estScrapProperty.Value;
            }
            set
            {
                if (estScrapProperty == null)
                    estScrapProperty = GetDecimalProperty("PartMtl.EstScrap");
                estScrapProperty.Value = value;
            }
        }

        protected RowProperty<string> estScrapTypeProperty;
        public string EstScrapType
        {
            get
            {
                if (estScrapTypeProperty == null)
                    estScrapTypeProperty = GetStringProperty("PartMtl.EstScrapType");
                return estScrapTypeProperty.Value;
            }
            set
            {
                if (estScrapTypeProperty == null)
                    estScrapTypeProperty = GetStringProperty("PartMtl.EstScrapType");
                estScrapTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> pullAsAsmProperty;
        public bool PullAsAsm
        {
            get
            {
                if (pullAsAsmProperty == null)
                    pullAsAsmProperty = GetBooleanProperty("PartMtl.PullAsAsm");
                return pullAsAsmProperty.Value;
            }
            set
            {
                if (pullAsAsmProperty == null)
                    pullAsAsmProperty = GetBooleanProperty("PartMtl.PullAsAsm");
                pullAsAsmProperty.Value = value;
            }
        }

        protected RowProperty<bool> viewAsAsmProperty;
        public bool ViewAsAsm
        {
            get
            {
                if (viewAsAsmProperty == null)
                    viewAsAsmProperty = GetBooleanProperty("PartMtl.ViewAsAsm");
                return viewAsAsmProperty.Value;
            }
            set
            {
                if (viewAsAsmProperty == null)
                    viewAsAsmProperty = GetBooleanProperty("PartMtl.ViewAsAsm");
                viewAsAsmProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSSchedulerNameProperty;
        public string APSSchedulerName
        {
            get
            {
                if (aPSSchedulerNameProperty == null)
                    aPSSchedulerNameProperty = GetStringProperty("PartMtl.APSSchedulerName");
                return aPSSchedulerNameProperty.Value;
            }
            set
            {
                if (aPSSchedulerNameProperty == null)
                    aPSSchedulerNameProperty = GetStringProperty("PartMtl.APSSchedulerName");
                aPSSchedulerNameProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> aPSSLDateProperty;
        public DateTime? APSSLDate
        {
            get
            {
                if (aPSSLDateProperty == null)
                    aPSSLDateProperty = GetNullableDateTimeProperty("PartMtl.APSSLDate");
                return aPSSLDateProperty.Value;
            }
            set
            {
                if (aPSSLDateProperty == null)
                    aPSSLDateProperty = GetNullableDateTimeProperty("PartMtl.APSSLDate");
                aPSSLDateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSSLTimeProperty;
        public decimal APSSLTime
        {
            get
            {
                if (aPSSLTimeProperty == null)
                    aPSSLTimeProperty = GetDecimalProperty("PartMtl.APSSLTime");
                return aPSSLTimeProperty.Value;
            }
            set
            {
                if (aPSSLTimeProperty == null)
                    aPSSLTimeProperty = GetDecimalProperty("PartMtl.APSSLTime");
                aPSSLTimeProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSInsertDirectionProperty;
        public string APSInsertDirection
        {
            get
            {
                if (aPSInsertDirectionProperty == null)
                    aPSInsertDirectionProperty = GetStringProperty("PartMtl.APSInsertDirection");
                return aPSInsertDirectionProperty.Value;
            }
            set
            {
                if (aPSInsertDirectionProperty == null)
                    aPSInsertDirectionProperty = GetStringProperty("PartMtl.APSInsertDirection");
                aPSInsertDirectionProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSInsertCriteriaProperty;
        public string APSInsertCriteria
        {
            get
            {
                if (aPSInsertCriteriaProperty == null)
                    aPSInsertCriteriaProperty = GetStringProperty("PartMtl.APSInsertCriteria");
                return aPSInsertCriteriaProperty.Value;
            }
            set
            {
                if (aPSInsertCriteriaProperty == null)
                    aPSInsertCriteriaProperty = GetStringProperty("PartMtl.APSInsertCriteria");
                aPSInsertCriteriaProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSAttrib1Property;
        public decimal APSAttrib1
        {
            get
            {
                if (aPSAttrib1Property == null)
                    aPSAttrib1Property = GetDecimalProperty("PartMtl.APSAttrib1");
                return aPSAttrib1Property.Value;
            }
            set
            {
                if (aPSAttrib1Property == null)
                    aPSAttrib1Property = GetDecimalProperty("PartMtl.APSAttrib1");
                aPSAttrib1Property.Value = value;
            }
        }

        protected RowProperty<decimal> aPSAttrib2Property;
        public decimal APSAttrib2
        {
            get
            {
                if (aPSAttrib2Property == null)
                    aPSAttrib2Property = GetDecimalProperty("PartMtl.APSAttrib2");
                return aPSAttrib2Property.Value;
            }
            set
            {
                if (aPSAttrib2Property == null)
                    aPSAttrib2Property = GetDecimalProperty("PartMtl.APSAttrib2");
                aPSAttrib2Property.Value = value;
            }
        }

        protected RowProperty<decimal> aPSAttrib3Property;
        public decimal APSAttrib3
        {
            get
            {
                if (aPSAttrib3Property == null)
                    aPSAttrib3Property = GetDecimalProperty("PartMtl.APSAttrib3");
                return aPSAttrib3Property.Value;
            }
            set
            {
                if (aPSAttrib3Property == null)
                    aPSAttrib3Property = GetDecimalProperty("PartMtl.APSAttrib3");
                aPSAttrib3Property.Value = value;
            }
        }

        protected RowProperty<decimal> aPSAttrib4Property;
        public decimal APSAttrib4
        {
            get
            {
                if (aPSAttrib4Property == null)
                    aPSAttrib4Property = GetDecimalProperty("PartMtl.APSAttrib4");
                return aPSAttrib4Property.Value;
            }
            set
            {
                if (aPSAttrib4Property == null)
                    aPSAttrib4Property = GetDecimalProperty("PartMtl.APSAttrib4");
                aPSAttrib4Property.Value = value;
            }
        }

        protected RowProperty<string> aPSAddResTypeProperty;
        public string APSAddResType
        {
            get
            {
                if (aPSAddResTypeProperty == null)
                    aPSAddResTypeProperty = GetStringProperty("PartMtl.APSAddResType");
                return aPSAddResTypeProperty.Value;
            }
            set
            {
                if (aPSAddResTypeProperty == null)
                    aPSAddResTypeProperty = GetStringProperty("PartMtl.APSAddResType");
                aPSAddResTypeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salvageMtlBurRateProperty;
        public decimal SalvageMtlBurRate
        {
            get
            {
                if (salvageMtlBurRateProperty == null)
                    salvageMtlBurRateProperty = GetDecimalProperty("PartMtl.SalvageMtlBurRate");
                return salvageMtlBurRateProperty.Value;
            }
            set
            {
                if (salvageMtlBurRateProperty == null)
                    salvageMtlBurRateProperty = GetDecimalProperty("PartMtl.SalvageMtlBurRate");
                salvageMtlBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salvageEstMtlBurUnitCreditProperty;
        public decimal SalvageEstMtlBurUnitCredit
        {
            get
            {
                if (salvageEstMtlBurUnitCreditProperty == null)
                    salvageEstMtlBurUnitCreditProperty = GetDecimalProperty("PartMtl.SalvageEstMtlBurUnitCredit");
                return salvageEstMtlBurUnitCreditProperty.Value;
            }
            set
            {
                if (salvageEstMtlBurUnitCreditProperty == null)
                    salvageEstMtlBurUnitCreditProperty = GetDecimalProperty("PartMtl.SalvageEstMtlBurUnitCredit");
                salvageEstMtlBurUnitCreditProperty.Value = value;
            }
        }

        protected RowProperty<decimal> mtlBurRateProperty;
        public decimal MtlBurRate
        {
            get
            {
                if (mtlBurRateProperty == null)
                    mtlBurRateProperty = GetDecimalProperty("PartMtl.MtlBurRate");
                return mtlBurRateProperty.Value;
            }
            set
            {
                if (mtlBurRateProperty == null)
                    mtlBurRateProperty = GetDecimalProperty("PartMtl.MtlBurRate");
                mtlBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estMtlBurUnitCostProperty;
        public decimal EstMtlBurUnitCost
        {
            get
            {
                if (estMtlBurUnitCostProperty == null)
                    estMtlBurUnitCostProperty = GetDecimalProperty("PartMtl.EstMtlBurUnitCost");
                return estMtlBurUnitCostProperty.Value;
            }
            set
            {
                if (estMtlBurUnitCostProperty == null)
                    estMtlBurUnitCostProperty = GetDecimalProperty("PartMtl.EstMtlBurUnitCost");
                estMtlBurUnitCostProperty.Value = value;
            }
        }

        protected RowProperty<bool> rFQNeededProperty;
        public bool RFQNeeded
        {
            get
            {
                if (rFQNeededProperty == null)
                    rFQNeededProperty = GetBooleanProperty("PartMtl.RFQNeeded");
                return rFQNeededProperty.Value;
            }
            set
            {
                if (rFQNeededProperty == null)
                    rFQNeededProperty = GetBooleanProperty("PartMtl.RFQNeeded");
                rFQNeededProperty.Value = value;
            }
        }

        protected RowProperty<int> rFQVendQuotesProperty;
        public int RFQVendQuotes
        {
            get
            {
                if (rFQVendQuotesProperty == null)
                    rFQVendQuotesProperty = GetIntegerProperty("PartMtl.RFQVendQuotes");
                return rFQVendQuotesProperty.Value;
            }
            set
            {
                if (rFQVendQuotesProperty == null)
                    rFQVendQuotesProperty = GetIntegerProperty("PartMtl.RFQVendQuotes");
                rFQVendQuotesProperty.Value = value;
            }
        }

        protected RowProperty<string> analysisCodeProperty;
        public string AnalysisCode
        {
            get
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("PartMtl.AnalysisCode");
                return analysisCodeProperty.Value;
            }
            set
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("PartMtl.AnalysisCode");
                analysisCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> reqdInPlantProperty;
        public string ReqdInPlant
        {
            get
            {
                if (reqdInPlantProperty == null)
                    reqdInPlantProperty = GetStringProperty("PartMtl.ReqdInPlant");
                return reqdInPlantProperty.Value;
            }
            set
            {
                if (reqdInPlantProperty == null)
                    reqdInPlantProperty = GetStringProperty("PartMtl.ReqdInPlant");
                reqdInPlantProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodProperty;
        public string AltMethod
        {
            get
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartMtl.AltMethod");
                return altMethodProperty.Value;
            }
            set
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartMtl.AltMethod");
                altMethodProperty.Value = value;
            }
        }

        protected RowProperty<bool> baseMethodOverriddenProperty;
        public bool BaseMethodOverridden
        {
            get
            {
                if (baseMethodOverriddenProperty == null)
                    baseMethodOverriddenProperty = GetBooleanProperty("PartMtl.BaseMethodOverridden");
                return baseMethodOverriddenProperty.Value;
            }
            set
            {
                if (baseMethodOverriddenProperty == null)
                    baseMethodOverriddenProperty = GetBooleanProperty("PartMtl.BaseMethodOverridden");
                baseMethodOverriddenProperty.Value = value;
            }
        }

        protected RowProperty<string> relatedStageProperty;
        public string RelatedStage
        {
            get
            {
                if (relatedStageProperty == null)
                    relatedStageProperty = GetStringProperty("PartMtl.RelatedStage");
                return relatedStageProperty.Value;
            }
            set
            {
                if (relatedStageProperty == null)
                    relatedStageProperty = GetStringProperty("PartMtl.RelatedStage");
                relatedStageProperty.Value = value;
            }
        }

        protected RowProperty<string> parentAltMethodProperty;
        public string ParentAltMethod
        {
            get
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartMtl.ParentAltMethod");
                return parentAltMethodProperty.Value;
            }
            set
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartMtl.ParentAltMethod");
                parentAltMethodProperty.Value = value;
            }
        }

        protected RowProperty<int> parentMtlSeqProperty;
        public int ParentMtlSeq
        {
            get
            {
                if (parentMtlSeqProperty == null)
                    parentMtlSeqProperty = GetIntegerProperty("PartMtl.ParentMtlSeq");
                return parentMtlSeqProperty.Value;
            }
            set
            {
                if (parentMtlSeqProperty == null)
                    parentMtlSeqProperty = GetIntegerProperty("PartMtl.ParentMtlSeq");
                parentMtlSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMCodeProperty;
        public string UOMCode
        {
            get
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("PartMtl.UOMCode");
                return uOMCodeProperty.Value;
            }
            set
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("PartMtl.UOMCode");
                uOMCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartMtl.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartMtl.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartMtl.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartMtl.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> weightProperty;
        public decimal Weight
        {
            get
            {
                if (weightProperty == null)
                    weightProperty = GetDecimalProperty("PartMtl.Weight");
                return weightProperty.Value;
            }
            set
            {
                if (weightProperty == null)
                    weightProperty = GetDecimalProperty("PartMtl.Weight");
                weightProperty.Value = value;
            }
        }

        protected RowProperty<string> weightUOMProperty;
        public string WeightUOM
        {
            get
            {
                if (weightUOMProperty == null)
                    weightUOMProperty = GetStringProperty("PartMtl.WeightUOM");
                return weightUOMProperty.Value;
            }
            set
            {
                if (weightUOMProperty == null)
                    weightUOMProperty = GetStringProperty("PartMtl.WeightUOM");
                weightUOMProperty.Value = value;
            }
        }

        protected RowProperty<string> ruleTagProperty;
        public string RuleTag
        {
            get
            {
                if (ruleTagProperty == null)
                    ruleTagProperty = GetStringProperty("PartMtl.RuleTag");
                return ruleTagProperty.Value;
            }
            set
            {
                if (ruleTagProperty == null)
                    ruleTagProperty = GetStringProperty("PartMtl.RuleTag");
                ruleTagProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartMtl.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartMtl.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<int> reqRefDesProperty;
        public int ReqRefDes
        {
            get
            {
                if (reqRefDesProperty == null)
                    reqRefDesProperty = GetIntegerProperty("PartMtl.ReqRefDes");
                return reqRefDesProperty.Value;
            }
            set
            {
                if (reqRefDesProperty == null)
                    reqRefDesProperty = GetIntegerProperty("PartMtl.ReqRefDes");
                reqRefDesProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartMtl.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartMtl.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartOpDtl Table

    [Serializable()]
    public abstract partial class PartOpDtlBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartOpDtlBase<T, R>, new()
        where R : PartOpDtlRow, new()
    {
        protected PartOpDtlBase() : base() { }

        protected static Schema.PartOpDtl schemaTable;
        public static Schema.PartOpDtl SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartOpDtl)E9Schema.Instance.TablesDictionary["PartOpDtl"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByRevisionNumCriteria;
        public static T FillByRevisionNum(DataContext context, string companyNum, string partNum, string revisionNum, params string[] columnNames)
        {
            if (fillByRevisionNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.RevisionNum]));
                fillByRevisionNumCriteria = list.ToArray();
            }
            fillByRevisionNumCriteria[0].Value = companyNum;
            fillByRevisionNumCriteria[1].Value = partNum;
            fillByRevisionNumCriteria[2].Value = revisionNum;
            return EditTable<T, R>.Fetch(context, fillByRevisionNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByAltMethodCriteria;
        public static T FillByAltMethod(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, params string[] columnNames)
        {
            if (fillByAltMethodCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.AltMethod]));
                fillByAltMethodCriteria = list.ToArray();
            }
            fillByAltMethodCriteria[0].Value = companyNum;
            fillByAltMethodCriteria[1].Value = partNum;
            fillByAltMethodCriteria[2].Value = revisionNum;
            fillByAltMethodCriteria[3].Value = altMethod;
            return EditTable<T, R>.Fetch(context, fillByAltMethodCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByOprSeqCriteria;
        public static T FillByOprSeq(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, int oprSeq, params string[] columnNames)
        {
            if (fillByOprSeqCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.AltMethod]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.OprSeq]));
                fillByOprSeqCriteria = list.ToArray();
            }
            fillByOprSeqCriteria[0].Value = companyNum;
            fillByOprSeqCriteria[1].Value = partNum;
            fillByOprSeqCriteria[2].Value = revisionNum;
            fillByOprSeqCriteria[3].Value = altMethod;
            fillByOprSeqCriteria[4].Value = oprSeq;
            return EditTable<T, R>.Fetch(context, fillByOprSeqCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByOpDtlSeqCriteria;
        public static T FillByOpDtlSeq(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, int oprSeq, int opDtlSeq, params string[] columnNames)
        {
            if (fillByOpDtlSeqCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.AltMethod]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.OprSeq]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PartOpDtl.OpDtlSeq]));
                fillByOpDtlSeqCriteria = list.ToArray();
            }
            fillByOpDtlSeqCriteria[0].Value = companyNum;
            fillByOpDtlSeqCriteria[1].Value = partNum;
            fillByOpDtlSeqCriteria[2].Value = revisionNum;
            fillByOpDtlSeqCriteria[3].Value = altMethod;
            fillByOpDtlSeqCriteria[4].Value = oprSeq;
            fillByOpDtlSeqCriteria[5].Value = opDtlSeq;
            return EditTable<T, R>.Fetch(context, fillByOpDtlSeqCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartOpDtl : PartOpDtlBase<PartOpDtl, PartOpDtlRow>
    {
        public PartOpDtl() : base() { }
    }

    #region PartOpDtlRow

    [Serializable()]
    public class PartOpDtlRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartOpDtl.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartOpDtl.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartOpDtl.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartOpDtl.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumProperty;
        public string RevisionNum
        {
            get
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartOpDtl.RevisionNum");
                return revisionNumProperty.Value;
            }
            set
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartOpDtl.RevisionNum");
                revisionNumProperty.Value = value;
            }
        }

        protected RowProperty<int> oprSeqProperty;
        public int OprSeq
        {
            get
            {
                if (oprSeqProperty == null)
                    oprSeqProperty = GetIntegerProperty("PartOpDtl.OprSeq");
                return oprSeqProperty.Value;
            }
            set
            {
                if (oprSeqProperty == null)
                    oprSeqProperty = GetIntegerProperty("PartOpDtl.OprSeq");
                oprSeqProperty.Value = value;
            }
        }

        protected RowProperty<int> opDtlSeqProperty;
        public int OpDtlSeq
        {
            get
            {
                if (opDtlSeqProperty == null)
                    opDtlSeqProperty = GetIntegerProperty("PartOpDtl.OpDtlSeq");
                return opDtlSeqProperty.Value;
            }
            set
            {
                if (opDtlSeqProperty == null)
                    opDtlSeqProperty = GetIntegerProperty("PartOpDtl.OpDtlSeq");
                opDtlSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> capabilityIDProperty;
        public string CapabilityID
        {
            get
            {
                if (capabilityIDProperty == null)
                    capabilityIDProperty = GetStringProperty("PartOpDtl.CapabilityID");
                return capabilityIDProperty.Value;
            }
            set
            {
                if (capabilityIDProperty == null)
                    capabilityIDProperty = GetStringProperty("PartOpDtl.CapabilityID");
                capabilityIDProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceGrpIDProperty;
        public string ResourceGrpID
        {
            get
            {
                if (resourceGrpIDProperty == null)
                    resourceGrpIDProperty = GetStringProperty("PartOpDtl.ResourceGrpID");
                return resourceGrpIDProperty.Value;
            }
            set
            {
                if (resourceGrpIDProperty == null)
                    resourceGrpIDProperty = GetStringProperty("PartOpDtl.ResourceGrpID");
                resourceGrpIDProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceIDProperty;
        public string ResourceID
        {
            get
            {
                if (resourceIDProperty == null)
                    resourceIDProperty = GetStringProperty("PartOpDtl.ResourceID");
                return resourceIDProperty.Value;
            }
            set
            {
                if (resourceIDProperty == null)
                    resourceIDProperty = GetStringProperty("PartOpDtl.ResourceID");
                resourceIDProperty.Value = value;
            }
        }

        protected RowProperty<string> obsolete803SchedResourceIDProperty;
        public string Obsolete803_SchedResourceID
        {
            get
            {
                if (obsolete803SchedResourceIDProperty == null)
                    obsolete803SchedResourceIDProperty = GetStringProperty("PartOpDtl.Obsolete803_SchedResourceID");
                return obsolete803SchedResourceIDProperty.Value;
            }
            set
            {
                if (obsolete803SchedResourceIDProperty == null)
                    obsolete803SchedResourceIDProperty = GetStringProperty("PartOpDtl.Obsolete803_SchedResourceID");
                obsolete803SchedResourceIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setupHoursProperty;
        public decimal SetupHours
        {
            get
            {
                if (setupHoursProperty == null)
                    setupHoursProperty = GetDecimalProperty("PartOpDtl.SetupHours");
                return setupHoursProperty.Value;
            }
            set
            {
                if (setupHoursProperty == null)
                    setupHoursProperty = GetDecimalProperty("PartOpDtl.SetupHours");
                setupHoursProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodHoursProperty;
        public decimal ProdHours
        {
            get
            {
                if (prodHoursProperty == null)
                    prodHoursProperty = GetDecimalProperty("PartOpDtl.ProdHours");
                return prodHoursProperty.Value;
            }
            set
            {
                if (prodHoursProperty == null)
                    prodHoursProperty = GetDecimalProperty("PartOpDtl.ProdHours");
                prodHoursProperty.Value = value;
            }
        }

        protected RowProperty<int> numResourcesProperty;
        public int NumResources
        {
            get
            {
                if (numResourcesProperty == null)
                    numResourcesProperty = GetIntegerProperty("PartOpDtl.NumResources");
                return numResourcesProperty.Value;
            }
            set
            {
                if (numResourcesProperty == null)
                    numResourcesProperty = GetIntegerProperty("PartOpDtl.NumResources");
                numResourcesProperty.Value = value;
            }
        }

        protected RowProperty<string> setupOrProdProperty;
        public string SetupOrProd
        {
            get
            {
                if (setupOrProdProperty == null)
                    setupOrProdProperty = GetStringProperty("PartOpDtl.SetupOrProd");
                return setupOrProdProperty.Value;
            }
            set
            {
                if (setupOrProdProperty == null)
                    setupOrProdProperty = GetStringProperty("PartOpDtl.SetupOrProd");
                setupOrProdProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodProperty;
        public string AltMethod
        {
            get
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartOpDtl.AltMethod");
                return altMethodProperty.Value;
            }
            set
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartOpDtl.AltMethod");
                altMethodProperty.Value = value;
            }
        }

        protected RowProperty<bool> baseMethodOverriddenProperty;
        public bool BaseMethodOverridden
        {
            get
            {
                if (baseMethodOverriddenProperty == null)
                    baseMethodOverriddenProperty = GetBooleanProperty("PartOpDtl.BaseMethodOverridden");
                return baseMethodOverriddenProperty.Value;
            }
            set
            {
                if (baseMethodOverriddenProperty == null)
                    baseMethodOverriddenProperty = GetBooleanProperty("PartOpDtl.BaseMethodOverridden");
                baseMethodOverriddenProperty.Value = value;
            }
        }

        protected RowProperty<string> opDtlDescProperty;
        public string OpDtlDesc
        {
            get
            {
                if (opDtlDescProperty == null)
                    opDtlDescProperty = GetStringProperty("PartOpDtl.OpDtlDesc");
                return opDtlDescProperty.Value;
            }
            set
            {
                if (opDtlDescProperty == null)
                    opDtlDescProperty = GetStringProperty("PartOpDtl.OpDtlDesc");
                opDtlDescProperty.Value = value;
            }
        }

        protected RowProperty<string> parentAltMethodProperty;
        public string ParentAltMethod
        {
            get
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartOpDtl.ParentAltMethod");
                return parentAltMethodProperty.Value;
            }
            set
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartOpDtl.ParentAltMethod");
                parentAltMethodProperty.Value = value;
            }
        }

        protected RowProperty<int> parentOprSeqProperty;
        public int ParentOprSeq
        {
            get
            {
                if (parentOprSeqProperty == null)
                    parentOprSeqProperty = GetIntegerProperty("PartOpDtl.ParentOprSeq");
                return parentOprSeqProperty.Value;
            }
            set
            {
                if (parentOprSeqProperty == null)
                    parentOprSeqProperty = GetIntegerProperty("PartOpDtl.ParentOprSeq");
                parentOprSeqProperty.Value = value;
            }
        }

        protected RowProperty<int> parentOpDtlSeqProperty;
        public int ParentOpDtlSeq
        {
            get
            {
                if (parentOpDtlSeqProperty == null)
                    parentOpDtlSeqProperty = GetIntegerProperty("PartOpDtl.ParentOpDtlSeq");
                return parentOpDtlSeqProperty.Value;
            }
            set
            {
                if (parentOpDtlSeqProperty == null)
                    parentOpDtlSeqProperty = GetIntegerProperty("PartOpDtl.ParentOpDtlSeq");
                parentOpDtlSeqProperty.Value = value;
            }
        }

        protected RowProperty<decimal> concurrentCapacityProperty;
        public decimal ConcurrentCapacity
        {
            get
            {
                if (concurrentCapacityProperty == null)
                    concurrentCapacityProperty = GetDecimalProperty("PartOpDtl.ConcurrentCapacity");
                return concurrentCapacityProperty.Value;
            }
            set
            {
                if (concurrentCapacityProperty == null)
                    concurrentCapacityProperty = GetDecimalProperty("PartOpDtl.ConcurrentCapacity");
                concurrentCapacityProperty.Value = value;
            }
        }

        protected RowProperty<decimal> dailyProdRateProperty;
        public decimal DailyProdRate
        {
            get
            {
                if (dailyProdRateProperty == null)
                    dailyProdRateProperty = GetDecimalProperty("PartOpDtl.DailyProdRate");
                return dailyProdRateProperty.Value;
            }
            set
            {
                if (dailyProdRateProperty == null)
                    dailyProdRateProperty = GetDecimalProperty("PartOpDtl.DailyProdRate");
                dailyProdRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodCrewSizeProperty;
        public decimal ProdCrewSize
        {
            get
            {
                if (prodCrewSizeProperty == null)
                    prodCrewSizeProperty = GetDecimalProperty("PartOpDtl.ProdCrewSize");
                return prodCrewSizeProperty.Value;
            }
            set
            {
                if (prodCrewSizeProperty == null)
                    prodCrewSizeProperty = GetDecimalProperty("PartOpDtl.ProdCrewSize");
                prodCrewSizeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setUpCrewSizeProperty;
        public decimal SetUpCrewSize
        {
            get
            {
                if (setUpCrewSizeProperty == null)
                    setUpCrewSizeProperty = GetDecimalProperty("PartOpDtl.SetUpCrewSize");
                return setUpCrewSizeProperty.Value;
            }
            set
            {
                if (setUpCrewSizeProperty == null)
                    setUpCrewSizeProperty = GetDecimalProperty("PartOpDtl.SetUpCrewSize");
                setUpCrewSizeProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartOpDtl.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartOpDtl.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartOpDtl.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartOpDtl.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartOpDtl.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartOpDtl.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartOpDtl.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartOpDtl.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartOpr Table

    [Serializable()]
    public abstract partial class PartOprBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartOprBase<T, R>, new()
        where R : PartOprRow, new()
    {
        protected PartOprBase() : base() { }

        protected static Schema.PartOpr schemaTable;
        public static Schema.PartOpr SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartOpr)E9Schema.Instance.TablesDictionary["PartOpr"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByRevisionNumCriteria;
        public static T FillByRevisionNum(DataContext context, string companyNum, string partNum, string revisionNum, params string[] columnNames)
        {
            if (fillByRevisionNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.RevisionNum]));
                fillByRevisionNumCriteria = list.ToArray();
            }
            fillByRevisionNumCriteria[0].Value = companyNum;
            fillByRevisionNumCriteria[1].Value = partNum;
            fillByRevisionNumCriteria[2].Value = revisionNum;
            return EditTable<T, R>.Fetch(context, fillByRevisionNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByAltMethodCriteria;
        public static T FillByAltMethod(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, params string[] columnNames)
        {
            if (fillByAltMethodCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.AltMethod]));
                fillByAltMethodCriteria = list.ToArray();
            }
            fillByAltMethodCriteria[0].Value = companyNum;
            fillByAltMethodCriteria[1].Value = partNum;
            fillByAltMethodCriteria[2].Value = revisionNum;
            fillByAltMethodCriteria[3].Value = altMethod;
            return EditTable<T, R>.Fetch(context, fillByAltMethodCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByOprSeqCriteria;
        public static T FillByOprSeq(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, int oprSeq, params string[] columnNames)
        {
            if (fillByOprSeqCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartOpr.AltMethod]));
                list.Add(new CriteriaValue<int>(SchemaTable.ColumnsDictionary[Schema.PartOpr.OprSeq]));
                fillByOprSeqCriteria = list.ToArray();
            }
            fillByOprSeqCriteria[0].Value = companyNum;
            fillByOprSeqCriteria[1].Value = partNum;
            fillByOprSeqCriteria[2].Value = revisionNum;
            fillByOprSeqCriteria[3].Value = altMethod;
            fillByOprSeqCriteria[4].Value = oprSeq;
            return EditTable<T, R>.Fetch(context, fillByOprSeqCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartOpr : PartOprBase<PartOpr, PartOprRow>
    {
        public PartOpr() : base() { }
    }

    #region PartOprRow

    [Serializable()]
    public class PartOprRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartOpr.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartOpr.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartOpr.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartOpr.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumProperty;
        public string RevisionNum
        {
            get
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartOpr.RevisionNum");
                return revisionNumProperty.Value;
            }
            set
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartOpr.RevisionNum");
                revisionNumProperty.Value = value;
            }
        }

        protected RowProperty<int> oprSeqProperty;
        public int OprSeq
        {
            get
            {
                if (oprSeqProperty == null)
                    oprSeqProperty = GetIntegerProperty("PartOpr.OprSeq");
                return oprSeqProperty.Value;
            }
            set
            {
                if (oprSeqProperty == null)
                    oprSeqProperty = GetIntegerProperty("PartOpr.OprSeq");
                oprSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> opCodeProperty;
        public string OpCode
        {
            get
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("PartOpr.OpCode");
                return opCodeProperty.Value;
            }
            set
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("PartOpr.OpCode");
                opCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> opStdIDProperty;
        public string OpStdID
        {
            get
            {
                if (opStdIDProperty == null)
                    opStdIDProperty = GetStringProperty("PartOpr.OpStdID");
                return opStdIDProperty.Value;
            }
            set
            {
                if (opStdIDProperty == null)
                    opStdIDProperty = GetStringProperty("PartOpr.OpStdID");
                opStdIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estSetHoursProperty;
        public decimal EstSetHours
        {
            get
            {
                if (estSetHoursProperty == null)
                    estSetHoursProperty = GetDecimalProperty("PartOpr.EstSetHours");
                return estSetHoursProperty.Value;
            }
            set
            {
                if (estSetHoursProperty == null)
                    estSetHoursProperty = GetDecimalProperty("PartOpr.EstSetHours");
                estSetHoursProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estProdHoursProperty;
        public decimal EstProdHours
        {
            get
            {
                if (estProdHoursProperty == null)
                    estProdHoursProperty = GetDecimalProperty("PartOpr.EstProdHours");
                return estProdHoursProperty.Value;
            }
            set
            {
                if (estProdHoursProperty == null)
                    estProdHoursProperty = GetDecimalProperty("PartOpr.EstProdHours");
                estProdHoursProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodStandardProperty;
        public decimal ProdStandard
        {
            get
            {
                if (prodStandardProperty == null)
                    prodStandardProperty = GetDecimalProperty("PartOpr.ProdStandard");
                return prodStandardProperty.Value;
            }
            set
            {
                if (prodStandardProperty == null)
                    prodStandardProperty = GetDecimalProperty("PartOpr.ProdStandard");
                prodStandardProperty.Value = value;
            }
        }

        protected RowProperty<string> stdFormatProperty;
        public string StdFormat
        {
            get
            {
                if (stdFormatProperty == null)
                    stdFormatProperty = GetStringProperty("PartOpr.StdFormat");
                return stdFormatProperty.Value;
            }
            set
            {
                if (stdFormatProperty == null)
                    stdFormatProperty = GetStringProperty("PartOpr.StdFormat");
                stdFormatProperty.Value = value;
            }
        }

        protected RowProperty<string> stdBasisProperty;
        public string StdBasis
        {
            get
            {
                if (stdBasisProperty == null)
                    stdBasisProperty = GetStringProperty("PartOpr.StdBasis");
                return stdBasisProperty.Value;
            }
            set
            {
                if (stdBasisProperty == null)
                    stdBasisProperty = GetStringProperty("PartOpr.StdBasis");
                stdBasisProperty.Value = value;
            }
        }

        protected RowProperty<int> opsPerPartProperty;
        public int OpsPerPart
        {
            get
            {
                if (opsPerPartProperty == null)
                    opsPerPartProperty = GetIntegerProperty("PartOpr.OpsPerPart");
                return opsPerPartProperty.Value;
            }
            set
            {
                if (opsPerPartProperty == null)
                    opsPerPartProperty = GetIntegerProperty("PartOpr.OpsPerPart");
                opsPerPartProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qtyPerProperty;
        public decimal QtyPer
        {
            get
            {
                if (qtyPerProperty == null)
                    qtyPerProperty = GetDecimalProperty("PartOpr.QtyPer");
                return qtyPerProperty.Value;
            }
            set
            {
                if (qtyPerProperty == null)
                    qtyPerProperty = GetDecimalProperty("PartOpr.QtyPer");
                qtyPerProperty.Value = value;
            }
        }

        protected RowProperty<int> machinesProperty;
        public int Machines
        {
            get
            {
                if (machinesProperty == null)
                    machinesProperty = GetIntegerProperty("PartOpr.Machines");
                return machinesProperty.Value;
            }
            set
            {
                if (machinesProperty == null)
                    machinesProperty = GetIntegerProperty("PartOpr.Machines");
                machinesProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setUpCrewSizeProperty;
        public decimal SetUpCrewSize
        {
            get
            {
                if (setUpCrewSizeProperty == null)
                    setUpCrewSizeProperty = GetDecimalProperty("PartOpr.SetUpCrewSize");
                return setUpCrewSizeProperty.Value;
            }
            set
            {
                if (setUpCrewSizeProperty == null)
                    setUpCrewSizeProperty = GetDecimalProperty("PartOpr.SetUpCrewSize");
                setUpCrewSizeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodCrewSizeProperty;
        public decimal ProdCrewSize
        {
            get
            {
                if (prodCrewSizeProperty == null)
                    prodCrewSizeProperty = GetDecimalProperty("PartOpr.ProdCrewSize");
                return prodCrewSizeProperty.Value;
            }
            set
            {
                if (prodCrewSizeProperty == null)
                    prodCrewSizeProperty = GetDecimalProperty("PartOpr.ProdCrewSize");
                prodCrewSizeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estScrapProperty;
        public decimal EstScrap
        {
            get
            {
                if (estScrapProperty == null)
                    estScrapProperty = GetDecimalProperty("PartOpr.EstScrap");
                return estScrapProperty.Value;
            }
            set
            {
                if (estScrapProperty == null)
                    estScrapProperty = GetDecimalProperty("PartOpr.EstScrap");
                estScrapProperty.Value = value;
            }
        }

        protected RowProperty<string> estScrapTypeProperty;
        public string EstScrapType
        {
            get
            {
                if (estScrapTypeProperty == null)
                    estScrapTypeProperty = GetStringProperty("PartOpr.EstScrapType");
                return estScrapTypeProperty.Value;
            }
            set
            {
                if (estScrapTypeProperty == null)
                    estScrapTypeProperty = GetStringProperty("PartOpr.EstScrapType");
                estScrapTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> subContractProperty;
        public bool SubContract
        {
            get
            {
                if (subContractProperty == null)
                    subContractProperty = GetBooleanProperty("PartOpr.SubContract");
                return subContractProperty.Value;
            }
            set
            {
                if (subContractProperty == null)
                    subContractProperty = GetBooleanProperty("PartOpr.SubContract");
                subContractProperty.Value = value;
            }
        }

        protected RowProperty<string> iumProperty;
        public string IUM
        {
            get
            {
                if (iumProperty == null)
                    iumProperty = GetStringProperty("PartOpr.IUM");
                return iumProperty.Value;
            }
            set
            {
                if (iumProperty == null)
                    iumProperty = GetStringProperty("PartOpr.IUM");
                iumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> estUnitCostProperty;
        public decimal EstUnitCost
        {
            get
            {
                if (estUnitCostProperty == null)
                    estUnitCostProperty = GetDecimalProperty("PartOpr.EstUnitCost");
                return estUnitCostProperty.Value;
            }
            set
            {
                if (estUnitCostProperty == null)
                    estUnitCostProperty = GetDecimalProperty("PartOpr.EstUnitCost");
                estUnitCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> daysOutProperty;
        public decimal DaysOut
        {
            get
            {
                if (daysOutProperty == null)
                    daysOutProperty = GetDecimalProperty("PartOpr.DaysOut");
                return daysOutProperty.Value;
            }
            set
            {
                if (daysOutProperty == null)
                    daysOutProperty = GetDecimalProperty("PartOpr.DaysOut");
                daysOutProperty.Value = value;
            }
        }

        protected RowProperty<string> obsolete803BrkQtyProperty;
        public string Obsolete803_BrkQty
        {
            get
            {
                if (obsolete803BrkQtyProperty == null)
                    obsolete803BrkQtyProperty = GetStringProperty("PartOpr.Obsolete803_BrkQty");
                return obsolete803BrkQtyProperty.Value;
            }
            set
            {
                if (obsolete803BrkQtyProperty == null)
                    obsolete803BrkQtyProperty = GetStringProperty("PartOpr.Obsolete803_BrkQty");
                obsolete803BrkQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("PartOpr.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("PartOpr.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<string> purPointProperty;
        public string PurPoint
        {
            get
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("PartOpr.PurPoint");
                return purPointProperty.Value;
            }
            set
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("PartOpr.PurPoint");
                purPointProperty.Value = value;
            }
        }

        protected RowProperty<string> commentTextProperty;
        public string CommentText
        {
            get
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("PartOpr.CommentText");
                return commentTextProperty.Value;
            }
            set
            {
                if (commentTextProperty == null)
                    commentTextProperty = GetStringProperty("PartOpr.CommentText");
                commentTextProperty.Value = value;
            }
        }

        protected RowProperty<string> schedRelationProperty;
        public string SchedRelation
        {
            get
            {
                if (schedRelationProperty == null)
                    schedRelationProperty = GetStringProperty("PartOpr.SchedRelation");
                return schedRelationProperty.Value;
            }
            set
            {
                if (schedRelationProperty == null)
                    schedRelationProperty = GetStringProperty("PartOpr.SchedRelation");
                schedRelationProperty.Value = value;
            }
        }

        protected RowProperty<decimal> runQtyProperty;
        public decimal RunQty
        {
            get
            {
                if (runQtyProperty == null)
                    runQtyProperty = GetDecimalProperty("PartOpr.RunQty");
                return runQtyProperty.Value;
            }
            set
            {
                if (runQtyProperty == null)
                    runQtyProperty = GetDecimalProperty("PartOpr.RunQty");
                runQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> subPartNumProperty;
        public string SubPartNum
        {
            get
            {
                if (subPartNumProperty == null)
                    subPartNumProperty = GetStringProperty("PartOpr.SubPartNum");
                return subPartNumProperty.Value;
            }
            set
            {
                if (subPartNumProperty == null)
                    subPartNumProperty = GetStringProperty("PartOpr.SubPartNum");
                subPartNumProperty.Value = value;
            }
        }

        protected RowProperty<string> obsolete803PBrkCostProperty;
        public string Obsolete803_PBrkCost
        {
            get
            {
                if (obsolete803PBrkCostProperty == null)
                    obsolete803PBrkCostProperty = GetStringProperty("PartOpr.Obsolete803_PBrkCost");
                return obsolete803PBrkCostProperty.Value;
            }
            set
            {
                if (obsolete803PBrkCostProperty == null)
                    obsolete803PBrkCostProperty = GetStringProperty("PartOpr.Obsolete803_PBrkCost");
                obsolete803PBrkCostProperty.Value = value;
            }
        }

        protected RowProperty<string> obsolete803PBrkStdRateProperty;
        public string Obsolete803_PBrkStdRate
        {
            get
            {
                if (obsolete803PBrkStdRateProperty == null)
                    obsolete803PBrkStdRateProperty = GetStringProperty("PartOpr.Obsolete803_PBrkStdRate");
                return obsolete803PBrkStdRateProperty.Value;
            }
            set
            {
                if (obsolete803PBrkStdRateProperty == null)
                    obsolete803PBrkStdRateProperty = GetStringProperty("PartOpr.Obsolete803_PBrkStdRate");
                obsolete803PBrkStdRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> addlSetupHoursProperty;
        public decimal AddlSetupHours
        {
            get
            {
                if (addlSetupHoursProperty == null)
                    addlSetupHoursProperty = GetDecimalProperty("PartOpr.AddlSetupHours");
                return addlSetupHoursProperty.Value;
            }
            set
            {
                if (addlSetupHoursProperty == null)
                    addlSetupHoursProperty = GetDecimalProperty("PartOpr.AddlSetupHours");
                addlSetupHoursProperty.Value = value;
            }
        }

        protected RowProperty<decimal> addlSetUpQtyProperty;
        public decimal AddlSetUpQty
        {
            get
            {
                if (addlSetUpQtyProperty == null)
                    addlSetUpQtyProperty = GetDecimalProperty("PartOpr.AddlSetUpQty");
                return addlSetUpQtyProperty.Value;
            }
            set
            {
                if (addlSetUpQtyProperty == null)
                    addlSetUpQtyProperty = GetDecimalProperty("PartOpr.AddlSetUpQty");
                addlSetUpQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> aPSPrepOpProperty;
        public int APSPrepOp
        {
            get
            {
                if (aPSPrepOpProperty == null)
                    aPSPrepOpProperty = GetIntegerProperty("PartOpr.APSPrepOp");
                return aPSPrepOpProperty.Value;
            }
            set
            {
                if (aPSPrepOpProperty == null)
                    aPSPrepOpProperty = GetIntegerProperty("PartOpr.APSPrepOp");
                aPSPrepOpProperty.Value = value;
            }
        }

        protected RowProperty<int> aPSNextOpProperty;
        public int APSNextOp
        {
            get
            {
                if (aPSNextOpProperty == null)
                    aPSNextOpProperty = GetIntegerProperty("PartOpr.APSNextOp");
                return aPSNextOpProperty.Value;
            }
            set
            {
                if (aPSNextOpProperty == null)
                    aPSNextOpProperty = GetIntegerProperty("PartOpr.APSNextOp");
                aPSNextOpProperty.Value = value;
            }
        }

        protected RowProperty<int> aPSAltOpProperty;
        public int APSAltOp
        {
            get
            {
                if (aPSAltOpProperty == null)
                    aPSAltOpProperty = GetIntegerProperty("PartOpr.APSAltOp");
                return aPSAltOpProperty.Value;
            }
            set
            {
                if (aPSAltOpProperty == null)
                    aPSAltOpProperty = GetIntegerProperty("PartOpr.APSAltOp");
                aPSAltOpProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSSpecificResourceProperty;
        public string APSSpecificResource
        {
            get
            {
                if (aPSSpecificResourceProperty == null)
                    aPSSpecificResourceProperty = GetStringProperty("PartOpr.APSSpecificResource");
                return aPSSpecificResourceProperty.Value;
            }
            set
            {
                if (aPSSpecificResourceProperty == null)
                    aPSSpecificResourceProperty = GetStringProperty("PartOpr.APSSpecificResource");
                aPSSpecificResourceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSCycleTimeProperty;
        public decimal APSCycleTime
        {
            get
            {
                if (aPSCycleTimeProperty == null)
                    aPSCycleTimeProperty = GetDecimalProperty("PartOpr.APSCycleTime");
                return aPSCycleTimeProperty.Value;
            }
            set
            {
                if (aPSCycleTimeProperty == null)
                    aPSCycleTimeProperty = GetDecimalProperty("PartOpr.APSCycleTime");
                aPSCycleTimeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSConstantTimeProperty;
        public decimal APSConstantTime
        {
            get
            {
                if (aPSConstantTimeProperty == null)
                    aPSConstantTimeProperty = GetDecimalProperty("PartOpr.APSConstantTime");
                return aPSConstantTimeProperty.Value;
            }
            set
            {
                if (aPSConstantTimeProperty == null)
                    aPSConstantTimeProperty = GetDecimalProperty("PartOpr.APSConstantTime");
                aPSConstantTimeProperty.Value = value;
            }
        }

        protected RowProperty<int> aPSSetupGroupProperty;
        public int APSSetupGroup
        {
            get
            {
                if (aPSSetupGroupProperty == null)
                    aPSSetupGroupProperty = GetIntegerProperty("PartOpr.APSSetupGroup");
                return aPSSetupGroupProperty.Value;
            }
            set
            {
                if (aPSSetupGroupProperty == null)
                    aPSSetupGroupProperty = GetIntegerProperty("PartOpr.APSSetupGroup");
                aPSSetupGroupProperty.Value = value;
            }
        }

        protected RowProperty<int> aPSMakeFactorProperty;
        public int APSMakeFactor
        {
            get
            {
                if (aPSMakeFactorProperty == null)
                    aPSMakeFactorProperty = GetIntegerProperty("PartOpr.APSMakeFactor");
                return aPSMakeFactorProperty.Value;
            }
            set
            {
                if (aPSMakeFactorProperty == null)
                    aPSMakeFactorProperty = GetIntegerProperty("PartOpr.APSMakeFactor");
                aPSMakeFactorProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSContainerSizeProperty;
        public decimal APSContainerSize
        {
            get
            {
                if (aPSContainerSizeProperty == null)
                    aPSContainerSizeProperty = GetDecimalProperty("PartOpr.APSContainerSize");
                return aPSContainerSizeProperty.Value;
            }
            set
            {
                if (aPSContainerSizeProperty == null)
                    aPSContainerSizeProperty = GetDecimalProperty("PartOpr.APSContainerSize");
                aPSContainerSizeProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSSchedulerNameProperty;
        public string APSSchedulerName
        {
            get
            {
                if (aPSSchedulerNameProperty == null)
                    aPSSchedulerNameProperty = GetStringProperty("PartOpr.APSSchedulerName");
                return aPSSchedulerNameProperty.Value;
            }
            set
            {
                if (aPSSchedulerNameProperty == null)
                    aPSSchedulerNameProperty = GetStringProperty("PartOpr.APSSchedulerName");
                aPSSchedulerNameProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSMaxLengthProperty;
        public decimal APSMaxLength
        {
            get
            {
                if (aPSMaxLengthProperty == null)
                    aPSMaxLengthProperty = GetDecimalProperty("PartOpr.APSMaxLength");
                return aPSMaxLengthProperty.Value;
            }
            set
            {
                if (aPSMaxLengthProperty == null)
                    aPSMaxLengthProperty = GetDecimalProperty("PartOpr.APSMaxLength");
                aPSMaxLengthProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSTransferTimeProperty;
        public decimal APSTransferTime
        {
            get
            {
                if (aPSTransferTimeProperty == null)
                    aPSTransferTimeProperty = GetDecimalProperty("PartOpr.APSTransferTime");
                return aPSTransferTimeProperty.Value;
            }
            set
            {
                if (aPSTransferTimeProperty == null)
                    aPSTransferTimeProperty = GetDecimalProperty("PartOpr.APSTransferTime");
                aPSTransferTimeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> aPSEffectivenessProperty;
        public decimal APSEffectiveness
        {
            get
            {
                if (aPSEffectivenessProperty == null)
                    aPSEffectivenessProperty = GetDecimalProperty("PartOpr.APSEffectiveness");
                return aPSEffectivenessProperty.Value;
            }
            set
            {
                if (aPSEffectivenessProperty == null)
                    aPSEffectivenessProperty = GetDecimalProperty("PartOpr.APSEffectiveness");
                aPSEffectivenessProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSOperationClassProperty;
        public string APSOperationClass
        {
            get
            {
                if (aPSOperationClassProperty == null)
                    aPSOperationClassProperty = GetStringProperty("PartOpr.APSOperationClass");
                return aPSOperationClassProperty.Value;
            }
            set
            {
                if (aPSOperationClassProperty == null)
                    aPSOperationClassProperty = GetStringProperty("PartOpr.APSOperationClass");
                aPSOperationClassProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSAuxResourceProperty;
        public string APSAuxResource
        {
            get
            {
                if (aPSAuxResourceProperty == null)
                    aPSAuxResourceProperty = GetStringProperty("PartOpr.APSAuxResource");
                return aPSAuxResourceProperty.Value;
            }
            set
            {
                if (aPSAuxResourceProperty == null)
                    aPSAuxResourceProperty = GetStringProperty("PartOpr.APSAuxResource");
                aPSAuxResourceProperty.Value = value;
            }
        }

        protected RowProperty<string> aPSAddResourceProperty;
        public string APSAddResource
        {
            get
            {
                if (aPSAddResourceProperty == null)
                    aPSAddResourceProperty = GetStringProperty("PartOpr.APSAddResource");
                return aPSAddResourceProperty.Value;
            }
            set
            {
                if (aPSAddResourceProperty == null)
                    aPSAddResourceProperty = GetStringProperty("PartOpr.APSAddResource");
                aPSAddResourceProperty.Value = value;
            }
        }

        protected RowProperty<string> laborEntryMethodProperty;
        public string LaborEntryMethod
        {
            get
            {
                if (laborEntryMethodProperty == null)
                    laborEntryMethodProperty = GetStringProperty("PartOpr.LaborEntryMethod");
                return laborEntryMethodProperty.Value;
            }
            set
            {
                if (laborEntryMethodProperty == null)
                    laborEntryMethodProperty = GetStringProperty("PartOpr.LaborEntryMethod");
                laborEntryMethodProperty.Value = value;
            }
        }

        protected RowProperty<decimal> fAQtyProperty;
        public decimal FAQty
        {
            get
            {
                if (fAQtyProperty == null)
                    fAQtyProperty = GetDecimalProperty("PartOpr.FAQty");
                return fAQtyProperty.Value;
            }
            set
            {
                if (fAQtyProperty == null)
                    fAQtyProperty = GetDecimalProperty("PartOpr.FAQty");
                fAQtyProperty.Value = value;
            }
        }

        protected RowProperty<bool> rFQNeededProperty;
        public bool RFQNeeded
        {
            get
            {
                if (rFQNeededProperty == null)
                    rFQNeededProperty = GetBooleanProperty("PartOpr.RFQNeeded");
                return rFQNeededProperty.Value;
            }
            set
            {
                if (rFQNeededProperty == null)
                    rFQNeededProperty = GetBooleanProperty("PartOpr.RFQNeeded");
                rFQNeededProperty.Value = value;
            }
        }

        protected RowProperty<int> rFQVendQuotesProperty;
        public int RFQVendQuotes
        {
            get
            {
                if (rFQVendQuotesProperty == null)
                    rFQVendQuotesProperty = GetIntegerProperty("PartOpr.RFQVendQuotes");
                return rFQVendQuotesProperty.Value;
            }
            set
            {
                if (rFQVendQuotesProperty == null)
                    rFQVendQuotesProperty = GetIntegerProperty("PartOpr.RFQVendQuotes");
                rFQVendQuotesProperty.Value = value;
            }
        }

        protected RowProperty<string> setupGroupProperty;
        public string SetupGroup
        {
            get
            {
                if (setupGroupProperty == null)
                    setupGroupProperty = GetStringProperty("PartOpr.SetupGroup");
                return setupGroupProperty.Value;
            }
            set
            {
                if (setupGroupProperty == null)
                    setupGroupProperty = GetStringProperty("PartOpr.SetupGroup");
                setupGroupProperty.Value = value;
            }
        }

        protected RowProperty<string> analysisCodeProperty;
        public string AnalysisCode
        {
            get
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("PartOpr.AnalysisCode");
                return analysisCodeProperty.Value;
            }
            set
            {
                if (analysisCodeProperty == null)
                    analysisCodeProperty = GetStringProperty("PartOpr.AnalysisCode");
                analysisCodeProperty.Value = value;
            }
        }

        protected RowProperty<int> primarySetupOpDtlProperty;
        public int PrimarySetupOpDtl
        {
            get
            {
                if (primarySetupOpDtlProperty == null)
                    primarySetupOpDtlProperty = GetIntegerProperty("PartOpr.PrimarySetupOpDtl");
                return primarySetupOpDtlProperty.Value;
            }
            set
            {
                if (primarySetupOpDtlProperty == null)
                    primarySetupOpDtlProperty = GetIntegerProperty("PartOpr.PrimarySetupOpDtl");
                primarySetupOpDtlProperty.Value = value;
            }
        }

        protected RowProperty<int> primaryProdOpDtlProperty;
        public int PrimaryProdOpDtl
        {
            get
            {
                if (primaryProdOpDtlProperty == null)
                    primaryProdOpDtlProperty = GetIntegerProperty("PartOpr.PrimaryProdOpDtl");
                return primaryProdOpDtlProperty.Value;
            }
            set
            {
                if (primaryProdOpDtlProperty == null)
                    primaryProdOpDtlProperty = GetIntegerProperty("PartOpr.PrimaryProdOpDtl");
                primaryProdOpDtlProperty.Value = value;
            }
        }

        protected RowProperty<int> rtgGroupProperty;
        public int RtgGroup
        {
            get
            {
                if (rtgGroupProperty == null)
                    rtgGroupProperty = GetIntegerProperty("PartOpr.RtgGroup");
                return rtgGroupProperty.Value;
            }
            set
            {
                if (rtgGroupProperty == null)
                    rtgGroupProperty = GetIntegerProperty("PartOpr.RtgGroup");
                rtgGroupProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodProperty;
        public string AltMethod
        {
            get
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartOpr.AltMethod");
                return altMethodProperty.Value;
            }
            set
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartOpr.AltMethod");
                altMethodProperty.Value = value;
            }
        }

        protected RowProperty<bool> baseMethodOverriddenProperty;
        public bool BaseMethodOverridden
        {
            get
            {
                if (baseMethodOverriddenProperty == null)
                    baseMethodOverriddenProperty = GetBooleanProperty("PartOpr.BaseMethodOverridden");
                return baseMethodOverriddenProperty.Value;
            }
            set
            {
                if (baseMethodOverriddenProperty == null)
                    baseMethodOverriddenProperty = GetBooleanProperty("PartOpr.BaseMethodOverridden");
                baseMethodOverriddenProperty.Value = value;
            }
        }

        protected RowProperty<string> stageNumberProperty;
        public string StageNumber
        {
            get
            {
                if (stageNumberProperty == null)
                    stageNumberProperty = GetStringProperty("PartOpr.StageNumber");
                return stageNumberProperty.Value;
            }
            set
            {
                if (stageNumberProperty == null)
                    stageNumberProperty = GetStringProperty("PartOpr.StageNumber");
                stageNumberProperty.Value = value;
            }
        }

        protected RowProperty<string> opDescProperty;
        public string OpDesc
        {
            get
            {
                if (opDescProperty == null)
                    opDescProperty = GetStringProperty("PartOpr.OpDesc");
                return opDescProperty.Value;
            }
            set
            {
                if (opDescProperty == null)
                    opDescProperty = GetStringProperty("PartOpr.OpDesc");
                opDescProperty.Value = value;
            }
        }

        protected RowProperty<string> parentAltMethodProperty;
        public string ParentAltMethod
        {
            get
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartOpr.ParentAltMethod");
                return parentAltMethodProperty.Value;
            }
            set
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartOpr.ParentAltMethod");
                parentAltMethodProperty.Value = value;
            }
        }

        protected RowProperty<int> parentOprSeqProperty;
        public int ParentOprSeq
        {
            get
            {
                if (parentOprSeqProperty == null)
                    parentOprSeqProperty = GetIntegerProperty("PartOpr.ParentOprSeq");
                return parentOprSeqProperty.Value;
            }
            set
            {
                if (parentOprSeqProperty == null)
                    parentOprSeqProperty = GetIntegerProperty("PartOpr.ParentOprSeq");
                parentOprSeqProperty.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost07Property;
        public decimal PBrkCost07
        {
            get
            {
                if (pBrkCost07Property == null)
                    pBrkCost07Property = GetDecimalProperty("PartOpr.PBrkCost07");
                return pBrkCost07Property.Value;
            }
            set
            {
                if (pBrkCost07Property == null)
                    pBrkCost07Property = GetDecimalProperty("PartOpr.PBrkCost07");
                pBrkCost07Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost08Property;
        public decimal PBrkCost08
        {
            get
            {
                if (pBrkCost08Property == null)
                    pBrkCost08Property = GetDecimalProperty("PartOpr.PBrkCost08");
                return pBrkCost08Property.Value;
            }
            set
            {
                if (pBrkCost08Property == null)
                    pBrkCost08Property = GetDecimalProperty("PartOpr.PBrkCost08");
                pBrkCost08Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost09Property;
        public decimal PBrkCost09
        {
            get
            {
                if (pBrkCost09Property == null)
                    pBrkCost09Property = GetDecimalProperty("PartOpr.PBrkCost09");
                return pBrkCost09Property.Value;
            }
            set
            {
                if (pBrkCost09Property == null)
                    pBrkCost09Property = GetDecimalProperty("PartOpr.PBrkCost09");
                pBrkCost09Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost10Property;
        public decimal PBrkCost10
        {
            get
            {
                if (pBrkCost10Property == null)
                    pBrkCost10Property = GetDecimalProperty("PartOpr.PBrkCost10");
                return pBrkCost10Property.Value;
            }
            set
            {
                if (pBrkCost10Property == null)
                    pBrkCost10Property = GetDecimalProperty("PartOpr.PBrkCost10");
                pBrkCost10Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate01Property;
        public decimal PBrkStdRate01
        {
            get
            {
                if (pBrkStdRate01Property == null)
                    pBrkStdRate01Property = GetDecimalProperty("PartOpr.PBrkStdRate01");
                return pBrkStdRate01Property.Value;
            }
            set
            {
                if (pBrkStdRate01Property == null)
                    pBrkStdRate01Property = GetDecimalProperty("PartOpr.PBrkStdRate01");
                pBrkStdRate01Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate02Property;
        public decimal PBrkStdRate02
        {
            get
            {
                if (pBrkStdRate02Property == null)
                    pBrkStdRate02Property = GetDecimalProperty("PartOpr.PBrkStdRate02");
                return pBrkStdRate02Property.Value;
            }
            set
            {
                if (pBrkStdRate02Property == null)
                    pBrkStdRate02Property = GetDecimalProperty("PartOpr.PBrkStdRate02");
                pBrkStdRate02Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate03Property;
        public decimal PBrkStdRate03
        {
            get
            {
                if (pBrkStdRate03Property == null)
                    pBrkStdRate03Property = GetDecimalProperty("PartOpr.PBrkStdRate03");
                return pBrkStdRate03Property.Value;
            }
            set
            {
                if (pBrkStdRate03Property == null)
                    pBrkStdRate03Property = GetDecimalProperty("PartOpr.PBrkStdRate03");
                pBrkStdRate03Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate04Property;
        public decimal PBrkStdRate04
        {
            get
            {
                if (pBrkStdRate04Property == null)
                    pBrkStdRate04Property = GetDecimalProperty("PartOpr.PBrkStdRate04");
                return pBrkStdRate04Property.Value;
            }
            set
            {
                if (pBrkStdRate04Property == null)
                    pBrkStdRate04Property = GetDecimalProperty("PartOpr.PBrkStdRate04");
                pBrkStdRate04Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate05Property;
        public decimal PBrkStdRate05
        {
            get
            {
                if (pBrkStdRate05Property == null)
                    pBrkStdRate05Property = GetDecimalProperty("PartOpr.PBrkStdRate05");
                return pBrkStdRate05Property.Value;
            }
            set
            {
                if (pBrkStdRate05Property == null)
                    pBrkStdRate05Property = GetDecimalProperty("PartOpr.PBrkStdRate05");
                pBrkStdRate05Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate06Property;
        public decimal PBrkStdRate06
        {
            get
            {
                if (pBrkStdRate06Property == null)
                    pBrkStdRate06Property = GetDecimalProperty("PartOpr.PBrkStdRate06");
                return pBrkStdRate06Property.Value;
            }
            set
            {
                if (pBrkStdRate06Property == null)
                    pBrkStdRate06Property = GetDecimalProperty("PartOpr.PBrkStdRate06");
                pBrkStdRate06Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate07Property;
        public decimal PBrkStdRate07
        {
            get
            {
                if (pBrkStdRate07Property == null)
                    pBrkStdRate07Property = GetDecimalProperty("PartOpr.PBrkStdRate07");
                return pBrkStdRate07Property.Value;
            }
            set
            {
                if (pBrkStdRate07Property == null)
                    pBrkStdRate07Property = GetDecimalProperty("PartOpr.PBrkStdRate07");
                pBrkStdRate07Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate08Property;
        public decimal PBrkStdRate08
        {
            get
            {
                if (pBrkStdRate08Property == null)
                    pBrkStdRate08Property = GetDecimalProperty("PartOpr.PBrkStdRate08");
                return pBrkStdRate08Property.Value;
            }
            set
            {
                if (pBrkStdRate08Property == null)
                    pBrkStdRate08Property = GetDecimalProperty("PartOpr.PBrkStdRate08");
                pBrkStdRate08Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate09Property;
        public decimal PBrkStdRate09
        {
            get
            {
                if (pBrkStdRate09Property == null)
                    pBrkStdRate09Property = GetDecimalProperty("PartOpr.PBrkStdRate09");
                return pBrkStdRate09Property.Value;
            }
            set
            {
                if (pBrkStdRate09Property == null)
                    pBrkStdRate09Property = GetDecimalProperty("PartOpr.PBrkStdRate09");
                pBrkStdRate09Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkStdRate10Property;
        public decimal PBrkStdRate10
        {
            get
            {
                if (pBrkStdRate10Property == null)
                    pBrkStdRate10Property = GetDecimalProperty("PartOpr.PBrkStdRate10");
                return pBrkStdRate10Property.Value;
            }
            set
            {
                if (pBrkStdRate10Property == null)
                    pBrkStdRate10Property = GetDecimalProperty("PartOpr.PBrkStdRate10");
                pBrkStdRate10Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty01Property;
        public decimal BrkQty01
        {
            get
            {
                if (brkQty01Property == null)
                    brkQty01Property = GetDecimalProperty("PartOpr.BrkQty01");
                return brkQty01Property.Value;
            }
            set
            {
                if (brkQty01Property == null)
                    brkQty01Property = GetDecimalProperty("PartOpr.BrkQty01");
                brkQty01Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty02Property;
        public decimal BrkQty02
        {
            get
            {
                if (brkQty02Property == null)
                    brkQty02Property = GetDecimalProperty("PartOpr.BrkQty02");
                return brkQty02Property.Value;
            }
            set
            {
                if (brkQty02Property == null)
                    brkQty02Property = GetDecimalProperty("PartOpr.BrkQty02");
                brkQty02Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty03Property;
        public decimal BrkQty03
        {
            get
            {
                if (brkQty03Property == null)
                    brkQty03Property = GetDecimalProperty("PartOpr.BrkQty03");
                return brkQty03Property.Value;
            }
            set
            {
                if (brkQty03Property == null)
                    brkQty03Property = GetDecimalProperty("PartOpr.BrkQty03");
                brkQty03Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty04Property;
        public decimal BrkQty04
        {
            get
            {
                if (brkQty04Property == null)
                    brkQty04Property = GetDecimalProperty("PartOpr.BrkQty04");
                return brkQty04Property.Value;
            }
            set
            {
                if (brkQty04Property == null)
                    brkQty04Property = GetDecimalProperty("PartOpr.BrkQty04");
                brkQty04Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty05Property;
        public decimal BrkQty05
        {
            get
            {
                if (brkQty05Property == null)
                    brkQty05Property = GetDecimalProperty("PartOpr.BrkQty05");
                return brkQty05Property.Value;
            }
            set
            {
                if (brkQty05Property == null)
                    brkQty05Property = GetDecimalProperty("PartOpr.BrkQty05");
                brkQty05Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty06Property;
        public decimal BrkQty06
        {
            get
            {
                if (brkQty06Property == null)
                    brkQty06Property = GetDecimalProperty("PartOpr.BrkQty06");
                return brkQty06Property.Value;
            }
            set
            {
                if (brkQty06Property == null)
                    brkQty06Property = GetDecimalProperty("PartOpr.BrkQty06");
                brkQty06Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty07Property;
        public decimal BrkQty07
        {
            get
            {
                if (brkQty07Property == null)
                    brkQty07Property = GetDecimalProperty("PartOpr.BrkQty07");
                return brkQty07Property.Value;
            }
            set
            {
                if (brkQty07Property == null)
                    brkQty07Property = GetDecimalProperty("PartOpr.BrkQty07");
                brkQty07Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty08Property;
        public decimal BrkQty08
        {
            get
            {
                if (brkQty08Property == null)
                    brkQty08Property = GetDecimalProperty("PartOpr.BrkQty08");
                return brkQty08Property.Value;
            }
            set
            {
                if (brkQty08Property == null)
                    brkQty08Property = GetDecimalProperty("PartOpr.BrkQty08");
                brkQty08Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty09Property;
        public decimal BrkQty09
        {
            get
            {
                if (brkQty09Property == null)
                    brkQty09Property = GetDecimalProperty("PartOpr.BrkQty09");
                return brkQty09Property.Value;
            }
            set
            {
                if (brkQty09Property == null)
                    brkQty09Property = GetDecimalProperty("PartOpr.BrkQty09");
                brkQty09Property.Value = value;
            }
        }

        protected RowProperty<decimal> brkQty10Property;
        public decimal BrkQty10
        {
            get
            {
                if (brkQty10Property == null)
                    brkQty10Property = GetDecimalProperty("PartOpr.BrkQty10");
                return brkQty10Property.Value;
            }
            set
            {
                if (brkQty10Property == null)
                    brkQty10Property = GetDecimalProperty("PartOpr.BrkQty10");
                brkQty10Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost01Property;
        public decimal PBrkCost01
        {
            get
            {
                if (pBrkCost01Property == null)
                    pBrkCost01Property = GetDecimalProperty("PartOpr.PBrkCost01");
                return pBrkCost01Property.Value;
            }
            set
            {
                if (pBrkCost01Property == null)
                    pBrkCost01Property = GetDecimalProperty("PartOpr.PBrkCost01");
                pBrkCost01Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost02Property;
        public decimal PBrkCost02
        {
            get
            {
                if (pBrkCost02Property == null)
                    pBrkCost02Property = GetDecimalProperty("PartOpr.PBrkCost02");
                return pBrkCost02Property.Value;
            }
            set
            {
                if (pBrkCost02Property == null)
                    pBrkCost02Property = GetDecimalProperty("PartOpr.PBrkCost02");
                pBrkCost02Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost03Property;
        public decimal PBrkCost03
        {
            get
            {
                if (pBrkCost03Property == null)
                    pBrkCost03Property = GetDecimalProperty("PartOpr.PBrkCost03");
                return pBrkCost03Property.Value;
            }
            set
            {
                if (pBrkCost03Property == null)
                    pBrkCost03Property = GetDecimalProperty("PartOpr.PBrkCost03");
                pBrkCost03Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost04Property;
        public decimal PBrkCost04
        {
            get
            {
                if (pBrkCost04Property == null)
                    pBrkCost04Property = GetDecimalProperty("PartOpr.PBrkCost04");
                return pBrkCost04Property.Value;
            }
            set
            {
                if (pBrkCost04Property == null)
                    pBrkCost04Property = GetDecimalProperty("PartOpr.PBrkCost04");
                pBrkCost04Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost05Property;
        public decimal PBrkCost05
        {
            get
            {
                if (pBrkCost05Property == null)
                    pBrkCost05Property = GetDecimalProperty("PartOpr.PBrkCost05");
                return pBrkCost05Property.Value;
            }
            set
            {
                if (pBrkCost05Property == null)
                    pBrkCost05Property = GetDecimalProperty("PartOpr.PBrkCost05");
                pBrkCost05Property.Value = value;
            }
        }

        protected RowProperty<decimal> pBrkCost06Property;
        public decimal PBrkCost06
        {
            get
            {
                if (pBrkCost06Property == null)
                    pBrkCost06Property = GetDecimalProperty("PartOpr.PBrkCost06");
                return pBrkCost06Property.Value;
            }
            set
            {
                if (pBrkCost06Property == null)
                    pBrkCost06Property = GetDecimalProperty("PartOpr.PBrkCost06");
                pBrkCost06Property.Value = value;
            }
        }

        protected RowProperty<bool> sNRequiredOprProperty;
        public bool SNRequiredOpr
        {
            get
            {
                if (sNRequiredOprProperty == null)
                    sNRequiredOprProperty = GetBooleanProperty("PartOpr.SNRequiredOpr");
                return sNRequiredOprProperty.Value;
            }
            set
            {
                if (sNRequiredOprProperty == null)
                    sNRequiredOprProperty = GetBooleanProperty("PartOpr.SNRequiredOpr");
                sNRequiredOprProperty.Value = value;
            }
        }

        protected RowProperty<bool> sNRequiredSubConShipProperty;
        public bool SNRequiredSubConShip
        {
            get
            {
                if (sNRequiredSubConShipProperty == null)
                    sNRequiredSubConShipProperty = GetBooleanProperty("PartOpr.SNRequiredSubConShip");
                return sNRequiredSubConShipProperty.Value;
            }
            set
            {
                if (sNRequiredSubConShipProperty == null)
                    sNRequiredSubConShipProperty = GetBooleanProperty("PartOpr.SNRequiredSubConShip");
                sNRequiredSubConShipProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartOpr.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartOpr.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartOpr.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartOpr.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> weightProperty;
        public decimal Weight
        {
            get
            {
                if (weightProperty == null)
                    weightProperty = GetDecimalProperty("PartOpr.Weight");
                return weightProperty.Value;
            }
            set
            {
                if (weightProperty == null)
                    weightProperty = GetDecimalProperty("PartOpr.Weight");
                weightProperty.Value = value;
            }
        }

        protected RowProperty<string> weightUOMProperty;
        public string WeightUOM
        {
            get
            {
                if (weightUOMProperty == null)
                    weightUOMProperty = GetStringProperty("PartOpr.WeightUOM");
                return weightUOMProperty.Value;
            }
            set
            {
                if (weightUOMProperty == null)
                    weightUOMProperty = GetStringProperty("PartOpr.WeightUOM");
                weightUOMProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartOpr.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartOpr.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartOpr.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartOpr.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartPlant Table

    [Serializable()]
    public abstract partial class PartPlantBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartPlantBase<T, R>, new()
        where R : PartPlantRow, new()
    {
        protected PartPlantBase() : base() { }

        protected static Schema.PartPlant schemaTable;
        public static Schema.PartPlant SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartPlant)E9Schema.Instance.TablesDictionary["PartPlant"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartPlant.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartPlant.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartPlant.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPlantNumCriteria;
        public static T FillByPlantNum(DataContext context, string companyNum, string partNum, string plantNum, params string[] columnNames)
        {
            if (fillByPlantNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartPlant.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartPlant.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartPlant.PlantNum]));
                fillByPlantNumCriteria = list.ToArray();
            }
            fillByPlantNumCriteria[0].Value = companyNum;
            fillByPlantNumCriteria[1].Value = partNum;
            fillByPlantNumCriteria[2].Value = plantNum;
            return EditTable<T, R>.Fetch(context, fillByPlantNumCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartPlant : PartPlantBase<PartPlant, PartPlantRow>
    {
        public PartPlant() : base() { }
    }

    #region PartPlantRow

    [Serializable()]
    public class PartPlantRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartPlant.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartPlant.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartPlant.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartPlant.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> primWhseProperty;
        public string PrimWhse
        {
            get
            {
                if (primWhseProperty == null)
                    primWhseProperty = GetStringProperty("PartPlant.PrimWhse");
                return primWhseProperty.Value;
            }
            set
            {
                if (primWhseProperty == null)
                    primWhseProperty = GetStringProperty("PartPlant.PrimWhse");
                primWhseProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minimumQtyProperty;
        public decimal MinimumQty
        {
            get
            {
                if (minimumQtyProperty == null)
                    minimumQtyProperty = GetDecimalProperty("PartPlant.MinimumQty");
                return minimumQtyProperty.Value;
            }
            set
            {
                if (minimumQtyProperty == null)
                    minimumQtyProperty = GetDecimalProperty("PartPlant.MinimumQty");
                minimumQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> maximumQtyProperty;
        public decimal MaximumQty
        {
            get
            {
                if (maximumQtyProperty == null)
                    maximumQtyProperty = GetDecimalProperty("PartPlant.MaximumQty");
                return maximumQtyProperty.Value;
            }
            set
            {
                if (maximumQtyProperty == null)
                    maximumQtyProperty = GetDecimalProperty("PartPlant.MaximumQty");
                maximumQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> safetyQtyProperty;
        public decimal SafetyQty
        {
            get
            {
                if (safetyQtyProperty == null)
                    safetyQtyProperty = GetDecimalProperty("PartPlant.SafetyQty");
                return safetyQtyProperty.Value;
            }
            set
            {
                if (safetyQtyProperty == null)
                    safetyQtyProperty = GetDecimalProperty("PartPlant.SafetyQty");
                safetyQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minOrderQtyProperty;
        public decimal MinOrderQty
        {
            get
            {
                if (minOrderQtyProperty == null)
                    minOrderQtyProperty = GetDecimalProperty("PartPlant.MinOrderQty");
                return minOrderQtyProperty.Value;
            }
            set
            {
                if (minOrderQtyProperty == null)
                    minOrderQtyProperty = GetDecimalProperty("PartPlant.MinOrderQty");
                minOrderQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> leadTimeProperty;
        public int LeadTime
        {
            get
            {
                if (leadTimeProperty == null)
                    leadTimeProperty = GetIntegerProperty("PartPlant.LeadTime");
                return leadTimeProperty.Value;
            }
            set
            {
                if (leadTimeProperty == null)
                    leadTimeProperty = GetIntegerProperty("PartPlant.LeadTime");
                leadTimeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minMfgLotSizeProperty;
        public decimal MinMfgLotSize
        {
            get
            {
                if (minMfgLotSizeProperty == null)
                    minMfgLotSizeProperty = GetDecimalProperty("PartPlant.MinMfgLotSize");
                return minMfgLotSizeProperty.Value;
            }
            set
            {
                if (minMfgLotSizeProperty == null)
                    minMfgLotSizeProperty = GetDecimalProperty("PartPlant.MinMfgLotSize");
                minMfgLotSizeProperty.Value = value;
            }
        }

        protected RowProperty<string> obsolete900MinAbcProperty;
        public string Obsolete900_MinAbc
        {
            get
            {
                if (obsolete900MinAbcProperty == null)
                    obsolete900MinAbcProperty = GetStringProperty("PartPlant.Obsolete900_MinAbc");
                return obsolete900MinAbcProperty.Value;
            }
            set
            {
                if (obsolete900MinAbcProperty == null)
                    obsolete900MinAbcProperty = GetStringProperty("PartPlant.Obsolete900_MinAbc");
                obsolete900MinAbcProperty.Value = value;
            }
        }

        protected RowProperty<string> obsolete900SystemAbcProperty;
        public string Obsolete900_SystemAbc
        {
            get
            {
                if (obsolete900SystemAbcProperty == null)
                    obsolete900SystemAbcProperty = GetStringProperty("PartPlant.Obsolete900_SystemAbc");
                return obsolete900SystemAbcProperty.Value;
            }
            set
            {
                if (obsolete900SystemAbcProperty == null)
                    obsolete900SystemAbcProperty = GetStringProperty("PartPlant.Obsolete900_SystemAbc");
                obsolete900SystemAbcProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("PartPlant.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("PartPlant.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete900AllocQtyProperty;
        public decimal Obsolete900_AllocQty
        {
            get
            {
                if (obsolete900AllocQtyProperty == null)
                    obsolete900AllocQtyProperty = GetDecimalProperty("PartPlant.Obsolete900_AllocQty");
                return obsolete900AllocQtyProperty.Value;
            }
            set
            {
                if (obsolete900AllocQtyProperty == null)
                    obsolete900AllocQtyProperty = GetDecimalProperty("PartPlant.Obsolete900_AllocQty");
                obsolete900AllocQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> purPointProperty;
        public string PurPoint
        {
            get
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("PartPlant.PurPoint");
                return purPointProperty.Value;
            }
            set
            {
                if (purPointProperty == null)
                    purPointProperty = GetStringProperty("PartPlant.PurPoint");
                purPointProperty.Value = value;
            }
        }

        protected RowProperty<bool> backFlushProperty;
        public bool BackFlush
        {
            get
            {
                if (backFlushProperty == null)
                    backFlushProperty = GetBooleanProperty("PartPlant.BackFlush");
                return backFlushProperty.Value;
            }
            set
            {
                if (backFlushProperty == null)
                    backFlushProperty = GetBooleanProperty("PartPlant.BackFlush");
                backFlushProperty.Value = value;
            }
        }

        protected RowProperty<decimal> mfgLotSizeProperty;
        public decimal MfgLotSize
        {
            get
            {
                if (mfgLotSizeProperty == null)
                    mfgLotSizeProperty = GetDecimalProperty("PartPlant.MfgLotSize");
                return mfgLotSizeProperty.Value;
            }
            set
            {
                if (mfgLotSizeProperty == null)
                    mfgLotSizeProperty = GetDecimalProperty("PartPlant.MfgLotSize");
                mfgLotSizeProperty.Value = value;
            }
        }

        protected RowProperty<string> plantNumProperty;
        public string PlantNum
        {
            get
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PartPlant.PlantNum");
                return plantNumProperty.Value;
            }
            set
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PartPlant.PlantNum");
                plantNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> maxMfgLotSizeProperty;
        public decimal MaxMfgLotSize
        {
            get
            {
                if (maxMfgLotSizeProperty == null)
                    maxMfgLotSizeProperty = GetDecimalProperty("PartPlant.MaxMfgLotSize");
                return maxMfgLotSizeProperty.Value;
            }
            set
            {
                if (maxMfgLotSizeProperty == null)
                    maxMfgLotSizeProperty = GetDecimalProperty("PartPlant.MaxMfgLotSize");
                maxMfgLotSizeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> mfgLotMultipleProperty;
        public decimal MfgLotMultiple
        {
            get
            {
                if (mfgLotMultipleProperty == null)
                    mfgLotMultipleProperty = GetDecimalProperty("PartPlant.MfgLotMultiple");
                return mfgLotMultipleProperty.Value;
            }
            set
            {
                if (mfgLotMultipleProperty == null)
                    mfgLotMultipleProperty = GetDecimalProperty("PartPlant.MfgLotMultiple");
                mfgLotMultipleProperty.Value = value;
            }
        }

        protected RowProperty<bool> mRPRecalcNeededProperty;
        public bool MRPRecalcNeeded
        {
            get
            {
                if (mRPRecalcNeededProperty == null)
                    mRPRecalcNeededProperty = GetBooleanProperty("PartPlant.MRPRecalcNeeded");
                return mRPRecalcNeededProperty.Value;
            }
            set
            {
                if (mRPRecalcNeededProperty == null)
                    mRPRecalcNeededProperty = GetBooleanProperty("PartPlant.MRPRecalcNeeded");
                mRPRecalcNeededProperty.Value = value;
            }
        }

        protected RowProperty<bool> processMRPProperty;
        public bool ProcessMRP
        {
            get
            {
                if (processMRPProperty == null)
                    processMRPProperty = GetBooleanProperty("PartPlant.ProcessMRP");
                return processMRPProperty.Value;
            }
            set
            {
                if (processMRPProperty == null)
                    processMRPProperty = GetBooleanProperty("PartPlant.ProcessMRP");
                processMRPProperty.Value = value;
            }
        }

        protected RowProperty<bool> generateSuggProperty;
        public bool GenerateSugg
        {
            get
            {
                if (generateSuggProperty == null)
                    generateSuggProperty = GetBooleanProperty("PartPlant.GenerateSugg");
                return generateSuggProperty.Value;
            }
            set
            {
                if (generateSuggProperty == null)
                    generateSuggProperty = GetBooleanProperty("PartPlant.GenerateSugg");
                generateSuggProperty.Value = value;
            }
        }

        protected RowProperty<int> daysOfSupplyProperty;
        public int DaysOfSupply
        {
            get
            {
                if (daysOfSupplyProperty == null)
                    daysOfSupplyProperty = GetIntegerProperty("PartPlant.DaysOfSupply");
                return daysOfSupplyProperty.Value;
            }
            set
            {
                if (daysOfSupplyProperty == null)
                    daysOfSupplyProperty = GetIntegerProperty("PartPlant.DaysOfSupply");
                daysOfSupplyProperty.Value = value;
            }
        }

        protected RowProperty<bool> reOrderLevelProperty;
        public bool ReOrderLevel
        {
            get
            {
                if (reOrderLevelProperty == null)
                    reOrderLevelProperty = GetBooleanProperty("PartPlant.ReOrderLevel");
                return reOrderLevelProperty.Value;
            }
            set
            {
                if (reOrderLevelProperty == null)
                    reOrderLevelProperty = GetBooleanProperty("PartPlant.ReOrderLevel");
                reOrderLevelProperty.Value = value;
            }
        }

        protected RowProperty<bool> getFromLocalWhseProperty;
        public bool GetFromLocalWhse
        {
            get
            {
                if (getFromLocalWhseProperty == null)
                    getFromLocalWhseProperty = GetBooleanProperty("PartPlant.GetFromLocalWhse");
                return getFromLocalWhseProperty.Value;
            }
            set
            {
                if (getFromLocalWhseProperty == null)
                    getFromLocalWhseProperty = GetBooleanProperty("PartPlant.GetFromLocalWhse");
                getFromLocalWhseProperty.Value = value;
            }
        }

        protected RowProperty<int> forecastTimeProperty;
        public int ForecastTime
        {
            get
            {
                if (forecastTimeProperty == null)
                    forecastTimeProperty = GetIntegerProperty("PartPlant.ForecastTime");
                return forecastTimeProperty.Value;
            }
            set
            {
                if (forecastTimeProperty == null)
                    forecastTimeProperty = GetIntegerProperty("PartPlant.ForecastTime");
                forecastTimeProperty.Value = value;
            }
        }

        protected RowProperty<string> transferPlantProperty;
        public string TransferPlant
        {
            get
            {
                if (transferPlantProperty == null)
                    transferPlantProperty = GetStringProperty("PartPlant.TransferPlant");
                return transferPlantProperty.Value;
            }
            set
            {
                if (transferPlantProperty == null)
                    transferPlantProperty = GetStringProperty("PartPlant.TransferPlant");
                transferPlantProperty.Value = value;
            }
        }

        protected RowProperty<string> sourceTypeProperty;
        public string SourceType
        {
            get
            {
                if (sourceTypeProperty == null)
                    sourceTypeProperty = GetStringProperty("PartPlant.SourceType");
                return sourceTypeProperty.Value;
            }
            set
            {
                if (sourceTypeProperty == null)
                    sourceTypeProperty = GetStringProperty("PartPlant.SourceType");
                sourceTypeProperty.Value = value;
            }
        }

        protected RowProperty<int> transferLeadTimeProperty;
        public int TransferLeadTime
        {
            get
            {
                if (transferLeadTimeProperty == null)
                    transferLeadTimeProperty = GetIntegerProperty("PartPlant.TransferLeadTime");
                return transferLeadTimeProperty.Value;
            }
            set
            {
                if (transferLeadTimeProperty == null)
                    transferLeadTimeProperty = GetIntegerProperty("PartPlant.TransferLeadTime");
                transferLeadTimeProperty.Value = value;
            }
        }

        protected RowProperty<int> planTimeFenceProperty;
        public int PlanTimeFence
        {
            get
            {
                if (planTimeFenceProperty == null)
                    planTimeFenceProperty = GetIntegerProperty("PartPlant.PlanTimeFence");
                return planTimeFenceProperty.Value;
            }
            set
            {
                if (planTimeFenceProperty == null)
                    planTimeFenceProperty = GetIntegerProperty("PartPlant.PlanTimeFence");
                planTimeFenceProperty.Value = value;
            }
        }

        protected RowProperty<int> reschedOutDeltaProperty;
        public int ReschedOutDelta
        {
            get
            {
                if (reschedOutDeltaProperty == null)
                    reschedOutDeltaProperty = GetIntegerProperty("PartPlant.ReschedOutDelta");
                return reschedOutDeltaProperty.Value;
            }
            set
            {
                if (reschedOutDeltaProperty == null)
                    reschedOutDeltaProperty = GetIntegerProperty("PartPlant.ReschedOutDelta");
                reschedOutDeltaProperty.Value = value;
            }
        }

        protected RowProperty<int> reschedInDeltaProperty;
        public int ReschedInDelta
        {
            get
            {
                if (reschedInDeltaProperty == null)
                    reschedInDeltaProperty = GetIntegerProperty("PartPlant.ReschedInDelta");
                return reschedInDeltaProperty.Value;
            }
            set
            {
                if (reschedInDeltaProperty == null)
                    reschedInDeltaProperty = GetIntegerProperty("PartPlant.ReschedInDelta");
                reschedInDeltaProperty.Value = value;
            }
        }

        protected RowProperty<bool> nonStockProperty;
        public bool NonStock
        {
            get
            {
                if (nonStockProperty == null)
                    nonStockProperty = GetBooleanProperty("PartPlant.NonStock");
                return nonStockProperty.Value;
            }
            set
            {
                if (nonStockProperty == null)
                    nonStockProperty = GetBooleanProperty("PartPlant.NonStock");
                nonStockProperty.Value = value;
            }
        }

        protected RowProperty<bool> phantomBOMProperty;
        public bool PhantomBOM
        {
            get
            {
                if (phantomBOMProperty == null)
                    phantomBOMProperty = GetBooleanProperty("PartPlant.PhantomBOM");
                return phantomBOMProperty.Value;
            }
            set
            {
                if (phantomBOMProperty == null)
                    phantomBOMProperty = GetBooleanProperty("PartPlant.PhantomBOM");
                phantomBOMProperty.Value = value;
            }
        }

        protected RowProperty<string> buyerIDProperty;
        public string BuyerID
        {
            get
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("PartPlant.BuyerID");
                return buyerIDProperty.Value;
            }
            set
            {
                if (buyerIDProperty == null)
                    buyerIDProperty = GetStringProperty("PartPlant.BuyerID");
                buyerIDProperty.Value = value;
            }
        }

        protected RowProperty<string> personIDProperty;
        public string PersonID
        {
            get
            {
                if (personIDProperty == null)
                    personIDProperty = GetStringProperty("PartPlant.PersonID");
                return personIDProperty.Value;
            }
            set
            {
                if (personIDProperty == null)
                    personIDProperty = GetStringProperty("PartPlant.PersonID");
                personIDProperty.Value = value;
            }
        }

        protected RowProperty<string> costMethodProperty;
        public string CostMethod
        {
            get
            {
                if (costMethodProperty == null)
                    costMethodProperty = GetStringProperty("PartPlant.CostMethod");
                return costMethodProperty.Value;
            }
            set
            {
                if (costMethodProperty == null)
                    costMethodProperty = GetStringProperty("PartPlant.CostMethod");
                costMethodProperty.Value = value;
            }
        }

        protected RowProperty<int> prepTimeProperty;
        public int PrepTime
        {
            get
            {
                if (prepTimeProperty == null)
                    prepTimeProperty = GetIntegerProperty("PartPlant.PrepTime");
                return prepTimeProperty.Value;
            }
            set
            {
                if (prepTimeProperty == null)
                    prepTimeProperty = GetIntegerProperty("PartPlant.PrepTime");
                prepTimeProperty.Value = value;
            }
        }

        protected RowProperty<int> receiveTimeProperty;
        public int ReceiveTime
        {
            get
            {
                if (receiveTimeProperty == null)
                    receiveTimeProperty = GetIntegerProperty("PartPlant.ReceiveTime");
                return receiveTimeProperty.Value;
            }
            set
            {
                if (receiveTimeProperty == null)
                    receiveTimeProperty = GetIntegerProperty("PartPlant.ReceiveTime");
                receiveTimeProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodProperty;
        public string AltMethod
        {
            get
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartPlant.AltMethod");
                return altMethodProperty.Value;
            }
            set
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartPlant.AltMethod");
                altMethodProperty.Value = value;
            }
        }

        protected RowProperty<int> kitTimeProperty;
        public int KitTime
        {
            get
            {
                if (kitTimeProperty == null)
                    kitTimeProperty = GetIntegerProperty("PartPlant.KitTime");
                return kitTimeProperty.Value;
            }
            set
            {
                if (kitTimeProperty == null)
                    kitTimeProperty = GetIntegerProperty("PartPlant.KitTime");
                kitTimeProperty.Value = value;
            }
        }

        protected RowProperty<bool> kitAllowUpdateProperty;
        public bool KitAllowUpdate
        {
            get
            {
                if (kitAllowUpdateProperty == null)
                    kitAllowUpdateProperty = GetBooleanProperty("PartPlant.KitAllowUpdate");
                return kitAllowUpdateProperty.Value;
            }
            set
            {
                if (kitAllowUpdateProperty == null)
                    kitAllowUpdateProperty = GetBooleanProperty("PartPlant.KitAllowUpdate");
                kitAllowUpdateProperty.Value = value;
            }
        }

        protected RowProperty<bool> kitBackFlushProperty;
        public bool KitBackFlush
        {
            get
            {
                if (kitBackFlushProperty == null)
                    kitBackFlushProperty = GetBooleanProperty("PartPlant.KitBackFlush");
                return kitBackFlushProperty.Value;
            }
            set
            {
                if (kitBackFlushProperty == null)
                    kitBackFlushProperty = GetBooleanProperty("PartPlant.KitBackFlush");
                kitBackFlushProperty.Value = value;
            }
        }

        protected RowProperty<string> kitPricingProperty;
        public string KitPricing
        {
            get
            {
                if (kitPricingProperty == null)
                    kitPricingProperty = GetStringProperty("PartPlant.KitPricing");
                return kitPricingProperty.Value;
            }
            set
            {
                if (kitPricingProperty == null)
                    kitPricingProperty = GetStringProperty("PartPlant.KitPricing");
                kitPricingProperty.Value = value;
            }
        }

        protected RowProperty<bool> kitPrintCompsPSProperty;
        public bool KitPrintCompsPS
        {
            get
            {
                if (kitPrintCompsPSProperty == null)
                    kitPrintCompsPSProperty = GetBooleanProperty("PartPlant.KitPrintCompsPS");
                return kitPrintCompsPSProperty.Value;
            }
            set
            {
                if (kitPrintCompsPSProperty == null)
                    kitPrintCompsPSProperty = GetBooleanProperty("PartPlant.KitPrintCompsPS");
                kitPrintCompsPSProperty.Value = value;
            }
        }

        protected RowProperty<bool> kitPrintCompsInvProperty;
        public bool KitPrintCompsInv
        {
            get
            {
                if (kitPrintCompsInvProperty == null)
                    kitPrintCompsInvProperty = GetBooleanProperty("PartPlant.KitPrintCompsInv");
                return kitPrintCompsInvProperty.Value;
            }
            set
            {
                if (kitPrintCompsInvProperty == null)
                    kitPrintCompsInvProperty = GetBooleanProperty("PartPlant.KitPrintCompsInv");
                kitPrintCompsInvProperty.Value = value;
            }
        }

        protected RowProperty<bool> kitShipCompleteProperty;
        public bool KitShipComplete
        {
            get
            {
                if (kitShipCompleteProperty == null)
                    kitShipCompleteProperty = GetBooleanProperty("PartPlant.KitShipComplete");
                return kitShipCompleteProperty.Value;
            }
            set
            {
                if (kitShipCompleteProperty == null)
                    kitShipCompleteProperty = GetBooleanProperty("PartPlant.KitShipComplete");
                kitShipCompleteProperty.Value = value;
            }
        }

        protected RowProperty<bool> kitAllowChangeParmsProperty;
        public bool KitAllowChangeParms
        {
            get
            {
                if (kitAllowChangeParmsProperty == null)
                    kitAllowChangeParmsProperty = GetBooleanProperty("PartPlant.KitAllowChangeParms");
                return kitAllowChangeParmsProperty.Value;
            }
            set
            {
                if (kitAllowChangeParmsProperty == null)
                    kitAllowChangeParmsProperty = GetBooleanProperty("PartPlant.KitAllowChangeParms");
                kitAllowChangeParmsProperty.Value = value;
            }
        }

        protected RowProperty<decimal> shortHorizonMaxMfgLotSizeProperty;
        public decimal ShortHorizonMaxMfgLotSize
        {
            get
            {
                if (shortHorizonMaxMfgLotSizeProperty == null)
                    shortHorizonMaxMfgLotSizeProperty = GetDecimalProperty("PartPlant.ShortHorizonMaxMfgLotSize");
                return shortHorizonMaxMfgLotSizeProperty.Value;
            }
            set
            {
                if (shortHorizonMaxMfgLotSizeProperty == null)
                    shortHorizonMaxMfgLotSizeProperty = GetDecimalProperty("PartPlant.ShortHorizonMaxMfgLotSize");
                shortHorizonMaxMfgLotSizeProperty.Value = value;
            }
        }

        protected RowProperty<int> shortHorizonDaysProperty;
        public int ShortHorizonDays
        {
            get
            {
                if (shortHorizonDaysProperty == null)
                    shortHorizonDaysProperty = GetIntegerProperty("PartPlant.ShortHorizonDays");
                return shortHorizonDaysProperty.Value;
            }
            set
            {
                if (shortHorizonDaysProperty == null)
                    shortHorizonDaysProperty = GetIntegerProperty("PartPlant.ShortHorizonDays");
                shortHorizonDaysProperty.Value = value;
            }
        }

        protected RowProperty<decimal> shortHorizonMinMfgLotSizeProperty;
        public decimal ShortHorizonMinMfgLotSize
        {
            get
            {
                if (shortHorizonMinMfgLotSizeProperty == null)
                    shortHorizonMinMfgLotSizeProperty = GetDecimalProperty("PartPlant.ShortHorizonMinMfgLotSize");
                return shortHorizonMinMfgLotSizeProperty.Value;
            }
            set
            {
                if (shortHorizonMinMfgLotSizeProperty == null)
                    shortHorizonMinMfgLotSizeProperty = GetDecimalProperty("PartPlant.ShortHorizonMinMfgLotSize");
                shortHorizonMinMfgLotSizeProperty.Value = value;
            }
        }

        protected RowProperty<bool> limitProdYldRecalcProperty;
        public bool LimitProdYldRecalc
        {
            get
            {
                if (limitProdYldRecalcProperty == null)
                    limitProdYldRecalcProperty = GetBooleanProperty("PartPlant.LimitProdYldRecalc");
                return limitProdYldRecalcProperty.Value;
            }
            set
            {
                if (limitProdYldRecalcProperty == null)
                    limitProdYldRecalcProperty = GetBooleanProperty("PartPlant.LimitProdYldRecalc");
                limitProdYldRecalcProperty.Value = value;
            }
        }

        protected RowProperty<bool> qtyBearingProperty;
        public bool QtyBearing
        {
            get
            {
                if (qtyBearingProperty == null)
                    qtyBearingProperty = GetBooleanProperty("PartPlant.QtyBearing");
                return qtyBearingProperty.Value;
            }
            set
            {
                if (qtyBearingProperty == null)
                    qtyBearingProperty = GetBooleanProperty("PartPlant.QtyBearing");
                qtyBearingProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> mRPLastScheduledDateProperty;
        public DateTime? MRPLastScheduledDate
        {
            get
            {
                if (mRPLastScheduledDateProperty == null)
                    mRPLastScheduledDateProperty = GetNullableDateTimeProperty("PartPlant.MRPLastScheduledDate");
                return mRPLastScheduledDateProperty.Value;
            }
            set
            {
                if (mRPLastScheduledDateProperty == null)
                    mRPLastScheduledDateProperty = GetNullableDateTimeProperty("PartPlant.MRPLastScheduledDate");
                mRPLastScheduledDateProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> mRPLastCutOffDateProperty;
        public DateTime? MRPLastCutOffDate
        {
            get
            {
                if (mRPLastCutOffDateProperty == null)
                    mRPLastCutOffDateProperty = GetNullableDateTimeProperty("PartPlant.MRPLastCutOffDate");
                return mRPLastCutOffDateProperty.Value;
            }
            set
            {
                if (mRPLastCutOffDateProperty == null)
                    mRPLastCutOffDateProperty = GetNullableDateTimeProperty("PartPlant.MRPLastCutOffDate");
                mRPLastCutOffDateProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> mRPLastRunDateProperty;
        public DateTime? MRPLastRunDate
        {
            get
            {
                if (mRPLastRunDateProperty == null)
                    mRPLastRunDateProperty = GetNullableDateTimeProperty("PartPlant.MRPLastRunDate");
                return mRPLastRunDateProperty.Value;
            }
            set
            {
                if (mRPLastRunDateProperty == null)
                    mRPLastRunDateProperty = GetNullableDateTimeProperty("PartPlant.MRPLastRunDate");
                mRPLastRunDateProperty.Value = value;
            }
        }

        protected RowProperty<int> mRPLastRunTimeProperty;
        public int MRPLastRunTime
        {
            get
            {
                if (mRPLastRunTimeProperty == null)
                    mRPLastRunTimeProperty = GetIntegerProperty("PartPlant.MRPLastRunTime");
                return mRPLastRunTimeProperty.Value;
            }
            set
            {
                if (mRPLastRunTimeProperty == null)
                    mRPLastRunTimeProperty = GetIntegerProperty("PartPlant.MRPLastRunTime");
                mRPLastRunTimeProperty.Value = value;
            }
        }

        protected RowProperty<int> shortHorizonDaysSuppProperty;
        public int ShortHorizonDaysSupp
        {
            get
            {
                if (shortHorizonDaysSuppProperty == null)
                    shortHorizonDaysSuppProperty = GetIntegerProperty("PartPlant.ShortHorizonDaysSupp");
                return shortHorizonDaysSuppProperty.Value;
            }
            set
            {
                if (shortHorizonDaysSuppProperty == null)
                    shortHorizonDaysSuppProperty = GetIntegerProperty("PartPlant.ShortHorizonDaysSupp");
                shortHorizonDaysSuppProperty.Value = value;
            }
        }

        protected RowProperty<string> sNBaseDataTypeProperty;
        public string SNBaseDataType
        {
            get
            {
                if (sNBaseDataTypeProperty == null)
                    sNBaseDataTypeProperty = GetStringProperty("PartPlant.SNBaseDataType");
                return sNBaseDataTypeProperty.Value;
            }
            set
            {
                if (sNBaseDataTypeProperty == null)
                    sNBaseDataTypeProperty = GetStringProperty("PartPlant.SNBaseDataType");
                sNBaseDataTypeProperty.Value = value;
            }
        }

        protected RowProperty<string> sNFormatProperty;
        public string SNFormat
        {
            get
            {
                if (sNFormatProperty == null)
                    sNFormatProperty = GetStringProperty("PartPlant.SNFormat");
                return sNFormatProperty.Value;
            }
            set
            {
                if (sNFormatProperty == null)
                    sNFormatProperty = GetStringProperty("PartPlant.SNFormat");
                sNFormatProperty.Value = value;
            }
        }

        protected RowProperty<string> sNPrefixProperty;
        public string SNPrefix
        {
            get
            {
                if (sNPrefixProperty == null)
                    sNPrefixProperty = GetStringProperty("PartPlant.SNPrefix");
                return sNPrefixProperty.Value;
            }
            set
            {
                if (sNPrefixProperty == null)
                    sNPrefixProperty = GetStringProperty("PartPlant.SNPrefix");
                sNPrefixProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskSuffixProperty;
        public string SNMaskSuffix
        {
            get
            {
                if (sNMaskSuffixProperty == null)
                    sNMaskSuffixProperty = GetStringProperty("PartPlant.SNMaskSuffix");
                return sNMaskSuffixProperty.Value;
            }
            set
            {
                if (sNMaskSuffixProperty == null)
                    sNMaskSuffixProperty = GetStringProperty("PartPlant.SNMaskSuffix");
                sNMaskSuffixProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskPrefixProperty;
        public string SNMaskPrefix
        {
            get
            {
                if (sNMaskPrefixProperty == null)
                    sNMaskPrefixProperty = GetStringProperty("PartPlant.SNMaskPrefix");
                return sNMaskPrefixProperty.Value;
            }
            set
            {
                if (sNMaskPrefixProperty == null)
                    sNMaskPrefixProperty = GetStringProperty("PartPlant.SNMaskPrefix");
                sNMaskPrefixProperty.Value = value;
            }
        }

        protected RowProperty<string> sNLastUsedSeqProperty;
        public string SNLastUsedSeq
        {
            get
            {
                if (sNLastUsedSeqProperty == null)
                    sNLastUsedSeqProperty = GetStringProperty("PartPlant.SNLastUsedSeq");
                return sNLastUsedSeqProperty.Value;
            }
            set
            {
                if (sNLastUsedSeqProperty == null)
                    sNLastUsedSeqProperty = GetStringProperty("PartPlant.SNLastUsedSeq");
                sNLastUsedSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskProperty;
        public string SNMask
        {
            get
            {
                if (sNMaskProperty == null)
                    sNMaskProperty = GetStringProperty("PartPlant.SNMask");
                return sNMaskProperty.Value;
            }
            set
            {
                if (sNMaskProperty == null)
                    sNMaskProperty = GetStringProperty("PartPlant.SNMask");
                sNMaskProperty.Value = value;
            }
        }

        protected RowProperty<string> sNMaskExampleProperty;
        public string SNMaskExample
        {
            get
            {
                if (sNMaskExampleProperty == null)
                    sNMaskExampleProperty = GetStringProperty("PartPlant.SNMaskExample");
                return sNMaskExampleProperty.Value;
            }
            set
            {
                if (sNMaskExampleProperty == null)
                    sNMaskExampleProperty = GetStringProperty("PartPlant.SNMaskExample");
                sNMaskExampleProperty.Value = value;
            }
        }

        protected RowProperty<bool> useMaskSeqProperty;
        public bool UseMaskSeq
        {
            get
            {
                if (useMaskSeqProperty == null)
                    useMaskSeqProperty = GetBooleanProperty("PartPlant.UseMaskSeq");
                return useMaskSeqProperty.Value;
            }
            set
            {
                if (useMaskSeqProperty == null)
                    useMaskSeqProperty = GetBooleanProperty("PartPlant.UseMaskSeq");
                useMaskSeqProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartPlant.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartPlant.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartPlant.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartPlant.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> buyToOrderProperty;
        public bool BuyToOrder
        {
            get
            {
                if (buyToOrderProperty == null)
                    buyToOrderProperty = GetBooleanProperty("PartPlant.BuyToOrder");
                return buyToOrderProperty.Value;
            }
            set
            {
                if (buyToOrderProperty == null)
                    buyToOrderProperty = GetBooleanProperty("PartPlant.BuyToOrder");
                buyToOrderProperty.Value = value;
            }
        }

        protected RowProperty<bool> dropShipProperty;
        public bool DropShip
        {
            get
            {
                if (dropShipProperty == null)
                    dropShipProperty = GetBooleanProperty("PartPlant.DropShip");
                return dropShipProperty.Value;
            }
            set
            {
                if (dropShipProperty == null)
                    dropShipProperty = GetBooleanProperty("PartPlant.DropShip");
                dropShipProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcQtyProperty;
        public bool CalcQty
        {
            get
            {
                if (calcQtyProperty == null)
                    calcQtyProperty = GetBooleanProperty("PartPlant.CalcQty");
                return calcQtyProperty.Value;
            }
            set
            {
                if (calcQtyProperty == null)
                    calcQtyProperty = GetBooleanProperty("PartPlant.CalcQty");
                calcQtyProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcValueProperty;
        public bool CalcValue
        {
            get
            {
                if (calcValueProperty == null)
                    calcValueProperty = GetBooleanProperty("PartPlant.CalcValue");
                return calcValueProperty.Value;
            }
            set
            {
                if (calcValueProperty == null)
                    calcValueProperty = GetBooleanProperty("PartPlant.CalcValue");
                calcValueProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qtyAdjToleranceProperty;
        public decimal QtyAdjTolerance
        {
            get
            {
                if (qtyAdjToleranceProperty == null)
                    qtyAdjToleranceProperty = GetDecimalProperty("PartPlant.QtyAdjTolerance");
                return qtyAdjToleranceProperty.Value;
            }
            set
            {
                if (qtyAdjToleranceProperty == null)
                    qtyAdjToleranceProperty = GetDecimalProperty("PartPlant.QtyAdjTolerance");
                qtyAdjToleranceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> pcntToleranceProperty;
        public decimal PcntTolerance
        {
            get
            {
                if (pcntToleranceProperty == null)
                    pcntToleranceProperty = GetDecimalProperty("PartPlant.PcntTolerance");
                return pcntToleranceProperty.Value;
            }
            set
            {
                if (pcntToleranceProperty == null)
                    pcntToleranceProperty = GetDecimalProperty("PartPlant.PcntTolerance");
                pcntToleranceProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcPcntProperty;
        public bool CalcPcnt
        {
            get
            {
                if (calcPcntProperty == null)
                    calcPcntProperty = GetBooleanProperty("PartPlant.CalcPcnt");
                return calcPcntProperty.Value;
            }
            set
            {
                if (calcPcntProperty == null)
                    calcPcntProperty = GetBooleanProperty("PartPlant.CalcPcnt");
                calcPcntProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qtyToleranceProperty;
        public decimal QtyTolerance
        {
            get
            {
                if (qtyToleranceProperty == null)
                    qtyToleranceProperty = GetDecimalProperty("PartPlant.QtyTolerance");
                return qtyToleranceProperty.Value;
            }
            set
            {
                if (qtyToleranceProperty == null)
                    qtyToleranceProperty = GetDecimalProperty("PartPlant.QtyTolerance");
                qtyToleranceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> valueToleranceProperty;
        public decimal ValueTolerance
        {
            get
            {
                if (valueToleranceProperty == null)
                    valueToleranceProperty = GetDecimalProperty("PartPlant.ValueTolerance");
                return valueToleranceProperty.Value;
            }
            set
            {
                if (valueToleranceProperty == null)
                    valueToleranceProperty = GetDecimalProperty("PartPlant.ValueTolerance");
                valueToleranceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> reservedQtyProperty;
        public decimal ReservedQty
        {
            get
            {
                if (reservedQtyProperty == null)
                    reservedQtyProperty = GetDecimalProperty("PartPlant.ReservedQty");
                return reservedQtyProperty.Value;
            }
            set
            {
                if (reservedQtyProperty == null)
                    reservedQtyProperty = GetDecimalProperty("PartPlant.ReservedQty");
                reservedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> allocatedQtyProperty;
        public decimal AllocatedQty
        {
            get
            {
                if (allocatedQtyProperty == null)
                    allocatedQtyProperty = GetDecimalProperty("PartPlant.AllocatedQty");
                return allocatedQtyProperty.Value;
            }
            set
            {
                if (allocatedQtyProperty == null)
                    allocatedQtyProperty = GetDecimalProperty("PartPlant.AllocatedQty");
                allocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> xRefPartNumProperty;
        public string XRefPartNum
        {
            get
            {
                if (xRefPartNumProperty == null)
                    xRefPartNumProperty = GetStringProperty("PartPlant.XRefPartNum");
                return xRefPartNumProperty.Value;
            }
            set
            {
                if (xRefPartNumProperty == null)
                    xRefPartNumProperty = GetStringProperty("PartPlant.XRefPartNum");
                xRefPartNumProperty.Value = value;
            }
        }

        protected RowProperty<string> xRefPartTypeProperty;
        public string XRefPartType
        {
            get
            {
                if (xRefPartTypeProperty == null)
                    xRefPartTypeProperty = GetStringProperty("PartPlant.XRefPartType");
                return xRefPartTypeProperty.Value;
            }
            set
            {
                if (xRefPartTypeProperty == null)
                    xRefPartTypeProperty = GetStringProperty("PartPlant.XRefPartType");
                xRefPartTypeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> demandQtyProperty;
        public decimal DemandQty
        {
            get
            {
                if (demandQtyProperty == null)
                    demandQtyProperty = GetDecimalProperty("PartPlant.DemandQty");
                return demandQtyProperty.Value;
            }
            set
            {
                if (demandQtyProperty == null)
                    demandQtyProperty = GetDecimalProperty("PartPlant.DemandQty");
                demandQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartPlant.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartPlant.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartPlant.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartPlant.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartRev Table

    [Serializable()]
    public abstract partial class PartRevBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartRevBase<T, R>, new()
        where R : PartRevRow, new()
    {
        protected PartRevBase() : base() { }

        protected static Schema.PartRev schemaTable;
        public static Schema.PartRev SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartRev)E9Schema.Instance.TablesDictionary["PartRev"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByRevisionNumCriteria;
        public static T FillByRevisionNum(DataContext context, string companyNum, string partNum, string revisionNum, params string[] columnNames)
        {
            if (fillByRevisionNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.RevisionNum]));
                fillByRevisionNumCriteria = list.ToArray();
            }
            fillByRevisionNumCriteria[0].Value = companyNum;
            fillByRevisionNumCriteria[1].Value = partNum;
            fillByRevisionNumCriteria[2].Value = revisionNum;
            return EditTable<T, R>.Fetch(context, fillByRevisionNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByAltMethodCriteria;
        public static T FillByAltMethod(DataContext context, string companyNum, string partNum, string revisionNum, string altMethod, params string[] columnNames)
        {
            if (fillByAltMethodCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.RevisionNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartRev.AltMethod]));
                fillByAltMethodCriteria = list.ToArray();
            }
            fillByAltMethodCriteria[0].Value = companyNum;
            fillByAltMethodCriteria[1].Value = partNum;
            fillByAltMethodCriteria[2].Value = revisionNum;
            fillByAltMethodCriteria[3].Value = altMethod;
            return EditTable<T, R>.Fetch(context, fillByAltMethodCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartRev : PartRevBase<PartRev, PartRevRow>
    {
        public PartRev() : base() { }
    }

    #region PartRevRow

    [Serializable()]
    public class PartRevRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartRev.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartRev.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartRev.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartRev.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> revShortDescProperty;
        public string RevShortDesc
        {
            get
            {
                if (revShortDescProperty == null)
                    revShortDescProperty = GetStringProperty("PartRev.RevShortDesc");
                return revShortDescProperty.Value;
            }
            set
            {
                if (revShortDescProperty == null)
                    revShortDescProperty = GetStringProperty("PartRev.RevShortDesc");
                revShortDescProperty.Value = value;
            }
        }

        protected RowProperty<string> revDescriptionProperty;
        public string RevDescription
        {
            get
            {
                if (revDescriptionProperty == null)
                    revDescriptionProperty = GetStringProperty("PartRev.RevDescription");
                return revDescriptionProperty.Value;
            }
            set
            {
                if (revDescriptionProperty == null)
                    revDescriptionProperty = GetStringProperty("PartRev.RevDescription");
                revDescriptionProperty.Value = value;
            }
        }

        protected RowProperty<string> revisionNumProperty;
        public string RevisionNum
        {
            get
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartRev.RevisionNum");
                return revisionNumProperty.Value;
            }
            set
            {
                if (revisionNumProperty == null)
                    revisionNumProperty = GetStringProperty("PartRev.RevisionNum");
                revisionNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> approvedProperty;
        public bool Approved
        {
            get
            {
                if (approvedProperty == null)
                    approvedProperty = GetBooleanProperty("PartRev.Approved");
                return approvedProperty.Value;
            }
            set
            {
                if (approvedProperty == null)
                    approvedProperty = GetBooleanProperty("PartRev.Approved");
                approvedProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> approvedDateProperty;
        public DateTime? ApprovedDate
        {
            get
            {
                if (approvedDateProperty == null)
                    approvedDateProperty = GetNullableDateTimeProperty("PartRev.ApprovedDate");
                return approvedDateProperty.Value;
            }
            set
            {
                if (approvedDateProperty == null)
                    approvedDateProperty = GetNullableDateTimeProperty("PartRev.ApprovedDate");
                approvedDateProperty.Value = value;
            }
        }

        protected RowProperty<string> approvedByProperty;
        public string ApprovedBy
        {
            get
            {
                if (approvedByProperty == null)
                    approvedByProperty = GetStringProperty("PartRev.ApprovedBy");
                return approvedByProperty.Value;
            }
            set
            {
                if (approvedByProperty == null)
                    approvedByProperty = GetStringProperty("PartRev.ApprovedBy");
                approvedByProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> effectiveDateProperty;
        public DateTime? EffectiveDate
        {
            get
            {
                if (effectiveDateProperty == null)
                    effectiveDateProperty = GetNullableDateTimeProperty("PartRev.EffectiveDate");
                return effectiveDateProperty.Value;
            }
            set
            {
                if (effectiveDateProperty == null)
                    effectiveDateProperty = GetNullableDateTimeProperty("PartRev.EffectiveDate");
                effectiveDateProperty.Value = value;
            }
        }

        protected RowProperty<int> autoRecOprProperty;
        public int AutoRecOpr
        {
            get
            {
                if (autoRecOprProperty == null)
                    autoRecOprProperty = GetIntegerProperty("PartRev.AutoRecOpr");
                return autoRecOprProperty.Value;
            }
            set
            {
                if (autoRecOprProperty == null)
                    autoRecOprProperty = GetIntegerProperty("PartRev.AutoRecOpr");
                autoRecOprProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRLaborCostProperty;
        public decimal TLRLaborCost
        {
            get
            {
                if (tLRLaborCostProperty == null)
                    tLRLaborCostProperty = GetDecimalProperty("PartRev.TLRLaborCost");
                return tLRLaborCostProperty.Value;
            }
            set
            {
                if (tLRLaborCostProperty == null)
                    tLRLaborCostProperty = GetDecimalProperty("PartRev.TLRLaborCost");
                tLRLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRBurdenCostProperty;
        public decimal TLRBurdenCost
        {
            get
            {
                if (tLRBurdenCostProperty == null)
                    tLRBurdenCostProperty = GetDecimalProperty("PartRev.TLRBurdenCost");
                return tLRBurdenCostProperty.Value;
            }
            set
            {
                if (tLRBurdenCostProperty == null)
                    tLRBurdenCostProperty = GetDecimalProperty("PartRev.TLRBurdenCost");
                tLRBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRMaterialCostProperty;
        public decimal TLRMaterialCost
        {
            get
            {
                if (tLRMaterialCostProperty == null)
                    tLRMaterialCostProperty = GetDecimalProperty("PartRev.TLRMaterialCost");
                return tLRMaterialCostProperty.Value;
            }
            set
            {
                if (tLRMaterialCostProperty == null)
                    tLRMaterialCostProperty = GetDecimalProperty("PartRev.TLRMaterialCost");
                tLRMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRSubcontractCostProperty;
        public decimal TLRSubcontractCost
        {
            get
            {
                if (tLRSubcontractCostProperty == null)
                    tLRSubcontractCostProperty = GetDecimalProperty("PartRev.TLRSubcontractCost");
                return tLRSubcontractCostProperty.Value;
            }
            set
            {
                if (tLRSubcontractCostProperty == null)
                    tLRSubcontractCostProperty = GetDecimalProperty("PartRev.TLRSubcontractCost");
                tLRSubcontractCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRSetupLaborCostProperty;
        public decimal TLRSetupLaborCost
        {
            get
            {
                if (tLRSetupLaborCostProperty == null)
                    tLRSetupLaborCostProperty = GetDecimalProperty("PartRev.TLRSetupLaborCost");
                return tLRSetupLaborCostProperty.Value;
            }
            set
            {
                if (tLRSetupLaborCostProperty == null)
                    tLRSetupLaborCostProperty = GetDecimalProperty("PartRev.TLRSetupLaborCost");
                tLRSetupLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRSetupBurdenCostProperty;
        public decimal TLRSetupBurdenCost
        {
            get
            {
                if (tLRSetupBurdenCostProperty == null)
                    tLRSetupBurdenCostProperty = GetDecimalProperty("PartRev.TLRSetupBurdenCost");
                return tLRSetupBurdenCostProperty.Value;
            }
            set
            {
                if (tLRSetupBurdenCostProperty == null)
                    tLRSetupBurdenCostProperty = GetDecimalProperty("PartRev.TLRSetupBurdenCost");
                tLRSetupBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRLaborCostProperty;
        public decimal LLRLaborCost
        {
            get
            {
                if (lLRLaborCostProperty == null)
                    lLRLaborCostProperty = GetDecimalProperty("PartRev.LLRLaborCost");
                return lLRLaborCostProperty.Value;
            }
            set
            {
                if (lLRLaborCostProperty == null)
                    lLRLaborCostProperty = GetDecimalProperty("PartRev.LLRLaborCost");
                lLRLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRBurdenCostProperty;
        public decimal LLRBurdenCost
        {
            get
            {
                if (lLRBurdenCostProperty == null)
                    lLRBurdenCostProperty = GetDecimalProperty("PartRev.LLRBurdenCost");
                return lLRBurdenCostProperty.Value;
            }
            set
            {
                if (lLRBurdenCostProperty == null)
                    lLRBurdenCostProperty = GetDecimalProperty("PartRev.LLRBurdenCost");
                lLRBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRMaterialCostProperty;
        public decimal LLRMaterialCost
        {
            get
            {
                if (lLRMaterialCostProperty == null)
                    lLRMaterialCostProperty = GetDecimalProperty("PartRev.LLRMaterialCost");
                return lLRMaterialCostProperty.Value;
            }
            set
            {
                if (lLRMaterialCostProperty == null)
                    lLRMaterialCostProperty = GetDecimalProperty("PartRev.LLRMaterialCost");
                lLRMaterialCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRSetupLaborCostProperty;
        public decimal LLRSetupLaborCost
        {
            get
            {
                if (lLRSetupLaborCostProperty == null)
                    lLRSetupLaborCostProperty = GetDecimalProperty("PartRev.LLRSetupLaborCost");
                return lLRSetupLaborCostProperty.Value;
            }
            set
            {
                if (lLRSetupLaborCostProperty == null)
                    lLRSetupLaborCostProperty = GetDecimalProperty("PartRev.LLRSetupLaborCost");
                lLRSetupLaborCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRSetupBurdenCostProperty;
        public decimal LLRSetupBurdenCost
        {
            get
            {
                if (lLRSetupBurdenCostProperty == null)
                    lLRSetupBurdenCostProperty = GetDecimalProperty("PartRev.LLRSetupBurdenCost");
                return lLRSetupBurdenCostProperty.Value;
            }
            set
            {
                if (lLRSetupBurdenCostProperty == null)
                    lLRSetupBurdenCostProperty = GetDecimalProperty("PartRev.LLRSetupBurdenCost");
                lLRSetupBurdenCostProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> rollupDateProperty;
        public DateTime? RollupDate
        {
            get
            {
                if (rollupDateProperty == null)
                    rollupDateProperty = GetNullableDateTimeProperty("PartRev.RollupDate");
                return rollupDateProperty.Value;
            }
            set
            {
                if (rollupDateProperty == null)
                    rollupDateProperty = GetNullableDateTimeProperty("PartRev.RollupDate");
                rollupDateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRSubcontractCostProperty;
        public decimal LLRSubcontractCost
        {
            get
            {
                if (lLRSubcontractCostProperty == null)
                    lLRSubcontractCostProperty = GetDecimalProperty("PartRev.LLRSubcontractCost");
                return lLRSubcontractCostProperty.Value;
            }
            set
            {
                if (lLRSubcontractCostProperty == null)
                    lLRSubcontractCostProperty = GetDecimalProperty("PartRev.LLRSubcontractCost");
                lLRSubcontractCostProperty.Value = value;
            }
        }

        protected RowProperty<string> drawNumProperty;
        public string DrawNum
        {
            get
            {
                if (drawNumProperty == null)
                    drawNumProperty = GetStringProperty("PartRev.DrawNum");
                return drawNumProperty.Value;
            }
            set
            {
                if (drawNumProperty == null)
                    drawNumProperty = GetStringProperty("PartRev.DrawNum");
                drawNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> methodProperty;
        public bool Method
        {
            get
            {
                if (methodProperty == null)
                    methodProperty = GetBooleanProperty("PartRev.Method");
                return methodProperty.Value;
            }
            set
            {
                if (methodProperty == null)
                    methodProperty = GetBooleanProperty("PartRev.Method");
                methodProperty.Value = value;
            }
        }

        protected RowProperty<string> ecoProperty;
        public string ECO
        {
            get
            {
                if (ecoProperty == null)
                    ecoProperty = GetStringProperty("PartRev.ECO");
                return ecoProperty.Value;
            }
            set
            {
                if (ecoProperty == null)
                    ecoProperty = GetStringProperty("PartRev.ECO");
                ecoProperty.Value = value;
            }
        }

        protected RowProperty<int> finalOprProperty;
        public int FinalOpr
        {
            get
            {
                if (finalOprProperty == null)
                    finalOprProperty = GetIntegerProperty("PartRev.FinalOpr");
                return finalOprProperty.Value;
            }
            set
            {
                if (finalOprProperty == null)
                    finalOprProperty = GetIntegerProperty("PartRev.FinalOpr");
                finalOprProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tLRMtlBurCostProperty;
        public decimal TLRMtlBurCost
        {
            get
            {
                if (tLRMtlBurCostProperty == null)
                    tLRMtlBurCostProperty = GetDecimalProperty("PartRev.TLRMtlBurCost");
                return tLRMtlBurCostProperty.Value;
            }
            set
            {
                if (tLRMtlBurCostProperty == null)
                    tLRMtlBurCostProperty = GetDecimalProperty("PartRev.TLRMtlBurCost");
                tLRMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<decimal> lLRMtlBurCostProperty;
        public decimal LLRMtlBurCost
        {
            get
            {
                if (lLRMtlBurCostProperty == null)
                    lLRMtlBurCostProperty = GetDecimalProperty("PartRev.LLRMtlBurCost");
                return lLRMtlBurCostProperty.Value;
            }
            set
            {
                if (lLRMtlBurCostProperty == null)
                    lLRMtlBurCostProperty = GetDecimalProperty("PartRev.LLRMtlBurCost");
                lLRMtlBurCostProperty.Value = value;
            }
        }

        protected RowProperty<string> pDMObjIDProperty;
        public string PDMObjID
        {
            get
            {
                if (pDMObjIDProperty == null)
                    pDMObjIDProperty = GetStringProperty("PartRev.PDMObjID");
                return pDMObjIDProperty.Value;
            }
            set
            {
                if (pDMObjIDProperty == null)
                    pDMObjIDProperty = GetStringProperty("PartRev.PDMObjID");
                pDMObjIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> configuredProperty;
        public bool Configured
        {
            get
            {
                if (configuredProperty == null)
                    configuredProperty = GetBooleanProperty("PartRev.Configured");
                return configuredProperty.Value;
            }
            set
            {
                if (configuredProperty == null)
                    configuredProperty = GetBooleanProperty("PartRev.Configured");
                configuredProperty.Value = value;
            }
        }

        protected RowProperty<bool> webConfiguredProperty;
        public bool WebConfigured
        {
            get
            {
                if (webConfiguredProperty == null)
                    webConfiguredProperty = GetBooleanProperty("PartRev.WebConfigured");
                return webConfiguredProperty.Value;
            }
            set
            {
                if (webConfiguredProperty == null)
                    webConfiguredProperty = GetBooleanProperty("PartRev.WebConfigured");
                webConfiguredProperty.Value = value;
            }
        }

        protected RowProperty<bool> showInputPriceProperty;
        public bool ShowInputPrice
        {
            get
            {
                if (showInputPriceProperty == null)
                    showInputPriceProperty = GetBooleanProperty("PartRev.ShowInputPrice");
                return showInputPriceProperty.Value;
            }
            set
            {
                if (showInputPriceProperty == null)
                    showInputPriceProperty = GetBooleanProperty("PartRev.ShowInputPrice");
                showInputPriceProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodProperty;
        public string AltMethod
        {
            get
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartRev.AltMethod");
                return altMethodProperty.Value;
            }
            set
            {
                if (altMethodProperty == null)
                    altMethodProperty = GetStringProperty("PartRev.AltMethod");
                altMethodProperty.Value = value;
            }
        }

        protected RowProperty<string> altMethodDescProperty;
        public string AltMethodDesc
        {
            get
            {
                if (altMethodDescProperty == null)
                    altMethodDescProperty = GetStringProperty("PartRev.AltMethodDesc");
                return altMethodDescProperty.Value;
            }
            set
            {
                if (altMethodDescProperty == null)
                    altMethodDescProperty = GetStringProperty("PartRev.AltMethodDesc");
                altMethodDescProperty.Value = value;
            }
        }

        protected RowProperty<string> plantNumProperty;
        public string PlantNum
        {
            get
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PartRev.PlantNum");
                return plantNumProperty.Value;
            }
            set
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PartRev.PlantNum");
                plantNumProperty.Value = value;
            }
        }

        protected RowProperty<string> parentAltMethodProperty;
        public string ParentAltMethod
        {
            get
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartRev.ParentAltMethod");
                return parentAltMethodProperty.Value;
            }
            set
            {
                if (parentAltMethodProperty == null)
                    parentAltMethodProperty = GetStringProperty("PartRev.ParentAltMethod");
                parentAltMethodProperty.Value = value;
            }
        }

        protected RowProperty<bool> useStagingProperty;
        public bool UseStaging
        {
            get
            {
                if (useStagingProperty == null)
                    useStagingProperty = GetBooleanProperty("PartRev.UseStaging");
                return useStagingProperty.Value;
            }
            set
            {
                if (useStagingProperty == null)
                    useStagingProperty = GetBooleanProperty("PartRev.UseStaging");
                useStagingProperty.Value = value;
            }
        }

        protected RowProperty<bool> useAltRevForPartsProperty;
        public bool UseAltRevForParts
        {
            get
            {
                if (useAltRevForPartsProperty == null)
                    useAltRevForPartsProperty = GetBooleanProperty("PartRev.UseAltRevForParts");
                return useAltRevForPartsProperty.Value;
            }
            set
            {
                if (useAltRevForPartsProperty == null)
                    useAltRevForPartsProperty = GetBooleanProperty("PartRev.UseAltRevForParts");
                useAltRevForPartsProperty.Value = value;
            }
        }

        protected RowProperty<string> ownershipStatusProperty;
        public string OwnershipStatus
        {
            get
            {
                if (ownershipStatusProperty == null)
                    ownershipStatusProperty = GetStringProperty("PartRev.OwnershipStatus");
                return ownershipStatusProperty.Value;
            }
            set
            {
                if (ownershipStatusProperty == null)
                    ownershipStatusProperty = GetStringProperty("PartRev.OwnershipStatus");
                ownershipStatusProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartRev.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartRev.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartRev.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartRev.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartRev.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartRev.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> extConfigProperty;
        public bool ExtConfig
        {
            get
            {
                if (extConfigProperty == null)
                    extConfigProperty = GetBooleanProperty("PartRev.ExtConfig");
                return extConfigProperty.Value;
            }
            set
            {
                if (extConfigProperty == null)
                    extConfigProperty = GetBooleanProperty("PartRev.ExtConfig");
                extConfigProperty.Value = value;
            }
        }

        protected RowProperty<bool> valRefDesProperty;
        public bool ValRefDes
        {
            get
            {
                if (valRefDesProperty == null)
                    valRefDesProperty = GetBooleanProperty("PartRev.ValRefDes");
                return valRefDesProperty.Value;
            }
            set
            {
                if (valRefDesProperty == null)
                    valRefDesProperty = GetBooleanProperty("PartRev.ValRefDes");
                valRefDesProperty.Value = value;
            }
        }

        protected RowProperty<bool> pcEntprsConfProperty;
        public bool PcEntprsConf
        {
            get
            {
                if (pcEntprsConfProperty == null)
                    pcEntprsConfProperty = GetBooleanProperty("PartRev.PcEntprsConf");
                return pcEntprsConfProperty.Value;
            }
            set
            {
                if (pcEntprsConfProperty == null)
                    pcEntprsConfProperty = GetBooleanProperty("PartRev.PcEntprsConf");
                pcEntprsConfProperty.Value = value;
            }
        }

        protected RowProperty<bool> pcGlobalPartProperty;
        public bool PcGlobalPart
        {
            get
            {
                if (pcGlobalPartProperty == null)
                    pcGlobalPartProperty = GetBooleanProperty("PartRev.PcGlobalPart");
                return pcGlobalPartProperty.Value;
            }
            set
            {
                if (pcGlobalPartProperty == null)
                    pcGlobalPartProperty = GetBooleanProperty("PartRev.PcGlobalPart");
                pcGlobalPartProperty.Value = value;
            }
        }

        protected RowProperty<bool> globalRevProperty;
        public bool GlobalRev
        {
            get
            {
                if (globalRevProperty == null)
                    globalRevProperty = GetBooleanProperty("PartRev.GlobalRev");
                return globalRevProperty.Value;
            }
            set
            {
                if (globalRevProperty == null)
                    globalRevProperty = GetBooleanProperty("PartRev.GlobalRev");
                globalRevProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartRev.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartRev.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartUOM Table

    [Serializable()]
    public abstract partial class PartUOMBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartUOMBase<T, R>, new()
        where R : PartUOMRow, new()
    {
        protected PartUOMBase() : base() { }

        protected static Schema.PartUOM schemaTable;
        public static Schema.PartUOM SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartUOM)E9Schema.Instance.TablesDictionary["PartUOM"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartUOM.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartUOM.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartUOM.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByUOMCodeCriteria;
        public static T FillByUOMCode(DataContext context, string companyNum, string partNum, string uOMCode, params string[] columnNames)
        {
            if (fillByUOMCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartUOM.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartUOM.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartUOM.UOMCode]));
                fillByUOMCodeCriteria = list.ToArray();
            }
            fillByUOMCodeCriteria[0].Value = companyNum;
            fillByUOMCodeCriteria[1].Value = partNum;
            fillByUOMCodeCriteria[2].Value = uOMCode;
            return EditTable<T, R>.Fetch(context, fillByUOMCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartUOM : PartUOMBase<PartUOM, PartUOMRow>
    {
        public PartUOM() : base() { }
    }

    #region PartUOMRow

    [Serializable()]
    public class PartUOMRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartUOM.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartUOM.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartUOM.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartUOM.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMCodeProperty;
        public string UOMCode
        {
            get
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("PartUOM.UOMCode");
                return uOMCodeProperty.Value;
            }
            set
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("PartUOM.UOMCode");
                uOMCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> convFactorProperty;
        public decimal ConvFactor
        {
            get
            {
                if (convFactorProperty == null)
                    convFactorProperty = GetDecimalProperty("PartUOM.ConvFactor");
                return convFactorProperty.Value;
            }
            set
            {
                if (convFactorProperty == null)
                    convFactorProperty = GetDecimalProperty("PartUOM.ConvFactor");
                convFactorProperty.Value = value;
            }
        }

        protected RowProperty<bool> activeProperty;
        public bool Active
        {
            get
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("PartUOM.Active");
                return activeProperty.Value;
            }
            set
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("PartUOM.Active");
                activeProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackOnHandProperty;
        public bool TrackOnHand
        {
            get
            {
                if (trackOnHandProperty == null)
                    trackOnHandProperty = GetBooleanProperty("PartUOM.TrackOnHand");
                return trackOnHandProperty.Value;
            }
            set
            {
                if (trackOnHandProperty == null)
                    trackOnHandProperty = GetBooleanProperty("PartUOM.TrackOnHand");
                trackOnHandProperty.Value = value;
            }
        }

        protected RowProperty<decimal> netVolumeProperty;
        public decimal NetVolume
        {
            get
            {
                if (netVolumeProperty == null)
                    netVolumeProperty = GetDecimalProperty("PartUOM.NetVolume");
                return netVolumeProperty.Value;
            }
            set
            {
                if (netVolumeProperty == null)
                    netVolumeProperty = GetDecimalProperty("PartUOM.NetVolume");
                netVolumeProperty.Value = value;
            }
        }

        protected RowProperty<string> netVolumeUOMProperty;
        public string NetVolumeUOM
        {
            get
            {
                if (netVolumeUOMProperty == null)
                    netVolumeUOMProperty = GetStringProperty("PartUOM.NetVolumeUOM");
                return netVolumeUOMProperty.Value;
            }
            set
            {
                if (netVolumeUOMProperty == null)
                    netVolumeUOMProperty = GetStringProperty("PartUOM.NetVolumeUOM");
                netVolumeUOMProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartUOM.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartUOM.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartUOM.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartUOM.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartUOM.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartUOM.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> hasBeenUsedProperty;
        public bool HasBeenUsed
        {
            get
            {
                if (hasBeenUsedProperty == null)
                    hasBeenUsedProperty = GetBooleanProperty("PartUOM.HasBeenUsed");
                return hasBeenUsedProperty.Value;
            }
            set
            {
                if (hasBeenUsedProperty == null)
                    hasBeenUsedProperty = GetBooleanProperty("PartUOM.HasBeenUsed");
                hasBeenUsedProperty.Value = value;
            }
        }

        protected RowProperty<string> convOperatorProperty;
        public string ConvOperator
        {
            get
            {
                if (convOperatorProperty == null)
                    convOperatorProperty = GetStringProperty("PartUOM.ConvOperator");
                return convOperatorProperty.Value;
            }
            set
            {
                if (convOperatorProperty == null)
                    convOperatorProperty = GetStringProperty("PartUOM.ConvOperator");
                convOperatorProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartUOM.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartUOM.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PartWhse Table

    [Serializable()]
    public abstract partial class PartWhseBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PartWhseBase<T, R>, new()
        where R : PartWhseRow, new()
    {
        protected PartWhseBase() : base() { }

        protected static Schema.PartWhse schemaTable;
        public static Schema.PartWhse SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PartWhse)E9Schema.Instance.TablesDictionary["PartWhse"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartWhse.CompanyNum]));
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartWhse.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartWhse.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByWarehouseCodeCriteria;
        public static T FillByWarehouseCode(DataContext context, string companyNum, string partNum, string warehouseCode, params string[] columnNames)
        {
            if (fillByWarehouseCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartWhse.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartWhse.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PartWhse.WarehouseCode]));
                fillByWarehouseCodeCriteria = list.ToArray();
            }
            fillByWarehouseCodeCriteria[0].Value = companyNum;
            fillByWarehouseCodeCriteria[1].Value = partNum;
            fillByWarehouseCodeCriteria[2].Value = warehouseCode;
            return EditTable<T, R>.Fetch(context, fillByWarehouseCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PartWhse : PartWhseBase<PartWhse, PartWhseRow>
    {
        public PartWhse() : base() { }
    }

    #region PartWhseRow

    [Serializable()]
    public class PartWhseRow : DataRow
    {
        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartWhse.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PartWhse.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> countedDateProperty;
        public DateTime? CountedDate
        {
            get
            {
                if (countedDateProperty == null)
                    countedDateProperty = GetNullableDateTimeProperty("PartWhse.CountedDate");
                return countedDateProperty.Value;
            }
            set
            {
                if (countedDateProperty == null)
                    countedDateProperty = GetNullableDateTimeProperty("PartWhse.CountedDate");
                countedDateProperty.Value = value;
            }
        }

        protected RowProperty<string> warehouseCodeProperty;
        public string WarehouseCode
        {
            get
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PartWhse.WarehouseCode");
                return warehouseCodeProperty.Value;
            }
            set
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PartWhse.WarehouseCode");
                warehouseCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartWhse.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PartWhse.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete900AllocQtyProperty;
        public decimal Obsolete900_AllocQty
        {
            get
            {
                if (obsolete900AllocQtyProperty == null)
                    obsolete900AllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_AllocQty");
                return obsolete900AllocQtyProperty.Value;
            }
            set
            {
                if (obsolete900AllocQtyProperty == null)
                    obsolete900AllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_AllocQty");
                obsolete900AllocQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> nonNettableQtyProperty;
        public decimal NonNettableQty
        {
            get
            {
                if (nonNettableQtyProperty == null)
                    nonNettableQtyProperty = GetDecimalProperty("PartWhse.NonNettableQty");
                return nonNettableQtyProperty.Value;
            }
            set
            {
                if (nonNettableQtyProperty == null)
                    nonNettableQtyProperty = GetDecimalProperty("PartWhse.NonNettableQty");
                nonNettableQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete900SalesAllocQtyProperty;
        public decimal Obsolete900_SalesAllocQty
        {
            get
            {
                if (obsolete900SalesAllocQtyProperty == null)
                    obsolete900SalesAllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_SalesAllocQty");
                return obsolete900SalesAllocQtyProperty.Value;
            }
            set
            {
                if (obsolete900SalesAllocQtyProperty == null)
                    obsolete900SalesAllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_SalesAllocQty");
                obsolete900SalesAllocQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesReservedQtyProperty;
        public decimal SalesReservedQty
        {
            get
            {
                if (salesReservedQtyProperty == null)
                    salesReservedQtyProperty = GetDecimalProperty("PartWhse.SalesReservedQty");
                return salesReservedQtyProperty.Value;
            }
            set
            {
                if (salesReservedQtyProperty == null)
                    salesReservedQtyProperty = GetDecimalProperty("PartWhse.SalesReservedQty");
                salesReservedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> onHandQtyProperty;
        public decimal OnHandQty
        {
            get
            {
                if (onHandQtyProperty == null)
                    onHandQtyProperty = GetDecimalProperty("PartWhse.OnHandQty");
                return onHandQtyProperty.Value;
            }
            set
            {
                if (onHandQtyProperty == null)
                    onHandQtyProperty = GetDecimalProperty("PartWhse.OnHandQty");
                onHandQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesPickedQtyProperty;
        public decimal SalesPickedQty
        {
            get
            {
                if (salesPickedQtyProperty == null)
                    salesPickedQtyProperty = GetDecimalProperty("PartWhse.SalesPickedQty");
                return salesPickedQtyProperty.Value;
            }
            set
            {
                if (salesPickedQtyProperty == null)
                    salesPickedQtyProperty = GetDecimalProperty("PartWhse.SalesPickedQty");
                salesPickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesPickingQtyProperty;
        public decimal SalesPickingQty
        {
            get
            {
                if (salesPickingQtyProperty == null)
                    salesPickingQtyProperty = GetDecimalProperty("PartWhse.SalesPickingQty");
                return salesPickingQtyProperty.Value;
            }
            set
            {
                if (salesPickingQtyProperty == null)
                    salesPickingQtyProperty = GetDecimalProperty("PartWhse.SalesPickingQty");
                salesPickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobReservedQtyProperty;
        public decimal JobReservedQty
        {
            get
            {
                if (jobReservedQtyProperty == null)
                    jobReservedQtyProperty = GetDecimalProperty("PartWhse.JobReservedQty");
                return jobReservedQtyProperty.Value;
            }
            set
            {
                if (jobReservedQtyProperty == null)
                    jobReservedQtyProperty = GetDecimalProperty("PartWhse.JobReservedQty");
                jobReservedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete900JobUnfirmAllocQtyProperty;
        public decimal Obsolete900_JobUnfirmAllocQty
        {
            get
            {
                if (obsolete900JobUnfirmAllocQtyProperty == null)
                    obsolete900JobUnfirmAllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_JobUnfirmAllocQty");
                return obsolete900JobUnfirmAllocQtyProperty.Value;
            }
            set
            {
                if (obsolete900JobUnfirmAllocQtyProperty == null)
                    obsolete900JobUnfirmAllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_JobUnfirmAllocQty");
                obsolete900JobUnfirmAllocQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> obsolete900JobAllocQtyProperty;
        public decimal Obsolete900_JobAllocQty
        {
            get
            {
                if (obsolete900JobAllocQtyProperty == null)
                    obsolete900JobAllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_JobAllocQty");
                return obsolete900JobAllocQtyProperty.Value;
            }
            set
            {
                if (obsolete900JobAllocQtyProperty == null)
                    obsolete900JobAllocQtyProperty = GetDecimalProperty("PartWhse.Obsolete900_JobAllocQty");
                obsolete900JobAllocQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> kBCodeProperty;
        public string KBCode
        {
            get
            {
                if (kBCodeProperty == null)
                    kBCodeProperty = GetStringProperty("PartWhse.KBCode");
                return kBCodeProperty.Value;
            }
            set
            {
                if (kBCodeProperty == null)
                    kBCodeProperty = GetStringProperty("PartWhse.KBCode");
                kBCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minimumQtyProperty;
        public decimal MinimumQty
        {
            get
            {
                if (minimumQtyProperty == null)
                    minimumQtyProperty = GetDecimalProperty("PartWhse.MinimumQty");
                return minimumQtyProperty.Value;
            }
            set
            {
                if (minimumQtyProperty == null)
                    minimumQtyProperty = GetDecimalProperty("PartWhse.MinimumQty");
                minimumQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> maximumQtyProperty;
        public decimal MaximumQty
        {
            get
            {
                if (maximumQtyProperty == null)
                    maximumQtyProperty = GetDecimalProperty("PartWhse.MaximumQty");
                return maximumQtyProperty.Value;
            }
            set
            {
                if (maximumQtyProperty == null)
                    maximumQtyProperty = GetDecimalProperty("PartWhse.MaximumQty");
                maximumQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> safetyQtyProperty;
        public decimal SafetyQty
        {
            get
            {
                if (safetyQtyProperty == null)
                    safetyQtyProperty = GetDecimalProperty("PartWhse.SafetyQty");
                return safetyQtyProperty.Value;
            }
            set
            {
                if (safetyQtyProperty == null)
                    safetyQtyProperty = GetDecimalProperty("PartWhse.SafetyQty");
                safetyQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> kbponumProperty;
        public int KBPONUM
        {
            get
            {
                if (kbponumProperty == null)
                    kbponumProperty = GetIntegerProperty("PartWhse.KBPONUM");
                return kbponumProperty.Value;
            }
            set
            {
                if (kbponumProperty == null)
                    kbponumProperty = GetIntegerProperty("PartWhse.KBPONUM");
                kbponumProperty.Value = value;
            }
        }

        protected RowProperty<int> kBPOLineProperty;
        public int KBPOLine
        {
            get
            {
                if (kBPOLineProperty == null)
                    kBPOLineProperty = GetIntegerProperty("PartWhse.KBPOLine");
                return kBPOLineProperty.Value;
            }
            set
            {
                if (kBPOLineProperty == null)
                    kBPOLineProperty = GetIntegerProperty("PartWhse.KBPOLine");
                kBPOLineProperty.Value = value;
            }
        }

        protected RowProperty<string> kBWarehouseCodeProperty;
        public string KBWarehouseCode
        {
            get
            {
                if (kBWarehouseCodeProperty == null)
                    kBWarehouseCodeProperty = GetStringProperty("PartWhse.KBWarehouseCode");
                return kBWarehouseCodeProperty.Value;
            }
            set
            {
                if (kBWarehouseCodeProperty == null)
                    kBWarehouseCodeProperty = GetStringProperty("PartWhse.KBWarehouseCode");
                kBWarehouseCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> kBBinNumProperty;
        public string KBBinNum
        {
            get
            {
                if (kBBinNumProperty == null)
                    kBBinNumProperty = GetStringProperty("PartWhse.KBBinNum");
                return kBBinNumProperty.Value;
            }
            set
            {
                if (kBBinNumProperty == null)
                    kBBinNumProperty = GetStringProperty("PartWhse.KBBinNum");
                kBBinNumProperty.Value = value;
            }
        }

        protected RowProperty<string> kBPlantProperty;
        public string KBPlant
        {
            get
            {
                if (kBPlantProperty == null)
                    kBPlantProperty = GetStringProperty("PartWhse.KBPlant");
                return kBPlantProperty.Value;
            }
            set
            {
                if (kBPlantProperty == null)
                    kBPlantProperty = GetStringProperty("PartWhse.KBPlant");
                kBPlantProperty.Value = value;
            }
        }

        protected RowProperty<decimal> kBQtyProperty;
        public decimal KBQty
        {
            get
            {
                if (kBQtyProperty == null)
                    kBQtyProperty = GetDecimalProperty("PartWhse.KBQty");
                return kBQtyProperty.Value;
            }
            set
            {
                if (kBQtyProperty == null)
                    kBQtyProperty = GetDecimalProperty("PartWhse.KBQty");
                kBQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartWhse.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PartWhse.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartWhse.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PartWhse.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcPcntProperty;
        public bool CalcPcnt
        {
            get
            {
                if (calcPcntProperty == null)
                    calcPcntProperty = GetBooleanProperty("PartWhse.CalcPcnt");
                return calcPcntProperty.Value;
            }
            set
            {
                if (calcPcntProperty == null)
                    calcPcntProperty = GetBooleanProperty("PartWhse.CalcPcnt");
                calcPcntProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcQtyProperty;
        public bool CalcQty
        {
            get
            {
                if (calcQtyProperty == null)
                    calcQtyProperty = GetBooleanProperty("PartWhse.CalcQty");
                return calcQtyProperty.Value;
            }
            set
            {
                if (calcQtyProperty == null)
                    calcQtyProperty = GetBooleanProperty("PartWhse.CalcQty");
                calcQtyProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcValueProperty;
        public bool CalcValue
        {
            get
            {
                if (calcValueProperty == null)
                    calcValueProperty = GetBooleanProperty("PartWhse.CalcValue");
                return calcValueProperty.Value;
            }
            set
            {
                if (calcValueProperty == null)
                    calcValueProperty = GetBooleanProperty("PartWhse.CalcValue");
                calcValueProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qtyAdjToleranceProperty;
        public decimal QtyAdjTolerance
        {
            get
            {
                if (qtyAdjToleranceProperty == null)
                    qtyAdjToleranceProperty = GetDecimalProperty("PartWhse.QtyAdjTolerance");
                return qtyAdjToleranceProperty.Value;
            }
            set
            {
                if (qtyAdjToleranceProperty == null)
                    qtyAdjToleranceProperty = GetDecimalProperty("PartWhse.QtyAdjTolerance");
                qtyAdjToleranceProperty.Value = value;
            }
        }

        protected RowProperty<bool> calcQtyAdjProperty;
        public bool CalcQtyAdj
        {
            get
            {
                if (calcQtyAdjProperty == null)
                    calcQtyAdjProperty = GetBooleanProperty("PartWhse.CalcQtyAdj");
                return calcQtyAdjProperty.Value;
            }
            set
            {
                if (calcQtyAdjProperty == null)
                    calcQtyAdjProperty = GetBooleanProperty("PartWhse.CalcQtyAdj");
                calcQtyAdjProperty.Value = value;
            }
        }

        protected RowProperty<string> minAbcProperty;
        public string MinAbc
        {
            get
            {
                if (minAbcProperty == null)
                    minAbcProperty = GetStringProperty("PartWhse.MinAbc");
                return minAbcProperty.Value;
            }
            set
            {
                if (minAbcProperty == null)
                    minAbcProperty = GetStringProperty("PartWhse.MinAbc");
                minAbcProperty.Value = value;
            }
        }

        protected RowProperty<string> systemAbcProperty;
        public string SystemAbc
        {
            get
            {
                if (systemAbcProperty == null)
                    systemAbcProperty = GetStringProperty("PartWhse.SystemAbc");
                return systemAbcProperty.Value;
            }
            set
            {
                if (systemAbcProperty == null)
                    systemAbcProperty = GetStringProperty("PartWhse.SystemAbc");
                systemAbcProperty.Value = value;
            }
        }

        protected RowProperty<bool> manualABCProperty;
        public bool ManualABC
        {
            get
            {
                if (manualABCProperty == null)
                    manualABCProperty = GetBooleanProperty("PartWhse.ManualABC");
                return manualABCProperty.Value;
            }
            set
            {
                if (manualABCProperty == null)
                    manualABCProperty = GetBooleanProperty("PartWhse.ManualABC");
                manualABCProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> lastCCDateProperty;
        public DateTime? LastCCDate
        {
            get
            {
                if (lastCCDateProperty == null)
                    lastCCDateProperty = GetNullableDateTimeProperty("PartWhse.LastCCDate");
                return lastCCDateProperty.Value;
            }
            set
            {
                if (lastCCDateProperty == null)
                    lastCCDateProperty = GetNullableDateTimeProperty("PartWhse.LastCCDate");
                lastCCDateProperty.Value = value;
            }
        }

        protected RowProperty<bool> ovrrideCountFreqProperty;
        public bool OvrrideCountFreq
        {
            get
            {
                if (ovrrideCountFreqProperty == null)
                    ovrrideCountFreqProperty = GetBooleanProperty("PartWhse.OvrrideCountFreq");
                return ovrrideCountFreqProperty.Value;
            }
            set
            {
                if (ovrrideCountFreqProperty == null)
                    ovrrideCountFreqProperty = GetBooleanProperty("PartWhse.OvrrideCountFreq");
                ovrrideCountFreqProperty.Value = value;
            }
        }

        protected RowProperty<int> countFreqProperty;
        public int CountFreq
        {
            get
            {
                if (countFreqProperty == null)
                    countFreqProperty = GetIntegerProperty("PartWhse.CountFreq");
                return countFreqProperty.Value;
            }
            set
            {
                if (countFreqProperty == null)
                    countFreqProperty = GetIntegerProperty("PartWhse.CountFreq");
                countFreqProperty.Value = value;
            }
        }

        protected RowProperty<decimal> pcntToleranceProperty;
        public decimal PcntTolerance
        {
            get
            {
                if (pcntToleranceProperty == null)
                    pcntToleranceProperty = GetDecimalProperty("PartWhse.PcntTolerance");
                return pcntToleranceProperty.Value;
            }
            set
            {
                if (pcntToleranceProperty == null)
                    pcntToleranceProperty = GetDecimalProperty("PartWhse.PcntTolerance");
                pcntToleranceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> valueToleranceProperty;
        public decimal ValueTolerance
        {
            get
            {
                if (valueToleranceProperty == null)
                    valueToleranceProperty = GetDecimalProperty("PartWhse.ValueTolerance");
                return valueToleranceProperty.Value;
            }
            set
            {
                if (valueToleranceProperty == null)
                    valueToleranceProperty = GetDecimalProperty("PartWhse.ValueTolerance");
                valueToleranceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qtyToleranceProperty;
        public decimal QtyTolerance
        {
            get
            {
                if (qtyToleranceProperty == null)
                    qtyToleranceProperty = GetDecimalProperty("PartWhse.QtyTolerance");
                return qtyToleranceProperty.Value;
            }
            set
            {
                if (qtyToleranceProperty == null)
                    qtyToleranceProperty = GetDecimalProperty("PartWhse.QtyTolerance");
                qtyToleranceProperty.Value = value;
            }
        }

        protected RowProperty<decimal> allocatedQtyProperty;
        public decimal AllocatedQty
        {
            get
            {
                if (allocatedQtyProperty == null)
                    allocatedQtyProperty = GetDecimalProperty("PartWhse.AllocatedQty");
                return allocatedQtyProperty.Value;
            }
            set
            {
                if (allocatedQtyProperty == null)
                    allocatedQtyProperty = GetDecimalProperty("PartWhse.AllocatedQty");
                allocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> reservedQtyProperty;
        public decimal ReservedQty
        {
            get
            {
                if (reservedQtyProperty == null)
                    reservedQtyProperty = GetDecimalProperty("PartWhse.ReservedQty");
                return reservedQtyProperty.Value;
            }
            set
            {
                if (reservedQtyProperty == null)
                    reservedQtyProperty = GetDecimalProperty("PartWhse.ReservedQty");
                reservedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobAllocatedQtyProperty;
        public decimal JobAllocatedQty
        {
            get
            {
                if (jobAllocatedQtyProperty == null)
                    jobAllocatedQtyProperty = GetDecimalProperty("PartWhse.JobAllocatedQty");
                return jobAllocatedQtyProperty.Value;
            }
            set
            {
                if (jobAllocatedQtyProperty == null)
                    jobAllocatedQtyProperty = GetDecimalProperty("PartWhse.JobAllocatedQty");
                jobAllocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> unfirmJobDemandQtyProperty;
        public decimal UnfirmJobDemandQty
        {
            get
            {
                if (unfirmJobDemandQtyProperty == null)
                    unfirmJobDemandQtyProperty = GetDecimalProperty("PartWhse.UnfirmJobDemandQty");
                return unfirmJobDemandQtyProperty.Value;
            }
            set
            {
                if (unfirmJobDemandQtyProperty == null)
                    unfirmJobDemandQtyProperty = GetDecimalProperty("PartWhse.UnfirmJobDemandQty");
                unfirmJobDemandQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdReservedQtyProperty;
        public decimal TFOrdReservedQty
        {
            get
            {
                if (tFOrdReservedQtyProperty == null)
                    tFOrdReservedQtyProperty = GetDecimalProperty("PartWhse.TFOrdReservedQty");
                return tFOrdReservedQtyProperty.Value;
            }
            set
            {
                if (tFOrdReservedQtyProperty == null)
                    tFOrdReservedQtyProperty = GetDecimalProperty("PartWhse.TFOrdReservedQty");
                tFOrdReservedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdAllocatedQtyProperty;
        public decimal TFOrdAllocatedQty
        {
            get
            {
                if (tFOrdAllocatedQtyProperty == null)
                    tFOrdAllocatedQtyProperty = GetDecimalProperty("PartWhse.TFOrdAllocatedQty");
                return tFOrdAllocatedQtyProperty.Value;
            }
            set
            {
                if (tFOrdAllocatedQtyProperty == null)
                    tFOrdAllocatedQtyProperty = GetDecimalProperty("PartWhse.TFOrdAllocatedQty");
                tFOrdAllocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesAllocatedQtyProperty;
        public decimal SalesAllocatedQty
        {
            get
            {
                if (salesAllocatedQtyProperty == null)
                    salesAllocatedQtyProperty = GetDecimalProperty("PartWhse.SalesAllocatedQty");
                return salesAllocatedQtyProperty.Value;
            }
            set
            {
                if (salesAllocatedQtyProperty == null)
                    salesAllocatedQtyProperty = GetDecimalProperty("PartWhse.SalesAllocatedQty");
                salesAllocatedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> salesDemandQtyProperty;
        public decimal SalesDemandQty
        {
            get
            {
                if (salesDemandQtyProperty == null)
                    salesDemandQtyProperty = GetDecimalProperty("PartWhse.SalesDemandQty");
                return salesDemandQtyProperty.Value;
            }
            set
            {
                if (salesDemandQtyProperty == null)
                    salesDemandQtyProperty = GetDecimalProperty("PartWhse.SalesDemandQty");
                salesDemandQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobDemandQtyProperty;
        public decimal JobDemandQty
        {
            get
            {
                if (jobDemandQtyProperty == null)
                    jobDemandQtyProperty = GetDecimalProperty("PartWhse.JobDemandQty");
                return jobDemandQtyProperty.Value;
            }
            set
            {
                if (jobDemandQtyProperty == null)
                    jobDemandQtyProperty = GetDecimalProperty("PartWhse.JobDemandQty");
                jobDemandQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobPickingQtyProperty;
        public decimal JobPickingQty
        {
            get
            {
                if (jobPickingQtyProperty == null)
                    jobPickingQtyProperty = GetDecimalProperty("PartWhse.JobPickingQty");
                return jobPickingQtyProperty.Value;
            }
            set
            {
                if (jobPickingQtyProperty == null)
                    jobPickingQtyProperty = GetDecimalProperty("PartWhse.JobPickingQty");
                jobPickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> jobPickedQtyProperty;
        public decimal JobPickedQty
        {
            get
            {
                if (jobPickedQtyProperty == null)
                    jobPickedQtyProperty = GetDecimalProperty("PartWhse.JobPickedQty");
                return jobPickedQtyProperty.Value;
            }
            set
            {
                if (jobPickedQtyProperty == null)
                    jobPickedQtyProperty = GetDecimalProperty("PartWhse.JobPickedQty");
                jobPickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdDemandQtyProperty;
        public decimal TFOrdDemandQty
        {
            get
            {
                if (tFOrdDemandQtyProperty == null)
                    tFOrdDemandQtyProperty = GetDecimalProperty("PartWhse.TFOrdDemandQty");
                return tFOrdDemandQtyProperty.Value;
            }
            set
            {
                if (tFOrdDemandQtyProperty == null)
                    tFOrdDemandQtyProperty = GetDecimalProperty("PartWhse.TFOrdDemandQty");
                tFOrdDemandQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdPickingQtyProperty;
        public decimal TFOrdPickingQty
        {
            get
            {
                if (tFOrdPickingQtyProperty == null)
                    tFOrdPickingQtyProperty = GetDecimalProperty("PartWhse.TFOrdPickingQty");
                return tFOrdPickingQtyProperty.Value;
            }
            set
            {
                if (tFOrdPickingQtyProperty == null)
                    tFOrdPickingQtyProperty = GetDecimalProperty("PartWhse.TFOrdPickingQty");
                tFOrdPickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> tFOrdPickedQtyProperty;
        public decimal TFOrdPickedQty
        {
            get
            {
                if (tFOrdPickedQtyProperty == null)
                    tFOrdPickedQtyProperty = GetDecimalProperty("PartWhse.TFOrdPickedQty");
                return tFOrdPickedQtyProperty.Value;
            }
            set
            {
                if (tFOrdPickedQtyProperty == null)
                    tFOrdPickedQtyProperty = GetDecimalProperty("PartWhse.TFOrdPickedQty");
                tFOrdPickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> demandQtyProperty;
        public decimal DemandQty
        {
            get
            {
                if (demandQtyProperty == null)
                    demandQtyProperty = GetDecimalProperty("PartWhse.DemandQty");
                return demandQtyProperty.Value;
            }
            set
            {
                if (demandQtyProperty == null)
                    demandQtyProperty = GetDecimalProperty("PartWhse.DemandQty");
                demandQtyProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartWhse.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PartWhse.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<decimal> pickingQtyProperty;
        public decimal PickingQty
        {
            get
            {
                if (pickingQtyProperty == null)
                    pickingQtyProperty = GetDecimalProperty("PartWhse.PickingQty");
                return pickingQtyProperty.Value;
            }
            set
            {
                if (pickingQtyProperty == null)
                    pickingQtyProperty = GetDecimalProperty("PartWhse.PickingQty");
                pickingQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> pickedQtyProperty;
        public decimal PickedQty
        {
            get
            {
                if (pickedQtyProperty == null)
                    pickedQtyProperty = GetDecimalProperty("PartWhse.PickedQty");
                return pickedQtyProperty.Value;
            }
            set
            {
                if (pickedQtyProperty == null)
                    pickedQtyProperty = GetDecimalProperty("PartWhse.PickedQty");
                pickedQtyProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartWhse.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PartWhse.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region PlantWhse Table

    [Serializable()]
    public abstract partial class PlantWhseBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : PlantWhseBase<T, R>, new()
        where R : PlantWhseRow, new()
    {
        protected PlantWhseBase() : base() { }

        protected static Schema.PlantWhse schemaTable;
        public static Schema.PlantWhse SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.PlantWhse)E9Schema.Instance.TablesDictionary["PlantWhse"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPlantNumCriteria;
        public static T FillByPlantNum(DataContext context, string companyNum, string plantNum, params string[] columnNames)
        {
            if (fillByPlantNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.PlantNum]));
                fillByPlantNumCriteria = list.ToArray();
            }
            fillByPlantNumCriteria[0].Value = companyNum;
            fillByPlantNumCriteria[1].Value = plantNum;
            return EditTable<T, R>.Fetch(context, fillByPlantNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPartNumCriteria;
        public static T FillByPartNum(DataContext context, string companyNum, string plantNum, string partNum, params string[] columnNames)
        {
            if (fillByPartNumCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.PlantNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.PartNum]));
                fillByPartNumCriteria = list.ToArray();
            }
            fillByPartNumCriteria[0].Value = companyNum;
            fillByPartNumCriteria[1].Value = plantNum;
            fillByPartNumCriteria[2].Value = partNum;
            return EditTable<T, R>.Fetch(context, fillByPartNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByWarehouseCodeCriteria;
        public static T FillByWarehouseCode(DataContext context, string companyNum, string plantNum, string partNum, string warehouseCode, params string[] columnNames)
        {
            if (fillByWarehouseCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.PlantNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.PlantWhse.WarehouseCode]));
                fillByWarehouseCodeCriteria = list.ToArray();
            }
            fillByWarehouseCodeCriteria[0].Value = companyNum;
            fillByWarehouseCodeCriteria[1].Value = plantNum;
            fillByWarehouseCodeCriteria[2].Value = partNum;
            fillByWarehouseCodeCriteria[3].Value = warehouseCode;
            return EditTable<T, R>.Fetch(context, fillByWarehouseCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class PlantWhse : PlantWhseBase<PlantWhse, PlantWhseRow>
    {
        public PlantWhse() : base() { }
    }

    #region PlantWhseRow

    [Serializable()]
    public class PlantWhseRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PlantWhse.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("PlantWhse.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> plantNumProperty;
        public string PlantNum
        {
            get
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PlantWhse.PlantNum");
                return plantNumProperty.Value;
            }
            set
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("PlantWhse.PlantNum");
                plantNumProperty.Value = value;
            }
        }

        protected RowProperty<string> warehouseCodeProperty;
        public string WarehouseCode
        {
            get
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PlantWhse.WarehouseCode");
                return warehouseCodeProperty.Value;
            }
            set
            {
                if (warehouseCodeProperty == null)
                    warehouseCodeProperty = GetStringProperty("PlantWhse.WarehouseCode");
                warehouseCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PlantWhse.PartNum");
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                    partNumProperty = GetStringProperty("PlantWhse.PartNum");
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> primBinProperty;
        public string PrimBin
        {
            get
            {
                if (primBinProperty == null)
                    primBinProperty = GetStringProperty("PlantWhse.PrimBin");
                return primBinProperty.Value;
            }
            set
            {
                if (primBinProperty == null)
                    primBinProperty = GetStringProperty("PlantWhse.PrimBin");
                primBinProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PlantWhse.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("PlantWhse.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PlantWhse.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("PlantWhse.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PlantWhse.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("PlantWhse.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PlantWhse.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("PlantWhse.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region Resource Table

    [Serializable()]
    public abstract partial class ResourceBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : ResourceBase<T, R>, new()
        where R : ResourceRow, new()
    {
        protected ResourceBase() : base() { }

        protected static Schema.Resource schemaTable;
        public static Schema.Resource SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.Resource)E9Schema.Instance.TablesDictionary["Resource"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Resource.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByResourceIDCriteria;
        public static T FillByResourceID(DataContext context, string companyNum, string resourceID, params string[] columnNames)
        {
            if (fillByResourceIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Resource.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Resource.ResourceID]));
                fillByResourceIDCriteria = list.ToArray();
            }
            fillByResourceIDCriteria[0].Value = companyNum;
            fillByResourceIDCriteria[1].Value = resourceID;
            return EditTable<T, R>.Fetch(context, fillByResourceIDCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class Resource : ResourceBase<Resource, ResourceRow>
    {
        public Resource() : base() { }
    }

    #region ResourceRow

    [Serializable()]
    public class ResourceRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Resource.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("Resource.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceIDProperty;
        public string ResourceID
        {
            get
            {
                if (resourceIDProperty == null)
                    resourceIDProperty = GetStringProperty("Resource.ResourceID");
                return resourceIDProperty.Value;
            }
            set
            {
                if (resourceIDProperty == null)
                    resourceIDProperty = GetStringProperty("Resource.ResourceID");
                resourceIDProperty.Value = value;
            }
        }

        protected RowProperty<string> descriptionProperty;
        public string Description
        {
            get
            {
                if (descriptionProperty == null)
                    descriptionProperty = GetStringProperty("Resource.Description");
                return descriptionProperty.Value;
            }
            set
            {
                if (descriptionProperty == null)
                    descriptionProperty = GetStringProperty("Resource.Description");
                descriptionProperty.Value = value;
            }
        }

        protected RowProperty<DateTime?> nextMaintDateProperty;
        public DateTime? NextMaintDate
        {
            get
            {
                if (nextMaintDateProperty == null)
                    nextMaintDateProperty = GetNullableDateTimeProperty("Resource.NextMaintDate");
                return nextMaintDateProperty.Value;
            }
            set
            {
                if (nextMaintDateProperty == null)
                    nextMaintDateProperty = GetNullableDateTimeProperty("Resource.NextMaintDate");
                nextMaintDateProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceGrpIDProperty;
        public string ResourceGrpID
        {
            get
            {
                if (resourceGrpIDProperty == null)
                    resourceGrpIDProperty = GetStringProperty("Resource.ResourceGrpID");
                return resourceGrpIDProperty.Value;
            }
            set
            {
                if (resourceGrpIDProperty == null)
                    resourceGrpIDProperty = GetStringProperty("Resource.ResourceGrpID");
                resourceGrpIDProperty.Value = value;
            }
        }

        protected RowProperty<string> outputWhseProperty;
        public string OutputWhse
        {
            get
            {
                if (outputWhseProperty == null)
                    outputWhseProperty = GetStringProperty("Resource.OutputWhse");
                return outputWhseProperty.Value;
            }
            set
            {
                if (outputWhseProperty == null)
                    outputWhseProperty = GetStringProperty("Resource.OutputWhse");
                outputWhseProperty.Value = value;
            }
        }

        protected RowProperty<string> outputBinNumProperty;
        public string OutputBinNum
        {
            get
            {
                if (outputBinNumProperty == null)
                    outputBinNumProperty = GetStringProperty("Resource.OutputBinNum");
                return outputBinNumProperty.Value;
            }
            set
            {
                if (outputBinNumProperty == null)
                    outputBinNumProperty = GetStringProperty("Resource.OutputBinNum");
                outputBinNumProperty.Value = value;
            }
        }

        protected RowProperty<string> backflushWhseProperty;
        public string BackflushWhse
        {
            get
            {
                if (backflushWhseProperty == null)
                    backflushWhseProperty = GetStringProperty("Resource.BackflushWhse");
                return backflushWhseProperty.Value;
            }
            set
            {
                if (backflushWhseProperty == null)
                    backflushWhseProperty = GetStringProperty("Resource.BackflushWhse");
                backflushWhseProperty.Value = value;
            }
        }

        protected RowProperty<string> backflushBinNumProperty;
        public string BackflushBinNum
        {
            get
            {
                if (backflushBinNumProperty == null)
                    backflushBinNumProperty = GetStringProperty("Resource.BackflushBinNum");
                return backflushBinNumProperty.Value;
            }
            set
            {
                if (backflushBinNumProperty == null)
                    backflushBinNumProperty = GetStringProperty("Resource.BackflushBinNum");
                backflushBinNumProperty.Value = value;
            }
        }

        protected RowProperty<string> inputWhseProperty;
        public string InputWhse
        {
            get
            {
                if (inputWhseProperty == null)
                    inputWhseProperty = GetStringProperty("Resource.InputWhse");
                return inputWhseProperty.Value;
            }
            set
            {
                if (inputWhseProperty == null)
                    inputWhseProperty = GetStringProperty("Resource.InputWhse");
                inputWhseProperty.Value = value;
            }
        }

        protected RowProperty<string> inputBinNumProperty;
        public string InputBinNum
        {
            get
            {
                if (inputBinNumProperty == null)
                    inputBinNumProperty = GetStringProperty("Resource.InputBinNum");
                return inputBinNumProperty.Value;
            }
            set
            {
                if (inputBinNumProperty == null)
                    inputBinNumProperty = GetStringProperty("Resource.InputBinNum");
                inputBinNumProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceTypeProperty;
        public string ResourceType
        {
            get
            {
                if (resourceTypeProperty == null)
                    resourceTypeProperty = GetStringProperty("Resource.ResourceType");
                return resourceTypeProperty.Value;
            }
            set
            {
                if (resourceTypeProperty == null)
                    resourceTypeProperty = GetStringProperty("Resource.ResourceType");
                resourceTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> trackProdQtyProperty;
        public bool TrackProdQty
        {
            get
            {
                if (trackProdQtyProperty == null)
                    trackProdQtyProperty = GetBooleanProperty("Resource.TrackProdQty");
                return trackProdQtyProperty.Value;
            }
            set
            {
                if (trackProdQtyProperty == null)
                    trackProdQtyProperty = GetBooleanProperty("Resource.TrackProdQty");
                trackProdQtyProperty.Value = value;
            }
        }

        protected RowProperty<string> linkedPartProperty;
        public string LinkedPart
        {
            get
            {
                if (linkedPartProperty == null)
                    linkedPartProperty = GetStringProperty("Resource.LinkedPart");
                return linkedPartProperty.Value;
            }
            set
            {
                if (linkedPartProperty == null)
                    linkedPartProperty = GetStringProperty("Resource.LinkedPart");
                linkedPartProperty.Value = value;
            }
        }

        protected RowProperty<string> assetNumProperty;
        public string AssetNum
        {
            get
            {
                if (assetNumProperty == null)
                    assetNumProperty = GetStringProperty("Resource.AssetNum");
                return assetNumProperty.Value;
            }
            set
            {
                if (assetNumProperty == null)
                    assetNumProperty = GetStringProperty("Resource.AssetNum");
                assetNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> inactiveProperty;
        public bool Inactive
        {
            get
            {
                if (inactiveProperty == null)
                    inactiveProperty = GetBooleanProperty("Resource.Inactive");
                return inactiveProperty.Value;
            }
            set
            {
                if (inactiveProperty == null)
                    inactiveProperty = GetBooleanProperty("Resource.Inactive");
                inactiveProperty.Value = value;
            }
        }

        protected RowProperty<decimal> concurrentCapacityProperty;
        public decimal ConcurrentCapacity
        {
            get
            {
                if (concurrentCapacityProperty == null)
                    concurrentCapacityProperty = GetDecimalProperty("Resource.ConcurrentCapacity");
                return concurrentCapacityProperty.Value;
            }
            set
            {
                if (concurrentCapacityProperty == null)
                    concurrentCapacityProperty = GetDecimalProperty("Resource.ConcurrentCapacity");
                concurrentCapacityProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodBurRateProperty;
        public decimal ProdBurRate
        {
            get
            {
                if (prodBurRateProperty == null)
                    prodBurRateProperty = GetDecimalProperty("Resource.ProdBurRate");
                return prodBurRateProperty.Value;
            }
            set
            {
                if (prodBurRateProperty == null)
                    prodBurRateProperty = GetDecimalProperty("Resource.ProdBurRate");
                prodBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setupBurRateProperty;
        public decimal SetupBurRate
        {
            get
            {
                if (setupBurRateProperty == null)
                    setupBurRateProperty = GetDecimalProperty("Resource.SetupBurRate");
                return setupBurRateProperty.Value;
            }
            set
            {
                if (setupBurRateProperty == null)
                    setupBurRateProperty = GetDecimalProperty("Resource.SetupBurRate");
                setupBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qProdBurRateProperty;
        public decimal QProdBurRate
        {
            get
            {
                if (qProdBurRateProperty == null)
                    qProdBurRateProperty = GetDecimalProperty("Resource.QProdBurRate");
                return qProdBurRateProperty.Value;
            }
            set
            {
                if (qProdBurRateProperty == null)
                    qProdBurRateProperty = GetDecimalProperty("Resource.QProdBurRate");
                qProdBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qSetupBurRateProperty;
        public decimal QSetupBurRate
        {
            get
            {
                if (qSetupBurRateProperty == null)
                    qSetupBurRateProperty = GetDecimalProperty("Resource.QSetupBurRate");
                return qSetupBurRateProperty.Value;
            }
            set
            {
                if (qSetupBurRateProperty == null)
                    qSetupBurRateProperty = GetDecimalProperty("Resource.QSetupBurRate");
                qSetupBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodLabRateProperty;
        public decimal ProdLabRate
        {
            get
            {
                if (prodLabRateProperty == null)
                    prodLabRateProperty = GetDecimalProperty("Resource.ProdLabRate");
                return prodLabRateProperty.Value;
            }
            set
            {
                if (prodLabRateProperty == null)
                    prodLabRateProperty = GetDecimalProperty("Resource.ProdLabRate");
                prodLabRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setupLabRateProperty;
        public decimal SetupLabRate
        {
            get
            {
                if (setupLabRateProperty == null)
                    setupLabRateProperty = GetDecimalProperty("Resource.SetupLabRate");
                return setupLabRateProperty.Value;
            }
            set
            {
                if (setupLabRateProperty == null)
                    setupLabRateProperty = GetDecimalProperty("Resource.SetupLabRate");
                setupLabRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qProdLabRateProperty;
        public decimal QProdLabRate
        {
            get
            {
                if (qProdLabRateProperty == null)
                    qProdLabRateProperty = GetDecimalProperty("Resource.QProdLabRate");
                return qProdLabRateProperty.Value;
            }
            set
            {
                if (qProdLabRateProperty == null)
                    qProdLabRateProperty = GetDecimalProperty("Resource.QProdLabRate");
                qProdLabRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qSetupLabRateProperty;
        public decimal QSetupLabRate
        {
            get
            {
                if (qSetupLabRateProperty == null)
                    qSetupLabRateProperty = GetDecimalProperty("Resource.QSetupLabRate");
                return qSetupLabRateProperty.Value;
            }
            set
            {
                if (qSetupLabRateProperty == null)
                    qSetupLabRateProperty = GetDecimalProperty("Resource.QSetupLabRate");
                qSetupLabRateProperty.Value = value;
            }
        }

        protected RowProperty<string> qBurdenTypeProperty;
        public string QBurdenType
        {
            get
            {
                if (qBurdenTypeProperty == null)
                    qBurdenTypeProperty = GetStringProperty("Resource.QBurdenType");
                return qBurdenTypeProperty.Value;
            }
            set
            {
                if (qBurdenTypeProperty == null)
                    qBurdenTypeProperty = GetStringProperty("Resource.QBurdenType");
                qBurdenTypeProperty.Value = value;
            }
        }

        protected RowProperty<int> vendorNumProperty;
        public int VendorNum
        {
            get
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("Resource.VendorNum");
                return vendorNumProperty.Value;
            }
            set
            {
                if (vendorNumProperty == null)
                    vendorNumProperty = GetIntegerProperty("Resource.VendorNum");
                vendorNumProperty.Value = value;
            }
        }

        protected RowProperty<string> burdenTypeProperty;
        public string BurdenType
        {
            get
            {
                if (burdenTypeProperty == null)
                    burdenTypeProperty = GetStringProperty("Resource.BurdenType");
                return burdenTypeProperty.Value;
            }
            set
            {
                if (burdenTypeProperty == null)
                    burdenTypeProperty = GetStringProperty("Resource.BurdenType");
                burdenTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> getDefaultBurdenFromGroupProperty;
        public bool GetDefaultBurdenFromGroup
        {
            get
            {
                if (getDefaultBurdenFromGroupProperty == null)
                    getDefaultBurdenFromGroupProperty = GetBooleanProperty("Resource.GetDefaultBurdenFromGroup");
                return getDefaultBurdenFromGroupProperty.Value;
            }
            set
            {
                if (getDefaultBurdenFromGroupProperty == null)
                    getDefaultBurdenFromGroupProperty = GetBooleanProperty("Resource.GetDefaultBurdenFromGroup");
                getDefaultBurdenFromGroupProperty.Value = value;
            }
        }

        protected RowProperty<bool> finiteProperty;
        public bool Finite
        {
            get
            {
                if (finiteProperty == null)
                    finiteProperty = GetBooleanProperty("Resource.Finite");
                return finiteProperty.Value;
            }
            set
            {
                if (finiteProperty == null)
                    finiteProperty = GetBooleanProperty("Resource.Finite");
                finiteProperty.Value = value;
            }
        }

        protected RowProperty<string> calendarIDProperty;
        public string CalendarID
        {
            get
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("Resource.CalendarID");
                return calendarIDProperty.Value;
            }
            set
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("Resource.CalendarID");
                calendarIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> informOverloadProperty;
        public bool InformOverload
        {
            get
            {
                if (informOverloadProperty == null)
                    informOverloadProperty = GetBooleanProperty("Resource.InformOverload");
                return informOverloadProperty.Value;
            }
            set
            {
                if (informOverloadProperty == null)
                    informOverloadProperty = GetBooleanProperty("Resource.InformOverload");
                informOverloadProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minOverloadPercProperty;
        public decimal MinOverloadPerc
        {
            get
            {
                if (minOverloadPercProperty == null)
                    minOverloadPercProperty = GetDecimalProperty("Resource.MinOverloadPerc");
                return minOverloadPercProperty.Value;
            }
            set
            {
                if (minOverloadPercProperty == null)
                    minOverloadPercProperty = GetDecimalProperty("Resource.MinOverloadPerc");
                minOverloadPercProperty.Value = value;
            }
        }

        protected RowProperty<bool> allowManualOverrideProperty;
        public bool AllowManualOverride
        {
            get
            {
                if (allowManualOverrideProperty == null)
                    allowManualOverrideProperty = GetBooleanProperty("Resource.AllowManualOverride");
                return allowManualOverrideProperty.Value;
            }
            set
            {
                if (allowManualOverrideProperty == null)
                    allowManualOverrideProperty = GetBooleanProperty("Resource.AllowManualOverride");
                allowManualOverrideProperty.Value = value;
            }
        }

        protected RowProperty<decimal> moveHoursProperty;
        public decimal MoveHours
        {
            get
            {
                if (moveHoursProperty == null)
                    moveHoursProperty = GetDecimalProperty("Resource.MoveHours");
                return moveHoursProperty.Value;
            }
            set
            {
                if (moveHoursProperty == null)
                    moveHoursProperty = GetDecimalProperty("Resource.MoveHours");
                moveHoursProperty.Value = value;
            }
        }

        protected RowProperty<decimal> queHoursProperty;
        public decimal QueHours
        {
            get
            {
                if (queHoursProperty == null)
                    queHoursProperty = GetDecimalProperty("Resource.QueHours");
                return queHoursProperty.Value;
            }
            set
            {
                if (queHoursProperty == null)
                    queHoursProperty = GetDecimalProperty("Resource.QueHours");
                queHoursProperty.Value = value;
            }
        }

        protected RowProperty<bool> getDefaultMQFromGroupProperty;
        public bool GetDefaultMQFromGroup
        {
            get
            {
                if (getDefaultMQFromGroupProperty == null)
                    getDefaultMQFromGroupProperty = GetBooleanProperty("Resource.GetDefaultMQFromGroup");
                return getDefaultMQFromGroupProperty.Value;
            }
            set
            {
                if (getDefaultMQFromGroupProperty == null)
                    getDefaultMQFromGroupProperty = GetBooleanProperty("Resource.GetDefaultMQFromGroup");
                getDefaultMQFromGroupProperty.Value = value;
            }
        }

        protected RowProperty<string> opCodeProperty;
        public string OpCode
        {
            get
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("Resource.OpCode");
                return opCodeProperty.Value;
            }
            set
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("Resource.OpCode");
                opCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> opStdIDProperty;
        public string OpStdID
        {
            get
            {
                if (opStdIDProperty == null)
                    opStdIDProperty = GetStringProperty("Resource.OpStdID");
                return opStdIDProperty.Value;
            }
            set
            {
                if (opStdIDProperty == null)
                    opStdIDProperty = GetStringProperty("Resource.OpStdID");
                opStdIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> getDefaultLaborFromGroupProperty;
        public bool GetDefaultLaborFromGroup
        {
            get
            {
                if (getDefaultLaborFromGroupProperty == null)
                    getDefaultLaborFromGroupProperty = GetBooleanProperty("Resource.GetDefaultLaborFromGroup");
                return getDefaultLaborFromGroupProperty.Value;
            }
            set
            {
                if (getDefaultLaborFromGroupProperty == null)
                    getDefaultLaborFromGroupProperty = GetBooleanProperty("Resource.GetDefaultLaborFromGroup");
                getDefaultLaborFromGroupProperty.Value = value;
            }
        }

        protected RowProperty<int> finiteHorizonProperty;
        public int FiniteHorizon
        {
            get
            {
                if (finiteHorizonProperty == null)
                    finiteHorizonProperty = GetIntegerProperty("Resource.FiniteHorizon");
                return finiteHorizonProperty.Value;
            }
            set
            {
                if (finiteHorizonProperty == null)
                    finiteHorizonProperty = GetIntegerProperty("Resource.FiniteHorizon");
                finiteHorizonProperty.Value = value;
            }
        }

        protected RowProperty<bool> autoMoveProperty;
        public bool AutoMove
        {
            get
            {
                if (autoMoveProperty == null)
                    autoMoveProperty = GetBooleanProperty("Resource.AutoMove");
                return autoMoveProperty.Value;
            }
            set
            {
                if (autoMoveProperty == null)
                    autoMoveProperty = GetBooleanProperty("Resource.AutoMove");
                autoMoveProperty.Value = value;
            }
        }

        protected RowProperty<bool> splitOperationsProperty;
        public bool SplitOperations
        {
            get
            {
                if (splitOperationsProperty == null)
                    splitOperationsProperty = GetBooleanProperty("Resource.SplitOperations");
                return splitOperationsProperty.Value;
            }
            set
            {
                if (splitOperationsProperty == null)
                    splitOperationsProperty = GetBooleanProperty("Resource.SplitOperations");
                splitOperationsProperty.Value = value;
            }
        }

        protected RowProperty<decimal> dailyProdQtyProperty;
        public decimal DailyProdQty
        {
            get
            {
                if (dailyProdQtyProperty == null)
                    dailyProdQtyProperty = GetDecimalProperty("Resource.DailyProdQty");
                return dailyProdQtyProperty.Value;
            }
            set
            {
                if (dailyProdQtyProperty == null)
                    dailyProdQtyProperty = GetDecimalProperty("Resource.DailyProdQty");
                dailyProdQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> billLaborRateProperty;
        public decimal BillLaborRate
        {
            get
            {
                if (billLaborRateProperty == null)
                    billLaborRateProperty = GetDecimalProperty("Resource.BillLaborRate");
                return billLaborRateProperty.Value;
            }
            set
            {
                if (billLaborRateProperty == null)
                    billLaborRateProperty = GetDecimalProperty("Resource.BillLaborRate");
                billLaborRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> dailyProdRateProperty;
        public decimal DailyProdRate
        {
            get
            {
                if (dailyProdRateProperty == null)
                    dailyProdRateProperty = GetDecimalProperty("Resource.DailyProdRate");
                return dailyProdRateProperty.Value;
            }
            set
            {
                if (dailyProdRateProperty == null)
                    dailyProdRateProperty = GetDecimalProperty("Resource.DailyProdRate");
                dailyProdRateProperty.Value = value;
            }
        }

        protected RowProperty<bool> getDefaultWhseFromGroupProperty;
        public bool GetDefaultWhseFromGroup
        {
            get
            {
                if (getDefaultWhseFromGroupProperty == null)
                    getDefaultWhseFromGroupProperty = GetBooleanProperty("Resource.GetDefaultWhseFromGroup");
                return getDefaultWhseFromGroupProperty.Value;
            }
            set
            {
                if (getDefaultWhseFromGroupProperty == null)
                    getDefaultWhseFromGroupProperty = GetBooleanProperty("Resource.GetDefaultWhseFromGroup");
                getDefaultWhseFromGroupProperty.Value = value;
            }
        }

        protected RowProperty<bool> locationProperty;
        public bool Location
        {
            get
            {
                if (locationProperty == null)
                    locationProperty = GetBooleanProperty("Resource.Location");
                return locationProperty.Value;
            }
            set
            {
                if (locationProperty == null)
                    locationProperty = GetBooleanProperty("Resource.Location");
                locationProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("Resource.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("Resource.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("Resource.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("Resource.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("Resource.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("Resource.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("Resource.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("Resource.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region ResourceGroup Table

    [Serializable()]
    public abstract partial class ResourceGroupBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : ResourceGroupBase<T, R>, new()
        where R : ResourceGroupRow, new()
    {
        protected ResourceGroupBase() : base() { }

        protected static Schema.ResourceGroup schemaTable;
        public static Schema.ResourceGroup SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.ResourceGroup)E9Schema.Instance.TablesDictionary["ResourceGroup"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ResourceGroup.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByResourceGrpIDCriteria;
        public static T FillByResourceGrpID(DataContext context, string companyNum, string resourceGrpID, params string[] columnNames)
        {
            if (fillByResourceGrpIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ResourceGroup.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ResourceGroup.ResourceGrpID]));
                fillByResourceGrpIDCriteria = list.ToArray();
            }
            fillByResourceGrpIDCriteria[0].Value = companyNum;
            fillByResourceGrpIDCriteria[1].Value = resourceGrpID;
            return EditTable<T, R>.Fetch(context, fillByResourceGrpIDCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class ResourceGroup : ResourceGroupBase<ResourceGroup, ResourceGroupRow>
    {
        public ResourceGroup() : base() { }
    }

    #region ResourceGroupRow

    [Serializable()]
    public class ResourceGroupRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("ResourceGroup.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("ResourceGroup.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceGrpIDProperty;
        public string ResourceGrpID
        {
            get
            {
                if (resourceGrpIDProperty == null)
                    resourceGrpIDProperty = GetStringProperty("ResourceGroup.ResourceGrpID");
                return resourceGrpIDProperty.Value;
            }
            set
            {
                if (resourceGrpIDProperty == null)
                    resourceGrpIDProperty = GetStringProperty("ResourceGroup.ResourceGrpID");
                resourceGrpIDProperty.Value = value;
            }
        }

        protected RowProperty<string> descriptionProperty;
        public string Description
        {
            get
            {
                if (descriptionProperty == null)
                    descriptionProperty = GetStringProperty("ResourceGroup.Description");
                return descriptionProperty.Value;
            }
            set
            {
                if (descriptionProperty == null)
                    descriptionProperty = GetStringProperty("ResourceGroup.Description");
                descriptionProperty.Value = value;
            }
        }

        protected RowProperty<int> numberOfMachinesProperty;
        public int NumberOfMachines
        {
            get
            {
                if (numberOfMachinesProperty == null)
                    numberOfMachinesProperty = GetIntegerProperty("ResourceGroup.NumberOfMachines");
                return numberOfMachinesProperty.Value;
            }
            set
            {
                if (numberOfMachinesProperty == null)
                    numberOfMachinesProperty = GetIntegerProperty("ResourceGroup.NumberOfMachines");
                numberOfMachinesProperty.Value = value;
            }
        }

        protected RowProperty<int> schMachineProperty;
        public int SchMachine
        {
            get
            {
                if (schMachineProperty == null)
                    schMachineProperty = GetIntegerProperty("ResourceGroup.SchMachine");
                return schMachineProperty.Value;
            }
            set
            {
                if (schMachineProperty == null)
                    schMachineProperty = GetIntegerProperty("ResourceGroup.SchMachine");
                schMachineProperty.Value = value;
            }
        }

        protected RowProperty<string> burdenTypeProperty;
        public string BurdenType
        {
            get
            {
                if (burdenTypeProperty == null)
                    burdenTypeProperty = GetStringProperty("ResourceGroup.BurdenType");
                return burdenTypeProperty.Value;
            }
            set
            {
                if (burdenTypeProperty == null)
                    burdenTypeProperty = GetStringProperty("ResourceGroup.BurdenType");
                burdenTypeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> moveHoursProperty;
        public decimal MoveHours
        {
            get
            {
                if (moveHoursProperty == null)
                    moveHoursProperty = GetDecimalProperty("ResourceGroup.MoveHours");
                return moveHoursProperty.Value;
            }
            set
            {
                if (moveHoursProperty == null)
                    moveHoursProperty = GetDecimalProperty("ResourceGroup.MoveHours");
                moveHoursProperty.Value = value;
            }
        }

        protected RowProperty<string> jCDeptNumProperty;
        public string JCDeptNum
        {
            get
            {
                if (jCDeptNumProperty == null)
                    jCDeptNumProperty = GetStringProperty("ResourceGroup.JCDeptNum");
                return jCDeptNumProperty.Value;
            }
            set
            {
                if (jCDeptNumProperty == null)
                    jCDeptNumProperty = GetStringProperty("ResourceGroup.JCDeptNum");
                jCDeptNumProperty.Value = value;
            }
        }

        protected RowProperty<decimal> queHoursProperty;
        public decimal QueHours
        {
            get
            {
                if (queHoursProperty == null)
                    queHoursProperty = GetDecimalProperty("ResourceGroup.QueHours");
                return queHoursProperty.Value;
            }
            set
            {
                if (queHoursProperty == null)
                    queHoursProperty = GetDecimalProperty("ResourceGroup.QueHours");
                queHoursProperty.Value = value;
            }
        }

        protected RowProperty<string> opCodeProperty;
        public string OpCode
        {
            get
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("ResourceGroup.OpCode");
                return opCodeProperty.Value;
            }
            set
            {
                if (opCodeProperty == null)
                    opCodeProperty = GetStringProperty("ResourceGroup.OpCode");
                opCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodBurRateProperty;
        public decimal ProdBurRate
        {
            get
            {
                if (prodBurRateProperty == null)
                    prodBurRateProperty = GetDecimalProperty("ResourceGroup.ProdBurRate");
                return prodBurRateProperty.Value;
            }
            set
            {
                if (prodBurRateProperty == null)
                    prodBurRateProperty = GetDecimalProperty("ResourceGroup.ProdBurRate");
                prodBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setupBurRateProperty;
        public decimal SetupBurRate
        {
            get
            {
                if (setupBurRateProperty == null)
                    setupBurRateProperty = GetDecimalProperty("ResourceGroup.SetupBurRate");
                return setupBurRateProperty.Value;
            }
            set
            {
                if (setupBurRateProperty == null)
                    setupBurRateProperty = GetDecimalProperty("ResourceGroup.SetupBurRate");
                setupBurRateProperty.Value = value;
            }
        }

        protected RowProperty<bool> splitBurdenProperty;
        public bool SplitBurden
        {
            get
            {
                if (splitBurdenProperty == null)
                    splitBurdenProperty = GetBooleanProperty("ResourceGroup.SplitBurden");
                return splitBurdenProperty.Value;
            }
            set
            {
                if (splitBurdenProperty == null)
                    splitBurdenProperty = GetBooleanProperty("ResourceGroup.SplitBurden");
                splitBurdenProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodCrewSizeProperty;
        public decimal ProdCrewSize
        {
            get
            {
                if (prodCrewSizeProperty == null)
                    prodCrewSizeProperty = GetDecimalProperty("ResourceGroup.ProdCrewSize");
                return prodCrewSizeProperty.Value;
            }
            set
            {
                if (prodCrewSizeProperty == null)
                    prodCrewSizeProperty = GetDecimalProperty("ResourceGroup.ProdCrewSize");
                prodCrewSizeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setupCrewSizeProperty;
        public decimal SetupCrewSize
        {
            get
            {
                if (setupCrewSizeProperty == null)
                    setupCrewSizeProperty = GetDecimalProperty("ResourceGroup.SetupCrewSize");
                return setupCrewSizeProperty.Value;
            }
            set
            {
                if (setupCrewSizeProperty == null)
                    setupCrewSizeProperty = GetDecimalProperty("ResourceGroup.SetupCrewSize");
                setupCrewSizeProperty.Value = value;
            }
        }

        protected RowProperty<string> opStdIDProperty;
        public string OpStdID
        {
            get
            {
                if (opStdIDProperty == null)
                    opStdIDProperty = GetStringProperty("ResourceGroup.OpStdID");
                return opStdIDProperty.Value;
            }
            set
            {
                if (opStdIDProperty == null)
                    opStdIDProperty = GetStringProperty("ResourceGroup.OpStdID");
                opStdIDProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qProdBurRateProperty;
        public decimal QProdBurRate
        {
            get
            {
                if (qProdBurRateProperty == null)
                    qProdBurRateProperty = GetDecimalProperty("ResourceGroup.QProdBurRate");
                return qProdBurRateProperty.Value;
            }
            set
            {
                if (qProdBurRateProperty == null)
                    qProdBurRateProperty = GetDecimalProperty("ResourceGroup.QProdBurRate");
                qProdBurRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qSetupBurRateProperty;
        public decimal QSetupBurRate
        {
            get
            {
                if (qSetupBurRateProperty == null)
                    qSetupBurRateProperty = GetDecimalProperty("ResourceGroup.QSetupBurRate");
                return qSetupBurRateProperty.Value;
            }
            set
            {
                if (qSetupBurRateProperty == null)
                    qSetupBurRateProperty = GetDecimalProperty("ResourceGroup.QSetupBurRate");
                qSetupBurRateProperty.Value = value;
            }
        }

        protected RowProperty<int> reloadNumProperty;
        public int ReloadNum
        {
            get
            {
                if (reloadNumProperty == null)
                    reloadNumProperty = GetIntegerProperty("ResourceGroup.ReloadNum");
                return reloadNumProperty.Value;
            }
            set
            {
                if (reloadNumProperty == null)
                    reloadNumProperty = GetIntegerProperty("ResourceGroup.ReloadNum");
                reloadNumProperty.Value = value;
            }
        }

        protected RowProperty<string> reloadStatusProperty;
        public string ReloadStatus
        {
            get
            {
                if (reloadStatusProperty == null)
                    reloadStatusProperty = GetStringProperty("ResourceGroup.ReloadStatus");
                return reloadStatusProperty.Value;
            }
            set
            {
                if (reloadStatusProperty == null)
                    reloadStatusProperty = GetStringProperty("ResourceGroup.ReloadStatus");
                reloadStatusProperty.Value = value;
            }
        }

        protected RowProperty<bool> obsolete803FiniteProperty;
        public bool Obsolete803_Finite
        {
            get
            {
                if (obsolete803FiniteProperty == null)
                    obsolete803FiniteProperty = GetBooleanProperty("ResourceGroup.Obsolete803_Finite");
                return obsolete803FiniteProperty.Value;
            }
            set
            {
                if (obsolete803FiniteProperty == null)
                    obsolete803FiniteProperty = GetBooleanProperty("ResourceGroup.Obsolete803_Finite");
                obsolete803FiniteProperty.Value = value;
            }
        }

        protected RowProperty<string> dailyCapacityProperty;
        public string DailyCapacity
        {
            get
            {
                if (dailyCapacityProperty == null)
                    dailyCapacityProperty = GetStringProperty("ResourceGroup.DailyCapacity");
                return dailyCapacityProperty.Value;
            }
            set
            {
                if (dailyCapacityProperty == null)
                    dailyCapacityProperty = GetStringProperty("ResourceGroup.DailyCapacity");
                dailyCapacityProperty.Value = value;
            }
        }

        protected RowProperty<string> qBurdenTypeProperty;
        public string QBurdenType
        {
            get
            {
                if (qBurdenTypeProperty == null)
                    qBurdenTypeProperty = GetStringProperty("ResourceGroup.QBurdenType");
                return qBurdenTypeProperty.Value;
            }
            set
            {
                if (qBurdenTypeProperty == null)
                    qBurdenTypeProperty = GetStringProperty("ResourceGroup.QBurdenType");
                qBurdenTypeProperty.Value = value;
            }
        }

        protected RowProperty<bool> burdenEQLaborProperty;
        public bool BurdenEQLabor
        {
            get
            {
                if (burdenEQLaborProperty == null)
                    burdenEQLaborProperty = GetBooleanProperty("ResourceGroup.BurdenEQLabor");
                return burdenEQLaborProperty.Value;
            }
            set
            {
                if (burdenEQLaborProperty == null)
                    burdenEQLaborProperty = GetBooleanProperty("ResourceGroup.BurdenEQLabor");
                burdenEQLaborProperty.Value = value;
            }
        }

        protected RowProperty<string> plantNumProperty;
        public string PlantNum
        {
            get
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("ResourceGroup.PlantNum");
                return plantNumProperty.Value;
            }
            set
            {
                if (plantNumProperty == null)
                    plantNumProperty = GetStringProperty("ResourceGroup.PlantNum");
                plantNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> splitOperationsProperty;
        public bool SplitOperations
        {
            get
            {
                if (splitOperationsProperty == null)
                    splitOperationsProperty = GetBooleanProperty("ResourceGroup.SplitOperations");
                return splitOperationsProperty.Value;
            }
            set
            {
                if (splitOperationsProperty == null)
                    splitOperationsProperty = GetBooleanProperty("ResourceGroup.SplitOperations");
                splitOperationsProperty.Value = value;
            }
        }

        protected RowProperty<string> resourceTypeProperty;
        public string ResourceType
        {
            get
            {
                if (resourceTypeProperty == null)
                    resourceTypeProperty = GetStringProperty("ResourceGroup.ResourceType");
                return resourceTypeProperty.Value;
            }
            set
            {
                if (resourceTypeProperty == null)
                    resourceTypeProperty = GetStringProperty("ResourceGroup.ResourceType");
                resourceTypeProperty.Value = value;
            }
        }

        protected RowProperty<string> inputWhseProperty;
        public string InputWhse
        {
            get
            {
                if (inputWhseProperty == null)
                    inputWhseProperty = GetStringProperty("ResourceGroup.InputWhse");
                return inputWhseProperty.Value;
            }
            set
            {
                if (inputWhseProperty == null)
                    inputWhseProperty = GetStringProperty("ResourceGroup.InputWhse");
                inputWhseProperty.Value = value;
            }
        }

        protected RowProperty<string> inputBinNumProperty;
        public string InputBinNum
        {
            get
            {
                if (inputBinNumProperty == null)
                    inputBinNumProperty = GetStringProperty("ResourceGroup.InputBinNum");
                return inputBinNumProperty.Value;
            }
            set
            {
                if (inputBinNumProperty == null)
                    inputBinNumProperty = GetStringProperty("ResourceGroup.InputBinNum");
                inputBinNumProperty.Value = value;
            }
        }

        protected RowProperty<string> outputWhseProperty;
        public string OutputWhse
        {
            get
            {
                if (outputWhseProperty == null)
                    outputWhseProperty = GetStringProperty("ResourceGroup.OutputWhse");
                return outputWhseProperty.Value;
            }
            set
            {
                if (outputWhseProperty == null)
                    outputWhseProperty = GetStringProperty("ResourceGroup.OutputWhse");
                outputWhseProperty.Value = value;
            }
        }

        protected RowProperty<string> outputBinNumProperty;
        public string OutputBinNum
        {
            get
            {
                if (outputBinNumProperty == null)
                    outputBinNumProperty = GetStringProperty("ResourceGroup.OutputBinNum");
                return outputBinNumProperty.Value;
            }
            set
            {
                if (outputBinNumProperty == null)
                    outputBinNumProperty = GetStringProperty("ResourceGroup.OutputBinNum");
                outputBinNumProperty.Value = value;
            }
        }

        protected RowProperty<string> backflushWhseProperty;
        public string BackflushWhse
        {
            get
            {
                if (backflushWhseProperty == null)
                    backflushWhseProperty = GetStringProperty("ResourceGroup.BackflushWhse");
                return backflushWhseProperty.Value;
            }
            set
            {
                if (backflushWhseProperty == null)
                    backflushWhseProperty = GetStringProperty("ResourceGroup.BackflushWhse");
                backflushWhseProperty.Value = value;
            }
        }

        protected RowProperty<string> backflushBinNumProperty;
        public string BackflushBinNum
        {
            get
            {
                if (backflushBinNumProperty == null)
                    backflushBinNumProperty = GetStringProperty("ResourceGroup.BackflushBinNum");
                return backflushBinNumProperty.Value;
            }
            set
            {
                if (backflushBinNumProperty == null)
                    backflushBinNumProperty = GetStringProperty("ResourceGroup.BackflushBinNum");
                backflushBinNumProperty.Value = value;
            }
        }

        protected RowProperty<bool> informOverloadProperty;
        public bool InformOverload
        {
            get
            {
                if (informOverloadProperty == null)
                    informOverloadProperty = GetBooleanProperty("ResourceGroup.InformOverload");
                return informOverloadProperty.Value;
            }
            set
            {
                if (informOverloadProperty == null)
                    informOverloadProperty = GetBooleanProperty("ResourceGroup.InformOverload");
                informOverloadProperty.Value = value;
            }
        }

        protected RowProperty<decimal> minOverloadPercProperty;
        public decimal MinOverloadPerc
        {
            get
            {
                if (minOverloadPercProperty == null)
                    minOverloadPercProperty = GetDecimalProperty("ResourceGroup.MinOverloadPerc");
                return minOverloadPercProperty.Value;
            }
            set
            {
                if (minOverloadPercProperty == null)
                    minOverloadPercProperty = GetDecimalProperty("ResourceGroup.MinOverloadPerc");
                minOverloadPercProperty.Value = value;
            }
        }

        protected RowProperty<string> backflushEmpIDProperty;
        public string BackflushEmpID
        {
            get
            {
                if (backflushEmpIDProperty == null)
                    backflushEmpIDProperty = GetStringProperty("ResourceGroup.BackflushEmpID");
                return backflushEmpIDProperty.Value;
            }
            set
            {
                if (backflushEmpIDProperty == null)
                    backflushEmpIDProperty = GetStringProperty("ResourceGroup.BackflushEmpID");
                backflushEmpIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> subContractProperty;
        public bool SubContract
        {
            get
            {
                if (subContractProperty == null)
                    subContractProperty = GetBooleanProperty("ResourceGroup.SubContract");
                return subContractProperty.Value;
            }
            set
            {
                if (subContractProperty == null)
                    subContractProperty = GetBooleanProperty("ResourceGroup.SubContract");
                subContractProperty.Value = value;
            }
        }

        protected RowProperty<bool> autoMoveProperty;
        public bool AutoMove
        {
            get
            {
                if (autoMoveProperty == null)
                    autoMoveProperty = GetBooleanProperty("ResourceGroup.AutoMove");
                return autoMoveProperty.Value;
            }
            set
            {
                if (autoMoveProperty == null)
                    autoMoveProperty = GetBooleanProperty("ResourceGroup.AutoMove");
                autoMoveProperty.Value = value;
            }
        }

        protected RowProperty<bool> useEstimatesProperty;
        public bool UseEstimates
        {
            get
            {
                if (useEstimatesProperty == null)
                    useEstimatesProperty = GetBooleanProperty("ResourceGroup.UseEstimates");
                return useEstimatesProperty.Value;
            }
            set
            {
                if (useEstimatesProperty == null)
                    useEstimatesProperty = GetBooleanProperty("ResourceGroup.UseEstimates");
                useEstimatesProperty.Value = value;
            }
        }

        protected RowProperty<string> calendarIDProperty;
        public string CalendarID
        {
            get
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("ResourceGroup.CalendarID");
                return calendarIDProperty.Value;
            }
            set
            {
                if (calendarIDProperty == null)
                    calendarIDProperty = GetStringProperty("ResourceGroup.CalendarID");
                calendarIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> inactiveProperty;
        public bool Inactive
        {
            get
            {
                if (inactiveProperty == null)
                    inactiveProperty = GetBooleanProperty("ResourceGroup.Inactive");
                return inactiveProperty.Value;
            }
            set
            {
                if (inactiveProperty == null)
                    inactiveProperty = GetBooleanProperty("ResourceGroup.Inactive");
                inactiveProperty.Value = value;
            }
        }

        protected RowProperty<int> finiteHorizonProperty;
        public int FiniteHorizon
        {
            get
            {
                if (finiteHorizonProperty == null)
                    finiteHorizonProperty = GetIntegerProperty("ResourceGroup.FiniteHorizon");
                return finiteHorizonProperty.Value;
            }
            set
            {
                if (finiteHorizonProperty == null)
                    finiteHorizonProperty = GetIntegerProperty("ResourceGroup.FiniteHorizon");
                finiteHorizonProperty.Value = value;
            }
        }

        protected RowProperty<decimal> prodLabRateProperty;
        public decimal ProdLabRate
        {
            get
            {
                if (prodLabRateProperty == null)
                    prodLabRateProperty = GetDecimalProperty("ResourceGroup.ProdLabRate");
                return prodLabRateProperty.Value;
            }
            set
            {
                if (prodLabRateProperty == null)
                    prodLabRateProperty = GetDecimalProperty("ResourceGroup.ProdLabRate");
                prodLabRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> setupLabRateProperty;
        public decimal SetupLabRate
        {
            get
            {
                if (setupLabRateProperty == null)
                    setupLabRateProperty = GetDecimalProperty("ResourceGroup.SetupLabRate");
                return setupLabRateProperty.Value;
            }
            set
            {
                if (setupLabRateProperty == null)
                    setupLabRateProperty = GetDecimalProperty("ResourceGroup.SetupLabRate");
                setupLabRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qProdLabRateProperty;
        public decimal QProdLabRate
        {
            get
            {
                if (qProdLabRateProperty == null)
                    qProdLabRateProperty = GetDecimalProperty("ResourceGroup.QProdLabRate");
                return qProdLabRateProperty.Value;
            }
            set
            {
                if (qProdLabRateProperty == null)
                    qProdLabRateProperty = GetDecimalProperty("ResourceGroup.QProdLabRate");
                qProdLabRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> qSetupLabRateProperty;
        public decimal QSetupLabRate
        {
            get
            {
                if (qSetupLabRateProperty == null)
                    qSetupLabRateProperty = GetDecimalProperty("ResourceGroup.QSetupLabRate");
                return qSetupLabRateProperty.Value;
            }
            set
            {
                if (qSetupLabRateProperty == null)
                    qSetupLabRateProperty = GetDecimalProperty("ResourceGroup.QSetupLabRate");
                qSetupLabRateProperty.Value = value;
            }
        }

        protected RowProperty<bool> allowManualOverrideProperty;
        public bool AllowManualOverride
        {
            get
            {
                if (allowManualOverrideProperty == null)
                    allowManualOverrideProperty = GetBooleanProperty("ResourceGroup.AllowManualOverride");
                return allowManualOverrideProperty.Value;
            }
            set
            {
                if (allowManualOverrideProperty == null)
                    allowManualOverrideProperty = GetBooleanProperty("ResourceGroup.AllowManualOverride");
                allowManualOverrideProperty.Value = value;
            }
        }

        protected RowProperty<decimal> dailyProdQtyProperty;
        public decimal DailyProdQty
        {
            get
            {
                if (dailyProdQtyProperty == null)
                    dailyProdQtyProperty = GetDecimalProperty("ResourceGroup.DailyProdQty");
                return dailyProdQtyProperty.Value;
            }
            set
            {
                if (dailyProdQtyProperty == null)
                    dailyProdQtyProperty = GetDecimalProperty("ResourceGroup.DailyProdQty");
                dailyProdQtyProperty.Value = value;
            }
        }

        protected RowProperty<decimal> billLaborRateProperty;
        public decimal BillLaborRate
        {
            get
            {
                if (billLaborRateProperty == null)
                    billLaborRateProperty = GetDecimalProperty("ResourceGroup.BillLaborRate");
                return billLaborRateProperty.Value;
            }
            set
            {
                if (billLaborRateProperty == null)
                    billLaborRateProperty = GetDecimalProperty("ResourceGroup.BillLaborRate");
                billLaborRateProperty.Value = value;
            }
        }

        protected RowProperty<decimal> dailyProdRateProperty;
        public decimal DailyProdRate
        {
            get
            {
                if (dailyProdRateProperty == null)
                    dailyProdRateProperty = GetDecimalProperty("ResourceGroup.DailyProdRate");
                return dailyProdRateProperty.Value;
            }
            set
            {
                if (dailyProdRateProperty == null)
                    dailyProdRateProperty = GetDecimalProperty("ResourceGroup.DailyProdRate");
                dailyProdRateProperty.Value = value;
            }
        }

        protected RowProperty<bool> locationProperty;
        public bool Location
        {
            get
            {
                if (locationProperty == null)
                    locationProperty = GetBooleanProperty("ResourceGroup.Location");
                return locationProperty.Value;
            }
            set
            {
                if (locationProperty == null)
                    locationProperty = GetBooleanProperty("ResourceGroup.Location");
                locationProperty.Value = value;
            }
        }

        protected RowProperty<bool> distributeLoadProperty;
        public bool DistributeLoad
        {
            get
            {
                if (distributeLoadProperty == null)
                    distributeLoadProperty = GetBooleanProperty("ResourceGroup.DistributeLoad");
                return distributeLoadProperty.Value;
            }
            set
            {
                if (distributeLoadProperty == null)
                    distributeLoadProperty = GetBooleanProperty("ResourceGroup.DistributeLoad");
                distributeLoadProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("ResourceGroup.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("ResourceGroup.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("ResourceGroup.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("ResourceGroup.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("ResourceGroup.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("ResourceGroup.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("ResourceGroup.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("ResourceGroup.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region UOM Table

    [Serializable()]
    public abstract partial class UOMBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : UOMBase<T, R>, new()
        where R : UOMRow, new()
    {
        protected UOMBase() : base() { }

        protected static Schema.UOM schemaTable;
        public static Schema.UOM SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.UOM)E9Schema.Instance.TablesDictionary["UOM"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOM.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByUOMCodeCriteria;
        public static T FillByUOMCode(DataContext context, string companyNum, string uOMCode, params string[] columnNames)
        {
            if (fillByUOMCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOM.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOM.UOMCode]));
                fillByUOMCodeCriteria = list.ToArray();
            }
            fillByUOMCodeCriteria[0].Value = companyNum;
            fillByUOMCodeCriteria[1].Value = uOMCode;
            return EditTable<T, R>.Fetch(context, fillByUOMCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class UOM : UOMBase<UOM, UOMRow>
    {
        public UOM() : base() { }
    }

    #region UOMRow

    [Serializable()]
    public class UOMRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("UOM.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("UOM.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMCodeProperty;
        public string UOMCode
        {
            get
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("UOM.UOMCode");
                return uOMCodeProperty.Value;
            }
            set
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("UOM.UOMCode");
                uOMCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMDescProperty;
        public string UOMDesc
        {
            get
            {
                if (uOMDescProperty == null)
                    uOMDescProperty = GetStringProperty("UOM.UOMDesc");
                return uOMDescProperty.Value;
            }
            set
            {
                if (uOMDescProperty == null)
                    uOMDescProperty = GetStringProperty("UOM.UOMDesc");
                uOMDescProperty.Value = value;
            }
        }

        protected RowProperty<string> fractionsProperty;
        public string Fractions
        {
            get
            {
                if (fractionsProperty == null)
                    fractionsProperty = GetStringProperty("UOM.Fractions");
                return fractionsProperty.Value;
            }
            set
            {
                if (fractionsProperty == null)
                    fractionsProperty = GetStringProperty("UOM.Fractions");
                fractionsProperty.Value = value;
            }
        }

        protected RowProperty<bool> activeProperty;
        public bool Active
        {
            get
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("UOM.Active");
                return activeProperty.Value;
            }
            set
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("UOM.Active");
                activeProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMSymbolProperty;
        public string UOMSymbol
        {
            get
            {
                if (uOMSymbolProperty == null)
                    uOMSymbolProperty = GetStringProperty("UOM.UOMSymbol");
                return uOMSymbolProperty.Value;
            }
            set
            {
                if (uOMSymbolProperty == null)
                    uOMSymbolProperty = GetStringProperty("UOM.UOMSymbol");
                uOMSymbolProperty.Value = value;
            }
        }

        protected RowProperty<bool> allowDecimalsProperty;
        public bool AllowDecimals
        {
            get
            {
                if (allowDecimalsProperty == null)
                    allowDecimalsProperty = GetBooleanProperty("UOM.AllowDecimals");
                return allowDecimalsProperty.Value;
            }
            set
            {
                if (allowDecimalsProperty == null)
                    allowDecimalsProperty = GetBooleanProperty("UOM.AllowDecimals");
                allowDecimalsProperty.Value = value;
            }
        }

        protected RowProperty<int> numOfDecProperty;
        public int NumOfDec
        {
            get
            {
                if (numOfDecProperty == null)
                    numOfDecProperty = GetIntegerProperty("UOM.NumOfDec");
                return numOfDecProperty.Value;
            }
            set
            {
                if (numOfDecProperty == null)
                    numOfDecProperty = GetIntegerProperty("UOM.NumOfDec");
                numOfDecProperty.Value = value;
            }
        }

        protected RowProperty<string> roundingProperty;
        public string Rounding
        {
            get
            {
                if (roundingProperty == null)
                    roundingProperty = GetStringProperty("UOM.Rounding");
                return roundingProperty.Value;
            }
            set
            {
                if (roundingProperty == null)
                    roundingProperty = GetStringProperty("UOM.Rounding");
                roundingProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("UOM.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("UOM.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("UOM.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("UOM.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("UOM.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("UOM.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("UOM.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("UOM.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region UOMClass Table

    [Serializable()]
    public abstract partial class UOMClassBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : UOMClassBase<T, R>, new()
        where R : UOMClassRow, new()
    {
        protected UOMClassBase() : base() { }

        protected static Schema.UOMClass schemaTable;
        public static Schema.UOMClass SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.UOMClass)E9Schema.Instance.TablesDictionary["UOMClass"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMClass.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByUOMClassIDCriteria;
        public static T FillByUOMClassID(DataContext context, string companyNum, string uOMClassID, params string[] columnNames)
        {
            if (fillByUOMClassIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMClass.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMClass.UOMClassID]));
                fillByUOMClassIDCriteria = list.ToArray();
            }
            fillByUOMClassIDCriteria[0].Value = companyNum;
            fillByUOMClassIDCriteria[1].Value = uOMClassID;
            return EditTable<T, R>.Fetch(context, fillByUOMClassIDCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class UOMClass : UOMClassBase<UOMClass, UOMClassRow>
    {
        public UOMClass() : base() { }
    }

    #region UOMClassRow

    [Serializable()]
    public class UOMClassRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("UOMClass.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("UOMClass.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMClassIDProperty;
        public string UOMClassID
        {
            get
            {
                if (uOMClassIDProperty == null)
                    uOMClassIDProperty = GetStringProperty("UOMClass.UOMClassID");
                return uOMClassIDProperty.Value;
            }
            set
            {
                if (uOMClassIDProperty == null)
                    uOMClassIDProperty = GetStringProperty("UOMClass.UOMClassID");
                uOMClassIDProperty.Value = value;
            }
        }

        protected RowProperty<string> descriptionProperty;
        public string Description
        {
            get
            {
                if (descriptionProperty == null)
                    descriptionProperty = GetStringProperty("UOMClass.Description");
                return descriptionProperty.Value;
            }
            set
            {
                if (descriptionProperty == null)
                    descriptionProperty = GetStringProperty("UOMClass.Description");
                descriptionProperty.Value = value;
            }
        }

        protected RowProperty<string> classTypeProperty;
        public string ClassType
        {
            get
            {
                if (classTypeProperty == null)
                    classTypeProperty = GetStringProperty("UOMClass.ClassType");
                return classTypeProperty.Value;
            }
            set
            {
                if (classTypeProperty == null)
                    classTypeProperty = GetStringProperty("UOMClass.ClassType");
                classTypeProperty.Value = value;
            }
        }

        protected RowProperty<string> baseUOMCodeProperty;
        public string BaseUOMCode
        {
            get
            {
                if (baseUOMCodeProperty == null)
                    baseUOMCodeProperty = GetStringProperty("UOMClass.BaseUOMCode");
                return baseUOMCodeProperty.Value;
            }
            set
            {
                if (baseUOMCodeProperty == null)
                    baseUOMCodeProperty = GetStringProperty("UOMClass.BaseUOMCode");
                baseUOMCodeProperty.Value = value;
            }
        }

        protected RowProperty<bool> partSpecificProperty;
        public bool PartSpecific
        {
            get
            {
                if (partSpecificProperty == null)
                    partSpecificProperty = GetBooleanProperty("UOMClass.PartSpecific");
                return partSpecificProperty.Value;
            }
            set
            {
                if (partSpecificProperty == null)
                    partSpecificProperty = GetBooleanProperty("UOMClass.PartSpecific");
                partSpecificProperty.Value = value;
            }
        }

        protected RowProperty<string> defUomCodeProperty;
        public string DefUomCode
        {
            get
            {
                if (defUomCodeProperty == null)
                    defUomCodeProperty = GetStringProperty("UOMClass.DefUomCode");
                return defUomCodeProperty.Value;
            }
            set
            {
                if (defUomCodeProperty == null)
                    defUomCodeProperty = GetStringProperty("UOMClass.DefUomCode");
                defUomCodeProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("UOMClass.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("UOMClass.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("UOMClass.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("UOMClass.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<bool> activeProperty;
        public bool Active
        {
            get
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("UOMClass.Active");
                return activeProperty.Value;
            }
            set
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("UOMClass.Active");
                activeProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("UOMClass.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("UOMClass.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("UOMClass.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("UOMClass.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #region UOMConv Table

    [Serializable()]
    public abstract partial class UOMConvBase<T, R> : SFEpic.Data.EditTable<T, R>
        where T : UOMConvBase<T, R>, new()
        where R : UOMConvRow, new()
    {
        protected UOMConvBase() : base() { }

        protected static Schema.UOMConv schemaTable;
        public static Schema.UOMConv SchemaTable
        {
            get
            {
                if (schemaTable == null)
                {
                    schemaTable = (Schema.UOMConv)E9Schema.Instance.TablesDictionary["UOMConv"];
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
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.CompanyNum]));
                fillByCompanyNumCriteria = list.ToArray();
            }
            fillByCompanyNumCriteria[0].Value = companyNum;
            return EditTable<T, R>.Fetch(context, fillByCompanyNumCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByUOMClassIDCriteria;
        public static T FillByUOMClassID(DataContext context, string companyNum, string uOMClassID, params string[] columnNames)
        {
            if (fillByUOMClassIDCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.UOMClassID]));
                fillByUOMClassIDCriteria = list.ToArray();
            }
            fillByUOMClassIDCriteria[0].Value = companyNum;
            fillByUOMClassIDCriteria[1].Value = uOMClassID;
            return EditTable<T, R>.Fetch(context, fillByUOMClassIDCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByUOMCodeCriteria;
        public static T FillByUOMCode(DataContext context, string companyNum, string uOMClassID, string uOMCode, params string[] columnNames)
        {
            if (fillByUOMCodeCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.UOMClassID]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.UOMCode]));
                fillByUOMCodeCriteria = list.ToArray();
            }
            fillByUOMCodeCriteria[0].Value = companyNum;
            fillByUOMCodeCriteria[1].Value = uOMClassID;
            fillByUOMCodeCriteria[2].Value = uOMCode;
            return EditTable<T, R>.Fetch(context, fillByUOMCodeCriteria, columnNames);
        }

        #endregion
    }

    [Serializable()]
    public class UOMConv : UOMConvBase<UOMConv, UOMConvRow>
    {
        public UOMConv() : base() { }
    }

    #region UOMConvRow

    [Serializable()]
    public class UOMConvRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("UOMConv.CompanyNum");
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                    companyNumProperty = GetStringProperty("UOMConv.CompanyNum");
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMClassIDProperty;
        public string UOMClassID
        {
            get
            {
                if (uOMClassIDProperty == null)
                    uOMClassIDProperty = GetStringProperty("UOMConv.UOMClassID");
                return uOMClassIDProperty.Value;
            }
            set
            {
                if (uOMClassIDProperty == null)
                    uOMClassIDProperty = GetStringProperty("UOMConv.UOMClassID");
                uOMClassIDProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMCodeProperty;
        public string UOMCode
        {
            get
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("UOMConv.UOMCode");
                return uOMCodeProperty.Value;
            }
            set
            {
                if (uOMCodeProperty == null)
                    uOMCodeProperty = GetStringProperty("UOMConv.UOMCode");
                uOMCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> convFactorProperty;
        public decimal ConvFactor
        {
            get
            {
                if (convFactorProperty == null)
                    convFactorProperty = GetDecimalProperty("UOMConv.ConvFactor");
                return convFactorProperty.Value;
            }
            set
            {
                if (convFactorProperty == null)
                    convFactorProperty = GetDecimalProperty("UOMConv.ConvFactor");
                convFactorProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMDescProperty;
        public string UOMDesc
        {
            get
            {
                if (uOMDescProperty == null)
                    uOMDescProperty = GetStringProperty("UOMConv.UOMDesc");
                return uOMDescProperty.Value;
            }
            set
            {
                if (uOMDescProperty == null)
                    uOMDescProperty = GetStringProperty("UOMConv.UOMDesc");
                uOMDescProperty.Value = value;
            }
        }

        protected RowProperty<bool> baseUOM83Property;
        public bool BaseUOM83
        {
            get
            {
                if (baseUOM83Property == null)
                    baseUOM83Property = GetBooleanProperty("UOMConv.BaseUOM83");
                return baseUOM83Property.Value;
            }
            set
            {
                if (baseUOM83Property == null)
                    baseUOM83Property = GetBooleanProperty("UOMConv.BaseUOM83");
                baseUOM83Property.Value = value;
            }
        }

        protected RowProperty<string> uOMCode83Property;
        public string UOMCode83
        {
            get
            {
                if (uOMCode83Property == null)
                    uOMCode83Property = GetStringProperty("UOMConv.UOMCode83");
                return uOMCode83Property.Value;
            }
            set
            {
                if (uOMCode83Property == null)
                    uOMCode83Property = GetStringProperty("UOMConv.UOMCode83");
                uOMCode83Property.Value = value;
            }
        }

        protected RowProperty<string> fractionsProperty;
        public string Fractions
        {
            get
            {
                if (fractionsProperty == null)
                    fractionsProperty = GetStringProperty("UOMConv.Fractions");
                return fractionsProperty.Value;
            }
            set
            {
                if (fractionsProperty == null)
                    fractionsProperty = GetStringProperty("UOMConv.Fractions");
                fractionsProperty.Value = value;
            }
        }

        protected RowProperty<bool> stdUOMProperty;
        public bool StdUOM
        {
            get
            {
                if (stdUOMProperty == null)
                    stdUOMProperty = GetBooleanProperty("UOMConv.StdUOM");
                return stdUOMProperty.Value;
            }
            set
            {
                if (stdUOMProperty == null)
                    stdUOMProperty = GetBooleanProperty("UOMConv.StdUOM");
                stdUOMProperty.Value = value;
            }
        }

        protected RowProperty<bool> activeProperty;
        public bool Active
        {
            get
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("UOMConv.Active");
                return activeProperty.Value;
            }
            set
            {
                if (activeProperty == null)
                    activeProperty = GetBooleanProperty("UOMConv.Active");
                activeProperty.Value = value;
            }
        }

        protected RowProperty<string> uOMSymbolProperty;
        public string UOMSymbol
        {
            get
            {
                if (uOMSymbolProperty == null)
                    uOMSymbolProperty = GetStringProperty("UOMConv.UOMSymbol");
                return uOMSymbolProperty.Value;
            }
            set
            {
                if (uOMSymbolProperty == null)
                    uOMSymbolProperty = GetStringProperty("UOMConv.UOMSymbol");
                uOMSymbolProperty.Value = value;
            }
        }

        protected RowProperty<int> numOfDecProperty;
        public int NumOfDec
        {
            get
            {
                if (numOfDecProperty == null)
                    numOfDecProperty = GetIntegerProperty("UOMConv.NumOfDec");
                return numOfDecProperty.Value;
            }
            set
            {
                if (numOfDecProperty == null)
                    numOfDecProperty = GetIntegerProperty("UOMConv.NumOfDec");
                numOfDecProperty.Value = value;
            }
        }

        protected RowProperty<string> roundingProperty;
        public string Rounding
        {
            get
            {
                if (roundingProperty == null)
                    roundingProperty = GetStringProperty("UOMConv.Rounding");
                return roundingProperty.Value;
            }
            set
            {
                if (roundingProperty == null)
                    roundingProperty = GetStringProperty("UOMConv.Rounding");
                roundingProperty.Value = value;
            }
        }

        protected RowProperty<bool> allowDecimalsProperty;
        public bool AllowDecimals
        {
            get
            {
                if (allowDecimalsProperty == null)
                    allowDecimalsProperty = GetBooleanProperty("UOMConv.AllowDecimals");
                return allowDecimalsProperty.Value;
            }
            set
            {
                if (allowDecimalsProperty == null)
                    allowDecimalsProperty = GetBooleanProperty("UOMConv.AllowDecimals");
                allowDecimalsProperty.Value = value;
            }
        }

        protected RowProperty<bool> partSpecificProperty;
        public bool PartSpecific
        {
            get
            {
                if (partSpecificProperty == null)
                    partSpecificProperty = GetBooleanProperty("UOMConv.PartSpecific");
                return partSpecificProperty.Value;
            }
            set
            {
                if (partSpecificProperty == null)
                    partSpecificProperty = GetBooleanProperty("UOMConv.PartSpecific");
                partSpecificProperty.Value = value;
            }
        }

        protected RowProperty<string> sysRowIDProperty;
        public string SysRowID
        {
            get
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("UOMConv.SysRowID");
                return sysRowIDProperty.Value;
            }
            set
            {
                if (sysRowIDProperty == null)
                    sysRowIDProperty = GetStringProperty("UOMConv.SysRowID");
                sysRowIDProperty.Value = value;
            }
        }

        protected RowProperty<int> sysRevIDProperty;
        public int SysRevID
        {
            get
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("UOMConv.SysRevID");
                return sysRevIDProperty.Value;
            }
            set
            {
                if (sysRevIDProperty == null)
                    sysRevIDProperty = GetIntegerProperty("UOMConv.SysRevID");
                sysRevIDProperty.Value = value;
            }
        }

        protected RowProperty<int> bitFlagProperty;
        public int BitFlag
        {
            get
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("UOMConv.BitFlag");
                return bitFlagProperty.Value;
            }
            set
            {
                if (bitFlagProperty == null)
                    bitFlagProperty = GetIntegerProperty("UOMConv.BitFlag");
                bitFlagProperty.Value = value;
            }
        }

        protected RowProperty<bool> hasBeenUsedProperty;
        public bool HasBeenUsed
        {
            get
            {
                if (hasBeenUsedProperty == null)
                    hasBeenUsedProperty = GetBooleanProperty("UOMConv.HasBeenUsed");
                return hasBeenUsedProperty.Value;
            }
            set
            {
                if (hasBeenUsedProperty == null)
                    hasBeenUsedProperty = GetBooleanProperty("UOMConv.HasBeenUsed");
                hasBeenUsedProperty.Value = value;
            }
        }

        protected RowProperty<string> convOperatorProperty;
        public string ConvOperator
        {
            get
            {
                if (convOperatorProperty == null)
                    convOperatorProperty = GetStringProperty("UOMConv.ConvOperator");
                return convOperatorProperty.Value;
            }
            set
            {
                if (convOperatorProperty == null)
                    convOperatorProperty = GetStringProperty("UOMConv.ConvOperator");
                convOperatorProperty.Value = value;
            }
        }

        protected RowProperty<bool> wasWrittenByAspaciaProperty;
        public bool WasWrittenByAspacia
        {
            get
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("UOMConv.WasWrittenByAspacia");
                return wasWrittenByAspaciaProperty.Value;
            }
            set
            {
                if (wasWrittenByAspaciaProperty == null)
                    wasWrittenByAspaciaProperty = GetBooleanProperty("UOMConv.WasWrittenByAspacia");
                wasWrittenByAspaciaProperty.Value = value;
            }
        }
    }

    #endregion

    #endregion

    #endregion
}
