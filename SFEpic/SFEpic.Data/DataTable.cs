using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Collections.Generic;

namespace SFEpic.Data
{
    [Serializable()]
    public class DataTable
    {
        protected internal DataTable()
        {
            InitRowLists();
        }

        //protected internal DataTable(DataContext dataContext, SchemaTable schemaTable)
        //{
        //    DataContext = dataContext;
        //    SchemaTable = schemaTable;
        //    InitColumns();
        //    rowsList = new ObservableCollection<DataRow>();
        //    rows = new ReadOnlyObservableCollection<DataRow>(rowsList);
        //}

        //protected internal DataTable(DataContext dataContext, SchemaTable schemaTable, string tableName)
        //    : this(dataContext, schemaTable)
        //{
        //    TableName = tableName;
        //}

        protected ReadOnlyObservableCollection<IDataColumn> readOnlyColumnsList;
        public ReadOnlyObservableCollection<IDataColumn> Columns
        {
            get
            {
                return readOnlyColumnsList;
            }
        }

        protected ReadOnlyDictionary<string, IDataColumn> readOnlyColumnsDictionary;
        public ReadOnlyDictionary<string, IDataColumn> ColumnsDictionary
        {
            get
            {
                return readOnlyColumnsDictionary;
            }
        }

        public DataContext DataContext
        {
            get;
            protected internal set;
        }

