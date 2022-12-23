// Задача 3. Необязательная, дополнительная задача. 
//           Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
//           В каждом столбце найдите среднее арифметическое среди тех элементов, 
//           которые являются палиндромами 
//           (если палиндромов нет, то среднее арифметическое считать равным 0). 
//           Полученные средние арифметические занести в одномерный массив.

// Например, задан массив:

// 100 404 504 225
// 550 478 800 363
// 505 101 410 479

// => [505, 252.5, 0, 363 ]

// 1. Создать метод заполняющий массив трёхзначными целыми числами
// 2. Создать метод выводящий на экран заполненный двухмерный массив
// 3. Создать метод, проверяющий является ли число палиндромом
// 4. Создать метод, который находит сред. арифметическое чисел-палиндромов каждого столбца,
//          если палиндромов нет, то сред. арифметическое столбца  = 0. 
//          Метод будет возвращать одномерный массив, 
//          в который записаны сред. арифметические значения чисел-палиндромов каждого столбца. 
// 5. Создать метода для вывода одномерного массива на экран.
// 6. Задать двухмерный массив размером 9х12.
// 7. Применить методы в пунктах 1, 2. Применить метод в пункте 5, передав ему в виде аргумента метод в пункте 4.

// 1.
void FillArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(100, 1000);
        }
    }
}

// 2.
void PrintArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//3. 
int Palindrome(int num)
{
    string str = Convert.ToString(num);
    int[] digits = str.Select(x => int.Parse(x.ToString())).ToArray();

    int result = digits[digits.Length - 1];

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (result != digits[i]) result = result * 10 + digits[i];
    }
    return result;
}

//4.
double[] AverageColumn(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double count = 0;
        double sum_palindrome = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            if (matr[i, j] == Palindrome(matr[i, j]))
            {
                if (count == 0) sum_palindrome = matr[i, j];
                else sum_palindrome = sum_palindrome + matr[i, j];
                count++;
            }
        }
        if (count == 0) arr[j] = 0;
        else arr[j] = Math.Round(sum_palindrome / count, 2);
    }
    return arr; 
}

// 5.
void PrintArray(double[] arg)
{
    for(int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + "; ");
    }
}

// 6.
int[,] matrix = new int[9, 12];

// 7.
FillArray2(matrix);
PrintArray2(matrix);
PrintArray(AverageColumn(matrix));
