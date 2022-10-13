using WebApi.DbOperations;
using WebApi.Entites;

namespace Tests.WebApi.UnitTests.TestSetup
{
    public static class Teachers
    {
        public static void AddTeachers(this UniManSystemDbContext context)
        {
            context.Teachers.AddRange(
                new Teacher {Name = "Yasin", Surname = "Fiyat", YearsOfExperience = 5, DepartmentId = 1},
                new Teacher {Name = "Nuran", Surname ="Işık", YearsOfExperience = 4, DepartmentId = 2},
                new Teacher {Name = "Duran", Surname = "Işık", YearsOfExperience = 8, DepartmentId = 3}
            );
        }
    }
}