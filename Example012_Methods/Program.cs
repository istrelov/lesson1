//Вид 1 - ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("имя автора");
}


//Вид 2 - ничего не возвращает, что то принимает
void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
    int i = 0;

    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//вид3 - что то возвращает, ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}

//вид 4 - что то принимает и что то возвращает
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }

    return result;
}

void Tabl()
{
    for (int i = 2; i <= 10; i++)
    {
        Console.WriteLine(i);
        for (int j = 1; j <= 10; j++)
        {
            int res = i * j;
            Console.WriteLine($"{i} * {j} = {res}");
        }
    }
}

// Работа с текстом
//Дан текст, в тексте нужно все пробелы заменить черточками
//мательние буквы "к" заменить большими "К"
//а больние С заменить на мательние "С"

string Replace(string text, char OldValue, char newValue)
{
    string res = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {   
        if (text[i] == OldValue) res = res + $"{newValue}";
        else res = res + $"{text[i]}";
        
    }

    return res;
}

/*string text = "- Я думаю, - сказал князь, улыбаясь, что, "
            + "ежели бы Вас прислали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля,"
            + "Вы так красноречивы. Вы дадите мне чаю?";


string newText = Replace(text, ' ', '_');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');

Console.WriteLine(newText);
*/

void PrintArray(int[] array)
{
    int count = array.Length - 1;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }

     Console.Write($"{array[count-1]}");
     Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[minPosition]) minPosition = j;
        }

        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
SelectionSort(arr);
PrintArray(arr);

