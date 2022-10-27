// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());

int i = 1;
while (i<x)
{
   if (i%2 = 0)
    Console.WriteLine("четные числа {i}");
    i=i+1;
}
