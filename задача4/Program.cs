//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a,b,c;

Console.WriteLine ("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.WriteLine ("max = ");
Console.WriteLine (max);