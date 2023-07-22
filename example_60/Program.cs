/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
Результат:
66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)
*/

int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth) {
    //                       0        1       2
    int[,,] matrix = new int[rows, columns, depth];
    int n = 10;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            for (int k = 0; k < matrix.GetLength(2); k++) {
                matrix[i, j, k] = n;
                n++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            for (int k = 0; k < matrix.GetLength(2); k++) {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3d = CreateMatrix3DRndInt(3, 5, 6);

if (array3d.Length > 90) {
    Console.WriteLine("Двузначные цифры закончились!");
} 

else PrintMatrix(array3d);