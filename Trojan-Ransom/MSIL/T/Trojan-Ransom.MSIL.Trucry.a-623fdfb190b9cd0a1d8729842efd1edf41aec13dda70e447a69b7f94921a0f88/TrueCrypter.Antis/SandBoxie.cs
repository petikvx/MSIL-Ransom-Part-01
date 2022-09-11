using System;
using System.Runtime.InteropServices;

namespace TrueCrypter.Antis;

public class SandBoxie
{
	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	public bool IsSandBoxed()
	{
		if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
		{
			return true;
		}
		return false;
	}
}
