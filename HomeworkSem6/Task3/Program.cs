// Задача 3: Задайте произвольную строку.
//Выясните, является ли она палиндромом.

Console.WriteLine("Введите строку для проверки:");
    string input = Console.ReadLine();

bool IsPalindrome(string str)
    {
        str = str.Replace(" ", "").ToLower();
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            if (str[i] != str[j])
            {
                return false;
            }
        }
        return true;
    }

void PrintIsPalindrome(string str)
    {
        if (IsPalindrome(str))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }

    PrintIsPalindrome(input);
    

   
