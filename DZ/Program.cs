// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void FillArray(double[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(-30, 30) + new Random().NextDouble();
//       }
//    }
// }

// void PrintArray(double[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//          System.Console.Write($"{Math.Round(array[i, j], 2),7}    ");
//       System.Console.WriteLine();
//    }
// }

// Console.Clear();
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, cols];
// FillArray(array);
// PrintArray(array);



// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void FillArrayRandomNumbers(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(-100, 100) / 10;
//       }
//    }
// }

// void PrintArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write($"{array[i, j],3}  ");
//       }
//       Console.WriteLine("");
//    }
// }

// Console.Clear();
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, cols];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//    Console.WriteLine("такого элемента нет");
// }
// else
// {
//    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
// }

// PrintArray(numbers);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(0, 10);
      }
   }
}

void PrintArray(int[,] array)
{

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
}

void AVG(int[,] array)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      double avarage = 0;
      for (int i = 0; i < array.GetLength(0); i++)
      {
         avarage = (avarage + array[i, j]);
      }
      avarage = avarage / array.GetLength(0);
      Console.Write(avarage + "; ");
   }
}




Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
AVG(array);