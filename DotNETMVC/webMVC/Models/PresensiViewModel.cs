namespace webMVC.Models
{
    public class PresensiViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PresensiStartDate { get; set; }
        public DateTime PresensiEndDate { get; set; }
        public String Description { get; set; }
    }
}
