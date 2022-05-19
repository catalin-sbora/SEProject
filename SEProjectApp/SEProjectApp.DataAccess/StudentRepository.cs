using Microsoft.EntityFrameworkCore;
using SEProjectApp.Abstractions.Repository;
using SEProjectApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class StudentRepository : BaseRepository<Student>, IStudentsRepository
    {
        public StudentRepository(SEProjectAppDbContext dbContext) : base(dbContext)
        {
        }
        public override ICollection<Student> GetAll()
        {
            return dbContext.Set<Student>()
                            .Include(student => student.Courses)
                            .ToList();
        }

        public IEnumerable<Student> GetStudentsWithNoCourse()
        {
            return dbContext.Set<Student>()
                            .Include(student => student.Courses)
                            .Where(student => student.Courses.Count == 0)
                            .AsEnumerable();
        }
    }
}
