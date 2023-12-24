// Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Write("Введите слово: ");
string inputString = Console.ReadLine();

bool isPalindrome = IsPalindrome(inputString);
if (isPalindrome)
{
    Console.WriteLine("Паллиндром");
}
else
{
    Console.WriteLine("Не является палиндромом");
}

bool IsPalindrome(string str)
{
    string cleanStr = str.Replace(" ", "").ToLower();
    int length = cleanStr.Length;
    int halfLength = length / 2;

    for (int i = 0; i < halfLength; i++)
    {
        if (cleanStr[i] != cleanStr[length - 1 - i])
        {
            return false;
        }
    }
        return true;
}