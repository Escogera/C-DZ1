//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите 1е число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a>b)
{
    max=a;
}
else 
{
    max=b;
}
if (max>c)
{
    Console.Write("max=");   
    Console.WriteLine(max);     
}
else 
{
    max=c;
    Console.Write("max=");   
    Console.WriteLine(max);     
}