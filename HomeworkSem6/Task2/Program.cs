// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
//Сформируйте строку, в которой все заглавные буквы заменены на строчные. 
    

    string ConvertToLowerCase(string str)
    {
        char[] chars = str.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            // Проверяем, является ли символ заглавной буквой
            if (chars[i] >= 'A' && chars[i] <= 'Z')
            {
                // Вычитаем разницу между кодами заглавной и строчной буквы,
                // чтобы получить символ в строчном регистре
                chars[i] = (char)(chars[i] - 'A' + 'a');
            }
        }

        return new string(chars);
    }
    string originalString = "AbcD15FplO";
    string lowerCaseString = ConvertToLowerCase(originalString);

        Console.WriteLine($"Исходная строка: {originalString}");
        Console.WriteLine($"Строка с заменой заглавных на строчные: {lowerCaseString}");
