using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SFEpic.Collections.Generic;

namespace SFEpic.Data
{
    [Serializable()]
    public abstract class SchemaTable
    {
        protected SchemaTable(string tableName)
        {
            TableName = tableName;
            InitColumns();
            InitPrimaryKeys();
        }

        public IList<SchemaColumn> GetColumns(params string[] columnNames)
        {
            var list = new List<SchemaColumn>();
            foreach (var name in columnNames)
            {
                //string shortName = null;
                //string[] nameParts = name.Split('.');
                //if (nameParts.Length == 1)
                //{
                //    shortName = nameParts[0];
                //}
                //else
                //{
                //    shortName = nameParts[1];
                //}
                //list.Add(columnsDictionary[shortName]);
                list.Add(columnsDictionary[name]);
            }
            return list;
        }

        public IEnumerable<ICriteriaValue> GetPrimaryKeyCriteriaValues()
        {
            List<ICriteriaValue> criteria = new List<ICriteriaValue>();
            foreach (var pk in primaryKeysList)
            {
                criteria.Add(pk.GetCriteriaValue());
            }
            return criteria;
        }

        public IEnumerable<ICriteriaValue> GetPrimaryKeyCriteriaValues(string[] values)
        {
            return GetPrimaryKeyCriteriaValues(values.ToArray<object>());
        }

        public IEnumerable<ICriteriaValue> GetPrimaryKeyCriteriaValues(object[] values)
        {
            if (values.Length != primaryKeysList.Count)
            {
                throw new ArgumentException("values must have the same number of elements as PrimaryKeys", "values");
            }
            List<ICriteriaValue> criteria = new List<ICriteriaValue>();
            for (int i = 0; i < primaryKeysList.Count; i++)
            {
                criteria.Add(primaryKeysList[i].GetCriteriaValue(values[i]));
            }
            return criteria;
        }

        protected abstract void InitColumnsCore(ref int seq);

        protected ObservableCollection<SchemaColumn> columnsList;
        protected Dictionary<string, SchemaColumn> columnsDictionary;
        protected void InitColumns()
        {
            columnsList = new ObservableCollection<SchemaColumn>();
            var seq = 0;
            InitColumnsCore(ref seq);
            columnsDictionary = new Dictionary<string, SchemaColumn>();
            foreach (var column in columnsList)
            {
                columnsDictionary.Add(String.Concat(TableName, ".", column.ColumnName), column);
            }
            readOnlyColumnsList = new ReadOnlyObservableCollection<SchemaColumn>(columnsList);
            readOnlyColumnsDictionary = new ReadOnlyDictionary<string, SchemaColumn>(columnsDictionary);
        }

        protected abstract void InitPrimaryKeysCore();

        protected ObservableCollection<SchemaColumn> primaryKeysList;
        protected void InitPrimaryKeys()
        {
            primaryKeysList = new ObservableCollection<SchemaColumn>();
            InitPrimaryKeysCore();
            readOnlyPrimaryKeysList = new ReadOnlyObservableCollection<SchemaColumn>(primaryKeysList);
        }

        protected ReadOnlyObservableCollection<SchemaColumn> readOnlyColumnsList;
        public ReadOnlyObservableCollection<SchemaColumn> Columns
        {
            get
            {
                return readOnlyColumnsList;
            }
        }

        protected ReadOnlyDictionary<string, SchemaColumn> readOnlyColumnsDictionary;
        public ReadOnlyDictionary<string, SchemaColumn> ColumnsDictionary
        {
            get
            {
                return readOnlyColumnsDictionary;
            }
        }

        protected ReadOnlyObservableCollection<SchemaColumn> readOnlyPrimaryKeysList;
        public ReadOnlyObservableCollection<SchemaColumn> PrimaryKeys
        {
            get
            {
                return readOnlyPrimaryKeysList;
            }
        }

        public string TableName
        {
            get;
            protected set;
        }
    }
}
