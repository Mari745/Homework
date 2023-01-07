int a;
Console.WriteLine("Введите число:");
a=Convert.ToInt32(Console.ReadLine()) ;
if (a % 2 == 0)
{
   Console.WriteLine("{0} четное", a );
}
else
{
    Console.WriteLine("{0} не четное", a);
}
Console.ReadLine();

