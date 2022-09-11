using System;

internal class Class0
{
	public string method_0(string string_0, byte byte_0)
	{
		string text = "";
		char[] array = string_0.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(array[i] ^ byte_0);
			text += char.ToString(array[i]);
		}
		return text;
	}

	public string method_1()
	{
		string text = "";
		Random random = new Random();
		random.Next(97, 122);
		for (int i = 0; i < 20; i++)
		{
			text += Convert.ToChar(random.Next(97, 122));
		}
		return text + ".html";
	}

	public string method_2()
	{
		string text = "";
		Random random = new Random();
		random.Next(97, 122);
		for (int i = 0; i < 2; i++)
		{
			text += Convert.ToChar(random.Next(97, 122));
		}
		return text + (DateTime.Now.Day + 10) + Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)) + (DateTime.Now.Month + 10) + Convert.ToChar(random.Next(97, 122));
	}
}
