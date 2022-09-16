using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ns14;

internal sealed class Class62
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class63
	{
		public static readonly Class63 class63_0 = new Class63();

		public static Func<FileInfo, long> func_0;

		public static Func<DirectoryInfo, long> func_1;

		internal long _003CDirectorySize_003Eb__2_0(FileInfo fi)
		{
			return fi.Length;
		}

		internal long _003CDirectorySize_003Eb__2_1(DirectoryInfo di)
		{
			return smethod_2(di.FullName);
		}
	}

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

	public static long smethod_2(string string_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		return directoryInfo.GetFiles().Sum((FileInfo fi) => fi.Length) + directoryInfo.GetDirectories().Sum((DirectoryInfo di) => smethod_2(di.FullName));
	}
}
