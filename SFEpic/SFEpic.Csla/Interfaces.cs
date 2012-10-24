using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SFEpic.Csla4
{
    public interface IHoldsRichBrokenRules
    {
        ReadOnlyObservableCollection<RichBrokenRule> RichBrokenRules { get; }
    }
}
