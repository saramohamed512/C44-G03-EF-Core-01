using EntitySession01Ass.Context;
using EntitySession01Ass.Data;
using Microsoft.EntityFrameworkCore;
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
            #region Eager Loading

            // Eager loading: Courses with Topic
            //var coursesWithTopic = dbContext.Courses
            //    .Include(c => c.Topic)
            //    .ToList();
            //foreach (var course in coursesWithTopic)
            //{
            //    Console.WriteLine($"{course.Name} - Topic: {course.Topic?.Name}");
            //}

            #endregion
            #region Explicit Loading

            //Example 1: Reference navigation(Student -> Department)
            //var student = dbContext.Students.FirstOrDefault(s => s.ID == 1);
            //if (student != null)
            //{
            //    Console.WriteLine($"Student Name: {student.FName} {student.LName}");
            //    Console.WriteLine($"Department ID: {student.Dep_Id}");

            //    //Explicitly load the Department reference
            //    dbContext.Entry(student).Reference(s => s.Department).Load();
            //    Console.WriteLine($"Department Name: {student.Department?.Name}");
            //}

            ////Example 2: Collection navigation(Department -> Students)
            //var department = dbContext.Departments.FirstOrDefault(d => d.ID == 1);
            //if (department != null)
            //{
            //    Console.WriteLine($"Department Name: {department.Name}");

            //    // Explicitly load the Students collection
            //    dbContext.Entry(department).Collection(d => d.Students).Load();

            //    foreach (var stud in department.Students)
            //    {
            //        Console.WriteLine($"Student: {stud.FName} {stud.LName}");
            //    }
            //}

            ////Example 3: Collection navigation with filter(Department -> Students where Age< 30)
            //var department2 = dbContext.Departments.FirstOrDefault(d => d.ID == 2);
            //if (department2 != null)
            //{
            //    Console.WriteLine("Failed");
            //    Console.WriteLine($"Department Name: {department2.Name}");

            //    // Explicitly load filtered Students collection
            //    dbContext.Entry(department2)
            //        .Collection(d => d.Students)
            //        .Query()
            //        .Where(s => s.Age < 30)
            //        .Load();

            //    foreach (var stud in department2.Students)
            //    {
            //        Console.WriteLine($"Student (Age<30): {stud.FName} {stud.LName}");
            //    }
            //}

            #endregion
        }
    } 
}