using System;

namespace PbjBzLsVOvNrzQ;

public class MRonfguJbWECp
{
	public static string vnojYkuiBAUr(int NPoNenjvShMNDx)
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
