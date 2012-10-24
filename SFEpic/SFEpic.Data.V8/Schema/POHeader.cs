using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFEpic.Data;

namespace SFEpic.Data.V8.Schema
{
    [Serializable()]
    public class POHeader : SchemaTable
    {
        public POHeader()
            : base("POHeader")
        {
        }

        protected override void InitColumnsCore()
        {
            int seq = 0;
            columnsList.Add(SchemaColumnFactory.GetTextSchemaColumn(this, "CompanyNum", 16, schemaColumnName: "Company", ordinalSequence: seq++, isNullable: false, isRequired: true));
            columnsList.Add(SchemaColumnFactory.GetDecimalSchemaColumn(this, "asdfasdf", 25, 9
        }
    }
}
