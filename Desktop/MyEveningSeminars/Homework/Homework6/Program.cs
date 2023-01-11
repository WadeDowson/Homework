// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateRandomArray(int size)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(-100,1000);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив->: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();

// }


// void CountPositive(int [] array)
// {   
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0) count++;
//     }
//     Console.WriteLine($"{count} - количество положительных элементов в массиве ");
// }

// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateRandomArray(length);
// ShowArray(newArray);
// CountPositive(newArray);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void DotCross(double k1, double b1, double k2, double b2)
// {
//     double x = (b1 - b2) / (k2 - k1);
//     double y = k2 * x + b2;
//     Console.WriteLine($"Точка пересечения с координатами ({x};{y})");
// }


// Console.WriteLine("Введите значение к1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение к2");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// DotCross(k1, b1, k2, b2);

