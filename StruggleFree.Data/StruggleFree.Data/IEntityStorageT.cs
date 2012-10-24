using System;
namespace StruggleFree.Data
{
    public interface IEntityStorage<T> : IEntityStorage
     where T : EntityData, new()
    {
        T AddOrUpdate(T item);
        new T Get(int instanceID);
        new T Get(string editValue, int parentEntityID = -1);
        new T[] GetAll();
        new T New(int parentInstanceID = -1);
        T Refresh(T item);
        bool TryGet(int instanceID, out T item);
        bool TryGet(string editValue, out T item, int parentEntityID = -1);
    }
}
