Console.Clear();

Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Введите трехзначное число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");


int rem10 = userNumber /10;
int rem1 = rem10 % 10;


if (userNumber>99 && userNumber <1000)
{
    Console.WriteLine(rem1);
} else
{
    Console.WriteLine("Ошибка! Неверное число.");
}

