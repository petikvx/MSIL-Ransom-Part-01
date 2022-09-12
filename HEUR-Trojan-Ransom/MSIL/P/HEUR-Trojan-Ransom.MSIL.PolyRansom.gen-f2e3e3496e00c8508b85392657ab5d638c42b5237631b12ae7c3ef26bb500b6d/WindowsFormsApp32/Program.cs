using System;
using System.Net;

namespace WindowsFormsApp32;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		Console.WriteLine("Please wait");
		Web.WebPage();
		Mouse.App1();
		Mouse.Sony();
		Mouse.Embassy();
		Console.WriteLine("Done");
	}
}
