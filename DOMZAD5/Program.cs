

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

//ЗАДАЧА 2
/*
Console.WriteLine("Введите количество элемпнтов массива");
int number = int.Parse(Console.ReadLine());
int[] masiv = new int[number];
GetRandoNumberinMasiv(masiv);
Console.WriteLine(string.Join(",", masiv));
GetSumArrayNechetPosition(masiv);


int[] GetRandoNumberinMasiv(int[] masiv)
{
    Random rand = new Random();
    for (int i = 0; i < masiv.Length; i++)
    {
        masiv[i]= rand.Next(1,99);
    }
     return masiv;
}

void GetSumArrayNechetPosition(int[] massiv)
{
    int sum = 0;
   for (int i = 1; i < number; i=i+2)
   {
     sum= sum + masiv[i];
   }

    Console.WriteLine(sum);
}
*/
//ЗАДАЧА 3
/*
Console.WriteLine("Введите количство элементов массива");
int number = int.Parse(Console.ReadLine());
int[] masiv = new int[number];
GetRandoNumberinMasiv(masiv);
Console.Write("[");
Console.Write(string.Join(",", masiv));
Console.Write("]");
GetMinAndMaxNumberArray(masiv);

Console.Write("Разница между макс и мин: ");
Console.WriteLine(GetMinAndMaxNumberArray(masiv));

int GetMinAndMaxNumberArray(int[] masiv)
{
    int result = 0;
    int max = 0;
    int min = 20;
    int i =0 ;
    while (i<masiv.Length)
    
    {
        if(masiv[i]>max)
        {
            max = masiv[i];
            i++;
        }
         else if (masiv[i]<min)
        {
            min = masiv[i];
            i++;
        }
        else 
        {
            i++;
        }
       
    }
    return result = max - min ; 
}


int[] GetRandoNumberinMasiv(int[] masiv)
{
    Random rand = new Random();
    for (int i = 0; i < masiv.Length; i++)
    {
        masiv[i]= rand.Next(10,50);
    }
     return masiv;
}
*/
//ЗАДАЧА 1

Console.WriteLine("Введите количество элемпнтов массива");
int number = int.Parse(Console.ReadLine());
int[] masiv = new int[number];
GetRandoNumberinMasiv(masiv);
Console.Write("[");
Console.WriteLine(string.Join(",", masiv));
Console.Write("]");
Console.Write("количество четных чисел  ");
Console.WriteLine(GetKolChetnuxChisel( masiv));
int GetKolChetnuxChisel(int[] masiv)
{
    int i = 0;
    int result = 0;
    int index = 0;
while (i<masiv.Length)
{
    result = masiv[i]%2;
    if (result == 0)
    {
        index= index + 1 ;
        i++;
    }
    else 
    {
       i++;
    }
    
}
return index;
}


int[] GetRandoNumberinMasiv(int[] masiv)
{
    Random rand = new Random();
    for (int i = 0; i < masiv.Length; i++)
    {
        masiv[i]= rand.Next(100,1000);
    }
     return masiv;
} 


