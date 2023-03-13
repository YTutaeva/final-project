// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами

Console.Clear();

void PrintArray(string[] StringArray)
{
    for (int i = 0; i < StringArray.Length; i++)
    {
        Console.WriteLine(StringArray[i]);
    }
}

string[] HandGenerate()
{
    Console.WriteLine("Please enter the array size: ");
    string[] StringArray = new string[int.Parse(Console.ReadLine())];
    for (int i = 0; i < StringArray.Length; i++) 
    {
        Console.WriteLine(@"Enter element № {0}",i+1);
        StringArray[i] = Console.ReadLine();
    }
    Console.WriteLine();
    Console.WriteLine("HERE IS YOUR ARRAY: ");
    Console.Write(String.Join(", ", StringArray));
    return StringArray;
    
}

void RecreateArray(string [] StringArray)
{
    int TotalCount = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= 3)
            TotalCount++;
    }
    string[] NewArray = new string[TotalCount];
    int j = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= 3)
            {
            NewArray[j] = StringArray[i];
            j++; 
            }
    }
    Console.WriteLine();
    Console.WriteLine("--------------");
    Console.WriteLine("NEW ARRAY");
    Console.Write(String.Join(", ", NewArray));
}

RecreateArray(HandGenerate());
Console.ReadKey();