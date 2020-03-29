using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Input your line: ");
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
		for (int i = 0; i < text.Length; i++)
		{
			int wordLength = 0;
			for (int j = i; j < text.Length && char.IsLetter((string)text, j); j++) //если символ - буква, то увеличивается длина слова
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
		Console.WriteLine($"Longest word: {text.Substring(maxI, maxLength)} \nShortest word: {text.Substring(minI, minLength)}"); 
		//выводим мин/макс слова подстроками
	}
}
