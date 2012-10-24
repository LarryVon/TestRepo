using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFEpic.Data;
//using SFEpic.Data.V8;

namespace TestHarness
{
    [Serializable()]
    public class TestDataContext : DataContext
    {
        public TestDataContext() : base() { }

        //public POHeader GetAllPOHeader()
        //{
        //    return POHeader.Fill(this);
        //}
    }
}
