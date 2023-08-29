// Заданы координаты - вывести в какой четверти находимся

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

// создать массив на два элемента
int[] array = new int[2];
array[0] = x;
array[1] = y;

// можно заполнить циклом
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}


if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Есть нулевые координаты");
}
