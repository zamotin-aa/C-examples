void FillArray(int[] collection) //метод сгенерировать массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

//void ключевое слово показывает что метод ничего не возвращает

void PrintArray(int[] col) //метод вывести на печать массив
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //метод, найти индекс по заданному значению массива
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; 
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
//создай массив на 10 элементов, по умолчанию запишутся 0000

//вызвали методы заполнения и печати
FillArray(array); //заполнили массив
PrintArray(array); //вывели на печать

Console.WriteLine("");

int pos = IndexOf(array, 4); //вызвали метод находжения позиции

Console.WriteLine(pos);