using System;
using System.Linq;

namespace Indexers
{
    public class Report
    {
        public delegate bool IllegibleSales(Employee e);
        public void ProcessEmployee(Employee[] Emps, string Title, IllegibleSales isIllegible)
        {

            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine(Title);
            foreach (var Emp in from Emp in Emps where isIllegible(Emp) select Emp)
            {
                System.Console.WriteLine($"{Emp.Id} | {Emp.Name} | {Emp.Gender} | ${Emp.TotalSales}");
            }

            System.Console.Write("\n\n");
        }
    }
}
