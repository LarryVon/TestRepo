using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Collections.Generic;

namespace SFEpic.Data
{
    [Serializable()]
    public abstract class DbSchema
    {
        protected DbSchema(string schemaName)
        {
            SchemaName = schemaName;
            InitTables();
            InitRelations();
        }

        //public string ConnectionString
        //{
        //    get;
        //    set;
        //}

        public T GetDataContext<T>(string dbProvider, string connectionString) where T : DataContext, new()
        {
            var context = new T() { DbSchema = this, DbProvider = dbProvider, ConnectionString = connectionString };
            context.InitTables();
            return context;
        }

        protected abstract void InitRelationsCore();

        protected ObservableCollection<SchemaRelation> relationsList;
        protected Dictionary<string, SchemaRelation> relationsDictionary;
        protected void InitRelations()
        {
            relationsList = new ObservableCollection<SchemaRelation>();
            InitRelationsCore();
            relationsDictionary = new Dictionary<string, SchemaRelation>();
            foreach (var relation in relationsList)
            {
                relationsDictionary.Add(relation.RelationName, relation);
            }
            readOnlyRelationsList = new ReadOnlyObservableCollection<SchemaRelation>(relationsList);
            readOnlyRelationsDictionary = new ReadOnlyDictionary<string, SchemaRelation>(relationsDictionary);
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

        public string SchemaName
        {
            get;
            protected set;
        }

        public virtual SchemaType SchemaType
        {
            get;
            set;
        }

        protected abstract void InitTablesCore();

        protected ObservableCollection<SchemaTable> tablesList;
        protected Dictionary<string, SchemaTable> tablesDictionary;
        protected void InitTables()
        {
            tablesList = new ObservableCollection<SchemaTable>();
            InitTablesCore();
            tablesDictionary = new Dictionary<string, SchemaTable>();
            foreach (var table in tablesList)
            {
                tablesDictionary.Add(table.TableName, table);
            }
            readOnlyTablesList = new ReadOnlyObservableCollection<SchemaTable>(tablesList);
            readOnlyTablesDictionary = new ReadOnlyDictionary<string, SchemaTable>(tablesDictionary);
        }

        protected ReadOnlyObservableCollection<SchemaTable> readOnlyTablesList;
        public ReadOnlyObservableCollection<SchemaTable> Tables
        {
            get
            {
                return readOnlyTablesList;
            }
        }

        protected ReadOnlyDictionary<string, SchemaTable> readOnlyTablesDictionary;
        public ReadOnlyDictionary<string, SchemaTable> TablesDictionary
        {
            get
            {
                return readOnlyTablesDictionary;
            }
        }
    }
}
