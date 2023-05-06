string[] CreateArray(int length)
{
    string[] array = new string[length];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Enter an array element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

string[] NewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int temp = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[temp] = array[i];
            temp++;
        }
    }
    return newArray;
}


Console.Write("Enter the length of the array: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(length);
Console.WriteLine();
Console.WriteLine("Initial array:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("New array:");
string[] newArray = NewArray(array);
PrintArray(newArray);