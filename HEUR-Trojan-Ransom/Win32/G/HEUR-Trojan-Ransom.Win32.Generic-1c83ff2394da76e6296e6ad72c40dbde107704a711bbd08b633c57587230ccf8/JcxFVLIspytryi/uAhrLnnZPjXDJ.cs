using System;
using System.Runtime.InteropServices;

namespace JcxFVLIspytryi;

internal static class uAhrLnnZPjXDJ
{
	[Flags]
	private enum YOekAJnziwKWD : uint
	{
		LTYKsmntJSwMsxN = 0x40u,
		riunimUWUOq = 0x80000000u,
		QXJyFogFkHUBEMs = 2u,
		CQgrhFVJIAjW = 1u
	}

	public static void mgPXBdDEDFm()
	{
		SetThreadExecutionState(YOekAJnziwKWD.riunimUWUOq | YOekAJnziwKWD.CQgrhFVJIAjW);
	}

	public static void cwWcrQKSJajgo()
	{
		SetThreadExecutionState(YOekAJnziwKWD.riunimUWUOq);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern YOekAJnziwKWD SetThreadExecutionState(YOekAJnziwKWD VhZGlOMefAus);
}
