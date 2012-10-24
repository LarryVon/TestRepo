using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFEpic.Data;

namespace SFEpic.Data.E9
{
    [Serializable()]
    public class E9Environment : Environment
    {
        public E9Environment()
            : base("E9")
        {
        }

        protected override void InitSchemasCore()
        {
            schemasList.Add(E9Schema.Instance);
        }
    }
}
