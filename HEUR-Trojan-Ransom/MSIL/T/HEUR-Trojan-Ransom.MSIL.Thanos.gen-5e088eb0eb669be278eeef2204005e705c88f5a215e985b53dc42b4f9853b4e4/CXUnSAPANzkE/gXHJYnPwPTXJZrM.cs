using System;

namespace CXUnSAPANzkE;

public sealed class gXHJYnPwPTXJZrM
{
	public static string QJQnnaFXKLEZHqqtt(int int_0)
	{
		Random random = new Random();
		string text = null;
		for (int i = 0; i < 32; i++)
		{
			char value = (char)(random.Next(33, 127) % 255);
			if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
			{
				text += Convert.ToChar(value);
			}
			else
			{
				i--;
			}
		}
		return text;
	}
}
