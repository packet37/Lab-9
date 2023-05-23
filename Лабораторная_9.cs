//Задание 1

//static double Formula(double x)
//{
//    Random rnd = new();
//    int a = rnd.Next(-50, 51);
//    if (a == x)
//    {
//        throw new DivideByZeroException("Деление на ноль");
//    }
//    if (x > a)
//    {
//        throw new ArgumentException();
//    }
//    if (x < 0)
//    {
//        return x + Math.Pow(Math.Sin(1 / (x - a) + 4), 2);
//    }
//    else
//    {
//        return a * x / Math.Sqrt(a * a - x * x);
//    }
//}

//try
//{
//    int x = int.Parse(Console.ReadLine());
//    Console.WriteLine(Formula(x));
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("Деление на ноль невозможно");
//}
//catch (FormatException e)
//{
//    Console.WriteLine("Введите числовые данные");
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine("Неподходящий аргумент");
//}
//catch (Exception e)
//{
//    Console.WriteLine("Какая-то ошибка");
//}
//finally
//{
//    Console.WriteLine("Все закончилось");
//}

//Задание 2

using System;

static void Array(int i, int k1, int k2, double[] arr)
{
    for (i = k1; i<k2;i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
}
static double RandArray(int k1, int k2, double[] arr)
{
    Random rnd = new Random();
    for (int i = k1; i < k2; i++)
    {
        
        arr[i] = rnd.Next();
    }
    return arr[k2-1];
}

try
{
    double[] array1 = { 1, 2, 3, 4, 5, 6, 6, 6, 7 };
    RandArray(2, 5, array1);
    Console.WriteLine(string.Join(", ", array1));
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Индекс вышел за рамки");
}
