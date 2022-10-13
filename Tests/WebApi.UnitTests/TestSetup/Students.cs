using WebApi.DbOperations;
using WebApi.Entites;

namespace Tests.WebApi.UnitTests.TestSetup
{
    public static class Students
    {
        public static void AddStudents(this UniManSystemDbContext context)
        {
            context.Students.AddRange(
                new Student {Name = "Samet", Surname = "Taşkın", Email = "samet@gmail.com", Password = "1234567",
                            CurrentGrade = 3, GPA = 3.59},
                new Student {Name = "Yusuf", Surname = "Gergin", Email = "yusuf@gmail.com", Password = "123456",
                            CurrentGrade = 3, GPA = 3.65},
                new Student {Name = "Ayşenur", Surname = "Doğru", Email = "aysenur@gmail.com", Password = "12345678",
                            CurrentGrade = 2, GPA = 2.98}
            );
        }
    }
}