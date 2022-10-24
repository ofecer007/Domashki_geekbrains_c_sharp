/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double userPoint(string msg)
{
    Console.Write($"Введите точку {msg}: ");
    double point = Convert.ToDouble(Console.ReadLine());
    return point;
}

double[] crossPoint(double b1, double k1, double b2, double k2)
{
    double[] y = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    y[0] = k1 * x + b1;
    y[1] = k2 * x + b2;
    return y;
}

void printArray(double[] incomingArray)
{
    Console.Write("(");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine(")");
}

Console.WriteLine("Чтобы найти точку пересечения двух прямых, задайте точки координат.");

double b1 = userPoint("b1");
double k1 = userPoint("k1");
double b2 = userPoint("b2");
double k2 = userPoint("k2");

double[] result = crossPoint(b1, k1, b2, k2);
printArray(result);