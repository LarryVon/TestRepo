using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public class RowProperty<T> : INotifyPropertyChanged, SFEpic.Data.IRowProperty
    {
        public RowProperty(DataRow row, DataColumn<T> column)
        {
            Row = row;
            Column = column;
            value = column.DefaultValue;
        }

        public RowProperty(DataRow row, DataColumn<T> column, T value)
        {
            Row = row;
            Column = column;
            SetValue(value);
        }

        protected bool canGet;
        public virtual bool CanGet
        {
            get
            {
                return canGet;
            }
            set
            {
                if (value != canGet)
                {
                    canGet = value;
                    OnPropertyChanged("CanGet");
                }
            }
        }

        protected bool canSet = true;
        public virtual bool CanSet
        {
            get
            {
                return canSet;
            }
            set
            {
                if (value != canSet)
                {
                    canSet = value;
                    OnPropertyChanged("CanSet");
                }
            }
        }

        public DataColumn<T> Column
        {
            get;
            protected set;
        }

        public DataRow Row
        {
            get;
            protected set;
        }

        public bool IsChanged
        {
            get;
            protected set;
        }

        protected bool isSet;
        public virtual bool IsSet
        {
            get
            {
                return isSet;
            }
            set
            {
                if (value != isSet)
                {
                    isSet = value;
                    OnPropertyChanged("IsSet");
                    CanSet = isSet;
                    CanGet = isSet;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            IsChanged = true;
            PropertyChangedEventHandler ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void SetValue(T value)
        {
            this.value = value;
            isSet = true;
            canSet = true;
            canGet = true;
        }

        protected T value;
        public T Value
        {
            get
            {
                if (CanGet)
                {
                    return value;
                }
                else
                {
                    return Column.DefaultValue;
                }
            }
            set
            {
                if (CanSet)
                {
                    IEquatable<T> equatableNew = value as IEquatable<T>;
                    if (equatableNew != null)
                    {
                        IEquatable<T> equatableValue = (IEquatable<T>)this.value;
                        if (equatableValue == null || !equatableValue.Equals(equatableNew))
                        {
                            SetValue(value);
                            OnPropertyChanged("Value");
                        }
                    }
                    else
                    {
                        SetValue(value);
                        OnPropertyChanged("Value");
                    }
                }
                else
                {
                    throw new System.InvalidOperationException("Cannot set Value");
                }
            }
        }

        IDataColumn IRowProperty.Column
        {
            get { return this.Column; }
        }

        object IRowProperty.Value
        {
            get
            {
                return this.Value;
            }
            set
            {
                this.Value = (T)value;
            }
        }
    }
}
