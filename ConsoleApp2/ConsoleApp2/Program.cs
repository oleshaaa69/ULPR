
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if ((a <= x && b <= y) || (c <= x && c <= y)) 
        {
    Console.WriteLine("Кирпич пройдет в отверстие");
}
else
{
    Console.WriteLine("Кирпич не пройдет отверстие");
}