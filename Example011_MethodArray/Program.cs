int[] array = {1, 12, 35, 4, 56, 69, 22, -55, 35};

int n = array.Length;
int find = 35;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
