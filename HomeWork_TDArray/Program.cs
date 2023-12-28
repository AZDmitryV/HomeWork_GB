// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] array = new int[10,10];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(100, 1000);
//         }
//     }
// }

// void PrintArray()  //для видимости и сравнения результатов, можно скрыть
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// CreateArray();
// PrintArray();

// // -1 и +1 в значениях для красоты и удобства человека
// Console.WriteLine($"Матрица {array.GetLength(0)}x{array.GetLength(1)}.");
// Console.Write($"Введите номер строки от 1 до {array.GetLength(0)}: ");
// int i = int.Parse(Console.ReadLine());
// i=i-1;
// Console.Write($"Введите номер столбца от 1 до {array.GetLength(0)}: ");
// int j = int.Parse(Console.ReadLine());
// j=j-1;
// if(i<1 || i>array.GetLength(0) || j<1 || j>array.GetLength(1))
// {
// Console.WriteLine($"Элемент за пределами массива.");
// }
// else{Console.WriteLine($"Значение в ячайке {i+1}x{j+1}: {array[i,j]}");}


// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] array = new int[3, 4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ReversArray()
// {
//     for (int i = 0; i < array.GetLength(0)/2; i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[array.GetLength(0) - 1 - i, j];
//             array[array.GetLength(0) - 1 - i, j] = temp;
//         }
//     }
// }

// void PrintRevArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// CreateArray();
// PrintArray();
// ReversArray();
// PrintRevArray();

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[5, 9];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SumElemString()
// {
//     int SumElem = new int();
//     int min = new int();
//     int minSumElem = new int();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             SumElem = 0;
//             while(j < array.GetLength(1))
//             {
//                 SumElem = SumElem+array[i,j];
//                 j++;
//             }
//             if(min==0)
//                 {
//                     min=SumElem; 
//                     minSumElem=i+1; //+1 визуально для человека, убрать чтобы счет был с 0
//                 }
//             if(SumElem<=min)
//                 {
//                     min=SumElem;
//                     minSumElem=i+1; //+1 визуально для человека, убрать чтобы счет был с 0
//                 }
//             Console.WriteLine($"Сумма строки {i+1}: {SumElem}");
//         }
//     }
//     Console.WriteLine("Строка с наименьшей суммой элементов: "+minSumElem);
// }


// CreateArray();
// PrintArray();
// SumElemString();

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца


// int[,] array = new int[10,10];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(100, 1000);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindMinElem()
// {   
//     int min = array[0,0];
//     int imin = 0;
//     int jmin = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i,j]<min)
//             {
//                 min=array[i,j];
//                 imin=i; jmin=j;
//             }
//         }
//     }
//     Console.Write($"Минимальное значение в массиве: {min}");
//     Console.WriteLine();
//     Console.WriteLine($"Позиция минимального значения: {imin}, {jmin}");
//     Console.WriteLine();

    // void NewArray() 
    // NewArray();

    // ! Так и не понял что должно получиться по заданию.
    // "Под удалением понимается создание нового двумерного массива без строки и столбца":
    // "создание нового массива" - совсем нового или со значениями предыдущего, исключая строку и столбец с минимальным значением? Без сохранения значений смысла в задании нет.
    // размер будет на 1 меньше или такой же, но с нулями на месте строки/столбца с минимальным значением? - перенос данных со смещением сделать немного сложнее, чем оставить нули.
    // Сделал 2 варианта с нулями, вариант со смещением не допилил, надо было ошибки с крайними значениями править, время закончилось, надо уходить (да, делаю ночью перед дедлайном).
    // Непонимание что я делаю и зачем выбесило - удалил всё.
    // Всё равно задача не обязательная. 
    // Напишите какой именно способ должен был быть и что должно получиться, для себя хоть доделаю.
// }

// CreateArray();
// PrintArray();
// FindMinElem();