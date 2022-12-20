//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b;

Console.WriteLine ("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine ($"большее число = {a} , а меньшее число = {b}");
}

else
{
    Console.WriteLine ($"большее число = {b} , а меньшее число = {a}");
}
