//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите номер дня недели");
int input1 = Convert.ToInt32(Console.ReadLine());
if (input1 == 1) 
{
    Console.WriteLine("Понедельник");
}
if (input1 == 2) 
{
    Console.WriteLine("Вторник");
}
if (input1 == 3) 
{
    Console.WriteLine("Среда");
}
if (input1 == 4) 
{
    Console.WriteLine("Четверг");
}
if (input1 == 5) 
{
    Console.WriteLine("Пятница");
}
if (input1 == 6) 
{
    Console.WriteLine("Суббота");
}
if (input1 == 7) 
{
    Console.WriteLine("Воскресенье");
}
if (input1 > 7) 
{
    Console.WriteLine("Такого дня нет");
}






