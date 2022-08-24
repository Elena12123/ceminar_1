Console.WriteLine("введите целове число a ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите целое число b ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите целое число c ");
int c = Convert.ToInt32 (Console.ReadLine());
int max = 0;

if (a < b)
{
    Console.WriteLine(max = b);
}
else if (b < c)
{
    Console.WriteLine(max = c);
}
else if (c < a)
{
    Console.WriteLine(max = a);
}
else
{
    Console.WriteLine(max);
}
