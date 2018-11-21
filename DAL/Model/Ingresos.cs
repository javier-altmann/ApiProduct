using System.Collections.Generic;

namespace DAL.Model
{
    public class Ingresos : BaseEntity 
    {
        public virtual IList<ChildrenProducts> ChildrenProducts { get; set; }        
        public string Description { get; set; }
        public int Quantity { get; set; } 
    }
}