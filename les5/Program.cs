﻿
/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 
3; массив [6, 7, 19, 345, 3] -> да


Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

/*

int[] array = new int[] {1,2,-2,3,-5,-6,4,9};
Console.WriteLine(SearchNumberinArray(2,  array));
Console.WriteLine(string.Join(",", ChangeArray(array)));

int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
        array[i]= array[i]*-1;
       
}
 return array;
}

string SearchNumberinArray(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
        if (array[i] == number )
        {
            return "yes";
        }
       
}
return "no";
}
*/
int n = int.Parse(Console.ReadLine());
int[] size = new int[123];

int[] GetCreateArray123( int[] size)
{
      for (int i = 0; i < size.Length; i++)
      {
        size[i]= Random.Next(0,200);
        
      }

return size;

}
