string [] CreateStringArray (int size)
{
    string [] newArray = new string [size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write ($"Введите {i+1} значение массива");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

