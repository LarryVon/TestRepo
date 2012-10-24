using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data.Common;
using SFEpic.Collections.Generic;

namespace SFEpic.Data
{
    [Serializable()]
    public class DataContext
    {
        //public DataSet(string dbProvider, string connectionString, params Type[] tableTypes)
        //{
        //    ConnectionString = connectionString;
        //    DbProvider = dbProvider;
        //    InitTables(tableTypes);
        //}

        public DataContext()
        {
            //ConnectionString = connectionString;
            //DbProvider = dbProvider;
            tablesList = new ObservableCollection<DataTable>();
            readOnlyTablesList = new ReadOnlyObservableCollection<DataTable>(tablesList);
            tablesDictionary = new Dictionary<string, DataTable>();
            readOnlyTablesDictionary = new ReadOnlyDictionary<string, DataTable>(tablesDictionary);
        }

        public void AddTable<T>(params string[] columnNames) where T:DataTable, new()
        {
            AddTable<T>(typeof(T).Name);
        }

        public void AddTable<T>(string tableName, params string[] columnNames) where T:DataTable, new()
        {
            InitTable(new T(), tableName, columnNames);
        }

        public void AddTable(SchemaTable schemaTable, params string[] columnNames)
        {
            InitTable(new DataTable() { DataContext = this }, schemaTable.TableName, columnNames);
        }

        public void AddTable(SchemaTable schemaTable, string tableName, params string[] columnNames)
        {
            InitTable(new DataTable() { DataContext = this }, tableName, columnNames);
        }

        public string CompanyNum
        {
            get;
            set;
        }

        public string ConnectionString
        {
            get;
            protected internal set;
        }

        public string DbProvider
        {
            get;
            protected internal set;
        }

        public DataTable Get(SchemaTable schemaTable, ICriteriaValue[] criteria, IEnumerable<string> columnsToSkip = null)
        {
            if (!DbSchema.Tables.Contains(schemaTable))
            {
                return null;
            }
            var type = this.GetType();
            var getMethodName = String.Concat("Get", schemaTable.TableName);
            var getAllMethod = type.GetMethod(getMethodName);
            if (getAllMethod != null)
            {
                //return (DataTable)getAllMethod.Invoke(this, new object[] { criteria, null});
                try
                {
                    if (columnsToSkip == null || columnsToSkip.Count() == 0)
                    {
                        return (DataTable)getAllMethod.Invoke(this, new object[] { criteria });
                    }
                    else
                    {
                        //var columnNames = (from c in schemaTable.Columns
                        //              where !columnsToSkip.Contains(c.ColumnName)
                        //              select c.ColumnName).ToArray();
                        var columnNames = (from c in schemaTable.Columns
                                           where !columnsToSkip.Contains(c.ColumnName)
                                           select string.Concat(schemaTable.TableName, ".", c.ColumnName)).ToArray();
                        return (DataTable)getAllMethod.Invoke(this, new object[] { criteria, columnNames }); 
                    }
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }
            return null;
        }

        public DataTable GetAll(SchemaTable schemaTable)
        {
            if (!DbSchema.Tables.Contains(schemaTable))
            {
                return null;
            }
            var type = this.GetType();
            var getAllMethodName = String.Concat("GetAll", schemaTable.TableName);
            var getAllMethod = type.GetMethod(getAllMethodName);
            if (getAllMethod != null)
            {
                return (DataTable)getAllMethod.Invoke(this, null);
            }
            return null;
        }

        [NonSerialized()]
        protected ConnectionManager connectionManager;
        public ConnectionManager GetConnectionManager()
        {
            if (connectionManager == null || connectionManager.IsDisposed)
            {
                connectionManager = new ConnectionManager(DbProvider, ConnectionString, true);
            }
            connectionManager.AddRef();
            return connectionManager;
        }

        protected SqlFactory sqlFactory;
        public SqlFactory GetSqlFactory()
        {
            if (DbProvider.ToLower().Contains("odbc"))
            {
                sqlFactory = SqlFactory.GetFactory(SqlFactoryType.Progress);
            }
            else
            {
                sqlFactory = SqlFactory.GetFactory(SqlFactoryType.SqlServer);
            }
            return sqlFactory;
        }

        protected void InitTable(DataTable table, string tableName, string[] columnNames)
        {
            table.DataContext = this;
            table.TableName = tableName;
            table.InitColumns(columnNames);
            tablesList.Add(table);
            tablesDictionary.Add(tableName, table);
        }

        protected internal virtual void InitTables() { }

        //protected virtual void InitTablesCore(Dictionary<string, Type> tablesTypesDictionary)
        //{
        //    foreach (var type in tableTypes)
        //    {
        //        DataTable table = (DataTable)Activator.CreateInstance(type);
        //        table.DataContext = this;
        //        tablesCol.Add(table);
        //    }
        //}

        protected ObservableCollection<DataTable> tablesList;
        protected Dictionary<string, DataTable> tablesDictionary;
        //protected void InitTables(Dictionary<string, Type> tablesTypesDictionary)
        //{
        //    //InitTablesCore(tablesTypesDictionary);
        //    foreach (var kvp in tablesTypesDictionary)
        //    {
        //        InitTable((DataTable)Activator.CreateInstance(kvp.Value), kvp.Key);
        //    }
        //}

        protected DbSchema dbSchema;
        public DbSchema DbSchema
        {
            get
            {
                return dbSchema;
            }
            protected internal set
            {
                dbSchema = value;
            }
        }

        public bool ShouldFormatCleanStrings
        {
            get;
            set;
        }

        public bool ShouldSelectSafeStrings
        {
            get;
            set;
        }

        protected ReadOnlyObservableCollection<DataTable> readOnlyTablesList;
        public ReadOnlyObservableCollection<DataTable> Tables
        {
            get
            {
                return readOnlyTablesList;
            }
        }

        protected ReadOnlyDictionary<string, DataTable> readOnlyTablesDictionary;
        public ReadOnlyDictionary<string, DataTable> TablesDictionary
        {
            get
            {
                return readOnlyTablesDictionary;
            }
        }
    }
}
