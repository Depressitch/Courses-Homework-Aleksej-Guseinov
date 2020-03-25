```cs

using System;

namespace courseTwoProjectOne
{
    class Program
    {      
        static void Main(string[] args)
        {
            const byte monthes = 12; // константа с количеством месяцев платежей
            Console.Write("Input desired loan amount: ");
            string input = Console.ReadLine();  //строка ввода, которую мы будем проверять на соответствие нужному типу
            decimal creditAmount;
            /*
            если введённые в строку данные невозможно перевести в double, то программа потребует повторно ввести размер кредита
            если данные возможно перевести в double, то эти данные передадутся в creditAmount
            если после этого значение creditAmount будет <=0, то программа потребует повторно ввести размер кредита
            */
            while (!decimal.TryParse(input, out creditAmount) && creditAmount <= 0)
            {
                Console.Write("Please, input a correct value of desired loan amount: ");
                input = Console.ReadLine();
            }

            Console.Write("Input desired loan interest (%): ");
            input = Console.ReadLine();
            decimal creditPercent;          
            while (!decimal.TryParse(input, out creditPercent))  //проверка на правильность ввода по тому же принципу
            {
                Console.Write("Please, input a correct value of desired loan amount: ");
                input = Console.ReadLine();
            }
            creditPercent /= 100;   //сразу переводим проценты в сотые 

            Console.WriteLine("Your monthly payouts: ");
            decimal creditBasePay = creditAmount / monthes;     //вводим переменную, в которой будет храниться базовый ежемесячный платёж 
            decimal creditTotal = 0;    //переменная с общим размером кредита
            for (int i = 1; i <= monthes; i++)
            {
                decimal creditMonthlyPay = creditBasePay + creditAmount * creditPercent / monthes;
                creditTotal += creditMonthlyPay;
                creditAmount -= creditBasePay;
                Console.WriteLine($"{i} month \t-\t{creditMonthlyPay:#.##}");
            }
            Console.WriteLine($"Your total loan amount: {creditTotal:#.##}");
            Console.ReadKey();
        }
    }
}
