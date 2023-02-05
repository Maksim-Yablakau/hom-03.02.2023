// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] num = new int [n, m];
Generate2DArray(num);
Print2DArray(num);

void Generate2DArray(int[,] result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}

for (int j = 0; j < num.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        avarage = (avarage + num[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}

Console.WriteLine();

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}