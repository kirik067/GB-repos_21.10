Console.WriteLine ("Введите трёхзначное число");
int inputConsole = Convert.ToInt32(Console.ReadLine());
int number2 = (inputConsole/ 10) % 10;
Console.WriteLine(number2);