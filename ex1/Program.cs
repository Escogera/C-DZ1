Console.WriteLine("Введите 1е число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max=");
    Console.WriteLine(a);
    Console.Write("min=");
    Console.Write(b);
}
else 
{
    Console.Write("max=");
    Console.WriteLine(b);
    Console.Write("min=");
    Console.Write(a);
}