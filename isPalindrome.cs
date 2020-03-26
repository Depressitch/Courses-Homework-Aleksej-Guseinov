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
	static void isPalindrome(string text) //������� �� �������� �������� �� ������ �����������
	{
		string modText = text; 	//������ ������ ������, � ������� �� ����� ��������
		dltSpaces(modText); 	//������� �� ������ �������
		for (int i = 0; i < modText.Length / 2; i++)
		{
			if(modText[i] != modText[text.Length - i - 1]) 	//���� ��������� �� "����������" �������, �� ����� ��������� ����� � ���, ��� ��� �� ��������� + ������������� �������
			{
				Console.WriteLine("This line is not a palindrome.");
				return;
			}
		}
		Console.WriteLine("This line is a palindrome.");
	}
	static void dltSpaces(string text) 	//������� ������� ������� �� ������
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