using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public class DataColumn<T> : IDataColumn
    {
        protected internal DataColumn() { }

        //public DataColumn(DataTable table, string columnName, System.Data.DbType dbType)
        //{
        //    Table = table;
        //    ColumnName = columnName;
        //    DbType = dbType;
        //    defaultValue = GetDefaultValue();
        //}

        //public DataColumn(DataTable table, string columnName, System.Data.DbType dbType, int ordinalSequence, string alias = null, bool isNullable = false, bool isPrimaryKey = false, bool isRequired = false, T defaultValue = default(T))
        //{
        //    Table = table;
        //    ColumnName = columnName;
        //    DbType = dbType;
        //    OrdinalSequence = ordinalSequence;
        //    Alias = alias;
        //    IsNullable = isNullable;
        //    IsPrimaryKey = isPrimaryKey;
        //    IsRequired = isRequired;
        //    DefaultValue = defaultValue;
        //    //if (defaultValue.Equals(default(T)))
        //    //{
        //    //    DefaultValue = GetDefaultValue();
        //    //}
        //    //else
        //    //{
        //    //    DefaultValue = defaultValue;
        //    //}
        //}

        //protected string alias;
        //public string Alias
        //{
        //    get
        //    {
        //        if (String.IsNullOrWhiteSpace(alias))
        //        {
        //            return ColumnName;
        //        }
        //        else
        //        {
        //            return alias;
        //        }
        //    }
        //    protected set
        //    {
        //        alias = value;
        //    }
        //}

        //public string ColumnName
        //{
        //    get;
        //    protected internal set;
        //}

        public string ColumnName
        {
            get
            {
                return SchemaColumn.ColumnName;
            }
        }

        //public System.Data.DbType DbType
        //{
        //    get;
        //    protected internal set;
        //}

        //protected T defaultValue;
        //public T DefaultValue
        //{
        //    get
        //    {
        //        return defaultValue;
        //    }
        //    set
        //    {
        //        if (!IsNullable && value == null)
        //        {
        //            throw new ArgumentException("value cannot be null when IsNullable is false", "value");
        //        }
        //        defaultValue = value;
        //    }
        //}

        public T DefaultValue
        {
            get
            {
                return GetDefaultValue();
            }
        }

        public virtual string FormatLiteral(SqlFactory sqlFactory, T literal)
        {
            return literal.ToString();
        }

        protected virtual T GetDefaultValue()
        {
            return default(T);
        }

        public virtual RowProperty<T> GetRowProperty(DataRow row)
        {
            return new RowProperty<T>(row, this);
        }

        public virtual RowProperty<T> GetRowPropertyWithValue(DataRow row, System.Data.IDataRecord record, int ordinal)
        {
            return new RowProperty<T>(row, this, ReadValue(record, ordinal));
        }

        //public bool IsNullable
        //{
        //    get;
        //    protected internal set;
        //}

        //public bool IsPrimaryKey
        //{
        //    get;
        //    protected internal set;
        //}

        //public bool IsRequired
        //{
        //    get;
        //    protected internal set;
        //}

        protected int ordinalSequence = -1;
        public int OrdinalSequence
        {
            get
            {
                return ordinalSequence;
            }
            protected internal set
            {
                ordinalSequence = value;
            }
        }

        protected virtual T ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return (T)reader.GetValue(ordinal);
        }

        public T ReadValue(System.Data.IDataRecord reader, int ordinal)
        {
            if (!reader.IsDBNull(ordinal))
            {
                return ReadValueCore(reader, ordinal);
            }
            return default(T);
        }

        public SchemaColumn SchemaColumn
        {
            get;
            protected internal set;
        }

        public DataTable Table
        {
            get;
            protected internal set;
        }

        //object IDataColumn.DefaultValue
        //{
        //    get
        //    {
        //        return this.DefaultValue;
        //    }
        //}

        IRowProperty IDataColumn.GetRowProperty(DataRow row)
        {
            return this.GetRowProperty(row);
        }

        IRowProperty IDataColumn.GetRowPropertyWithValue(DataRow row, System.Data.IDataRecord record, int ordinal)
        {
            return this.GetRowPropertyWithValue(row, record, ordinal);
        }

        string IDataColumn.FormatLiteral(SqlFactory sqlFactory, object literal)
        {
            return this.FormatLiteral(sqlFactory, (T)literal);
        }

        //bool IDataColumn.IsNullable
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //bool IDataColumn.IsPrimaryKey
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //bool IDataColumn.IsRequired
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //int IDataColumn.OrdinalSequence
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //DataTable IDataColumn.Table
        //{
        //    get { throw new NotImplementedException(); }
        //}
    }

    //public abstract class MinMaxValueDataColumn<T> : DataColumn<T>
    //    where T:IEquatable<T>
    //{
    //    //public MinMaxValueDataColumn(DataTable table, string columnName, System.Data.DbType dbType)
    //    //    : base(table, columnName, dbType)
    //    //{
    //    //}

    //    //public MinMaxValueDataColumn(DataTable table, string columnName, System.Data.DbType dbType, int ordinalSequence, string alias = null, bool isNullable = false, bool isPrimaryKey = false, bool isRequired = false, T defaultValue = default(T))
    //    //    : base(table, columnName, dbType, ordinalSequence, alias, isNullable, isPrimaryKey, isRequired, defaultValue)
    //    //{
    //    //}

    //    protected internal MinMaxValueDataColumn() { }

    //    protected abstract void SetDefaultMaxValue();
    //    protected abstract void SetDefaultMinValue();

    //    public T MaxValue
    //    {
    //        get;
    //        protected internal set;
    //    }

    //    public T MinValue
    //    {
    //        get;
    //        protected internal set;
    //    }
    //}

    [Serializable()]
    public class BooleanDataColumn : DataColumn<bool>
    {
        //public BooleanDataColumn(DataTable table, string columnName)
        //    : base(table, columnName, System.Data.DbType.Boolean)
        //{
        //}

        //public BooleanDataColumn(DataTable table, string columnName, int ordinalSequence, string alias = null, bool isPrimaryKey = false, bool isRequired = false, bool defaultValue = false)
        //    : base(table, columnName, System.Data.DbType.Boolean, ordinalSequence, alias, false, isPrimaryKey, isRequired, defaultValue)
        //{
        //}

        protected internal BooleanDataColumn() { }

        public override string FormatLiteral(SqlFactory sqlFactory, bool literal)
        {
            if (literal)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        protected override bool ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return reader.GetBoolean(ordinal);
        }
    }        

    [Serializable()]
    public class DecimalDataColumn : DataColumn<decimal>
    {
        //public DecimalDataColumn(DataTable table, string columnName, byte precision, byte scale)
        //    : base(table, columnName, System.Data.DbType.Decimal)
        //{
        //    Precision = precision;
        //    Scale = scale;
        //    SetDefaultMaxValue();
        //    SetDefaultMinValue();
        //}

        //public DecimalDataColumn(DataTable table, string columnName, byte precision, byte scale, decimal minValue)
        //    : base(table, columnName, System.Data.DbType.Decimal)
        //{
        //    Precision = precision;
        //    Scale = scale;
        //    SetDefaultMaxValue();
        //}

        //public DecimalDataColumn(DataTable table, string columnName, byte precision, byte scale, decimal minValue, decimal maxValue)
        //    : base(table, columnName, System.Data.DbType.Decimal)
        //{
        //    Precision = precision;
        //    Scale = scale;
        //}

        //public DecimalDataColumn(DataTable table, string columnName, int ordinalSequence, byte precision, byte scale, decimal minValue, decimal maxValue, string alias = null, bool isPrimaryKey = false, bool isRequired = false, decimal defaultValue = Decimal.Zero)
        //    : base(table, columnName, System.Data.DbType.Decimal, ordinalSequence, alias, false, isPrimaryKey, isRequired, defaultValue)
        //{
        //    Precision = precision;
        //    Scale = scale;
        //}

        protected internal DecimalDataColumn() { }

        protected override decimal ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return reader.GetDecimal(ordinal);
        }

        //protected override void SetDefaultMaxValue()
        //{
        //    MaxValue = Decimal.MaxValue;
        //}

        //protected override void SetDefaultMinValue()
        //{
        //    MinValue = Decimal.MinValue;
        //}

        //public byte Precision
        //{
        //    get;
        //    set;
        //}

        //public byte Scale
        //{
        //    get;
        //    set;
        //}
    }

    [Serializable()]
    public class IntegerDataColumn : DataColumn<int>
    {
        //public IntegerDataColumn(DataTable table, string columnName)
        //    : base(table, columnName, System.Data.DbType.Int32)
        //{
        //    SetDefaultMaxValue();
        //    SetDefaultMinValue();
        //}

        //public IntegerDataColumn(DataTable table, string columnName, int minValue)
        //    : base(table, columnName, System.Data.DbType.Int32)
        //{
        //    SetDefaultMaxValue();
        //}

        //public IntegerDataColumn(DataTable table, string columnName, int minValue, int maxValue)
        //    : base(table, columnName, System.Data.DbType.Int32)
        //{
        //}

        //public IntegerDataColumn(DataTable table, string columnName, int ordinalSequence, int minValue, int maxValue, string alias = null, bool isPrimaryKey = false, bool isRequired = false, int defaultValue = 0)
        //    : base(table, columnName, System.Data.DbType.Int32, ordinalSequence, alias, false, isPrimaryKey, isRequired, defaultValue)
        //{
        //}

        protected internal IntegerDataColumn() { }

        protected override int ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return reader.GetInt32(ordinal);
        }

        //protected override void SetDefaultMaxValue()
        //{
        //    MaxValue = Int32.MaxValue;
        //}

        //protected override void SetDefaultMinValue()
        //{
        //    MinValue = Int32.MinValue;
        //}
    }

    [Serializable()]
    public class DateTimeDataColumn : DataColumn<DateTime>
    {
        //public DateTimeDataColumn(DataTable table, string columnName)
        //    : base(table, columnName, System.Data.DbType.DateTime)
        //{
        //    SetDefaultMaxValue();
        //    SetDefaultMinValue();
        //    IsNullable = true;
        //}

        //public DateTimeDataColumn(DataTable table, string columnName, DateTime minValue)
        //    : base(table, columnName, System.Data.DbType.DateTime)
        //{
        //    SetDefaultMaxValue();
        //    IsNullable = true;
        //}

        //public DateTimeDataColumn(DataTable table, string columnName, DateTime minValue, DateTime maxValue)
        //    : base(table, columnName, System.Data.DbType.DateTime)
        //{
        //    IsNullable = true;
        //}

        //public DateTimeDataColumn(DataTable table, string columnName, int ordinalSequence, DateTime minValue, DateTime maxValue, string alias = null, bool isNullable = true, bool isPrimaryKey = false, bool isRequired = false, DateTime defaultValue = default(DateTime))
        //    : base(table, columnName, System.Data.DbType.DateTime, ordinalSequence, alias, isNullable, isPrimaryKey, isRequired, defaultValue)
        //{
        //}

        protected internal DateTimeDataColumn() { }

        public override string FormatLiteral(SqlFactory sqlFactory, DateTime literal)
        {
            if (literal > DateTime.MinValue)
            {
                return String.Concat(sqlFactory.StringDelimiter, literal.ToString("yyyy-MM-dd"), sqlFactory.StringDelimiter);
            }
            return "NULL";
        }

        protected override DateTime ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return reader.GetDateTime(ordinal);
        }

        //protected override void SetDefaultMaxValue()
        //{
        //    MaxValue = DateTime.MaxValue;
        //}

        //protected override void SetDefaultMinValue()
        //{
        //    MinValue = DateTime.MinValue;
        //}
    }

    [Serializable()]
    public class NullableDateTimeDataColumn : DataColumn<DateTime?>
    {
        protected internal NullableDateTimeDataColumn() { }

        public override string FormatLiteral(SqlFactory sqlFactory, DateTime? literal)
        {
            if (literal.HasValue)
            {
                return String.Concat(sqlFactory.StringDelimiter, literal.Value.ToString("yyyy-MM-dd"), sqlFactory.StringDelimiter);
            }
            return "NULL";
        }

        protected override DateTime? ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return reader.GetDateTime(ordinal);
        }
    }

    //[Serializable()]
    //public class NullableDateTimeColumn : MinMaxValueDataColumn<System.Nullable<DateTime>>
    //{
    //    public NullableDateTimeColumn(DataTable table, string columnName)
    //        : base(table, columnName, System.Data.DbType.DateTime)
    //    {
    //        SetDefaultMaxValue();
    //        SetDefaultMinValue();
    //    }

    //    public NullableDateTimeColumn(DataTable table, string columnName, DateTime? minValue)
    //        : base(table, columnName, System.Data.DbType.DateTime)
    //    {
    //        SetDefaultMaxValue();
    //    }

    //    public NullableDateTimeColumn(DataTable table, string columnName, DateTime? minValue, DateTime? maxValue)
    //        : base(table, columnName, System.Data.DbType.DateTime)
    //    {
    //    }

    //    public NullableDateTimeColumn(DataTable table, string columnName, int ordinalSequence, DateTime? minValue, DateTime? maxValue, string alias = null, bool isPrimaryKey = false, bool isRequired = false, DateTime? defaultValue = null)
    //        : base(table, columnName, System.Data.DbType.DateTime, ordinalSequence, alias, true, isPrimaryKey, isRequired, defaultValue)
    //    {
    //    }

    //    protected override void SetDefaultMaxValue()
    //    {
    //        MaxValue = DateTime.MaxValue;
    //    }

    //    protected override void SetDefaultMinValue()
    //    {
    //        MinValue = DateTime.MinValue;
    //    }
    //}

    [Serializable()]
    public class StringDataColumn : DataColumn<string>
    {
        //public StringDataColumn(DataTable table, string columnName, int maxLength)
        //    : this(table, columnName, maxLength, false) {}

        //public StringDataColumn(DataTable table, string columnName, int maxLength, bool isFixedLength)
        //    : base(table, columnName, isFixedLength ? System.Data.DbType.StringFixedLength : System.Data.DbType.String) 
        //{
        //    MaxLength = maxLength;
        //}

        //public StringDataColumn(DataTable table, string columnName, int maxLength, int ordinalSequence, bool isFixedLength = false, string alias = null, bool isNullable = false, bool isPrimaryKey = false, bool isRequired = false)
        //    : base(table, columnName, isFixedLength ? System.Data.DbType.StringFixedLength : System.Data.DbType.String, ordinalSequence, alias, isNullable, isPrimaryKey, isRequired, String.Empty)
        //{
        //}

        protected internal StringDataColumn() { }

        public override string FormatLiteral(SqlFactory sqlFactory, string literal)
        {
            //
            // Defaulting all NULL strings to empty.  Need instead to correctly generate the columns to default to empty
            //
            if (String.IsNullOrWhiteSpace(literal))
            {
                literal = String.Empty;
            }
            else if (Table.DataContext.ShouldFormatCleanStrings)
            {
                char[] input = literal.ToCharArray();
                char[] output = new char[input.Length];
                int outputCount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int asciiVal = (int)input[i];
                    if ((asciiVal >= 32 && asciiVal <= 126) || asciiVal == 13 || asciiVal == 10)
                    {
                        output[outputCount++] = input[i];
                    }
                }
                literal = new String(output, 0, outputCount);
                if (outputCount != input.Length)
                {

                }
            }
            string delimiter = sqlFactory.StringDelimiter.ToString();
            return String.Concat(delimiter, literal.Replace(delimiter, String.Concat(delimiter, delimiter)).TrimEnd(), delimiter);
        }

        //protected override string GetDefaultValue()
        //{
        //    if (IsNullable)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return String.Empty;
        //    }
        //}

        //public int MaxLength
        //{
        //    get;
        //    protected internal set;
        //}

        protected override string ReadValueCore(System.Data.IDataRecord reader, int ordinal)
        {
            return reader.GetString(ordinal);
        }
    }
}
