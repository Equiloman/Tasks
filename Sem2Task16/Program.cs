// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого. 
void squareTest(int fistNum, int secondNum)
{
    if (fistNum == Math.Pow(secondNum, 2))
    {
        Console.WriteLine($"Число {fistNum} является квадратом {secondNum}");
    }
    else
    {
        Console.WriteLine($"Число {fistNum} не является квадратом {secondNum}");
    }
}

Console.WriteLine("Введите первое число: ");
int fistNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

squareTest(fistNumer,secondNumer);

squareTest(secondNumer,fistNumer);