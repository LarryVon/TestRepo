using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data.E9
{
    public class DefaultDataContext : SFEpic.Data.DataContext
    {
        public DefaultDataContext() : base() { }

        public Part NewPart()
        {
            return Part.GetEmpty(this);
        }
    }
}
