
using System.Reflection.Emit;
using System.Data;
using Internal;
using System;
/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
3 -> 11
2 -> 10

Задача 44: Не используя рекурсию, выведите первые
N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
1.
Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
поэлементного копирования.
*/




/*
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
 
GetFalseorTrue( number1, number2, number3);

Console.WriteLine(GetFalseorTrue( number1, number2, number3));

bool GetFalseorTrue(int a, int b, int c)
{
  if ( a < (b+c) & b < (a+c) & c < (b+a) )
  {
    return true;
  }
   return false;

string number = Convert.toString();
}
*/




/*
int number = int.Parse(Console.ReadLine());


Console.WriteLine(Get2numberis10( number));

string Get2numberis10(int number)
{
    string text = "";
    
    for (int i = 0; 0 < number  ; i++)
    {
        text = number%2 + text;
        number /= 2;
        
    }
return text ;

}

*/




/*
int number = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(",", GetArrayFibonachi(number)));

int[] GetArrayFibonachi(int number)
{
  
    int[] array = new int[number];
    if (number > 0 ) array[0] = 0;
    if (number > 1 ) array[1] = 1;
    
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = (array[i - 1]) + (array[i - 2]);
    }

    return array;
}


 void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}
*/

/*
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];

Console.WriteLine(string.Join(",", GetRandomNumber(array)));

Console.WriteLine(string.Join(", ", GetArrayCopy(array)));

int[] GetArrayCopy(int[] array)
{
    int[] arraycopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arraycopy[i] = array[i];
    }

    return arraycopy;
}

int[] GetRandomNumber(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 15);
    }

    return array;
}


*/

















/*
int[] array = new int[5] { 1, 2, 3, 4, 5 };

int[] tmp = new int[array.Length];
Array.Copy(array, tmp, array.Length);
Reverse(array);
PrintArray(array);

PrintArray(tmp);

int[] reversed = Reverse2(array);
PrintArray(reversed);

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

void Reverse(int[] array)
{
    int tmp;
    for (var i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

int[] Reverse2(int[] array)
{
    int[] reversed = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }

    return reversed;
}
*/
