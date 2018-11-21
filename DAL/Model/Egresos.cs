using System.Collections.Generic;

namespace DAL.Model
{
    public class Egresos : BaseEntity
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public virtual ChildrenProducts ChildrenProduct { get; set; } 
        
    }
}