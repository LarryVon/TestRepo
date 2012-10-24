using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public abstract class SelectionListViewModelBase<T, C, V> : ObservableCollection<V>, INotifyPropertyChanged
        where T:IEnumerable<C>
        where V:SelectionViewModel<C>
    {
        protected SelectionListViewModelBase(T collection, bool isMultiSelect = true)
        {
            IsMultiSelect = isMultiSelect;
            Init(collection);
        }

        protected virtual void Init(T collection)
        {
            UnderlyingCollection = collection;
            if (collection == null)
            {
                return;
            }
            foreach (var item in collection)
            {
                var vm = InitViewModel(item);
                vm.IsSelectedChanged += new EventHandler(vm_IsSelectedChanged);
                if (vm.IsSelected)
                {
                    selectedItems.Add(vm);
                }
                Add(vm);
            }
        }

        protected virtual void vm_IsSelectedChanged(object sender, EventArgs e)
        {
            if (!isMultiSelect)
            {
                return;
            }
            var vm = (V)sender;
            if (vm.IsSelected)
            {
                selectedItems.Add(vm);
            }
            else
            {
                selectedItems.Remove(vm);
            }
            if (selectedItems.Count > 0)
            {
                selectedItem = selectedItems[0];
            }
            else
            {
                selectedItem = default(V);
            }
        }

        public V GetViewModel(C item)
        {
            foreach (var vm in this)
            {
                if (Object.ReferenceEquals(item, vm.Model))
                {
                    return vm;
                }
            }
            return null;
        }

        private bool isMultiSelect;
        public bool IsMultiSelect
        {
            get
            {
                return isMultiSelect;
            }
            set
            {
                if (value != isMultiSelect)
                {
                    isMultiSelect = value;
                    OnIsMultiSelectChanged();
                }
            }
        }

        protected virtual void OnIsMultiSelectChanged()
        {
            if (isMultiSelect)
            {
                if (SelectedItem != null)
                {
                    selectedItems.Add(SelectedItem);
                }
            }
            else
            {
                selectedItems.Clear();
            }
            OnPropertyChanged("IsMultiSelect");
        }

        protected abstract V InitViewModel(C item);

        private V selectedItem;
        public V SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (isMultiSelect)
                {
                    throw new InvalidOperationException("SelectedItem cannot be set when IsMultiSelect is true");
                }
                if (!Object.ReferenceEquals(selectedItem, value))
                {
                    selectedItem.IsSelected = false;
                    selectedItem = value;
                    selectedItem.IsSelected = true;
                    OnPropertyChanged("SelectedItem");
                }
            }
        }

        protected ObservableCollection<V> selectedItems = new ObservableCollection<V>();
        protected ReadOnlyObservableCollection<V> readOnlySelectedItems;
        public ReadOnlyObservableCollection<V> SelectedItems
        {
            get
            {
                if (!isMultiSelect)
                {
                    throw new InvalidOperationException("SelectedItems cannot be retrieved when IsMultiSelect is false");
                }
                if (readOnlySelectedItems == null)
                {
                    readOnlySelectedItems = new ReadOnlyObservableCollection<V>(selectedItems);
                }
                return readOnlySelectedItems;
            }
        }

        protected T UnderlyingCollection
        {
            get;
            set;
        }

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
    }
}
