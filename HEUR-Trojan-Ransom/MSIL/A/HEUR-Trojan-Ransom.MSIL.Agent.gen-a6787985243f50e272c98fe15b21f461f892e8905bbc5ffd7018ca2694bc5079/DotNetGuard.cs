using System;
using System.Runtime.InteropServices;
using DNGVM.Runtime;

internal class DotNetGuard
{
	public delegate void a(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2);

	private static a C1871907615;

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	private static extern IntPtr LoadLibraryA(string string_0);

	[STAThread]
	public static int C111474055(string[] args)
	{
		return (int)VMEntry.Run(typeof(DotNetGuard).TypeHandle, 2u, new object[1] { args });
	}

	static void DotNetGuard()
	{
		VMEntry.Run(typeof(DotNetGuard).TypeHandle, 3u, new object[0]);
	}
}
