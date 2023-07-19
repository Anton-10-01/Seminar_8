/* Задача 57: Cocтавить частотный словарь элементов
двумерного массива. Частотный словарь содержит информацию
о том, сколько раз встречается элемент входных данных

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

int[] MatrixToArray(int[,] matrix) {
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        int num = arr[i];
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.WriteLine($"{num}");
    }
}

void FrequencyDictionary(int[] array) {
    int temp = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == temp) count++;
        else {
            Console.WriteLine($"{temp} встречается {count} раз");
            temp = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);

int[] arr = MatrixToArray(array2d);
Array.Sort(arr);
PrintArray(arr);

FrequencyDictionary(arr);