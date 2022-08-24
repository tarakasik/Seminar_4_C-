//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// int GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     } 
//     return sum;
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Cумма цифр от 1 до введенного числа: {GetSumNums(num)}");



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3    78 -> 2    89126 -> 5

// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// if (num == 0)
//     Console.WriteLine("1");
// else
// {    
//     while(num!= 0)
//     {
//         num = num / 10;
//         i++;
//     }
//     Console.WriteLine(i);
// }



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24    5 -> 120

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int work = 1;
// if (n > 0)
// {
//     for (int x = 1; x <= n; x++)
//     {
//         work *= x;
//     }
//     Console.WriteLine($"сумма чисел от 1 до {n} -> {work}");
// }
// else
// {
//     Console.WriteLine("введите положительное число от 1, иначе всегда будет 0");
// }



// Волшебство, которое мы еще не изучали.

// long fact(long num)
// {
//     if (num == 1)
//     {
//         return num;
//     }
//     else
//     {
//         return num * fact(num - 1);
//     }
// }
// Console.WriteLine("Введите число N");
// long inputNumber = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Факториал числа " + fact(inputNumber));



// //Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] array1 = new int[8];
Random rnd = new Random();
Console.Write ("Случайный массив из 8 элементов в диапазоне [0,1] - ");
for ( int i = 0; i < 8; i++)
{
    array1[i] = rnd.Next(0,2);
    Console.Write(array1[i] + " ");
}