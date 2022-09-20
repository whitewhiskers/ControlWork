// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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

Console.Clear();
System.Console.Write("Введите количество слов в массиве: ");
int number = int.Parse(Console.ReadLine());
string[] array = new string[number];
FillArrayByUser(array);
PrintArray(array);
int size = CheckCountShortWords(array);
string[] result = FillArray(array, size);
System.Console.Write("--->");
PrintArray(result);