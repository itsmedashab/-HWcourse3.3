// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int a;

Console.Write($"Введите число: ");
string user = Console.ReadLine()!;
int.TryParse(user, out a);
user = a.ToString();

int[] array = new int[user.Length];
int sum = 0;
for (int i = 0; i < user.Length; i++)
{
    array[i] = int.Parse(user[i].ToString());
    sum += array[i];
}

Console.Write($"Сумма цифр в числе = {sum}\n");