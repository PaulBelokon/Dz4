
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();
FindElementArray(arrayresult);

int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 50);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/


/*


Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
       
        for (var j = 0; j < array.GetLength(1); j++)
        {

         array[i,j] = random.Next(-10,50);

        }
    }
   
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }


        Console.WriteLine("Введите число a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число b");
        int b= int.Parse(Console.ReadLine());
       
        

         if (a < m  && b < n )
          {
           int c = array[a,b];
            Console.WriteLine(c);
          }
          else
          {
          Console.WriteLine("Такого числа нет");
          }
        

*/











/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2     00 + 10 + 20 /
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();

Console.WriteLine();


for (int j = 0; j < arrayresult.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arrayresult.GetLength(0); i++)
    {
        sum = (sum + arrayresult[i, j]);
    }
    sum = sum / m;
    Console.Write(sum + "; ");
}
Console.WriteLine();





int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 50);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}




