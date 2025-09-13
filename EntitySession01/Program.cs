using EntitySession01.Context;
using EntitySession01.Data;
using EntitySession01.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntitySession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            #region Session01
            #region Entity Framework Core
            /*
             * Features :-
             *      - Obj Relational Mapper [ORM] =>Fully ORM
             *      -Auto Tracker
             *      -Support Migrations
             *      -Support LINQ
             *      -Cross Platform
             *      -Support Multiple DBs
             * Disadvantages :-
             *      -Performance (Auto Tracker)
             *      -Complexity
             * 
             * 
             */
            #endregion
            #region ADO.NET
            /*
             * Features :-
             *      - Low Level Framework
             *      -No Tracking
             *      -Manual Connection
             *      -Direct Access to SQL
             *     
             */
            #endregion
            #region Dapper
            /*
             * Features :-
             *      - Lightweight for Simple , Small Projects
             *      -No Tracker
             *      -No Migrations
             *      -Simple API (Dapper)
             *      -Faster
             *      -Easy to use
             *      -Micro ORM
             *          Limited Features
             *     
             */
            #endregion
            #region DbContext
            //CompanyDbContext dbContext= new CompanyDbContext();
            //try 
            //{
            //}
            //finally { 
            //    dbContext.Dispose();
            //}
            //using CompanyDbContext dbContext = new CompanyDbContext();
            //dbContext.Database.Migrate();

            #endregion
            #endregion
            #region Session02
            #region Query Object Model [CRUD Operations]
            //using CompanyDbContext dbContext = new CompanyDbContext();

            #region Add new record
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //Employee emp01 = new Employee()
            //{
            //    //Id = 1,
            //    Name = "John Doe",
            //    Salary = 5000,
            //    Age = 24
            //};
            //Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            ////Different Ways to Add Entity to Table in DB
            ////1st Way
            //dbContext.Employees.Add(emp01);
            ////2nd Way
            //dbContext.Set<Employee>().Add(emp01);
            ////3rd Way
            //dbContext.Add(emp01);
            //Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            ////Save Changes
            //dbContext.SaveChanges();
            #endregion
            #region Get Data from table - select
            //var emp01 =dbContext.Employees.Where(E => E.Id == 1).FirstOrDefault();
            //var emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 1);

            //if (emp01 != null)
            //{
            //    Console.WriteLine($"Id : {emp01.Id}");
            //    Console.WriteLine($"Name : {emp01.Name}");
            //    Console.WriteLine($"Salary : {emp01.Salary}");
            //    Console.WriteLine($"Age : {emp01.Age}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}
            #endregion
            #region Update Record
            //var emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 1);
            //if (emp01 != null)
            //{
            //    Console.WriteLine($"Before Update : Name : {emp01.Name}");
            //    emp01.Name = "Sara";
            //    //Different Ways to Update Entity to Table in DB
            //    //1st Way
            //    dbContext.Employees.Update(emp01);
            //    //2nd Way
            //    //dbContext.Set<Employee>().Update(emp01);
            //    //3rd Way
            //    //dbContext.Update(emp01);
            //    Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            //    dbContext.SaveChanges();
            //    Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");

            //    Console.WriteLine($"After Update : Name : {emp01.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}
            #endregion
            #region Delete record
            //var emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 1);
            //if (emp01 != null)
            //{
            //    Console.WriteLine($"Before Delete : Name : {emp01.Name}");
            //    //Different Ways to Delete Entity to Table in DB
            //    //1st Way
            //    dbContext.Employees.Remove(emp01);
            //    //2nd Way
            //    //dbContext.Set<Employee>().Remove(emp01);
            //    //3rd Way
            //    //dbContext.Remove(emp01);
            //    Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            //    dbContext.SaveChanges();
            //    Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            //    Console.WriteLine($"After Delete : Name : {emp01.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}
            #endregion
            #endregion
            #region Relationships Between Classes

            #endregion

            #endregion
            #region Session03
            #region One to Many RS

            #endregion
            #region Many to Many RS

            #endregion
            #region Data Seed
            /*
             * 3 Ways to Seed Data
             * 1. Using Migrations
             * 2. Manual Seed
             * 3. Dynamic Seed
             */

            #region Manual Seed

            //Department Dep01 = new Department()
            //{
            //    DeptName = "IT"
            //};
            //dbContext.Add(Dep01);
            //dbContext.SaveChanges();
            //List<Department> Deps = new List<Department>()
            //{
            //    new Department(){ DeptName= "HR"},
            //    new Department(){ DeptName= "Finance"},
            //    new Department(){ DeptName= "Marketing"},
            //    new Department(){ DeptName= "Sales"}
            //};
            //dbContext.AddRange(Deps);
            //dbContext.SaveChanges();
            #endregion
            #endregion
            #region Using Migrations

            #endregion
            #region Dynamic Seed
            //bool IsSeeded = CompanyContextSeed.Seed(dbContext);
            //if (IsSeeded)
            //{
            //    Console.WriteLine("Seeded Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to Seed");
            //}

            #endregion
            #region Loading Related Data
            //var emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 5);
            //if (emp01 != null)
            //{
            //    #region Lazy Loading
            //    //Lazy Loading
            //    //Console.WriteLine($"Employee Name : {emp01.Name}");
            //    //Console.WriteLine($"Employee Dept Name : {emp01.EmployeeDepartment.DeptName}");
            //    #endregion
            //    #region Eager Loading


            //    //Eager Loading
            //    //var emp02 = dbContext.Employees
            //    //            .Include(E => E.EmployeeDepartment)
            //    //            .FirstOrDefault(E => E.Id == 5);
            //    //Console.WriteLine($"Employee Name : {emp02.Name}");
            //    //Console.WriteLine($"Employee Dept Name : {emp02.EmployeeDepartment.DeptName}");
            //    ////Explicit Loading
            //    //var emp03 = dbContext.Employees.FirstOrDefault(E => E.Id == 5);
            //    //if (emp03 != null)
            //    //{
            //    //    dbContext.Entry(emp03).Reference(E => E.EmployeeDepartment).Load();
            //    //    Console.WriteLine($"Employee Name : {emp03.Name}");
            //    //    Console.WriteLine($"Employee Dept Name : {emp03.EmployeeDepartment.DeptName}");
            //    //}
            //    #endregion
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            #region default nav property


            // default nav property
            //var EmpDept = (from D in dbContext.Departments
            //              where D.DeptId== emp01.EmpDeptId
            //              select D
            //              ).FirstOrDefault();
            //Console.WriteLine($"Employee Dept Name : {EmpDept?.DeptName}");
            #endregion

            #region Explicit Loading
            #region Example 01
            //var Emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 5);
            //if (Emp01 != null)
            //{
            //    //Explicit Loading
            //    dbContext.Entry(Emp01).Reference(E => E.EmployeeDepartment).Load();
            //    Console.WriteLine($"Employee Name : {Emp01.Name}");
            //    Console.WriteLine($"Employee Dept Name : {Emp01.EmployeeDepartment.DeptName}");
            //}
            #endregion
            #region Example 02
            //var Dept01 = dbContext.Departments.FirstOrDefault(D => D.DeptId == 3);
            //if (Dept01 != null)
            //{
            //    //Explicit Loading
            //    //dbContext.Entry(Dept01).Collection(D => D.Employees).Load();
            //    dbContext.Entry(Dept01).Collection(D => D.Employees).Query().Where(E=>E.Age <30).Load();

            //    Console.WriteLine($"Department Name : {Dept01.DeptName}");
            //    foreach (var emp in Dept01.Employees)
            //    {
            //        Console.WriteLine($"Employee Name : {emp.Name}");
            //    }
            //}
            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}