Console.WriteLine("Введите число:");
int number=Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

 if (amount < 3 | amount > 3)
 {  
    Console.WriteLine("Это не трехзначное число");

 }
 else 
 {
    Console.WriteLine(InCenter (number));
 }

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
