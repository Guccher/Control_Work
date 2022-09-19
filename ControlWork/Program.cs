// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



Console.Write("Enter Size: ");
int Size = int.Parse(Console.ReadLine()!);
int MaximalTokens = 3;
string[] EnteredArray = new string[Size];
for (int i = 0; i < EnteredArray.Length; i++)
{
    Console.Write($"Enter an array element under the index {i}:\t");
    EnteredArray[i] = Convert.ToString(Console.ReadLine()!);
}
Console.WriteLine("\nOutput entered array: ");
for (int i = 0; i < EnteredArray.Length; i++)
{
    Console.Write($"[{String.Join(", ", EnteredArray[i])}]");
}
Console.WriteLine();
Console.ReadLine();
string[] FilteredArray = new string[EnteredArray.Length];
void SecondArray(string[] EnteredArray, string[] FilteredArray, int Size)
{
    int count = 0;
    for (int i = 0; i < EnteredArray.Length; i++)
    {
        if (EnteredArray[i].Length <= MaximalTokens)
        {
            FilteredArray[count] = EnteredArray[i];
            count++;
        }
    }
}
void OutputArray(string[] array)
{
    Console.WriteLine("Output filtered array: ");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"[{String.Join(", ", array[i])}]");
    }
    Console.WriteLine();
}
SecondArray(EnteredArray, FilteredArray, Size);
OutputArray(FilteredArray);



