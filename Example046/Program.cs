// Задача 46:
// Задайте двумерный массив размером m×n, заполненный случайными
// целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
// m - строки, n - столбцы
int[,] GetArray(int m, int n)  // Метод заполнения массива,
{// содержащий две переменных, который возвращает массив matrix
    int[,] matrix = new int[m, n];  // Создание матрицы
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строки
    {          // Обычно индексы обозначают буквами i, j, m, k
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбцы
        {
            matrix[i, j] = new Random().Next(11);   // От 0 до 10
        }
    }
    return matrix;
}                  // Конец описания метода GetArray
int[,] result = GetArray(rows, columns);    // Вызов метода
                                            // GetArray и создание
                                            // двумерной матрицы
                                            // result, заполненной
                                            // числами от 0 до 10
void PrintArray(int[,] inputMatrix)   // Метод печати массива,
{   // который содержит переменную в виде двумерной матрицы
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i, m] + "\t"); // \t - табуляция
        }
        Console.WriteLine();
    }
}                   // Конец описания метода PrintArray
PrintArray(result); // Вызов метода PrintArray для печати матрицы
                    // result