/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();
ReverseRowinArray(arrayresult);
Print2DArray(arrayresult);
int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 20);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ReverseRowinArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            if (array[i,k]<array[i,k+1])
            {
                int res = array[i,k+1];
                array[i,k+1] = array[i,k];
                array[i,k] =res;
            }
        }
    }
}
}
/*
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();
GetMinRowinArray(arrayresult);

int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 20);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetMinRowinArray(int[,] array)
{
     int result = 0;
   int min = 100;
    int sum = 0;
    int index = 0;
    int f =0;
for (int i = 0; i < arrayresult.GetLength(0); i++)
{
    for (int j = 0; j < arrayresult.GetLength(1); j++)
    {
        sum= (sum + arrayresult[i,j]);
        result = sum;
        
       
 
    }
    index++;
         if (min>result)
    {
        min = result;
         f = index;
    }
    Console.WriteLine($"{sum}  это сумма  {i+1} строки ");
    sum = 0;

}

Console.WriteLine($"номер строки {f} ее сумма {min}");

}

*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
int[,] arrayresult1 = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);
Console.WriteLine();
Print2DArray(arrayresult1);
Console.WriteLine();
Console.WriteLine("Перемножение матриц");
Print2DArray(GetSqMatrixMatrix(arrayresult, arrayresult1));
int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 5);
        }
    }
    return (array);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetSqMatrixMatrix(int[,] arrayresult, int[,] arrayresult1)
{
    int[,] newarray = new int[m, n];

    for (int i = 0; i < arrayresult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayresult1.GetLength(1); j++)
        {
            for (int k = 0; k < arrayresult1.GetLength(0); ++k)
            {
                newarray[i,j] += arrayresult[i, k] * arrayresult1[k, j];
            }
        }
    }
    return newarray;
}
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число d");
int d = int.Parse(Console.ReadLine());
int[,,] arrayresult = CreateArrayWithRandomNumber(m, n, d);
Print2DArray(arrayresult);

void CreateArrayWithRandomNumber(int m, int n, int d)
{
    Random random = new Random();
    int[,,] array = new int[m, n, d];
    int number;
    for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(100);
                y = x[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (x[i] == x[j])
                        {
                            x[i] = random.Next(100);
                            j = 0;
                            y = x[i];
                        }
 
                        y = x[i];
                    }
                }
                Console.WriteLine(x[i]);
            }
}

/*
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
}

*/






void Print2DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            
        }
        Console.WriteLine();
    }
}












/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
