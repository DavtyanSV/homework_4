// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum(int something)
{
    int result = 0;
    for (; something > 0;)
    {
        result = result + (something % 10);
        something = something / 10;
    }

    return result;
}
System.Console.WriteLine("Введите число -> ");
int number = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Сумма числе в веденном числе {number} = {Sum(number)}");


