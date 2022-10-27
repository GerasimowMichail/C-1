// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа (a, b, c)"); //вывели значение в скобках
Console.Write("Введите три числа: a= ");
int a=Convert.ToInt32 ( Console.ReadLine()); // производим конвертацию в int 32
Console.Write("Введите три числа: b= ");
int b=Convert.ToInt32 ( Console.ReadLine());
Console.Write("Введите три числа: c= ");
int c=Convert.ToInt32 ( Console.ReadLine());

if (a<b) 
    {if (b<c)
      { 
        Console.WriteLine($"максимальное число равно c: {c}");
         }
      else 
      Console.WriteLine($"максимальное число равно b: {b}");
    }
else 
    if (a>c)
    { 
        Console.WriteLine($"максимальное число равно a: {a}");
    }
    else 
      Console.WriteLine($"максимальное число равно c: {c}");