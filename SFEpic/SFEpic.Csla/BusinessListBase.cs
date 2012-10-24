using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Csla4
{
    [Serializable()]
    public class BusinessListBase<T, C> : Csla.BusinessListBase<T, C>
        where T:BusinessListBase<T, C>
        where C:BusinessBase<C>
    {
        #region Factory Methods

        protected BusinessListBase() : base() { }

        #endregion
    }
}
