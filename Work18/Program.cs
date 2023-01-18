//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Ввод строк и столбцов
int strok = ReadInt("Введите количество строк: ");
int stolb = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[strok, stolb];
FillArray(numbers);
PrintArray(numbers);

if (strok < numbers.GetLength(0) && stolb < numbers.GetLength(1)) Console.WriteLine(numbers[strok, stolb]);
else Console.WriteLine($"{strok}{stolb} -> такого числа в массиве нет");
//Заполнение массива

void FillArray(double[,] collection)
{ 
    for (int i = 0; i < collection.GetLength(0); i++)
    {
         for (int j = 0; j < collection.GetLength(1); j++)
         {
            collection[i, j] = new Random().Next(1,10);
         }
    }
}

//Печать массива
void PrintArray(double[,] array)
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
