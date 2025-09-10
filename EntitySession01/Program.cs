using EntitySession01.Context;
using EntitySession01.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntitySession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            using CompanyDbContext dbContext = new CompanyDbContext();
            dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            Employee emp01 = new Employee()
            {
                //Id = 1,
                Name = "John Doe",
                Salary = 5000,
                Age = 24
            };
            Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            //Different Ways to Add Entity to Table in DB
            //1st Way
            dbContext.Employees.Add(emp01);
            //2nd Way
            dbContext.Set<Employee>().Add(emp01);
            //3rd Way
            dbContext.Add(emp01);
            Console.WriteLine($"Entity State : {dbContext.Entry<Employee>(emp01).State}");
            //Save Changes
            dbContext.SaveChanges();
            #endregion
            #endregion
        }
    }
}