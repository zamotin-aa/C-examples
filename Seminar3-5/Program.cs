


void IsPalindrome(int number)
{

    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Число не пятизначное");
        Console.WriteLine("False");
    }
    else
    {
        int count = 0;
        int result = 0;
        int original_number = number;

        while (number != 0)
        {
            int last_digit = number % 10;
            number = number / 10;
            count += 1;
            result = result * 10 + last_digit;
        }

        if (result == original_number)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

Console.WriteLine("Введите number");
int number = Convert.ToInt32(Console.ReadLine());
IsPalindrome(number);


void string IsBig(int number)
{
    if (number < 10000 || number > 99999)
    {
        string a = "Число не пятизначное" + '\n';
        return a;
    }
}