using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data.V8
{
    public class PurchasingDataContext : SFEpic.Data.DataContext
    {
        public PurchasingDataContext()
        {
        }

        public V8.POHeader NewPOHeader()
        {
            //return V8.POHeader.FillByPONum(this, companyNum, poNum, GetPOHeaderColumnNames());
            return V8.POHeader.GetEmpty(this);
        }

        protected override void InitTables()
        {
            base.InitTables();
            //AddTable<POHeader>("POHeader", Schema.POHeader.PONum, Schema.POHeader.CompanyNum, Schema.POHeader.BuyerID);
            //AddTable<Part>("Part", Schema.Part.CompanyNum, Schema.Part.PartNum, Schema.Part.PartDescription);
        }
    }
}
