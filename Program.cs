/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] CreatRandom2dArray()
{
    int rows = new Random().Next(4, 6);
    int columns = new Random().Next(4, 6);
    int minValue = new Random().Next(0, 1);
    int maxValue = new Random().Next(5, 6);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10)
                Console.Write($" {array[i, j]}   ");
            if (array[i, j] > -10 && array[i, j] < 0)
                Console.Write($"{array[i, j]}   ");
            if (array[i, j] >= 10)
                Console.Write($" {array[i, j]}  ");
            if (array[i, j] <= -10)
                Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
/*
void SortToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxposj = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxposj])
                    maxposj = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxposj];
            array[i, maxposj] = temp;
        }
    }
}
SortToMin(myArray);
Show2dArray(myArray);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка
*/
/*
int MinSumElementsRow(int[,] array)
{
    int k = 0;
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            sumRow[i] = sum;
        }
        int min = sumRow[0];
        if (sumRow[i] < min)
        {
            sumRow[i] = min;
            k = i;
        }
    }
    return (k + 1);
}
int a = MinSumElementsRow(myArray);
Console.WriteLine($"{a} is number rows with the smallest sum of elements.");
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
bool TestProduct2Matric(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) == arr2.GetLength(0)) return true;
    else return false;
}

int[,] Product2Matric(int[,] arr1, int[,] arr2)
{
    int[,] arrResult = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for( int k = 0; k < arr2.GetLength(1); k++)
            {
                sum+= arr1[i ,k]* arr2[k, j];
            }
            arrResult[i, j] = sum;
        }
    return arrResult;
}

int[,] myArray2 = CreatRandom2dArray();
Show2dArray(myArray2);

if (TestProduct2Matric(myArray, myArray2) == false)
{
    Console.WriteLine("The product of two matrices is not possible!");
    Console.WriteLine();
}
if (TestProduct2Matric(myArray, myArray2) == true)
{
    int[,] result = Product2Matric(myArray, myArray2);
    Console.WriteLine("The resulting matrix:");
    Show2dArray(result);
}
*/