void InputMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(new Random().NextDouble()*(50-10) + 10, 2);
    }
}
void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int m = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);