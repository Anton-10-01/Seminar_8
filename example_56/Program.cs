/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) {
    //                       0        1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementsRowsMatrix(int[,] matrix) {
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            sum[i] = sum[i] + matrix[i, j];
        }
    }
    return sum;
}

int SearchMinimalSumRows(int[] sum) {
    int minRows = sum[0];
    int count = 1;
    for (int i = 1; i < sum.Length; i++) {
        if (sum[i] < minRows) {
            minRows = sum[i];
            count++;
        }
    }
    return count;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(array2d);

Console.WriteLine("");

int[] minSumRowsMatrix = SumElementsRowsMatrix(array2d);
int rows = SearchMinimalSumRows(minSumRowsMatrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rows} строка");