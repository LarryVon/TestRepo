using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using SFEpic.Collections.Generic;

namespace SFEpic.Data
{
    [Serializable()]
    public class DataRow
    {
        //protected internal DataRow(DataTable table)
        //{
        //    Table = table;
        //    InitRowProperties(null, null);
        //}

        //protected internal DataRow(DataTable table, System.Data.IDataRecord record, IDictionary<string, IDataColumn> columnsDictionary)
        //{
        //    Table = table;
        //    InitRowProperties(record, columnsDictionary);
        //}

        protected IRowProperty GetRowProperty(string propertyName, System.Data.IDataRecord record)
        {
            var column = Table.GetColumnOrNew(propertyName);
            if (column == null)
            {
                throw new NullReferenceException();
            }
            return GetRowProperty(column, record);
        }

        protected IRowProperty GetRowProperty(IDataColumn column, System.Data.IDataRecord record)
        {
            IRowProperty rowProperty = null;
            var columnName = String.Concat(column.SchemaColumn.SchemaTable.TableName, ".", column.SchemaColumn.SchemaColumnName);
            if (!propertiesDictionary.TryGetValue(columnName, out rowProperty))
            {
                if (record == null)
                {
                    rowProperty = column.GetRowProperty(this);
                    //IsInserted = true;
                }
                else
                {
                    rowProperty = column.GetRowPropertyWithValue(this, record, column.OrdinalSequence);
                }
                propertyList.Add(rowProperty);
                propertiesDictionary.Add(columnName, rowProperty);
            }
            return rowProperty;
        }

        protected RowProperty<bool> GetBooleanProperty(string propertyName)
        {
            return (RowProperty<bool>)GetRowProperty(propertyName, null);
        }

        protected RowProperty<DateTime> GetDateTimeProperty(string propertyName)
        {
            return (RowProperty<DateTime>)GetRowProperty(propertyName, null);
        }

        protected RowProperty<decimal> GetDecimalProperty(string propertyName)
        {
            return (RowProperty<decimal>)GetRowProperty(propertyName, null);
        }

        protected RowProperty<int> GetIntegerProperty(string propertyName)
        {
            return (RowProperty<int>)GetRowProperty(propertyName, null);
        }

        protected RowProperty<DateTime?> GetNullableDateTimeProperty(string propertyName)
        {
            return (RowProperty<DateTime?>)GetRowProperty(propertyName, null);
        }

        protected RowProperty<string> GetStringProperty(string propertyName)
        {
            return (RowProperty<string>)GetRowProperty(propertyName, null);
        }

        public ReadOnlyObservableCollection<IRowProperty> GetChangedProperties()
        {
            ObservableCollection<IRowProperty> list = new ObservableCollection<IRowProperty>();
            foreach (var prop in propertyList)
            {
                if (prop.IsChanged)
                {
                    list.Add(prop);
                }
            }
            return new ReadOnlyObservableCollection<IRowProperty>(list);
        }

        public ReadOnlyCollection<IRowProperty> GetPrimaryKeyProperties()
        {
            ObservableCollection<IRowProperty> list = new ObservableCollection<IRowProperty>();
            foreach (var prop in propertyList)
            {
                if (prop.Column.SchemaColumn.IsPrimaryKey)
                {
                    list.Add(prop);
                }
            }
            return new ReadOnlyObservableCollection<IRowProperty>(list);
        }

        public bool HasChanges
        {
            get
            {
                foreach (var prop in propertyList)
                {
                    if (prop.IsChanged)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        protected Dictionary<string, IRowProperty> propertiesDictionary;
        protected ObservableCollection<IRowProperty> propertyList;
        protected ReadOnlyObservableCollection<IRowProperty> properties;
        protected internal virtual void InitRowProperties(System.Data.IDataRecord record, IDictionary<string, IDataColumn> columnsDictionary)
        {
            propertyList = new ObservableCollection<IRowProperty>();
            properties = new ReadOnlyObservableCollection<IRowProperty>(propertyList);
            propertiesDictionary = new Dictionary<string, IRowProperty>();
            //if (record == null)
            //{
            //    foreach (var column in Table.Columns)
            //    {
            //        var rowProperty = column.GetRowProperty(this);
            //        propertyList.Add(rowProperty);
            //        propertiesDictionary.Add(column.ColumnName, rowProperty);
            //    }
            //}
            //else
            //{
            //    foreach (var kvp in columnsDictionary)
            //    {
            //        var column = kvp.Value;
            //        var rowProperty = column.GetRowPropertyWithValue(this, record, column.OrdinalSequence);
            //        propertyList.Add(rowProperty);
            //        propertiesDictionary.Add(column.ColumnName, rowProperty);
            //    }
            //}
            foreach (var kvp in columnsDictionary)
            {
                GetRowProperty(kvp.Value, record);
                //var column = kvp.Value;
                //var rowProperty = column.GetRowPropertyWithValue(this, record, column.OrdinalSequence);
                //propertyList.Add(rowProperty);
                //propertiesDictionary.Add(column.ColumnName, rowProperty);
            }
            readOnlyPropertiesDictionary = new ReadOnlyDictionary<string, IRowProperty>(propertiesDictionary);
        }

        public bool IsInserted
        {
            get;
            protected internal set;
        }

        protected ReadOnlyDictionary<string, IRowProperty> readOnlyPropertiesDictionary;
        public ReadOnlyDictionary<string, IRowProperty> PropertiesDictionary
        {
            get
            {
                return readOnlyPropertiesDictionary;
            }
        }

        public DataTable Table
        {
            get;
            protected internal set;
        }
    }
}
