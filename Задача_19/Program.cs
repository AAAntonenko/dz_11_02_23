// n1 * 10 000 + n2 * 1 000 * n3 * 100 * n4 * 10 + n5
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int n5 = number%10; 
int n4 = ((number%100)-n5)/10; 
int n3 = ((number % 1000)-n4*10-5)/100; 
int n2 = ((number % 10000)-n3*100-n4*10-n5)/1000; 
int n1 = (number / 10000); 

if (n5 == n1 && n4 == n2 )
{
  Console.WriteLine("Это число палиндром");
}
else
{
  Console.WriteLine("Это число не палиндром");
}