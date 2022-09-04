using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

internal class Wtf
{
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string module);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

	public static byte[] Wut()
	{
		ResourceManager resourceManager = new ResourceManager("hjgJhjhVjHv", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject("hbJHbJhVB");
	}
}
