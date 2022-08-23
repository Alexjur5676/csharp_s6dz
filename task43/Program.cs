// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (d-c)/(a-b)
// y=a*(d-c)/(a-b)+c

Console.WriteLine("значения b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("значения k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("значения b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("значения k2");
double k2 = Convert.ToDouble(Console.ReadLine());


if (b2 == b1 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают ");
    }
else
    if(k1 == k2)
    {
        Console.WriteLine("Прямые паралельны ");
    }
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами: X = {x} , Y = {y} ");
}


