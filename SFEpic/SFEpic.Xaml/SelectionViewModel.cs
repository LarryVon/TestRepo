using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public class SelectionViewModel<T> : INotifyPropertyChanged, IViewModel
    {
        public SelectionViewModel() { }

        public SelectionViewModel(T model)
        {
            Model = model;
        }

        #region Properties

        private string busyMessage;
        public string BusyMessage
        {
            get
            {
                return busyMessage;
            }
            set
            {
                if (busyMessage != value)
                {
                    busyMessage = value;
                    OnPropertyChanged("BusyMessage");
                }
            }
        }

        protected int BusyCount
        {
            get
            {
                return busyCount;
            }
        }

        protected void ClearBusy()
        {
            busyCount = 0;
            OnPropertyChanged("IsBusy");
        }

        private int busyCount;
        public bool IsBusy
        {
            get
            {
                return busyCount > 0;
            }
            set
            {
                //if (isBusy != value)
                //{
                //    isBusy = value;
                //    OnPropertyChanged("IsBusy");
                //}
                if (value)
                {
                    if (++busyCount == 1)
                    {
                        OnPropertyChanged("IsBusy");
                    }
                }
                else
                {
                    if (busyCount > 0)
                    {
                        if (--busyCount == 0)
                        {
                            OnPropertyChanged("IsBusy");
                        }
                    }
                }
            }
        }

        private bool isSelected;
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    OnIsSelectedChanged();
                    OnPropertyChanged("IsSelected");
                }
            }
        }

        public event EventHandler IsSelectedChanged;
        protected void OnIsSelectedChanged()
        {
            EventHandler ev = IsSelectedChanged;
            if (ev != null)
            {
                ev(this, new EventArgs());
            }
        }

        protected T model;
        public T Model
        {
            get
            {
                return model;
            }
            set
            {
                if (Object.ReferenceEquals(model, value))
                {
                    return;
                }
                T oldVal = model;
                model = value;
                OnModelChanged(oldVal, model);
                OnPropertyChanged("Model");
            }
        }

        protected virtual void OnModelChanged(T oldVal, T newVal) { }

        #endregion

        #region OnPropertyChanged

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region IViewModel

        object IViewModel.Model
        {
            get
            {
                return Model;
            }
            set
            {
                Model = (T)value;
            }
        }

        #endregion
    }
}
