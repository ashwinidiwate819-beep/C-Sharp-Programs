using System;

class MatrixMultiplication
{
    static void Main()
    {
        Console.Write("Enter rows of Matrix 1: ");
        int r1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter columns of Matrix 1: ");
        int c1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter rows of Matrix 2: ");
        int r2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter columns of Matrix 2: ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        if (c1 != r2)
        {
            Console.WriteLine("Matrix multiplication not possible.");
            return;
        }

        int[,] matrix1 = new int[r1, c1];
        int[,] matrix2 = new int[r2, c2];
        int[,] product = new int[r1, c2];

        Console.WriteLine("Enter elements of Matrix 1:");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c1; j++)
            {
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of Matrix 2:");
        for (int i = 0; i < r2; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                product[i, j] = 0;
                for (int k = 0; k < c1; k++)
                {
                    product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Product of matrices:");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write(product[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
