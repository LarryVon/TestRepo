using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using SFEpic.Data.E9;

namespace SFEpic.Library.E9
{
    [Serializable()]
    public abstract class PartImporterBase<T> : SFEpic.Csla4.BusinessBase<T>
        where T:PartImporterBase<T>
    {
        #region Business Methods

        public static Csla.PropertyInfo<string> CompanyNumProperty = RegisterProperty<string>(p => p.CompanyNum);
        public string CompanyNum
        {
            get { return (string)GetProperty(CompanyNumProperty); }
            set { SetProperty(CompanyNumProperty, value); }
        }

        public static Csla.PropertyInfo<string> PartNumProperty = RegisterProperty<string>(p => p.PartNum);
        public string PartNum
        {
            get { return (string)GetProperty(PartNumProperty); }
            set { SetProperty(PartNumProperty, value); }
        }

        public static Csla.PropertyInfo<string> DescriptionProperty = RegisterProperty<string>(p => p.Description);
        public string Description
        {
            get { return (string)GetProperty(DescriptionProperty); }
            set { SetProperty(DescriptionProperty, value); }
        }

        public static Csla.PropertyInfo<string> UMProperty = RegisterProperty<string>(p => p.UM);
        public string UM
        {
            get { return (string)GetProperty(UMProperty); }
            set { SetProperty(UMProperty, value); }
        }

        public static Csla.PropertyInfo<bool> IsPurchasedProperty = RegisterProperty<bool>(p => p.IsPurchased);
        public bool IsPurchased
        {
            get { return (bool)GetProperty(IsPurchasedProperty); }
            set { SetProperty(IsPurchasedProperty, value); }
        }

        public static Csla.PropertyInfo<string> ClassIDProperty = RegisterProperty<string>(p => p.ClassID);
        public string ClassID
        {
            get { return (string)GetProperty(ClassIDProperty); }
            set { SetProperty(ClassIDProperty, value); }
        }

        public static Csla.PropertyInfo<int> PurchasingFactorProperty = RegisterProperty<int>(p => p.PurchasingFactor);
        public int PurchasingFactor
        {
            get { return (int)GetProperty(PurchasingFactorProperty); }
            set { SetProperty(PurchasingFactorProperty, value); }
        }

        public static Csla.PropertyInfo<string> PricePerCodeProperty = RegisterProperty<string>(p => p.PricePerCode);
        public string PricePerCode
        {
            get { return (string)GetProperty(PricePerCodeProperty); }
            set { SetProperty(PricePerCodeProperty, value); }
        }

        public static Csla.PropertyInfo<string> CostMethodProperty = RegisterProperty<string>(p => p.CostMethod);
        public string CostMethod
        {
            get { return (string)GetProperty(CostMethodProperty); }
            set { SetProperty(CostMethodProperty, value); }
        }

        public static Csla.PropertyInfo<string> InternalPricePerCodeProperty = RegisterProperty<string>(p => p.InternalPricePerCode);
        public string InternalPricePerCode
        {
            get { return (string)GetProperty(InternalPricePerCodeProperty); }
            set { SetProperty(InternalPricePerCodeProperty, value); }
        }

        public static Csla.PropertyInfo<int> SellingFactorProperty = RegisterProperty<int>(p => p.SellingFactor);
        public int SellingFactor
        {
            get { return (int)GetProperty(SellingFactorProperty); }
            set { SetProperty(SellingFactorProperty, value); }
        }

        public static Csla.PropertyInfo<int> ISSuppUnitsFactorProperty = RegisterProperty<int>(p => p.ISSuppUnitsFactor);
        public int ISSuppUnitsFactor
        {
            get { return (int)GetProperty(ISSuppUnitsFactorProperty); }
            set { SetProperty(ISSuppUnitsFactorProperty, value); }
        }

        public static Csla.PropertyInfo<string> PurchasingFactorDirectionProperty = RegisterProperty<string>(p => p.PurchasingFactorDirection);
        public string PurchasingFactorDirection
        {
            get { return (string)GetProperty(PurchasingFactorDirectionProperty); }
            set { SetProperty(PurchasingFactorDirectionProperty, value); }
        }

        public static Csla.PropertyInfo<string> SellingFactorDirectionProperty = RegisterProperty<string>(p => p.SellingFactorDirection);
        public string SellingFactorDirection
        {
            get { return (string)GetProperty(SellingFactorDirectionProperty); }
            set { SetProperty(SellingFactorDirectionProperty, value); }
        }

        public static Csla.PropertyInfo<bool> QtyBearingProperty = RegisterProperty<bool>(p => p.QtyBearing);
        public bool QtyBearing
        {
            get { return (bool)GetProperty(QtyBearingProperty); }
            set { SetProperty(QtyBearingProperty, value); }
        }

        public static Csla.PropertyInfo<string> UOMClassIDProperty = RegisterProperty<string>(p => p.UOMClassID);
        public string UOMClassID
        {
            get { return (string)GetProperty(UOMClassIDProperty); }
            set { SetProperty(UOMClassIDProperty, value); }
        }

        public static Csla.PropertyInfo<string> NetWeightUOMProperty = RegisterProperty<string>(p => p.NetWeightUOM);
        public string NetWeightUOM
        {
            get { return (string)GetProperty(NetWeightUOMProperty); }
            set { SetProperty(NetWeightUOMProperty, value); }
        }

        public static Csla.PropertyInfo<string> NetVolumeUOMProperty = RegisterProperty<string>(p => p.NetVolumeUOM);
        public string NetVolumeUOM
        {
            get { return (string)GetProperty(NetVolumeUOMProperty); }
            set { SetProperty(NetVolumeUOMProperty, value); }
        }

        public static Csla.PropertyInfo<int> LotNextNumberProperty = RegisterProperty<int>(p => p.LotNextNumber);
        public int LotNextNumber
        {
            get { return (int)GetProperty(LotNextNumberProperty); }
            set { SetProperty(LotNextNumberProperty, value); }
        }

        public static Csla.PropertyInfo<string> PrimWhseProperty = RegisterProperty<string>(p => p.PrimWhse);
        public string PrimWhse
        {
            get { return (string)GetProperty(PrimWhseProperty); }
            set { SetProperty(PrimWhseProperty, value); }
        }

        public static Csla.PropertyInfo<string> PlantNumProperty = RegisterProperty<string>(p => p.PlantNum);
        public string PlantNum
        {
            get { return (string)GetProperty(PlantNumProperty); }
            set { SetProperty(PlantNumProperty, value); }
        }

        public static Csla.PropertyInfo<string> PrimBinNumProperty = RegisterProperty<string>(p => p.PrimBinNum);
        public string PrimBinNum
        {
            get { return (string)GetProperty(PrimBinNumProperty); }
            set { SetProperty(PrimBinNumProperty, value); }
        }
        

        #endregion

        #region Factory Methods

        public static void BeginNew(PartDataContext context, EventHandler<DataPortalResult<T>> callback)
        {
            DataPortal.BeginCreate<T>(context, callback);
        }

        public static T New(PartDataContext context)
        {
            return DataPortal.Create<T>(context);
        }

        protected PartImporterBase() : base() { }

        #endregion

        #region Data Access

        protected PartDataContext context;

        protected virtual void DataPortal_Create(PartDataContext context)
        {
            //PricePerCode = E 
            //CostMethod = A
            //InternalPricePerCode = E
            //PurchasingFactorDirection = D
            //SellingFactorDirection = D
            //UOMClassID = Count
            //NetWeightUOM = LB
            //NetVolumeUOM = GA
            //QtyBearing = true
            this.context = context;
            using (BypassPropertyChecks)
            {
                PurchasingFactor = 1;
                SellingFactor = 1;
                ISSuppUnitsFactor = 1;
                LotNextNumber = 1;
                PrimBinNum = "Default";
            }
            base.DataPortal_Create();
        }

        //
        // Need something to update rather than insert a part if a record exists
        //
        protected override void DataPortal_Insert()
        {
            using (BypassPropertyChecks)
            {
                var companyNum = CompanyNum;
                var partNum = PartNum;
                var plantNum = PlantNum;
                var warehouseCode = PrimWhse;
                var partTable = context.GetPart(companyNum, partNum);
                if (!partTable.HasRows)
                {
                    LoadPartData(partTable.NewRow());
                    try
                    {
                        partTable.Update();
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
                var partPlantTable = context.GetPartPlant(companyNum, partNum);
                if (!partPlantTable.HasRows)
                {
                    LoadPartPlantData(partPlantTable.NewRow());
                    try
                    {
                        partPlantTable.Update();
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
                var partWhseTable = context.GetPartWhse(companyNum, partNum, warehouseCode);
                if (!partWhseTable.HasRows)
                {
                    LoadPartWhseData(partWhseTable.NewRow());
                    try
                    {
                        partWhseTable.Update();
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
                var plantWhseTable = context.GetPlantWhse(companyNum, plantNum, partNum, warehouseCode);
                if (!plantWhseTable.HasRows)
                {
                    LoadPlantWhseData(plantWhseTable.NewRow());
                    try
                    {
                        plantWhseTable.Update();
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
                var partCostTable = context.GetPartCost(companyNum, partNum);
                if (!partCostTable.HasRows)
                {
                    LoadPartCostData(partCostTable.NewRow());
                    try
                    {
                        partCostTable.Update();
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
                var partUOMTable = context.GetPartUOM(companyNum, partNum);
                if (!partUOMTable.HasRows)
                {
                    LoadPartUOMData(partUOMTable);
                    try
                    {
                        partUOMTable.Update();
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
            }
        }

        protected virtual void LoadPartUOMData(PartUOM partUOMTable)
        {
            var companyNum = CompanyNum;
            var uomConvTable = context.GetUOMConv(CompanyNum, UOMClassID);
            foreach (var uomConvRow in uomConvTable.Rows.Cast<UOMConvRow>())
            {
                var partUOMRow = partUOMTable.NewRow();
                partUOMRow.CompanyNum = companyNum;
                partUOMRow.PartNum = PartNum;
                partUOMRow.UOMCode = uomConvRow.UOMCode;
                partUOMRow.ConvFactor = uomConvRow.ConvFactor;
                partUOMRow.ConvOperator = uomConvRow.ConvOperator;
                partUOMRow.Active = uomConvRow.Active;
                partUOMRow.NetVolumeUOM = NetVolumeUOM;
                LoadPartUOMRowCore(partUOMRow);
            }
        }

        protected virtual void LoadPartUOMRowCore(PartUOMRow partUOMRow)
        {
        }

        protected virtual void LoadPartData(PartRow row) 
        {
            row.CompanyNum = CompanyNum;
            row.PartNum = PartNum;
            row.PartDescription = Description;
            row.IUM = UM;
            row.PUM = UM;
            row.SalesUM = UM;
            row.TypeCode = IsPurchased ? "P" : "M";
            row.ClassID = ClassID;
            //PurchasingFactor = 1
            //PricePerCode = E 
            //CostMethod = A
            //InternalPricePerCode = E
            //SellingFactor = 1
            //ISSuppUnitsFactor = 1
            //PurchasingFactorDirection = D
            //SellingFactorDirection = D
            //QtyBearing = 1
            //UOMClassID = Count
            //NetWeightUOM = LB
            //NetVolumeUOM = GA
            //LotNxtNum = 1
            row.PurchasingFactor = PurchasingFactor;
            row.PricePerCode = PricePerCode;
            row.CostMethod = CostMethod;
            row.InternalPricePerCode = InternalPricePerCode;
            row.SellingFactor = SellingFactor;
            row.ISSuppUnitsFactor = ISSuppUnitsFactor;
            row.PurchasingFactorDirection = PurchasingFactorDirection;
            row.SellingFactorDirection = SellingFactorDirection;
            row.QtyBearing = QtyBearing;
            row.UOMClassID = UOMClassID;
            row.NetVolumeUOM = NetVolumeUOM;
            row.NetWeightUOM = NetWeightUOM;
            row.LotNxtNum = LotNextNumber;
            row.WasWrittenByAspacia = true;
        }
        protected virtual void LoadPartRevData(PartRevRow row) { }

        protected virtual void LoadPartWhseData(PartWhseRow row)
        {
            row.CompanyNum = CompanyNum;
            row.PartNum = PartNum;
            row.WarehouseCode = PrimWhse;
            row.LastCCDate = DateTime.Today;
            row.WasWrittenByAspacia = true;
        }

        protected virtual void LoadPartPlantData(PartPlantRow row)
        {
            row.CompanyNum = CompanyNum;
            row.PartNum = PartNum;
            row.PrimWhse = PrimWhse;
            row.PlantNum = PlantNum;
            row.Obsolete900_SystemAbc = "A";
            row.QtyBearing = QtyBearing;
            row.PersonID = "SYSTEM";
            row.CostMethod = CostMethod;
            row.WasWrittenByAspacia = true;
            //row.MRPLastScheduledDate = DateTime.Today;
            //row.MRPLastRunDate = DateTime.Today;
            //row.MRPLastRunTime = 7239;
        }

        protected virtual void LoadPartBinData(PartBinRow row) { }

        protected virtual void LoadPlantWhseData(PlantWhseRow row)
        {
            //Company
            //Plant = Mfgsys
            //WarehouseCode = KFC
            //PartNum
            //PrimBin = Default
            row.CompanyNum = CompanyNum;
            row.PlantNum = PlantNum;
            row.WarehouseCode = PrimWhse;
            row.PartNum = PartNum;
            row.PrimBin = PrimBinNum;
            row.WasWrittenByAspacia = true;
        }
        
        protected virtual void LoadPartCostData(PartCostRow row) 
        {
            row.CompanyNum = CompanyNum;
            row.PartNum = PartNum;
            row.CostID = "1";
            row.WasWrittenByAspacia = true;
        }

        protected override void DataPortal_Update()
        {
            throw new InvalidOperationException("Update not supported by PartImporter");
        }

        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(CompanyNumProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(PartNumProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(DescriptionProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(UMProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(PrimWhseProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(PlantNumProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(PrimBinNumProperty));
        }

        #endregion
    }
}
