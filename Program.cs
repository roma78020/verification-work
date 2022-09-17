string [] CreateStringArray (int size)
{
    string [] newArray = new string [size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write ($"Введите {i+1} значение массива: ");
        newArray[i] = Console.ReadLine();        
    }
    return newArray;
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32 (Console.ReadLine());

string [] array = CreateStringArray(size);
Console.WriteLine("Введенный массив: "); 
ShowArray(array);


void ReducingArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 1)
        Console.Write("[null] ");
        if (array[i].Length <= 3)
        Console.Write(array[i] + " ");
    }  
}

Console.WriteLine("Значения массива длина которых < или = 3 :");
ReducingArray(array);