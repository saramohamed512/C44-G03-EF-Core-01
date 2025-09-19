
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
        }
    }
}