/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
int number = int.Parse(Console.ReadLine());
VoidArrayNto1(number);
void VoidArrayNto1(int number, int i = 0)
{
   
    if (number<1)
    {
        return;
    }


    
    Console.Write($"{number}; ");
 number--;

    VoidArrayNto1(number,i);
}

*/

/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int number = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int resultmain = VoidArrayNto1(number, number2);
Console.Write(resultmain);
int VoidArrayNto1(int number, int number2, int i = 0)
{
     int result= 0;
  
   
   
    if (number2>=number)
    {
        result += number;   
    }
    else 
    {
        return result;
    }
  number ++;
   return result + VoidArrayNto1(number,number2);
}


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int number = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

Console.Write(MethodAkermana(number,number2));
int MethodAkermana(int number, int number2, int i = 0)
{
  if (number == 0)
    return number2 + 1;
  else
    if ((number != 0) && (number2 == 0))
      return MethodAkermana(number- 1, 1);
    else
      return MethodAkermana(number - 1, MethodAkermana(number, number2 - 1));
}

*/