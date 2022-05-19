using Microsoft.EntityFrameworkCore;
using SEProjectApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class SEProjectAppDbContext: DbContext
    {
        public SEProjectAppDbContext(DbContextOptions<SEProjectAppDbContext> options) : base(options)
        { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
