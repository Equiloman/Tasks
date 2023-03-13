// Задача №2
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
int a = new Random().Next(0, 1000); 
int b = new Random().Next(0, 1000); 
Console.Write("a=");
Console.Write(a);
if (a > b)
{
    Console.Write(" больше ");
}
else if (a == b)
{
    Console.Write(" равен ");
}
else
{
    Console.Write(" меньше ");
};
Console.Write("b=");
Console.WriteLine(b);