using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public class BusinessBaseSelectionListViewModel<T, C> : SelectionListViewModelBase<T, C, BusinessBaseViewModel<C>>
        where T:Csla.BusinessListBase<T, C>
        where C:SFEpic.Csla4.BusinessBase<C>
    {
        public BusinessBaseSelectionListViewModel(T list)
            : base(list)
        {
        }

        protected override BusinessBaseViewModel<C> InitViewModel(C item)
        {
            return new BusinessBaseViewModel<C>(item);
        }
    }
}
