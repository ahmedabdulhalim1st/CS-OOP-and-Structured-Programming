using System.Data;

namespace Week2;

class Program
{
    static int Main()
    {
        // Client
        Dollar D1 = new(1.0099m);
        // D1.setAmount(-2.85m); // set Property
        Console.WriteLine(D1.Amount); // get Property
        Console.WriteLine(D1.isZero); // get Property
        Console.WriteLine(D1.conversionFactor); // get Property

        return 0;
    }
}

public class Dollar
{
    private decimal _amount;

    public Dollar(decimal amount)
    {
        // backing Process
        // Amount = ProcessAmount(amount);
        _amount = ProcessAmount(amount);
    }

    public decimal Amount
    {
        // readonly property
        get => _amount;
        private set => _amount = ProcessAmount(value);
    }

    // don't Repeat Yourself
    public void setAmount(decimal amount)
    {
        Amount = ProcessAmount(amount);
        // Amount = amount;
    }

    public decimal getAmount()
    {
        return Amount;
    }

    private decimal ProcessAmount(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);

    // property Validation
    public bool isZero => Amount == 0;

    // Poperty Initilization You can't Modify it
    public decimal conversionFactor { get; set; } = 1.99m;
}
