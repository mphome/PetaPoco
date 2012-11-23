// PetaPoco - A Tiny ORMish thing for your POCO's.
// Copyright © 2011-2012 Topten Software.  All Rights Reserved.

using System;

namespace PetaPoco
{

    /// <summary>
    /// Marks a poco property as a result only column that is populated in queries
    /// but not used for updates or inserts.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ResultColumnAttribute : ColumnAttribute
    {
        public ResultColumnAttribute()
        {
        }

        public ResultColumnAttribute(string name)
            : base(name)
        {
        }
    }

    // column does not inserted and only updated
    [AttributeUsage(AttributeTargets.Property)]
    public class OnlyUpdateAttribute : ColumnAttribute
    {
        public OnlyUpdateAttribute()
        {
        }
    }

    // column does not updated and only inserted
    [AttributeUsage(AttributeTargets.Property)]
    public class OnlyInsertAttribute : ColumnAttribute
    {
        public OnlyInsertAttribute()
        {
        }
    }

}
