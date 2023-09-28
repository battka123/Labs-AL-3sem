using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Rectangle
{
    // Поля класса
    public double side1;
    public double side2;

    // Конструктор с 2 параметрами
    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    // Метод для подсчёта площади
    private double CalculateArea()
    {
        return side1 * side2;
    }
    // Метод для подсчёта периметра
    private double CalculatePerimeter()
    {
        return (side1 + side2) * 2;
    }
    // Свойство для приват метода подсчёта площади
    public double Area
    {
        get
        {
            if (side2 > 0 && side1 > 0) return CalculateArea();
            return 0;

        }
    }
    // Свойство для приват метода подсчёта периметра
    public double Perimeter
    {
        get
        {
            if (side2 > 0 && side1 > 0) return CalculatePerimeter();
            return 0;

        }

    }
}

public class Point
{
    // Поля класса
    private int x;
    private int y;

    // Свойства для полей
    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }

    // Конструктор с 2 параметрами
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}

public class Figure
{
    private Point[] points;
    public string Name { get; set; }


    // Конструктор с параметрами

    public Figure(string name)
    {
        points = new Point[5];
        Name = name;
    }
    public Figure(Point p1, Point p2, Point p3, string name) : this(name)
    {
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, string name) : this(p1,p2,p3,name)
    {
        points[3] = p4;
        
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, string name) : this(p1, p2, p3, p4, name)
    {
        points[4] = p5;

    }
    /*
    public Figure(Point p1, Point p2, Point p3, Point p4 = null, Point p5 = null, string name = "")
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
        Name = name;
    }
    */
    // Метод, который рассчитывает длину стороны многоугольника
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    // Метод, который рассчитывает периметр многоугольника
    public /* double */ void PerimeterCalculator()
    {
        double perimeter = 0;
        int i = 0;

        for (; i < points.Length - 1; ++i)
        {

            if (points[i + 1] != null)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            else break;
        }
        // Добавляем последнюю сторону
        perimeter += LengthSide(points[i], points[0]);

        Console.WriteLine($"Периметр: {perimeter}");

        // return perimeter;
        //для тестов раскоментить для double и return, убрать void следовало бы :)
    }

}

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            // int
            Console.WriteLine($"Минимальное значение int: {int.MinValue}");
            Console.WriteLine($"Максимальное значение int: {int.MaxValue}");

            // float
            Console.WriteLine($"Минимальное значение float: {float.MinValue}");
            Console.WriteLine($"Максимальное значение float: {float.MaxValue}");

            // double
            Console.WriteLine($"Минимальное значение double: {double.MinValue}");
            Console.WriteLine($"Максимальное значение double: {double.MaxValue}");

            // decimal 
            Console.WriteLine($"Минимальное значение decimal: {decimal.MinValue}");
            Console.WriteLine($"Максимальное значение decimal: {decimal.MaxValue}");

            // byte 
            Console.WriteLine($"Минимальное значение byte: {byte.MinValue}");
            Console.WriteLine($"Максимальное значение byte: {byte.MaxValue}");

            // DateTime
            Console.WriteLine($"Минимальное значение DateTime: {DateTime.MinValue}");
            Console.WriteLine($"Максимальное значение DateTime: {DateTime.MaxValue}");

            // SByte 
            Console.WriteLine($"Минимальное значение SByte: {SByte.MinValue}");
            Console.WriteLine($"Максимальное значение SByte: {SByte.MaxValue}");

            // Single
            Console.WriteLine($"Минимальное значение  Single: {Single.MinValue}");
            Console.WriteLine($"Максимальное значение  Single: {Single.MaxValue}");

            // bool
            Console.WriteLine($"Минимальное значение bool: {bool.FalseString}");
            Console.WriteLine($"Максимальное значение bool: {bool.TrueString}");

            // UInt16
            Console.WriteLine($"Минимальное значение  UInt16: {UInt16.MinValue}");
            Console.WriteLine($"Максимальное значение  UInt16: {UInt16.MaxValue}");

            // и так далее для других типов

            // Задание 2

            Console.WriteLine("Введите одну сторону прямоугольника: ");
            String first = Console.ReadLine();
            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            String second = Console.ReadLine();

            // Создал объект прямоугольник
            Rectangle rectangle = new Rectangle(Double.Parse(first), Double.Parse(second));

            // Выдаёт "0", если сторона неположительна!
            Console.WriteLine("Площадь прямоугольника: {0}", rectangle.Area);
            Console.WriteLine("Периметр прямоугольника: {0}", rectangle.Perimeter);

            //Задание 3

            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(1, 0);
            // Point p5 = new Point(1, 1);

            Figure figure = new Figure(p1, p2, p3, p4, name: "Square");
            Console.WriteLine($"Фигура называется: {figure.Name}");
            figure.PerimeterCalculator();

            // (Тесты в другом файле)
            Console.ReadLine();
        }
    }
}

