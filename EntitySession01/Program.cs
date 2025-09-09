using EntitySession01.Context;
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

            #endregion
        }
    }
}