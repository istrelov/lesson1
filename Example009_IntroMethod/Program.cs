int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;

    return result;
}

int a1 = 1;
int b1 = 2;
int c1 = 4200;
int a2 = 8;
int b2 = 7896;
int c2 = 4;
int a3 = 39;
int b3 = 7;
int c3 = 4;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
    
Console.Write("max = ");
Console.WriteLine(max);