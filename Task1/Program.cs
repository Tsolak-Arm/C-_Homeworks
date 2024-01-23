//Задача 1: Напишите программу,
//которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’
//или при вводе числа, сумма цифр которого чётная.


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена по запросу пользователя.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                int digitSum = CalculateDigitSum(number);
                Console.WriteLine($"Сумма цифр введенного числа: {digitSum}");

                if (digitSum % 2 == 0)
                {
                    Console.WriteLine("Программа завершена, так как сумма цифр чётная.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    static int CalculateDigitSum(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}

    