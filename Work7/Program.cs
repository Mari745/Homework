Console.WriteLine("Введите число от 1 до 7:");
int dayNumber = 9;
Console.WriteLine(WorkHoliday(dayNumber));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Цифра " + a + " - Выходной");
        }
        else
        {
            Console.Write("Цифра" + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("День не определен");
    }
    return " день.";
}