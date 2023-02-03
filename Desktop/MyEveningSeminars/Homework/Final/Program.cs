// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNum(int num)
// {
//     if (num >= 1)
//     {
//         Console.Write(num + " ");
//         PrintNum(num - 1);

//     }
// }

// PrintNum(8);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int m, int n)
// {
//     if (m!=n)
//     {
//             return FindSum(m,n-1) + n;
//     }
//     else
//     {
//         return m;
//     }
// }
// int result = FindSum(4,8);
// Console.WriteLine(result);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AkkermanFunc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return AkkermanFunc(m - 1, 1);
//     }
//     return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// }

// int result = AkkermanFunc(3, 2);
// Console.WriteLine(result);

