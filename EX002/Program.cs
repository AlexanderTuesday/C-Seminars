Console.Write("Введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA == numB * numB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}