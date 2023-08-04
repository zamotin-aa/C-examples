// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Random rand = new Random();
int number = rand.Next(100, 1000);

int a = number / 100;
//int b = (number % 100)/10;
int c = number % 10;

int result = a*10 + c ;

Console.WriteLine(number);
Console.WriteLine(result);


// Второй вариант:

// int number = Convert.ToInt32(Console.ReadLine());
// int a = number / 100;
// a = a * 10;
// int b = number % 10;
// int result = a + b;
// Console.WriteLine(result);

