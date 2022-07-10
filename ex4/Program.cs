//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
int a=1;
int b=-1;
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());   
if (Math.Abs(n)<2)
{
    Console.WriteLine ("нет четных чисел");
}
else
{
    if (n>0)
    {
        while (a<=n)
            {    
            if (a%2==0)
            Console.Write(a);
            Console.Write(" ");
            a++;      
            }
    }   
    else
    {
        while (b>=n)
            {    
            if (b%2==0)
            Console.Write(b);
            Console.Write(" ");
            b--; 
            }
    }
}


