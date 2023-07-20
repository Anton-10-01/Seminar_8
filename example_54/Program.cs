/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortRowsMatrxi(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++) {
            for (int j = 1; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] < matrix[i, j - 1]) {
                    int temp = matrix[i, j - 1];
                    matrix[i, j - 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(array2d);

Console.WriteLine("");

SortRowsMatrxi(array2d);
PrintMatrix(array2d);