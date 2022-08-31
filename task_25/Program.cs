// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите натуральную степень B, в которую будет возведено число А: ");
int b = int.Parse(Console.ReadLine());
int resul = a;
while (b < 0)
{
    Console.Write("Вы ввели число B которое не является натуральным числом. Введите натуральную степень B, в которую будет возведено число А: ");
    b = int.Parse(Console.ReadLine());
}

for (int i = 0; i < b - 1; i++)
{
    resul = resul * a;
}

Console.Write("Ответ: число А в натуральной степени B -> " + resul);