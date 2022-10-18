string[] Input()
{
    Console.WriteLine("Сколько элементов должно быть?");
    int len = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[len];
    for (int i = 0; i < len; i++)
    {
        string line = Console.ReadLine();
        array[i] = line;
    }
    return array;
}

void WriteStringArray(string[] array)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] SortArrayLessThree(string[] array)
{
    string[] reservArray = new string[array.Length];
    int len = array.Length;
    for (int i = 0; i < reservArray.Length; i++)
    {
        if (array[i].Length < 4)
        {
            reservArray[i] = array[i];
        }
        else
        {
            reservArray[i] = "no info";
            len--;
        }
    }
    
    string[] sortArray = new string[len];
    int sortId = 0;
    for (int i = 0; i < reservArray.Length; i++)
    {
        if (reservArray[i] != "no info")
        {
            sortArray[sortId] = reservArray[i];
            sortId++;
        }
    }
    return sortArray;
}

string[] array = Input();
string[] sortArray = SortArrayLessThree(array);
WriteStringArray(array);
WriteStringArray(sortArray);

