namespace InstagramApiSharp.Helpers;

public class InstaApiHelper
{
	public static string GetCodeFromId(long id)
	{
		char[] array = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_".ToCharArray();
		string text = string.Empty;
		while (id > 0L)
		{
			long num = id % 64L;
			id = (id - num) / 64L;
			text = array[num] + text;
		}
		return text;
	}
}
