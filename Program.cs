// Задача 10. Напишите программу, которая принимает на вход трёхзначное число на выходе показывает вторую цифру числа
Console.WriteLine("Введите трёхзначное число ");
int x = int.Parse(Console.ReadLine()!);
int result = 0;
int y = x / 10;
if (y > 10 && y < 100)
{
    result = (x % 100) / 10;
    Console.WriteLine($"Вторая цифра числа {x} -> {result}");
}
else
{
    Console.WriteLine($"Число не трехзначное");
}