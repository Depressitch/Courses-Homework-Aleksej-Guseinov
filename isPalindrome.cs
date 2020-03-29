using System;

namespace isPalindrome
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Input your line: ");
			string input = Console.ReadLine();
			//на консоль всегда выведется "this line is a palindrom", а если функция вернёт false
			Console.WriteLine("This line is" + ((IsPalindrome(input) ? "" : " not") + " a palindrom"));
			Console.ReadLine();
		}
		static bool IsPalindrome(string text) //функция на проверку является ли строка палиндромом
		{
			text = text.ToLower(); //делаем все буквы нижнего регистра
			text = DltNotLetters(text); //удаляем из строки всё кроме букв
			for (int i = 0; i < text.Length / 2; i++)
			{
				//если находится не "зеркальный" элемент, то сразу выходим из функции с false
				if (text[i] != text[text.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}
		static string DltNotLetters(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				if (!char.IsLetter(text, i))
				{
					text = text.Remove(i--, 1);
					//i-- необходим для того, чтобы индекс сдивнулся назад, так как при удалении символа по факту индекс перескачит на 2 от оригинала
				}
			}
			return text;			
		}
	}
}
