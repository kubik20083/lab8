/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов. */

Console.WriteLine("Введите размер массива m x n");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
System.Console.WriteLine();
int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSum = 0;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSum = SumLine(array, i);
    if (sum > tempSum)
    {
        sum = tempSum;
        minSum = i;
    }
}

Console.WriteLine($"\nСтрокa с наименьшей суммой - {minSum + 1} \nСумма элементов = {sum}");

//Функция подсчета суммы в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int messege = Convert.ToInt32(Console.ReadLine());
    return messege;
}

void CreateArray(int[,] array)
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