// Задача 54: Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine($"Введите размер массива m x n :");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine($"\nИсходный массив: \n");
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: \n");
SortArrayLines(array);
WriteArray(array);

//Функция сортировки элементов в строках массива по убыванию
void SortArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int messege = Convert.ToInt32(Console.ReadLine());
    return messege;
}
//Функция заполнения массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}