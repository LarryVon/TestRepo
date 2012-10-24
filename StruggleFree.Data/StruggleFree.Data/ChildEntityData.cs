using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StruggleFree.Data
{
    [Serializable()]
    public abstract class ChildEntityData : EntityData
    {
        public ChildEntityData()
            : base() { }

        public int ParentInstanceID
        {
            get;
            protected internal set;
        }
    }
}
