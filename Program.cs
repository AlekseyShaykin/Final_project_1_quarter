// Написать программу, которая из имеюgщегося массива строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



string[] array = { "YES", "12#4fg", "Man", "2", "Hello", "Red", "Oop" };

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}


string[] Method(string[] arr)
{
    Console.Write(" -->");
    int size = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        int word = arr[j].Length;
        if (word <= 3) size++;
    }

    string[] array = new string[size];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int word = arr[i].Length;
        if (word <= 3) array[index++] = arr[i];
    }
    return array;
}



PrintArray(array);
string[] array1 = Method(array);
PrintArray(array1);

