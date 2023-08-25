//Напишите программу, которая на вход принимает число и 
//выдает его квадрат (число умноженное на само себя).
//Например:
//4 -> 16 

//string input = Console.ReadLine();
//int number = Convert.ToInt32(input);
//вместо этого можно записать в одну строку (см.ниже)

Console.WriteLine("Введите число");
int input = Convert.ToInt32(Console.ReadLine());
int sqr_number = input * input;
Console.WriteLine("Наш результат - " + sqr_number);


