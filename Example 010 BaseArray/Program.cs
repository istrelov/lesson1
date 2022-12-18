int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;

    return result;
}

int[] array = {1, 2, 4200, 8, 7896, 4, 39, 7, 4};

int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));
    
Console.Write("max = ");
Console.WriteLine(result);