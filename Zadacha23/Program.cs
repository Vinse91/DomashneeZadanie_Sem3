// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine())!;
int num = 1;
Console.WriteLine($"Таблица кубов чисел {N}, от 1 до {N}");

while (num < N)
{
    int result = num*num*num;
    Console.WriteLine(result + ",");
    num ++;
}
Console.Write(N*N*N);