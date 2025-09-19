
using System;

namespace DatabaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}