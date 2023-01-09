namespace webMVC.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }


        public CustomerViewModel()
        {

        }

        public CustomerViewModel(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
