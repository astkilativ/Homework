// Console.WriteLine("введите число от 100 до 999");
// int number = Convert.ToInt32(Console.ReadLine());
// //int number = new Random().Next(0,1000);
// int res = number/10 % 10;
// if (number <100 || number>1000)
// {
//     Console.WriteLine("ошибка ввода введите трехзначное число");
// }
// Console.WriteLine(res); // ответ на задачу 10

// Console.WriteLine("введите любое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int number3 = number% 100;
// Console.WriteLine(number3);
// if (number3 == 0)
// {
//     Console.WriteLine("3-го числа нет");
// }
// int number = Convert.ToInt32(Console.ReadLine());
// int dif =0;
// int original=number;
// int remaind = 0;
// while (number>0)
// {
// remaind=number % 10;
// number = number/10;
// dif=(dif*10)+remaind;
// }
// if (original>99999)
// {
//     Console.WriteLine("Число не пятизначное");
//     Console.WriteLine("                     False");
// }
// else
// {
//  if (dif == original)
//     {
//         Console.WriteLine("True");
//     }
//     if (dif < original || dif > original)
//     {
//         Console.WriteLine("False");
//     }
// }

// Задача 40: Напишите программу, которая принимает
//  на вход три числа и проверяет, может ли существовать 
//  треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая 
// сторона треугольника меньше суммы двух других сторон.
// // || - или && - и

// System.Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num3 = int.Parse(Console.ReadLine());

// if(num1<num2+num3 && num2<num1+num3 && num3<num2+num1)
// {
//     System.Console.WriteLine("Подходит");
// }
// else
// {
//     System.Console.WriteLine("Не подходит");
// }

// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// System.Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// string result= "";

// while(num1>0)
// {
//     result = num1%2 + result;
//     num1= num1/2;
// }

// System.Console.WriteLine(result);

// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом
//   месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// System.Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int[] array = new int[num];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]= new Random().Next(0,10);
//     System.Console.Write(array[i]+ " ");
// }

// for (int i = 0; i < array.Length/2; i++)
// {
//     int temp = array[i];
//     array[i] =array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }

// System.Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i]+ " ");
// }


// Буткемп Понедельник
// Быстрая Сортировка O(n * log2(n))
// Напишите программу, которая принимает на вход два числа(a и b) и выполняет сложения
// без оператора a + b

// int summNumbers(int a, int b){
//     if (b == 0)
//         return a;
//     return summNumbers(a + 1, b - 1);
// }   


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {summNumbers(a, b)}");
/*
summNumbers = S
S(2, 3) = S(3, 2) = S(4, 1) = S(5, 0) = 5
*/

/*
[3, -10, 0, 2, -1, 9, 4, 5, 3]
pivot = 3
[-10, 0, 2, -1] + [3, 3] + [9, 4, 5]

[-10, 0, 2, -1]
pivot = -10
[] + [-10] + [0, 2, -1]

[0, 2, -1]
pivot = 0
[-1] + [0] + [2]


[9, 4, 5]
pivot = 9
[4, 5] + [9] + []


[4, 5]
pivot = 4
[] + [4] + [5]



[-10] + [-1] + [0] + [2] + [3, 3] + [4] + [5] + [9]
*/



// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




// Данная промежуточная аттестация оценивается по системе "зачет" / "не зачет".
// Данная промежуточная аттестация оценивается по системе "зачет" / "не зачет".
// "Зачет"" ставится, если Слушатель успешно выполнил 3 или 2 критерия.
// "Незачет"" ставится, если Слушатель успешно выполнил 1 или меньше критериев.

// Критерии оценивания:
// 1 - Слушатель написал корректную программу с использованием рекурсии по выведению всех натуральных чисел в промежутке от N до 1.
// 2 - Слушатель написал корректную программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 3 - Слушатель написал корректную программу с использованием рекурсии по вычислению функции Аккермана

// ___________________________________________________________________________________________
// using System;
// namespace NumberRecursion
// {
//     class Program
//     {
//         // Функция, которая выводит числа с помощью рекурсии
//         static void PrintNumbersRecursive(int number)
//         {
//             // Если число равно 0, выходим из рекурсии
//             if (number == 0)
//             {
//                 return;
//             }
            
//             // Выводим текущее число
//             Console.Write($"{number} ");
            
//             // Рекурсивно вызываем функцию с уменьшенным числом
//             PrintNumbersRecursive(number - 1);
//         }
        
//         static void Main(string[] args)
//         {
//             Console.WriteLine("\n Введите число:");
//             int number = int.Parse(Console.ReadLine());
//             PrintNumbersRecursive(number);
//         }
//     }
// }
// ___________________________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// using System;

// namespace SumNaturals
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите M:");
//             Console.WriteLine("Введите N:");
//             int M = Convert.ToInt16(Console.ReadLine());
//             int N = Convert.ToInt16(Console.ReadLine());

//             int sum = 0;
//             for (int i = M; i <= N; i++)
//             {
//                 sum += i;
//             }

//             Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}: {sum}");
//         }
//     }
// }
// вводим числа
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите M и N через Enter:");
//ограничил числовое пространство чтоб не баловаться с порядком цифр
int m = Convert.ToInt16(Console.ReadLine());
int n = Convert.ToInt16(Console.ReadLine());

int Akeman (int m, int n)
{
if (m == 0)
{
    return n+1; // спросить почему не получается n++ n--
}

if (n == 0)
{
return Akeman(m-1, 1);
}
return Akeman(m-1,Akeman(m, n-1)); //возвращаю m  и функцию саму на себя? признаться честно до сих пор не очень понимаю как работает, но работает. 
}
Console.WriteLine($"Аккерман= (*_*)// {Akeman(m,n)}");