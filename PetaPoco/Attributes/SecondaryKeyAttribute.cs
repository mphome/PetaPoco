using System;

namespace PetaPoco
{


    /// <summary>
    /// Specifies the secondary key column of a poco class, whether the column is auto incrementing
    /// and the sequence name for Oracle sequence columns.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SecondaryKeyAttribute : Attribute
    {
        public SecondaryKeyAttribute(string key)
        {
            this.Value = key;
        }

        public string Value
        {
            get;
            private set;
        }
    }
}