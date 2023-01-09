namespace webMVC.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public String Description { get; set; }
        public int ProductId { get; set; }

        public OrderViewModel() 
        {
        }

        public OrderViewModel(int id, int count, string description, int productId)
        {
            Id = id;
            Count = count;
            Description = description;
            ProductId = productId;
        }
    }
}
