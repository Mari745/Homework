Console.WriteLine("Введите число:");
int number = 14212;

if (number % 100 == ((number /1000)+9))
{
   Console.WriteLine("{0} Палиндром" , number);
}
else 
{
    Console.WriteLine("{0} Не палиндром", number);
}
Console.ReadLine();