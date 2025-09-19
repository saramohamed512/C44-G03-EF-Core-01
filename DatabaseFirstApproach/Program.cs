
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Contexts.MyNorthwindDbContext dbContext = new Contexts.MyNorthwindDbContext();

            #region Database First With Commands
            /*
             * 1. Download Packages
             *      -EntityFrameworkCore.SqlServer
             *      -Entity FrameworkCore.Tools
             *      -Entity FrameworkCore.Proxies
             *      
             * 2. Use Database 'Northwind' => Scaffold => Package Manager Console
             *      A) Scaffold-DbContext
             *          -Connection 
             *              -Provider
             *                  -Context
             *                      -ContextDir
             *                          -OutputDir => Models OutPut
             *                              -Tables
             *                          
             */

            //Get All Products Name
            //Opening Connection
            //using Contexts.MyNorthwindDbContext dbContext = new Contexts.MyNorthwindDbContext();
            //var products = dbContext.Products.ToList();
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}");
            //}
            #endregion
            #region DataBase First With EF Core Power Tools

            /*
             * 1. Install EF Core Power Tools Extension
             * 2. Right Click on Project => EF Core Power Tools => Reverse Engineer
             * 
             * Don't forget to inject "TrustServerCertificate = true" in connection string in class DBContext
             */

            //using Contexts.MyNorthwindDbContext dbContext = new Contexts.MyNorthwindDbContext();
            //var Emps = dbContext.Employees.ToList();
            //foreach (var emp in Emps)
            //{
            //    Console.WriteLine($"Employee Name: {emp.FirstName} {emp.LastName}");
            //}

            #endregion
            #region Run SQL Queries VIA Apllication
            //using Contexts.MyNorthwindDbContext dbContext = new Contexts.MyNorthwindDbContext();
            #region Select

            //int CategoryID = 1;
            //var Result = dbContext.Products
            //    .FromSqlRaw("SELECT * FROM Products Where CategoryID={0}",CategoryID);
            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine($"Product Name: {item.ProductName}");
            //     }


            ////$
            //Result = dbContext.Products
            //    .FromSqlInterpolated($"SELECT * FROM Products Where CategoryID={CategoryID}");
            #endregion

            #region Update , Delete
            //var Result = dbContext.Database.ExecuteSqlRaw("UPDATE Products SET ProductName = 'ICE Coffe' WHERE ProductID=1");

            //int ProductID = 1;
            //var Result = dbContext.Database.ExecuteSqlInterpolated($"UPDATE Products SET ProductName = 'ICE Coffe' WHERE ProductID={ProductID}");

            //Console.WriteLine(Result);

            //var Result = dbContext.Database.ExecuteSqlInterpolated($"DELETE FROM Products WHERE ProductID={ProductID}");
            //Console.WriteLine(Result);
            #endregion

            #endregion
            #region Views
            //var Result = dbContext.ProductsByCategories.ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category Name: {item.CategoryName} - Product Name: {item.ProductName}");
            //}
            #endregion
        }
    }
}