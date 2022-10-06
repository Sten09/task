/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число A ");
string A = Console.ReadLine();
Console.WriteLine("Введите число B ");
string B = Console.ReadLine();

int numA = int.Parse(A);
int numB = int.Parse(B);

if(numA > numB)
Console.WriteLine($"{numA} = максимальное число");
else
Console.WriteLine($"Максимальное число = {numB}");
Console.WriteLine($"Минимальное число = {numA}");