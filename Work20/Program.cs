//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



//Ввод
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArrayD(numbers);
PrintArrayD(numbers);
NumberArray(numbers);
Console.WriteLine();
//Заполнение массива

void FillArrayD(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}
//Минимальная сумма строки
void NumberArray(int[,] array)
{
int minRows = 0;
int minSumRows = 0;
int minSum= 0;;

for (int i = 0; i < numbers.GetLength(1); i++)
{
    minRows += numbers[0, i];
}
for (int i = 0; i < numbers.GetLength(0); i++)
   {
    for (int j = 0; j < numbers.GetLength(1);j++)
    
        minSum += numbers[i, j];
    
     if (minSum < minRows)
     {
            minRows = minSum;
            minSumRows = i;
        }
        minSum = 0;
    }
    Console.Write($"{minSumRows + 1} строка");
}

//Печать массива
void PrintArrayD(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
