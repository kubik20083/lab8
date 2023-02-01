// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
int rows = ReadInt("Введите количество строк общее для двух матриц: ");
int columns = ReadInt("Введите количество столбцов общее для двух матриц: ");
int[,] firstArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

System.Console.WriteLine("Первая матрица");
FillArrayRandom(firstArray);
PrintArray2D(firstArray);

System.Console.WriteLine();

System.Console.WriteLine("Вторая матрица");
FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}
System.Console.WriteLine("Произведение матриц");
PrintArray2D(resultArray);



// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция заполнения массива рандомными числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 5}", array[i, j] + " "));
        }
        Console.WriteLine();
    }
}