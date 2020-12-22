using System;
using System.Collections.Generic;
using System.Linq;
// using Features.MyLinq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func types using lambda expressions - the first generic types describe the incoming parameters and the last generic type is the return type 
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(3));
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(5, 5));

            // Action type using lambda expressions - always returns void, the generic type parameter only describe the incoming parameter to the method
            Action<int> write = x => Console.WriteLine(x);
            write(square(add(3, 5)));

            Employee[] developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott"},
                new Employee { Id = 2, Name = "Chris"}
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };

            foreach (var employee in developers.Where(e => e.Name.Length == 5).OrderBy(e => e.Name))
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
