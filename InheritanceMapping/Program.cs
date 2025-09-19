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
            #region 2.Table Per Hierarchy [TPH]
            //Employee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Full Time Employee 1",
            //    Salary = 50000,
            //    Age = 24,
            //    StartDate = DateTime.Now,
            //    Adress = "Address 1"
            //};
            //Employee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Part Time Employee 1",
            //    HourlyRate = 50,
            //    Age = 22,
            //    Adress = "Address 2"
            //};
            //dbContext.Add(fullTimeEmployee);

            //dbContext.Add(partTimeEmployee);
            //dbContext.SaveChanges();

            //var employees = (from emp in dbContext.Employees
            //                 select emp).ToList();
            //foreach (var emp in employees)
            //    {
            //    if (emp is FullTimeEmployee fte)
            //    {
            //        Console.WriteLine($"Full Time Employee: {fte.Name}, Salary: {fte.Salary}");
            //    }
            //    else if (emp is PartTimeEmployee pte)
            //    {
            //        Console.WriteLine($"Part Time Employee: {pte.Name}, Hourly Rate: {pte.HourlyRate}");
            //    }
            //}
            //foreach (var emp in employees.OfType<FullTimeEmployee>())
            //{
            //    Console.WriteLine($"Employee: {emp.Name}, Type: {emp.GetType().Name}");
            //}

            #endregion
            #region 3.Table Per Type [TPT]
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

            //var employees = (from emp in dbContext.Employees
            //                 select emp).ToList();
            //foreach (var emp in employees)
            //    {
            //    if (emp is FullTimeEmployee fte)
            //    {
            //        Console.WriteLine($"Full Time Employee: {fte.Name}, Salary: {fte.Salary}");
            //    }
            //    else if (emp is PartTimeEmployee pte)
            //    {
            //        Console.WriteLine($"Part Time Employee: {pte.Name}, Hourly Rate: {pte.HourlyRate}");
            //    }
            //}
            #endregion
            #endregion

            #region Session05
            #region Local
            #region Ex01

            // Request DataBase
            //var Result = dbContext.Employees.Any(E => E.Age != null);
            //Console.WriteLine(Result);

            //Local
            //It Can't Send Request For DataBase
            //var Result = dbContext.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(Result);

            #endregion
            #region Ex02
            //var Emp01= dbContext.Employees.FirstOrDefault();
            //if (Emp01 != null) { 
            //    Console.WriteLine(Emp01);
            //    Emp01.Age = null;
            //}

            ////DataBase
            //var Result1 = dbContext.Employees.Any(E => E.Age == null);
            //Console.WriteLine($"DB :  {Result1} ");

            ////C# Application
            //var Result = dbContext.Employees.Local.Any(E => E.Age == null);
            //Console.WriteLine($"Local Result :  { Result} ");
            #endregion
            #endregion
            #endregion

        }
    }
}