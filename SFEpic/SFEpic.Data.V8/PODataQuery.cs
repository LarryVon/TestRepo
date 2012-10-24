using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace SFEpic.Data.V8
{
    [Serializable()]
    public class PODataQuery : QueryTable<PODataQuery, PODataQueryRow>
    {
        public PODataQuery()
            : base() { }

        protected static ICriteriaValue[] GetCriteria(string companyNum, int poNum)
        {
            var schema = V8Schema.Instance;
            return new ICriteriaValue[] 
                { 
                   new CriteriaValue<string>(schema.TablesDictionary[V8Schema.POHeader].ColumnsDictionary[Schema.POHeader.CompanyNum], companyNum),
                   new CriteriaValue<int>(schema.TablesDictionary[V8Schema.POHeader].ColumnsDictionary[Schema.POHeader.PONum], poNum) 
                };
        }

        protected static string[] GetProperties()
        {
            return new string[]
                {
                    "POHeader.CompanyNum", "POHeader.PONum", "POHeader.BuyerID", "PODetail.PartNum", "PORel.RelQty"
                };
        }

        protected static SchemaRelation[] GetRelations()
        {
            var schema = V8Schema.Instance;
            return new SchemaRelation[] 
                { 
                    schema.RelationsDictionary["POHeader_PODetail"],
                    schema.RelationsDictionary["PODetail_PORel"]
                };
        }

        public static PODataQuery Fetch(PurchasingDataContext context, string companyNum, int poNum)
        {
            return Fetch(context, GetRelations(), GetCriteria(companyNum, poNum), GetProperties());
        }

        //protected override DataRow GetNewDataRowCore()
        //{
        //    return new PODataQueryRow();
        //}

        //protected override void InitRowLists()
        //{
        //    var pORelRowsList = new ObservableCollection<PODataQueryRow>();
        //    rowsList = pORelRowsList;
        //    rows = new ReadOnlyObservableCollection<PODataQueryRow>(pORelRowsList);
        //    readOnlyRowsList = rows;
        //}

        //protected ReadOnlyObservableCollection<PODataQueryRow> rows;
        //new public ReadOnlyObservableCollection<PODataQueryRow> Rows
        //{
        //    get
        //    {
        //        return rows;
        //    }
        //}

        //public PODataQueryRow this[int index]
        //{
        //    get
        //    {
        //        return rows[index];
        //    }
        //}
    }

    [Serializable()]
    public class PODataQueryRow : DataRow
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
        }
    }
}
