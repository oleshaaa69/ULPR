
    int[] a = new int[int.Parse(Console.ReadLine())];
Console.WriteLine(a.Select(x => x = int.Parse(Console.ReadLine())).Where(x =>
Math.Abs(x) % 2 == 0).Min().ToString());
Console.ReadKey();

