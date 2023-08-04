// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите первое число");
int input1 = Convert.ToInt32(Console.ReadLine());

if (input1 % 7 == 0 && input1 % 23 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("Нет");
}