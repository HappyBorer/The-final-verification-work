﻿Console.Clear();

// Methods.
int Input(string invite)
{
    Console.Write(invite);
    return int.Parse(Console.ReadLine());
}
string[] FillingArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку в массив: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
// My code.
int length = Input("Введите размер массива: ");
string[] arrayOfLines = new string[length];

arrayOfLines = FillingArray(arrayOfLines);

