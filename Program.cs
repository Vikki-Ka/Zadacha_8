/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();
Console.Write("Ввидите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int i = 2;

while (i <= number1)
{
Console.Write(i + " ");
i += 2;
}