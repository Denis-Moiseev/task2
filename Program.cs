Console.Write("Введите первое число: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondNumber = double.Parse(Console.ReadLine());
double max = firstNumber;
double min = secondNumber;
if (firstNumber < secondNumber)
{
    max = secondNumber; min = firstNumber;
}
Console.Write($"Число {max} больше чем число {min}");