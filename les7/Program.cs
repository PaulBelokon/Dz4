/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Ai,j = i+j. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5


0,0 -> 2,0
0,1 -> 2,1
0,2 -> 2,2
0,3 > 2,3




*/








int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);

PrintArray(array);
GetReverse(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArrayFirst(array);
Console.WriteLine();
PrintArrayLast(array);

void PrintArray(int[,] array)
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

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void GetReverse(int[,] array)
{
    int result;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = result;
    }
}

void PrintArrayFirst(int[,] array)
{
    int result;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write(array[0, i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayLast(int[,] array)
{
    int result;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write(array[array.GetLength(0) - 1, i] + " ");
    }
    Console.WriteLine();
}























/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечетные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2 5 92 3 8 42 4
Новый массив будет выглядеть вот так:
1 47 2
58129
8 42 4
*/
/*
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[m,n] GetSqrtNechetnux(int m, int n)
{
for (var i = 0;  i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;

    }




}
}

*/






//Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
//m = 3, n = 4.
/*1 4 8 19
5 -2 33 -2
77 3 8 1*/
/*
try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,100);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }
    
    throw new Exception("Введены не корректные символы");
}









*/














/*using System.Text;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 5;
int b = 2;
double c = (double)a / b;*/

//Console.WriteLine(c);

// про Split
//string str = "123adasdasdasdas2313adasdasdasdas45";
//string[] strs = str.Split("adasdasdasdas");

/*int[] array = new int[strs.Length];
for (var i = 0; i < strs.Length; i++)
{
    array[i] = int.Parse(strs[i]);
}
for (var i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}*/

// про Join
// int[] array = new int[]{1,23,4,56};

// string str = string.Join(",",array);

// Console.WriteLine(str);



//Console.WriteLine(str);

/*int[] array = new int[] { 12313, -123123, -123123234, 234234 };
int[] result = array.Where(number => number % 2 == 0).ToArray();
Print(result);
void Print(int[] arr)
{
    Console.WriteLine(string.Join(",",arr));
}
for (var i = 0; i < array.Length; i++)
{
    int number = array[i];
}*/

/*string[] array = new string[] { "1231l3", "12", "lalal", "234234" };
string[] result = array.Where(str => str.Contains("1") && str.Length > 5).ToArray();
Print(result);
List<string> result2 = new List<string>();
for (var i = 0; i < array.Length; i++)
{
    string str = array[i];
    if (str.Contains("1") && str.Length > 5)
    {
        result2.Add(str);
    }
}
void Print(string[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}*/
