using System;

namespace rundll32.encryption;

internal class sll
{
	private static string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

	public static string decrypt(string input, string pass)
	{
		char[] array = new char[input.Length];
		for (int i = 0; i < input.Length; i++)
		{
			if (chars.Contains(input[i].ToString()))
			{
				array[i] = '0';
			}
			else
			{
				array[i] = input[i];
			}
		}
		input = new string(array);
		pass += pass;
		string text = "";
		int num = 0;
		for (int j = 0; j < input.Length / 5; j++)
		{
			if (num == pass.Length - 1)
			{
				num = 0;
			}
			char c = (char)int.Parse(input.Substring((j + 1) * 5 - 5, 5));
			char c2 = c;
			char c3 = pass[num];
			text += (char)((c2 ^ c3) / (int)c3);
			num++;
		}
		return text;
	}

	public static string encrypt(string input, string pass)
	{
		pass += pass;
		int num = 0;
		char[] array = new char[input.Length];
		for (int i = 0; i < input.Length; i++)
		{
			if (num == pass.Length - 1)
			{
				num = 0;
			}
			char c = input[i];
			char c2 = pass[num];
			char c3 = (array[i] = (char)((c * c2) ^ c2));
			num++;
		}
		string text = "";
		char[] array2 = array;
		foreach (int num2 in array2)
		{
			text += $"{num2:00000}";
		}
		char[] array3 = new char[text.Length];
		Random random = new Random();
		for (int k = 0; k < text.Length; k++)
		{
			if (text[k] == '0')
			{
				int index = random.Next(0, chars.Length);
				array3[k] = chars[index];
			}
			else
			{
				array3[k] = text[k];
			}
		}
		return new string(array3);
	}
}
