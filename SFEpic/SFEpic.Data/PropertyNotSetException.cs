using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Data
{
    [Serializable()]
    public class PropertyNotSetException : System.Exception
    {
        public PropertyNotSetException() : base() { }

        public PropertyNotSetException(string message) : base(message) { }

        public PropertyNotSetException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        public PropertyNotSetException(string message, Exception innerException)
            : base(message, innerException) {}
    }
}
