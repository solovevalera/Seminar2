// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number>=100 & number<1000)
{
    int digit2 = (number % 100)/10;
    Console.WriteLine($"Вторая цифра - {digit2}");
}
else
{
    Console.WriteLine("Введите трёхзначное число");
}