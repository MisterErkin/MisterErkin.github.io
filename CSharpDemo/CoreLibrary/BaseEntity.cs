using System;

namespace CoreLibrary
{
    // Abstract class (Requirement 9)
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        // Abstract method
        public abstract void Save();

        // Virtual method with default implementation
        public virtual string GetInfo()
        {
            return $"Entity ID: {Id}, Created: {CreatedDate}";
        }
    }
}
