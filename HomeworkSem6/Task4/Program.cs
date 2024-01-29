// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
//Сформировать строку, в которой слова расположены в обратном порядке.
//В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Input a string with spaces: ");
string input = Console.ReadLine();

    if (input != null)
        {
            string reversedString = ReverseWords(input);
            Console.WriteLine("Результат: " + reversedString);
        }
    else
        {
            Console.WriteLine("Введена пустая строка.");
        }

    string ReverseWords(string input)
    {
        
        string[] words = input.Split(' ');
        string[] reversedWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
            reversedWords[i] = words[words.Length - 1 - i];
            }
        string reversedString = string.Join(" ", reversedWords);

        return reversedString;
    }
