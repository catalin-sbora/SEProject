using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEProjectApp.AppLogic;
using SEProjectApp.DataModel;
using System;
using System.Collections.Generic;

namespace SEProjectApp.UnitTests
{
    [TestClass]
    public class StudentsServiceTests
    {
        [TestMethod]
        public void GetStudentAverageGrade_ShouldReturn_AverageValue_Of_TheGrades()
        {   //AAA

            //Arrange
            StudentsService service = new StudentsService(null);
            Student student = new Student()
            {
                Id = Guid.NewGuid(),
                Courses = new List<Course>(),
                Name = "Student One"
            };

            student.Grades = new List<Grade>
                            {
                                new Grade() { Id = Guid.NewGuid(), Student=student, Value = 9.00m },
                                new Grade() { Id = Guid.NewGuid(), Student=student, Value = 10.00m },
                                new Grade() { Id = Guid.NewGuid(), Student=student, Value = 8.00m }
                            };

            //Act
            var retValue = service.GetStudentAverageGrade(student);


            //Assert
            Assert.AreEqual(9.00m, retValue);

        }
    }
}
