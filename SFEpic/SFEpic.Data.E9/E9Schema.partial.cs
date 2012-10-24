using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data.E9
{
    public partial class E9Schema
    {
        protected override void InitRelationsCore()
        {
            
        }
    }

    public partial class ECORevBase<T, R>
    {
        protected static ICriteriaValue[] fillByPartRevCriteria;
        public static T FillByPartRev(DataContext context, string companyNum, string partNum, string revisionNum, params string[] columnNames)
        {
            if (fillByPartRevCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.PartNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.ECORev.RevisionNum]));
                fillByPartRevCriteria = list.ToArray();
            }
            fillByPartRevCriteria[0].Value = companyNum;
            fillByPartRevCriteria[1].Value = partNum;
            fillByPartRevCriteria[2].Value = revisionNum;
            return EditTable<T, R>.Fetch(context, fillByPartRevCriteria, columnNames);
        }
    }

    public partial class UOMConvBase<T, R>
    {
        protected static ICriteriaValue[] fillByUOMCodeOnlyCriteria;
        public static T FillByUOMCodeOnly(DataContext context, string companyNum, string uomCode, params string[] columnNames)
        {
            if (fillByUOMCodeOnlyCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.UOMConv.UOMCode]));
                fillByUOMCodeOnlyCriteria = list.ToArray();
            }
            fillByUOMCodeOnlyCriteria[0].Value = companyNum;
            fillByUOMCodeOnlyCriteria[1].Value = uomCode;
            return EditTable<T, R>.Fetch(context, fillByUOMCodeOnlyCriteria, columnNames);
        }
    }
}
