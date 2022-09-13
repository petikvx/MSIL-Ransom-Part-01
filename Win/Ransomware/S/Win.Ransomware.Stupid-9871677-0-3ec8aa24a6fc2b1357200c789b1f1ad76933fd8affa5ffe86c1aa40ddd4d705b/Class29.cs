using System;
using System.IO;
using System.Linq;

internal sealed class Class29
{
	public static void smethod_0(string string_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		if (directoryInfo.Exists)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				smethod_0(directories[i].FullName);
			}
			directoryInfo.Delete(recursive: true);
		}
	}

	public static void smethod_1(string string_0, string string_1)
	{
		try
		{
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			string[] files = Directory.GetFiles(string_0);
			foreach (string obj in files)
			{
				string fileName = Path.GetFileName(obj);
				string destFileName = Path.Combine(string_1, fileName);
				File.Copy(obj, destFileName);
			}
			files = Directory.GetDirectories(string_0);
			foreach (string obj2 in files)
			{
				string fileName2 = Path.GetFileName(obj2);
				string string_2 = Path.Combine(string_1, fileName2);
				smethod_1(obj2, string_2);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	public static long smethod_2(string string_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		return directoryInfo.GetFiles().Sum((FileInfo fi) => fi.Length) + directoryInfo.GetDirectories().Sum((DirectoryInfo di) => smethod_2(di.FullName));
	}
}
