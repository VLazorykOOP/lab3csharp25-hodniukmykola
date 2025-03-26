using System;
using System.Collections.Generic;

class Romb
{
    // Захищені поля
    protected int a, d1;
    protected int color;

    // Конструктор
    public Romb(int a, int d1, int color)
    {
        this.a = a;
        this.d1 = d1;
        this.color = color;
    }

    // Властивості
    public int A
    {
        get { return a; }
        set { a = value; }
    }
    public int D1
    {
        get { return d1; }
        set { d1 = value; }
    }
    public int Color
    {
        get { return color; }
    }

    // Методи
    public void Display()
    {
        Console.WriteLine($"Ромб: сторона = {a}, діагональ = {d1}, колір = {color}");
    }

    public int Perimeter()
    {
        return 4 * a;
    }

    public double Area()
    {
        double d2 = Math.Sqrt(4 * a * a - d1 * d1);
        return (d1 * d2) / 2;
    }

    public bool IsSquare()
    {
        return d1 == a * Math.Sqrt(2);
    }
}

class Program
{
    static void Main()
    {
        List<Romb> rombs = new List<Romb>
        {
            new Romb(5, 6, 1),
            new Romb(4, 5, 2),
            new Romb(7, 7, 3),
            new Romb(6, 6, 4)
        };

        int squareCount = 0;

        foreach (var romb in rombs)
        {
            romb.Display();
            Console.WriteLine($"Периметр: {romb.Perimeter()}");
            Console.WriteLine($"Площа: {romb.Area():F2}");
            if (romb.IsSquare())
            {
                Console.WriteLine("Це квадрат.");
                squareCount++;
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
