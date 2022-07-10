void FillArray(int [] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection [index] = new Random ().Next(1,10);
        index++;
    }
}

void PrintArray (int[]Col)
{
    int count = Col.Length;
    int position =0;
    while(position<count)
    {
        Console.WriteLine (Col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count=collection.Length;
    int index = 0; 
    int position=-1;
    while (index<count)
    {
        if (collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];
FillArray (array);
//можно добавить прунудительное заполнение конкретными цифрами определенные позиции в array
array[4]=4;
array[8]=4;
PrintArray (array);

Console.WriteLine();
int pos = IndexOf(array, 4444);
Console.WriteLine(pos);