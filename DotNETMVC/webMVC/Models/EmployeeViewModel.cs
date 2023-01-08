namespace webMVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public String EmployeeName { get; set; }
        public String Email { get; set; }
        public String Position { get; set; }

        public EmployeeViewModel() 
        { 
        }

        public EmployeeViewModel(int id, string employeeName, string email, string position)
        {
            Id = id;
            EmployeeName = employeeName;
            Email = email;
            Position = position;
        }
    }
}
