using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Input sizes of first matrix (a - height, b - width):\na: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b: ");
		int b = Convert.ToInt32(Console.ReadLine());
		int[,] mtrOne = inputMatrix (a, b);
		Console.Write("Input sizes of second matrix (a - height, b - width):\na: ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b: ");
		b = Convert.ToInt32(Console.ReadLine());
		int[,] mtTwo = inputMatrix (a, b);
	}
	static int[,] inputMatrix (int a, int b)
	{
		int [,] newMatrix = new int[a, b];
		for (int i = 0; i < a; i++)
			for (int j = 0; j < b; j++)
			{
				newMatrix [i, j] = Convert.ToInt32(Console.ReadLine());
			}
		return newMatrix;
	}
	static void outputMatrix (int [,] matrix)
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
	static int[,] multMatrix (int [,] matrixOne, int[,] matrixTwo)
	{
		int[,] newMatrix = new int []; 
		return newMatrix;
	}
}
