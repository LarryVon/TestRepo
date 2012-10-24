using System;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public abstract class SqlFactory
    {
        public static SqlFactory GetFactory(SqlFactoryType sqlFactoryType)
        {
            switch (sqlFactoryType)
            {
                case SqlFactoryType.SqlServer:
                    return new SqlServerSqlFactory();
                    break;

                case SqlFactoryType.Progress:
                    return new ProgressSqlFactory();
                    break;
            }
            throw new InvalidOperationException("Unsupported SqlFactoryType");
        }

        public virtual string DefaultOwner
        {
            get
            {
                return "dbo";
            }
        }

        public virtual char IdentifierDelimiterClose
        {
            get
            {
                return ']';
            }
        }

        public virtual char IdentifierDelimiterOpen
        {
            get
            {
                return '[';
            }
        }

        public virtual char StringDelimiter
        {
            get
            {
                return '\'';
            }
        }

        protected string GetSqlServerCreateTableField(SchemaColumn schemaColumn)
        {
            //[Company] [varchar](8) NULL,
            return string.Format("[{0}] [{1}]{2}{3}", schemaColumn.SchemaColumnName,
                                 GetSqlServerColumnDataType(schemaColumn),
                                 GetSqlServerColumnSize(schemaColumn), schemaColumn.IsNullable ? " NULL" : string.Empty);
        }

        protected string GetSqlServerColumnDataType(SchemaColumn schemaColumn)
        {
            switch (schemaColumn.DbType)
            {
                case DbType.AnsiString:
                case DbType.AnsiStringFixedLength:
                case DbType.String:
                case DbType.StringFixedLength:
                    return "varchar";
                    break;

                case DbType.Binary:
                case DbType.Object:
                    return "varbinary";
                    break;

                case DbType.Byte:
                case DbType.SByte:
                    return "tinyint";
                    break;

                case DbType.Boolean:
                    return "bit";
                    break;

                case DbType.Currency:
                case DbType.Decimal:
                case DbType.VarNumeric:
                    return "decimal";
                    break;

                case DbType.Date:
                case DbType.DateTime:
                case DbType.DateTimeOffset:
                    return "date";
                    break;
                
                case DbType.Double:
                    return "real";
                    break;

                case DbType.Guid:
                    return "uniqueid";
                    break;

                case DbType.Int16:
                case DbType.UInt16:
                    return "smallint";
                    break;

                case DbType.Int32:
                case DbType.UInt32:
                    return "int";
                    break;

                case DbType.Int64:
                case DbType.UInt64:
                    return "bigint";
                    break;

                case DbType.Single:
                    return "float";
                    break;
                
                case DbType.Time:
                    return "Time";
                    break;

                case DbType.Xml:
                    return "xml";
                    break;

                case DbType.DateTime2:
                    return "DateTime2";
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected string GetSqlServerColumnSize(SchemaColumn schemaColumn)
        {
            switch (schemaColumn.DbType)
            {
                case DbType.AnsiString:
                case DbType.AnsiStringFixedLength:
                case DbType.String:
                case DbType.StringFixedLength:
                    var textColumn = schemaColumn as TextSchemaColumn;
                    if (textColumn != null && textColumn.MaxLength <= 100)
                    {
                        return string.Format("({0})", textColumn.MaxLength);
                    }
                    else
                    {
                        return "(max)";
                    }
                    break;

                case DbType.Binary:
                case DbType.Object:
                    return "(max)";
                    break;

                case DbType.Currency:
                case DbType.Decimal:
                case DbType.VarNumeric:
                    var decimalColumn = schemaColumn as DecimalSchemaColumn;
                    if (decimalColumn != null)
                    {
                        return string.Format("({0},{1})", decimalColumn.Precision, decimalColumn.Scale);
                    }
                    else
                    {
                        return "(28,8)";
                    }
                    break;

                case DbType.Byte:
                case DbType.SByte:
                case DbType.Boolean:
                case DbType.Date:
                case DbType.DateTime:
                case DbType.DateTimeOffset:
                case DbType.Double:
                case DbType.Guid:
                case DbType.Int16:
                case DbType.UInt16:
                case DbType.Int32:
                case DbType.UInt32:
                case DbType.Int64:
                case DbType.UInt64:
                case DbType.Single:
                case DbType.Time:
                case DbType.Xml:
                case DbType.DateTime2:
                    return string.Empty;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }            
        }

        protected string GetSqlServerCreateTableOpen(SchemaTable schemaTable)
        {
            //CREATE TABLE [dbo].[JobHead](
            return string.Format("CREATE TABLE [dbo].[{0}](", schemaTable.TableName);
        }


        public string GetSqlServerCreate(SchemaTable schemaTable)
        {
            var fieldList = new List<string>();
            foreach (var schemaColumn in schemaTable.Columns)
            {
                fieldList.Add(GetSqlServerCreateTableField(schemaColumn));
            }
            fieldList.Add(string.Format("[{0}RecID] [bigint] IDENTITY(1,1) NOT NULL", schemaTable.TableName));
            return string.Format("{0}\r\n{1}\r\n)", GetSqlServerCreateTableOpen(schemaTable),
                                 string.Join(",\r\n", fieldList));
        }

        protected internal string GetInsertSql(DataRow row)
        {
            var table = row.Table;
            var tableName = table.TableName;
            var schemaTable = table.DataContext.DbSchema.TablesDictionary[tableName];
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("INSERT INTO {0} (", GetSqlTableName(tableName));
            foreach (var prop in row.PropertiesDictionary.Values)
            {
                builder.AppendFormat("{0}, ", GetSqlFieldName(prop.Column.SchemaColumn.SchemaColumnName));
            }
            //
            // Remove trailing comma and space
            //
            builder.Remove(builder.Length - 2, 2);
            builder.Append(") VALUES (");
            foreach (var prop in row.PropertiesDictionary.Values)
            {
                try
                {
                    builder.AppendFormat("{0}, ", prop.Column.FormatLiteral(this, prop.Value));
                }
                catch (System.Exception ex)
                {

                }
            }
            //
            // Remove trailing comma and space
            //
            builder.Remove(builder.Length - 2, 2);
            builder.Append(")");
            return builder.ToString();
        }

        public string GetSelectSql(SchemaRelation[] relations, IEnumerable<IDataColumn> columms, params ICriteriaValue[] criteria)
        {
            var builder = new StringBuilder();
            builder.Append("SELECT ");
            if (columms != null && columms.Count() > 0)
            {
                foreach (var column in columms)
                {
                    builder.Append(GetSqlFieldName(column.SchemaColumn.SchemaTable.TableName, column.SchemaColumn.SchemaColumnName));
                    builder.Append(", ");
                }
                //
                // Remove trailing comma and space
                //
                builder.Remove(builder.Length - 2, 2);
            }
            else
            {
                builder.Append(" *");
            }
            //builder.AppendFormat(" FROM {0}{1}{3}.{0}{2}{3}", IdentifierDelimiterOpen, DefaultOwner, tableName, IdentifierDelimiterClose);
            //
            // FROM "PUB"."POHeader" INNER JOIN "PUB"."PODetail" ON "PUB"."POHeader"."Company" = "PUB"."PODetail"."Company" AND "PUB"."POHeader"."PONum" = "PUB"."PODetail"."PONum" 
            // INNER JOIN "PUB"."PORel" ON PUB"."PODetail"."Company" = "PUB"."PORel"."Company" AND "PUB"."PODetail"."PONum" = "PUB"."PORel"."PONum" AND "PUB"."PODetail"."POLine" = "PUB"."PORel"."POLine" 
            //
            builder.AppendFormat(" FROM ");
            bool isFirstRelation = true;
            foreach (var relation in relations)
            {
                SchemaTable parent = null;
                SchemaTable child = null;
                parent = relation.IsReversed ? relation.ChildTable : relation.ParentTable;
                child = relation.IsReversed ? relation.ParentTable : relation.ChildTable;
                if (isFirstRelation)
                {
                    builder.AppendFormat("{0} INNER JOIN {1} ON {2}", GetSqlTableName(parent.TableName), GetSqlTableName(child.TableName), GetSqlJoinExpression(relation));
                    isFirstRelation = false;
                }
                else
                {
                    builder.AppendFormat(" INNER JOIN {0} ON {1}", GetSqlTableName(child.TableName), GetSqlJoinExpression(relation));
                }
            }
            if (criteria != null && criteria.Length > 0)
            {
                builder.Append(" WHERE ");
                foreach (var criterion in criteria)
                {
                    var column = criterion.Column;
                    builder.AppendFormat("{4}.{0}{1}{2} = {3} AND ", IdentifierDelimiterOpen, column.SchemaColumn.SchemaColumnName, IdentifierDelimiterClose, column.FormatLiteral(this, criterion.Value), GetSqlTableName(column.SchemaColumn.SchemaTable.TableName));
                }
                //
                // Remove trailing " AND "
                //
                builder.Remove(builder.Length - 5, 5);
            }
            return builder.ToString();
        }

        public string GetSafeSelectSql(string tableName, IEnumerable<IDataColumn> columms, params ICriteriaValue[] criteria)
        {
            return GetSelectSql(tableName, columms, true, criteria);
        }

        public string GetSelectSql(string tableName, IEnumerable<IDataColumn> columms, params ICriteriaValue[] criteria)
        {
            return GetSelectSql(tableName, columms, false, criteria);
        }

        public string GetPrimaryKeySelectSql(SchemaTable schemaTable, bool isSafe, string companyNum = "")
        {
            var columns = schemaTable.PrimaryKeys;
            var builder = new StringBuilder();
            builder.Append("SELECT ");
            if (columns != null && columns.Count() > 0)
            {
                foreach (var schemaCol in columns)
                {
                    TextSchemaColumn textCol = schemaCol as TextSchemaColumn;
                    if (textCol == null || !isSafe)
                    {
                        builder.Append(String.Concat(IdentifierDelimiterOpen, schemaCol.SchemaColumnName, IdentifierDelimiterClose, ", "));
                    }
                    else
                    {
                        builder.Append(String.Format("SUBSTRING({0}{1}{2}, 1, {3}) AS {0}{1}{2}, ", IdentifierDelimiterOpen, schemaCol.SchemaColumnName, IdentifierDelimiterClose, textCol.MaxLength));
                    }
                }
                //
                // Remove trailing comma and space
                //
                builder.Remove(builder.Length - 2, 2);
            }
            else
            {
                builder.Append(" *");
            }
            builder.AppendFormat(" FROM {0}", GetSqlTableName(schemaTable.TableName));
            if (schemaTable.Columns.Count(c => c.SchemaColumnName.ToLower() == "company") > 0)
            {
                //builder.AppendFormat(" FROM {0}{1}", GetSqlTableName(schemaTable.TableName), !string.IsNullOrWhiteSpace(companyNum) ? string.Format(" WHERE company = '{0}'", companyNum) : string.Empty);
                builder.Append(!string.IsNullOrWhiteSpace(companyNum) ? string.Format(" WHERE company = '{0}'", companyNum) : string.Empty);
            }
            return builder.ToString();           
        }

        protected string GetSelectSql(string tableName, IEnumerable<IDataColumn> columms, bool isSafe, params ICriteriaValue[] criteria)
        {
            var builder = new StringBuilder();
            builder.Append("SELECT ");
            if (columms != null && columms.Count() > 0)
            {
                foreach (var column in columms)
                {
                    SchemaColumn schemaCol = column.SchemaColumn;
                    TextSchemaColumn textCol = schemaCol as TextSchemaColumn;
                    if (textCol == null || !isSafe)
                    {
                        builder.Append(String.Concat(IdentifierDelimiterOpen, schemaCol.SchemaColumnName, IdentifierDelimiterClose, ", "));
                    }
                    else
                    {
                        builder.Append(String.Format("SUBSTRING({0}{1}{2}, 1, {3}) AS {0}{1}{2}, ", IdentifierDelimiterOpen, schemaCol.SchemaColumnName, IdentifierDelimiterClose, textCol.MaxLength));
                    }
                }
                //
                // Remove trailing comma and space
                //
                builder.Remove(builder.Length - 2, 2);
            }
            else
            {
                builder.Append(" *");
            }
            builder.AppendFormat(" FROM {0}", GetSqlTableName(tableName));
            if (criteria != null && criteria.Length > 0)
            {
                builder.Append(" WHERE ");
                foreach (var criterion in criteria)
                {
                    var column = criterion.Column;
                    var literal = column.FormatLiteral(this, criterion.Value);
                    var oper = "=";
                    if (criterion.Value == null || criterion.Value == System.DBNull.Value)
                    {
                        oper = "IS";
                    }
                    builder.AppendFormat("{4}.{0}{1}{2} {5} {3} AND ", IdentifierDelimiterOpen, column.SchemaColumn.SchemaColumnName, IdentifierDelimiterClose, literal, GetSqlTableName(tableName), oper);
                }
                //
                // Remove trailing " AND "
                //
                builder.Remove(builder.Length - 5, 5);
            }
            return builder.ToString();
        }

        protected string GetSqlFieldName(string fieldName)
        {
            return String.Format("{0}{1}{2}", IdentifierDelimiterOpen, fieldName, IdentifierDelimiterClose);
        }

        protected string GetSqlFieldName(string tableName, string fieldName)
        {
            return String.Format("{3}.{0}{1}{2}", IdentifierDelimiterOpen, fieldName, IdentifierDelimiterClose, GetSqlTableName(tableName));
        }

        protected string GetSqlJoinExpression(SchemaRelation relation)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < relation.ParentColumns.Count; i++)
            {
                builder.AppendFormat("{0} = {1} AND ", 
                    GetSqlFieldName(relation.ParentTable.TableName, relation.ParentColumns[i].SchemaColumnName),
                    GetSqlFieldName(relation.ChildTable.TableName, relation.ChildColumns[i].SchemaColumnName));
            }
            //
            // Remove trailing " AND "
            //
            builder.Remove(builder.Length - 5, 5);
            return builder.ToString();
        }

        protected string GetSqlTableName(string tableName)
        {
            return String.Format("{0}{1}{3}.{0}{2}{3}", IdentifierDelimiterOpen, DefaultOwner, tableName, IdentifierDelimiterClose);
        }

        protected internal string GetDeleteSql(DataRow row)
        {
            var table = row.Table;
            var tableName = table.TableName;
            var schemaTable = table.DataContext.DbSchema.TablesDictionary[tableName];
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("DELETE FROM {0} ", GetSqlTableName(tableName));
            builder.Append(" WHERE ");
            foreach (var prop in row.GetPrimaryKeyProperties())
            {
                builder.AppendFormat("{0} = {1} AND ", GetSqlFieldName(tableName, prop.Column.SchemaColumn.SchemaColumnName), prop.Column.FormatLiteral(this, prop.Value));
            }
            //
            // Remove trailing " AND "
            //
            builder.Remove(builder.Length - 5, 5);
            return builder.ToString();
        }

        protected internal string GetUpdateSql(DataRow row)
        {
            var table = row.Table;
            var tableName = table.TableName;
            var schemaTable = table.DataContext.DbSchema.TablesDictionary[tableName];
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("UPDATE {0} SET ", GetSqlTableName(tableName));
            foreach (var prop in row.GetChangedProperties())
            {
                builder.AppendFormat("{0} = {1}, ", GetSqlFieldName(prop.Column.SchemaColumn.SchemaColumnName), prop.Column.FormatLiteral(this, prop.Value));
            }
            //
            // Remove trailing comma and space
            //
            builder.Remove(builder.Length - 2, 2);
            builder.Append(" WHERE ");
            foreach (var prop in row.GetPrimaryKeyProperties())
            {
                builder.AppendFormat("{0} = {1} AND ", GetSqlFieldName(tableName, prop.Column.SchemaColumn.SchemaColumnName), prop.Column.FormatLiteral(this, prop.Value));
            }
            //
            // Remove trailing " AND "
            //
            builder.Remove(builder.Length - 5, 5);
            return builder.ToString();
        }

        public string GetWhere(SchemaTable schemaTable, IEnumerable<ICriteriaValue> criteria)
        {
            var tableName = schemaTable.TableName;
            StringBuilder builder = new StringBuilder();
            builder.Append(" WHERE ");
            foreach (var item in criteria)
            {
                builder.AppendFormat("{0} = {1} AND ", GetSqlFieldName(tableName, item.SchemaColumn.SchemaColumnName), item.SchemaColumn.FormatLiteral(this, item.Value));
            }
            //
            // Remove trailing " AND "
            //
            builder.Remove(builder.Length - 5, 5);
            return builder.ToString();
        }
    }

    [Serializable()]
    public class SqlServerSqlFactory : SqlFactory
    {

    }

    [Serializable()]
    public class ProgressSqlFactory : SqlFactory
    {
        public override string DefaultOwner
        {
            get
            {
                return "PUB";
            }
        }

        public override char IdentifierDelimiterClose
        {
            get
            {
                return '"';
            }
        }

        public override char IdentifierDelimiterOpen
        {
            get
            {
                return '"';
            }
        }
    }
}
