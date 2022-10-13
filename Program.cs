// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 1;
for (i = 1; i <= B; i++)
    sum = A * sum;
Console.WriteLine($"Число {A} в степени {B} равно = {sum}");
*/


// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int sum = 0;
int res = 0;
int num1;
while (number > 10)
{
    num1 = number % 10;
    sum = sum + num1;
    number = number / 10;

if (number<10)
    res = sum + number;
}

Console.WriteLine($"Сумма цифр во введенном числе = {res}");
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и 
// выводит их на экран.
//m = 5 -> [1, 2, 5, 7, 19]
//m = 3 -> [6, 1, 33]


Console.WriteLine("Введите количество элементов массива");


 void FillArray(int[] array)
 {
     int length = array.Length;
     int index = 0;
     while (index < length)
    {
         Console.WriteLine($"Введите элемент массива [{index}]:");
        int N = Convert.ToInt32(Console.ReadLine());
        array[index] = N;
         index++;
     }
 }
 void PrintArray(int[] arr)
 {
     int count = arr.Length;
     int index = 0;
     while (index < count)
     {
         Console.Write(arr[index] + " ");
         index++;
     }
 }
 int[] array = new int[3];
 int count = array.Length;

 FillArray(array);
 PrintArray(array);