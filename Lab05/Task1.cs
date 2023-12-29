using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class MyMatrix
    {
        private int[,] matrix;
        // Создал консрукор
        public MyMatrix(int m, int n, int minRange, int maxRange)
        {
            matrix = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(minRange, maxRange + 1);
                }
            }
        }
        // Метод Fill перезаполняющий матрицу случайными значениями
        public void Fill(int minRange, int maxRange)
        {
            Random rand2 = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand2.Next(minRange, maxRange + 1);
                }
            }
        }
        // Метод ChangeSize, изменяющий число строк и/или столбцов с копированием значений существующей матрицы
        public void ChangeSize(int m, int n, int minRange, int maxRange)
        {
            int[,] newMatrix = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                    else
                    {
                        newMatrix[i, j] = rand.Next(minRange, maxRange + 1);
                    }
                }
            }
            matrix = newMatrix;
        }
        // Метод ShowPartialy выдаёт значение матрицы с заданной строки и солбца
        public void ShowPartialy(int startRow, int endRow, int startColumn, int endColumn)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // Метод Show выводит всю матрицу
        public void Show()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // Индексатор с аксессором и мутатором
        public int this[int index1, int index2]
        {
            get // аксессор
            {
                return matrix[index1, index2];
            }
            set // мутатор
            {
                matrix[index1, index2] = value;
            }
        }
    }
}

