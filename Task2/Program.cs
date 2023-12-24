// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string ConvertFromUpperToLower(string input)
{
    char[] charArray = input.ToCharArray();
    for (int i = 0; i < charArray.Length; i++)
    {
        if (char.IsUpper(charArray[i]))
        {
            charArray[i] = char.ToLower(charArray[i]);
        }
    }
    return new string(charArray);
}

//------------------------

Console.Write("Введите строку латинских букв разных регистров: ");
string inputString = Console.ReadLine();
string resultString = ConvertFromUpperToLower(inputString);
Console.WriteLine("Новая строка со строчными буквами: " + resultString);