Console.Write("Введите число: ");

string userInputStr = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInputStr);

int result = userNumber * userNumber;
Console.WriteLine($"{userNumber} -> {result}");