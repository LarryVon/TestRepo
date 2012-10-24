﻿using System;
namespace StruggleFree.Data
{
    public interface IEntityStorage
    {
        IEntityData AddOrUpdate(IEntityData item);
        IEntityData Get(int instanceID);
        IEntityData Get(string editValue, int parentEntityID = -1);
        IEntityData[] GetAll();
        IEntityData New(int parentInstanceID = -1);
        IEntityData Refresh(IEntityData item);
        bool TryGet(int instanceID, out IEntityData item);
        bool TryGet(string editValue, out IEntityData item, int parentEntityID = -1);
    }
}
