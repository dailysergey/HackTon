using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            var spiralMatrix = p.SpiralMatrix(5);
            p.PrintMatrix(spiralMatrix, 5);
        }

        void PrintMatrix(int[,] matr,int dim)
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write(matr[i,j]);
                }
                Console.WriteLine();
            }
        }

        int[,] SpiralMatrix(int N)
        {
            int[,] result = new int[N,N];
            int last_row, last_column, last_dim;
            last_row =last_column=last_dim = N - 1;
            //vars for watching and going through matrix
            int i,k = 0,l = 0;
            //temp var for values inititalize
            int temp;
            #region Generating values to put in Spiral Matrix 
            int[] values = new int[N*N];
            for (temp = 0; temp < N*N; temp++)
            {
                values[temp] = temp + 1;
            }
            #endregion

            temp = 0;
            while(k <= last_row && l <= last_column)
            {
                //Initialize first row
                for(i = l; i <= last_column; i++)
                {
                    result[k, i] = values[temp];
                    if (temp < values.Length)
                        temp++;
                }
                k++;
                for (i = k; i <= last_row;i++)
                {
                    result[i, last_column] = values[temp];
                    if (temp < values.Length)
                        temp++;
                }
                last_column--;

                if(k <= last_row)
                {
                    for (i = last_row; i >= l; i--)
                    {
                        result[last_column, l] = values[temp];
                        if(temp < values.Length)
                            temp++;
                    }
                    last_row--;
                }
                if (l <= last_column)
                {
                    for (i = last_row; i >= k; i--)
                    {
                        result[i, l] = values[temp];
                        if (++temp == values.Length)
                            continue;
                    }
                    l++;
                }
            }
            return result;
        }
    }
}
