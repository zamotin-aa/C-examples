using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел, которые вы хотите ввести:");
        int m = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                count++;
            }
        }
        Console.WriteLine("Количество чисел, больших 0: " + count);
    }
}
