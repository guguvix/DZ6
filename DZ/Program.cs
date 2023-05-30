// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void Massiv(int[] Array)
// {
//    Console.WriteLine($"Заполните массив случайными числами ");
//    for (int i = 0; i < Array.Length; i++)
//    {
//       Console.WriteLine($"Введите {i + 1} число");
//       Array[i] = Convert.ToInt32(Console.ReadLine());
//    }

// }

// int Kollich(int[] Array)
// {
//    int i = 0;
//    int sum = 0;
//    while (i < Array.Length)
//    {
//       if (Array[i] > 0)
//          sum = sum + 1;
//       i = i + 1;
//    }
//    return sum;
// }



// Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[m];
// Massiv(Array);
// Console.Write($"Чисел больше нуля: {Kollich(Array)}");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");