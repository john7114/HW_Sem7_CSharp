// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
//           Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

/* m = 3, n = 4.
   0.5 7.96 -2.78 -0.2
   1.7 -3.3 8.574 -9.9
   8.5 7.87 -7.1 9.15*/

// 1. Задать двумерный массив 
// 2. Написать цикл заполнящий двумерный массив вещественными числами
// 3. Вывести двумерный массив на экран.


int m = 5;
int n = 4;
double[,] twoDimensionalArray = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Random rnd = new Random();
        twoDimensionalArray[i, j] = Convert.ToDouble(rnd.Next(-1000, 1000) / 100.0); 
    }
}

for(int i=0; i < m; i++)
{
    for( int j = 0; j<n; j++)
    {
        Console.Write(" " + twoDimensionalArray[i, j]);
    }
    Console.WriteLine();
}
