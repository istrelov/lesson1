void FillArray(int[] collect)
{
    int length = collect.Length;
    int index = 0;

    while(index < length)
    {   
        collect[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int posit = 0;

    while(posit < count)
    {
        Console.WriteLine(collection[posit]);
        posit++;
    }
}

int IndexOf(int[] CollectArray, int find)
{
    int count = CollectArray.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(CollectArray[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 12);
Console.WriteLine(pos);