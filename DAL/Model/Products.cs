using System.Collections.Generic;

namespace DAL.Model
{
    public class Products : BaseEntity 
    {
        public virtual IList<ChildrenProducts> ChildrenProduct { get; set; }
        public string Code { get; set; }
    }
}