
int GetNumber()
{
    bool correctFlag = false;
    string input;
    int number = default;

    while (correctFlag == false)
    {
        input = Console.ReadLine();
        if (int.TryParse(input, out number))
        {
            correctFlag = true;
        }
        else
        {
            Console.Write("Ай-яй, нехорошо. Введите число - ");
        }
    }
    
    return number;
}

void checkPalindrome(int[] symbols)
{
    bool palindromeFlag = true;
    for (int i = 0; i < symbols.Length; i++)
    {
        if (symbols[i] != symbols[symbols.Length - 1 - i] && i <= symbols.Length - 1 - i)
        {
            palindromeFlag = false;
        }
    }
    switch (palindromeFlag)
    {
        case true:
            Console.WriteLine("Это число - палиндром");
            break;
        case false:
            Console.WriteLine("Это число - НЕ палиндром");
            break;
    }
}



Console.Write("Введите число - ");
int number = GetNumber();

int numberLength = (int)Math.Log10(Math.Abs(number)) + 1;
int[] symbols = new int[numberLength];
for (int i = 0; i < numberLength; i++)
{
    symbols[i] = number % 10;
    number /= 10;
}

checkPalindrome(symbols);