//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите первое число");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int input2 = Convert.ToInt32(Console.ReadLine());

if (input1 == input2 * input2) 
{
Console.WriteLine("Правильно");
}
else
{
Console.WriteLine("Правильно");
}


