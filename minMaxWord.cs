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
		var modText = text.ToLower();
		int minLength = modText.Length;
		int minI = 0;
		int maxLength = 0;
		int maxI = 0;
		for (int i = 0; i < modText.Length; i++)
		{
			int wordLength = 0;
			for (int j = i; j < modText.Length && char.IsLetter(modText, j); j++) //если символ - буква, то увеличивается длина слова
			{
				wordLength++;
			}
			if (maxLength < wordLength) //присваиваем индекс и длину макс слова
			{
				maxLength = wordLength;
				maxI = i;
			}
			if (minLength > wordLength && wordLength > 0) //присваиваем индекс и длину мин слова, если длина слова не 0
			{
				minLength = wordLength;
				minI = i;
			}
			i += wordLength;
		}
		Console.WriteLine($"Longest word: {modText.Substring(maxI, maxLength)} \nShortest word: {modText.Substring(minI, minLength)}"); 
	}
}
