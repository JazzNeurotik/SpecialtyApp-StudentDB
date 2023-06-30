using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SpecialtyApp.Models
{
    public class SpecialtyContext : DbContext
    {
        public SpecialtyContext(DbContextOptions<SpecialtyContext> options) : base(options)
        { }

        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
