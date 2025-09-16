using InheritanceMapping.Context;
using System;

namespace InheritanceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyContext dbContext = new CompanyContext();
            #region Inheritance Mapping

            #region 1.Table Per Concrete Type [TPCT]
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Full Time Employee 1",
            //    Salary = 50000,
            //    Age = 24,
            //    StartDate = DateTime.Now,
            //    Adress = "Address 1"
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Part Time Employee 1",
            //    HourlyRate = 50,
            //    Age = 22,
            //    Adress = "Address 2"
            //};
            //dbContext.Add(fullTimeEmployee);
            //dbContext.Add(partTimeEmployee);
            //dbContext.SaveChanges();

            //var fullTimeEmployees = (from emp in dbContext.FullTimeEmployees
            //                         select emp).FirstOrDefault();

            //var partTimeEmployees = (from emp in dbContext.PartTimeEmployees
            //                         select emp).FirstOrDefault();

            //if (fullTimeEmployees != null)
            //{
            //    Console.WriteLine($"Full Time Employee: {fullTimeEmployees.Name}, Salary: {fullTimeEmployees.Salary}");
            //}
            //else
            //{
            //    Console.WriteLine("No Full Time Employee found.");
            //}

            //if (partTimeEmployees != null)
            //{
            //    Console.WriteLine($"Part Time Employee: {partTimeEmployees.Name}, Hourly Rate: {partTimeEmployees.HourlyRate}");
            //}
            //else
            //{
            //    Console.WriteLine("No Part Time Employee found.");
            //}

            #endregion
            #endregion
        }
    }
}