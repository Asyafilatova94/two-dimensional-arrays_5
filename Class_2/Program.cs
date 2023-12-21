//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


var array = new[,] { { 12, 5, 24, 71, 66 }, //Определяем двумерный массив 
                    { 2, 44, 66, 33, 77 },
                    {43, 56, 87, 34, 11} };

var rowMax = array.GetLength(0);
var columnMax = array.GetLength(1);

Console.WriteLine("Исходный массив:");
for (var i = 0; i < rowMax; i++)
{
    for (var j = 0; j < columnMax; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (var i = 0; i < columnMax; i++)
{
    var bufValue = array[rowMax - 1, i]; // запоминаем текущий элемент последней строки
    array[rowMax - 1, i] = array[0, i]; // Записываем в текущий элемент последней строки текущий элемент первой
    array[0, i] = bufValue; // Записываем в текущий элемент первой строки запомненное значение из последней
}


Console.WriteLine("Поменяли первую и последнюю строки:");

for (var i = 0; i < rowMax; i++)
{
    for (var j = 0; j < columnMax; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}