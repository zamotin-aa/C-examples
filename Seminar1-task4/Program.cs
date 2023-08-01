// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите целое число");
int input1 = Convert.ToInt32(Console.ReadLine());
if (input1 > 0)
{
int input2 = - input1;
while (input2 <= input1)
{
    Console.WriteLine(input2);
    input2 ++ ;
}}

// input = -3 
else
{
int input3 = - input1;
while (input3 >= input1) // -3 >= 3 
{
    Console.WriteLine(input1); // -3 
    input1 ++ ;
}}

