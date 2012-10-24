using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StruggleFree.Data;

namespace StruggleFree.TestData
{
    [Serializable()]
    public class Parent : EntityData
    {
        public Parent()
            : base() { }

        public string Name
        {
            get
            {
                return EditValue;
            }
            set
            {
                EditValue = value;
            }
        }
    }
}
