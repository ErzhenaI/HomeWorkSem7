//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет
//НЕ МОГУ НАПИСАТЬ ПРОГРАММУ! ДЕНИС, ПОДСКАЖИТЕ, В ЧЕМ ОШИБКА?

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(10, 31);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

void SearchElement(int[,] matrix, int n = 0, int m = 0)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (n < 0 || n > matrix.GetLength(0)-1 || m < 0 || m > matrix.GetLength(1)-1)
                    Console.WriteLine("Такого элемента в массиве нет");
                else
                    Console.WriteLine("Такой элемент в массиве есть, равен = {0}", matrix[n,m]);
            }
            Console.ReadLine();  
    }
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите позицию строки элемента в массиве: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца элемента в массиве: ");
int m = int.Parse(Console.ReadLine()!);
SearchElement(matrix);