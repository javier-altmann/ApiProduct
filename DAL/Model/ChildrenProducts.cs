namespace DAL.Model
{
    public class ChildrenProducts : BaseEntity  
    {
        public Colors Color { get; set; }
        public Products Product { get; set; }
        public Sizes Size { get; set; }
    }
}