#region Task 1

using System.Text;

int[] array = { 1, 4, 7, 5, -5, -2, 15, -59, 9 };

MakePositive(ref array);
PrintArray(array);

void MakePositive(ref int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] < 0 ? -array[i] : array[i];
    }
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.WriteLine(i);
    }
}

#endregion

#region Task 2

Repeat("Ha!", 2);

void Repeat(string word, int count=1)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < count; i++)
    {
        sb.Append(word);
    }
    Console.WriteLine(sb.ToString());
}

#endregion

#region Task 3

Console.WriteLine(IsPalindrome("racecar"));

bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

#endregion

#region Task 4

string word = "Salam";
Console.WriteLine(DeleteRepeatedChars(word));

string DeleteRepeatedChars(string word)
{
    char[] chars = new char[0];
    StringBuilder sb = new StringBuilder();
    foreach (char c in word)
    {
        if (!Contains(c, chars))
        {
            sb.Append(c);
        }
        AddToArray(c, ref chars);
    }
    return sb.ToString();
}

void AddToArray(char c, ref char[] chars)
{
    Array.Resize(ref chars, chars.Length + 1);
    chars[chars.Length - 1] = c;
}

bool Contains(char c, char[] chars)
{
    foreach(char symbol in chars)
    {
        if (symbol == c)
        {
            return true;
        }
    }
    return false;
}

#endregion

#region Task 5

string input = "Bonjour";
Console.WriteLine(ReverseString(input));
string ReverseString(string word)
{
    StringBuilder sb = new StringBuilder();
    for (int i = word.Length - 1; i >= 0; i--)
    {
        sb.Append(word[i]);
    }
    return sb.ToString();
}

#endregion

#region Task 6

string sentence = "Lorem ipsum dolor sit amet";

foreach (string item in DivideSentenceToWords(sentence))
{
    Console.WriteLine(item);
}


string[] DivideSentenceToWords(string sentence)
{
    string[] words = new string[0];
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < sentence.Length; i++)
    {
        if (sentence[i] != ' ')
        {
            sb.Append(sentence[i]);
        }
        else
        {
            AddToArrayString(sb.ToString(), ref words);
            sb = new StringBuilder();
        }
    }
    return words;
}
void AddToArrayString(string word, ref string[] words)
{
    Array.Resize(ref words, words.Length + 1);
    words[words.Length - 1] = word;
}



#endregion

#region Task 7

int[] numbers = { 4, 2, -5, 3, 7, 10, 8, 95, 1, 7 };

BubbleSort(ref numbers);

PrintArray(numbers);
void BubbleSort(ref int[] numbers)
{
    bool isChanged = true;
    while (isChanged)
    {
        isChanged = false;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                int temp = numbers[i];
                numbers[i] = numbers[i+1];
                numbers[i+1] = temp;
                isChanged = true;
            }
        }
    }
}
#endregion

#region Task 8

PrintFourLetters("lorem");

void PrintFourLetters(string word, int limit=4)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < limit; i++)
    {
        sb.Append(word[i]);
    }
    Console.WriteLine(sb.ToString());
}

#endregion