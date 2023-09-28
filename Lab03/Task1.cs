using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        // Сложение векторов
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);
        }   
        // Умножение векоров
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X * vector2.X, vector1.Y * vector2.Y, vector1.Z * vector2.Z);
        }
        // Умножене векоров на число
        public static Vector operator *(Vector vector, double scalar)
        {
            return new Vector(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
        }
        public static Vector operator *(double scalar, Vector vector)
        {
            return vector*scalar;
        }
        // Сравнене длин векторов через ==
        public static bool operator ==(Vector vector1, Vector vector2)
        {
            return Math.Abs(vector1.Length()) == Math.Abs(vector2.Length());
        }
        // Сравнене векоров через !=
        public static bool operator !=(Vector vector1, Vector vector2)
        {
            return !(vector1 == vector2);
        }
        // Нахождене длины вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }
        internal class Task1
    {
        static void Main(string[] args)
        {
            // Task1 - проверена
            Vector vector1 = new Vector(5, 10, 15);
            Vector vector2 = new Vector(8, 4, 2);

            Vector sum = vector1 + vector2;
            Vector multip = vector1 * vector2;
            Vector multipnum = vector1 * 2;
            bool equal = vector1 == vector2;

            Console.WriteLine($"Sum: ({sum.X}, {sum.Y}, {sum.Z})"); // Sum: (13, 14, 17)
            Console.WriteLine($"Multiplikashon: ({multip.X}, {multip.Y}, {multip.Z})"); // Multiplikashon: (40, 40, 30)
            Console.WriteLine($"Multiplikashon number : ({multipnum.X}, {multipnum.Y}, {multipnum.Z})"); // Multiplikashon number : (10, 20, 30)
            Console.WriteLine($"Equal: {equal}"); // Equal: False

            Console.WriteLine();

            // Task2 - проверена
            Car car1 = new Car { Name = "Nissan", Engine = "V6", MaxSpeed = 200 };
            Car car2 = new Car { Name = "Toyota", Engine = "4-cylinder", MaxSpeed = 180 };

            Console.WriteLine(car1); // Nissan 
            Console.WriteLine(car2); // Toyota

            Console.WriteLine(car1.Equals(car2)); // False

            CarsCatalog catalog = new CarsCatalog();
            catalog.AddCar(car1);
            catalog.AddCar(car2);

            catalog.Info(0); // Nissan V6
            Console.WriteLine(catalog[0].Name); // Nissan
            Console.WriteLine(catalog[1].Engine);// 4-cylinder

            Console.WriteLine();

            
        }
    }
}
    

