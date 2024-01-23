//Задача 2: Задайте массив заполненный
//случайными трёхзначными числами.
//Напишите программу, которая покажет
//количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int[] array = new int[10];
        Random rnd = new Random();
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000);
            Console.WriteLine($"Трехзначное число: {array[i]}");
            foreach (int e in array)
        {
            if (e % 2 == 0)
            {
                counter++;
            }
        }
            Console.WriteLine($"Количество четных чисел: {counter}");
        }
    }
}       

   
        