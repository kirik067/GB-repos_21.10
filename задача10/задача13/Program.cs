Console.WriteLine("Видите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
Console.WriteLine($"третья цифра: {num = (num % 10) % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}