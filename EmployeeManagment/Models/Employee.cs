using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Position { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        public string Status { get; set; } = "active";

        public int DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
    }
}
