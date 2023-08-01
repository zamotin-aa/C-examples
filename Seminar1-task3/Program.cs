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
if (input1 > 7 || input1 < 1) 
{
    Console.WriteLine("Такого дня нет");
}

//Вариант 2

//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number== 1){
//     Console.WriteLine("Понедельник");
//}
//else if  (number== 2){
//    Console.WriteLine("Вторник");
//}
//else if  (number== 3){
//     Console.WriteLine("Среда");
//}
//else if  (number== 4){
//     Console.WriteLine("Четверг");
//} 
//else if  (number== 5){
//     Console.WriteLine("Пятница");
//}
//else if  (number== 6){
//     Console.WriteLine("Суббота");
//}
// else if  (number== 7){
//     Console.WriteLine("Воскресенье");
//} 
//else {
//    Console.WriteLine("Введи от 1 до 7");
//}

//Вариант 3
//switch (number) {
//  case 1:
//Console.WriteLine();
// break; 
//
//  case 2:
// Console.WriteLine()
// break;
//
//    default:
//    Console.WriteLine();
//    break;
//}



