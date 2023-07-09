Console.Write("Введите первое число: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondNumber = double.Parse(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.Write($"Число {firstNumber} больше чем число {secondNumber}");
}
else
    if (firstNumber == secondNumber)
    {
        Console.Write($"Число {firstNumber} равно числу {secondNumber}");
    }
    else
        Console.Write($"Число {secondNumber} больше чем число {firstNumber}");