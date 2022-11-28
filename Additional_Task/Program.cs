// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, 
// если из последовательности удалить наибольший элемент.

Console.WriteLine("Enter a sequence of integers (еnter 0 to end input):");
int n = int.Parse(Console.ReadLine());
int max = n;
int sec_max = max;
n = int.Parse(Console.ReadLine());
    if (n > max) {
        sec_max = max;
        max = n;
    }
    else {
        sec_max = n;
    }
while (n != 0) {
    n = int.Parse(Console.ReadLine());
    if (n > max) {
        sec_max = max;
        max = n;
    }
    else if (n > sec_max) {
        sec_max = n;
    }
}
Console.WriteLine($"Second max in the sequence -> {sec_max}");
