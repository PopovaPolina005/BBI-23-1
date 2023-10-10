﻿#region 2.1
/*
using System;

class Program
{
	static void Main()
	{
		double x = 0.5; // Значение x
		double epsilon = 0.0001; // Точность
		double sum = 0.0;
		double term = 1.0; // Первый член ряда
		int n = 1;

		while (Math.Abs(term) >= epsilon)
		{
			sum += term;
			n++;
			term = Math.Cos(n * x) / (n * n);
		}

		Console.WriteLine("Сумма последовательности равна: " + sum);
	}
}
*/
#endregion

#region 2.2
/*
using System;

class Program
{
    static void Main()
    {
        int L = 30000; // Заданное значение L
        int n = 1;    // Начинаю с n = 1
        int p = 1;    // Начальное значение произведения

        while (p * (3 * n + 1) <= L)
        {
            p *= 3 * n + 1;
            n++;
        }

        Console.WriteLine("Наибольшее значение n: " + (n - 1));
    }
}
*/
#endregion

#region 2.3
/*
int a = 1; // первый член прогрессии
int h = 2; // шаг прогрессии
int p = 100; // заданное число
int n = 0; // количество членов прогрессии

int sum = 0; // сумма членов прогрессии
int count = 0; // количество членов прогрессии

while (sum <= p)
{
    count++;
    sum += a + (count * h);
}

n = count - 1;

Console.WriteLine("Количество членов прогрессии: " + n);
*/
#endregion

#region 2.4
/*
double e = 0.0001;
n = 0;
x = 0.9;
s = 0;
while (Math.Pow(x, 2 * n) >= e)
{
    s += Math.Pow(x, 2 * n);
    n += 1;
}
Console.WriteLine("2_4:\n{0}", s);
Console.WriteLine();
*/
#endregion

#region 2.5
/*
using System;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            int result = 0;
            N = Int32.Parse(Console.ReadLine());
            M = Int32.Parse(Console.ReadLine());
            while (N >= M)
            {
                N -= M;
                result++;
            }
            Console.WriteLine($"Частное: {result},остаток: {N}");
            Console.ReadKey();
        }
    }
}
*/
#endregion

#region 2.7
/*
//А
double dailyDistance = 10; // начальное расстояние в первый день
double sumDistance = dailyDistance; // суммарное расстояние

for (int day = 2; day <= 7; day++)
{
    dailyDistance *= 1.1; // увеличиваю дневную норму на 10%
    sumDistance += dailyDistance; // добавляю пройденное расстояние к суммарному пробегу
}

Console.WriteLine("Суммарный путь за 7 дней: " + sumDistance + " км");

//Б
double dailyDistance = 10; // начальное расстояние в первый день
double sumDistance = dailyDistance; // суммарное расстояние
int day = 2; // счетчик дней

while (sumDistance <= 100)
{
    dailyDistance *= 1.1; // увеличиваю дневную норму на 10%
    sumDistance += dailyDistance; // добавляю пройденное расстояние к суммарному пробегу
    day++;
}

Console.WriteLine("Спортсмен пробежит суммарный путь 100 км через " + (day - 1) + " дней");

//В 
double dailyDistance = 10; // начальное расстояние в первый день
int day = 1; // счетчик дней

while (dailyDistance <= 20)
{
    dailyDistance *= 1.1; // увеличиваю дневную норму на 10%
    day++;
}

Console.WriteLine("Спортсмен будет пробегать в день больше 20 км через " + day + " дней");
*/
#endregion

#region 2.8
/*
s = 10000;
k = 0;
while (s <= 20000)
{
    s *= 1.08;
    k++;
}
Console.WriteLine("2.8:\n{0}", k);
Console.WriteLine();
*/
#endregion

#region 3.7
/*
using System;
mamespace ConsoleAplication2

    class Program
{
    public static int Factoria(int fact)
    {
        if (fact == 0 || fact == 1) return 1;
        return fact * Factoria(fact - 1);
    }
    public static void Main(string[] args)
    {
        double s = 0;
        int i = 0;
        double y = 0;

        for (double x = 0.1; x <= 1; x = x + 0.05)
        {
            double tr = 0;
            do
            {
                tr = (Math.Pow(x, (2 * i)) / Factorial(2 * i));
                s = s + tr;
                i++;
            }
            while (Math.Abs(tr) >= 0.0001);
            Console.WriteLine(s);
            y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, y - x)) / 2;
            Console.WriteLina("Y равен" + y);
        }
*/
#endregion