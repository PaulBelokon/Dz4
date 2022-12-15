


/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/





// ЗАДАНИЕ 1
/*
Console.WriteLine("Введите число которое хотите возвести в степень");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько раз нужно его возвести");
int kol = int.Parse(Console.ReadLine());

int num= 1;


    for ( int i = 1;i<=kol ;i++ )
{
        num *= number;
}
     Console.WriteLine("{0} ^ {1} = {2}", number, kol, num);



*/

//ЗАДАНИЕ 3
/*
Console.WriteLine("Введите количество элементов массива");

  int numberarray = int.Parse(Console.ReadLine());
   int[] arrayis8number = new int[numberarray];



Console.WriteLine(string.Join(",",  GetNumberArray(arrayis8number)));
int[] GetNumberArray(int[] arrayis8number)
{
    Random rand = new Random();
    for (int i = 0; i < arrayis8number.Length; i++)
    {
        arrayis8number[i] = rand.Next(0,20);
    }

return arrayis8number;

}


*/

//ЗАДАНИЕ 2
Console.WriteLine("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());
int length = GetNumberinNumber(number);
GetSumminNumber(number, length);
 
 int GetNumberinNumber(int kol)
 {
    int index = 0;
while (kol >0)
    {

     kol = kol/10;
     index++;   
    }
    return index;
 }


void GetSumminNumber(int num, int length)
{
int sum = 0;
for (int i = 1; i <= length; i++)
{
    sum+= num%10;
    num=num/10;
}
Console.WriteLine(sum);
}