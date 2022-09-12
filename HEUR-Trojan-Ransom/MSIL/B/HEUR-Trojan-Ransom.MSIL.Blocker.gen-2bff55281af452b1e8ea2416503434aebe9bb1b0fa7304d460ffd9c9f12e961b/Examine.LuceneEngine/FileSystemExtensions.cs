using System.IO;

namespace Examine.LuceneEngine;

public static class FileSystemExtensions
{
	public static int ClearFiles(this DirectoryInfo di)
	{
		int num = 0;
		di.Refresh();
		if (di.Exists)
		{
			FileInfo[] files = di.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				files[i].Delete();
				num++;
			}
		}
		return num;
	}
}
