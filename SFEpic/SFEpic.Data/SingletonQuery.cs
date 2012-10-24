using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public abstract class SingletonQuery
    {
        protected SingletonQuery() { }

        public DataContext DataContext
        {
            get;
            protected internal set;
        }

        protected ICriteriaValue[] fetchCriteria;
        protected void DoFetch(SchemaRelation[] relations, ICriteriaValue[] criteria, params string[] columnNames)
        {
            fetchCriteria = criteria;
            foreach (var criterion in criteria)
            {
                if (criterion.Column == null)
                {
                    IDataColumn col = null;
                    var schemaCol = criterion.SchemaColumn;
                    var colName = String.Concat(schemaCol.SchemaTable.TableName, ".", criterion.SchemaColumn.ColumnName);
                    if (!columnsDictionary.TryGetValue(colName, out col))
                    {
                        col = InitColumn(colName);
                    }
                    criterion.Column = col;
                }
            }
            rowsList.Clear();
            using (var cm = DataContext.GetConnectionManager())
            {
                var cmd = cm.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if (relations == null)
                {
                    cmd.CommandText = DataContext.GetSqlFactory().GetSelectSql(TableName, readOnlyColumnsList, criteria);
                }
                else
                {
                    cmd.CommandText = DataContext.GetSqlFactory().GetSelectSql(relations, readOnlyColumnsList, criteria);
                }
                using (var reader = cmd.ExecuteReader())
                {
                    //var columnOrdinalDictionary = GetQueryColumnOrdinals(reader);
                    while (reader.Read())
                    {
                        rowsList.Add(GetNewDataRow(reader));
                    }
                }
            }
        }
    }
}
