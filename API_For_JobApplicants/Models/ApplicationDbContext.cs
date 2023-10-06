using Microsoft.EntityFrameworkCore;

namespace API_For_JobApplicants.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Applicants> Applicants { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Applications> Applications { get; set; }

    }
}
