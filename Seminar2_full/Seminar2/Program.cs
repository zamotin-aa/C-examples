// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
//Классы, экземпляры классов - почитать.
//Использовать для генерации сл.чисел Random

Random rand = new Random();
int number = rand.Next(10, 100);

int a = number / 10;
int b = number % 10;

Console.WriteLine(number);

if (a > b)
{
    Console.WriteLine("Максимальное число a = " + a);
}
else if (b > a)
{
    Console.WriteLine("Максимальное число b = {0}", b);
}
else {
    Console.WriteLine($"Все числы равны {a} = {b}");
}