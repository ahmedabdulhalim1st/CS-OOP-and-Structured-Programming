namespace week2
{
    // ClassModifier > Public - internal [Default]
    // <ClassModifier> calss <CalssName>
    // {
    //      calss Block [Fields - Constants - Properties - Methods - Events
    //  - Opterators - Indexers - Constructors - Finalizers - Nasted Types]
    // }
    public class Employee
    {
        // <AccessModifiers> Public, Private, Protected
        // Constants > <AccessModifiers> const <DataType> <ConstName> = <Value>;
        public static double TAX;

        // <AccessModifiers> Public, Private, Protected
        // Fields > <AccessModifiers> <DataType> <FieldName> = <InitialValue>;
        public string? fName = "";
        public string? lName = "";
        public double wage;
        public double loggedHoures;
    }
}
