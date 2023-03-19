Console.Clear();

Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите цифру соответствующую дню недели: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

if (userNumber == 6 || userNumber == 7)
{
    Console.WriteLine($"Данный день выходной");
}
else
{
    Console.WriteLine($"Данный день не выходной");
}

