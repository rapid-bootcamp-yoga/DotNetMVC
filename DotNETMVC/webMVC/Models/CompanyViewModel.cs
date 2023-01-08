namespace webMVC.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public String CompanyName { get; set; }
        public String Segmentasi { get; set; }
        public String Address { get; set; }
        
        public CompanyViewModel()
        {

        }

        public CompanyViewModel(int id, string companyName, string segmentasi, string address)
        {
            Id = id;
            CompanyName = companyName;
            Segmentasi = segmentasi;
            Address = address;
        }
    }
}
