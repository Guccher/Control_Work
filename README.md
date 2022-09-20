# Control_Work
## Объявление переменной "Size"
переменная "Size", является размером массива "EnteredArray" и 
вводится с клавиатуры:

    int Size = int.Parse(Console.ReadLine()!);

## Объявление переменной "MaximalTokens"
к переменной "MaximalTokens", я присовил значение 3, для того чтобы задать границы элементов для второго массива "FilteredArray":
    
        int MaximalTokens = 3;

## Объявление первого массива 
для массива под названием "EnteredArray", я задал тип данных string и присвоил размер "Size":

    string[] EnteredArray = new string[Size];

## Цикл вывода элементов первого массива по индексам, ввод первого массива с клавиатуры и вывод надписи "Output entered array " :
в цикле for я вывел счётчик индексов "i" с горизонтальной  табуляцией, затем я конвертировал массив "EnteredArray" в строку и ввёл его с клавиатуры, а также за циклом вывел первый массив:

    for (int i = 0; i < EnteredArray.Length; i++)
    {
        Console.Write($"Enter an array element under the index {i}:\t");
        EnteredArray[i] = Convert.ToString(Console.ReadLine()!);
    }
    Console.WriteLine("\nOutput entered array: ");

## Цикл полного вывода первого массива
в цикле for я вывел массив через String.Join, с помощью которого сцепил все элементы массива строк и поместил между ними заданный разделитель "[]" : 

    for (int i = 0; i < EnteredArray.Length; i++)
    {
        Console.Write($"[{String.Join(", ", EnteredArray[i])}]");
    }

## Вывод и ввод с новой строки

    Console.WriteLine();
    Console.ReadLine();

## Объявление второго массива
Второму массиву под названием "FilteredArray", я задал строчный тип данных, а также за размер, взял длину первого массива:

    string[] FilteredArray = new string[EnteredArray.Length];

## Создание метода для заполнения второго массива
сначала я заполнил метод параметрами:

    void SecondArray(string[] EnteredArray, string[] FilteredArray, int Size)
    {

затем объявляю счётчик индексов для второго массива:

    int count = 0;
после создаю цикл, где проверяется условие, что если длина первого массива меньше или равна 3, то во второй массив записываются элементы первого массива подошедшие под данное условие, затем производится итерация счётчика второго массива:

    for (int i = 0; i < EnteredArray.Length; i++)
      {
          if (EnteredArray[i].Length <= MaximalTokens)
          {
            FilteredArray[count] = EnteredArray[i];
            count++;
          }
      }
    }

## Создание метода для вывода второго массива 
параметры метода:

    void OutputArray(string[] FilteredArray)
    {
    
затем делаю вывод надписи "Output filtered array" :

        Console.WriteLine("Output filtered array: ");
    
после создаю цикл, для вывода второго массива, через String.Join :

        for (int i = 0; i < FilteredArray.Length; i++)
        {
                Console.Write($"[{String.Join(", ", FilteredArray[i])}]");
        }

и делаю вывод с новой строки :

        Console.WriteLine();
    }

и под конец вызов методов :

    SecondArray(EnteredArray, FilteredArray, Size);
    OutputArray(FilteredArray);









    
