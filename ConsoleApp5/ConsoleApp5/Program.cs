int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i < n; i++)
{
    int lastN = n % 10;
    n = n/10;
    if (lastN > 5)
    {
        
        sum = sum + lastN;
    }
   
}
Console.WriteLine(sum);