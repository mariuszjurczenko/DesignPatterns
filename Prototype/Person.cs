﻿namespace Prototype
{
    /// <summary>
    /// Prototype
    /// </summary>
    public abstract class Person
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }

        public abstract Person Clone(bool deepClone);
    }
}
