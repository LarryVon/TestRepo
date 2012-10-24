using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    public interface ICriteriaValue
    {
        IDataColumn Column { get; set; }
        SchemaColumn SchemaColumn { get; }
        object Value { get; set; }
    }

    //[Serializable()]
    //public class CriteriaValue<T> : ICriteriaValue
    //    where T:IEquatable<T>
    [Serializable()]
    public class CriteriaValue<T> : ICriteriaValue
    {
        public CriteriaValue(DataColumn<T> column, T value)
        {
            Column = column;
            Value = value;
        }

        public CriteriaValue(SchemaColumn schemaColumn)
        {
            SchemaColumn = schemaColumn;
        }

        public CriteriaValue(SchemaColumn schemaColumn, T value)
        {
            SchemaColumn = schemaColumn;
            Value = value;
        }

        public DataColumn<T> Column
        {
            get;
            protected set;
        }

        public SchemaColumn SchemaColumn
        {
            get;
            set;
        }

        public T Value
        {
            get;
            set;
        }

        IDataColumn ICriteriaValue.Column
        {
            get { return Column; }
            set { Column = (DataColumn<T>)value; }
        }

        object ICriteriaValue.Value
        {
            get { return Value; }
            set { Value = (T)value; }
        }
    }
}
