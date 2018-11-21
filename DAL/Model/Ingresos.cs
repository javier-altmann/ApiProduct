namespace DAL.Model
{
    public class Ingresos : BaseEntity
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ChildrenProducts ChildrenProduct { get; set; } 
        
    }
}