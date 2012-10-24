using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFEpic.Data;

namespace SFEpic.Data.V8
{
    [Serializable()]
    public class V8Environment : Environment
    {
        public V8Environment()
            : base("V8")
        {
        }

        protected override void InitSchemasCore()
        {
            schemasList.Add(V8Schema.Instance);
        }
    }
}
