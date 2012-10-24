using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Data;

namespace SFEpic.Data.V8
{
    [Serializable()]
    public partial class Part : DataTable<Part>
    {
        public Part() : base() { }

        new protected static Schema.Part schemaTable;
        new public static Schema.Part SchemaTable
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

        protected static ICriteriaValue[] fillByCompanyCriteria;
        public static Part FillByCompany(DataContext context, string companyNum, params string[] columnNames)
        {
            if (fillByCompanyCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.CompanyNum]));
                fillByCompanyCriteria = list.ToArray();
            }
            fillByCompanyCriteria[0].Value = companyNum;
            return Part.Fetch(context, fillByCompanyCriteria, columnNames);
        }

        protected static ICriteriaValue[] fillByPartCriteria;
        public static Part FillByPart(DataContext context, string companyNum, string partNum, params string[] columnNames)
        {
            if (fillByPartCriteria == null)
            {
                var list = new List<ICriteriaValue>();
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.CompanyNum]));
                list.Add(new CriteriaValue<string>(SchemaTable.ColumnsDictionary[Schema.Part.PartNum]));
                fillByPartCriteria = list.ToArray();
            }
            fillByPartCriteria[0].Value = companyNum;
            fillByPartCriteria[1].Value = partNum;
            return Part.Fetch(context, fillByPartCriteria, columnNames);
        }

        protected override DataRow GetNewDataRowCore()
        {
            return new PartRow();
        }

        protected override SchemaTable GetSchemaTable()
        {
            if (DataContext != null)
            {
                return DataContext.DbSchema.TablesDictionary["Part"];
            }
            return null;
        }

        protected override void InitRowLists()
        {
            var partRowsList = new ObservableCollection<PartRow>();
            rowsList = partRowsList;
            rows = new ReadOnlyObservableCollection<PartRow>(partRowsList);
            readOnlyRowsList = rows;
        }

        protected ReadOnlyObservableCollection<PartRow> rows;
        new public ReadOnlyObservableCollection<PartRow> Rows
        {
            get
            {
                return rows;
            }
        }

        public PartRow this[int index]
        {
            get
            {
                return rows[index];
            }
        }
    }

    [Serializable()]
    public class PartRow : DataRow
    {
        protected RowProperty<string> companyNumProperty;
        public string CompanyNum
        {
            get
            {
                if (companyNumProperty == null)
                {
                    companyNumProperty = GetStringProperty("Part.CompanyNum");
                }
                return companyNumProperty.Value;
            }
            set
            {
                if (companyNumProperty == null)
                {
                    companyNumProperty = GetStringProperty("Part.CompanyNum");
                }
                companyNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partNumProperty;
        public string PartNum
        {
            get
            {
                if (partNumProperty == null)
                {
                    partNumProperty = GetStringProperty("Part.PartNum");
                }
                return partNumProperty.Value;
            }
            set
            {
                if (partNumProperty == null)
                {
                    partNumProperty = GetStringProperty("Part.PartNum");
                }
                partNumProperty.Value = value;
            }
        }

        protected RowProperty<string> partDescriptionProperty;
        public string PartDescription
        {
            get
            {
                if (partDescriptionProperty == null)
                {
                    partDescriptionProperty = GetStringProperty("Part.PartDescription");
                }
                return partDescriptionProperty.Value;
            }
            set
            {
                if (partDescriptionProperty == null)
                {
                    partDescriptionProperty = GetStringProperty("Part.PartDescription");
                }
                partDescriptionProperty.Value = value;
            }
        }

        protected RowProperty<string> prodCodeProperty;
        public string ProdCode
        {
            get
            {
                if (prodCodeProperty == null)
                {
                    prodCodeProperty = GetStringProperty("Part.ProdCode");
                }
                return prodCodeProperty.Value;
            }
            set
            {
                if (prodCodeProperty == null)
                {
                    prodCodeProperty = GetStringProperty("Part.ProdCode");
                }
                prodCodeProperty.Value = value;
            }
        }

        protected RowProperty<decimal> unitPriceProperty;
        public decimal UnitPrice
        {
            get
            {
                if (unitPriceProperty == null)
                {
                    unitPriceProperty = GetDecimalProperty("Part.UnitPrice");
                }
                return unitPriceProperty.Value;
            }
            set
            {
                if (unitPriceProperty == null)
                {
                    unitPriceProperty = GetDecimalProperty("Part.UnitPrice");
                }
                unitPriceProperty.Value = value;
            }
        }
    }
}
