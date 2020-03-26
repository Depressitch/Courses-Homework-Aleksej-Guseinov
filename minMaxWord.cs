using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input your line: ");
		string input = Console.ReadLine();
		FindMinMaxWord(input);
		Console.ReadLine();
	}
	static void FindMinMaxWord(string text) //функция на нахождение самого длинного и короткого слова
	{
		int minLength = text.Length;
		int minI = 0;
		int maxLength = 0;
		int maxI = 0;
		for (int i = 0; i < text.Length && text[i] != '.'; i++)
		{
			int wordLength = 0;
			for (int j = i; j < text.Length && char.IsLetter(text, j); j++)
			{
				wordLength++;
			}
			if (maxLength < wordLength)
			{
				maxLength = wordLength;
				maxI = i;
			}
			if (minLength > wordLength)
			{
				minLength = wordLength;
				minI = i;
			}
			i += wordLength;
		}
		Console.WriteLine($"Longest word: {text.Substring(maxI, maxLength)} \nShortest word: {text.Substring(minI, minLength)}");
	}
}
