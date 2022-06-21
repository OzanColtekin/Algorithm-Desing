using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class Matrix
    {
        public int[,] Create(int row=3,int column=3, int min=1,int max=9)
        {
            int[,] matrix = new int[row,column];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    matrix[i, j] = new Random().Next(min, max);
            return matrix;
        }
        public void Print(int[,] matrix)
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
        public int[,] ZeroMatrix(int row,int column)
        {
            return Create(row, column, 0, 0);
        }
        public int[,] OneMatrix(int row, int column)
        {
            return Create(row, column, 1, 1);
        }
        public int[,] DiagonalMatrix(int x = 3,int min=1,int max=9)
        {
            int[,] matrix = ZeroMatrix(x, x);
            for (int i = 0; i < x; i++)
            {
                matrix[i, i] = new Random().Next(min, max);
            }
            return matrix;
        }
        public int[,] ScalarMatrix(int x=3,int scalar = 3)
        {
            var matrix = DiagonalMatrix(x, scalar,scalar);
            return matrix;
        }
        public int[,] UnitMatrix(int x=3)
        {
            var matrix = ScalarMatrix(x, 1);
            return matrix;
        }
        public bool IsSquareMatrix(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ? true : false ;
        }
        public bool IsUnitMatrix(int[,] X)
        {
            bool control = true;
            for (int i = 0; (i<X.GetLength(0) && control==true); i++)
            {
                for (int j = 0; (j < X.GetLength(1)); j++)
                {
                    if (X[i,j] != 0 && i!=j)
                    {
                        control = false;
                        break;
                    }
                    else
                    {
                        if (X[i,i] != 1 && i == j)
                        {
                            control = false;
                            break;
                        }
                    }
                }
            }
            return control;
        }
        public void PrintDiagonal(int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    if (i == j) Console.Write(X[i, j] + "     ");
                }
            }
        }
        public int[,] Transpoze(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[j, i] = X[i, j];
                }
            }
            return T;
        }
    }
}
