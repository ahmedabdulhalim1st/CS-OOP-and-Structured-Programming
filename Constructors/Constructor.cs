using System.Data;

namespace Week2;

class Program
{
    static int Main()
    {
        Employee E1 = Employee.Create(100, "Ahmad", "A.");
        System.Console.WriteLine(E1.DisplayName());
        return 0;
    }
}

public class Employee
{
    private Employee() { }

    private Employee(int id, string fName, string lName)
    {
        this.id = id;
        this.fName = fName;
        this.lName = lName;
    }

    public static Employee Create(int id, string fName, string lName)
    {
        return new Employee(id, fName, lName);
    }

    private Int32 id;
    private string fName;
    private string lName;

    public string DisplayName()
    {
        return $"ID: {id}\nName: {fName} {lName}";
    }
}
