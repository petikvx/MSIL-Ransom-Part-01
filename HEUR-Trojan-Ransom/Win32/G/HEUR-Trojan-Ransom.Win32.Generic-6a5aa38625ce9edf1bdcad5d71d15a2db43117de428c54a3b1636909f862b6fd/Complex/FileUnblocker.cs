using System.Runtime.InteropServices;

namespace Complex;

public class FileUnblocker
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string name);

	public bool Unblock(string fileName)
	{
		return DeleteFile(fileName + ":Zone.Identifier");
	}
}