        public System.Data.Common.DbDataReader FetchReader(SchemaRelation[] relations, ICriteriaValue[] criteria, params string[] columnNames)
        {
            if (criteria == null)
            {
                criteria = Enumerable.Empty<ICriteriaValue>().ToArray();
            }
            fetchCriteria = criteria;
            if (columnNames != null && columnNames.Length > 0)
            {
                InitColumns(columnNames);
            }
            else
            {
                InitColumns();
            }
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
                    if (DataContext.ShouldSelectSafeStrings)
                    {
                        cmd.CommandText = DataContext.GetSqlFactory().GetSafeSelectSql(TableName, readOnlyColumnsList, criteria);
                    }
                    else
                    {
                        cmd.CommandText = DataContext.GetSqlFactory().GetSelectSql(TableName, readOnlyColumnsList, criteria);
                    }
                }
                else
                {
                    cmd.CommandText = DataContext.GetSqlFactory().GetSelectSql(relations, readOnlyColumnsList, criteria);
                }
                try
                {
                    //using (var reader = cmd.ExecuteReader())
                    //{
                    //    //var columnOrdinalDictionary = GetQueryColumnOrdinals(reader);
                    //    while (reader.Read())
                    //    {
                    //        rowsList.Add(GetNewDataRow(reader));
                    //    }
                    //}
                    return cmd.ExecuteReader();
                }
                catch (System.Exception ex)
                {
                    if (ex.Message.ToLower().Contains("socket"))
                    {
                        cm.ReleaseImmediately();
                    }
                    throw;
                }
            }
        }

        protected ICriteriaValue[] fetchCriteria;
        protected void DoFetch(SchemaRelation[] relations, ICriteriaValue[] criteria, params string[] columnNames)
        {
            if (criteria == null)
            {
                criteria = Enumerable.Empty<ICriteriaValue>().ToArray();
            }
            fetchCriteria = criteria;
            if (columnNames != null && columnNames.Length > 0)
            {
                InitColumns(columnNames);
            }
            else
            {
                InitColumns();
            }
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
                    if (DataContext.ShouldSelectSafeStrings)
                    {
                        cmd.CommandText = DataContext.GetSqlFactory().GetSafeSelectSql(TableName, readOnlyColumnsList, criteria);
                    }
                    else
                    {
                        cmd.CommandText = DataContext.GetSqlFactory().GetSelectSql(TableName, readOnlyColumnsList, criteria);
                    }
                }
                else
                {
                    cmd.CommandText = DataContext.GetSqlFactory().GetSelectSql(relations, readOnlyColumnsList, criteria);
                }
                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        //var columnOrdinalDictionary = GetQueryColumnOrdinals(reader);
                        while (reader.Read())
                        {
                            rowsList.Add(GetNewDataRow(reader));
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    if (ex.Message.ToLower().Contains("socket"))
                    {
                        cm.ReleaseImmediately();
                    }
                    throw;
                }
            }
        }

        public IEnumerable<string> GetColumnNames()
        {
            return columnsDictionary.Keys;
        }

        public IDataColumn GetColumnOrNew(string columnName)
        {
            IDataColumn col = null;
            if (!columnsDictionary.TryGetValue(columnName, out col))
            {
                col = InitColumn(columnName);
            }
            return col;
        }

        public virtual List<string> GetInsertStatements()
        {
            throw new NotSupportedException();
        }

        public virtual string GetInsertForRow(DataRow row)
        {
            throw new NotSupportedException();
        }

        protected virtual DataRow GetNewDataRowCore()
        {
            return new DataRow();
        }

        protected DataRow GetNewDataRow(System.Data.IDataRecord record)
        {
            //return new DataRow(this, record, readOnlyColumnsDictionary);
            var row = GetNewDataRowCore();
            row.Table = this;
            row.InitRowProperties(record, readOnlyColumnsDictionary);
            return row;
        }

        public bool HasRows
        {
            get
            {
                return Rows.Count > 0;
            }
        }

        //protected Dictionary<IDataColumn, int> GetQueryColumnOrdinals(System.Data.Common.DbDataReader reader)
        //{
        //    var dict = new Dictionary<IDataColumn, int>();
        //    foreach (var field in FetchFieldList)
        //    {
        //        dict.Add(columnsDictionary[field], reader.GetOrdinal(field));
        //    }
        //    return dict;
        //}

        //public IEnumerable<string> FetchFieldList
        //{
        //    get;
        //    set;
        //}

        //protected SqlFactory sqlFactory;
        //protected SqlFactory GetSqlFactory()
        //{
        //    if (sqlFactory == null)
        //    {
        //        return DataContext.GetSqlFact
        //    }
        //}

        protected internal IDataColumn InitColumn(string columnName, bool ignoreIfNotFound = false)
        {
            return InitColumn(columnName, columnsList.Count, ignoreIfNotFound);
        }

        protected internal IDataColumn InitColumn(string columnName, int ordinalSequence, bool ignoreIfNotFound = false)
        {
            string[] parts = columnName.Split('.');
            SchemaColumn schemaColumn = null;
            if (!DataContext.DbSchema.TablesDictionary[parts[0]].ColumnsDictionary.TryGetValue(columnName, out schemaColumn))
            {
                if (ignoreIfNotFound)
                {
                    return null;
                }
                else
                {
                    throw new ArgumentException("columnName is not a valid SchemaColumn", "columnName");
                }
            }
            var dataColumn = schemaColumn.GetDataColumn(this, ordinalSequence);
            columnsList.Add(dataColumn);
            columnsDictionary.Add(columnName, dataColumn);
            return dataColumn;
        }

        protected internal void InitColumns()
        {
            InitColumns(DataContext.DbSchema.TablesDictionary[TableName].ColumnsDictionary.Keys.ToArray());
        }

        protected ObservableCollection<IDataColumn> columnsList;
        protected Dictionary<string, IDataColumn> columnsDictionary;
        protected internal void InitColumns(string[] columnNames)
        {
            columnsList = new ObservableCollection<IDataColumn>();
            columnsDictionary = new Dictionary<string, IDataColumn>();
            int seq = 0;
            foreach (var name in columnNames)
            {
                InitColumn(name, seq++);
            }
            InitAdditionalColumns();
            readOnlyColumnsList = new ReadOnlyObservableCollection<IDataColumn>(columnsList);
            readOnlyColumnsDictionary = new ReadOnlyDictionary<string, IDataColumn>(columnsDictionary);
        }

        protected virtual void InitAdditionalColumns() { }

        protected virtual void InitRowLists()
        {
            var rows = new ObservableCollection<DataRow>();
            rowsList = rows;
            readOnlyRowsList = new ReadOnlyObservableCollection<DataRow>(rows);
        }

        //protected abstract void InitColumnsCore(ObservableCollection<IDataColumn> list);

        //protected ReadOnlyObservableCollection<IDataColumn> primaryKeyColumns;
        //public ReadOnlyObservableCollection<IDataColumn> PrimaryKeyColumns
        //{
        //    get
        //    {
        //        return primaryKeyColumns;
        //    }
        //}

        protected ObservableCollection<DataRow> rowsList;
        protected ReadOnlyObservableCollection<DataRow> readOnlyRowsList;
        //protected System.Collections.IList rowsList;
        //protected System.Collections.IList readOnlyRowsList;
        public ReadOnlyObservableCollection<DataRow> Rows
        {
            get
            {
                return readOnlyRowsList;
            }
        }

        protected string tableName;
        public virtual string TableName
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }
    }

    [Serializable()]
    public class QueryTable<T, R> : DataTable
        where T : QueryTable<T, R>, new()
        where R : DataRow, new()
    {
        protected internal QueryTable()
            : base() { }

        public static T Fetch(DataContext context, SchemaRelation[] relations, ICriteriaValue[] criteria, params string[] columnNames)
        {
            var table = new T();
            table.TableName = typeof(T).Name;
            table.DataContext = context;
            table.InitRelations(relations);
            table.DoFetch(relations, criteria, columnNames);
            return table;
        }

        protected ObservableCollection<SchemaRelation> relationsList;
        protected Dictionary<string, SchemaRelation> relationsDictionary;
        protected ObservableCollection<SchemaTable> schemaTablesList;
        protected Dictionary<string, SchemaTable> schemaTablesDictionary;
        protected void InitRelations(IEnumerable<SchemaRelation> relations)
        {
            relationsList = new ObservableCollection<SchemaRelation>(relations);
            relationsDictionary = new Dictionary<string, SchemaRelation>();
            schemaTablesList = new ObservableCollection<SchemaTable>();
            schemaTablesDictionary = new Dictionary<string, SchemaTable>();
            foreach (var relation in relations)
            {
                relationsDictionary.Add(relation.RelationName, relation);
                var parentTable = relation.ParentTable;
                var childTable = relation.ChildTable;
                if (!schemaTablesList.Contains(parentTable))
                {
                    schemaTablesList.Add(parentTable);
                    schemaTablesDictionary.Add(parentTable.TableName, parentTable);
                }
                if (!schemaTablesList.Contains(childTable))
                {
                    schemaTablesList.Add(childTable);
                    schemaTablesDictionary.Add(childTable.TableName, childTable);
                }
            }
            readOnlyRelationsList = new ReadOnlyObservableCollection<SchemaRelation>(relationsList);
            readOnlyRelationsDictionary = new ReadOnlyDictionary<string, SchemaRelation>(relationsDictionary);
            readOnlySchemaTablesList = new ReadOnlyObservableCollection<SchemaTable>(schemaTablesList);
            readOnlySchemaTablesDictionary = new ReadOnlyDictionary<string, SchemaTable>(schemaTablesDictionary);
        }

        protected ReadOnlyObservableCollection<SchemaRelation> readOnlyRelationsList;
        public ReadOnlyObservableCollection<SchemaRelation> Relations
        {
            get
            {
                return readOnlyRelationsList;
            }
        }

        protected ReadOnlyDictionary<string, SchemaRelation> readOnlyRelationsDictionary;
        public ReadOnlyDictionary<string, SchemaRelation> RelationsDictionary
        {
            get
            {
                return readOnlyRelationsDictionary;
            }
        }

        protected ReadOnlyObservableCollection<SchemaTable> readOnlySchemaTablesList;
        public ReadOnlyObservableCollection<SchemaTable> SchemaTables
        {
            get
            {
                return readOnlySchemaTablesList;
            }
        }

        protected ReadOnlyDictionary<string, SchemaTable> readOnlySchemaTablesDictionary;
        public ReadOnlyDictionary<string, SchemaTable> SchemaTablesDictionary
        {
            get
            {
                return readOnlySchemaTablesDictionary;
            }
        }

        protected override DataRow GetNewDataRowCore()
        {
            return new R();
        }

        public R this[int index]
        {
            get
            {
                return (R)rowsList[index];
            }
        }
    }

    [Serializable()]
    public class Query : QueryTable<Query, DataRow>
    {
        public Query()
            : base() { }
    }

    [Serializable()]
    public abstract class EditTable<T> : DataTable
        where T : EditTable<T>, new()
    {
        protected internal EditTable()
            : base() { }

        public static T GetEmpty(DataContext context)
        {
            var table = new T();
            table.TableName = typeof(T).Name;
            table.DataContext = context;
            table.InitColumns();
            return table;
        }

        public static T Fetch(DataContext context, ICriteriaValue[] criteria, params string[] columnNames)
        {
            var table = new T();
            table.TableName = typeof(T).Name;
            table.DataContext = context;
            table.DoFetch(null, criteria, columnNames);
            return table;
        }

        //public static S Fetch<S>(DataContext context, ICriteriaValue[] criteria, params string[] columnNames)
        //    where S:T, new()
        //{
        //    var table = new S();
        //    table.TableName = typeof(S).Name;
        //    table.DataContext = context;
        //    table.DoFetch(null, criteria, columnNames);
        //    return table;
        //}

        protected void DoInsert()
        {
            foreach (var row in rowsList)
            {
                //
                // This will forcibly issue an INSERT command for every row with changes
                // Use with caution ...
                //
                if (!row.HasChanges)
                {
                    return;
                }
                using (var cm = DataContext.GetConnectionManager())
                {
                    var cmd = cm.Connection.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    IRowProperty sysRowIDRowProp = null;
                    if (row.PropertiesDictionary.TryGetValue(GetColumnName("SysRowID"), out sysRowIDRowProp))
                    {
                        ((RowProperty<string>)sysRowIDRowProp).Value = Guid.NewGuid().ToString();
                    }
                    cmd.CommandText = DataContext.GetSqlFactory().GetInsertSql(row);
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        // throw something about update error
                    }
                }
            }
        }

        protected void DoUpdate()
        {
            foreach (var row in rowsList)
            {
                if (row.HasChanges || row.IsInserted)
                {
                    using (var cm = DataContext.GetConnectionManager())
                    {
                        var cmd = cm.Connection.CreateCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        if (row.IsInserted)
                        {
                            IRowProperty sysRowIDRowProp = null;
                            if (row.PropertiesDictionary.TryGetValue(GetColumnName("SysRowID"), out sysRowIDRowProp))
                            {
                                ((RowProperty<string>)sysRowIDRowProp).Value = Guid.NewGuid().ToString();
                            }
                            cmd.CommandText = DataContext.GetSqlFactory().GetInsertSql(row);
                        }
                        else
                        {
                            IRowProperty sysRevIDRowProp = null;
                            if (row.PropertiesDictionary.TryGetValue(GetColumnName("SysRevID"), out sysRevIDRowProp))
                            {
                                ((RowProperty<int>)sysRevIDRowProp).Value += 1;
                            }
                            cmd.CommandText = DataContext.GetSqlFactory().GetUpdateSql(row);
                        }
                        if (cmd.ExecuteNonQuery() < 1)
                        {
                            // throw something about update error
                        }
                    }
                }
            }
        }

        public override List<string> GetInsertStatements()
        {
            List<string> insertList = new List<string>();
            foreach (var row in rowsList)
            {
                insertList.Add(GetInsertForRow(row));
            }
            return insertList;
        }

        public override string GetInsertForRow(DataRow row)
        {
            IRowProperty sysRowIDRowProp = null;
            if (row.PropertiesDictionary.TryGetValue(GetColumnName("SysRowID"), out sysRowIDRowProp))
            {
                ((RowProperty<string>)sysRowIDRowProp).Value = Guid.NewGuid().ToString();
            }
            return DataContext.GetSqlFactory().GetInsertSql(row);
        }

        protected string GetColumnName(string columnName)
        {
            return String.Concat(GetSchemaTable().TableName, ".", columnName);
        }

        protected SchemaTable tSchemaTable;
        public SchemaTable GetSchemaTable()
        {
            if (tSchemaTable == null)
            {
                tSchemaTable = DataContext.DbSchema.TablesDictionary[TableName];
            }
            return tSchemaTable;
        }

        //protected DataColumn<int> GetSysRevIDColumn()
        //{
        //    IDataColumn col = null;
        //    var colName = String.Concat(GetSchemaTable().TableName, ".", "SysRevID");
        //    if (!columnsDictionary.TryGetValue(colName, out col))
        //    {
        //        col = InitColumn(colName);
        //    }
        //    return (DataColumn<int>)col;
        //}

        //protected DataColumn<string> GetSysRowIDColumn()
        //{
        //    IDataColumn col = null;
        //    var colName = String.Concat(GetSchemaTable().TableName, ".", "SysRowID");
        //    if (!columnsDictionary.TryGetValue(colName, out col))
        //    {
        //        col = InitColumn(colName);
        //    }
        //    return (DataColumn<string>)col;
        //}

        protected override void InitAdditionalColumns()
        {
            base.InitAdditionalColumns();
            var sysRevIDName = String.Concat(GetSchemaTable().TableName, ".", "SysRevID");
            if (!columnsDictionary.ContainsKey(sysRevIDName))
            {
                InitColumn(sysRevIDName, true);
            }
            var sysRowIDName = String.Concat(GetSchemaTable().TableName, ".", "SysRowID");
            if (!columnsDictionary.ContainsKey(sysRowIDName))
            {
                InitColumn(sysRowIDName, true);
            }
        }

        public void Remove(DataRow row)
        {
            using (var cm = DataContext.GetConnectionManager())
            {
                var cmd = cm.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = DataContext.GetSqlFactory().GetDeleteSql(row);
                if (cmd.ExecuteNonQuery() < 1)
                {
                    // throw something about update error
                }
            }
        }

        public void ForceInsert()
        {
            DoInsert();
        }

        public void Update()
        {
            DoUpdate();
        }

        //protected static SchemaTable schemaTable;
        //public static SchemaTable SchemaTable
        //{
        //    get
        //    {
        //        if (schemaTable == null)
        //        {
        //            return DataContext.DbSchema.TablesDictionary[
        //        }
        //    }
        //}

        //public override string TableName
        //{
        //    get
        //    {
        //        if (String.IsNullOrWhiteSpace(tableName))
        //        {
        //            return SchemaTable.TableName;
        //        }
        //        else
        //        {
        //            return base.TableName;
        //        }
        //    }
        //    set
        //    {
        //        base.TableName = value;
        //    }
        //}
    }

    [Serializable()]
    public abstract class EditTable<T, R> : EditTable<T>
        where T : EditTable<T, R>, new()
        where R : DataRow, new()
    {
        protected internal EditTable()
            : base() { }

        protected override DataRow GetNewDataRowCore()
        {
            return new R();
        }

        public R NewRow()
        {
            var row = GetNewDataRow(null);
            row.IsInserted = true;
            rowsList.Add(row);
            return (R)row;
        }

        public R this[int index]
        {
            get
            {
                return (R)rowsList[index];
            }
        }

        new public IEnumerable<R> Rows
        {
            get
            {
                return base.Rows.OfType<R>();
            }
        }
    }
}
