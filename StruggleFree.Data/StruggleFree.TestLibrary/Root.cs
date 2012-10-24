using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StruggleFree.TestLibrary
{
    [Serializable()]
    public class LibraryRoot : MarshalByRefObject
    {
        public LibraryRoot() { }

        public ParentEdit Get(int parentID)
        {
            //return ParentEdit.Get(parentID);
            return Csla.DataPortal.Fetch<ParentEdit>(parentID);
        }

        public ParentEdit Get(string name)
        {
            //return ParentEdit.Get(name);
            return Csla.DataPortal.Fetch<ParentEdit>(name);
        }

        public ParentEdit New()
        {
            //return ParentEdit.New();
            return Csla.DataPortal.Create<ParentEdit>();
        }

        public ParentEdit Save(ParentEdit parentEdit)
        {
            return parentEdit.Save();
        }
    }
}
