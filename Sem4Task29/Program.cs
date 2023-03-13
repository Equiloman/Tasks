// Задача №29
// Напишите программу, которая задаёт массив из 
// N элементов и выводит их на экран. Ввести с клавиатуры 
// длину массива и диапазон значений элементов.
static void Main()
{
    int size = 20;
    int[] array = new int[20];
    Random myRandom = new Random();

    Console.WriteLine("Вывод с помощью for");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(0, 20);
        Console.Write("{0} ", array[i]);
    }

    Console.WriteLine("\n\nВывод с помощью foreach");
    foreach (var elem in array)
    {
        Console.Write("{0} ", elem);
    }
}