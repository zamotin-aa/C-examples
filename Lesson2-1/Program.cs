
//запись массива

// int[] array= {1,4,5,634,23,4,44} ;
// int max = array[1];
// Console.WriteLine(max);


//поиск номера в массиве
int[] array = {1,4,5,634,23,4,44};
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}

