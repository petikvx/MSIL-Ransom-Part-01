using System;
using System.Runtime.InteropServices;

namespace OedchgEuvSrX;

internal static class wlCVKRWvBCU
{
	[Flags]
	private enum BBcNXvmxNXkn : uint
	{
		ZtIJmaHGluh = 0x40u,
		MtepRXArXcYgA = 0x80000000u,
		aRsHtBwLOy = 2u,
		gsXYlwLtCgvEk = 1u
	}

	public static void OlbnNUvraWAkNIM()
	{
		SetThreadExecutionState(BBcNXvmxNXkn.MtepRXArXcYgA | BBcNXvmxNXkn.gsXYlwLtCgvEk);
	}

	public static void wGMyFvLUiQP()
	{
		SetThreadExecutionState(BBcNXvmxNXkn.MtepRXArXcYgA);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern BBcNXvmxNXkn SetThreadExecutionState(BBcNXvmxNXkn QnmkgwGJHhlJUkuM);
}
