string[] array1 = new string[6] {"test1", "342", "dragon", "world", "ini", "test2"};
string[] array2 = new string[array1.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

