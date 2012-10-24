using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public class BusinessBaseViewModel<T> : SelectionViewModel<T>, INotifyPropertyChanged, IViewModel
        where T : SFEpic.Csla4.BusinessBase<T>
    {
        public BusinessBaseViewModel()
        {
            SetPropertiesAtObjectLevel();
            ManageObjectLifetime = true;
        }

        public BusinessBaseViewModel(T model) 
            : this()
        {
            if (model != null)
            {
                Model = model;
            }
        }

        #region Properties

        private Exception _error;
        public Exception Error
        {
            get { return _error; }
            protected set
            {
                if (!ReferenceEquals(_error, value))
                {
                    _error = value;
                    OnPropertyChanged("Error");
                    if (_error != null)
                        OnError(_error);
                }
            }
        }

        public event EventHandler<ErrorEventArgs> ErrorOccurred;

        protected virtual void OnError(Exception error)
        {
            if (ErrorOccurred != null)
                ErrorOccurred(this, new ErrorEventArgs { Error = error });
        }

        private bool isValid;
        public bool IsValid
        {
            get
            {
                return isValid;
            }
            set
            {
                if (isValid != value)
                {
                    isValid = value;
                    OnPropertyChanged("IsValid");
                }
            }
        }

        private bool managedObjectLifetime;
        public bool ManageObjectLifetime
        {
            get
            {
                return managedObjectLifetime;
            }
            set
            {
                if (managedObjectLifetime != value)
                {
                    managedObjectLifetime = value;
                    OnPropertyChanged("ManageObjectLifetime");
                }
            }
        }

        #endregion

        #region Can Properties

        private bool canCancel;
        public virtual bool CanCancel
        {
            get
            {
                return canCancel;
            }
            private set
            {
                if (value == canCancel)
                {
                    return;
                }
                canCancel = value;
                OnPropertyChanged("CanCancel");
            }
        }

        private bool canCreate;
        public virtual bool CanCreate
        {
            get
            {
                return canCreate;
            }
            private set
            {
                if (value == canCreate)
                {
                    return;
                }
                canCreate = value;
                OnPropertyChanged("CanCreate");
            }
        }

        private bool canCreateObject;
        public virtual bool CanCreateObject
        {
            get
            {
                return canCreateObject;
            }
            private set
            {
                if (value == canCreateObject)
                {
                    return;
                }
                canCreateObject = value;
                OnPropertyChanged("CanCreateObject");
            }
        }

        private bool canDelete;
        public virtual bool CanDelete
        {
            get
            {
                return canDelete;
            }
            private set
            {
                if (value == canDelete)
                {
                    return;
                }
                canDelete = value;
                OnPropertyChanged("CanDelete");
            }
        }

        private bool canDeleteObject;
        public virtual bool CanDeleteObject
        {
            get
            {
                return canDeleteObject;
            }
            private set
            {
                if (value == canDeleteObject)
                {
                    return;
                }
                canDeleteObject = value;
                OnPropertyChanged("CanDeleteObject");
            }
        }

        private bool canEdit;
        public virtual bool CanEdit
        {
            get
            {
                return canEdit;
            }
            private set
            {
                if (value == canEdit)
                {
                    return;
                }
                canEdit = value;
                OnPropertyChanged("CanEdit");
            }
        }

        private bool canEditObject;
        public virtual bool CanEditObject
        {
            get
            {
                return canEditObject;
            }
            private set
            {
                if (value == canEditObject)
                {
                    return;
                }
                canEditObject = value;
                OnPropertyChanged("CanEditObject");
            }
        }

        private bool canFetch;
        public virtual bool CanFetch
        {
            get
            {
                return canFetch;
            }
            private set
            {
                if (value == canFetch)
                {
                    return;
                }
                canFetch = value;
                OnPropertyChanged("CanFetch");
            }
        }

        private bool canGetObject;
        public virtual bool CanGetObject
        {
            get
            {
                return canGetObject;
            }
            private set
            {
                if (value == canGetObject)
                {
                    return;
                }
                canGetObject = value;
                OnPropertyChanged("CanGetObject");
            }
        }

        private bool canSave;
        public virtual bool CanSave
        {
            get
            {
                return canSave;
            }
            private set
            {
                if (value == canSave)
                {
                    return;
                }
                canSave = value;
                OnPropertyChanged("CanSave");
            }
        }

        protected void SetPropertiesAtObjectLevel()
        {
            Type sourceType = typeof(T);

            CanCreateObject = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.CreateObject, sourceType);
            CanGetObject = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.GetObject, sourceType);
            CanEditObject = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, sourceType);
            CanDeleteObject = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.DeleteObject, sourceType);

            // call SetProperties to set "instance" values 
            SetProperties();
        }

        protected virtual void SetAdditionalProperties() { }
        protected virtual bool SetCanEdit() { return true; }
        protected virtual bool SetCanSave() { return true; }
        protected virtual bool SetCanCancel() { return true; }
        protected virtual bool SetCanCreate() { return true; }
        protected virtual bool SetCanDelete() { return true; }
        protected virtual bool SetCanFetch() { return true; }

        protected void SetProperties()
        {
            T model = Model;
            if (model != null)
            {
                bool isModelBusy = model.IsBusy;
                CanEdit = CanEditObject && !isModelBusy && SetCanEdit();
                CanSave = CanEditObject && model.IsSavable && !isModelBusy && SetCanSave();
                CanCancel = CanEditObject && model.IsDirty && !isModelBusy && SetCanCancel();
                CanCreate = CanCreateObject && !model.IsDirty && !isModelBusy && SetCanCreate();
                CanDelete = CanDeleteObject && !isModelBusy && SetCanDelete();
                CanFetch = CanGetObject && !model.IsDirty && !isModelBusy && SetCanFetch();
                IsValid = model.IsValid;
            }
            else
            {
                CanEdit = false;
                CanSave = false;
                CanCancel = false;
                CanCreate = CanCreateObject && SetCanCreate();
                CanDelete = false;
                CanFetch = CanGetObject && SetCanFetch();
                IsValid = false;
            }
            SetAdditionalProperties();
        }

        #endregion

        #region Verbs

        /// <summary>
        /// Creates or retrieves a new instance of the 
        /// Model by invoking a static factory method.
        /// </summary>
        /// <param name="factoryMethod">Static factory method function.</param>
        /// <example>DoRefresh(BusinessList.GetList)</example>
        /// <example>DoRefresh(() => BusinessList.GetList())</example>
        /// <example>DoRefresh(() => BusinessList.GetList(id))</example>
        protected void DoRefresh(Func<T> factoryMethod)
        {
            if (typeof(T) != null)
            {
                Error = null;
                try
                {
                    Model = factoryMethod.Invoke();
                }
                catch (Exception ex)
                {
                    Error = ex;
                }
                OnRefreshed();
            }
        }

        /// <summary>
        /// Creates or retrieves a new instance of the 
        /// Model by invoking a static factory method.
        /// </summary>
        /// <param name="factoryMethod">Name of the static factory method.</param>
        /// <param name="factoryParameters">Factory method parameters.</param>
        protected virtual void DoRefresh(string factoryMethod, params object[] factoryParameters)
        {
            if (typeof(T) != null)
            {
                Error = null;
                try
                {
                    Model = (T)Csla.Reflection.MethodCaller.CallFactoryMethod(typeof(T), factoryMethod, factoryParameters);
                }
                catch (Exception ex)
                {
                    Error = ex;
                }
                OnRefreshed();
            }
        }

        /// <summary>
        /// Creates or retrieves a new instance of the 
        /// Model by invoking a static factory method.
        /// </summary>
        /// <param name="factoryMethod">Name of the static factory method.</param>
        protected virtual void DoRefresh(string factoryMethod)
        {
            DoRefresh(factoryMethod, new object[] { });
        }

        /// <summary>
        /// Creates or retrieves a new instance of the 
        /// Model by invoking a static factory method.
        /// </summary>
        /// <param name="factoryMethod">Static factory method action.</param>
        /// <example>BeginRefresh(BusinessList.BeginGetList)</example>
        /// <example>BeginRefresh(handler => BusinessList.BeginGetList(handler))</example>
        /// <example>BeginRefresh(handler => BusinessList.BeginGetList(id, handler))</example>
        protected void BeginRefresh(Action<EventHandler<Csla.DataPortalResult<T>>> factoryMethod)
        {
            if (typeof(T) != null)
                try
                {
                    Error = null;
                    IsBusy = true;

                    var handler = (EventHandler<Csla.DataPortalResult<T>>)CreateHandler(typeof(T));
                    factoryMethod(handler);
                }
                catch (Exception ex)
                {
                    Error = ex;
                    IsBusy = false;
                }
        }

        /// <summary>
        /// Creates or retrieves a new instance of the 
        /// Model by invoking a static factory method.
        /// </summary>
        /// <param name="factoryMethod">Name of the static factory method.</param>
        /// <param name="factoryParameters">Factory method parameters.</param>
        protected virtual void BeginRefresh(string factoryMethod, params object[] factoryParameters)
        {
            if (typeof(T) != null)
                try
                {
                    Error = null;
                    IsBusy = true;
                    var parameters = new List<object>(factoryParameters);
                    parameters.Add(CreateHandler(typeof(T)));

                    Csla.Reflection.MethodCaller.CallFactoryMethod(typeof(T), factoryMethod, parameters.ToArray());
                }
                catch (Exception ex)
                {
                    Error = ex;
                    IsBusy = false;
                }
        }

        /// <summary>
        /// Creates or retrieves a new instance of the 
        /// Model by invoking a static factory method.
        /// </summary>
        /// <param name="factoryMethod">Name of the static factory method.</param>
        protected virtual void BeginRefresh(string factoryMethod)
        {
            BeginRefresh(factoryMethod, new object[] { });
        }

        private Delegate CreateHandler(Type objectType)
        {
            var args = typeof(Csla.DataPortalResult<>).MakeGenericType(objectType);
            System.Reflection.MethodInfo method = Csla.Reflection.MethodCaller.GetNonPublicMethod(GetType(), "QueryCompleted");
            Delegate handler = Delegate.CreateDelegate(typeof(EventHandler<>).MakeGenericType(args), this, method);
            return handler;
        }

        private void QueryCompleted(object sender, EventArgs e)
        {
            try
            {
                var eventArgs = (Csla.IDataPortalResult)e;
                if (eventArgs.Error == null)
                {
                    var model = (T)eventArgs.Object;
                    OnRefreshing(model);
                    Model = model;
                }
                else
                    Error = eventArgs.Error;
                OnRefreshed();
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected virtual void OnRefreshing(T model)
        { }

        protected virtual void OnRefreshed()
        { }

        protected virtual T DoSave()
        {
            T result = (T)Model;
            Error = null;
            try
            {
                var savable = Model as Csla.Core.ISavable;
                if (ManageObjectLifetime)
                {
                    // clone the object if possible
                    ICloneable clonable = Model as ICloneable;
                    if (clonable != null)
                        savable = (Csla.Core.ISavable)clonable.Clone();

                    //apply changes
                    var undoable = savable as Csla.Core.ISupportUndo;
                    if (undoable != null)
                        undoable.ApplyEdit();
                }

                result = (T)savable.Save();

                Model = result;
                OnSaved();
            }
            catch (Exception ex)
            {
                Error = ex;
                OnSaved();
            }
            return result;
        }

        /// <summary>
        /// Saves the Model, first committing changes
        /// if ManagedObjectLifetime is true.
        /// </summary>
        protected virtual void BeginSave()
        {
            try
            {
                var savable = Model as Csla.Core.ISavable;
                if (ManageObjectLifetime)
                {
                    // clone the object if possible
                    ICloneable clonable = Model as ICloneable;
                    if (clonable != null)
                        savable = (Csla.Core.ISavable)clonable.Clone();

                    //apply changes
                    var undoable = savable as Csla.Core.ISupportUndo;
                    if (undoable != null)
                        undoable.ApplyEdit();
                }

                savable.Saved += (o, e) =>
                {
                    IsBusy = false;
                    if (e.Error == null)
                    {
                        var result = e.NewObject;
                        var model = (T)result;
                        OnSaving(model);
                        Model = model;
                    }
                    else
                    {
                        Error = e.Error;
                    }
                    OnSaved();
                };
                Error = null;
                IsBusy = true;
                savable.BeginSave();
            }
            catch (Exception ex)
            {
                IsBusy = false;
                Error = ex;
                OnSaved();
            }
        }

        public virtual void Save(object sender, ExecuteEventArgs e)
        {
            BeginSave();
        }

        protected virtual void OnSaving(T model)
        { }

        protected virtual void OnSaved()
        { }

        public virtual void Cancel(object sender, ExecuteEventArgs e)
        {
            DoCancel();
        }

        protected virtual void DoCancel()
        {
            if (ManageObjectLifetime)
            {
                var undo = Model as Csla.Core.ISupportUndo;
                if (undo != null)
                {
                    undo.CancelEdit();
                    undo.BeginEdit();
                }
            }
        }

        public virtual void Delete(object sender, ExecuteEventArgs e)
        {
            DoDelete();
        }

        protected virtual void DoDelete()
        {
            var model = Model;
            if (model != null && CanDelete)
            {
                model.Delete();
            }
        }

        #endregion

        #region Model

        //protected T model;
        //public T Model
        //{
        //    get
        //    {
        //        return model;
        //    }
        //    set
        //    {
        //        if (Object.ReferenceEquals(model, value))
        //        {
        //            return;
        //        }
        //        T oldVal = model;
        //        model = value;
        //        OnModelChanged(oldVal, model);
        //        OnPropertyChanged("Model");
        //    }
        //}

        protected override void OnModelChanged(T oldVal, T newVal)
        {
            base.OnModelChanged(oldVal, newVal);
            if (Object.ReferenceEquals(oldVal, newVal))
            {
                return;
            }
            if (oldVal != null)
            {
                oldVal.BusyChanged -= Model_BusyChanged;
                oldVal.ChildChanged -= Model_ChildChanged;
                oldVal.PropertyChanged -= Model_PropertyChanged;
            }
            if (newVal != null)
            {
                newVal.BusyChanged += Model_BusyChanged;
                newVal.ChildChanged += Model_ChildChanged;
                newVal.PropertyChanged += Model_PropertyChanged;
                if (ManageObjectLifetime)
                {
                    newVal.BeginEdit();
                }
            }
            SetProperties();
        }

        protected virtual void Model_BusyChanged(object sender, Csla.Core.BusyChangedEventArgs e)
        {
            // only set busy state for entire object.  Ignore busy state based
            // on asynch rules being active
            if (e.PropertyName == string.Empty)
                IsBusy = e.Busy;
            else
                SetProperties();
        }

        protected virtual void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SetProperties();
        }

        protected virtual void Model_ChildChanged(object sender, Csla.Core.ChildChangedEventArgs e)
        {
            SetProperties();
        }

        #endregion
    }
}
