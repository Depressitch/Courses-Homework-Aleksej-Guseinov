using System;

namespace isPrime
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

            Console.WriteLine("================================\n" +
                $"List of prime numbers from 0 to {number}:");
            for (int i = 0; i <= number; i++) 
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
        static bool IsPrime(int num)  //функция для определения является ли число простым
        {
            /            //если остаток от деления на 2 не равен 0, то начинается проверка на простоту
			if (num % 2 != 0)
			{
				/*
				вводим переменную для условия продолжения цикла, чтобы не высчитывать корень в каждой итеррации 
				наименьший делитель числа не превосходит корень этого числа
				*/
				int sqrtNum = (int)Math.Sqrt(num); 
            	for (int j = 3; j <= sqrtNum; j+=2)
					if (num % j == 0) //если делится каким-либо числом нацело, то false
						return false; 
				return true;
			}
			//так как из-за первого условия мы можем попасть на двойку, то проверяем чтобы не допустить ошибку
			if (num == 2)
				return true;
			return false;
        }
    }
}
