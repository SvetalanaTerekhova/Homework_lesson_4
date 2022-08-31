// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1 Вариант, когда задано что массив будет из 8 элементов. Диапазон массива определяется пользователем.

Console.Write("Введите минимальное значение диапазона чисел массива: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение, до которого будет формироваться диапазон чисел массива: ");
int number2 = int.Parse(Console.ReadLine());
while (number1 > number2)
{
    Console.WriteLine("Вы ввели диапазон массива, где минимальное значение больше максимального значения, до которого будет формироваться диапазон чисел массива. Сформировать такой массив не возможно.");
    Console.Write("Введите минимальное значение диапазона чисел массива: ");
    number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите максимальное значение, до которого будет формироваться диапазон чисел массива: ");
    number2 = int.Parse(Console.ReadLine());
}
int[] arrey = new int[8];
int lenght = arrey.Length;

for (int index = 0; index < lenght; index++)
{
    arrey[index] = new Random().Next(number1, number2);
}

for (int position = 0; position < lenght; position++)
{
    Console.Write(arrey[position] + ",");
}

// 2 Вариант, когда пользователь сам определяем размер массива, но максимальное количество элементов массива не будет превышать 8. Диапазон массива определяется пользователем.
/* 
Console.Write("Введите количество элементов массива от 1 до 8: ");
int number1 = int.Parse(Console.ReadLine());
while (number1 > 8 || number1 < 1)
{
    if (number1 > 8)
    {
        Console.Write("Вы ввели количество элементов массива превышающее значение 8. Введите количество элементов массива от 1 до 8: ");
        number1 = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.Write("Вы ввели количество элементов массива, превышающее значение 8. Введите количество элементов массива от 1 до 8: ");
        number1 = int.Parse(Console.ReadLine());
    }
}
Console.Write("Введите минимальное значение диапазона чисел массива: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение, до которого будет формироваться диапазон чисел массива: ");
int number3 = int.Parse(Console.ReadLine());
while (number2 > number3)
{
    Console.WriteLine("Вы ввели диапазон массива, где минимальное значение больше максимального значения, до которого будет формироваться диапазон чисел массива. Сформировать такой массив не возможно.");
    Console.Write("Введите минимальное значение диапазона чисел массива: ");
    number2 = int.Parse(Console.ReadLine());
    Console.Write("Введите максимальное значение, до которого будет формироваться диапазон чисел массива: ");
    number3 = int.Parse(Console.ReadLine());
}
int[] arrey = new int[number1];
int lenght = arrey.Length;
for (int index = 0; index < lenght; index++)
{
    arrey[index] = new Random().Next(number2, number3);
}
for (int position = 0; position < lenght; position++)
{
    Console.Write(arrey[position] + ",");
} */

// 3 Вариант, когда размер массива равен 8. И пользователь сам вводит значение каждого элемента массива

/* int[] arrey = new int[8];
int lenght = arrey.Length;

for (int index = 0; index < lenght; index++)
{
    Console.Write("Введите значение элемента массива под index " + index + " = ");
    arrey[index] = int.Parse(Console.ReadLine());
}
Console.Write("Массив из заданных элементов -> ");
for (int position = 0; position < lenght; position++)
{
    Console.Write(arrey[position] + ",");
} */

// 4 Вариант, когда пользователь сам сам определяем размер массива, но максимальное количество элементов массива не будет превышать 8. А затем вводит значение каждого элемента массива

/* Console.Write("Введите количество элементов массива от 1 до 8: ");
int number1 = int.Parse(Console.ReadLine());
while (number1 > 8 || number1 < 1)
{
    if (number1 > 8)
    {
        Console.Write("Вы ввели количество элементов массива превышающее значение 8. Введите количество элементов массива от 1 до 8: ");
        number1 = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.Write("Вы ввели количество элементов массива, превышающее значение 8. Введите количество элементов массива от 1 до 8: ");
        number1 = int.Parse(Console.ReadLine());
    }
}
int[] arrey = new int[number1];
int lenght = arrey.Length;

for (int index = 0; index < lenght; index++)
{
    Console.Write("Введите значение элемента массива под index " + index + " = ");
    arrey[index] = int.Parse(Console.ReadLine());
}
Console.Write("Массив из заданных элементов -> ");
for (int position = 0; position < lenght; position++)
{
    Console.Write(arrey[position] + ","); 
} */