namespace Indexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Emps = new Employee[]
            {
                new Employee{Id = 3, Name = "Ahmad Mohammad", Gender = 'M', TotalSales= 5000},
                new Employee{Id = 8, Name = "Aya Mohammad", Gender = 'F',TotalSales =60000},
                new Employee{Id = 9, Name = "Nora Mohammad", Gender = 'F',TotalSales= 5700},
                new Employee{Id = 7, Name = "Sara Ahmad", Gender = 'F',TotalSales = 80000},
                new Employee{Id = 12, Name = "Adel Hamzawy", Gender = 'M',TotalSales= 45000},
                new Employee{Id = 32, Name = "Ali Maher", Gender = 'M',TotalSales= 30000},
                new Employee{Id = 11, Name = "Sherif Othman", Gender = 'M',TotalSales = 11000}
             };

            var Reports = new Report();
            Reports.ProcessEmployee(Emps, "Employees With Target Greater Than $60,000", IsGreaterThan60000);
            Reports.ProcessEmployee(Emps, "Employees With Target Greater Than $30,000 & Less Than $60,000", IsGreaterThan30000AndLessThan60000);
            Reports.ProcessEmployee(Emps, "Employees With Target Less Than $30,000", IsLessThan30000);

            Console.ReadKey();
        }
        public static bool IsGreaterThan60000(Employee E) => E.TotalSales >= 60000;
        public static bool IsGreaterThan30000AndLessThan60000(Employee E) => E.TotalSales >= 30000 && E.TotalSales < 60000;
        public static bool IsLessThan30000(Employee E) => E.TotalSales < 30000;

    }
}
