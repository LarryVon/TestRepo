using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data.V8
{
    public partial class V8Schema
    {
        protected override void InitRelationsCore()
        {
            var company = tablesDictionary["Company"];
            var poHeader = tablesDictionary["POHeader"];
            var poDetail = tablesDictionary["PODetail"];
            var poRel = tablesDictionary["PORel"];
            var part = tablesDictionary["Part"];
            var vendor = tablesDictionary["Vendor"];
            var purAgent = tablesDictionary["PurAgent"];
            relationsList.Add(new SchemaRelation(this, company, poHeader, poHeader.GetColumns(Schema.POHeader.CompanyNum)));
            relationsList.Add(new SchemaRelation(this, company, part, part.GetColumns(Schema.Part.CompanyNum)));
            relationsList.Add(new SchemaRelation(this, poHeader, poDetail, poDetail.GetColumns(Schema.PODetail.CompanyNum, Schema.PODetail.PONUM)));
            relationsList.Add(new SchemaRelation(this, poDetail, poRel, poRel.GetColumns(Schema.PORel.CompanyNum, Schema.PORel.PONum, Schema.PORel.POLine)));
            relationsList.Add(new SchemaRelation(this, vendor, poHeader, poHeader.GetColumns(Schema.POHeader.CompanyNum, Schema.POHeader.VendorNum)));
            relationsList.Add(new SchemaRelation(this, purAgent, poHeader, poHeader.GetColumns(Schema.POHeader.CompanyNum, Schema.POHeader.BuyerID)));
        }
    }
}
