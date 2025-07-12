namespace week2
{
    public class Employee
    {
        public static double TAX;
        public string? fName = "";
        public string? lName = "";
        public double wage;
        public double loggedHoures;

        private double Calculate() => (wage) * (loggedHoures);

        private double CalculateTAX() => (Calculate()) * (TAX);

        private double CalculateNetSalary() => (Calculate()) - (CalculateTAX());

        public string PrintSlip()
        {
            return "\n\n----------------------------------------------"
                + $"\nFirst Name   : {fName}"
                + $"\nLast Name    : {lName}"
                + $"\nWage         : {wage}"
                + $"\nLogged Hours : {loggedHoures}"
                + "----------------------------------------------"
                + $"\nSalary       : ${Calculate()}"
                + $"\nTAX Rate     : {TAX:P0}"
                + $"\nTAX Amount   : ${CalculateTAX()}"
                + $"\nNetSalary    : ${CalculateNetSalary()}"
                + "\n----------------------------------------------\n";
        }
    }
}

