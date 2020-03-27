using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input your line: ");
		string input = Console.ReadLine();
		IsPalindrome(input);
		Console.ReadLine();
	}
	static void IsPalindrome(string text) //функция на проверку является ли строка палиндромом
	{
		string modText = text;  //создаём другую строку, в которой не будет пробелов
		modText = modText.ToLower(); //делаем все буквы нижнего регистра
		modText = modText.Replace(" ", ""); //удаляем пробелы
		for (int i = 0; i < modText.Length / 2; i++)
		{
			//если находится не "зеркальный" элемент, то сразу выводится текст о том, что это не палиндром + заканчивается функция
			if (modText[i] != modText[modText.Length - i - 1])
			{
				Console.WriteLine("This line is not a palindrome.");
				return;
			}
		}
		Console.WriteLine("This line is a palindrome.");
	}
}
