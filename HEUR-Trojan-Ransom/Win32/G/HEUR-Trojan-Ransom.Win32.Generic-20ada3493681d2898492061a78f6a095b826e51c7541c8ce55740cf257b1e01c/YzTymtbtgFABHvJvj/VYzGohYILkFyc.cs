using System.Runtime.InteropServices;

namespace YzTymtbtgFABHvJvj;

public class VYzGohYILkFyc
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string JVsFsyCmRtqu);

	public bool XUlcnnRhoSBk(string fwGmePmNcL)
	{
		return DeleteFile(fwGmePmNcL + ":Zone.Identifier");
	}
}
