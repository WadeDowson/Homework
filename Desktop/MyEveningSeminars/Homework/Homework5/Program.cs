// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minPosition, int maxPosition)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minPosition, maxPosition);
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

// void NumberOfEven(int [] array)
// {
//     int count=0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2==0) count++;
//     }    
//     Console.WriteLine($"Количество четных чисел в массиве - {count}");
// }


// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(length, min, max);
// ShowArray(newArray);
// NumberOfEven(newArray);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minPosition, int maxPosition)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minPosition, maxPosition);
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

// void SumOfOdd(int [] array)
// {
//     int sum=0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2==1) sum+=array[i];
//     }    
//     Console.WriteLine($"Сумма нечетных чисел в массиве - {sum}");
// }


// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(length, min, max);
// ShowArray(newArray);
// SumOfOdd(newArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size, int minPosition, int maxPosition)
// {
//     double[] myArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minPosition, maxPosition);
//     }
//     return myArray;
// }

// void ShowArray(double[] array)
// {
//     Console.WriteLine("Полученный массив->: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();

// }

// void FindSubtructionMinMax(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         if (array[i] > max) max = array[i];
//         for (int j = 1; j < array.Length; j++)
//         {
//             if (array[j] < min) min = array[j]; 
//         }
//     }
//     Console.WriteLine($"Разность между максимальным и минимальным элементом массива : {max-min}");
// }   

// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] newArray = CreateRandomArray(length, min, max);
// ShowArray(newArray);
// FindSubtructionMinMax(newArray);
