using System;
using System.IO;

public class sex
{
	public static void fuck()
	{
		try
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\read.txt");
		}
		catch
		{
		}
	}
}
