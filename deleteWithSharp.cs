using System;

namespace deleteWithSharp
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Input your line: ");
			string input = Console.ReadLine();
			input = DelWithSharp(input);
			Console.WriteLine("Your decoded line: " + input);
			Console.ReadLine();
		}
		static string DelWithSharp(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '#')
				{
					if (i > 0) //проверка необходима в связи с тем, что удаляются сразу 2 символа, из-за чего в начале текста возможно выйти за рамки строки
					{
						text = text.Remove(i - 1, 2);
						i -= 2;
					}
					else
					{
						text = text.Remove(i, 1);
						i--;
					}
				}
			}
			return text;
		}
	}
}