// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


var array = new[,] { { 122, 56, 24, 71, 66 }, //Определяем двумерный массив 
                    { 222, 44, 66, 33, 77 },
                    {43, 56, 87, 34, 11} };

var rowMax = array.GetLength(0);
var columnMax = array.GetLength(1);

var rowWithMinSumm = 0;

for (var i = 0; i < rowMax; i++)
{
    var currentRowSumm = 0;
    var minRowSumm = 0;
    for (var j = 0; j < columnMax; j++)
    {
        currentRowSumm += array[i, j];
        minRowSumm += array[rowWithMinSumm, j];
    }

    if (currentRowSumm < minRowSumm)
    {
        rowWithMinSumm = i;
    }
}

Console.WriteLine($"Индекс строки с ниаменьшей суммой жлементов - {rowWithMinSumm}");