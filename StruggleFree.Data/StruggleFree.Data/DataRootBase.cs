using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using Bamboo.Prevalence;
using Bamboo.Prevalence.Attributes;

namespace StruggleFree.Data
{
    [Serializable()]
    public abstract class DataRootBase : MarshalByRefObject
    {
        protected static PrevalenceEngine engine;

        protected ConcurrentDictionary<Type, IEntityStorage> storageDictionary = new ConcurrentDictionary<Type, IEntityStorage>();

        public DataRootBase()
        {
            InitEntityStorage();
        }

        [Query()]
        protected abstract void InitEntityStorage();

        public static PrevalenceEngine Engine
        {
            get
            {
                return engine;
            }
        }

        #region Overrides

        [PassThrough]
        public override object InitializeLifetimeService()
        {
            // object lives till the end of AppDomain...
            return null;
        }

        #endregion
    }
}
