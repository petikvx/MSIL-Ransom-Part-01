using System;
using System.IO;

public class main
{
	public static string c = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\read.txt");

	public static string textname = "read_me";

	public static string extension = ".bluez";
}
