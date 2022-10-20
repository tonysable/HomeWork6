int[] CreateArray(int size)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            Console.WriteLine("Введите любое число: ");
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
    return array;
}

int CountPos(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}

int[] porno = CreateArray(7);
int sum = CountPos(porno);

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"] -> {sum}");
}

PrintArray(porno);
