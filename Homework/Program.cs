void PrintArray(string[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write('"');
        if (i < arr.Length - 1)
        {
            System.Console.Write($"{arr[i]}");
            System.Console.Write('"');
            System.Console.Write(',');
        }
        else
        {
            System.Console.Write($"{arr[i]}");
            System.Console.Write('"');
        }

    }
    System.Console.Write("]");
}
int CheckCountShortWords(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    return count;
}
string[] FillArray(string[] arr, int lenght)
{
    string[] resultArray = new string[lenght];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            resultArray[index] = arr[i];
            index++;
        }
    }
    return resultArray;
}
void FillArrayByUser(string [] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} слово");
        arr[i] = Console.ReadLine();
    }
}

System.Console.WriteLine("Введите количество слов в массиве: ");
int number = int.Parse(Console.ReadLine());
string[] array = new string[number];
FillArrayByUser(array);
Console.Clear();
PrintArray(array);
int size = CheckCountShortWords(array);
string[] result = FillArray(array, size);
System.Console.Write("--->");
PrintArray(result);