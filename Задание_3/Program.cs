// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string message)
{
    System.Console.WriteLine($"{message} -> ");
    int something = int.Parse(Console.ReadLine());
    return something;
}

int[] CreateArray(int dlina, int min, int max)  //вводим данные для создания массива
{
    int[] array = new int[dlina];

    for (int i = 0; i < dlina; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

void Print(int[] array)
{
    System.Console.Write("Итоговый массив ");
    for(int i = 0; i<array.Length; i++)
    {
        System.Console.Write(array[i]+", ");
    }
}

int dlina = ReadInt("Введите длину массива");
int min = ReadInt("Введите минимальное число в диапозоне массива");
int max = ReadInt("Введите максимальное число в диапозоне массива");

int[] massive = CreateArray(dlina, min, max);

Print(massive);
