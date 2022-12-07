// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе/
// 452 -> 11

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int total = 0;
while (number != 0)
{
    total = total + (number % 10);
    number = number/10;
}

Console.WriteLine($"сумма цифр в числе = {total}");
