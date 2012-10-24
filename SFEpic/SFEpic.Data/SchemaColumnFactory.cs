using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    public static class SchemaColumnFactory
    {
        public static BooleanSchemaColumn GetBooleanSchemaColumn(SchemaTable schemaTable, string columnName, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            BooleanSchemaColumn col = new BooleanSchemaColumn();
            InitSchemaColumn(col, schemaTable, columnName, schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
            return col;
        }

        public static DateSchemaColumn GetDateSchemaColumn(SchemaTable schemaTable, string columnName, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            return GetDateSchemaColumn(schemaTable, columnName, new DateTime(1900, 1, 1), new DateTime(2199, 12, 31), schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
        }

        public static DateSchemaColumn GetDateSchemaColumn(SchemaTable schemaTable, string columnName, DateTime minValue, DateTime maxValue, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            DateSchemaColumn col = new DateSchemaColumn();
            col.MaxValue = maxValue;
            col.MinValue = minValue;
            InitSchemaColumn(col, schemaTable, columnName, schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
            return col;
        }

        public static DecimalSchemaColumn GetDecimalSchemaColumn(SchemaTable schemaTable, string columnName, byte precision, byte scale, decimal minValue = Decimal.MinValue, decimal maxValue = Decimal.MaxValue, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            DecimalSchemaColumn col = new DecimalSchemaColumn();
            col.Precision = precision;
            col.Scale = scale;
            col.MaxValue = maxValue;
            col.MinValue = minValue;
            InitSchemaColumn(col, schemaTable, columnName, schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
            return col;
        }

        public static IntegerSchemaColumn GetIntegerSchemaColumn(SchemaTable schemaTable, string columnName, int minValue = Int32.MinValue, int maxValue = Int32.MaxValue, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            IntegerSchemaColumn col = new IntegerSchemaColumn();
            col.MaxValue = maxValue;
            col.MinValue = minValue;
            InitSchemaColumn(col, schemaTable, columnName, schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
            return col;
        }

        public static TimeSchemaColumn GetTimeSchemaColumn(SchemaTable schemaTable, string columnName, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            return GetTimeSchemaColumn(schemaTable, columnName, new TimeSpan(0, 0, 0), new TimeSpan(23, 59, 59), schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
        }

        public static TimeSchemaColumn GetTimeSchemaColumn(SchemaTable schemaTable, string columnName, TimeSpan minValue, TimeSpan maxValue, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            TimeSchemaColumn col = new TimeSchemaColumn();
            col.MaxValue = maxValue;
            col.MinValue = minValue;
            InitSchemaColumn(col, schemaTable, columnName, schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
            return col;
        }

        public static TextSchemaColumn GetTextSchemaColumn(SchemaTable schemaTable, string columnName, int maxLength, bool isFixedWidth = false, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            TextSchemaColumn col = null;
            if (isFixedWidth)
            {
                col = new FixedWidthTextSchemaColumn();
            }
            else
            {
                col = new TextSchemaColumn();
            }
            col.MaxLength = maxLength;
            InitSchemaColumn(col, schemaTable, columnName, schemaColumnName, ordinalSequence, defaultValue, isNullable, isRequired);
            return col;
        }

        private static void InitSchemaColumn(SchemaColumn col, SchemaTable schemaTable, string columnName, string schemaColumnName = "", int ordinalSequence = -1, string defaultValue = null, bool isNullable = false, bool isRequired = false)
        {
            col.SchemaTable = schemaTable;
            col.ColumnName = columnName;
            col.SchemaColumnName = schemaColumnName;
            col.OrdinalSequence = ordinalSequence;
            col.DefaultValue = defaultValue;
            col.IsNullable = isNullable;
            col.IsRequired = isRequired;
        }
    }
}
