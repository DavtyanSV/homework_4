// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите первое число");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int degree = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= degree; i++)
{
    result *= number;
}

System.Console.WriteLine($"Итоговое число = {result}");