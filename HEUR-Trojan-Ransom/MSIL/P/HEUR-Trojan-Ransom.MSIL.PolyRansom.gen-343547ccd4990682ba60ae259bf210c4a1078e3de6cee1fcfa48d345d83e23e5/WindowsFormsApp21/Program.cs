using System;

namespace WindowsFormsApp21;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		Console.WriteLine("Please wait");
		Web.WebPage();
		Mouse.App1();
		Mouse.Sony();
		Mouse.Embassy();
		Console.WriteLine("Done");
	}
}
