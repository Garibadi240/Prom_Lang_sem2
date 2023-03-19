Console.Clear();

Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

int constUserNumber = userNumber;

if (userNumber > 999)
{
    while (userNumber > 999)
    {
        userNumber = userNumber / 10;
        if (userNumber < 999 && userNumber > 99)
        {
            int rem1 = userNumber % 10;
            Console.WriteLine($"{constUserNumber} -> {rem1}");
            break;
        }
    }
}
else
{
    if (userNumber < 1000 && userNumber > 99)
    {
        int rem1 = userNumber % 10;
        Console.WriteLine($"{constUserNumber} -> {rem1}");
    }
    else
    {
        int rem1 = userNumber % 10;
        Console.WriteLine($"{constUserNumber} -> нет третьей цифры.");
    }
}
