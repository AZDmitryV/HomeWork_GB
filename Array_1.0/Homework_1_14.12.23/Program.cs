// Console.WriteLine();

// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[] array = new int[10];
// int count = 0;
// for(int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1,100);
//     Console.WriteLine();
//     Console.Write(array[i] +" ");
//     if(array[i]>20 && array[i]<90)
//     {
//         Console.Write(array[i] +" ");
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {count}");
// Console.WriteLine();


// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = new int[10];
// int count = 0;
// for(int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next();
//     Console.Write(array[i] +" ");
//     if(array[i] % 2 == 0)
//     {
//     count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Чётных чисел в массиве: {count}");

// Console.WriteLine();


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[10];
// int i=0;
// Console.Write("Значения массива: ");
// for(i=0; i<array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     Console.Write(array[i] +"; ");
// }

// double max = array[0];
// double min = array[0];
// for(i=0; i<array.Length; i++)
// {
//     if(max<array[i])
//     {
//         max=array[i];
//     }
//     if(min>array[i])
//     {
//         min=array[i];
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"Максимальный элемент массива: {max}");
// Console.WriteLine($"Минимальный элемент массива: {min}");
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max-min}");
// Console.WriteLine();


// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

// int num = new Random().Next(1,100001);
// int mem = num; // память
// Console.WriteLine($"Случайное число: {num}"); // покажем сгенерированное число
// int i=0;
// int count=0; // для подсчета чисел в числе

// for(i=0; num>0; i++) // считаем цифры в числе
// {
//     num = num / 10;
//     count++;
// }
// i=0;
// num = mem;
// int find=count; // начальное значение массива
// int[] arrrem = new int[find]; // массив для сохранения остатков

// for(i=0; i<arrrem.Length; i++) // записываем цифры в массив
// {
//     arrrem[arrrem.Length-1-i] = num % 10; // не хочет корректно выдавать последние два значения, заменяет их нулями при записи через один цикл. В отдельном цикле всё выдаёт как надо
//     num = num / 10;
// }
// Console.WriteLine();
// i=0;
//     Console.Write("Массив из цифр полученного числа: ");
// while(i<arrrem.Length)
// {
//     Console.Write(arrrem[i] +" ");
//     i++;
// }