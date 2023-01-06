
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Pow(int num1,int num2)
// {
//     int pow = num1;
//     for (int step = 1; step < num2; step++)
//     {
//          pow= pow*num1;
//     }
//     return pow;
// }
   
// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = Pow (a,b);
// Console.WriteLine($"{result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int SumOfDigits (int number)
// {
// int sum = 0;
// while (number != 0)
//     {
//         sum+= number %10;
//         number /= 10;
//     }
//      return sum;
// }

// Console.WriteLine("Введите число" );
// int a = Convert.ToInt32(Console.ReadLine());
// int result = SumOfDigits(a);
// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandomArray(int size)
// {
//     int [] myArray = new int [size];
//     for(int i=0; i<size; i++)
//     {
//     myArray[i]= new Random().Next(0,100);
//     }
//     return myArray;
// }

// void ShowArray (int [] array)
// {
//     Console.WriteLine ("Полученный массив->: ");
//     for(int i=0; i<array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();

// }

// int size = 8;
// int [] newArray = CreateRandomArray(size);
// ShowArray(newArray);
