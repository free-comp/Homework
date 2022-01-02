// Программа формирует из массива случайных чисел массив из четных чисел и выводит в консоль.

// Алгоритм:
// 1. Инициализируем переменную - размер массива, а также сам массив.
// 2. Заполняем массив случайными целыми числами от -10 до 10.
// 3. Выводим на в консоль.
// 3. Инициализируем новый пустой массив такого же размера, что и первоначальный
// 4. Ищем четные числа в первоначальном массиве, для чего проходимся по всем его элементам
// 5. Найденные четные числа записываем в выходной массив
// 6. Проверяем, если не было найдено четных чисел, то выводим надпись, сообщающую об этом.
// 7. Иначе выводим в консоль содержимое нового массива.


// метод заполнения массива
void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

// метод вывода элементов массива в консоль
void PrintArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// inputArray - исходный массив
// outputArray - конечный массив
// evenCount - счетчик четных элементов
int SearchEven(int[] inputArray, int[] outputArray)
{
    int length = inputArray.Length;
    int evenCount = 0;
    for (int i = 0; i < length; i++)
    {
        if (inputArray[i] % 2 == 0)
        {
            outputArray[evenCount] = inputArray[i]; // в вых.массив кладем четные значения
            evenCount++;
        }
    }
    return evenCount;
}

int SizeArray = 2; // чтобы можно было менять размер только в одном месте
int[] firstArray = new int[SizeArray];

FillArray(firstArray);
Console.WriteLine("Исходный массив: ");
PrintArray(firstArray, firstArray.Length);

int[] resultArray = new int[SizeArray];
int evenCount = SearchEven(firstArray, resultArray);

if (evenCount == 0)
{
    Console.WriteLine("Массив не содержит четных чисел.");
}
else
{
    Console.WriteLine("Четные числа в массиве: ");
    PrintArray(resultArray, evenCount);
}
