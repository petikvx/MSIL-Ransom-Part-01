using System;

namespace TRM;

internal static class Program
{
	public static string[] AppArgs;

	[STAThread]
	private static void Main(string[] args)
	{
		AppArgs = args;
		try
		{
			AppManager.Start(args);
		}
		catch (Exception)
		{
		}
	}
}
