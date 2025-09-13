using EntitySession01Ass.Context;
using System;

namespace EntitySession01Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
        }
    }
}