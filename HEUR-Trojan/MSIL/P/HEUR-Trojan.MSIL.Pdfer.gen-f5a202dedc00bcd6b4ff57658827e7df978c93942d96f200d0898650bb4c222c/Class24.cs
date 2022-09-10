using System.Runtime.InteropServices;

internal static class Class24
{
	[DllImport("kernel32.dll")]
	private unsafe static extern bool VirtualProtect(byte* lpAddress, int dwSize, uint flNewProtect, out uint lpflOldProtect);

	public static extern void smethod_0();
}
