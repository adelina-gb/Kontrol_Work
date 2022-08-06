
void KontrolWork()
{
    Console.WriteLine("Дан массив:");
    string[] array = { "hello", "2", "world", ":-)", "4568", "yes" };
    PrintArray(array);

    string[] newArray = new string[array.Length];
    Console.WriteLine("Массив, где длина элементов меньше или равна 3:");
    FillNewArray(array, newArray);
    PrintArray(newArray);
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void FillNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

KontrolWork();