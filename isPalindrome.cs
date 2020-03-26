using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input your line: ");
		string input = Console.ReadLine();
		isPalindrome(input);
		Console.ReadLine();
	}
	static void isPalindrome(string text) //функция на проверку является ли строка палиндромом
	{
		string modText = text; 	//создаём другую строку, в которой не будет пробелов
		dltSpaces(modText); 	//удаляем из строки пробелы
		for (int i = 0; i < modText.Length / 2; i++)
		{
			//если находится не "зеркальный" элемент, то сразу выводится текст о том, что это не палиндром + заканчивается функция
			if(modText[i] != modText[text.Length - i - 1]) 
			{
				Console.WriteLine("This line is not a palindrome.");
				return;
			}
		}
		Console.WriteLine("This line is a palindrome.");
	}
	static void dltSpaces(string text) 	//функция удаляет пробелы из строки
	{
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == ' ')
			{
				text.Remove(i, 1);				
			}
		}
	}
}
