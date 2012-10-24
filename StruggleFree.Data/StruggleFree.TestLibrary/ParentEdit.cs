using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StruggleFree.TestData;
using StruggleFree.Entities;

namespace StruggleFree.TestLibrary
{
    [Serializable()]
    public class ParentEdit : BusinessBase<ParentEdit>
    {
        #region Business Methods

        #region ParentID

        protected static Csla.PropertyInfo<int> ParentIDProperty = RegisterProperty<int>(c => c.ParentID);
        public int ParentID
        {
            get { return GetProperty(ParentIDProperty); }
            protected set { SetProperty(ParentIDProperty, value); }
        }

        #endregion

        #region Name

        protected static Csla.PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
        public string Name
        {
            get { return GetProperty(NameProperty); }
            set { SetProperty(NameProperty, value); }
        }

        #endregion

        protected override string GetEditValue()
        {
            return Name;
        }

        #endregion

        #region Factory Methods

        //public static ParentEdit New()
        //{
        //    return Csla.DataPortal.Create<ParentEdit>();
        //}

        //public static ParentEdit Get(int parentID)
        //{
        //    return Csla.DataPortal.Fetch<ParentEdit>(parentID);
        //}

        //public static ParentEdit Get(string name)
        //{
        //    return Csla.DataPortal.Fetch<ParentEdit>(name);
        //}

        protected bool isIllegal = true;
        public ParentEdit() { }

        #endregion

        #region Data Access

        protected Parent parent;
        protected override void DataPortal_Create()
        {
            isIllegal = false;
            parent = StruggleFree.TestData.Root.Instance.New<Parent>();
            using (BypassPropertyChecks)
            {
                ParentID = parent.InstanceID;
            }
            BusinessRules.CheckRules();
        }

        protected virtual void DataPortal_Fetch(int parentID)
        {
            FetchCore(StruggleFree.TestData.Root.Instance.Get<Parent>(parentID));
        }

        protected virtual void DataPortal_Fetch(string name)
        {
            FetchCore(StruggleFree.TestData.Root.Instance.Get<Parent>(name));
        }

        protected virtual void FetchCore(Parent parent)
        {
            this.parent = parent;
            isIllegal = false;
            using (BypassPropertyChecks)
            {
                ParentID = parent.InstanceID;
                Name = parent.Name;
            }
        }

        protected virtual void GatherCore()
        {
            using (BypassPropertyChecks)
            {
                parent.Name = Name;
            }
        }

        protected virtual void DataPortal_Delete()
        {
            DataPortal_DeleteSelf();
        }

        protected override void DataPortal_DeleteSelf()
        {
            //SecurityRoot.Instance.RemoveUser(GatherCore());
        }

        protected override void DataPortal_Insert()
        {
            GatherCore();
            parent = StruggleFree.TestData.Root.Instance.AddOrUpdate(parent);
        }

        protected override void DataPortal_Update()
        {
            GatherCore();
            parent = StruggleFree.TestData.Root.Instance.AddOrUpdate(parent);
        }

        #endregion
    }
}
