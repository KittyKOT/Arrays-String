// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

void Print2DArray<T>(T[,] matrix)
{
    Console.WriteLine($"Исходный массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

string GetStringFromCharArray(char[,] array)
{
    string str = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str += array[i, j];
        }
    }
    Console.WriteLine();
    return str;
}

char[,] charArray = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
Print2DArray(charArray);
string result = GetStringFromCharArray(charArray);
Console.WriteLine($"Результат: {result}");