//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет

var array = new[,] { { 12, 5, 24, 71, 66 }, //Определяем двумерный массив 
                    { 2, 44, 66, 33, 77 },
                    {43, 56, 87, 34, 11} };

Console.WriteLine("Введите позицию элемента в двумерном массиве через запятую:");

var positionsStr = Console.ReadLine()?.Split(',') ?? []; //Считываем пользовательский ввод и разделяем строку запятой

if (positionsStr.Length != 2)// Проверяем что введено 2 элемента через запятую
{
    Console.WriteLine("Неправильный ввод, введите 2 числа через запятую");
    return;
}

var rowPosition = int.Parse(positionsStr[0]); // Парсим первое число (Индекс строки)
var columnPostion = int.Parse(positionsStr[1]); // Парсим второе число (ИНдекс столбца)


var arrayRows = array.GetLength(0);// Получаем количество строк в массиве
var arrayColumns = array.GetLength(1);// Получаем количество столбцов в массиве
if ((arrayRows - 1) < rowPosition ||
(arrayColumns - 1) < columnPostion)
{
    Console.WriteLine($"Введённая позиция выходит за пределы размерности массива. Определён массив с размерностью [{arrayRows}, {arrayColumns}]");
    return;
}

Console.WriteLine($"Значение элемента с индексом [{rowPosition}, {columnPostion}] - {array[rowPosition, columnPostion]}");
