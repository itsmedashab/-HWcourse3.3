// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a, b;
Console.Write($"Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);

int dgr = 1;
for (int i = 1; i <= b; i++)
{
    dgr *= a;
}
Console.Write($"Число А в степени В = {dgr}\n");