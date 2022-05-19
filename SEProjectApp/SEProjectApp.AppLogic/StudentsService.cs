using SEProjectApp.Abstractions.Repository;
using SEProjectApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.AppLogic
{
    public class StudentsService
    {
        private readonly IStudentsRepository studentsRepo;
        public StudentsService(IStudentsRepository studentsRepo)
        {
            this.studentsRepo = studentsRepo;
        }

        public ICollection<Student> GetStudentsWithNoCourse()
        {
            return studentsRepo.GetStudentsWithNoCourse()
                 .ToList();
        }

        public decimal GetStudentAverageGrade(Student student)
        {
            return student.Grades.Average(grade => (grade.Value));
        }

    }
}
