// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a number: ");
int n = int.Parse(Console.ReadLine());
int n_10 = n / 10;
int res = n_10 % 10;
Console.WriteLine($"Second digit of the number -> {res}");
