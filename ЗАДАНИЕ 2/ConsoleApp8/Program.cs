using System.Globalization;
    class Program
    {
        static void Main()
        {
            DateTime dt;
            int a = int.Parse(Console.ReadLine()); //day
            int b = int.Parse(Console.ReadLine()); //month
            int c = int.Parse(Console.ReadLine()); //year
            string date = $"{a}, {b}, {c}";

            JulianCalendar calendar = new JulianCalendar();
            if (DateTime.TryParse(date, out dt))
            {
                if (b != 2)
                {
                    a = a + 13;
                }
                if (a > 30)
                {
                    int temp = a - 30;
                    a = temp;
                    b += 1;
                }
                if (b > 12)
                {
                    int temp = b - 12;
                    b = temp;
                    c += 1;
                }
                Console.WriteLine($"{ a} {b} {c}");
            }
            else
            {
                Console.WriteLine("Неверная дата ");
            }
        }
    }

