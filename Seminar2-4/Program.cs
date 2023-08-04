// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("Введите первое число");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int input2 = Convert.ToInt32(Console.ReadLine());

int a = input1 % input2;

if (a == 0)
{
    Console.WriteLine("Кратно");
}
else if (a != 0)
{
    Console.WriteLine("не кратно, остаток - " + a);
}

// Второй вариант

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 % number2 == 0){
    Console.WriteLine("Кратно");
}
else{
    Console.WriteLine("Не кратно");
    Console.WriteLine($"остаток = {number1 % number2}");
}
















// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да