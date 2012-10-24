using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public class SchemaRelation
    {
        public SchemaRelation(DbSchema schema, SchemaTable parentTable, SchemaTable childTable, IEnumerable<SchemaColumn> childColumns, string relationName = null, bool isOneToOne = false, bool isRequired = true, bool isReversed = false)
            : this(schema, parentTable, childTable, parentTable.PrimaryKeys, childColumns, relationName, isOneToOne, isRequired, isReversed)
        {
        }

        public SchemaRelation(DbSchema schema, SchemaTable parentTable, SchemaTable childTable, IEnumerable<SchemaColumn> parentColumns, IEnumerable<SchemaColumn> childColumns, string relationName = null, bool isOneToOne = false, bool isRequired = true, bool isReversed = false)
        {
            Schema = schema;
            ParentTable = parentTable;
            ChildTable = childTable;
            ParentColumns = new ReadOnlyObservableCollection<SchemaColumn>(new ObservableCollection<SchemaColumn>(parentColumns));
            ChildColumns = new ReadOnlyObservableCollection<SchemaColumn>(new ObservableCollection<SchemaColumn>(childColumns));
            RelationName = String.IsNullOrWhiteSpace(relationName) ? String.Format("{0}_{1}", parentTable.TableName, childTable.TableName) : relationName;
            RelationType = isOneToOne ? RelationType.OneToOne : RelationType.OneToMany;
            IsRequired = isRequired;
            IsReversed = isReversed;
        }

        public ReadOnlyObservableCollection<SchemaColumn> ChildColumns
        {
            get;
            protected set;
        }

        public SchemaTable ChildTable
        {
            get;
            protected set;
        }

        public bool IsReversed
        {
            get;
            protected set;
        }

        public bool IsRequired
        {
            get;
            protected set;
        }

        public ReadOnlyObservableCollection<SchemaColumn> ParentColumns
        {
            get;
            protected set;
        }

        public SchemaTable ParentTable
        {
            get;
            protected set;
        }

        public string RelationName
        {
            get;
            protected set;
        }

        public RelationType RelationType
        {
            get;
            protected set;
        }

        public SchemaRelation Reverse()
        {
            SchemaRelation rel = (SchemaRelation)this.MemberwiseClone();
            rel.IsReversed = true;
            return rel;
        }

        public DbSchema Schema
        {
            get;
            protected set;
        }
    }
}
