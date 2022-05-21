// Additional Task.
// Write a programm which get the text string and return 'true', if this string contains
// two equal standing nearby letters

Console.Write("Enter some text: ");
string st = Console.ReadLine();
Console.Write("Shold we use case sensitive (Y/N): "); // if 'Y' then 'a' != 'A', if 'N' then 'a' == 'A'
char choose = Convert.ToChar(Console.ReadLine().ToUpper());

bool checkString(string s, char useCase)
{
    bool flag = false;

    if (useCase == 'Y')
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            //cheking that standind nearby symbols are equal and they are letters (not numbers and not symbols)
            if (s[i] == s[i + 1] && Char.IsLetter(s[i]))
            {
                flag = true;
                break;
            }
        }
    }
    else
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            //cheking that standind nearby symbols are equal (without case sensitive) and they are letters (not numbers and not symbols)
            if (Char.ToUpper(s[i]) == Char.ToUpper(s[i + 1]) && Char.IsLetter(s[i]))
            {
                flag = true;
                break;
            }
        }
    }

    return flag;
}

Console.WriteLine(checkString(st, choose));