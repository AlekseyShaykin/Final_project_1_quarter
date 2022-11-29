// Написать программу, которая из имеющегося массива строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



string[] array = { "YES", "12#4fg", "Man", "Novosibirsk" };

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}


void Method(string[] arr)
{
    Console.Write(" --> [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        int a = new int();
        a = arr[i].Length;
        if (a <= 3) Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}


PrintArray(array);
Method(array);