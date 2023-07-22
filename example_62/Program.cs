/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


void PrintMatrix(string[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j], 5} ");
            }
        Console.WriteLine("|");
    }
}

string[,] SpiralMAtrix(string[,] matrix) {
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int rows = 0;
    int columns = 0;
    int dx = 1;
    int dy = 0;
    int k = m;
    int b = 0;
    for (int i = 0; i < matrix.Length; i++) {
        if (i < 10) matrix[rows, columns] = $"{0}{i}";
        else matrix[rows, columns] = $"{i}";
        k--;
        if (k == 0) {
                k = m * (b % 2) + n * ((b + 1) % 2) - (b/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                b++;
              }
        rows += dy;
        columns += dx;
    }
    return matrix;
}

string[,] array2d = new string[4,4];
string[,] spiralMatrix = SpiralMAtrix(array2d);
PrintMatrix(spiralMatrix);
