// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool F = true;
while (F) {
    Console.WriteLine("Enter a number [1; 7]: ");
    int n = int.Parse(Console.ReadLine());
    if (n >= 1 && n <= 7 ) {
        if (n == 6 || n == 7) Console.WriteLine("Yes!");
        else Console.WriteLine("No!");
        F = false;
    }
}