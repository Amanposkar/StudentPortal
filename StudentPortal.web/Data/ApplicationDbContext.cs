using Microsoft.EntityFrameworkCore;
using StudentPortal.web.Models.Entities;

namespace StudentPortal.web.Data
{
    //DbContext birdge between application and sqlserver
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
