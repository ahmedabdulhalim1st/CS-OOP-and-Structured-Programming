namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var EuroStock = new Stock("Amazon");
            //Console.WriteLine(EuroStock.Name);
            EuroStock.Price = 100;

            // Subscriber in the Event
            // Useage of Lambda Expression
            EuroStock.ChangeStockPriceBy(0.05m); // green
            EuroStock.ChangeStockPriceBy(-0.09m); // red
            EuroStock.ChangeStockPriceBy(0.00m); // gray   
            EuroStock.OnPriceChanged += (stock, oldPrice) =>
            {
                if (stock.Price > oldPrice)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (oldPrice > stock.Price)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine($"{stock.Name} : {stock.Price}");
            };
            //EuroStock.OnPriceChanged += EuroStock_OnPriceChanged; // the method you want to Excute 
            //EuroStock.ChangeStockPriceBy(0.05m); // green
            //EuroStock.ChangeStockPriceBy(-0.02m); // red
            //EuroStock.ChangeStockPriceBy(0.00m); // gray
            // UnSubscribe
            //EuroStock.OnPriceChanged -= EuroStock_OnPriceChanged;
            EuroStock.ChangeStockPriceBy(0.05m); // green
            EuroStock.ChangeStockPriceBy(-0.09m); // red
            EuroStock.ChangeStockPriceBy(0.00m); // gray    
            //Console.WriteLine($"Amazon Stock Price at EuroStock Before Changed ${EuroStock.Price}");
            //EuroStock.ChangeStockPriceBy(0.05m);
            //Console.WriteLine($"Amazon Stock Price at EuroStock after Changed ${EuroStock.Price}");

            Console.ReadKey();

        }
        private static void EuroStock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine($"{stock.Name} : {stock.Price}");
        }
    }
    // Delegate is an object Points at Method
    // Publisher of the Event
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
    public class Stock
    {
        private string _name;
        private decimal _price;
        public event StockPriceChangeHandler OnPriceChanged;
        public string Name => this._name;

        public decimal Price { get => this._price; set => this._price = value; }

        public Stock(string name)
        {
            this._name = name;
        }

        // We need to handle That case of Changnes Due to Events 

        public void ChangeStockPriceBy(decimal Present)
        {
            // using event delegate
            decimal oldPrice = this.Price;
            Price += Math.Round(Present * this.Price, 2);
            // check if There is a Subscriber or not
            if (OnPriceChanged != null)
            {
                // I will send then the new price to the subscreibers and the old one too;
                OnPriceChanged(this, oldPrice);
            }
        }
    }
}

