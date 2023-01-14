//Ввод N
int ValueInput()
{
    Console.Write("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

//2 Создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

//3 Заполнение массива

void FillArray(int[] collection)
{
     int count = collection.Length;
    for (int i = 0; i < count; i++)
   {
    collection[i] = Random.Shared.Next(2);
    collection[0] = 1;
   }
}
//4 Печать массива
string PrintArray(int[] Numbers)
{
    string output = String.Empty;
    int size = Numbers.Length;
    for (int i = 0; i < size; i++)
    {
        output= output + $"{Numbers[i]}";
    }
    return output;
}
//5.Конвертация из 2-го в 10-ое
int DramHouse(int[] arrBin)
{
    int count = arrBin.Length;
    int test = arrBin.Length - 1;
    int result = 0;
    for (int i = 0; i < arrBin.Length; i++)
    {
            result += Convert.ToInt32(Math.Pow(2, test));
        test--;
    }
    return result;   
}

// 6.10110100>>180
string BestPrint(int[] bin, int dec)
{
    return $"{String.Join("", bin)} >> {dec}";
}

int number = ValueInput();
int[] arr = CreateArray(number);
FillArray(arr);
int result = DramHouse(arr);

string binPrint = PrintArray(arr);
Console.WriteLine(binPrint);
Console.WriteLine(BestPrint(arr, result));


