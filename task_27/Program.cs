// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
int num1 = Math.Abs(number);
int num2 = Math.Abs(number);
int sum = num2 % 10;
while (num1 > 0)
{
    count++;
    num1 = num1 / 10;
}
while (count > 0)
{
    num2 = num2 / 10;
    int LastNumber = num2 % 10;
    sum = sum + LastNumber;
    count--;
}
Console.Write("Ответ: суммой цифр числа " + number + " является " +  sum);