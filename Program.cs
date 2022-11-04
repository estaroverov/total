// Functions

// Функция печати массива строк
void PrintStringArray(string[] arr)
{
    foreach (string i in arr)
        Console.Write(i + " ");
    Console.WriteLine();
}
// Функция для ввода массиа строк с клавиатуры
string[] InputStringArray(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите элемент массива по индексу " + i + ":");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
// Функция фильтрации массива строк. 
// Выбирает строки длиной не более 3 символов и помещает в новый массив.
string[] FilterArray(string[] arr)
{
    int length = arr.Length;
    int counter = 0;

    foreach (string i in arr)
        if (i.Length <= 3)
            counter++;

    string[] filteredArray = new string[counter];
    counter = 0;

    for (int i = 0; i < length; i++)
        if (arr[i].Length <= 3)
        {
            filteredArray[counter] = arr[i];
            counter++;
        }

    return filteredArray;
}

// Решение задачи
Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
string[] arrString = InputStringArray(length);
Console.Write("Исходный массив: ");
PrintStringArray(arrString);
Console.Write("Отфильтрованный массив: ");
PrintStringArray(FilterArray(arrString));