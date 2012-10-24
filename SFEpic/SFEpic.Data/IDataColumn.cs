using System;
using System.Data.Common;

namespace SFEpic.Data
{
    public interface IDataColumn
    {
        string ColumnName { get;  }
        string FormatLiteral(SqlFactory sqlFactory, object literal);
        IRowProperty GetRowProperty(DataRow row);
        IRowProperty GetRowPropertyWithValue(DataRow row, System.Data.IDataRecord record, int ordinal);
        int OrdinalSequence { get; }
        SchemaColumn SchemaColumn { get; }
        DataTable Table { get; }
    }
}
