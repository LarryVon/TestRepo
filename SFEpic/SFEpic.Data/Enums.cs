using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    public enum RelationType
    {
        OneToMany,
        OneToOne
    }

    public enum SchemaType
    {
        SqlServer,
        Progress
    }

    public enum SqlFactoryType
    {
        SqlServer,
        Progress
    }
}
