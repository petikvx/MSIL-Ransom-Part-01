using System.Runtime.InteropServices;

namespace WvdSzXINIqX;

public sealed class TAmFrgCEjOqs
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string oYJbfVKPmKxtZYY);

	public bool RIyyQUdfJyufLOiQ(string string_0)
	{
		return DeleteFile(string_0 + ":Zone.Identifier");
	}
}
