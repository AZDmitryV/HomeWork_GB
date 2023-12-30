// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int m = new Random().Next(1,5);
// int n = new Random().Next(m+1,9);
// int step = 1;
// Console.Write(m+" ");
// Console.WriteLine(n);

// PrintNum(m, n);
// void PrintNum(int m, int n)
// {
// if(m>n){return;}
// Console.Write(m+" ");
// PrintNum(m+step, n);
// }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Работа с функциями (типа Аккермана) - вообще тёмный лес. Нет видимых вычислений = непонимание происходящего. Условия написать можно и по вики, но что здесь происходит?! Где подсчёт?

// int m = 3;
// int n = 2;
// ackermann(m, n);
// int ackermann(int m, int n)
// {
//     if (m == 0) 
//     {
//         return n + 1;
//     } 
//     else if (m > 0 && n == 0) 
//     {
//         return ackermann(m - 1, 1);
//     } 
//     else 
//     {
//         return ackermann(m - 1, ackermann(m, n - 1));
//     }
// }
// Console.WriteLine(ackermann(m, n));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int length = 10; //длина массива
// int i = 0; //начало массива
// int[] array = new int[length];
// FillArray(i);
// void FillArray(int i) // к сожалению я так и не понял на 100% как именно я сделал это заполнение и как и почему оно работает внутри :( Но работает. Вот бы кто объяснил пошагово что к чему...
// {
//     if(i==array.Length){return;}
//     array[i] = new Random().Next(1,10);
//     Console.Write(array[i]+" ");
//     i++;
//     FillArray(i);
//     return;
// }
// Console.WriteLine();
// ReversArray(i); // а вот здесь всё максимально понятно
// void ReversArray(int i)
// {
//     i=array.Length-i-1;
//     Console.Write(array[i]+" ");
//     i--;
//     if(i<0){return;}
//     ReversArray(i=array.Length-i-1);
//     return;
// }