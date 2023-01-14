
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int test)
{
    int index = 0;
    while (test > 0)
    {
        test /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int ben, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += ben % 10;
        ben /= 10;
    }
    Console.WriteLine(sum);
}
