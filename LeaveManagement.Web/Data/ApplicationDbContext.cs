using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Create a table based on the LeaveType class and call it LeaveTypes
        public DbSet<LeaveType> LeaveTypes { get; set; }

        // Create a table based on the LeaveAllocation class and call it LeaveAllocations
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

    }
}