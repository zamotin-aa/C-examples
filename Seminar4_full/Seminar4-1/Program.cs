
// Задача 24: Напишите программу, которая принимает на 
// вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 0; i <= number; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Parse("Введите число");

int Sumx(int number)
{
    if (number == 0)
    {
        return 1;
    }

    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;
}

Console.WriteLine(Sumx(number));





