//Задача 1: Задайте двумерный массив символов (тип char [,]).
//Создать строку из символов этого массива.

string MatrixToString(char[,] chars)
{
    string str = "";
    int rows = chars.GetLength(0);
    int columns = chars.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                str += chars[i, j];
            }
        }
        return str;
}
char[,] chars = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'}
        };
string result = MatrixToString(chars);
Console.WriteLine($"'{result}'");
