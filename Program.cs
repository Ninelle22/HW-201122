// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();

Write ("Введите первое число: ");
int number = int.Parse(Readline());
Write ("Введите второе число:");
int number2 = int.Parse(Readline());

if (number>number2)
{
    WriteLine($"Число {number} является максимальным, а число {number2} минимальным");
}
else
{
    WriteLine($"Число {number} является минимальным, а число {number2} минимальным");   
}
