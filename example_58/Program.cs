/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2) {
    int productMatrix = 0;
    int[,] sumMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++) {
        for (int n = 0; n < matrix1.GetLength(1); n++) {
            for (int j = 0; j < matrix2.GetLength(1); j++) {
                productMatrix = matrix1[i, n] * matrix2[n, j];
                sumMatrix[i, j] += productMatrix;
                productMatrix = 0;
            }
        }
    }
    return sumMatrix;
}

int[,] array2d1 = CreateMatrixRndInt(5, 3, 1, 9);
int[,] array2d2 = CreateMatrixRndInt(3, 7, 1, 9);

if (array2d1.GetLength(1) == array2d2.GetLength(0)) {
    PrintMatrix(array2d1);

Console.WriteLine("Х");

PrintMatrix(array2d2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица равна");
Console.WriteLine();
int[,] productMAtrix = ProductMatrix(array2d1, array2d2);
PrintMatrix(productMAtrix);

} else Console.WriteLine("Ошибка! Число столбцов матрицы 1 не равно числу строк матрицы 2!");