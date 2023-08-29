// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите координаты");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Возможные координаты x");

if (x > 0)
{
    for (int i = 0; i <= x; i++)
        Console.Write(i + " ");
}
else
{
    for (int i = 0; i >= x; i--)
        Console.Write(i + " ");
}

Console.WriteLine("\n" + "Возможные координаты y");

if (y > 0)
{
    for (int i = 0; i <= y; i++)
        Console.Write(i + " ");
}
else
{
    for (int i = 0; i >= y; i--)
        Console.Write(i + " ");
}


// Второй вариант

// Console.WriteLine("Введите четветь (от 1 до 4): ");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num == 1) 
// {
//     Console.WriteLine($"Диапазон X от {1} до {int.MaxValue} ");
//     Console.WriteLine($"Диапазон Y от {1} до {int.MaxValue} ");

// }
// else if (num == 2) 
// {
//     Console.WriteLine($"Диапазон X от {- 1} до {int.MinValue} ");
//     Console.WriteLine($"Диапазон Y от {1} до {int.MaxValue} ");

// }
// else if (num == 3) 
// {
//     Console.WriteLine($"Диапазон X от {- 1} до {int.MinValue} ");
//     Console.WriteLine($"Диапазон Y от {- 1} до {int.MinValue} ");

// }
// else if (num == 4) 
// {
//     Console.WriteLine($"Диапазон X от {1} до {int.MaxValue} ");
//     Console.WriteLine($"Диапазон Y от {- 1} до {int.MinValue} ");

// }