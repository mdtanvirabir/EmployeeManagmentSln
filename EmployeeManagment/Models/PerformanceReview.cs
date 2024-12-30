using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class PerformanceReview
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        [Range(1, 10)]
        public int ReviewScore { get; set; }

        public string ReviewNotes { get; set; }

        public virtual Employee? Employee { get; set; }
    }

}
