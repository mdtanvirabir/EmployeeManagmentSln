using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PerformanceReview> PerformanceReviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PerformanceReview>()
                .HasKey(pr => pr.ReviewID);

            base.OnModelCreating(modelBuilder);
        }
    }

}
