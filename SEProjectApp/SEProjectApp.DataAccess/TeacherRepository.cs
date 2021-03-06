using SEProjectApp.Abstractions.Repository;
using SEProjectApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeachersRepository
    {
        public TeacherRepository(SEProjectAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
