using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();

            course.Level = ContentContext.EContentLevel.Beginner;

            foreach(var item in course.Modules)
            {
                

            }

            var module = new Module();
        }
    }
}
