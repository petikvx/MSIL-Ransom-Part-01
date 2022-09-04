using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ConS;

[StandardModule]
public sealed class Read
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	public static byte[] Go(string filename, string de)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref filename);
		IntPtr hResInfo = FindResource(moduleHandleA, de, "RT_RCDATA");
		IntPtr source = LoadResource(moduleHandleA, hResInfo);
		int num = SizeofResource(moduleHandleA, hResInfo);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}
}
