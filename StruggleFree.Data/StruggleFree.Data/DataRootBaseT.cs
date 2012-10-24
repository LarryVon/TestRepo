using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bamboo.Prevalence;
using Bamboo.Prevalence.Attributes;

namespace StruggleFree.Data
{
    [Serializable()]
    public abstract class DataRootBase<T> : DataRootBase
        where T:DataRootBase<T>
    {
        protected static T instance;

        static DataRootBase()
        {
            engine = PrevalenceActivator.CreateTransparentEngine(typeof(T), System.IO.Path.Combine(Environment.CurrentDirectory, "Data"));
            instance = engine.PrevalentSystem as T;
        }

        public DataRootBase() : base()
        {
            //InitEntityStorage();
        }

        protected T AddOrUpdate<T>(T entity) where T : EntityData, new()
        {
            return GetEntityStorage<T>().AddOrUpdate(entity);
        }

        protected virtual IEntityStorage<T> GetEntityStorage<T>() where T : EntityData, new()
        {
            IEntityStorage storage = null;
            if (storageDictionary.TryGetValue(typeof(T), out storage))
            {
                return (IEntityStorage<T>)storage;
            }
            return null;
        }

        [Query()]
        public T Get<T>(int instanceID) where T : EntityData, new()
        {
            return GetEntityStorage<T>().Get(instanceID);
        }

        [Query()]
        public T Get<T>(string editValue, int parentInstanceID = -1) where T : EntityData, new()
        {
            return GetEntityStorage<T>().Get(editValue, parentInstanceID);
        }

        [Query()]
        public T[] GetAll<T>() where T:EntityData, new()
        {
            return GetEntityStorage<T>().GetAll();
        }

        [Query()]
        public T New<T>() where T : EntityData, new()
        {
            return GetEntityStorage<T>().New();
        }

        [Query()]
        public T New<T, P>(P parentEntity)
            where T : EntityData, new()
            where P : EntityData, new()
        {
            return this.New<T>(parentEntity.InstanceID);
        }

        [Query()]
        public T New<T>(int parentInstanceID) where T : EntityData, new()
        {
            return GetEntityStorage<T>().New(parentInstanceID);
        }


        public static T Instance
        {
            get
            {
                return instance;
            }
        }

        public static void TakeSnapshot()
        {
            engine.TakeSnapshot();
        }

        //[Query()]
        //protected abstract void InitEntityStorage();
    }
}
