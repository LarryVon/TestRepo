using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Csla4
{
    [Serializable()]
    public class RichBrokenRule
    {
        public RichBrokenRule(Csla.Core.BusinessBase businessBase, Csla.Rules.BrokenRule brokenRule)
        {
            BusinessObject = businessBase;
            Description = brokenRule.Description;
            Severity = brokenRule.Severity;
            Property = brokenRule.Property;
            RuleName = brokenRule.RuleName;
        }

        public Csla.Core.BusinessBase BusinessObject
        {
            get;
            protected set;
        }

        public string Description
        {
            get;
            protected set;
        }

        public string Property
        {
            get;
            protected set;
        }

        public string RuleName
        {
            get;
            protected set;
        }

        public Csla.Rules.RuleSeverity Severity
        {
            get;
            protected set;
        }
    }
}
