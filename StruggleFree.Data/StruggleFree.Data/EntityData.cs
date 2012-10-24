/*
 * Created by SharpDevelop.
 * User: Larry Kurtze
 * Date: 6/18/2011
 * Time: 9:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace StruggleFree.Data
{
	[Serializable()]
	public abstract class EntityData : ICloneable, StruggleFree.Data.IEntityData
	{
		public EntityData()
		{
		}
		
		public string EditValue
		{
			get;
			protected internal set;
		}
		
		public int InstanceID
		{
			get;
			protected internal set;
		}

        public DateTime Timestamp
        {
            get;
            protected internal set;
        }

        public override string ToString()
        {
            return EditValue;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
