Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());


if( n > 0 )
{
    while ( n > 0 )
    {
    int cube = n*n*n;
    Console.Write($"{cube}, ");
    n = n-1;
    }
    return;
}
if( n < 0 )
{
    while ( n < 0 )
    {
    int cube = n*n*n;
    Console.Write($"{cube}, ");
    n = n+1;
    }
    return;
}
if (n == 0)
{
    Console.WriteLine("Куб от 0 это 0");
}