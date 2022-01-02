﻿// Программа формирует из массива случайных чисел массив из четных чисел и выводит в консоль.

// Алгоритм:
// 1. Инициализируем переменную - размер массива, сам массив, ставим счетчик на 0 элемент
// 2. Заполняем массив случайными целыми числами от -10 до 10, выводим на экран
// 3. Инициализируем новый пустой массив такого же размера, что и первоначальный
// 4. Ищем четные числа в первоначальном массиве, для чего проходимся по всем его элементам
// 5. Найденные четные числа записываем в новый пустой массив
// 6. Проверяем, если в новый массив остался пустым, то выводим надпись, что в первонач.
//    массиве не было четных чисел
// 7. Иначе выводим содержимое нового массива.


int SizeArray = 10; // чтобы можно было менять размер только в одном месте

int[] Array = new int[SizeArray];
int index = 0;
Console.WriteLine("Дан массив случайных целых чисел: ");
while (index < SizeArray)
{
    Array[index] = new Random().Next(-10, 11); // заполняем
    Console.Write($"{Array[index]} "); // выводим в консоль
    index++;
}
Console.WriteLine();

int[] ResultArray = new int[SizeArray];
int position = 0;

for (int i = 0; i < SizeArray; i++)
{
    if (Array[i] % 2 == 0)
    {
        ResultArray[position] = Array[i]; // в нов.массив кладем только четные значения
        position++;
    }
}

if (position == 0) // если позиция осталась на нул.месте, то в нов.массив ничего не положили
{
    Console.WriteLine("Массив не содержит четных чисел.");
}
else
{
    Console.WriteLine("Четные числа в массиве: ");
    for (int i = 0; i < position; i++)
    {
        Console.Write($"{ResultArray[i]} ");
    }
    Console.WriteLine();
}
