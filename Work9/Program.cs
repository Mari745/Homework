double GetDistance(double x1,double x2, double y1, double y2,double z1,double z2)
{
    return Math.Sqrt (Math.Pow(x1-x2, 2)
                    + Math.Pow(y1-y2, 2)
                    + Math.Pow(z1-z2, 2));

}
 
double GetValue(string text)
{
  System.Console.Write(text);
  return Convert.ToDouble(Console.ReadLine());
}

double x1=GetValue("x1 = ");
double x2=GetValue("x2 = ");
double y1=GetValue("y1 = ");
double y2=GetValue("y2 = ");
double z1=GetValue("z1 = ");
double z2=GetValue("z2 = ");

double distance = GetDistance(x1, x2, y1, y2, z1,z2);
System.Console.WriteLine(distance);