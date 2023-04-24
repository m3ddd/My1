// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
int stepen = numA;

for (int i = 1; i < numB; i++)
{
stepen = stepen * numA;
}
Console.WriteLine("A в степени B = " + stepen);


// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите ваше число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
int i = num % 10;
num = num / 10;
sum = sum + i;
}
Console.WriteLine("сумма всех цифр в числе = " + sum);


// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Вывод сделать отдельным методом.

Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int enterNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[enterNumber];

for (int i = 0; i < enterNumber; i++)
{
  array[i] = new Random().Next(enterNumber+1);
  Console.Write(array[i] + "; ");
}
Console.WriteLine();