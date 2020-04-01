using System;

namespace arraysAndStrings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an operation: " +
                "\n1 - find value and index of last negative number in an array" +
                "\n2 - change all elements in a 2D matrix that go after a max in a line to 0" +
                "\n3 - NOTWORKING!! same as 2, but using a different method" +
                "\n4 - count amount of vowels in a line" +
                "\n5 - switch all 'a' to 'A' in a line");
            string input = Console.ReadLine();
            Random random = new Random();
            Console.Clear();
            switch (input)
            {
                case "1":
                    #region negative number                    
                        const int arraySize = 8;
                        int[] arr1 = new int[arraySize];
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            arr1[i] = random.Next(-9, 9);  //заполняем массив случайными числами от -9 до 9
                        }
                        Console.WriteLine("Your array is:");
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            Console.Write($"{arr1[i]} ");
                        }
                        int negI = 0;
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            if (arr1[i] < 0)
                            {
                                negI = i;
                            }
                        }
                        Console.WriteLine($"\nValue of last negative number: {arr1[negI]}\n" +
                            $"Index of last negative number: {negI}");
                    break;
                    #endregion
                case "2":
                    #region switch values after max
                    {
                        Console.Write("Input matrix's height: ");
                        int sizeA2 = ParseInput("matrix's height");
                        Console.Write("Input matrix's width: ");
                        int sizeB2 = ParseInput("matrix's width");
                        int[,] arr2 = new int[sizeA2, sizeB2];
                        arr2 = GetRandMatrix(arr2);
                        Console.WriteLine("===========================\n" +
                            "Your matrix: ");
                        OutputMatrix(arr2);
                        for (int i = 0; i < arr2.GetLength(0);i++)
                        {
                            int maxJ = 0;
                            for (int j = 0;j < arr2.GetLength(1); j++) //находим индекс максимального числа в строке массива
                            {
                                if (arr2[i, j] > arr2[i, maxJ])
                                {
                                    maxJ = j;
                                }
                            }
                            for (int k = maxJ + 1; k < arr2.GetLength(1); k++) //меняем все числа после этого индекса
                            {
                                arr2[i, k] = 0;
                            }                         
                            Console.WriteLine();
                        }
                        Console.WriteLine("===========================\n" +
                            "Your modiffied matrix: ");
                        OutputMatrix(arr2);
                    }
                    break;
                    #endregion
                case "3": //увы, не успел сделать :с
                    #region switch values after max but different
                    break;
                    #endregion
                case "4":
                    #region find vowels in a line
                    int count = 0;
                    Console.Write("Input your line: ");
                    string text1 = Console.ReadLine();
                    text1 = text1.ToLower();
                    for (int i = 0; i < text1.Length; i++)
                    {
                        if (text1[i] == 'a' || text1[i] == 'e' || text1[i] == 'i' || text1[i] == 'o' || text1[i] == 'u')
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"There are {count} vowels in your line.");
                    break;
                    #endregion
                case "5":
                    #region swap 'a' to 'A'
                    Console.Write("Input your line: ");
                    string text2 = Console.ReadLine();
                    text2 = text2.Replace('a', 'A');
                    Console.WriteLine($"Your modiffied line: " + text2);
                    break;
                    #endregion
                default:
                    Console.WriteLine("Incorrect input.");
                    break;
            }
            Console.WriteLine("===============================\n" +
                "Press \"r\" to repeat the program.");
            if (Console.ReadKey().KeyChar == 'r') //если нажата r, то программа перезапустится, предварительно очистив консоль
            {
                Console.Clear();
                Main();
            }
        }
        #region functions for parsing values
        static int ParseInput(string text)
        {
            string input = Console.ReadLine();
            int value;
            while (!int.TryParse(input, out value) && value <= 0)
            {
                Console.Write($"Please, input correct {text}: ");
                input = Console.ReadLine();
            }
            return value;
        } //функция для парсинга int с выводом названия значения
        static int ParseInput()
        {
            string input = Console.ReadLine();
            int value;
            while (!int.TryParse(input, out value) && value <= 0)
            {
                Console.Write("Please, input correct value: ");
                input = Console.ReadLine();
            }
            return value;
        } //функция для парсинга int без вывода названия значения
        #endregion
        #region functions for working with matrixes
        static int[,] InputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            return matrix;
        } //ручной ввод значений матрицы
        static int[,] GetRandMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 9);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            return matrix;
        } //заполнение матрицы случайными числами от 0 до 9
        static int[,] GetRandMatrix(int[,] matrix, int startRand, int endRand)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(startRand, endRand);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            return matrix;
        } //заполнение матрицы случайными числами в заданном диапазоне
        static void OutputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        } //вывод матрицы
        #endregion
    }
}
