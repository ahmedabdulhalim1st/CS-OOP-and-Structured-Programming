using System.Data;

namespace Week2;

class Program
{
    static int Main()
    {
        Date Day1 = new(2025);

        System.Console.WriteLine(Day1.GetDateString());

        return 0;
    }

    public class Date
    {
        private static readonly int[] NumberOfDays =
        {
            0,
            31,
            28,
            31,
            30,
            31,
            30,
            31,
            31,
            30,
            31,
            30,
            31,
        };
        private static readonly int[] NumberOfDaysLeap =
        {
            0,
            31,
            29,
            31,
            30,
            31,
            30,
            31,
            31,
            30,
            31,
            30,
            31,
        };
        private readonly byte day = 01;
        private readonly byte month = 01;
        private readonly short year = 0001;

        public Date(byte day, byte month, short year)
        {
            bool isLeap = (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] Days = isLeap ? NumberOfDaysLeap : NumberOfDays;
                if (day >= 1 && day <= Days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }
        }

        public Date(short year)
            : this(01, 01, year) { }

        public Date(byte month, short year)
            : this(01, month, year) { }

        public string GetDateString()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
        }
    }
}
