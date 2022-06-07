class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int neededNumber = rnd.Next(1, n);
        int k = rnd.Next(10, n);
        bool isWin = false;
        while (k > 0 & isWin == false)
        {
            Console.WriteLine($"У вас есть {k} попыток");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber == neededNumber)
            {
                Console.WriteLine("Ура! вы угадали");
                isWin = true;
            }
            else
            {
                if (inputNumber > neededNumber)
                {
                    Console.WriteLine("Число меньше");
                }
                else
                {
                    Console.WriteLine("Число больше");
                }
                k -= 1;
            }
        }
        if (k <= 0)
        {
            Console.WriteLine("К сожалению попытки кончились");
        }
    }
}