//Задача 3: Напишите программу,
//которая перевернёт одномерный массив
//(первый элемент станет последним, второй – предпоследним и т.д.)
//Пример: [1 3 5 6 7 8] => [8 7 6 5 3 1]
class Program
{
    static void Main()
    {
        int[] array = { 10, 23, 65, 76, 197, 1008 };
        Console.WriteLine("Исходный массив: ");
        PrintArray(array);
        ReverseArray(array);

        Console.WriteLine("Перевернутый массив: ");
        PrintArray(array);
    }

    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        int temp;

        for (int i = 0; i < length / 2; i++)
        {
            temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int e in array)
        {
            Console.Write(e + " ");
        }
        Console.WriteLine();
    }
}