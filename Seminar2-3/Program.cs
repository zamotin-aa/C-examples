// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int input2 = Convert.ToInt32(Console.ReadLine());


if (input1*input1 == input2)
{
    Console.WriteLine("Да");
}
else if (input2*input2 == input1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
