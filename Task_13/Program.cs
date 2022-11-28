// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// (НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)

// 645 -> 5
// 78 -> третьей цифры нет
// 326791 -> 6

Console.WriteLine("Enter a number: ");
int n, clone_n, count, ex, res;
n = int.Parse(Console.ReadLine());
clone_n = n;
count = 0;
while (clone_n != 0) {
    clone_n = clone_n / 10;
    count++;
}
if (count < 3) Console.WriteLine("No third digit!");
else {
    ex = count - 3;
    while (ex > 0){
        n = n / 10;
        ex--;
    }
    res = n % 10;
    Console.WriteLine($"Third digit -> {res}");
}