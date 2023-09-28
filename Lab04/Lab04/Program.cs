using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            /*
            Console.WriteLine("Введите количество строк матрицы:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы:");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальное значение для случайных чисел:");
            int minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение для случайных чисел:");
            int maxValue = int.Parse(Console.ReadLine());

            MyMatrix matrix1 = new MyMatrix(rows, columns, minValue, maxValue);
            MyMatrix matrix2 = new MyMatrix(rows, columns, minValue, maxValue);

            Console.WriteLine("Матрица 1:");
            matrix1.PrintMatrix();

            Console.WriteLine("Матрица 2:");
            matrix2.PrintMatrix();

            Console.WriteLine("Сложение матриц:");
            MyMatrix sumMatrix = matrix1 + matrix2;
            sumMatrix.PrintMatrix();

            Console.WriteLine("Вычитание матриц:");
            MyMatrix diffMatrix = matrix1 - matrix2;
            diffMatrix.PrintMatrix();

            Console.WriteLine("Умножение матриц:");
            MyMatrix mulMatrix = matrix1 * matrix2;
            mulMatrix.PrintMatrix();

            Console.WriteLine("Умножение матрицы на число:");
            Console.WriteLine("Введите число:");
            int scalar = int.Parse(Console.ReadLine());
            MyMatrix mulScalarMatrix = matrix1 * scalar;
            mulScalarMatrix.PrintMatrix();

            Console.WriteLine("Деление матрицы на число:");
            Console.WriteLine("Введите число:");
            scalar = int.Parse(Console.ReadLine());
            MyMatrix divScalarMatrix = matrix1 / scalar;
            divScalarMatrix.PrintMatrix();
            */
            //Task 2
            
            Car[] cars = new Car[]
            {
                new Car("Audi", 2010, 200),
                new Car("BMW", 2020, 250),
                new Car("Mercedes", 2015, 220),
                new Car("Toyota", 2018, 180)
            };

            Console.WriteLine("Sort by name:");
            Array.Sort(cars, new CarComparer(CarComparer.SortBy.Name));
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Console.WriteLine("Sort by production year:");
            Array.Sort(cars, new CarComparer(CarComparer.SortBy.ProductionYear));
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Console.WriteLine("Sort by max speed:");
            Array.Sort(cars, new CarComparer(CarComparer.SortBy.MaxSpeed));
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            // Task 3
            Console.WriteLine("Task 3");
            Console.WriteLine();
            CarCatalor catalog = new CarCatalor();

            catalog.AddCar(new Car("Car1", 2010, 200));
            catalog.AddCar(new Car("Car2", 2015, 250));
            catalog.AddCar(new Car("Car3", 2010, 180));

            // Прямой проход
            Console.WriteLine("Прямой проход:");
            foreach (Car car in catalog)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            // Обратный проход
            Console.WriteLine("Обратный проход:");
            foreach (Car car in catalog.GetReverseIterator())
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            // Проход по году выпуска
            Console.WriteLine("Проход по году выпуска:");
            foreach (Car car in catalog.GetCarsByYear(2010))
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            // Проход по максимальной скорости
            Console.WriteLine("Проход по максимальной скорости:");
            foreach (Car car in catalog.GetCarsByMaxSpeed(200))
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}
