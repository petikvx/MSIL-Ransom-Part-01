using System;
using System.IO;

internal class Class5
{
	public static void m()
	{
		try
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\destroyed.txt");
		}
		catch
		{
		}
		try
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd1.txt");
		}
		catch
		{
		}
		try
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd3.txt");
		}
		catch
		{
		}
		try
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\asd4.txt");
		}
		catch
		{
		}
	}
}
