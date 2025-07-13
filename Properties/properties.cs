using System.Data;

namespace Week2;

class Program
{
    static int Main()
    {
        // Client
        Dollar D1 = new(1.0099m);
        // D1.setAmount(-2.85m); // set Property
        D1.MyProperty = 2.33m;
        Console.WriteLine(D1.MyProperty); // get Property
        Console.WriteLine(D1.isZero); // get Property
        Console.WriteLine(D1.conversionFactor); // get Property

        return 0;
    }
}

public class Dollar
{
    private decimal _amount;

    // you can create public method for get and set if it needed
    public decimal MyProperty { get; set; }

    public Dollar(decimal amount)
    {
        // backing Process
        // Amount = ProcessAmount(amount);
        _amount = ProcessAmount(amount);
    }

    // public decimal Amount
    // {
    //     // readonly property
    //     get => _amount;
    //     private set => _amount = ProcessAmount(value);
    // }

    // don't Repeat Yourself
    public void setAmount(decimal amount)
    {
        MyProperty = ProcessAmount(amount);
        // Amount = amount;
    }

    public decimal getAmount()
    {
        return MyProperty;
    }

    private decimal ProcessAmount(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);

    // property Validation
    public bool isZero => MyProperty == 0;

    // Poperty Initilization You can't Modify it
    public decimal conversionFactor { get; set; } = 1.99m;
}
