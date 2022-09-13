using System;

internal class Class37
{
	public static string smethod_0()
	{
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = "";
		Random random = new Random();
		int num = random.Next(0, text.Length);
		for (int i = 0; i < num; i++)
		{
			text2 += text[random.Next(10, text.Length)];
		}
		return text2;
	}

	public static int smethod_1()
	{
		return new Random().Next(11, 99);
	}
}
