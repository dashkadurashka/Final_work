string[] array = { "12345", "1567", "3", "8", "42", "fjhks", "f", "00"};
ShowArray(array, "Исходный массив: ");
SortArray(array);

void SortArray(string[] array)
{
    string[] result_array = new string[array.Length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result_array[j] = array[i];
            j++;
        }
    }
    ShowArray(result_array, "Результат: ");
}

void ShowArray(string[] array, string message = "") 
{
    Console.Write(message);
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
