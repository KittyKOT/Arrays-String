// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReverseWords(string input)
{
    string[] words = input.Split(' ');
    Array.Reverse(words);
    string reversedString = string.Join(" ", words);
    return reversedString;
}

//----------------------------
Console.Write("Введите несколько слов через пробел: ");
string inputString = Console.ReadLine();
string reversedString = ReverseWords(inputString);
Console.WriteLine("Обратный порядк слов: " + reversedString);