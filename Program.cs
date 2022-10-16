string[] Input()
{
    Console.WriteLine("Сколько элементов должно быть?");
    int len = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[len];
    for (int i = 0; i < len; i++)
    {
        string str = Console.ReadLine();
        array[i] = str;
    }
    return array;
}

void WriteStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
