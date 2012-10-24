using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Collections.Generic;

namespace SFEpic.Data
{
    [Serializable()]
    public abstract class Environment
    {
        protected Environment(string environmentName)
        {
            EnvironmentName = environmentName;
            InitSchemas();
        }

        public string EnvironmentName
        {
            get;
            protected set;
        }

        protected abstract void InitSchemasCore();

        protected ObservableCollection<DbSchema> schemasList;
        protected Dictionary<string, DbSchema> schemasDictionary;
        protected void InitSchemas()
        {
            schemasList = new ObservableCollection<DbSchema>();
            InitSchemasCore();
            schemasDictionary = new Dictionary<string, DbSchema>();
            foreach (var schema in schemasList)
            {
                schemasDictionary.Add(schema.SchemaName, schema);
            }
            readOnlySchemasList = new ReadOnlyObservableCollection<DbSchema>(schemasList);
            readOnlySchemasDictionary = new ReadOnlyDictionary<string, DbSchema>(schemasDictionary);
        }

        protected ReadOnlyObservableCollection<DbSchema> readOnlySchemasList;
        public ReadOnlyObservableCollection<DbSchema> Schemas
        {
            get
            {
                return readOnlySchemasList;
            }
        }

        protected ReadOnlyDictionary<string, DbSchema> readOnlySchemasDictionary;
        public ReadOnlyDictionary<string, DbSchema> SchemasDictionary
        {
            get
            {
                return readOnlySchemasDictionary;
            }
        }
    }
}
