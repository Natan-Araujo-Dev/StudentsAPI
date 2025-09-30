using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models.Entities;

namespace StudentsAPI.ApiDbContext
{
    public class IStudentsAPIDbContext : DbContext
    {
        public IStudentsAPIDbContext(DbContextOptions<IStudentsAPIDbContext> options) : base(options)
        {
        }

        public DbSet<StudentModel>? Students { get; set; }
    }
}
