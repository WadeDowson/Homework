// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom(int Number)
// {
//     string NumberText = Convert.ToString(Number);
//     if (NumberText[0] == NumberText[4] && NumberText[1] == NumberText[3])
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }
// Console.WriteLine("Введите пятизначное число");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberText = Convert.ToString(Number);
// Palindrom(Number);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double N(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double raz1 = x2 - x1;
//     double raz2 = y2 - y1;
//     double raz3 = z2 - z1;
//     double distanse = Math.Round(Math.Sqrt(Math.Pow(raz1, 2) + Math.Pow(raz2, 2) + Math.Pow(raz3, 2)), 2);
//     return distanse;
// }
// Console.WriteLine("Input X1");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y1");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Z1");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input X2");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y2");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Z2");
// double z2 = Convert.ToDouble(Console.ReadLine());
// double result = N(x1, y1, z1, x2, y2, z2);
// Console.WriteLine(result);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void N(int number)
// {
//     for (int i = 1; i < number+1; i++)
//     {
//         int result= i*i*i;
//         Console.WriteLine($"{result}");
//     }
// }

// Console.WriteLine("Input number");
// int x = Convert.ToInt32(Console.ReadLine());
// N(x);

