// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumxNumber(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int last_digit = number % 10;
        sum = sum + last_digit;
        number = number / 10;
    }
    return sum;
}

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Parse("Введите число");

int result = SumxNumber(a);

Console.WriteLine(result);