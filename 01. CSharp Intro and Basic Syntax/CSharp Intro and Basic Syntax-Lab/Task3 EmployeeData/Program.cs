using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine(
                $"Name: {name}" + System.Environment.NewLine +
                $"Age: {age}" + System.Environment.NewLine +
                $"Employee ID: {id:D8}" + System.Environment.NewLine +
                $"Salary: {salary:F2}");
        }
    }
}
