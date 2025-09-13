using EntitySession01Ass.Context;
using EntitySession01Ass.Data;
using System;

namespace EntitySession01Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region Dynamic Data Seed



            //bool flag = ITIDbContextSeed.seed(dbContext);
            //if (flag)
            //{
            //    Console.WriteLine("Data Seed Done");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            #endregion
        }
    }
}