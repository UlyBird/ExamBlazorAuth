using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }
    }
}
