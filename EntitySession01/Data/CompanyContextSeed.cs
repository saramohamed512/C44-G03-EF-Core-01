using EntitySession01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Data
{
    internal class CompanyContextSeed
    {
        public static bool Seed(CompanyDbContext dbContext)
        {
            try
            {
                if (!dbContext.Employees.Any())
                {
                    var EmpData = File.ReadAllText("Files\\employees.json");
                    var Employees = System.Text.Json.JsonSerializer.Deserialize<List<Models.Employee>>(EmpData);

                    if (Employees.Count > 0)
                    {
                        dbContext.Employees.AddRange(Employees);
                        dbContext.SaveChanges();

                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
