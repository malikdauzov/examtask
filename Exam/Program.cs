
Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

// Проверка
if(sizeArr <= 0)
{
    Console.WriteLine("Попробуйте еще раз!");
    return;
}

// Создаем массивы
string[] array = new string[sizeArr];
string[] newArr = new string[array.Length];

// Заполняем массив
void FillArray(string[] arr)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Элемент № [{i + 1}] = ", i);
        arr[i] = (Console.ReadLine()!);
    }
}

// Вывод массива
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

// Создание нового массива с выполнением условия
void EndArray(string[] arr1, string[] arr2)
{
    int index = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[index] = arr1[i];
            index++;
        }
    }
}

FillArray(array);
Console.Write("Первичный массив -> ");
PrintArray(array);
Console.WriteLine();
EndArray(array, newArr);
Console.Write("Конечный массив -> ");
PrintArray(newArr);