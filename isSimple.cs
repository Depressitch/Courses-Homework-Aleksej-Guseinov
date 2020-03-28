using System;

namespace hwFourTaskOne
{
    class Program
    {
        static void Main()
        {
            #region input

            Console.Write("Input number higher than 0: ");
            var input = Console.ReadLine();  //строка ввода, которую мы будем проверять на соответствие нужному типу
            int number;
            while (!int.TryParse(input, out number) && number <= 0)
            {
                Console.Write("Please, input a correct number: ");
                input = Console.ReadLine();
            }

            #endregion

            #region finding out if it's prime

            Console.WriteLine("================================\n" +
                $"List of prime numbers from 0 to {number}:");
            for (int i = 0; i <= number; i++) 
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            Console.ReadKey();
        }
        static bool IsPrime(int num)  //функция для определения является ли число простым
        {
            /*
             цикл идёт только до числа, которое равно половине заданного, так как число больше явно не будет делить нацело
             также есть дополнительное условие - num < 2 - которое необходимо для того, чтобы 0 и 1 не воспринимались как простые числа
            */
            for (int j = 2; j <= num / 2 || num < 2; j++)
            {
                if (num % j == 0) //если делится каким-либо числом нацело, то false
                {
                    return false; 
                }
            }
            return true;
        }
    }
