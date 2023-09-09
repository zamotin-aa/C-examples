// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.


int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;

FillArray(array);

foreach (int number in array) //сокращенная версия цикла for
{
    if (number > 0)
    {
        sumPositive = sumPositive + number;
    }
    else
    {
        sumNegative += number;
    }
}

Console.WriteLine($"Сумма положительных - {sumPositive} и сумма отрицательных - {sumNegative}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(String.Join(" ", array));
}



