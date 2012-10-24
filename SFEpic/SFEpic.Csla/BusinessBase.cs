using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Csla4
{
    [Serializable()]
    public class BusinessBase<T> : Csla.BusinessBase<T>, IHoldsRichBrokenRules
        where T : BusinessBase<T>
    {
        #region Business Methods

        public bool IsEditable
        {
            get
            {
                return Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, this);
            }
        }

        public static Csla.PropertyInfo<bool> IsDraftProperty = RegisterProperty<bool>(p => p.IsDraft);
        public bool IsDraft
        {
            get { return GetProperty<bool>(IsDraftProperty); }
            set { SetProperty(IsDraftProperty, value); }
        }

        public static Csla.PropertyInfo<bool> IsReadOnlyProperty = RegisterProperty<bool>(p => p.IsReadOnly);
        public bool IsReadOnly
        {
            get { return (bool)GetProperty(IsReadOnlyProperty); }
            set { SetProperty(IsReadOnlyProperty, value); }
        }

        public override bool IsSelfValid
        {
            get
            {
                if (IsDraft)
                {
                    return true;
                }
                return base.IsSelfValid;
            }
        }

        public override bool IsValid
        {
            get
            {
                if (IsDraft)
                {
                    return true;
                }
                return base.IsValid;
            }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case "IsReadOnly":
                    OnPropertyChanged("IsEditable");
                    break;

                default:
                    break;
            }
        }

        protected System.Collections.ObjectModel.ReadOnlyObservableCollection<RichBrokenRule> readOnlyRichBrokenRules;
        public System.Collections.ObjectModel.ReadOnlyObservableCollection<RichBrokenRule> RichBrokenRules
        {
            //
            // This is pretty inefficient ... need way to cache the broken rules in the object so
            // it returns the same collection unless changed.  Or something to not rebuild the
            // broken rules every time a property changes unless the rules change
            //
            // Perhaps an override of IsValid that caches the value and fires PropertyChanged when it changes
            // ViewModel calls IsValid a lot
            // Could also be used to invalidate the RichBrokenRules collection when needed so it won't be rebuilt every time
            //
            get
            {
                var richBrokenRules = new System.Collections.ObjectModel.ObservableCollection<RichBrokenRule>();
                LoadBrokenRules(richBrokenRules);
                var children = FieldManager.GetChildren();
                foreach (var child in children)
                {
                    if (child is IEnumerable)
                    {
                        var childObjects = ((IEnumerable)child).OfType<IHoldsRichBrokenRules>();
                        foreach (var childObject in childObjects)
                        {
                            foreach (var brokenRule in childObject.RichBrokenRules)
                            {
                                richBrokenRules.Add(brokenRule);
                            }
                        }
                    }
                    else if (child is IHoldsRichBrokenRules)
                    {
                        foreach (var brokenRule in ((IHoldsRichBrokenRules)child).RichBrokenRules)
                        {
                            richBrokenRules.Add(brokenRule);
                        }
                    }
                }
                return new System.Collections.ObjectModel.ReadOnlyObservableCollection<RichBrokenRule>(richBrokenRules);
            }
        }

        protected virtual void LoadBrokenRules(System.Collections.ObjectModel.ObservableCollection<RichBrokenRule> richBrokenRules)
        {
            foreach (var brokenRule in BrokenRulesCollection)
            {
                richBrokenRules.Add(new RichBrokenRule(this, brokenRule));
            }
        }

        #endregion

        #region Factory Methods

        protected BusinessBase() : base() { }

        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new ReadOnlyRule());
        }

        public bool IsPropertyValid(Csla.Core.IPropertyInfo property)
        {
            return BrokenRulesCollection.Count(r => r.Property == property.Name) == 0;
        }

        protected class ReadOnlyRule : Csla.Rules.AuthorizationRule
        {
            public ReadOnlyRule()
                : base(Csla.Rules.AuthorizationActions.EditObject)
            {
            }

            public override bool CacheResult
            {
                get
                {
                    return false;
                }
            }

            protected override void Execute(Csla.Rules.AuthorizationContext context)
            {
                BusinessBase<T> target = context.Target as BusinessBase<T>;
                if (target != null)
                {
                    context.HasPermission = !target.ReadProperty(IsReadOnlyProperty);
                }
                else
                {
                    context.HasPermission = true;
                }
            }
        }

        #endregion
    }
}
