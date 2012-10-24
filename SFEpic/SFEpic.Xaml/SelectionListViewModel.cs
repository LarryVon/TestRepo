using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public class SelectionListViewModel<T, C> : SelectionListViewModelBase<T, C, SelectionViewModel<C>>
        where T : IEnumerable<C>
    {
        public SelectionListViewModel(T collection)
            : base(collection) { }

        protected override SelectionViewModel<C> InitViewModel(C item)
        {
            return new SelectionViewModel<C>(item);
        }
    }
}
