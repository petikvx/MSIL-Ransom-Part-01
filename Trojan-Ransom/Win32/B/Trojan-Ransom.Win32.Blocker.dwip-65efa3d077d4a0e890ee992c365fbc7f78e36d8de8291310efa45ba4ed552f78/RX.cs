using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class RX
{
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string module);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

	public static byte[] RM()
	{
		ResourceManager resourceManager = new ResourceManager("Encrypted", Assembly.Load(File.ReadAllBytes(Application.get_ExecutablePath())));
		return (byte[])resourceManager.GetObject("encfile");
	}
}
