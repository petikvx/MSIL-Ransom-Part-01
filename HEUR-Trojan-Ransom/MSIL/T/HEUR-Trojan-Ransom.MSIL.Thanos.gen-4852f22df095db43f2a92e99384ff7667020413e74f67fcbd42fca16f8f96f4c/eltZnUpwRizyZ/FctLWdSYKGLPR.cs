using System;

namespace eltZnUpwRizyZ;

public sealed class FctLWdSYKGLPR
{
	public static string NCHlcfUWfflUhH(int P_0)
	{
		Random random = new Random();
		string text = null;
		for (int i = 0; i < 32; i++)
		{
			char value = (char)(random.Next(33, 127) % 255);
			if (Convert.ToInt32(value) == 34 || Convert.ToInt32(value) == 92)
			{
				i--;
			}
			else
			{
				text += Convert.ToChar(value);
			}
		}
		return text;
	}
}
