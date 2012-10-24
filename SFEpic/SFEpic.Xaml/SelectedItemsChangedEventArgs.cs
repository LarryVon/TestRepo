using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public class SelectedItemsChangedEventArgs<T> : EventArgs
        where T:SelectionViewModel<T>
    {
        public SelectedItemsChangedEventArgs(IEnumerable<T> oldValues, IEnumerable<T> newValues)
        {
            NewValues = newValues;
            OldValues = oldValues;
        }

        public IEnumerable<T> NewValues
        {
            get;
            protected set;
        }

        public IEnumerable<T> OldValues
        {
            get;
            protected set;
        }
    }
}