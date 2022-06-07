    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < 12 + 1; i++)
            {
                DateTime date = new DateTime(a, i, DateTime.DaysInMonth(a, i));
                Console.WriteLine($"{date.Month} месяц: {date.Day - (7 + (int)date.DayOfWeek - 4) % 7} четвергов");
            }
        }
    }
