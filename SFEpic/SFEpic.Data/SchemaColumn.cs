using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public abstract class SchemaColumn
    {
        protected internal SchemaColumn() { }

        public string ColumnName
        {
            get;
            protected internal set;
        }

        public abstract Type ClrType { get; }
        public abstract System.Data.DbType DbType { get; }

        public string DefaultValue
        {
            get;
            protected internal set;
        }

        public abstract ICriteriaValue GetCriteriaValue();
        public abstract ICriteriaValue GetCriteriaValue(object value);
        public abstract IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence);

        public bool IsNullable
        {
            get;
            protected internal set;
        }

        protected internal bool isPrimaryKey;
        public bool IsPrimaryKey
        {
            get
            {
                return isPrimaryKey;
            }
            //
            // Figure out way to set this from the field initializer
            //
            set
            {
                isPrimaryKey = value;
                if (value)
                {
                    IsRequired = true;
                }
            }
        }

        public bool IsRequired
        {
            get;
            protected internal set;
        }

        protected internal int ordinalSequence = -1;
        public int OrdinalSequence
        {
            get
            {
                return ordinalSequence;
            }
            set
            {
                ordinalSequence = value;
            }
        }

        protected internal string schemaColumnName;
        public string SchemaColumnName
        {
            get
            {
                if (String.IsNullOrWhiteSpace(schemaColumnName))
                {
                    return ColumnName;
                }
                return schemaColumnName;
            }
            protected internal set
            {
                schemaColumnName = value;
            }
        }

        public SchemaTable SchemaTable
        {
            get;
            protected internal set;
        }

        public virtual string FormatLiteral(SqlFactory sqlFactory, object literal)
        {
            if (literal == null)
            {
                return "NULL";
            }
            var stringValue = literal.ToString();
            bool boolValue;
            if (Boolean.TryParse(stringValue, out boolValue))
            {
                return boolValue ? "1" : "0";
            }
            DateTime dateTimeValue;
            if (DateTime.TryParse(stringValue, out dateTimeValue))
            {
                return String.Concat(sqlFactory.StringDelimiter, dateTimeValue.ToString("yyyy-MM-dd"), sqlFactory.StringDelimiter);
            }
            Decimal decimalValue;
            if (Decimal.TryParse(stringValue, out decimalValue))
            {
                return stringValue;
            }
            Int32 intValue;
            if (Int32.TryParse(stringValue, out intValue))
            {
                return stringValue;
            }
            return String.Concat(sqlFactory.StringDelimiter, stringValue, sqlFactory.StringDelimiter);
        }
    }

    [Serializable()]
    public class TextSchemaColumn : SchemaColumn
    {
        protected internal TextSchemaColumn() { }

        public override Type ClrType
        {
            get { return typeof(string); }
        }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.AnsiString; }
        }

        public override ICriteriaValue GetCriteriaValue()
        {
            return new CriteriaValue<string>(this);
        }

        public override ICriteriaValue GetCriteriaValue(object value)
        {
            return new CriteriaValue<string>(this, value.ToString());
        }

        public ICriteriaValue GetCriteriaValue(string value)
        {
            return new CriteriaValue<string>(this, value);
        }

        public override IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence)
        {
            return new StringDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
        }

        public virtual bool IsFixedWidth 
        {
            get
            {
                return false;
            }
        }

        public int MaxLength
        {
            get;
            protected internal set;
        }
    }

    [Serializable()]
    public class FixedWidthTextSchemaColumn : TextSchemaColumn
    {
        protected internal FixedWidthTextSchemaColumn() { }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.AnsiStringFixedLength; }
        }

        public override bool IsFixedWidth
        {
            get { return true; }
        }
    }

    [Serializable()]
    public abstract class NumericSchemaColumn : SchemaColumn
    {
        protected internal NumericSchemaColumn() { }
    }

    [Serializable()]
    public class IntegerSchemaColumn : NumericSchemaColumn
    {
        protected internal IntegerSchemaColumn() { }

        public override Type ClrType
        {
            get { return typeof(int); }
        }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.Int32; }
        }

        public override ICriteriaValue GetCriteriaValue()
        {
            return new CriteriaValue<int>(this);
        }

        public override ICriteriaValue GetCriteriaValue(object value)
        {
            return new CriteriaValue<int>(this, (int)value);
        }

        public ICriteriaValue GetCriteriaValue(int value)
        {
            return new CriteriaValue<int>(this, value);
        }

        public override IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence)
        {
            return new IntegerDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
        }

        public int MaxValue
        {
            get;
            protected internal set;
        }

        public int MinValue
        {
            get;
            protected internal set;
        }
    }

    [Serializable()]
    public class DecimalSchemaColumn : NumericSchemaColumn
    {
        protected internal DecimalSchemaColumn() { }

        public override Type ClrType
        {
            get { return typeof(decimal); }
        }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.Decimal; }
        }

        public override ICriteriaValue GetCriteriaValue()
        {
            return new CriteriaValue<decimal>(this);
        }

        public override ICriteriaValue GetCriteriaValue(object value)
        {
            return new CriteriaValue<decimal>(this, (decimal)value);
        }

        public ICriteriaValue GetCriteriaValue(decimal value)
        {
            return new CriteriaValue<decimal>(this, value);
        }

        public override IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence)
        {
            return new DecimalDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
        }

        public decimal MaxValue
        {
            get;
            protected internal set;
        }

        public decimal MinValue
        {
            get;
            protected internal set;
        }

        public byte Precision
        {
            get;
            protected internal set;
        }

        public byte Scale
        {
            get;
            protected internal set;
        }
    }

    [Serializable()]
    public class BooleanSchemaColumn : SchemaColumn
    {
        protected internal BooleanSchemaColumn() { }

        public override Type ClrType
        {
            get { return typeof(bool); }
        }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.Boolean; }
        }

        public override ICriteriaValue GetCriteriaValue()
        {
            return new CriteriaValue<bool>(this);
        }

        public override ICriteriaValue GetCriteriaValue(object value)
        {
            return new CriteriaValue<bool>(this, (bool)value);
        }

        public ICriteriaValue GetCriteriaValue(bool value)
        {
            return new CriteriaValue<bool>(this, value);
        }

        public override IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence)
        {
            return new BooleanDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
        }
    }

    [Serializable()]
    public class DateTimeSchemaColumn : SchemaColumn
    {
        protected internal DateTimeSchemaColumn() { }

        public override Type ClrType
        {
            get { return typeof(DateTime); }
        }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.DateTime; }
        }

        public override ICriteriaValue GetCriteriaValue()
        {
            return new CriteriaValue<DateTime>(this);
        }

        public override ICriteriaValue GetCriteriaValue(object value)
        {
            if (IsNullable)
            {
                return new CriteriaValue<DateTime?>(this, value == null || value == System.DBNull.Value ? default(DateTime?) : (DateTime)value);
            }
            else
            {
                return new CriteriaValue<DateTime>(this, (DateTime)value);
            }
        }

        public ICriteriaValue GetCriteriaValue(DateTime value)
        {
            return new CriteriaValue<DateTime>(this, value);
        }

        public override IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence)
        {
            if (IsNullable)
            {
                return new NullableDateTimeDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
            }
            return new DateTimeDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
        }

        public DateTime MaxValue
        {
            get;
            protected internal set;
        }

        public DateTime MinValue
        {
            get;
            protected internal set;
        }

        public virtual bool SupportsTime
        {
            get
            {
                return true;
            }
        }
    }

    [Serializable()]
    public class DateSchemaColumn : DateTimeSchemaColumn
    {
        protected internal DateSchemaColumn() { }

        public override System.Data.DbType DbType
        {
            get
            {
                return System.Data.DbType.Date;
            }
        }

        public override bool SupportsTime
        {
            get
            {
                return false;
            }
        }
    }

    [Serializable()]
    public class TimeSchemaColumn : SchemaColumn
    {
        protected internal TimeSchemaColumn() { }

        public override Type ClrType
        {
            get { return typeof(TimeSpan); }
        }

        public override System.Data.DbType DbType
        {
            get { return System.Data.DbType.Time; }
        }

        public override ICriteriaValue GetCriteriaValue()
        {
            return new CriteriaValue<DateTime>(this);
        }

        public override ICriteriaValue GetCriteriaValue(object value)
        {
            return new CriteriaValue<DateTime>(this, (DateTime)value);
        }

        public override IDataColumn GetDataColumn(DataTable dataTable, int ordinalSequence)
        {
            return new DateTimeDataColumn() { Table = dataTable, OrdinalSequence = ordinalSequence, SchemaColumn = this };
        }

        public TimeSpan MaxValue
        {
            get;
            protected internal set;
        }

        public TimeSpan MinValue
        {
            get;
            protected internal set;
        }
    }
}
