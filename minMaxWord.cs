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
		int minLengthI = 0;
		int maxLength = 1;
		int maxLengthI = 0;
		for (int i = 0; text[i] == '.'; i++)
		{
			int wordLength = 0;
			for (int j = 0; !char.IsLetter(text, j); j++)
			{
				wordLength++;
			}
			if (maxLength < wordLength)
			{
				maxLength = wordLength;
				maxLengthI = wordLength;
			}
			if (minLength > wordLength)
			{
				minLength = wordLength;
				minLengthI = wordLength;
			}
			i += wordLength;
		}
		Console.WriteLine($"Longest word: {text.Substring(maxLengthI, maxLength)} \nShortest word: {text.Substring(minLengthI, minLength)}");
	}
}
