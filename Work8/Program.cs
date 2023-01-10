Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 100 == ((number /1000)+9))
{
   Console.WriteLine("{0} Палиндром" , number);
}
else 
{
    Console.WriteLine("{0} Не палиндром", number);
}
Console.ReadLine();