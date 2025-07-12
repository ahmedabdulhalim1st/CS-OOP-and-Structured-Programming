using System.Data;

namespace Week2;

class Program
{
    static int Main()
    {
        Employee E1 = new Employee();
        E1.Id = 1000;
        E1.FName = "Ahmad";
        E1.LName = "A.";

        // Object Initilizer
        Employee E2 = new Employee
        {
            // more Common
            Id = 2000,
            FName = "Issam",
            LName = "A.",
        };

        Employee E3 = new Employee(3000) { FName = "Mohammad", LName = "M." };

        System.Console.WriteLine(E3.DisplayName());
        return 0;
    }
}

public class Employee
{
    public Int32 Id;
    public string FName;
    public string LName;

    public Employee() { }

    public Employee(int id)
    {
        Id = id;
    }

    public string DisplayName()
    {
        return $"ID: {Id}\nName: {FName} {LName}";
    }
}
