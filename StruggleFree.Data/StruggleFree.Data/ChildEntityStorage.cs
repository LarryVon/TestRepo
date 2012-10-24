using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace StruggleFree.Data
{
    [Serializable()]
    public class ChildEntityStorage<T, P, R> : EntityStorage<T, R>
        where T:ChildEntityData, new()
        where P:EntityData, new()
        where R : DataRootBase<R>
    {
        public ChildEntityStorage(EntityStorage<P, R> parentEntityStorage, R root)
            : base(root, true)
        {
            ParentEntityStorage = parentEntityStorage;
        }

        protected internal EntityStorage<P, R> ParentEntityStorage
        {
            get;
            set;
        }
    }
}
