﻿
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondNumber (int num)
// {
//     int dec = num/10;
//     return dec%10;
// }

// Console.WriteLine("Input number");
// int num =Convert.ToInt32(Console.ReadLine());
// int result = SecondNumber(num);
// Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + numText[2]);
// }
// else 
// {
//   Console.WriteLine("-> третьей цифры нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Input day's number of the week");
// int num = Convert.ToInt32(Console.ReadLine());
// void CheckTheDayOfTheWeek (int num) 
// {if (num == 6 || num == 7)
// {
//     Console.WriteLine("выходной -> да");
// }

//   else Console.WriteLine("не выходной -> нет");
// }
// CheckTheDayOfTheWeek(num);
