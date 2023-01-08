namespace webMVC.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public String Description { get; set; }

        public OrderViewModel() 
        {
        }

        public OrderViewModel(int id, int count, string description)
        {
            Id = id;
            Count = count;
            Description = description;
        }
    }
}
