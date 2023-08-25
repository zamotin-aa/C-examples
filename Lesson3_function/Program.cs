// Пример с методом

// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "fff");
// Console.WriteLine(res);


// Пример с таблицей умножение:

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j} ");
//     }
//     Console.WriteLine("");
// }

// Пример с заменой текста

// При запуске этого метода в C# возникает ошибка. Помогу поправить.

string text = "lllddd";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;

}

string newText = Replace(text, 'd', 'f');

Console.WriteLine(newText);

