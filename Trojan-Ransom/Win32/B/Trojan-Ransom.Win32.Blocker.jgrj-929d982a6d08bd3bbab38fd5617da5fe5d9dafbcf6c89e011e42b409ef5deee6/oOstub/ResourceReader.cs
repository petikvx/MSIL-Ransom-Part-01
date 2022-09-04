using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace oOstub;

internal class ResourceReader
{
	[DllImport("Kernel32.dll", BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = true)]
	private static extern IntPtr FindResourceEx(IntPtr moduleHandle, int type, string name, ushort language);

	[DllImport("Kernel32.dll", BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = true)]
	private static extern int SizeofResource(IntPtr moduleHandle, IntPtr resInfo);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("Kernel32.dll", BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = true)]
	public static extern IntPtr LoadResource(IntPtr moduleHandle, IntPtr resInfo);

	public static byte[] ReadResource(int type, string subValue, ushort resourceLanaguge)
	{
		string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		IntPtr moduleHandleA = GetModuleHandleA(ref moduleName);
		IntPtr resInfo = FindResourceEx(moduleHandleA, type, subValue, resourceLanaguge);
		IntPtr source = LoadResource(moduleHandleA, resInfo);
		int num = SizeofResource(moduleHandleA, resInfo);
		byte[] array = new byte[checked(num - 1 + 1 - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}
}
