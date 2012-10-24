using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public class BrokenRulesViewModelCollection : SelectionListViewModel<ReadOnlyObservableCollection<SFEpic.Csla4.RichBrokenRule>, SFEpic.Csla4.RichBrokenRule>
    {
        public BrokenRulesViewModelCollection(ReadOnlyObservableCollection<SFEpic.Csla4.RichBrokenRule> collection) 
            : base(collection)
        {
            
        }

        public virtual string ErrorCountText
        {
            get
            {
                switch (Count)
                {
                    case 0:
                        return "No Errors";
                        break;

                    case 1:
                        return "1 Error";
                        break;

                    default:
                        return String.Concat(Count, " Errors");
                        break;
                }
            }
        }

        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.PropertyName == "Count")
            {
                OnPropertyChanged("ErrorCountText");
            }
        }
    }
}
