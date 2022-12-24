/*
int m;
int n;
*/
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
while (true)
{
    Console.WriteLine("Введите число m");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число n");
    n = int.Parse(Console.ReadLine());
    if (m == n)
    {
        break;
    }
    Console.WriteLine("Введены неверные данные");
}
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();
int[,] reversearray = ReverseArray(arrayresult);
Print2DArray(reversearray);

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

int[,] ReverseArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[j, i];
        }
    }
    return result;
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


/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/


/*
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число number");
int number = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine($"Число {number} повторяется столько раз :  " + FindElementinArray(arrayresult));
int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 5);
        }
    }
    return array;
}


int FindElementinArray(int[,] array)
{

int index = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (number == array[i,j])
        index++;
        
        
    }
    
}
return index;
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
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число number");
int[,] number1 = new int[x,y] ;

int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine($"Число {number} повторяется столько :  " + FindElementinArray(arrayresult));
int[,] CreateArrayWithRandomNumber(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 5);
        }
    }
    return array;
}

int FindElementinArray(int[,] array)
{

int index = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (number1[x,y] == array[i,j])
        
        
       
    }
    
}
return index;
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
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив: 14 72
59 23
84 24
52 67
Наименьший элемент - 1, на выходе получим следующий массив:
94 2
22 6
34 7
*/

Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
int[,] arrayresult = CreateArrayWithRandomNumber(m, n);
Print2DArray(arrayresult);

Console.WriteLine();
(int row, int column) = GetMinNumber(arrayresult);
Console.WriteLine();
Print2DArray (TradeArrayNumber( arrayresult, row, column));

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


(int row, int column) GetMinNumber(int[,] array)
{
int min = array[0,0];
int row = 0;
int column = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j]<min)
        {
            min = array[i,j];
            row = i;
            column = j;
        }
    }
}
return (row,column);
}




int[,] TradeArrayNumber(int[,] array, int row, int column)
{
    Console.WriteLine(row);
    Console.WriteLine(column);
    int[,] result =  new int[array.GetLength(0)-1,array.GetLength(1)-1];
    int resultI= 0;
    int resultJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (row == i) 
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($" j = {resultJ}i =  {resultI}");
            if (column != j )
            {
              result[resultI,resultJ] = array[i,j];
              resultJ++;
            }
        }
        if (row != i) 
        {
            resultI++;
        }
        resultJ = 0;
    }

return result;
}







