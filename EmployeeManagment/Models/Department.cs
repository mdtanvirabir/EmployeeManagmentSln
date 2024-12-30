using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Required]
        public string DepartmentName { get; set; }
        public int? ManagerID { get; set; }
        public decimal Budget { get; set; }
    }

}
