using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MyMatrix
    {
        private int m;
        private int n;
        private int[,] data;
        private Random random;

        public MyMatrix(int m, int n, int minValue, int maxValue)
        {
            this.m = m;
            this.n = n;           
            random = new Random();

            data = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    data[i, j] = random.Next(minValue, maxValue); // Рандомный ли рандом?
                }
            }
        }
        public int this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Матрицы должны быть одинакового размера для сложения.");
            }
            
            MyMatrix resultMatrix = new MyMatrix(matrix1.m, matrix1.n, 0, 0);

            for (int i = 0; i < matrix1.m; i++)
            {
                for (int j = 0; j < matrix1.n; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultMatrix;
        }
        public static MyMatrix operator -(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Матрицы должны быть одинакового размера для вычитания.");
            }

            MyMatrix resultMatrix = new MyMatrix(matrix1.m, matrix1.n, 0, 0);

            for (int i = 0; i < matrix1.m; i++)
            {
                for (int j = 0; j < matrix1.n; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return resultMatrix;
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1.n != matrix2.m)
            {
                throw new ArgumentException("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы для их умножения.");
            }

            MyMatrix resultMatrix = new MyMatrix(matrix1.m, matrix2.n, 0, 0);

            for (int i = 0; i < matrix1.m; i++)
            {
                for (int j = 0; j < matrix2.n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.n; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            return resultMatrix;
        }
        public static MyMatrix operator *(MyMatrix matrix, int scalar)
        {
            MyMatrix resultMatrix = new MyMatrix(matrix.m, matrix.n, 0, 0);

            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] * scalar;
                }
            }

            return resultMatrix;
        }
        public static MyMatrix operator /(MyMatrix matrix, int scalar)
        {
            if (scalar == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо.");
            }

            MyMatrix resultMatrix = new MyMatrix(matrix.m, matrix.n, 0, 0);

            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] / scalar;
                }
            }

            return resultMatrix;
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
